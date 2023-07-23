#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MuCOE/Nodes/CustomizableObjectNodeGroupProjectorParameter.h")]
public partial class UCustomizableObjectNodeGroupProjectorParameter : UCustomizableObjectNodeProjectorParameter {
// CustomizableObjectNodeGroupProjectorParameter
	public sbyte MaterialChannelNameToConnect;
	public sbyte MaskedOutAreaMaterialChannelName;
	public UTexture2D ReferenceTexture;
	public int ProjectionTextureSize;
	public int DropProjectionTextureAtLOD;
	public bool bShareProjectionTexturesBetweenLODs;
	public TArray<FGroupProjectorParameterImage> OptionImages;
	public TArray<FGroupProjectorParameterPose> OptionPoses;
	public sbyte DataTableTextureColumnName;
	public UDataTable OptionImagesDataTable;
	public sbyte AlternateProjectionResolutionStateName;
	public float AlternateProjectionResolutionFactor;
	public int UVLayout;
	public FEdGraphPinReference ImagePin;
}
