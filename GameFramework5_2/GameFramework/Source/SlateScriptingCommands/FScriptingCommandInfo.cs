#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("UICommandsScriptingSubsystem.h")]
///<summary>The data defining a scripting command. At the exception of its delegates.</summary>
public partial struct FScriptingCommandInfo {
// ScriptingCommandInfo
	public sbyte ContextName;
	public sbyte Set;
	public sbyte Name;
	public sbyte Label;
	public sbyte Description;
	public FInputChord InputChord;
}
