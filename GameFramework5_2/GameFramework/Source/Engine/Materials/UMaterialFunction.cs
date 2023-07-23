#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialFunction.h")]
///<summary>A Material Function is a collection of material expressions that can be reused in different materials</summary>
public partial class UMaterialFunction : UMaterialFunctionInterface {
// MaterialFunction
	public UMaterialFunction ParentFunction;
	public sbyte Description;
	public bool bExposeToLibrary;
	public bool bPrefixParameterNames;
	public bool bEnableExecWire;
	public bool bEnableNewHLSLGenerator;
	public TArray<sbyte> LibraryCategories_DEPRECATED;
	public TArray<sbyte> LibraryCategoriesText;
	public UMaterial PreviewMaterial;
	public TArray<UMaterialExpressionMaterialFunctionCall> DependentFunctionExpressionCandidates;
	public byte PreviewBlendMode;
	public bool bReentrantFlag;
	public TArray<UMaterialExpression> FunctionExpressions_DEPRECATED;
	public TArray<UMaterialExpressionComment> FunctionEditorComments_DEPRECATED;
	public UMaterialExpressionExecBegin ExpressionExecBegin_DEPRECATED;
	public UMaterialExpressionExecEnd ExpressionExecEnd_DEPRECATED;
}
