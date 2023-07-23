#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/AnimMontage.h")]
///<summary>Section data for each track. Reference of data will be stored in the child class for the way they want</summary>
public partial struct FCompositeSection {
// CompositeSection
	public sbyte SectionName;
	public float StartTime_DEPRECATED;
	public sbyte NextSectionName;
	public TArray<UAnimMetaData> MetaData;
}
