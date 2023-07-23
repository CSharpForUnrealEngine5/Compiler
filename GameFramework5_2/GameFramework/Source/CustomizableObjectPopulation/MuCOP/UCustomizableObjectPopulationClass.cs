#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MuCOP/CustomizableObjectPopulationClass.h")]
public partial class UCustomizableObjectPopulationClass : UObject {
// CustomizableObjectPopulationClass
	public sbyte Name;
	public UCustomizableObject CustomizableObject;
	public TArray<sbyte> Allowlist;
	public TArray<sbyte> Blocklist;
	public TArray<FCustomizableObjectPopulationCharacteristic> Characteristics;
	public TArray<sbyte> Tags;
}
