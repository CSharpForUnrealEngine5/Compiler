#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ModelProto.h")]
///<summary>Level 4 - FAttributeProto</summary>
public partial struct FAttributeProto {
// AttributeProto
	public sbyte Name;
	public sbyte DocString;
	public EAttributeProtoAttributeType Type;
	public float F;
	public long I;
	public sbyte S;
	public FTensorProto T;
	public FSparseTensorProto SparseTensor;
	public TArray<float> Floats;
	public TArray<long> Integers;
	public TArray<sbyte> Strings;
	public TArray<FTensorProto> Tensors;
	public TArray<FSparseTensorProto> SparseTensors;
}
