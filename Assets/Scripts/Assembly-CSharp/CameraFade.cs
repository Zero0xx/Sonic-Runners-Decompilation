using UnityEngine;

public class CameraFade : MonoBehaviour
{
	public GUIStyle m_BackgroundStyle;
	public Texture2D m_FadeTexture;
	public Color m_CurrentScreenOverlayColor;
	public Color m_TargetScreenOverlayColor;
	public Color m_DeltaColor;
	public int m_FadeGUIDepth;
	public float m_FadeDelay;
}
