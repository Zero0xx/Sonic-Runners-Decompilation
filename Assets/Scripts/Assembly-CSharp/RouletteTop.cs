using UnityEngine;
using System.Collections.Generic;

public class RouletteTop : CustomGameObject
{
	[SerializeField]
	private Color m_premiumColor;
	[SerializeField]
	private Color m_specialColor;
	[SerializeField]
	private Color m_defaultColor;
	[SerializeField]
	private RouletteBoard m_orgRouletteBoard;
	[SerializeField]
	private RouletteStandardPart m_orgStdPartsBoard;
	[SerializeField]
	private Animation m_animation;
	[SerializeField]
	private List<UIPanel> m_panels;
	[SerializeField]
	private GameObject m_topPageObject;
	[SerializeField]
	private GameObject m_rouletteBase;
	[SerializeField]
	private GameObject m_stdPartsBase;
	[SerializeField]
	private GameObject m_buttonsBase;
	[SerializeField]
	private GameObject m_buttonsBaseBg;
	[SerializeField]
	private window_odds m_odds;
	[SerializeField]
	public Texture m_itemRouletteDefaultTexture;
}
