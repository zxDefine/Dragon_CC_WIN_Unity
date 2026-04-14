using UnityEngine;

public class UtilsMethods{
	/// <summary>
	/// 根据屏幕比例位置获取X坐标（ratioX 范围建议为 0~1）。
	/// </summary>
	/// <param name="ratioX">屏幕宽度比例位置</param>
	/// <returns>X 坐标</returns>
	public static float GetXFromRatio(float ratioX)
	{
		return (Screen.width * ratioX) - 640;
	}

    /// <summary>
	/// 根据屏幕比例位置获取Y坐标（ratioY 范围建议为 0~1）。
	/// </summary>
	/// <param name="ratioY">屏幕宽度比例位置</param>
	/// <returns>X 坐标</returns>
	public static float GetYFromRatio(float ratioY)
	{
		return (Screen.height * ratioY - 360) * (-1) / 1.11f; 
	}

	public static float ChangeZposToScale(float zpos){
		return 0.018f / 30f * zpos;
	}
}