#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ContextualAnimSceneAsset.h")]
///<summary>Named container with one or more ContextualAnimSet</summary>
public partial struct FContextualAnimSceneSection {
// ContextualAnimSceneSection
	public sbyte Name;
	public TArray<FContextualAnimSet> AnimSets;
	public TMap<sbyte,FContextualAnimIKTargetDefContainer> RoleToIKTargetDefsMap;
	public TArray<FContextualAnimSetPivotDefinition> AnimSetPivotDefinitions;
}
