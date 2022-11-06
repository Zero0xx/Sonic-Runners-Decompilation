using UnityEngine;
using System;
using Text;

namespace UI
{
	public class UILocalizeText : MonoBehaviour
	{
		[Serializable]
		public class TextData
		{
			[SerializeField]
			public TextManager.TextType text_type;
			[SerializeField]
			public string group_id;
			[SerializeField]
			public string cell_id;
		}

		[Serializable]
		public class TagTextData
		{
			[SerializeField]
			public UILocalizeText.TextData text_data;
			[SerializeField]
			public string tag;
		}

		[SerializeField]
		public TextData m_main_text_data;
		[SerializeField]
		public TagTextData[] m_tag_text_data;
	}
}
