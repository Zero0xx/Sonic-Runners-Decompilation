using System;
using UnityEngine;

namespace Chao
{
	[Serializable]
	public class ChaoSetupParameterData
	{
		[SerializeField]
		private Vector3 m_mainOffset;
		[SerializeField]
		private Vector3 m_subOffset;
		[SerializeField]
		private float m_colliRadius;
		[SerializeField]
		private Vector3 m_colliCenter;
		[SerializeField]
		private ChaoMovementType m_movementType;
		[SerializeField]
		private ChaoHoverType m_hoverType;
		[SerializeField]
		private bool m_useCustomHoverParam;
		[SerializeField]
		private float m_hoverSpeedDegree;
		[SerializeField]
		private float m_hoverHeight;
		[SerializeField]
		private float m_hoverStartDegreeMain;
		[SerializeField]
		private float m_hoverStartDegreeSub;
		[SerializeField]
		private ShaderType m_shaderType;
	}
}
