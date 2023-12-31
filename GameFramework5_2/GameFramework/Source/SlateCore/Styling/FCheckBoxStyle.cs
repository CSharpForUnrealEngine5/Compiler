#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Styling/SlateTypes.h")]
///<summary>Represents the appearance of an SCheckBox</summary>
public partial struct FCheckBoxStyle {
// CheckBoxStyle
	public byte CheckBoxType;
	public FSlateBrush UncheckedImage;
	public FSlateBrush UncheckedHoveredImage;
	public FSlateBrush UncheckedPressedImage;
	public FSlateBrush CheckedImage;
	public FSlateBrush CheckedHoveredImage;
	public FSlateBrush CheckedPressedImage;
	public FSlateBrush UndeterminedImage;
	public FSlateBrush UndeterminedHoveredImage;
	public FSlateBrush UndeterminedPressedImage;
	public FMargin Padding;
	public FSlateBrush BackgroundImage;
	public FSlateBrush BackgroundHoveredImage;
	public FSlateBrush BackgroundPressedImage;
	public FSlateColor ForegroundColor;
	public FSlateColor HoveredForeground;
	public FSlateColor PressedForeground;
	public FSlateColor CheckedForeground;
	public FSlateColor CheckedHoveredForeground;
	public FSlateColor CheckedPressedForeground;
	public FSlateColor UndeterminedForeground;
	public FSlateColor BorderBackgroundColor;
	public FSlateSound CheckedSlateSound;
	public FSlateSound UncheckedSlateSound;
	public FSlateSound HoveredSlateSound;
	public string CheckedSound_DEPRECATED;
	public string UncheckedSound_DEPRECATED;
	public string HoveredSound_DEPRECATED;
}
