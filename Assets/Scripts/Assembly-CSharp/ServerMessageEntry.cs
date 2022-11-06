public class ServerMessageEntry
{
	public enum MessageType
	{
		RequestEnergy = 0,
		ReturnRequestEnergy = 1,
		SendEnergy = 2,
		ReturnSendEnergy = 3,
		LentChao = 4,
		InviteCode = 5,
		Unknown = -1,
	}

	public enum MessageState
	{
		Unread = 0,
		Read = 1,
		Used = 2,
		Deleted = 3,
	}

	public int m_messageId;
	public MessageType m_messageType;
	public string m_fromId;
	public string m_name;
	public string m_url;
	public MessageState m_messageState;
	public int m_expireTiem;
}
