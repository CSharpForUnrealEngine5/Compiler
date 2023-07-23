#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/GameFrameworkInitStateInterface.h")]
public partial class UGameFrameworkInitStateInterface : UInterface {
// GameFrameworkInitStateInterface
	public sbyte GetFeatureName(sbyte ReturnValue) { return default; }
	public FGameplayTag GetInitState(FGameplayTag ReturnValue) { return default; }
	public bool HasReachedInitState(FGameplayTag DesiredState,bool ReturnValue) { return default; }
	public bool RegisterAndCallForInitStateChange(FGameplayTag RequiredState,FActorInitStateChangedBPDelegate Delegate,bool bCallImmediately=true,bool ReturnValue) { return default; }
	public bool UnregisterInitStateDelegate(FActorInitStateChangedBPDelegate Delegate,bool ReturnValue) { return default; }
}
