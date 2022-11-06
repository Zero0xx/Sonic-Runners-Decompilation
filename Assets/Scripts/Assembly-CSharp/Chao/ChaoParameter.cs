using System;
using UnityEngine;

namespace Chao
{
	[Serializable]
	public class ChaoParameter : MonoBehaviour
	{
		[SerializeField]
		private int m_mainChaoId;
		[SerializeField]
		private int m_mainChaoLevel;
		[SerializeField]
		private int m_subChaoId;
		[SerializeField]
		private int m_subChaoLevel;
		public ChaoParameterData m_data;
	}
}
