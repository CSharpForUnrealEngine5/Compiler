#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Blueprint/UserWidget.h")]
///<summary>The user widget is extensible by users through the WidgetBlueprint.</summary>
public partial class UUserWidget : UWidget {
// UserWidget
	public void AddToViewport(int ZOrder=0) {}
	public bool AddToPlayerScreen(int ZOrder=0,bool ReturnValue) { return default; }
	public void RemoveFromViewport() {}
	public void SetPositionInViewport(FVector2D Position,bool bRemoveDPIScale=true) {}
	public void SetDesiredSizeInViewport(FVector2D Size) {}
	public void SetAnchorsInViewport(FAnchors Anchors) {}
	public void SetAlignmentInViewport(FVector2D Alignment) {}
	public FAnchors GetAnchorsInViewport(FAnchors ReturnValue) { return default; }
	public FVector2D GetAlignmentInViewport(FVector2D ReturnValue) { return default; }
	public bool GetIsVisible(bool ReturnValue) { return default; }
	public void SetOwningPlayer(UObject LocalPlayerController) {}
	public UObject GetOwningPlayerPawn(UObject ReturnValue) { return default; }
	public UObject GetOwningPlayerCameraManager(UObject ReturnValue) { return default; }
	public void OnInitialized() {}
	public void PreConstruct(bool IsDesignTime) {}
	public void Construct() {}
	public void Destruct() {}
	public void Tick(FGeometry MyGeometry,float InDeltaTime) {}
	public void OnPaint(FPaintContext Context) {}
	public bool IsInteractable(bool ReturnValue) { return default; }
	public FEventReply OnFocusReceived(FGeometry MyGeometry,FFocusEvent InFocusEvent,FEventReply ReturnValue) { return default; }
	public void OnFocusLost(FFocusEvent InFocusEvent) {}
	public void OnAddedToFocusPath(FFocusEvent InFocusEvent) {}
	public void OnRemovedFromFocusPath(FFocusEvent InFocusEvent) {}
	public FEventReply OnKeyChar(FGeometry MyGeometry,FCharacterEvent InCharacterEvent,FEventReply ReturnValue) { return default; }
	public FEventReply OnPreviewKeyDown(FGeometry MyGeometry,FKeyEvent InKeyEvent,FEventReply ReturnValue) { return default; }
	public FEventReply OnKeyDown(FGeometry MyGeometry,FKeyEvent InKeyEvent,FEventReply ReturnValue) { return default; }
	public FEventReply OnKeyUp(FGeometry MyGeometry,FKeyEvent InKeyEvent,FEventReply ReturnValue) { return default; }
	public FEventReply OnAnalogValueChanged(FGeometry MyGeometry,FAnalogInputEvent InAnalogInputEvent,FEventReply ReturnValue) { return default; }
	public FEventReply OnMouseButtonDown(FGeometry MyGeometry,FPointerEvent MouseEvent,FEventReply ReturnValue) { return default; }
	public FEventReply OnPreviewMouseButtonDown(FGeometry MyGeometry,FPointerEvent MouseEvent,FEventReply ReturnValue) { return default; }
	public FEventReply OnMouseButtonUp(FGeometry MyGeometry,FPointerEvent MouseEvent,FEventReply ReturnValue) { return default; }
	public FEventReply OnMouseMove(FGeometry MyGeometry,FPointerEvent MouseEvent,FEventReply ReturnValue) { return default; }
	public void OnMouseEnter(FGeometry MyGeometry,FPointerEvent MouseEvent) {}
	public void OnMouseLeave(FPointerEvent MouseEvent) {}
	public FEventReply OnMouseWheel(FGeometry MyGeometry,FPointerEvent MouseEvent,FEventReply ReturnValue) { return default; }
	public FEventReply OnMouseButtonDoubleClick(FGeometry InMyGeometry,FPointerEvent InMouseEvent,FEventReply ReturnValue) { return default; }
	public void OnDragDetected(FGeometry MyGeometry,FPointerEvent PointerEvent,UObject Operation) {}
	public void OnDragCancelled(FPointerEvent PointerEvent,UObject Operation) {}
	public void OnDragEnter(FGeometry MyGeometry,FPointerEvent PointerEvent,UObject Operation) {}
	public void OnDragLeave(FPointerEvent PointerEvent,UObject Operation) {}
	public bool OnDragOver(FGeometry MyGeometry,FPointerEvent PointerEvent,UObject Operation,bool ReturnValue) { return default; }
	public bool OnDrop(FGeometry MyGeometry,FPointerEvent PointerEvent,UObject Operation,bool ReturnValue) { return default; }
	public FEventReply OnTouchGesture(FGeometry MyGeometry,FPointerEvent GestureEvent,FEventReply ReturnValue) { return default; }
	public FEventReply OnTouchStarted(FGeometry MyGeometry,FPointerEvent InTouchEvent,FEventReply ReturnValue) { return default; }
	public FEventReply OnTouchMoved(FGeometry MyGeometry,FPointerEvent InTouchEvent,FEventReply ReturnValue) { return default; }
	public FEventReply OnTouchEnded(FGeometry MyGeometry,FPointerEvent InTouchEvent,FEventReply ReturnValue) { return default; }
	public FEventReply OnMotionDetected(FGeometry MyGeometry,FMotionEvent InMotionEvent,FEventReply ReturnValue) { return default; }
	public void OnMouseCaptureLost() {}
	public void CancelLatentActions() {}
	public void StopAnimationsAndLatentActions() {}
	public FEventReply OnTouchForceChanged(FGeometry MyGeometry,FPointerEvent InTouchEvent,FEventReply ReturnValue) { return default; }
	public void BindToAnimationStarted(UObject Animation,FWidgetAnimationDynamicEvent Delegate) {}
	public void UnbindFromAnimationStarted(UObject Animation,FWidgetAnimationDynamicEvent Delegate) {}
	public void UnbindAllFromAnimationStarted(UObject Animation) {}
	public void BindToAnimationFinished(UObject Animation,FWidgetAnimationDynamicEvent Delegate) {}
	public void UnbindFromAnimationFinished(UObject Animation,FWidgetAnimationDynamicEvent Delegate) {}
	public void UnbindAllFromAnimationFinished(UObject Animation) {}
	public void BindToAnimationEvent(UObject Animation,FWidgetAnimationDynamicEvent Delegate,EWidgetAnimationEvent AnimationEvent,sbyte UserTag=NAME_None) {}
	public void OnAnimationStarted(UObject Animation) {}
	public void OnAnimationFinished(UObject Animation) {}
	public FLinearColor ColorAndOpacity;
	public FGetLinearColor ColorAndOpacityDelegate;
	public FSlateColor ForegroundColor;
	public FGetSlateColor ForegroundColorDelegate;
	public FOnVisibilityChangedEvent OnVisibilityChanged;
	public FMargin Padding;
	public int Priority;
	public bool bIsFocusable;
	public bool bStopAction;
	public void SetColorAndOpacity(FLinearColor InColorAndOpacity) {}
	public void SetForegroundColor(FSlateColor InForegroundColor) {}
	public void SetPadding(FMargin InPadding) {}
	public UObject PlayAnimation(UObject InAnimation,float StartAtTime=0.0f,int NumLoopsToPlay=1,EUMGSequencePlayMode PlayMode=EUMGSequencePlayMode,float PlaybackSpeed=1.0f,bool bRestoreState=false,UObject ReturnValue) { return default; }
	public UObject PlayAnimationTimeRange(UObject InAnimation,float StartAtTime=0.0f,float EndAtTime=0.0f,int NumLoopsToPlay=1,EUMGSequencePlayMode PlayMode=EUMGSequencePlayMode,float PlaybackSpeed=1.0f,bool bRestoreState=false,UObject ReturnValue) { return default; }
	public UObject PlayAnimationForward(UObject InAnimation,float PlaybackSpeed=1.0f,bool bRestoreState=false,UObject ReturnValue) { return default; }
	public UObject PlayAnimationReverse(UObject InAnimation,float PlaybackSpeed=1.0f,bool bRestoreState=false,UObject ReturnValue) { return default; }
	public void StopAnimation(UObject InAnimation) {}
	public void StopAllAnimations() {}
	public float PauseAnimation(UObject InAnimation,float ReturnValue) { return default; }
	public float GetAnimationCurrentTime(UObject InAnimation,float ReturnValue) { return default; }
	public void SetAnimationCurrentTime(UObject InAnimation,float InTime) {}
	public bool IsAnimationPlaying(UObject InAnimation,bool ReturnValue) { return default; }
	public bool IsAnyAnimationPlaying(bool ReturnValue) { return default; }
	public void SetNumLoopsToPlay(UObject InAnimation,int NumLoopsToPlay) {}
	public void SetPlaybackSpeed(UObject InAnimation,float PlaybackSpeed=1.0f) {}
	public void ReverseAnimation(UObject InAnimation) {}
	public bool IsAnimationPlayingForward(UObject InAnimation,bool ReturnValue) { return default; }
	public void FlushAnimations() {}
	public UObject GetExtension(UClass ExtensionType,UObject ReturnValue) { return default; }
	public TArray<UObject> GetExtensions(UClass ExtensionType,TArray<UObject> ReturnValue) { return default; }
	public UObject AddExtension(UClass InExtensionType,UObject ReturnValue) { return default; }
	public void RemoveExtension(UObject InExtension) {}
	public void RemoveExtensions(UClass InExtensionType) {}
	public void PlaySound(UObject SoundToPlay) {}
	public bool IsPlayingAnimation(bool ReturnValue) { return default; }
	public TArray<UUMGSequencePlayer> ActiveSequencePlayers;
	public UUMGSequenceTickManager AnimationTickManager;
	public TArray<UUMGSequencePlayer> StoppedSequencePlayers;
	public TArray<FNamedSlotBinding> NamedSlotBindings;
	public TArray<UUserWidgetExtension> Extensions;
	public UWidgetTree WidgetTree;
	public FVector2D DesignTimeSize;
	public EDesignPreviewSizeMode DesignSizeMode;
	public sbyte PaletteCategory;
	public UTexture2D PreviewBackground;
	public bool bHasScriptImplementedTick;
	public bool bHasScriptImplementedPaint;
	public void ListenForInputAction(sbyte ActionName,byte EventType,bool bConsume,FOnInputAction Callback) {}
	public void StopListeningForInputAction(sbyte ActionName,byte EventType) {}
	public void StopListeningForAllInputActions() {}
	public void RegisterInputComponent() {}
	public void UnregisterInputComponent() {}
	public bool IsListeningForInputAction(sbyte ActionName,bool ReturnValue) { return default; }
	public void SetInputActionPriority(int NewPriority) {}
	public void SetInputActionBlocking(bool bShouldBlock) {}
	public EWidgetTickFrequency TickFrequency;
	public UInputComponent InputComponent;
	public TArray<FAnimationEventBinding> AnimationCallbacks;
}
