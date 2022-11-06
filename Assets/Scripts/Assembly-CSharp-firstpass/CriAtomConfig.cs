using System;

[Serializable]
public class CriAtomConfig
{
	[Serializable]
	public class StandardVoicePoolConfig
	{
		public int memoryVoices;
		public int streamingVoices;
	}

	[Serializable]
	public class HcaMxVoicePoolConfig
	{
		public int memoryVoices;
		public int streamingVoices;
	}

	[Serializable]
	public class AndroidLowLatencyStandardVoicePoolConfig
	{
		public int memoryVoices;
		public int streamingVoices;
	}

	[Serializable]
	public class VitaAtrac9VoicePoolConfig
	{
		public int memoryVoices;
		public int streamingVoices;
	}

	[Serializable]
	public class Ps4Atrac9VoicePoolConfig
	{
		public int memoryVoices;
		public int streamingVoices;
	}

	public string acfFileName;
	public int maxVirtualVoices;
	public StandardVoicePoolConfig standardVoicePoolConfig;
	public HcaMxVoicePoolConfig hcaMxVoicePoolConfig;
	public int outputSamplingRate;
	public bool usesInGamePreview;
	public float serverFrequency;
	public bool useRandomSeedWithTime;
	public int iosBufferingTime;
	public bool iosOverrideIPodMusic;
	public int androidBufferingTime;
	public int androidStartBufferingTime;
	public bool androidEnableAudioLatencyCheck;
	public AndroidLowLatencyStandardVoicePoolConfig androidLowLatencyStandardVoicePoolConfig;
	public VitaAtrac9VoicePoolConfig vitaAtrac9VoicePoolConfig;
	public Ps4Atrac9VoicePoolConfig ps4Atrac9VoicePoolConfig;
}
