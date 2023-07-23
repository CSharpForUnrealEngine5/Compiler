#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraDataChannelAccessor.h")]
///<summary>Initial simple API for reading and writing data in a data channel from game code / BP.</summary>
public partial class UNiagaraDataChannelReader : UObject {
// NiagaraDataChannelReader
	public UNiagaraDataChannelHandler Owner;
	public bool InitAccess(UObject OwningComponent,bool ReturnValue) { return default; }
	public int Num(int ReturnValue) { return default; }
	public double ReadFloat(sbyte VarName,int Index,double ReturnValue) { return default; }
	public FVector2D ReadVector2D(sbyte VarName,int Index,FVector2D ReturnValue) { return default; }
	public FVector ReadVector(sbyte VarName,int Index,FVector ReturnValue) { return default; }
	public FVector4 ReadVector4(sbyte VarName,int Index,FVector4 ReturnValue) { return default; }
	public FQuat ReadQuat(sbyte VarName,int Index,FQuat ReturnValue) { return default; }
	public FLinearColor ReadLinearColor(sbyte VarName,int Index,FLinearColor ReturnValue) { return default; }
	public int ReadInt(sbyte VarName,int Index,int ReturnValue) { return default; }
	public bool ReadBool(sbyte VarName,int Index,bool ReturnValue) { return default; }
}
