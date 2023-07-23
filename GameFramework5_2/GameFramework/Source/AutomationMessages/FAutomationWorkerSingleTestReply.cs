#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AutomationWorkerMessages.h")]
///<summary>A single test reply, used by FAutomationWorkerRequestTestsReplyComplete</summary>
public partial struct FAutomationWorkerSingleTestReply {
// AutomationWorkerSingleTestReply
	public sbyte DisplayName;
	public sbyte FullTestPath;
	public sbyte TestName;
	public sbyte TestParameter;
	public sbyte SourceFile;
	public int SourceFileLine;
	public sbyte AssetPath;
	public sbyte OpenCommand;
	public uint TestFlags;
	public uint NumParticipantsRequired;
}
