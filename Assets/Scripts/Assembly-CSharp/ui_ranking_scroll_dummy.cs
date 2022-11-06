using UnityEngine;

public class ui_ranking_scroll_dummy : MonoBehaviour
{
	[SerializeField]
	private UIDragPanelContents dragPanelContent;
	[SerializeField]
	private UISprite dummySprite;
	[SerializeField]
	private UIButtonMessage button;
	[SerializeField]
	private UILabel label;
	public UIRectItemStorageRanking storage;
	public SpecialStageWindow spWindow;
	public RankingUI rankingUI;
	public RankingUtil.RankingScoreType scoreType;
	public RankingUtil.RankingRankerType rankerType;
	public bool end;
	public bool top;
	public int slot;
}
