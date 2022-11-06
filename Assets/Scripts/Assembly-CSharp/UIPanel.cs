using UnityEngine;

public class UIPanel : MonoBehaviour
{
	public bool showInPanelTool;
	public bool generateNormals;
	public bool widgetsAreStatic;
	public bool cullWhileDragging;
	public Matrix4x4 worldToLocal;
	[SerializeField]
	private float mAlpha;
	[SerializeField]
	private UIDrawCall.Clipping mClipping;
	[SerializeField]
	private Vector4 mClipRange;
	[SerializeField]
	private Vector2 mClipSoftness;
	[SerializeField]
	private int mDepth;
}
