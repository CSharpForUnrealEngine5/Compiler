#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/SinglePropertyView.h")]
///<summary>The single property view allows you to display the value of an object's property.</summary>
public partial class USinglePropertyView : UPropertyViewBase {
// SinglePropertyView
	public sbyte PropertyName;
	public sbyte NameOverride;
	public sbyte GetPropertyName(sbyte ReturnValue) { return default; }
	public void SetPropertyName(sbyte NewPropertyName) {}
	public sbyte GetNameOverride(sbyte ReturnValue) { return default; }
	public void SetNameOverride(sbyte NewPropertyName) {}
}
