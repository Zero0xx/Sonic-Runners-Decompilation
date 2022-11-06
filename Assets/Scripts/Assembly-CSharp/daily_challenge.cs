using UnityEngine;
using System;
using System.Collections.Generic;

public class daily_challenge : MonoBehaviour
{
	[Serializable]
	private class InspectorUi
	{
		[SerializeField]
		public GameObject m_clearGameObject;
		[SerializeField]
		public Animation m_clearAnimation;
		[SerializeField]
		public GameObject m_dayObjectOrg;
		[SerializeField]
		public GameObject m_dayBigObjectOrg;
		[SerializeField]
		public GameObject m_dayObjectBase;
		[SerializeField]
		public List<Color> m_dayObjectColors;
	}

	[SerializeField]
	private InspectorUi m_inspectorUi;
}
