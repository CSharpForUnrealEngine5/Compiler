#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CompositingElements/CompositingMaterialPass.h")]
public partial struct FCompositingMaterial {
// CompositingMaterial
	public UMaterialInterface Material;
	public TMap<sbyte,sbyte> ParamPassMappings;
	public TMap<sbyte,FNamedCompMaterialParam> RequiredMaterialParams;
	public TArray<sbyte> EditorHiddenParams;
	public TMap<sbyte,FLinearColor> VectorOverrideProxies;
	public UMaterialInstanceDynamic CachedMID;
}
