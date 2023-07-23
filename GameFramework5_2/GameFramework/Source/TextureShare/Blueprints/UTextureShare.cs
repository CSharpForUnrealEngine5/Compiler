#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Blueprints/TextureShareBlueprintContainers.h")]
///<summary>TextureShare UObject interface</summary>
public partial class UTextureShare : UObject {
// TextureShare
	public UObject GetOrCreateTextureShareObject(sbyte InShareName,UObject ReturnValue) { return default; }
	public bool RemoveTextureShareObject(sbyte InShareName,bool ReturnValue) { return default; }
	public TArray<UObject> GetTextureShareObjects(TArray<UObject> ReturnValue) { return default; }
	public bool bEnable;
	public sbyte ProcessName;
	public TArray<UTextureShareObject> TextureShareObjects;
}
