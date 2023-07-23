#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MVVMSubsystem.h")]
public partial class UMVVMSubsystem : UEngineSubsystem {
// MVVMSubsystem
	public UObject K2_GetViewFromUserWidget(UObject UserWidget,UObject ReturnValue) { return default; }
	public bool DoesWidgetTreeContainedWidget(UObject WidgetTree,UObject ViewWidget,bool ReturnValue) { return default; }
	public TArray<FMVVMAvailableBinding> K2_GetAvailableBindings(UClass Class,UClass Accessor,TArray<FMVVMAvailableBinding> ReturnValue) { return default; }
	public FMVVMAvailableBinding K2_GetAvailableBinding(UClass Class,FMVVMBindingName BindingName,UClass Accessor,FMVVMAvailableBinding ReturnValue) { return default; }
	public UObject GetGlobalViewModelCollection(UObject ReturnValue) { return default; }
	public UMVVMViewModelCollectionObject GlobalViewModelCollection;
}
