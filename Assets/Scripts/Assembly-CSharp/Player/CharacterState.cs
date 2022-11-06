using UnityEngine;

namespace Player
{
	public class CharacterState : MonoBehaviour
	{
		public CharacterInput m_input;
		[SerializeField]
		private float m_defaultSpeed;
		[SerializeField]
		private bool m_notLoadCharaParameter;
		public float m_hitWallTimer;
		public bool m_isEdit;
		public bool m_notDeadNoRing;
		public bool m_noCrushDead;
		public bool m_notDropRing;
	}
}
