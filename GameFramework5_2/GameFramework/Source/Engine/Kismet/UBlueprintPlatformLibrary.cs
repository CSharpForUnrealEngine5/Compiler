#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Kismet/BlueprintPlatformLibrary.h")]
public partial class UBlueprintPlatformLibrary : UBlueprintFunctionLibrary {
// BlueprintPlatformLibrary
	public void ClearAllLocalNotifications() {}
	public int ScheduleLocalNotificationAtTime(FDateTime FireDateTime,bool LocalTime,sbyte Title,sbyte Body,sbyte Action,sbyte ActivationEvent,int ReturnValue) { return default; }
	public int ScheduleLocalNotificationFromNow(int inSecondsFromNow,sbyte Title,sbyte Body,sbyte Action,sbyte ActivationEvent,int ReturnValue) { return default; }
	public int ScheduleLocalNotificationBadgeAtTime(FDateTime FireDateTime,bool LocalTime,sbyte ActivationEvent,int ReturnValue) { return default; }
	public void ScheduleLocalNotificationBadgeFromNow(int inSecondsFromNow,sbyte ActivationEvent) {}
	public void CancelLocalNotification(sbyte ActivationEvent) {}
	public void CancelLocalNotificationById(int NotificationId) {}
	public void GetLaunchNotification(bool NotificationLaunchedApp,sbyte ActivationEvent,int FireDate) {}
	public EScreenOrientation GetDeviceOrientation(EScreenOrientation ReturnValue) { return default; }
	public EScreenOrientation GetAllowedDeviceOrientation(EScreenOrientation ReturnValue) { return default; }
	public void SetAllowedDeviceOrientation(EScreenOrientation NewAllowedDeviceOrientation) {}
}
