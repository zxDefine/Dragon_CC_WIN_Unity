// M3.6 色彩矩阵变换（对应 Renpy 的 matrixcolor: InvertMatrix*ContrastMatrix*SaturationMatrix*BrightnessMatrix*HueMatrix）
// 用法：在 Material 上设置 _Invert / _Contrast / _Saturation / _Brightness / _Hue
// 注：Hue 以角度为单位（0~360）
Shader "UI/MatrixColor"
{
    Properties
    {
        [PerRendererData] _MainTex ("Sprite Texture", 2D) = "white" {}
        _Color ("Tint", Color) = (1,1,1,1)
        _Invert ("Invert (0-1)", Range(0, 1)) = 0
        _Contrast ("Contrast", Range(0, 4)) = 1
        _Saturation ("Saturation", Range(0, 4)) = 1
        _Brightness ("Brightness", Range(-1, 1)) = 0
        _Hue ("Hue (deg)", Range(0, 360)) = 0
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
            Name "MatrixColor"
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
            fixed4 _Color;
            float _Invert;
            float _Contrast;
            float _Saturation;
            float _Brightness;
            float _Hue;

            v2f vert(appdata v)
            {
                v2f o;
                o.pos = UnityObjectToClipPos(v.vertex);
                o.uv = v.uv;
                o.color = v.color * _Color;
                return o;
            }

            // 标准亮度系数 (ITU-R BT.709)
            static const float3 LUMA = float3(0.2126, 0.7152, 0.0722);

            // HSV 转换辅助（用于 Hue 偏移）
            float3 HueShift(float3 rgb, float deg)
            {
                float rad = radians(deg);
                float cosA = cos(rad);
                float sinA = sin(rad);
                // 绕 (1,1,1) 轴旋转 RGB 空间的标准矩阵
                float3x3 m = float3x3(
                    cosA + (1.0 - cosA) / 3.0,
                    (1.0 - cosA) / 3.0 - sqrt(1.0/3.0) * sinA,
                    (1.0 - cosA) / 3.0 + sqrt(1.0/3.0) * sinA,
                    (1.0 - cosA) / 3.0 + sqrt(1.0/3.0) * sinA,
                    cosA + (1.0 - cosA) / 3.0,
                    (1.0 - cosA) / 3.0 - sqrt(1.0/3.0) * sinA,
                    (1.0 - cosA) / 3.0 - sqrt(1.0/3.0) * sinA,
                    (1.0 - cosA) / 3.0 + sqrt(1.0/3.0) * sinA,
                    cosA + (1.0 - cosA) / 3.0
                );
                return mul(m, rgb);
            }

            fixed4 frag(v2f i) : SV_Target
            {
                fixed4 c = tex2D(_MainTex, i.uv) * i.color;
                float3 rgb = c.rgb;

                // 1. Invert
                rgb = lerp(rgb, 1.0 - rgb, _Invert);
                // 2. Hue
                if (abs(_Hue) > 0.001) rgb = HueShift(rgb, _Hue);
                // 3. Saturation
                float gray = dot(rgb, LUMA);
                rgb = lerp(float3(gray, gray, gray), rgb, _Saturation);
                // 4. Contrast（绕中灰 0.5）
                rgb = (rgb - 0.5) * _Contrast + 0.5;
                // 5. Brightness（加法）
                rgb += _Brightness;

                return fixed4(saturate(rgb), c.a);
            }
            ENDCG
        }
    }

    Fallback "UI/Default"
}
