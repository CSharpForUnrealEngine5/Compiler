#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/CustomAttributes.h")]
///<summary>Settings that identify the names of custom attributes that represent the individual components of a timecode and a subframe along with a take name.</summary>
public partial struct FTimecodeCustomAttributeNameSettings {
// TimecodeCustomAttributeNameSettings
	public sbyte HourAttributeName;
	public sbyte MinuteAttributeName;
	public sbyte SecondAttributeName;
	public sbyte FrameAttributeName;
	public sbyte SubframeAttributeName;
	public sbyte RateAttributeName;
	public sbyte TakenameAttributeName;
}
