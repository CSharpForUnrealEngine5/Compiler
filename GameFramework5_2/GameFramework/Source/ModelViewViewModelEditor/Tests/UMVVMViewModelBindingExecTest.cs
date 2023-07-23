#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Tests/MVVMBindingExecuteTest.h")]
public partial class UMVVMViewModelBindingExecTest : UObject {
// MVVMViewModelBindingExecTest
	public FMVVMBindingExecTextCounter PropertyA;
	public TArray<FMVVMBindingExecTextCounter> PropertyB;
	public int PropertyC;
	public TArray<int> PropertyD;
	public float PropertyFloat;
	public float PropertyFloatAccessor;
	public double PropertyDouble;
	public FMVVMBindingExecTextCounter GetterA(FMVVMBindingExecTextCounter ReturnValue) { return default; }
	public TArray<FMVVMBindingExecTextCounter> GetterB(TArray<FMVVMBindingExecTextCounter> ReturnValue) { return default; }
	public int GetterC(int ReturnValue) { return default; }
	public TArray<int> GetterD(TArray<int> ReturnValue) { return default; }
	public float GetterFloat(float ReturnValue) { return default; }
	public double GetterDouble(double ReturnValue) { return default; }
	public void SetterA(FMVVMBindingExecTextCounter Value) {}
	public void SetterB(TArray<FMVVMBindingExecTextCounter> Value) {}
	public void SetterC(int Value) {}
	public void SetterD(TArray<int> Value) {}
	public void SetterFloat(float Value) {}
	public void SetterDouble(double Value) {}
	public int ConversionStructToInt(FMVVMBindingExecTextCounter Value,int ReturnValue) { return default; }
	public int ConversionConstStructToInt(FMVVMBindingExecTextCounter Value,int ReturnValue) { return default; }
	public TArray<int> ConversionArrayStructToArrayInt(TArray<FMVVMBindingExecTextCounter> Values,TArray<int> ReturnValue) { return default; }
	public FMVVMBindingExecTextCounter ConversionIntToStruct(int Value,FMVVMBindingExecTextCounter ReturnValue) { return default; }
	public FMVVMBindingExecTextCounter ConversionConstIntToStruct(int Value,FMVVMBindingExecTextCounter ReturnValue) { return default; }
	public TArray<FMVVMBindingExecTextCounter> ConversionArrayIntToArrayStruct(TArray<int> Values,TArray<FMVVMBindingExecTextCounter> ReturnValue) { return default; }
	public float ConversionIncFloat(float Value,float ReturnValue) { return default; }
	public float ConversionIncDouble(double Value,float ReturnValue) { return default; }
}
