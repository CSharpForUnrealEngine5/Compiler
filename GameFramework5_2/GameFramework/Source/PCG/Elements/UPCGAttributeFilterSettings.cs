#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Elements/PCGAttributeFilterElement.h")]
///<summary>Filter the attributes from a given input metadata.</summary>
public partial class UPCGAttributeFilterSettings : UPCGSettings {
// PCGAttributeFilterSettings
	public EPCGAttributeFilterOperation Operation;
	public sbyte SelectedAttributes;
	public TArray<sbyte> AttributesToKeep_DEPRECATED;
}
