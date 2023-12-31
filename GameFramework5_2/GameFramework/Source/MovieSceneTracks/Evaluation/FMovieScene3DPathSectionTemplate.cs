#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Evaluation/MovieScene3DPathTemplate.h")]
public partial struct FMovieScene3DPathSectionTemplate {
// MovieScene3DPathSectionTemplate
	public FMovieSceneObjectBindingID PathBindingID;
	public FMovieSceneFloatChannel TimingCurve;
	public MovieScene3DPathSection_Axis FrontAxisEnum;
	public MovieScene3DPathSection_Axis UpAxisEnum;
	public bool bFollow;
	public bool bReverse;
	public bool bForceUpright;
}
