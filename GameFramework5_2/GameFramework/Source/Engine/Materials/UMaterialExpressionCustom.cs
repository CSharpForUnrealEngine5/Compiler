#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionCustom.h")]
public partial class UMaterialExpressionCustom : UMaterialExpression {
// MaterialExpressionCustom
	public sbyte Code;
	public byte OutputType;
	public sbyte Description;
	public TArray<FCustomInput> Inputs;
	public TArray<FCustomOutput> AdditionalOutputs;
	public TArray<FCustomDefine> AdditionalDefines;
	public TArray<sbyte> IncludeFilePaths;
}
