using UnityEngine;
using System.Collections.Generic;

public class PlayerCharaList : MonoBehaviour
{
	[SerializeField]
	private Animation m_animation;
	[SerializeField]
	private UIRectItemStorage m_storage;
	[SerializeField]
	private GameObject m_charaDeckObject;
	[SerializeField]
	private GameObject m_chaoDeckObject;
	[SerializeField]
	private List<GameObject> m_gameObjectList;
}
