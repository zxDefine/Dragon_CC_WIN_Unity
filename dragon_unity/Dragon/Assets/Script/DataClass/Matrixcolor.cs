/// <summary>
/// Renpy Matrixcolor 颜色矩阵数据类，存储图像后处理的各项矩阵参数
/// </summary>
/// <remarks>
/// 对应 Renpy 的 matrixcolor 属性，用于控制图像的反转、对比度、饱和度、亮度和色相变换。
/// </remarks>
public class Matrixcolor
{
        private float _invertMatrix;
        private float _contrastMatrix;
        private float _saturationMatrix;
        private float _brightnessMatrix;
        private float _hueMatrix;

        /// <summary>反转矩阵参数，0 为正常，1 为完全反转</summary>
        public float InvertMatrix => _invertMatrix;

        /// <summary>对比度矩阵参数，1.0 为原始对比度</summary>
        public float ContrastMatrix => _contrastMatrix;

        /// <summary>饱和度矩阵参数，1.0 为原始饱和度，0 为灰度</summary>
        public float SaturationMatrix => _saturationMatrix;

        /// <summary>亮度矩阵参数，1.0 为原始亮度</summary>
        public float BrightnessMatrix => _brightnessMatrix;

        /// <summary>色相旋转矩阵参数，以角度为单位</summary>
        public float HueMatrix => _hueMatrix;

        /// <summary>
        /// 构造 Matrixcolor 实例
        /// </summary>
        /// <param name="invertMatrix">反转矩阵值</param>
        /// <param name="contrastMatrix">对比度矩阵值</param>
        /// <param name="saturationMatrix">饱和度矩阵值</param>
        /// <param name="brightnessMatrix">亮度矩阵值</param>
        /// <param name="hueMatrix">色相矩阵值</param>
        public Matrixcolor(float invertMatrix, float contrastMatrix, float saturationMatrix, float brightnessMatrix,
                float hueMatrix)
        {
                _invertMatrix = invertMatrix;
                _contrastMatrix = contrastMatrix;
                _saturationMatrix = saturationMatrix;
                _brightnessMatrix = brightnessMatrix;
                _hueMatrix = hueMatrix;
        }
}