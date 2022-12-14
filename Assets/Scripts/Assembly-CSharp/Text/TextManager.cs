using UnityEngine;

namespace Text
{
	public class TextManager : MonoBehaviour
	{
		public enum TextType
		{
			TEXTTYPE_NONE = -1,
			TEXTTYPE_COMMON_TEXT = 0,
			TEXTTYPE_MILEAGE_MAP_COMMON = 1,
			TEXTTYPE_MILEAGE_MAP_EPISODE = 2,
			TEXTTYPE_MILEAGE_MAP_PRE_EPISODE = 3,
			TEXTTYPE_FIXATION_TEXT = 4,
			TEXTTYPE_EVENT_COMMON_TEXT = 5,
			TEXTTYPE_EVENT_SPECIFIC = 6,
			TEXTTYPE_CHAO_TEXT = 7,
			TEXTTYPE_END = 8,
		}

	}
}
