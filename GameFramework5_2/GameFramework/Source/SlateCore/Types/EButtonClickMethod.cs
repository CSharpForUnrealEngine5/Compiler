#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Types/SlateEnums.h")]
///<summary>Enumerates different methods that a button click can be triggered. Normally, DownAndUp is appropriate.</summary>
public enum EButtonClickMethod {
	DownAndUp=0,
	MouseDown=1,
	MouseUp=2,
	PreciseClick=3,
}
