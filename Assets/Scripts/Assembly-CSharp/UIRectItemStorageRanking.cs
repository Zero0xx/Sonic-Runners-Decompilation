using UnityEngine;

public class UIRectItemStorageRanking : MonoBehaviour
{
	public enum ActiveType
	{
		ACTIVE = 0,
		NOT_ACTTIVE = 1,
		DEFAULT = 2,
	}

	public RankingUtil.RankingRankerType rankingType;
	public UIDraggablePanel parentPanel;
	[SerializeField]
	private bool isDirectionVertical;
	public int maxItemCount;
	public GameObject template;
	public GameObject templateDummy;
	public int spacing;
	public int padding;
	public ActiveType m_activeType;
}
