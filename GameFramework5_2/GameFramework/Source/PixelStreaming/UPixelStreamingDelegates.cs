#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PixelStreamingDelegates.h")]
public partial class UPixelStreamingDelegates : UObject {
// PixelStreamingDelegates
	public void FConnectedToSignallingServer() {}
	public FConnectedToSignallingServer OnConnectedToSignallingServer;
	public void FDisconnectedFromSignallingServer() {}
	public FDisconnectedFromSignallingServer OnDisconnectedFromSignallingServer;
	public void FNewConnection(sbyte StreamerId,sbyte PlayerId,bool QualityController) {}
	public FNewConnection OnNewConnection;
	public void FClosedConnection(sbyte StreamerId,sbyte PlayerId,bool WasQualityController) {}
	public FClosedConnection OnClosedConnection;
	public void FAllConnectionsClosed(sbyte StreamerId) {}
	public FAllConnectionsClosed OnAllConnectionsClosed;
	public void FStatsChanged(sbyte PlayerId,sbyte StatName,float StatValue) {}
	public FStatsChanged OnStatChanged;
	public void FFallbackToSoftwareEncodering() {}
	public FFallbackToSoftwareEncodering OnFallbackToSoftwareEncodering;
}
