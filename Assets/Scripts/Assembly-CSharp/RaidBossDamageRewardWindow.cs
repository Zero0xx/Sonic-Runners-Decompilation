using UnityEngine;

public class RaidBossDamageRewardWindow : WindowBase
{
	[SerializeField]
	private UIPanel mainPanel;
	[SerializeField]
	private Animation m_animation;
	[SerializeField]
	private UIDraggablePanel m_listPanel;
	[SerializeField]
	private GameObject m_topInfo;
	[SerializeField]
	private GameObject m_topReward;
	[SerializeField]
	private UILabel m_topRewardItem;
	[SerializeField]
	private UILabel m_headerLabel;
}
