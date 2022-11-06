using UnityEngine;
using System.Collections.Generic;

public class RouletteStandardPart : RoulettePartsBase
{
	[SerializeField]
	private Animation m_wordAnim;
	[SerializeField]
	private GameObject m_wordGet;
	[SerializeField]
	private GameObject m_wordRankup;
	[SerializeField]
	private GameObject m_wordJackpot;
	[SerializeField]
	private GameObject m_wordLavel;
	[SerializeField]
	private GameObject m_spEgg;
	[SerializeField]
	private List<GameObject> m_Eggs;
	[SerializeField]
	private GameObject m_backButton;
	[SerializeField]
	private GameObject m_oddsButton;
	[SerializeField]
	private List<GameObject> m_spinButtons;
	[SerializeField]
	private GameObject m_costBase;
	[SerializeField]
	private GameObject m_eventUI;
	[SerializeField]
	private GameObject m_frontCollider;
	[SerializeField]
	private Animation m_fadeAnime;
}
