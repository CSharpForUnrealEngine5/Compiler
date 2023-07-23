#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RemoteControlBinding.h")]
public partial struct FRemoteControlInitialBindingContext {
// RemoteControlInitialBindingContext
	public TSoftObjectPtr<UClass> SupportedClass;
	public sbyte ComponentName;
	public sbyte SubObjectPath;
	public TSoftObjectPtr<UClass> OwnerActorClass;
	public sbyte OwnerActorName;
}
