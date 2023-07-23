#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EnhancedInputEditorSubsystem.h")]
///<summary>The Enhanced Input Editor Subsystem can be used to process input outside of PIE within the editor.</summary>
public partial class UEnhancedInputEditorSubsystem : UEditorSubsystem {
// EnhancedInputEditorSubsystem
	public void PushInputComponent(UObject InInputComponent) {}
	public bool PopInputComponent(UObject InInputComponent,bool ReturnValue) { return default; }
	public void StartConsumingInput() {}
	public void StopConsumingInput() {}
	public bool IsConsumingInput(bool ReturnValue) { return default; }
	public UEnhancedPlayerInput PlayerInput;
	public TArray<TWeakObjectPtr<UInputComponent>> CurrentInputStack;
}
