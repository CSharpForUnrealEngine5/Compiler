#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraDataChannelAccessor.h")]
public partial class UNiagaraDataChannelWriter : UObject {
// NiagaraDataChannelWriter
	public UNiagaraDataChannelHandler Owner;
	public bool InitWrite(UObject OwningComponent,int Count,bool bVisibleToGame=true,bool bVisibleToCPU=true,bool bVisibleToGPU=true,bool ReturnValue) { return default; }
	public int Num(int ReturnValue) { return default; }
	public void WriteFloat(sbyte VarName,int Index,double InData) {}
	public void WriteVector2D(sbyte VarName,int Index,FVector2D InData) {}
	public void WriteVector(sbyte VarName,int Index,FVector InData) {}
	public void WriteVector4(sbyte VarName,int Index,FVector4 InData) {}
	public void WriteQuat(sbyte VarName,int Index,FQuat InData) {}
	public void WriteLinearColor(sbyte VarName,int Index,FLinearColor InData) {}
	public void WriteInt(sbyte VarName,int Index,int InData) {}
	public void WriteBool(sbyte VarName,int Index,bool InData) {}
	public void WriteSpawnInfo(sbyte VarName,int Index,FNiagaraSpawnInfo InData) {}
}
