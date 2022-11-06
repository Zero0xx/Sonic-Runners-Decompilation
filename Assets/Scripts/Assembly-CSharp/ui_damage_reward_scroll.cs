using UnityEngine;

public class ui_damage_reward_scroll : MonoBehaviour
{
	[SerializeField]
	private UITexture m_faceTexture;
	[SerializeField]
	private UISprite m_scoreRankIconSprite;
	[SerializeField]
	private UISprite m_friendIconSprite;
	[SerializeField]
	private UISprite m_charaSprite;
	[SerializeField]
	private UITexture m_mainChaoIcon;
	[SerializeField]
	private UITexture m_subChaoIcon;
	[SerializeField]
	private UISprite m_chao1BgSprite;
	[SerializeField]
	private UISprite m_chao2BgSprite;
	[SerializeField]
	private UILabel m_nameLabel;
	[SerializeField]
	private UILabel m_damageLabel;
	[SerializeField]
	private UILabel m_damageRateLabel;
	[SerializeField]
	private UISlider m_damage;
	[SerializeField]
	private UISprite m_destroyIcon;
	[SerializeField]
	private UILabel m_destroyCountLabel;
	[SerializeField]
	private TweenColor[] m_myRanker;
}
