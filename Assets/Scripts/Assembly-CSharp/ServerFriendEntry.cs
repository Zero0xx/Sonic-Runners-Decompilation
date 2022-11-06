public class ServerFriendEntry
{
	public enum FriendStateFlags
	{
		None = 0,
		SentEnergy = 1,
		RequestedEnergy = 2,
		Invited = 4,
	}

	public string m_mid;
	public string m_name;
	public string m_url;
	public FriendStateFlags m_stateFlags;
}
