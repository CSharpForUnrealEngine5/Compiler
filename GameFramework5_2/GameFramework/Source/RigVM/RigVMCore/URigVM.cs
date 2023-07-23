#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMCore/RigVM.h")]
///<summary>The RigVM is the main object for evaluating FRigVMByteCode instructions.</summary>
public partial class URigVM : UObject {
// RigVM
	public bool Execute(sbyte InEntryName=NAME_None,bool ReturnValue) { return default; }
	public int AddRigVMFunction(UObject InRigVMStruct,sbyte InMethodName,int ReturnValue) { return default; }
	public sbyte GetRigVMFunctionName(int InFunctionIndex,sbyte ReturnValue) { return default; }
	public URigVMMemoryStorage WorkMemoryStorageObject;
	public URigVMMemoryStorage LiteralMemoryStorageObject;
	public URigVMMemoryStorage DebugMemoryStorageObject;
	public FRigVMByteCode ByteCodeStorage;
	public bool GetParameterValueBool(sbyte InParameterName,int InArrayIndex=0,bool ReturnValue) { return default; }
	public float GetParameterValueFloat(sbyte InParameterName,int InArrayIndex=0,float ReturnValue) { return default; }
	public double GetParameterValueDouble(sbyte InParameterName,int InArrayIndex=0,double ReturnValue) { return default; }
	public int GetParameterValueInt(sbyte InParameterName,int InArrayIndex=0,int ReturnValue) { return default; }
	public sbyte GetParameterValueName(sbyte InParameterName,int InArrayIndex=0,sbyte ReturnValue) { return default; }
	public sbyte GetParameterValueString(sbyte InParameterName,int InArrayIndex=0,sbyte ReturnValue) { return default; }
	public FVector2D GetParameterValueVector2D(sbyte InParameterName,int InArrayIndex=0,FVector2D ReturnValue) { return default; }
	public FVector GetParameterValueVector(sbyte InParameterName,int InArrayIndex=0,FVector ReturnValue) { return default; }
	public FQuat GetParameterValueQuat(sbyte InParameterName,int InArrayIndex=0,FQuat ReturnValue) { return default; }
	public FTransform GetParameterValueTransform(sbyte InParameterName,int InArrayIndex=0,FTransform ReturnValue) { return default; }
	public void SetParameterValueBool(sbyte InParameterName,bool InValue,int InArrayIndex=0) {}
	public void SetParameterValueFloat(sbyte InParameterName,float InValue,int InArrayIndex=0) {}
	public void SetParameterValueDouble(sbyte InParameterName,double InValue,int InArrayIndex=0) {}
	public void SetParameterValueInt(sbyte InParameterName,int InValue,int InArrayIndex=0) {}
	public void SetParameterValueName(sbyte InParameterName,sbyte InValue,int InArrayIndex=0) {}
	public void SetParameterValueString(sbyte InParameterName,sbyte InValue,int InArrayIndex=0) {}
	public void SetParameterValueVector2D(sbyte InParameterName,FVector2D InValue,int InArrayIndex=0) {}
	public void SetParameterValueVector(sbyte InParameterName,FVector InValue,int InArrayIndex=0) {}
	public void SetParameterValueQuat(sbyte InParameterName,FQuat InValue,int InArrayIndex=0) {}
	public void SetParameterValueTransform(sbyte InParameterName,FTransform InValue,int InArrayIndex=0) {}
	public FRigVMStatistics GetStatistics(FRigVMStatistics ReturnValue) { return default; }
	public FRigVMInstructionArray Instructions;
	public FRigVMExtendedExecuteContext Context;
	public uint NumExecutions;
	public TArray<sbyte> FunctionNamesStorage;
	public TArray<FRigVMParameter> Parameters;
	public TMap<sbyte,int> ParametersNameMap;
	public URigVM DeferredVMToCopy;
}
