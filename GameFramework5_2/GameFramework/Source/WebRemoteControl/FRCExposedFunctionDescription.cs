#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RemoteControlModels.h")]
public partial struct FRCExposedFunctionDescription {
// RCExposedFunctionDescription
	public sbyte DisplayName;
	public sbyte ID;
	public FRCFunctionDescription UnderlyingFunction;
	public TArray<FRCObjectDescription> OwnerObjects;
}
