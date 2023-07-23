#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/SlateWrapperTypes.h")]
///<summary>A container for all accessible properties for a UWidget that will be passed to the underlying SWidget.</summary>
public partial class USlateAccessibleWidgetData : UObject {
// SlateAccessibleWidgetData
	public sbyte FGetText(sbyte ReturnValue) { return default; }
	public bool bCanChildrenBeAccessible;
	public ESlateAccessibleBehavior AccessibleBehavior;
	public ESlateAccessibleBehavior AccessibleSummaryBehavior;
	public sbyte AccessibleText;
	public FGetText AccessibleTextDelegate;
	public sbyte AccessibleSummaryText;
	public FGetText AccessibleSummaryTextDelegate;
}
