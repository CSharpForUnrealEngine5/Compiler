#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("OnlinePIESettings.h")]
///<summary>Stores PIE login credentials</summary>
public partial struct FPIELoginSettingsInternal {
// PIELoginSettingsInternal
	public sbyte Id;
	public sbyte Token;
	public sbyte Type;
	public TArray<byte> TokenBytes;
}
