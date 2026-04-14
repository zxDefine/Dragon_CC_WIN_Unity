// M3.6 高斯模糊效果（对应 Renpy 的 blur 属性）
// 用法：在 Material 上设置 _BlurSize（像素半径），通常结合 UI/Image 组件使用
Shader "UI/GaussianBlur"
{
    Properties
    {
        [PerRendererData] _MainTex ("Sprite Texture", 2D) = "white" {}
        _Color ("Tint", Color) = (1,1,1,1)
        _BlurSize ("Blur Size (px)", Range(0, 32)) = 4
        _StencilComp ("Stencil Comparison", Float) = 8
        _Stencil ("Stencil ID", Float) = 0
        _StencilOp ("Stencil Operation", Float) = 0
        _StencilWriteMask ("Stencil Write Mask", Float) = 255
        _StencilReadMask ("Stencil Read Mask", Float) = 255
        _ColorMask ("Color Mask", Float) = 15
    }

    SubShader
    {
        Tags
        {
            "Queue"="Transparent"
            "IgnoreProjector"="True"
            "RenderType"="Transparent"
            "PreviewType"="Plane"
            "CanUseSpriteAtlas"="True"
        }

        Stencil
        {
            Ref [_Stencil]
            Comp [_StencilComp]
            Pass [_StencilOp]
            ReadMask [_StencilReadMask]
            WriteMask [_StencilWriteMask]
        }

        Cull Off
        Lighting Off
        ZWrite Off
        ZTest [unity_GUIZTestMode]
        Blend SrcAlpha OneMinusSrcAlpha
        ColorMask [_ColorMask]

        Pass
        {
            Name "GaussianBlur"
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #include "UnityCG.cginc"

            struct appdata
            {
                float4 vertex : POSITION;
                float2 uv : TEXCOORD0;
                float4 color : COLOR;
            };

            struct v2f
            {
                float4 pos : SV_POSITION;
                float2 uv : TEXCOORD0;
                float4 color : COLOR;
            };

            sampler2D _MainTex;
            float4 _MainTex_TexelSize;
            fixed4 _Color;
            float _BlurSize;

            v2f vert(appdata v)
            {
                v2f o;
                o.pos = UnityObjectToClipPos(v.vertex);
                o.uv = v.uv;
                o.color = v.color * _Color;
                return o;
            }

            // 9-tap 近似高斯核 (σ 随 _BlurSize 缩放)
            fixed4 frag(v2f i) : SV_Target
            {
                float2 texel = _MainTex_TexelSize.xy * _BlurSize;
                // 9 个采样点 + 权重（接近 Gaussian σ=1.5）
                fixed4 sum = tex2D(_MainTex, i.uv) * 0.2270270270;
                sum += tex2D(_MainTex, i.uv + float2( texel.x,  0)) * 0.1945945946;
                sum += tex2D(_MainTex, i.uv + float2(-texel.x,  0)) * 0.1945945946;
                sum += tex2D(_MainTex, i.uv + float2( 0,  texel.y)) * 0.1216216216;
                sum += tex2D(_MainTex, i.uv + float2( 0, -texel.y)) * 0.1216216216;
                sum += tex2D(_MainTex, i.uv + texel) * 0.0540540541;
                sum += tex2D(_MainTex, i.uv - texel) * 0.0540540541;
                sum += tex2D(_MainTex, i.uv + float2( texel.x, -texel.y)) * 0.0162162162;
                sum += tex2D(_MainTex, i.uv + float2(-texel.x,  texel.y)) * 0.0162162162;
                return sum * i.color;
            }
            ENDCG
        }
    }

    Fallback "UI/Default"
}
