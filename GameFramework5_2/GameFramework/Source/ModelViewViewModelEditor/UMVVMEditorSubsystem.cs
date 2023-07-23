#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MVVMEditorSubsystem.h")]
public partial class UMVVMEditorSubsystem : UEditorSubsystem {
// MVVMEditorSubsystem
	public UObject RequestView(UObject WidgetBlueprint,UObject ReturnValue) { return default; }
	public UObject GetView(UObject WidgetBlueprint,UObject ReturnValue) { return default; }
	public sbyte AddViewModel(UObject WidgetBlueprint,UClass ViewModel,sbyte ReturnValue) { return default; }
	public void RemoveViewModel(UObject WidgetBlueprint,sbyte ViewModel) {}
	public bool VerifyViewModelRename(UObject WidgetBlueprint,sbyte ViewModel,sbyte NewViewModel,sbyte OutError,bool ReturnValue) { return default; }
	public bool RenameViewModel(UObject WidgetBlueprint,sbyte ViewModel,sbyte NewViewModel,sbyte OutError,bool ReturnValue) { return default; }
	public FMVVMBlueprintViewBinding AddBinding(UObject WidgetBlueprint,FMVVMBlueprintViewBinding ReturnValue) { return default; }
	public void RemoveBinding(UObject WidgetBlueprint,FMVVMBlueprintViewBinding Binding) {}
	public TArray<FMVVMAvailableBinding> GetChildViewModels(UClass Class,UClass Accessor,TArray<FMVVMAvailableBinding> ReturnValue) { return default; }
	public bool IsValidConversionFunction(UObject Function,FMVVMBlueprintPropertyPath Source,FMVVMBlueprintPropertyPath Destination,bool ReturnValue) { return default; }
	public bool IsSimpleConversionFunction(UObject Function,bool ReturnValue) { return default; }
	public UObject GetConversionFunctionGraph(UObject WidgetBlueprint,FMVVMBlueprintViewBinding Binding,bool bSourceToDestination,UObject ReturnValue) { return default; }
	public UObject GetConversionFunction(UObject WidgetBlueprint,FMVVMBlueprintViewBinding Binding,bool bSourceToDestination,UObject ReturnValue) { return default; }
	public UObject GetConversionFunctionNode(UObject WidgetBlueprint,FMVVMBlueprintViewBinding Binding,bool bSourceToDestination,UObject ReturnValue) { return default; }
	public TArray<UObject> GetAvailableConversionFunctions(UObject WidgetBlueprint,FMVVMBlueprintPropertyPath Source,FMVVMBlueprintPropertyPath Destination,TArray<UObject> ReturnValue) { return default; }
}
