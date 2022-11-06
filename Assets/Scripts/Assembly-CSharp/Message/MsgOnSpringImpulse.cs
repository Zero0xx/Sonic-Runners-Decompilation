using UnityEngine;

namespace Message
{
	public class MsgOnSpringImpulse : MessageBase
	{
		public Vector3 m_position;
		public Quaternion m_rotation;
		public float m_firstSpeed;
		public float m_outOfControl;
		public bool m_succeed;
	}
}
