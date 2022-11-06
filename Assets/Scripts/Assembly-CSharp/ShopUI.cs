using UnityEngine;
using System;

public class ShopUI : MonoBehaviour
{
	[Serializable]
	public class EexchangeItem
	{
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
		public UILabel m_saleQuantityLabel;
	}

	[Serializable]
	private class EexchangeType
	{
		[SerializeField]
		public ShopUI.EexchangeItem[] m_exchangeItems;
	}

	[SerializeField]
	private EexchangeType[] m_exchangeTypes;
	[SerializeField]
	private GameObject[] m_exchangeObjects;
	[SerializeField]
	public int m_tabOffsetX;
}
