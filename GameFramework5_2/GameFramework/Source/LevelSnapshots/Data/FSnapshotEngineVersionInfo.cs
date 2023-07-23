#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Data/SnapshotVersion.h")]
///<summary>Holds engine version information</summary>
public partial struct FSnapshotEngineVersionInfo {
// SnapshotEngineVersionInfo
	public ushort Major;
	public ushort Minor;
	public ushort Patch;
	public uint Changelist;
}
