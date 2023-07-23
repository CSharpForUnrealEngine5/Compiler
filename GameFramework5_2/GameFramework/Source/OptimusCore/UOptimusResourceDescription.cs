#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("OptimusResourceDescription.h")]
public partial class UOptimusResourceDescription : UObject {
// OptimusResourceDescription
	public sbyte ResourceName;
	public FOptimusDataTypeRef DataType;
	public TWeakObjectPtr<UOptimusComponentSourceBinding> ComponentBinding;
	public FOptimusDataDomain DataDomain;
	public UOptimusPersistentBufferDataInterface DataInterface;
}
