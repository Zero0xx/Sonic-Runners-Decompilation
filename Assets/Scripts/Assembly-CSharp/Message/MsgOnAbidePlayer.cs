using UnityEngine;

namespace Message
{
	public class MsgOnAbidePlayer : MessageBase
	{
		public Vector3 m_position;
		public Quaternion m_rotation;
		public float m_height;
		public GameObject m_abideObject;
		public bool m_succeed;
	}
}
