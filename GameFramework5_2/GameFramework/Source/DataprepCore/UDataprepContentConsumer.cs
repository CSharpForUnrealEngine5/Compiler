#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DataprepContentConsumer.h")]
///<summary>Abstract class providing the minimal services required for a DataprepConsumer</summary>
public partial class UDataprepContentConsumer : UObject {
// DataprepContentConsumer
	public bool SetLevelName(sbyte InLevelName,sbyte OutFailureReason,bool ReturnValue) { return default; }
	public bool SetLevelNameAutomated(sbyte InLevelName,sbyte OutFailureReason,bool ReturnValue) { return default; }
	public sbyte GetLevelName(sbyte ReturnValue) { return default; }
	public bool SetTargetContentFolder(sbyte InTargetContentFolder,sbyte OutFailureReason,bool ReturnValue) { return default; }
	public bool SetTargetContentFolderAutomated(sbyte InTargetContentFolder,sbyte OutFailureReason,bool ReturnValue) { return default; }
	public sbyte GetTargetContentFolder(sbyte ReturnValue) { return default; }
	public sbyte TargetContentFolder;
	public sbyte LevelName;
}
