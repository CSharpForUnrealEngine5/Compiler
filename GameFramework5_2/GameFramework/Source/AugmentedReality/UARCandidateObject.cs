#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ARTypes.h")]
///<summary>An asset that points to an object to be detected in a scene</summary>
public partial class UARCandidateObject : UDataAsset {
// ARCandidateObject
	public TArray<byte> GetCandidateObjectData(TArray<byte> ReturnValue) { return default; }
	public void SetCandidateObjectData(TArray<byte> InCandidateObject) {}
	public sbyte GetFriendlyName(sbyte ReturnValue) { return default; }
	public void SetFriendlyName(sbyte NewName) {}
	public FBox GetBoundingBox(FBox ReturnValue) { return default; }
	public void SetBoundingBox(FBox InBoundingBox) {}
	public TArray<byte> CandidateObjectData;
	public sbyte FriendlyName;
	public FBox BoundingBox;
}
