#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PixelStreamingInputComponent.h")]
///<summary>This component may be attached to an actor to allow UI interactions to be</summary>
public partial class UPixelStreamingInput : UActorComponent {
// PixelStreamingInput
	public void FOnInput(sbyte Descriptor) {}
	public FOnInput OnInputEvent;
	public void SendPixelStreamingResponse(sbyte Descriptor) {}
	public void GetJsonStringValue(sbyte Descriptor,sbyte FieldName,sbyte StringValue,bool Success) {}
	public void AddJsonStringValue(sbyte Descriptor,sbyte FieldName,sbyte StringValue,sbyte NewDescriptor,bool Success) {}
}
