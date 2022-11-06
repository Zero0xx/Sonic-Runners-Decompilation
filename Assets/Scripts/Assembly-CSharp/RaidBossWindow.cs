using UnityEngine;

public class RaidBossWindow : EventWindowBase
{
	[SerializeField]
	private UIPanel mainPanel;
	[SerializeField]
	private Animation m_animation;
	[SerializeField]
	private UIDraggablePanel m_listPanel;
	[SerializeField]
	private UILabel m_crushCount;
	[SerializeField]
	private UILabel m_raidRingCount;
	[SerializeField]
	private RaidEnergyStorage m_energy;
	[SerializeField]
	private GameObject m_advent;
	[SerializeField]
	private UITexture m_bgTexture;
	[SerializeField]
	private GameObject eventEndObject;
}
