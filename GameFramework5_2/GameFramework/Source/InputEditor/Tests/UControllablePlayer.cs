#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Tests/InputTestFramework.h")]
public partial class UControllablePlayer : UObject {
// ControllablePlayer
	public APlayerController Player;
	public TMap<sbyte,FBindingTargets> BindingTargets;
	public TMap<sbyte,UInputMappingContext> InputContext;
	public TMap<sbyte,UInputAction> InputAction;
}
