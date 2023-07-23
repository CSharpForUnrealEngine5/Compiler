#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/Widget.h")]
///<summary>This is the base class for all wrapped Slate controls that are exposed to UObjects.</summary>
public partial class UWidget : UVisual {
// Widget
	public bool FGetBool(bool ReturnValue) { return default; }
	public float FGetFloat(float ReturnValue) { return default; }
	public int FGetInt32(int ReturnValue) { return default; }
	public sbyte FGetText(sbyte ReturnValue) { return default; }
	public FSlateColor FGetSlateColor(FSlateColor ReturnValue) { return default; }
	public FLinearColor FGetLinearColor(FLinearColor ReturnValue) { return default; }
	public FSlateBrush FGetSlateBrush(FSlateBrush ReturnValue) { return default; }
	public ESlateVisibility FGetSlateVisibility(ESlateVisibility ReturnValue) { return default; }
	public EMouseCursor FGetMouseCursor(EMouseCursor ReturnValue) { return default; }
	public ECheckBoxState FGetCheckBoxState(ECheckBoxState ReturnValue) { return default; }
	public UObject FGetWidget(UObject ReturnValue) { return default; }
	public UObject FGenerateWidgetForString(sbyte Item,UObject ReturnValue) { return default; }
	public UObject FGenerateWidgetForObject(UObject Item,UObject ReturnValue) { return default; }
	public FEventReply FOnReply(FEventReply ReturnValue) { return default; }
	public FEventReply FOnPointerEvent(FGeometry MyGeometry,FPointerEvent MouseEvent,FEventReply ReturnValue) { return default; }
	public UPanelSlot Slot;
	public FGetBool bIsEnabledDelegate;
	public sbyte ToolTipText;
	public FGetText ToolTipTextDelegate;
	public UWidget ToolTipWidget;
	public FGetWidget ToolTipWidgetDelegate;
	public FGetSlateVisibility VisibilityDelegate;
	public FWidgetTransform RenderTransform;
	public FVector2D RenderTransformPivot;
	public EFlowDirectionPreference FlowDirectionPreference;
	public bool bIsVariable;
	public bool bCreatedByConstructionScript;
	public bool bIsEnabled;
	public bool bOverride_Cursor;
	public bool bOverrideAccessibleDefaults;
	public bool bCanChildrenBeAccessible;
	public ESlateAccessibleBehavior AccessibleBehavior;
	public ESlateAccessibleBehavior AccessibleSummaryBehavior;
	public sbyte AccessibleText;
	public FGetText AccessibleTextDelegate;
	public sbyte AccessibleSummaryText;
	public FGetText AccessibleSummaryTextDelegate;
	public bool bIsVolatile;
	public bool bHiddenInDesigner;
	public bool bExpandedInDesigner;
	public bool bLockedInDesigner;
	public byte Cursor;
	public EWidgetClipping Clipping;
	public ESlateVisibility Visibility;
	public float RenderOpacity;
	public USlateAccessibleWidgetData AccessibleWidgetData;
	public UWidgetNavigation Navigation;
	public void SetRenderTransform(FWidgetTransform InTransform) {}
	public void SetRenderScale(FVector2D Scale) {}
	public void SetRenderShear(FVector2D Shear) {}
	public void SetRenderTransformAngle(float Angle) {}
	public float GetRenderTransformAngle(float ReturnValue) { return default; }
	public void SetRenderTranslation(FVector2D Translation) {}
	public void SetRenderTransformPivot(FVector2D Pivot) {}
	public bool GetIsEnabled(bool ReturnValue) { return default; }
	public void SetIsEnabled(bool bInIsEnabled) {}
	public bool IsInViewport(bool ReturnValue) { return default; }
	public void SetToolTipText(sbyte InToolTipText) {}
	public void SetToolTip(UObject Widget) {}
	public void SetCursor(EMouseCursor InCursor) {}
	public void ResetCursor() {}
	public bool IsRendered(bool ReturnValue) { return default; }
	public bool IsVisible(bool ReturnValue) { return default; }
	public ESlateVisibility GetVisibility(ESlateVisibility ReturnValue) { return default; }
	public void SetVisibility(ESlateVisibility InVisibility) {}
	public float GetRenderOpacity(float ReturnValue) { return default; }
	public void SetRenderOpacity(float InOpacity) {}
	public EWidgetClipping GetClipping(EWidgetClipping ReturnValue) { return default; }
	public void SetClipping(EWidgetClipping InClipping) {}
	public void ForceVolatile(bool bForce) {}
	public bool IsHovered(bool ReturnValue) { return default; }
	public bool HasKeyboardFocus(bool ReturnValue) { return default; }
	public bool HasMouseCapture(bool ReturnValue) { return default; }
	public bool HasMouseCaptureByUser(int UserIndex,int PointerIndex=-1,bool ReturnValue) { return default; }
	public void SetKeyboardFocus() {}
	public bool HasUserFocus(UObject PlayerController,bool ReturnValue) { return default; }
	public bool HasAnyUserFocus(bool ReturnValue) { return default; }
	public bool HasFocusedDescendants(bool ReturnValue) { return default; }
	public bool HasUserFocusedDescendants(UObject PlayerController,bool ReturnValue) { return default; }
	public void SetFocus() {}
	public void SetUserFocus(UObject PlayerController) {}
	public void ForceLayoutPrepass() {}
	public void InvalidateLayoutAndVolatility() {}
	public FVector2D GetDesiredSize(FVector2D ReturnValue) { return default; }
	public void SetAllNavigationRules(EUINavigationRule Rule,sbyte WidgetToFocus) {}
	public void SetNavigationRule(EUINavigation Direction,EUINavigationRule Rule,sbyte WidgetToFocus) {}
	public void SetNavigationRuleBase(EUINavigation Direction,EUINavigationRule Rule) {}
	public void SetNavigationRuleExplicit(EUINavigation Direction,UObject InWidget) {}
	public void SetNavigationRuleCustom(EUINavigation Direction,FCustomWidgetNavigationDelegate InCustomDelegate) {}
	public void SetNavigationRuleCustomBoundary(EUINavigation Direction,FCustomWidgetNavigationDelegate InCustomDelegate) {}
	public UObject GetParent(UObject ReturnValue) { return default; }
	public void RemoveFromParent() {}
	public FGeometry GetCachedGeometry(FGeometry ReturnValue) { return default; }
	public FGeometry GetTickSpaceGeometry(FGeometry ReturnValue) { return default; }
	public FGeometry GetPaintSpaceGeometry(FGeometry ReturnValue) { return default; }
	public void K2_AddFieldValueChangedDelegate(FFieldNotificationId FieldId,FFieldValueChangedDynamicDelegate Delegate) {}
	public void K2_RemoveFieldValueChangedDelegate(FFieldNotificationId FieldId,FFieldValueChangedDynamicDelegate Delegate) {}
	public void K2_BroadcastFieldValueChanged(FFieldNotificationId FieldId) {}
	public UObject GetGameInstance(UObject ReturnValue) { return default; }
	public UObject GetOwningPlayer(UObject ReturnValue) { return default; }
	public UObject GetOwningLocalPlayer(UObject ReturnValue) { return default; }
	public sbyte GetAccessibleText(sbyte ReturnValue) { return default; }
	public sbyte GetAccessibleSummaryText(sbyte ReturnValue) { return default; }
	public TArray<UPropertyBinding> NativeBindings;
	public byte DesignerFlags;
	public sbyte DisplayLabel;
	public sbyte CategoryName;
}
