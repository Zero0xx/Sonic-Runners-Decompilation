using UnityEngine;

public class PresentBoxUI : MonoBehaviour
{
	[SerializeField]
	private UIRectItemStorage m_itemStorage;
	[SerializeField]
	private UIScrollBar m_scrollBar;
	[SerializeField]
	private UILabel m_recieveAllLabel;
	[SerializeField]
	private UILabel m_recieveSelectLabel;
	[SerializeField]
	private UILabel m_infoLabel;
	[SerializeField]
	private UILabel m_nextPageLabel;
	[SerializeField]
	private UILabel m_prevPageLabel;
	[SerializeField]
	private UILabel m_numPageLabel;
	[SerializeField]
	private GameObject m_recieveAllBtnObj;
	[SerializeField]
	private GameObject m_recieveSelectBtnObj;
	[SerializeField]
	private GameObject m_nextPageBtnObj;
	[SerializeField]
	private GameObject m_prevPageBtnObj;
}
