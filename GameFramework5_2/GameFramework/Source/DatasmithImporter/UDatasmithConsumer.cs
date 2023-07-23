#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DatasmithConsumer.h")]
public partial class UDatasmithConsumer : UDataprepContentConsumer {
// DatasmithConsumer
	public TSoftObjectPtr<UDatasmithScene> DatasmithScene_DEPRECATED;
	public sbyte UniqueID;
	public UObject GetDatasmithScene(UObject ReturnValue) { return default; }
	public sbyte DatasmithSceneObjectPath;
	public sbyte OutputLevelObjectPath;
	public FSoftObjectPath OutputLevelSoftObject_DEPRECATED;
	public TWeakObjectPtr<UDatasmithScene> DatasmithSceneWeakPtr;
}
