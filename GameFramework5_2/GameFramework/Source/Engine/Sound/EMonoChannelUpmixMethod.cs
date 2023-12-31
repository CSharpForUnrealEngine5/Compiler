#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sound/AudioSettings.h")]
///<summary>Enumeration defines how to treat mono 2D playback. Mono sounds need to upmixed to stereo when played back in 2D.</summary>
public enum EMonoChannelUpmixMethod {
	Linear=0,
	EqualPower=1,
	FullVolume=2,
}
