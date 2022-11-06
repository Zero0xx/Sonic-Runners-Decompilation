using UnityEngine;

public class CriAtomSource : MonoBehaviour
{
	[SerializeField]
	private bool _playOnStart;
	[SerializeField]
	private string _cueName;
	[SerializeField]
	private string _cueSheet;
	[SerializeField]
	private bool _use3dPositioning;
	[SerializeField]
	private bool _loop;
	[SerializeField]
	private float _volume;
	[SerializeField]
	private float _pitch;
	[SerializeField]
	private bool _androidUseLowLatencyVoicePool;
	[SerializeField]
	private bool need_to_player_update_all;
}
