// M3.6 Glitch 故障效果（电子干扰风格）
// 用法：_Strength 控制总强度，_Time 由 Material.SetFloat 每帧更新（或直接用 _Time.y）
Shader "UI/Glitch"
{
    Properties
    {
        [PerRendererData] _MainTex ("Sprite Texture", 2D) = "white" {}
        _Color ("Tint", Color) = (1,1,1,1)
        _Strength ("Strength", Range(0, 1)) = 0.3
        _ScanlineIntensity ("Scanline Intensity", Range(0, 1)) = 0.1
        _ChromaticAberration ("Chromatic Aberration (px)", Range(0, 32)) = 4
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
            Name "Glitch"
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
            float _Strength;
            float _ScanlineIntensity;
            float _ChromaticAberration;

            v2f vert(appdata v)
            {
                v2f o;
                o.pos = UnityObjectToClipPos(v.vertex);
                o.uv = v.uv;
                o.color = v.color * _Color;
                return o;
            }

            // 伪随机数（基于坐标 + 时间）
            float rand(float2 co)
            {
                return frac(sin(dot(co, float2(12.9898, 78.233))) * 43758.5453);
            }

            fixed4 frag(v2f i) : SV_Target
            {
                float2 uv = i.uv;
                float time = _Time.y;

                // 条带抖动：对 y 方向做块级位移
                float band = floor(uv.y * 32.0 + time * 8.0);
                float bandRand = rand(float2(band, time));
                float shift = (bandRand - 0.5) * 0.05 * _Strength * step(0.7, bandRand);
                uv.x += shift;

                // 色彩像差（红蓝通道偏移）
                float2 aberrOffset = _MainTex_TexelSize.xy * _ChromaticAberration * _Strength;
                float r = tex2D(_MainTex, uv + float2(aberrOffset.x, 0)).r;
                float g = tex2D(_MainTex, uv).g;
                float b = tex2D(_MainTex, uv - float2(aberrOffset.x, 0)).b;
                float a = tex2D(_MainTex, uv).a;

                fixed4 c = fixed4(r, g, b, a) * i.color;

                // 扫描线
                float scan = sin(uv.y * 800.0 + time * 20.0) * 0.5 + 0.5;
                c.rgb *= 1.0 - scan * _ScanlineIntensity;

                return c;
            }
            ENDCG
        }
    }

    Fallback "UI/Default"
}
