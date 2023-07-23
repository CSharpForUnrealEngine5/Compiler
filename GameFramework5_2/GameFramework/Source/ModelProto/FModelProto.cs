#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ModelProto.h")]
///<summary>Level 0 - FModelProto</summary>
public partial struct FModelProto {
// ModelProto
	public bool bIsLoaded;
	public long IRVersion;
	public TArray<FOperatorSetIdProto> OpsetImport;
	public sbyte ProducerName;
	public sbyte ProducerVersion;
	public sbyte Domain;
	public long ModelVersion;
	public sbyte DocString;
	public FGraphProto Graph;
	public TArray<FStringStringEntryProto> MetadataProps;
	public TArray<FTrainingInfoProto> TrainingInfo;
}
