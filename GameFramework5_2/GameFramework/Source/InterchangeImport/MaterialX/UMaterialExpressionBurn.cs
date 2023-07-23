#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MaterialX/MaterialExpressionBurn.h")]
///<summary>Blend nodes take two 1-4 channel inputs and apply the same operator to all channels.</summary>
public partial class UMaterialExpressionBurn : UMaterialExpression {
// MaterialExpressionBurn
	public FExpressionInput A;
	public FExpressionInput B;
	public FExpressionInput Alpha;
	public float ConstAlpha;
}
