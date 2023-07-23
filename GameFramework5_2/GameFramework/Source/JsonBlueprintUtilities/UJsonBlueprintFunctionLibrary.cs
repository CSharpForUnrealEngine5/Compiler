#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("JsonBlueprintFunctionLibrary.h")]
public partial class UJsonBlueprintFunctionLibrary : UBlueprintFunctionLibrary {
// JsonBlueprintFunctionLibrary
	public bool FromString(UObject WorldContextObject,sbyte JsonString,FJsonObjectWrapper OutJsonObject,bool ReturnValue) { return default; }
	public bool FromFile(UObject WorldContextObject,FFilePath File,FJsonObjectWrapper OutJsonObject,bool ReturnValue) { return default; }
	public bool ToString(FJsonObjectWrapper JsonObject,sbyte OutJsonString,bool ReturnValue) { return default; }
	public bool ToFile(FJsonObjectWrapper JsonObject,FFilePath File,bool ReturnValue) { return default; }
	public bool GetField(FJsonObjectWrapper JsonObject,sbyte FieldName,int OutValue,bool ReturnValue) { return default; }
	public bool SetField(FJsonObjectWrapper JsonObject,sbyte FieldName,int Value,bool ReturnValue) { return default; }
	public bool StructToJsonString(int Struct,sbyte OutJsonString,bool ReturnValue) { return default; }
	public bool HasField(FJsonObjectWrapper JsonObject,sbyte FieldName,bool ReturnValue) { return default; }
	public bool GetFieldNames(FJsonObjectWrapper JsonObject,TArray<sbyte> FieldNames,bool ReturnValue) { return default; }
}
