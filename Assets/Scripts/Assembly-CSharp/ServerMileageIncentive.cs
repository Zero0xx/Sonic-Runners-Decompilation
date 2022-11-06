public class ServerMileageIncentive
{
	public enum Type
	{
		NONE = 0,
		POINT = 1,
		CHAPTER = 2,
		EPISODE = 3,
		FRIEND = 4,
	}

	public Type m_type;
	public int m_itemId;
	public int m_num;
	public int m_pointId;
	public string m_friendId;
}
