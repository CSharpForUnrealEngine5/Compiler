#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("FunctionalTest.h")]
public partial class AFunctionalTest : AActor {
// FunctionalTest
	public sbyte TestLabel;
	public sbyte Author;
	public sbyte Description;
	public UBillboardComponent SpriteComponent;
	public bool bIsEnabled;
	public EFunctionalTestLogHandling LogErrorHandling;
	public EFunctionalTestLogHandling LogWarningHandling;
	public AActor ObservationPoint;
	public FRandomStream RandomNumbersStream;
	public EFunctionalTestResult Result;
	public float PreparationTimeLimit;
	public float TimeLimit;
	public sbyte TimesUpMessage;
	public EFunctionalTestResult TimesUpResult;
	public FFunctionalTestEventSignature OnTestPrepare;
	public FFunctionalTestEventSignature OnTestStart;
	public FFunctionalTestEventSignature OnTestFinished;
	public TArray<AActor> AutoDestroyActors;
	public UFuncTestRenderingComponent RenderComp;
	public UTextRenderComponent TestName;
	public bool AssertTrue(bool Condition,sbyte Message,UObject ContextObject=nullptr,bool ReturnValue) { return default; }
	public bool AssertFalse(bool Condition,sbyte Message,UObject ContextObject=nullptr,bool ReturnValue) { return default; }
	public bool AssertIsValid(UObject Object,sbyte Message,UObject ContextObject=nullptr,bool ReturnValue) { return default; }
	public bool AssertValue_Int(int Actual,EComparisonMethod ShouldBe,int Expected,sbyte What,UObject ContextObject=nullptr,bool ReturnValue) { return default; }
	public bool AssertValue_Float(float Actual,EComparisonMethod ShouldBe,float Expected,sbyte What,UObject ContextObject=nullptr,bool ReturnValue) { return default; }
	public bool AssertValue_Double(double Actual,EComparisonMethod ShouldBe,double Expected,sbyte What,UObject ContextObject=nullptr,bool ReturnValue) { return default; }
	public bool AssertValue_DateTime(FDateTime Actual,EComparisonMethod ShouldBe,FDateTime Expected,sbyte What,UObject ContextObject=nullptr,bool ReturnValue) { return default; }
	public bool AssertEqual_Transform(FTransform Actual,FTransform Expected,sbyte What,float Tolerance=1.e-4f,UObject ContextObject=nullptr,bool ReturnValue) { return default; }
	public bool AssertEqual_Float(float Actual,float Expected,sbyte What,float Tolerance=1.e-4f,UObject ContextObject=nullptr,bool ReturnValue) { return default; }
	public bool AssertEqual_Double(double Actual,double Expected,sbyte What,double Tolerance=1.e-4,UObject ContextObject=nullptr,bool ReturnValue) { return default; }
	public bool AssertEqual_Bool(bool Actual,bool Expected,sbyte What,UObject ContextObject=nullptr,bool ReturnValue) { return default; }
	public bool AssertEqual_Int(int Actual,int Expected,sbyte What,UObject ContextObject=nullptr,bool ReturnValue) { return default; }
	public bool AssertEqual_Name(sbyte Actual,sbyte Expected,sbyte What,UObject ContextObject=nullptr,bool ReturnValue) { return default; }
	public bool AssertEqual_Object(UObject Actual,UObject Expected,sbyte What,UObject ContextObject=nullptr,bool ReturnValue) { return default; }
	public bool AssertNotEqual_Transform(FTransform Actual,FTransform NotExpected,sbyte What,UObject ContextObject=nullptr,bool ReturnValue) { return default; }
	public bool AssertEqual_Rotator(FRotator Actual,FRotator Expected,sbyte What,float Tolerance=1.e-4f,UObject ContextObject=nullptr,bool ReturnValue) { return default; }
	public bool AssertNotEqual_Rotator(FRotator Actual,FRotator NotExpected,sbyte What,UObject ContextObject=nullptr,bool ReturnValue) { return default; }
	public bool AssertEqual_Vector(FVector Actual,FVector Expected,sbyte What,float Tolerance=1.e-4f,UObject ContextObject=nullptr,bool ReturnValue) { return default; }
	public bool AssertNotEqual_Vector(FVector Actual,FVector NotExpected,sbyte What,UObject ContextObject=nullptr,bool ReturnValue) { return default; }
	public bool AssertEqual_Vector2D(FVector2D Actual,FVector2D Expected,sbyte What,float Tolerance=1.e-4f,UObject ContextObject=nullptr,bool ReturnValue) { return default; }
	public bool AssertNotEqual_Vector2D(FVector2D Actual,FVector2D NotExpected,sbyte What,UObject ContextObject=nullptr,bool ReturnValue) { return default; }
	public bool AssertEqual_Box2D(FBox2D Actual,FBox2D Expected,sbyte What,float Tolerance=1.e-4f,UObject ContextObject=nullptr,bool ReturnValue) { return default; }
	public bool AssertNotEqual_Box2D(FBox2D Actual,FBox2D NotExpected,sbyte What,UObject ContextObject=nullptr,bool ReturnValue) { return default; }
	public bool AssertEqual_Vector4(FVector4 Actual,FVector4 Expected,sbyte What,float Tolerance=1.e-4f,UObject ContextObject=nullptr,bool ReturnValue) { return default; }
	public bool AssertNotEqual_Vector4(FVector4 Actual,FVector4 NotExpected,sbyte What,UObject ContextObject=nullptr,bool ReturnValue) { return default; }
	public bool AssertEqual_Plane(FPlane Actual,FPlane Expected,sbyte What,float Tolerance=1.e-4f,UObject ContextObject=nullptr,bool ReturnValue) { return default; }
	public bool AssertNotEqual_Plane(FPlane Actual,FPlane NotExpected,sbyte What,UObject ContextObject=nullptr,bool ReturnValue) { return default; }
	public bool AssertEqual_Quat(FQuat Actual,FQuat Expected,sbyte What,float Tolerance=1.e-4f,UObject ContextObject=nullptr,bool ReturnValue) { return default; }
	public bool AssertNotEqual_Quat(FQuat Actual,FQuat NotExpected,sbyte What,UObject ContextObject=nullptr,bool ReturnValue) { return default; }
	public bool AssertEqual_Matrix(FMatrix Actual,FMatrix Expected,sbyte What,float Tolerance=1.e-4f,UObject ContextObject=nullptr,bool ReturnValue) { return default; }
	public bool AssertNotEqual_Matrix(FMatrix Actual,FMatrix NotExpected,sbyte What,UObject ContextObject=nullptr,bool ReturnValue) { return default; }
	public bool AssertEqual_String(sbyte Actual,sbyte Expected,sbyte What,UObject ContextObject=nullptr,bool ReturnValue) { return default; }
	public bool AssertNotEqual_String(sbyte Actual,sbyte NotExpected,sbyte What,UObject ContextObject=nullptr,bool ReturnValue) { return default; }
	public bool AssertEqual_TraceQueryResults(UObject Actual,UObject Expected,sbyte What,UObject ContextObject=nullptr,bool ReturnValue) { return default; }
	public void AddWarning(sbyte Message) {}
	public void AddError(sbyte Message) {}
	public void FinishTest(EFunctionalTestResult TestResult,sbyte Message) {}
	public void LogMessage(sbyte Message) {}
	public void SetTimeLimit(float NewTimeLimit,EFunctionalTestResult ResultWhenTimeRunsOut) {}
	public TArray<UObject> DebugGatherRelevantActors(TArray<UObject> ReturnValue) { return default; }
	public bool OnWantsReRunCheck(bool ReturnValue) { return default; }
	public void AddRerun(sbyte Reason) {}
	public sbyte GetCurrentRerunReason(sbyte ReturnValue) { return default; }
	public sbyte OnAdditionalTestFinishedMessageRequest(EFunctionalTestResult TestResult,sbyte ReturnValue) { return default; }
	public void RegisterAutoDestroyActor(UObject ActorToAutoDestroy) {}
	public bool IsRunning(bool ReturnValue) { return default; }
	public bool IsEnabled(bool ReturnValue) { return default; }
	public void ReceivePrepareTest() {}
	public void ReceiveStartTest() {}
	public bool IsReady(bool ReturnValue) { return default; }
	public bool bIsRunning;
	public float TotalTime;
}
