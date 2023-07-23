#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnalyticsBlueprintLibrary.h")]
public partial class UAnalyticsBlueprintLibrary : UBlueprintFunctionLibrary {
// AnalyticsBlueprintLibrary
	public bool StartSession(bool ReturnValue) { return default; }
	public bool StartSessionWithAttributes(TArray<FAnalyticsEventAttr> Attributes,bool ReturnValue) { return default; }
	public void EndSession() {}
	public void FlushEvents() {}
	public void RecordEvent(sbyte EventName) {}
	public void RecordEventWithAttribute(sbyte EventName,sbyte AttributeName,sbyte AttributeValue) {}
	public void RecordEventWithAttributes(sbyte EventName,TArray<FAnalyticsEventAttr> Attributes) {}
	public void RecordItemPurchase(sbyte ItemId,sbyte Currency,int PerItemCost,int ItemQuantity) {}
	public void RecordSimpleItemPurchase(sbyte ItemId,int ItemQuantity) {}
	public void RecordSimpleItemPurchaseWithAttributes(sbyte ItemId,int ItemQuantity,TArray<FAnalyticsEventAttr> Attributes) {}
	public void RecordSimpleCurrencyPurchase(sbyte GameCurrencyType,int GameCurrencyAmount) {}
	public void RecordSimpleCurrencyPurchaseWithAttributes(sbyte GameCurrencyType,int GameCurrencyAmount,TArray<FAnalyticsEventAttr> Attributes) {}
	public void RecordCurrencyPurchase(sbyte GameCurrencyType,int GameCurrencyAmount,sbyte RealCurrencyType,float RealMoneyCost,sbyte PaymentProvider) {}
	public void RecordCurrencyGiven(sbyte GameCurrencyType,int GameCurrencyAmount) {}
	public void RecordCurrencyGivenWithAttributes(sbyte GameCurrencyType,int GameCurrencyAmount,TArray<FAnalyticsEventAttr> Attributes) {}
	public FAnalyticsEventAttr MakeEventAttribute(sbyte AttributeName,sbyte AttributeValue,FAnalyticsEventAttr ReturnValue) { return default; }
	public sbyte GetSessionId(sbyte ReturnValue) { return default; }
	public void SetSessionId(sbyte SessionId) {}
	public sbyte GetUserId(sbyte ReturnValue) { return default; }
	public void SetUserId(sbyte UserId) {}
	public void SetAge(int Age) {}
	public void SetLocation(sbyte Location) {}
	public void SetGender(sbyte Gender) {}
	public void SetBuildInfo(sbyte BuildInfo) {}
	public void RecordErrorWithAttributes(sbyte Error,TArray<FAnalyticsEventAttr> Attributes) {}
	public void RecordError(sbyte Error) {}
	public void RecordProgressWithFullHierarchyAndAttributes(sbyte ProgressType,TArray<sbyte> ProgressNames,TArray<FAnalyticsEventAttr> Attributes) {}
	public void RecordProgressWithAttributes(sbyte ProgressType,sbyte ProgressName,TArray<FAnalyticsEventAttr> Attributes) {}
	public void RecordProgress(sbyte ProgressType,sbyte ProgressName) {}
}
