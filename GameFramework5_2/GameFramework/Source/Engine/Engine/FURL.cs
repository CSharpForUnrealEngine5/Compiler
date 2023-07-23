#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/EngineBaseTypes.h")]
///<summary>URL structure.</summary>
public partial struct FURL {
// URL
	public sbyte Protocol;
	public sbyte Host;
	public int Port;
	public int Valid;
	public sbyte Map;
	public sbyte RedirectURL;
	public TArray<sbyte> Op;
	public sbyte Portal;
}
