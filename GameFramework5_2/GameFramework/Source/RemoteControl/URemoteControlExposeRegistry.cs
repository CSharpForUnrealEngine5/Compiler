#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RemoteControlExposeRegistry.h")]
public partial class URemoteControlExposeRegistry : UObject {
// RemoteControlExposeRegistry
	public TSet<FRCEntityWrapper> ExposedEntities;
	public TMap<sbyte,FGuid> LabelToIdCache;
	public TSet<UScriptStruct> ExposedTypes;
}
