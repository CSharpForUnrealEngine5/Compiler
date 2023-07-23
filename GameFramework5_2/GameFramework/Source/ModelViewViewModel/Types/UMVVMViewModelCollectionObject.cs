#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Types/MVVMViewModelCollection.h")]
public partial class UMVVMViewModelCollectionObject : UObject {
// MVVMViewModelCollectionObject
	public UObject FindViewModelInstance(FMVVMViewModelContext Context,UObject ReturnValue) { return default; }
	public UObject FindFirstViewModelInstanceOfType(UClass ViewModelClass,UObject ReturnValue) { return default; }
	public bool AddViewModelInstance(FMVVMViewModelContext Context,UObject ViewModel,bool ReturnValue) { return default; }
	public bool RemoveViewModel(FMVVMViewModelContext Context,bool ReturnValue) { return default; }
	public int RemoveAllViewModelInstance(UObject ViewModel,int ReturnValue) { return default; }
	public FMVVMViewModelCollection ViewModelCollection;
}
