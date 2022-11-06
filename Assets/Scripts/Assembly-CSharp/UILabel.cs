using UnityEngine;

public class UILabel : UIWidget
{
	public enum Effect
	{
		None = 0,
		Shadow = 1,
		Outline = 2,
	}

	public enum Overflow
	{
		ShrinkContent = 0,
		ClampContent = 1,
		ResizeFreely = 2,
		ResizeHeight = 3,
	}

	[SerializeField]
	private UIFont mFont;
	[SerializeField]
	private string mText;
	[SerializeField]
	private bool mEncoding;
	[SerializeField]
	private int mMaxLineCount;
	[SerializeField]
	private bool mPassword;
	[SerializeField]
	private bool mShowLastChar;
	[SerializeField]
	private Effect mEffectStyle;
	[SerializeField]
	private Color mEffectColor;
	[SerializeField]
	private UIFont.SymbolStyle mSymbols;
	[SerializeField]
	private Vector2 mEffectDistance;
	[SerializeField]
	private Overflow mOverflow;
	[SerializeField]
	private bool mShrinkToFit;
	[SerializeField]
	private int mMaxLineWidth;
	[SerializeField]
	private int mMaxLineHeight;
	[SerializeField]
	private float mLineWidth;
	[SerializeField]
	private bool mMultiline;
}
