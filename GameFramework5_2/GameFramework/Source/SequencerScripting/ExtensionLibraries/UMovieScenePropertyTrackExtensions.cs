#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ExtensionLibraries/MovieScenePropertyTrackExtensions.h")]
///<summary>Function library containing methods that should be hoisted onto UMovieScenePropertyTrack for scripting</summary>
public partial class UMovieScenePropertyTrackExtensions : UBlueprintFunctionLibrary {
// MovieScenePropertyTrackExtensions
	public void SetPropertyNameAndPath(UObject Track,sbyte InPropertyName,sbyte InPropertyPath) {}
	public sbyte GetPropertyName(UObject Track,sbyte ReturnValue) { return default; }
	public sbyte GetPropertyPath(UObject Track,sbyte ReturnValue) { return default; }
	public sbyte GetUniqueTrackName(UObject Track,sbyte ReturnValue) { return default; }
	public void SetObjectPropertyClass(UObject Track,UClass PropertyClass) {}
	public UClass GetObjectPropertyClass(UObject Track,UClass ReturnValue) { return default; }
	public void SetByteTrackEnum(UObject Track,UObject InEnum) {}
	public UObject GetByteTrackEnum(UObject Track,UObject ReturnValue) { return default; }
}
