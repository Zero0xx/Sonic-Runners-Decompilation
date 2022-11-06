using UnityEngine;

namespace Message
{
	public class MsgWarpPlayer : MessageBase
	{
		public Vector3 m_position;
		public Quaternion m_rotation;
		public bool m_hold;
	}
}
