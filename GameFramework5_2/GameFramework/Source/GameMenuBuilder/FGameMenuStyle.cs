#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameMenuWidgetStyle.h")]
public partial struct FGameMenuStyle {
// GameMenuStyle
	public FSlateBrush MenuTopBrush;
	public FSlateBrush MenuFrameBrush;
	public FSlateBrush MenuBackgroundBrush;
	public FSlateBrush MenuSelectBrush;
	public FSlateSound MenuEnterSound;
	public FSlateSound MenuBackSound;
	public FSlateSound OptionChangeSound;
	public FSlateSound MenuItemChangeSound;
	public FSlateSound MenuItemInactiveSound;
	public FSlateSound MenuItemChosenSound;
	public float LeftMarginPercent;
	public float SubMenuMarginPercent;
	public byte LayoutType;
	public FMargin TitleBorderMargin;
	public FMargin ItemBorderMargin;
	public byte TitleHorizontalAlignment;
	public byte TitleVerticalAlignment;
	public byte PanelsVerticalAlignment;
	public float AnimationSpeed;
	public FSlateColor TextColor;
}
