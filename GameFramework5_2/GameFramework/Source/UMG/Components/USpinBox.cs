#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/SpinBox.h")]
///<summary>A numerical entry box that allows for direct entry of the number or allows the user to click and slide the number.</summary>
public partial class USpinBox : UWidget {
// SpinBox
	public void FOnSpinBoxValueChangedEvent(float InValue) {}
	public void FOnSpinBoxValueCommittedEvent(float InValue,ETextCommit CommitMethod) {}
	public void FOnSpinBoxBeginSliderMovement() {}
	public float Value;
	public FGetFloat ValueDelegate;
	public FSpinBoxStyle WidgetStyle;
	public int MinFractionalDigits;
	public int MaxFractionalDigits;
	public bool bAlwaysUsesDeltaSnap;
	public bool bEnableSlider;
	public float Delta;
	public float SliderExponent;
	public FSlateFontInfo Font;
	public byte Justification;
	public float MinDesiredWidth;
	public byte KeyboardType;
	public bool ClearKeyboardFocusOnCommit;
	public bool SelectAllTextOnCommit;
	public FSlateColor ForegroundColor;
	public FOnSpinBoxValueChangedEvent OnValueChanged;
	public FOnSpinBoxValueCommittedEvent OnValueCommitted;
	public FOnSpinBoxBeginSliderMovement OnBeginSliderMovement;
	public FOnSpinBoxValueChangedEvent OnEndSliderMovement;
	public float GetValue(float ReturnValue) { return default; }
	public void SetValue(float NewValue) {}
	public int GetMinFractionalDigits(int ReturnValue) { return default; }
	public void SetMinFractionalDigits(int NewValue) {}
	public int GetMaxFractionalDigits(int ReturnValue) { return default; }
	public void SetMaxFractionalDigits(int NewValue) {}
	public bool GetAlwaysUsesDeltaSnap(bool ReturnValue) { return default; }
	public void SetAlwaysUsesDeltaSnap(bool bNewValue) {}
	public float GetDelta(float ReturnValue) { return default; }
	public void SetDelta(float NewValue) {}
	public float GetMinValue(float ReturnValue) { return default; }
	public void SetMinValue(float NewValue) {}
	public void ClearMinValue() {}
	public float GetMaxValue(float ReturnValue) { return default; }
	public void SetMaxValue(float NewValue) {}
	public void ClearMaxValue() {}
	public float GetMinSliderValue(float ReturnValue) { return default; }
	public void SetMinSliderValue(float NewValue) {}
	public void ClearMinSliderValue() {}
	public float GetMaxSliderValue(float ReturnValue) { return default; }
	public void SetMaxSliderValue(float NewValue) {}
	public void ClearMaxSliderValue() {}
	public void SetForegroundColor(FSlateColor InForegroundColor) {}
	public bool bOverride_MinValue;
	public bool bOverride_MaxValue;
	public bool bOverride_MinSliderValue;
	public bool bOverride_MaxSliderValue;
	public float MinValue;
	public float MaxValue;
	public float MinSliderValue;
	public float MaxSliderValue;
}
