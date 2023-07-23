#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MuCOE/Nodes/CustomizableObjectNodeTable.h")]
///<summary>Additional data for a Mesh pins.</summary>
public partial class UCustomizableObjectNodeTableMeshPinData : UCustomizableObjectNodeTableObjectPinData {
// CustomizableObjectNodeTableMeshPinData
	public sbyte AnimInstanceColumnName;
	public sbyte AnimSlotColumnName;
	public sbyte AnimTagColumnName;
	public sbyte MutableColumnName;
	public int LOD;
	public int Material;
	public TArray<UCustomizableObjectLayout> Layouts;
}
