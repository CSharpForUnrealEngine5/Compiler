#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CommonUITypes.h")]
public partial struct FCommonInputActionDataBase {
// CommonInputActionDataBase
	public sbyte DisplayName;
	public sbyte HoldDisplayName;
	public int NavBarPriority;
	public FCommonInputTypeInfo KeyboardInputTypeInfo;
	public FCommonInputTypeInfo DefaultGamepadInputTypeInfo;
	public TMap<sbyte,FCommonInputTypeInfo> GamepadInputOverrides;
	public FCommonInputTypeInfo TouchInputTypeInfo;
}
