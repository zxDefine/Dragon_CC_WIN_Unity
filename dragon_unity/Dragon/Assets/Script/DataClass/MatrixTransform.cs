using UnityEngine;

/// <summary>
/// 3D 矩阵变换数据类，对应 Renpy ATL 的 matrixtransform 属性。
/// 存储缩放、旋转、偏移三组 3D 向量参数。
/// </summary>
/// <remarks>
/// 对应 Renpy 原版功能：matrixtransform ScaleMatrix(x,y,z)*RotateMatrix(x,y,z)*OffsetMatrix(x,y,z)
/// 用于实现立绘/CG 的 3D 透视变换效果（缩放、旋转、平移）。
/// M1 阶段仅作为数据载体，实际渲染效果由 M3 的着色器系统实现。
/// </remarks>
public class MatrixTransform
{
    /// <summary>缩放向量 (x, y, z)</summary>
    private Vector3 _scaleMatrix;

    /// <summary>旋转向量 (x, y, z)，单位为度</summary>
    private Vector3 _rotateMatrix;

    /// <summary>偏移向量 (x, y, z)，世界坐标偏移</summary>
    private Vector3 _offsetMatrix;

    /// <summary>
    /// 构造一个 3D 矩阵变换对象。
    /// </summary>
    /// <param name="ScaleMatrix">缩放向量</param>
    /// <param name="RotateMatrix">旋转向量（度）</param>
    /// <param name="OffsetMatrix">偏移向量</param>
    public MatrixTransform(Vector3 ScaleMatrix, Vector3 RotateMatrix, Vector3 OffsetMatrix)
    {
        _scaleMatrix = ScaleMatrix;
        _rotateMatrix = RotateMatrix;
        _offsetMatrix = OffsetMatrix;
    }

    /// <summary>缩放向量只读访问器</summary>
    public Vector3 ScaleMatrix => _scaleMatrix;

    /// <summary>旋转向量只读访问器</summary>
    public Vector3 RotateMatrix => _rotateMatrix;

    /// <summary>偏移向量只读访问器</summary>
    public Vector3 OffsetMatrix => _offsetMatrix;
}
