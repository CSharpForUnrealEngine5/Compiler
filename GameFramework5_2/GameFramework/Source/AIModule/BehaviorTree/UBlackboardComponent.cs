#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BehaviorTree/BlackboardComponent.h")]
public partial class UBlackboardComponent : UActorComponent {
// BlackboardComponent
	public UObject GetValueAsObject(sbyte KeyName,UObject ReturnValue) { return default; }
	public UClass GetValueAsClass(sbyte KeyName,UClass ReturnValue) { return default; }
	public byte GetValueAsEnum(sbyte KeyName,byte ReturnValue) { return default; }
	public int GetValueAsInt(sbyte KeyName,int ReturnValue) { return default; }
	public float GetValueAsFloat(sbyte KeyName,float ReturnValue) { return default; }
	public bool GetValueAsBool(sbyte KeyName,bool ReturnValue) { return default; }
	public sbyte GetValueAsString(sbyte KeyName,sbyte ReturnValue) { return default; }
	public sbyte GetValueAsName(sbyte KeyName,sbyte ReturnValue) { return default; }
	public FVector GetValueAsVector(sbyte KeyName,FVector ReturnValue) { return default; }
	public FRotator GetValueAsRotator(sbyte KeyName,FRotator ReturnValue) { return default; }
	public void SetValueAsObject(sbyte KeyName,UObject ObjectValue) {}
	public void SetValueAsClass(sbyte KeyName,UClass ClassValue) {}
	public void SetValueAsEnum(sbyte KeyName,byte EnumValue) {}
	public void SetValueAsInt(sbyte KeyName,int IntValue) {}
	public void SetValueAsFloat(sbyte KeyName,float FloatValue) {}
	public void SetValueAsBool(sbyte KeyName,bool BoolValue) {}
	public void SetValueAsString(sbyte KeyName,sbyte StringValue) {}
	public void SetValueAsName(sbyte KeyName,sbyte NameValue) {}
	public void SetValueAsVector(sbyte KeyName,FVector VectorValue) {}
	public void SetValueAsRotator(sbyte KeyName,FRotator VectorValue) {}
	public bool IsVectorValueSet(sbyte KeyName,bool ReturnValue) { return default; }
	public bool GetLocationFromEntry(sbyte KeyName,FVector ResultLocation,bool ReturnValue) { return default; }
	public bool GetRotationFromEntry(sbyte KeyName,FRotator ResultRotation,bool ReturnValue) { return default; }
	public void ClearValue(sbyte KeyName) {}
	public UBrainComponent BrainComp;
	public UBlackboardData DefaultBlackboardAsset;
	public UBlackboardData BlackboardAsset;
	public TArray<UBlackboardKeyType> KeyInstances;
}
