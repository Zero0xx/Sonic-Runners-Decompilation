using UnityEngine;

public class StageModeManager : MonoBehaviour
{
	public enum Mode
	{
		ENDLESS = 0,
		QUICK = 1,
		UNKNOWN = 2,
	}

	public bool m_debugFlag;
	public bool m_firstTutorial;
	public Mode m_mode;
}
