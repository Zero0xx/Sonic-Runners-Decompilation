using UnityEngine;
using System.Collections.Generic;

public class RouletteBoard : RoulettePartsBase
{
	[SerializeField]
	private GameObject m_arrow;
	[SerializeField]
	private List<RouletteBoardPattern> m_pattern;
	[SerializeField]
	private RouletteItem m_orgRouletteItem;
}
