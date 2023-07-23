#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("TimedDataMonitorSubsystem.h")]
public partial class UTimedDataMonitorSubsystem : UEngineSubsystem {
// TimedDataMonitorSubsystem
	public FTimedDataIdentifierListChangedSignature OnIdentifierListChanged_Dynamic;
	public TArray<FTimedDataMonitorInputIdentifier> GetAllInputs(TArray<FTimedDataMonitorInputIdentifier> ReturnValue) { return default; }
	public TArray<FTimedDataMonitorChannelIdentifier> GetAllChannels(TArray<FTimedDataMonitorChannelIdentifier> ReturnValue) { return default; }
	public TArray<FTimedDataMonitorChannelIdentifier> GetAllEnabledChannels(TArray<FTimedDataMonitorChannelIdentifier> ReturnValue) { return default; }
	public void CalibrateLatent(UObject WorldContextObject,FLatentActionInfo LatentInfo,FTimedDataMonitorCalibrationParameters CalibrationParameters,FTimedDataMonitorCalibrationResult Result) {}
	public FTimedDataMonitorTimeCorrectionResult ApplyTimeCorrection(FTimedDataMonitorInputIdentifier Identifier,FTimedDataMonitorTimeCorrectionParameters TimeCorrectionParameters,FTimedDataMonitorTimeCorrectionResult ReturnValue) { return default; }
	public void ResetAllBufferStats() {}
	public ETimedDataMonitorEvaluationState GetEvaluationState(ETimedDataMonitorEvaluationState ReturnValue) { return default; }
	public bool DoesInputExist(FTimedDataMonitorInputIdentifier Identifier,bool ReturnValue) { return default; }
	public ETimedDataMonitorInputEnabled GetInputEnabled(FTimedDataMonitorInputIdentifier Identifier,ETimedDataMonitorInputEnabled ReturnValue) { return default; }
	public void SetInputEnabled(FTimedDataMonitorInputIdentifier Identifier,bool bInEnabled) {}
	public sbyte GetInputDisplayName(FTimedDataMonitorInputIdentifier Identifier,sbyte ReturnValue) { return default; }
	public TArray<FTimedDataMonitorChannelIdentifier> GetInputChannels(FTimedDataMonitorInputIdentifier Identifier,TArray<FTimedDataMonitorChannelIdentifier> ReturnValue) { return default; }
	public ETimedDataInputEvaluationType GetInputEvaluationType(FTimedDataMonitorInputIdentifier Identifier,ETimedDataInputEvaluationType ReturnValue) { return default; }
	public void SetInputEvaluationType(FTimedDataMonitorInputIdentifier Identifier,ETimedDataInputEvaluationType Evaluation) {}
	public float GetInputEvaluationOffsetInSeconds(FTimedDataMonitorInputIdentifier Identifier,float ReturnValue) { return default; }
	public void SetInputEvaluationOffsetInSeconds(FTimedDataMonitorInputIdentifier Identifier,float Seconds) {}
	public float GetInputEvaluationOffsetInFrames(FTimedDataMonitorInputIdentifier Identifier,float ReturnValue) { return default; }
	public void SetInputEvaluationOffsetInFrames(FTimedDataMonitorInputIdentifier Identifier,float Frames) {}
	public FFrameRate GetInputFrameRate(FTimedDataMonitorInputIdentifier Identifier,FFrameRate ReturnValue) { return default; }
	public FTimedDataChannelSampleTime GetInputOldestDataTime(FTimedDataMonitorInputIdentifier Identifier,FTimedDataChannelSampleTime ReturnValue) { return default; }
	public FTimedDataChannelSampleTime GetInputNewestDataTime(FTimedDataMonitorInputIdentifier Identifier,FTimedDataChannelSampleTime ReturnValue) { return default; }
	public bool IsDataBufferSizeControlledByInput(FTimedDataMonitorInputIdentifier Identifier,bool ReturnValue) { return default; }
	public int GetInputDataBufferSize(FTimedDataMonitorInputIdentifier Identifier,int ReturnValue) { return default; }
	public void SetInputDataBufferSize(FTimedDataMonitorInputIdentifier Identifier,int BufferSize) {}
	public ETimedDataInputState GetInputConnectionState(FTimedDataMonitorInputIdentifier Identifier,ETimedDataInputState ReturnValue) { return default; }
	public ETimedDataMonitorEvaluationState GetInputEvaluationState(FTimedDataMonitorInputIdentifier Identifier,ETimedDataMonitorEvaluationState ReturnValue) { return default; }
	public float GetInputEvaluationDistanceToNewestSampleMean(FTimedDataMonitorInputIdentifier Identifier,float ReturnValue) { return default; }
	public float GetInputEvaluationDistanceToOldestSampleMean(FTimedDataMonitorInputIdentifier Identifier,float ReturnValue) { return default; }
	public float GetInputEvaluationDistanceToNewestSampleStandardDeviation(FTimedDataMonitorInputIdentifier Identifier,float ReturnValue) { return default; }
	public float GetInputEvaluationDistanceToOldestSampleStandardDeviation(FTimedDataMonitorInputIdentifier Identifier,float ReturnValue) { return default; }
	public bool DoesChannelExist(FTimedDataMonitorChannelIdentifier Identifier,bool ReturnValue) { return default; }
	public bool IsChannelEnabled(FTimedDataMonitorChannelIdentifier Identifier,bool ReturnValue) { return default; }
	public void SetChannelEnabled(FTimedDataMonitorChannelIdentifier Identifier,bool bEnabled) {}
	public FTimedDataMonitorInputIdentifier GetChannelInput(FTimedDataMonitorChannelIdentifier Identifier,FTimedDataMonitorInputIdentifier ReturnValue) { return default; }
	public sbyte GetChannelDisplayName(FTimedDataMonitorChannelIdentifier Identifier,sbyte ReturnValue) { return default; }
	public ETimedDataInputState GetChannelConnectionState(FTimedDataMonitorChannelIdentifier Identifier,ETimedDataInputState ReturnValue) { return default; }
	public ETimedDataMonitorEvaluationState GetChannelEvaluationState(FTimedDataMonitorChannelIdentifier Identifier,ETimedDataMonitorEvaluationState ReturnValue) { return default; }
	public FTimedDataChannelSampleTime GetChannelOldestDataTime(FTimedDataMonitorChannelIdentifier Identifier,FTimedDataChannelSampleTime ReturnValue) { return default; }
	public FTimedDataChannelSampleTime GetChannelNewestDataTime(FTimedDataMonitorChannelIdentifier Identifier,FTimedDataChannelSampleTime ReturnValue) { return default; }
	public TArray<FTimedDataChannelSampleTime> GetChannelFrameDataTimes(FTimedDataMonitorChannelIdentifier Identifier,TArray<FTimedDataChannelSampleTime> ReturnValue) { return default; }
	public int GetChannelNumberOfSamples(FTimedDataMonitorChannelIdentifier Identifier,int ReturnValue) { return default; }
	public int GetChannelDataBufferSize(FTimedDataMonitorChannelIdentifier Identifier,int ReturnValue) { return default; }
	public void SetChannelDataBufferSize(FTimedDataMonitorChannelIdentifier Identifier,int BufferSize) {}
	public int GetChannelBufferUnderflowStat(FTimedDataMonitorChannelIdentifier Identifier,int ReturnValue) { return default; }
	public int GetChannelBufferOverflowStat(FTimedDataMonitorChannelIdentifier Identifier,int ReturnValue) { return default; }
	public int GetChannelFrameDroppedStat(FTimedDataMonitorChannelIdentifier Identifier,int ReturnValue) { return default; }
	public void GetChannelLastEvaluationDataStat(FTimedDataMonitorChannelIdentifier Identifier,FTimedDataInputEvaluationData Result) {}
	public float GetChannelEvaluationDistanceToNewestSampleMean(FTimedDataMonitorChannelIdentifier Identifier,float ReturnValue) { return default; }
	public float GetChannelEvaluationDistanceToOldestSampleMean(FTimedDataMonitorChannelIdentifier Identifier,float ReturnValue) { return default; }
	public float GetChannelEvaluationDistanceToNewestSampleStandardDeviation(FTimedDataMonitorChannelIdentifier Identifier,float ReturnValue) { return default; }
	public float GetChannelEvaluationDistanceToOldestSampleStandardDeviation(FTimedDataMonitorChannelIdentifier Identifier,float ReturnValue) { return default; }
}
