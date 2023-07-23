#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Agents/MLAdapterAgent.h")]
///<summary>A serializable config for an agent. Used in the external API to define agents.</summary>
public partial struct FMLAdapterAgentConfig {
// MLAdapterAgentConfig
	public TMap<sbyte,FMLAdapterParameterMap> Sensors;
	public TMap<sbyte,FMLAdapterParameterMap> Actuators;
	public sbyte AvatarClassName;
	public sbyte AgentClassName;
	public bool bAvatarClassExact;
	public bool bAutoRequestNewAvatarUponClearingPrev;
}
