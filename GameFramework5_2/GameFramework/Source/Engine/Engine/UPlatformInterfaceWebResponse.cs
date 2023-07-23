#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/PlatformInterfaceWebResponse.h")]
public partial class UPlatformInterfaceWebResponse : UObject {
// PlatformInterfaceWebResponse
	public sbyte OriginalURL;
	public int ResponseCode;
	public int Tag;
	public sbyte StringResponse;
	public TArray<byte> BinaryResponse;
	public int GetNumHeaders(int ReturnValue) { return default; }
	public void GetHeader(int HeaderIndex,sbyte Header,sbyte Value) {}
	public sbyte GetHeaderValue(sbyte HeaderName,sbyte ReturnValue) { return default; }
}
