#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RemoteControlRequest.h")]
///<summary>Holds a request to expose a property on a preset</summary>
public partial struct FRCPresetExposePropertyRequest {
// RCPresetExposePropertyRequest
	public sbyte ObjectPath;
	public sbyte PropertyName;
	public sbyte Label;
	public sbyte GroupName;
	public bool EnableEditCondition;
}
