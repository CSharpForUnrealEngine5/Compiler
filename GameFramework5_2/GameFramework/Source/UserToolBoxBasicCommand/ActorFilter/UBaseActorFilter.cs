#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ActorFilter/BaseActorFilter.h")]
public partial class UBaseActorFilter : UObject {
// BaseActorFilter
	public TArray<UObject> Filter(TArray<UObject> Source,TArray<UObject> ReturnValue) { return default; }
	public bool FilterUnit(UObject Source,bool ReturnValue) { return default; }
	public bool bShouldRunGlobalFilter;
	public bool bShouldRunUnitFilter;
}
