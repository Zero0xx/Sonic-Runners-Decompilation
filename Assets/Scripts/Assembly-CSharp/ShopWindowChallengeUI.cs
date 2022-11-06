using UnityEngine;

public class ShopWindowChallengeUI : MonoBehaviour
{
	[SerializeField]
	private GameObject[] m_itemsGameObject;
	[SerializeField]
	private GameObject m_panelGameObject;
	[SerializeField]
	public UILabel m_quantityLabel;
	[SerializeField]
	public UILabel m_costLabel;
	[SerializeField]
	public GameObject m_bonusGameObject;
	[SerializeField]
	public UILabel[] m_bonusLabels;
	[SerializeField]
	public UISprite m_saleSprite;
	[SerializeField]
	public UILabel m_presentLabel;
}
