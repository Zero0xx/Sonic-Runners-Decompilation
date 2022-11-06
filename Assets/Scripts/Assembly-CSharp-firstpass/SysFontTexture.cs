using System;
using UnityEngine;

[Serializable]
public class SysFontTexture
{
	[SerializeField]
	protected string _text;
	[SerializeField]
	protected string _appleFontName;
	[SerializeField]
	protected string _androidFontName;
	[SerializeField]
	protected int _fontSize;
	[SerializeField]
	protected bool _isBold;
	[SerializeField]
	protected bool _isItalic;
	[SerializeField]
	protected SysFont.Alignment _alignment;
	[SerializeField]
	protected bool _isMultiLine;
	[SerializeField]
	protected int _maxWidthPixels;
	[SerializeField]
	protected int _maxHeightPixels;
}
