#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CommonDateTimeTextBlock.h")]
public partial class UCommonDateTimeTextBlock : UCommonTextBlock {
// CommonDateTimeTextBlock
	public void SetDateTimeValue(FDateTime InDateTime,bool bShowAsCountdown,float InRefreshDelay=1.0f) {}
	public void SetTimespanValue(FTimespan InTimespan) {}
	public void SetCountDownCompletionText(sbyte InCompletionText) {}
	public FDateTime GetDateTime(FDateTime ReturnValue) { return default; }
}
