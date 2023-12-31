#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DatasmithDefinitions.h")]
///<summary>Describes a category of an UPropertyValue asset, indicating types of</summary>
public enum EDatasmithPropertyCategory {
	Undefined=0,
	Generic=1,
	RelativeLocation=2,
	RelativeRotation=4,
	RelativeScale3D=8,
	Visibility=16,
	Material=32,
	Color=64,
	Option=128,
}
