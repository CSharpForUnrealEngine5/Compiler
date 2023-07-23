#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Settings/LevelEditorPlayNetworkEmulationSettings.h")]
public partial struct FLevelEditorPlayNetworkEmulationSettings {
// LevelEditorPlayNetworkEmulationSettings
	public bool bIsNetworkEmulationEnabled;
	public NetworkEmulationTarget EmulationTarget;
	public sbyte CurrentProfile;
	public FNetworkEmulationPacketSettings OutPackets;
	public FNetworkEmulationPacketSettings InPackets;
}
