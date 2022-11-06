using UnityEngine;
using System.Collections.Generic;

public class UIInput : UIWidgetContainer
{
	public enum KeyboardType
	{
		Default = 0,
		ASCIICapable = 1,
		NumbersAndPunctuation = 2,
		URL = 3,
		NumberPad = 4,
		PhonePad = 5,
		NamePhonePad = 6,
		EmailAddress = 7,
	}

	public UILabel label;
	public int maxChars;
	public string caratChar;
	public string playerPrefsField;
	public KeyboardType type;
	public bool isPassword;
	public bool autoCorrect;
	public bool useLabelTextAtStart;
	public Color activeColor;
	public GameObject selectOnTab;
	public List<EventDelegate> onSubmit;
	[SerializeField]
	private GameObject eventReceiver;
	[SerializeField]
	private string functionName;
}
