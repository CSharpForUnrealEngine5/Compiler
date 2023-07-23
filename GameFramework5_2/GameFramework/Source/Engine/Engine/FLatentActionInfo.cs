#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/LatentActionManager.h")]
///<summary>Latent action info</summary>
public partial struct FLatentActionInfo {
// LatentActionInfo
	public int Linkage;
	public int UUID;
	public sbyte ExecutionFunction;
	public UObject CallbackTarget;
}
