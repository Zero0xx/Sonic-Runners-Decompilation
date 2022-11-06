namespace Message
{
	public class MsgInvincible : MessageBase
	{
		public enum Mode
		{
			Start = 0,
			End = 1,
		}

		public Mode m_mode;
	}
}
