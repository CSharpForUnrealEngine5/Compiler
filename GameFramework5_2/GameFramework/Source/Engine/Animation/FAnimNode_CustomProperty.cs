#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/AnimNode_CustomProperty.h")]
///<summary>Custom property node that you'd like to expand pin by reflecting internal instance (we call TargetInstance here)</summary>
public partial struct FAnimNode_CustomProperty {
// AnimNode_CustomProperty
	public TArray<sbyte> SourcePropertyNames;
	public TArray<sbyte> DestPropertyNames;
	public UObject TargetInstance;
	public UObject SourceInstance;
}
