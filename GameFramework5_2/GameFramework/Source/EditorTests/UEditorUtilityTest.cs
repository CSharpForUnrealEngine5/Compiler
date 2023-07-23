#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EditorUtilityTest.h")]
public partial class UEditorUtilityTest : UObject {
// EditorUtilityTest
	public FEditorUtilityTestEventSignature OnTestPrepare;
	public FEditorUtilityTestEventSignature OnTestStart;
	public FEditorUtilityTestFinishedSignature OnTestFinished;
	public sbyte Owner;
	public sbyte Description;
	public float PreparationTimeLimit;
	public float TimeLimit;
	public void Run() {}
	public void PrepareTest() {}
	public void FinishPrepareTest() {}
	public void StartTest() {}
	public void FinishTest(EEditorUtilityTestResult TestState,sbyte Message) {}
	public void ReceiveFinishedTest(EEditorUtilityTestResult TestState,EEditorUtilityTestResult FinalState) {}
	public void AddError(sbyte Message) {}
	public void AddWarning(sbyte Message) {}
	public void AddInfo(sbyte Message) {}
	public void ExpectTrue(bool Condition,sbyte ErrorMessage) {}
	public void ExpectFalse(bool Condition,sbyte ErrorMessage) {}
	public EEditorUtilityTestResult GetState(EEditorUtilityTestResult ReturnValue) { return default; }
	public bool IsRunning(bool ReturnValue) { return default; }
}
