#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Editor/PropertyEditorTestObject.h")]
public partial class APropertyEditorTestActor : AActor {
// PropertyEditorTestActor
	public TArray<UPropertyEditorTestInstancedObject> InstancedUObjectArray;
	public sbyte GetOptionsValue;
	public float DefaultsOnly;
	public float DefaultsOnlySubcategory;
	public float InstanceOnly;
	public float InstanceOnlySubcategory;
	public TMap<int,sbyte> MultiLineMap;
	public TArray<sbyte> GetOptionsFunc(TArray<sbyte> ReturnValue) { return default; }
}
