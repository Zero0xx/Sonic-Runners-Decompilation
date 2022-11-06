using UnityEngine;
using System;

public class CameraManager : MonoBehaviour
{
	[Serializable]
	public class CameraEditParameter
	{
		public float m_upScrollLine;
		public float m_downScrollLine;
		public float m_upScrollLimit;
		public float m_downScrollLimit;
		public float m_downScrollLineOnDown;
	}

	[Serializable]
	public class LaserEditParameter
	{
		public float m_upScrollViewPort;
		public float m_downScrollViewPort;
		public float m_rightScrollViewPort;
		public float m_leftScrollViewPort;
		public float m_fastScrollTime;
		public float m_slowScrollSpeed;
	}

	[Serializable]
	public class JumpBoardEditParameter
	{
		public float m_waitTime;
		public float m_upScrollViewPort;
		public float m_leftScrollViewPort;
		public float m_depthScrollViewPort;
		public float m_scrollTime;
	}

	[Serializable]
	public class CannonEditParameter
	{
		public float m_waitTime;
		public float m_upScrollViewPort;
		public float m_leftScrollViewPort;
		public float m_depthScrollViewPort;
		public float m_scrollTime;
	}

	[Serializable]
	public class LoopTerrainEditParameter
	{
		public float m_waitTime;
		public float m_upScrollViewPort;
		public float m_leftScrollViewPort;
		public float m_depthScrollViewPort;
		public float m_scrollTime;
	}

	[Serializable]
	public class StartActEditParameter
	{
		public Vector3 m_cameraOffset;
		public Vector3 m_targetOffset;
		public float m_nearStayTime;
		public float m_nearToFarTime;
	}

	public Vector3 m_startCameraPos;
	public CameraEditParameter m_editParameter;
	public LaserEditParameter m_laserParameter;
	public JumpBoardEditParameter m_jumpBoardParameter;
	public CannonEditParameter m_cannonParameter;
	public LoopTerrainEditParameter m_loopTerrainParameter;
	public StartActEditParameter m_startActParameter;
	[SerializeField]
	private bool m_drawInfo;
	[SerializeField]
	private bool m_debugInterpolate;
	[SerializeField]
	private float m_debugPushInterpolateTime;
	[SerializeField]
	private float m_debugPopInterpolateTime;
}
