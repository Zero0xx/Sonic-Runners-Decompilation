using UnityEngine;
using System.Collections.Generic;

public class RankingUI : MonoBehaviour
{
	[SerializeField]
	private Color m_quickModeColor1;
	[SerializeField]
	private Color m_quickModeColor2;
	[SerializeField]
	private Color m_endlessModeColor1;
	[SerializeField]
	private Color m_endlessModeColor2;
	[SerializeField]
	private List<UISprite> m_colorObjects1;
	[SerializeField]
	private List<UISprite> m_colorObjects2;
	[SerializeField]
	private GameObject m_loading;
	[SerializeField]
	private GameObject m_facebook;
	[SerializeField]
	private GameObject m_pattern0;
	[SerializeField]
	private UIRectItemStorage m_pattern0MyDataArea;
	[SerializeField]
	private UIRectItemStorage m_pattern0TopRankerArea;
	[SerializeField]
	private GameObject m_pattern0More;
	[SerializeField]
	private GameObject m_pattern1;
	[SerializeField]
	private UIRectItemStorageRanking m_pattern1ListArea;
	[SerializeField]
	private UIDraggablePanel m_pattern1MainListPanel;
	[SerializeField]
	private GameObject m_pattern2;
	[SerializeField]
	private UIRectItemStorageRanking m_pattern2ListArea;
	[SerializeField]
	private UIDraggablePanel m_pattern2MainListPanel;
	[SerializeField]
	private GameObject m_parts;
	[SerializeField]
	private GameObject m_partsTabNormal;
	[SerializeField]
	private GameObject m_partsTabRival;
	[SerializeField]
	private GameObject m_partsTabFriend;
	[SerializeField]
	private UILabel m_partsInfo;
	[SerializeField]
	private UIImageButton[] m_partsBtns;
	[SerializeField]
	private UISprite m_partsRankIcon0;
	[SerializeField]
	private UISprite m_partsRankIcon1;
	[SerializeField]
	private UILabel m_partsRankText;
	[SerializeField]
	private UILabel m_partsRankTextEx;
	[SerializeField]
	private GameObject m_tallying;
	[SerializeField]
	private UIToggle m_partsTabNormalTogglH;
	[SerializeField]
	private UIToggle m_partsTabNormalTogglT;
	[SerializeField]
	private UIToggle m_partsTabRivalTogglH;
	[SerializeField]
	private UIToggle m_partsTabRivalTogglT;
	[SerializeField]
	private UIToggle m_partsTabFriendTogglH;
	[SerializeField]
	private UIToggle m_partsTabFriendTogglT;
	[SerializeField]
	private List<UIToggle> m_partsBtnToggls;
	[SerializeField]
	private ranking_help m_help;
}
