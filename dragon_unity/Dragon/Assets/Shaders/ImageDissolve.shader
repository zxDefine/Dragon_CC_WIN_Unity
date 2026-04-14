// ImageDissolve Shader — 遮罩溶解转场效果
// 对应 Renpy 的 ImageDissolve(mask, time, ramplen, reverse)
// 用于 blink（睁眼/闭眼）和 trans_rip（波纹）转场
//
// 原理：使用灰度遮罩纹理控制像素的溶解顺序。
// 遮罩中较亮的像素先显露，较暗的后显露（reverse=false 时）。
// _Progress 从 0→1 时，画面从完全遮挡→完全显露。
// _Ramplen 控制过渡边缘的柔和度。

Shader "UI/ImageDissolve"
{
    Properties
    {
        [PerRendererData] _MainTex ("Sprite Texture", 2D) = "white" {}
        _MaskTex ("Dissolve Mask", 2D) = "white" {}
        _Progress ("Dissolve Progress", Range(0, 1)) = 0
        _Ramplen ("Edge Softness", Range(0.001, 0.5)) = 0.1
        _OverlayColor ("Overlay Color", Color) = (0, 0, 0, 1)
        [Toggle] _Reverse ("Reverse Direction", Float) = 0

        // UI 必需属性
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
            "Queue"="Overlay"
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
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #include "UnityCG.cginc"
            #include "UnityUI.cginc"

            struct appdata
            {
                float4 vertex : POSITION;
                float2 uv : TEXCOORD0;
                float4 color : COLOR;
            };

            struct v2f
            {
                float2 uv : TEXCOORD0;
                float4 vertex : SV_POSITION;
                float4 color : COLOR;
            };

            sampler2D _MainTex;
            sampler2D _MaskTex;
            float _Progress;
            float _Ramplen;
            float4 _OverlayColor;
            float _Reverse;

            v2f vert(appdata v)
            {
                v2f o;
                o.vertex = UnityObjectToClipPos(v.vertex);
                o.uv = v.uv;
                o.color = v.color;
                return o;
            }

            fixed4 frag(v2f i) : SV_Target
            {
                // 采样遮罩灰度值
                float mask = tex2D(_MaskTex, i.uv).r;

                // reverse 模式：闭眼时反转遮罩
                if (_Reverse > 0.5)
                    mask = 1.0 - mask;

                // 计算当前像素的 alpha
                // 当 progress=0 时，alpha=1（完全覆盖/遮挡）
                // 当 progress=1 时，alpha=0（完全显露）
                // smoothstep 提供平滑的边缘过渡
                float edge = smoothstep(_Progress - _Ramplen, _Progress + _Ramplen, mask);

                // 输出：覆盖颜色 + 由遮罩控制的 alpha
                return fixed4(_OverlayColor.rgb, edge * _OverlayColor.a);
            }
            ENDCG
        }
    }
}
