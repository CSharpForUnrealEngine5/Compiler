#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MovieSceneToolsProjectSettings.h")]
///<summary>Settings for the level sequences</summary>
public partial class UMovieSceneToolsProjectSettings : UObject {
// MovieSceneToolsProjectSettings
	public float DefaultStartTime;
	public float DefaultDuration;
	public sbyte ShotDirectory;
	public sbyte ShotPrefix;
	public uint FirstShotNumber;
	public uint ShotIncrement;
	public uint ShotNumDigits;
	public uint TakeNumDigits;
	public uint FirstTakeNumber;
	public sbyte TakeSeparator;
	public sbyte SubSequenceSeparator;
	public TArray<FMovieSceneToolsFbxSettings> FbxSettings;
}
