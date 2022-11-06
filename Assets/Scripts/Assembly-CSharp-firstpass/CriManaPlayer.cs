using UnityEngine;

public class CriManaPlayer : MonoBehaviour
{
	[SerializeField]
	private Material _movieMaterial;
	[SerializeField]
	private uint _texNumber;
	[SerializeField]
	private string _moviePath;
	[SerializeField]
	private bool _playOnStart;
	[SerializeField]
	private bool _loop;
	[SerializeField]
	private float _volume;
	[SerializeField]
	private float _subAudioVolume;
	[SerializeField]
	private float _speed;
	[SerializeField]
	private bool _additiveMode;
	[SerializeField]
	private bool _flipTopBottom;
	[SerializeField]
	private bool _flipLeftRight;
}
