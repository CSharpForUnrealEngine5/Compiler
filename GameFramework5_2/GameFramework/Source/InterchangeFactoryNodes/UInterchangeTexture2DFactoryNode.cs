#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("InterchangeTexture2DFactoryNode.h")]
///<summary>ns UE::Interchange</summary>
public partial class UInterchangeTexture2DFactoryNode : UInterchangeTextureFactoryNode {
// InterchangeTexture2DFactoryNode
	public bool GetCustomAddressX(byte AttributeValue,bool ReturnValue) { return default; }
	public bool SetCustomAddressX(byte AttributeValue,bool bAddApplyDelegate=true,bool ReturnValue) { return default; }
	public bool GetCustomAddressY(byte AttributeValue,bool ReturnValue) { return default; }
	public bool SetCustomAddressY(byte AttributeValue,bool bAddApplyDelegate=true,bool ReturnValue) { return default; }
	public TMap<int,sbyte> GetSourceBlocks(TMap<int,sbyte> ReturnValue) { return default; }
	public void SetSourceBlocks(TMap<int,sbyte> InSourceBlocks) {}
	public bool GetSourceBlockByCoordinates(int X,int Y,sbyte OutSourceFile,bool ReturnValue) { return default; }
	public bool GetSourceBlock(int BlockIndex,sbyte OutSourceFile,bool ReturnValue) { return default; }
	public void SetSourceBlockByCoordinates(int X,int Y,sbyte InSourceFile) {}
	public void SetSourceBlock(int BlockIndex,sbyte InSourceFile) {}
}
