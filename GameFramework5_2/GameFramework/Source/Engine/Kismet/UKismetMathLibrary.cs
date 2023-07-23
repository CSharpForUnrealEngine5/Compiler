#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Kismet/KismetMathLibrary.h")]
public partial class UKismetMathLibrary : UBlueprintFunctionLibrary {
// KismetMathLibrary
	public bool RandomBool(bool ReturnValue) { return default; }
	public bool RandomBoolWithWeight(float Weight,bool ReturnValue) { return default; }
	public bool RandomBoolWithWeightFromStream(FRandomStream RandomStream,float Weight,bool ReturnValue) { return default; }
	public bool Not_PreBool(bool A,bool ReturnValue) { return default; }
	public bool EqualEqual_BoolBool(bool A,bool B,bool ReturnValue) { return default; }
	public bool NotEqual_BoolBool(bool A,bool B,bool ReturnValue) { return default; }
	public bool BooleanAND(bool A,bool B,bool ReturnValue) { return default; }
	public bool BooleanNAND(bool A,bool B,bool ReturnValue) { return default; }
	public bool BooleanOR(bool A,bool B,bool ReturnValue) { return default; }
	public bool BooleanXOR(bool A,bool B,bool ReturnValue) { return default; }
	public bool BooleanNOR(bool A,bool B,bool ReturnValue) { return default; }
	public byte Multiply_ByteByte(byte A,byte B,byte ReturnValue) { return default; }
	public byte Divide_ByteByte(byte A,byte B=1,byte ReturnValue) { return default; }
	public byte Percent_ByteByte(byte A,byte B=1,byte ReturnValue) { return default; }
	public byte Add_ByteByte(byte A,byte B=1,byte ReturnValue) { return default; }
	public byte Subtract_ByteByte(byte A,byte B=1,byte ReturnValue) { return default; }
	public byte BMin(byte A,byte B,byte ReturnValue) { return default; }
	public byte BMax(byte A,byte B,byte ReturnValue) { return default; }
	public bool Less_ByteByte(byte A,byte B,bool ReturnValue) { return default; }
	public bool Greater_ByteByte(byte A,byte B,bool ReturnValue) { return default; }
	public bool LessEqual_ByteByte(byte A,byte B,bool ReturnValue) { return default; }
	public bool GreaterEqual_ByteByte(byte A,byte B,bool ReturnValue) { return default; }
	public bool EqualEqual_ByteByte(byte A,byte B,bool ReturnValue) { return default; }
	public bool NotEqual_ByteByte(byte A,byte B,bool ReturnValue) { return default; }
	public int Multiply_IntInt(int A,int B,int ReturnValue) { return default; }
	public int Divide_IntInt(int A,int B=1,int ReturnValue) { return default; }
	public int Percent_IntInt(int A,int B=1,int ReturnValue) { return default; }
	public int Add_IntInt(int A,int B=1,int ReturnValue) { return default; }
	public int Subtract_IntInt(int A,int B=1,int ReturnValue) { return default; }
	public bool Less_IntInt(int A,int B,bool ReturnValue) { return default; }
	public bool Greater_IntInt(int A,int B,bool ReturnValue) { return default; }
	public bool LessEqual_IntInt(int A,int B,bool ReturnValue) { return default; }
	public bool GreaterEqual_IntInt(int A,int B,bool ReturnValue) { return default; }
	public bool EqualEqual_IntInt(int A,int B,bool ReturnValue) { return default; }
	public bool NotEqual_IntInt(int A,int B,bool ReturnValue) { return default; }
	public bool InRange_IntInt(int Value,int Min,int Max,bool InclusiveMin=true,bool InclusiveMax=true,bool ReturnValue) { return default; }
	public int And_IntInt(int A,int B,int ReturnValue) { return default; }
	public int Xor_IntInt(int A,int B,int ReturnValue) { return default; }
	public int Or_IntInt(int A,int B,int ReturnValue) { return default; }
	public int Not_Int(int A,int ReturnValue) { return default; }
	public int SignOfInteger(int A,int ReturnValue) { return default; }
	public int RandomInteger(int Max,int ReturnValue) { return default; }
	public int RandomIntegerInRange(int Min,int Max,int ReturnValue) { return default; }
	public int Min(int A,int B,int ReturnValue) { return default; }
	public int Max(int A,int B,int ReturnValue) { return default; }
	public int Clamp(int Value,int Min,int Max,int ReturnValue) { return default; }
	public int Wrap(int Value,int Min,int Max,int ReturnValue) { return default; }
	public int Abs_Int(int A,int ReturnValue) { return default; }
	public long Multiply_Int64Int64(long A,long B,long ReturnValue) { return default; }
	public long Divide_Int64Int64(long A,long B=1,long ReturnValue) { return default; }
	public long Percent_Int64Int64(long A,long B=1,long ReturnValue) { return default; }
	public long Add_Int64Int64(long A,long B=1,long ReturnValue) { return default; }
	public long Subtract_Int64Int64(long A,long B=1,long ReturnValue) { return default; }
	public bool Less_Int64Int64(long A,long B,bool ReturnValue) { return default; }
	public bool Greater_Int64Int64(long A,long B,bool ReturnValue) { return default; }
	public bool LessEqual_Int64Int64(long A,long B,bool ReturnValue) { return default; }
	public bool GreaterEqual_Int64Int64(long A,long B,bool ReturnValue) { return default; }
	public bool EqualEqual_Int64Int64(long A,long B,bool ReturnValue) { return default; }
	public bool NotEqual_Int64Int64(long A,long B,bool ReturnValue) { return default; }
	public bool InRange_Int64Int64(long Value,long Min,long Max,bool InclusiveMin=true,bool InclusiveMax=true,bool ReturnValue) { return default; }
	public long And_Int64Int64(long A,long B,long ReturnValue) { return default; }
	public long Xor_Int64Int64(long A,long B,long ReturnValue) { return default; }
	public long Or_Int64Int64(long A,long B,long ReturnValue) { return default; }
	public long Not_Int64(long A,long ReturnValue) { return default; }
	public long SignOfInteger64(long A,long ReturnValue) { return default; }
	public long RandomInteger64(long Max,long ReturnValue) { return default; }
	public long RandomInteger64InRange(long Min,long Max,long ReturnValue) { return default; }
	public long MinInt64(long A,long B,long ReturnValue) { return default; }
	public long MaxInt64(long A,long B,long ReturnValue) { return default; }
	public long ClampInt64(long Value,long Min,long Max,long ReturnValue) { return default; }
	public long Abs_Int64(long A,long ReturnValue) { return default; }
	public double MultiplyMultiply_FloatFloat(double Base,double Exp,double ReturnValue) { return default; }
	public double Multiply_IntFloat(int A,double B,double ReturnValue) { return default; }
	public double Percent_FloatFloat(double A,double B=1.f,double ReturnValue) { return default; }
	public double Fraction(double A,double ReturnValue) { return default; }
	public double Add_DoubleDouble(double A,double B=1.0,double ReturnValue) { return default; }
	public double Subtract_DoubleDouble(double A,double B=1.0,double ReturnValue) { return default; }
	public double Multiply_DoubleDouble(double A,double B,double ReturnValue) { return default; }
	public double Divide_DoubleDouble(double A,double B=1.0,double ReturnValue) { return default; }
	public bool Less_DoubleDouble(double A,double B,bool ReturnValue) { return default; }
	public bool Greater_DoubleDouble(double A,double B,bool ReturnValue) { return default; }
	public bool LessEqual_DoubleDouble(double A,double B,bool ReturnValue) { return default; }
	public bool GreaterEqual_DoubleDouble(double A,double B,bool ReturnValue) { return default; }
	public bool EqualEqual_DoubleDouble(double A,double B,bool ReturnValue) { return default; }
	public bool NearlyEqual_FloatFloat(double A,double B,double ErrorTolerance=1.e-6,bool ReturnValue) { return default; }
	public bool NotEqual_DoubleDouble(double A,double B,bool ReturnValue) { return default; }
	public bool InRange_FloatFloat(double Value,double Min,double Max,bool InclusiveMin=true,bool InclusiveMax=true,bool ReturnValue) { return default; }
	public double Hypotenuse(double Width,double Height,double ReturnValue) { return default; }
	public double GridSnap_Float(double Location,double GridSize,double ReturnValue) { return default; }
	public double Abs(double A,double ReturnValue) { return default; }
	public double Sin(double A,double ReturnValue) { return default; }
	public double Asin(double A,double ReturnValue) { return default; }
	public double Cos(double A,double ReturnValue) { return default; }
	public double Acos(double A,double ReturnValue) { return default; }
	public double Tan(double A,double ReturnValue) { return default; }
	public double Atan(double A,double ReturnValue) { return default; }
	public double Atan2(double Y,double X,double ReturnValue) { return default; }
	public double Exp(double A,double ReturnValue) { return default; }
	public double Log(double A,double Base=1.0,double ReturnValue) { return default; }
	public double Loge(double A,double ReturnValue) { return default; }
	public double Sqrt(double A,double ReturnValue) { return default; }
	public double Square(double A,double ReturnValue) { return default; }
	public double RandomFloat(double ReturnValue) { return default; }
	public double RandomFloatInRange(double Min,double Max,double ReturnValue) { return default; }
	public double GetPI(double ReturnValue) { return default; }
	public double GetTAU(double ReturnValue) { return default; }
	public double DegreesToRadians(double A,double ReturnValue) { return default; }
	public double RadiansToDegrees(double A,double ReturnValue) { return default; }
	public double DegSin(double A,double ReturnValue) { return default; }
	public double DegAsin(double A,double ReturnValue) { return default; }
	public double DegCos(double A,double ReturnValue) { return default; }
	public double DegAcos(double A,double ReturnValue) { return default; }
	public double DegTan(double A,double ReturnValue) { return default; }
	public double DegAtan(double A,double ReturnValue) { return default; }
	public double DegAtan2(double Y,double X,double ReturnValue) { return default; }
	public double ClampAngle(double AngleDegrees,double MinAngleDegrees,double MaxAngleDegrees,double ReturnValue) { return default; }
	public double FMin(double A,double B,double ReturnValue) { return default; }
	public double FMax(double A,double B,double ReturnValue) { return default; }
	public double FClamp(double Value,double Min,double Max,double ReturnValue) { return default; }
	public double FWrap(double Value,double Min,double Max,double ReturnValue) { return default; }
	public double SafeDivide(double A,double B,double ReturnValue) { return default; }
	public void MaxOfIntArray(TArray<int> IntArray,int IndexOfMaxValue,int MaxValue) {}
	public void MinOfIntArray(TArray<int> IntArray,int IndexOfMinValue,int MinValue) {}
	public void MedianOfIntArray(TArray<int> IntArray,float MedianValue) {}
	public void AverageOfIntArray(TArray<int> IntArray,float AverageValue) {}
	public void MaxOfFloatArray(TArray<float> FloatArray,int IndexOfMaxValue,float MaxValue) {}
	public void MinOfFloatArray(TArray<float> FloatArray,int IndexOfMinValue,float MinValue) {}
	public void MaxOfByteArray(TArray<byte> ByteArray,int IndexOfMaxValue,byte MaxValue) {}
	public void MinOfByteArray(TArray<byte> ByteArray,int IndexOfMinValue,byte MinValue) {}
	public double Lerp(double A,double B,double Alpha,double ReturnValue) { return default; }
	public double Ease(double A,double B,double Alpha,byte EasingFunc,double BlendExp=2,int Steps=2,double ReturnValue) { return default; }
	public int Round(double A,int ReturnValue) { return default; }
	public int FFloor(double A,int ReturnValue) { return default; }
	public int FTrunc(double A,int ReturnValue) { return default; }
	public int FCeil(double A,int ReturnValue) { return default; }
	public long Round64(double A,long ReturnValue) { return default; }
	public long FFloor64(double A,long ReturnValue) { return default; }
	public long FTrunc64(double A,long ReturnValue) { return default; }
	public long FCeil64(double A,long ReturnValue) { return default; }
	public int FMod(double Dividend,double Divisor,double Remainder,int ReturnValue) { return default; }
	public long FMod64(double Dividend,double Divisor,double Remainder,long ReturnValue) { return default; }
	public double SignOfFloat(double A,double ReturnValue) { return default; }
	public double NormalizeToRange(double Value,double RangeMin,double RangeMax,double ReturnValue) { return default; }
	public double MapRangeUnclamped(double Value,double InRangeA,double InRangeB,double OutRangeA,double OutRangeB,double ReturnValue) { return default; }
	public double MapRangeClamped(double Value,double InRangeA,double InRangeB,double OutRangeA,double OutRangeB,double ReturnValue) { return default; }
	public double MultiplyByPi(double Value,double ReturnValue) { return default; }
	public double FInterpEaseInOut(double A,double B,double Alpha,double Exponent,double ReturnValue) { return default; }
	public float MakePulsatingValue(float InCurrentTime,float InPulsesPerSecond=1.0f,float InPhase=0.0f,float ReturnValue) { return default; }
	public float FixedTurn(float InCurrent,float InDesired,float InDeltaRate,float ReturnValue) { return default; }
	public FIntPoint IntPoint_Zero(FIntPoint ReturnValue) { return default; }
	public FIntPoint IntPoint_One(FIntPoint ReturnValue) { return default; }
	public FIntPoint IntPoint_Up(FIntPoint ReturnValue) { return default; }
	public FIntPoint IntPoint_Left(FIntPoint ReturnValue) { return default; }
	public FIntPoint IntPoint_Right(FIntPoint ReturnValue) { return default; }
	public FIntPoint IntPoint_Down(FIntPoint ReturnValue) { return default; }
	public FVector2D Conv_IntPointToVector2D(FIntPoint InIntPoint,FVector2D ReturnValue) { return default; }
	public FIntPoint Add_IntPointIntPoint(FIntPoint A,FIntPoint B,FIntPoint ReturnValue) { return default; }
	public FIntPoint Add_IntPointInt(FIntPoint A,int B,FIntPoint ReturnValue) { return default; }
	public FIntPoint Subtract_IntPointIntPoint(FIntPoint A,FIntPoint B,FIntPoint ReturnValue) { return default; }
	public FIntPoint Subtract_IntPointInt(FIntPoint A,int B,FIntPoint ReturnValue) { return default; }
	public FIntPoint Multiply_IntPointIntPoint(FIntPoint A,FIntPoint B,FIntPoint ReturnValue) { return default; }
	public FIntPoint Multiply_IntPointInt(FIntPoint A,int B,FIntPoint ReturnValue) { return default; }
	public FIntPoint Divide_IntPointIntPoint(FIntPoint A,FIntPoint B,FIntPoint ReturnValue) { return default; }
	public FIntPoint Divide_IntPointInt(FIntPoint A,int B,FIntPoint ReturnValue) { return default; }
	public bool Equal_IntPointIntPoint(FIntPoint A,FIntPoint B,bool ReturnValue) { return default; }
	public bool NotEqual_IntPointIntPoint(FIntPoint A,FIntPoint B,bool ReturnValue) { return default; }
	public FVector2D Vector2D_One(FVector2D ReturnValue) { return default; }
	public FVector2D Vector2D_Unit45Deg(FVector2D ReturnValue) { return default; }
	public FVector2D Vector2D_Zero(FVector2D ReturnValue) { return default; }
	public FVector2D MakeVector2D(double X,double Y,FVector2D ReturnValue) { return default; }
	public void BreakVector2D(FVector2D InVec,double X,double Y) {}
	public FVector Conv_Vector2DToVector(FVector2D InVector2D,float Z=0,FVector ReturnValue) { return default; }
	public FIntPoint Conv_Vector2DToIntPoint(FVector2D InVector2D,FIntPoint ReturnValue) { return default; }
	public FVector2D Add_Vector2DVector2D(FVector2D A,FVector2D B,FVector2D ReturnValue) { return default; }
	public FVector2D Add_Vector2DFloat(FVector2D A,double B,FVector2D ReturnValue) { return default; }
	public FVector2D Subtract_Vector2DVector2D(FVector2D A,FVector2D B,FVector2D ReturnValue) { return default; }
	public FVector2D Subtract_Vector2DFloat(FVector2D A,double B,FVector2D ReturnValue) { return default; }
	public FVector2D Multiply_Vector2DVector2D(FVector2D A,FVector2D B,FVector2D ReturnValue) { return default; }
	public FVector2D Multiply_Vector2DFloat(FVector2D A,double B,FVector2D ReturnValue) { return default; }
	public FVector2D Divide_Vector2DVector2D(FVector2D A,FVector2D B,FVector2D ReturnValue) { return default; }
	public FVector2D Divide_Vector2DFloat(FVector2D A,double B=1.f,FVector2D ReturnValue) { return default; }
	public bool EqualExactly_Vector2DVector2D(FVector2D A,FVector2D B,bool ReturnValue) { return default; }
	public bool EqualEqual_Vector2DVector2D(FVector2D A,FVector2D B,float ErrorTolerance=1.e-4f,bool ReturnValue) { return default; }
	public bool NotEqualExactly_Vector2DVector2D(FVector2D A,FVector2D B,bool ReturnValue) { return default; }
	public bool NotEqual_Vector2DVector2D(FVector2D A,FVector2D B,float ErrorTolerance=1.e-4f,bool ReturnValue) { return default; }
	public FVector2D Negated2D(FVector2D A,FVector2D ReturnValue) { return default; }
	public void Set2D(FVector2D A,double X,double Y) {}
	public FVector2D ClampAxes2D(FVector2D A,double MinAxisVal,double MaxAxisVal,FVector2D ReturnValue) { return default; }
	public double CrossProduct2D(FVector2D A,FVector2D B,double ReturnValue) { return default; }
	public double Distance2D(FVector2D V1,FVector2D V2,double ReturnValue) { return default; }
	public double DistanceSquared2D(FVector2D V1,FVector2D V2,double ReturnValue) { return default; }
	public double DotProduct2D(FVector2D A,FVector2D B,double ReturnValue) { return default; }
	public FVector2D GetAbs2D(FVector2D A,FVector2D ReturnValue) { return default; }
	public double GetAbsMax2D(FVector2D A,double ReturnValue) { return default; }
	public double GetMax2D(FVector2D A,double ReturnValue) { return default; }
	public double GetMin2D(FVector2D A,double ReturnValue) { return default; }
	public FVector2D GetRotated2D(FVector2D A,float AngleDeg,FVector2D ReturnValue) { return default; }
	public bool IsNearlyZero2D(FVector2D A,float Tolerance=1.e-4f,bool ReturnValue) { return default; }
	public bool IsZero2D(FVector2D A,bool ReturnValue) { return default; }
	public FVector2D Vector2DInterpTo(FVector2D Current,FVector2D Target,float DeltaTime,float InterpSpeed,FVector2D ReturnValue) { return default; }
	public FVector2D Vector2DInterpTo_Constant(FVector2D Current,FVector2D Target,float DeltaTime,float InterpSpeed,FVector2D ReturnValue) { return default; }
	public FVector2D NormalSafe2D(FVector2D A,float Tolerance=1.e-8f,FVector2D ReturnValue) { return default; }
	public FVector2D Normal2D(FVector2D A,FVector2D ReturnValue) { return default; }
	public void Normalize2D(FVector2D A,float Tolerance=1.e-8) {}
	public FVector Spherical2DToUnitCartesian(FVector2D A,FVector ReturnValue) { return default; }
	public void ToDirectionAndLength2D(FVector2D A,FVector2D OutDir,double OutLength) {}
	public FVector2D ToRounded2D(FVector2D A,FVector2D ReturnValue) { return default; }
	public FVector2D ToSign2D(FVector2D A,FVector2D ReturnValue) { return default; }
	public double VSize2D(FVector2D A,double ReturnValue) { return default; }
	public double VSize2DSquared(FVector2D A,double ReturnValue) { return default; }
	public FVector Vector_Zero(FVector ReturnValue) { return default; }
	public FVector Vector_One(FVector ReturnValue) { return default; }
	public FVector Vector_Forward(FVector ReturnValue) { return default; }
	public FVector Vector_Backward(FVector ReturnValue) { return default; }
	public FVector Vector_Up(FVector ReturnValue) { return default; }
	public FVector Vector_Down(FVector ReturnValue) { return default; }
	public FVector Vector_Right(FVector ReturnValue) { return default; }
	public FVector Vector_Left(FVector ReturnValue) { return default; }
	public FVector MakeVector(double X,double Y,double Z,FVector ReturnValue) { return default; }
	public FVector CreateVectorFromYawPitch(float Yaw,float Pitch,float Length=1.0f,FVector ReturnValue) { return default; }
	public void Vector_Assign(FVector A,FVector InVector) {}
	public void Vector_Set(FVector A,double X,double Y,double Z) {}
	public void BreakVector(FVector InVec,double X,double Y,double Z) {}
	public void BreakVector3f(FVector3f InVec,float X,float Y,float Z) {}
	public FLinearColor Conv_VectorToLinearColor(FVector InVec,FLinearColor ReturnValue) { return default; }
	public FTransform Conv_VectorToTransform(FVector InLocation,FTransform ReturnValue) { return default; }
	public FVector2D Conv_VectorToVector2D(FVector InVector,FVector2D ReturnValue) { return default; }
	public FRotator Conv_VectorToRotator(FVector InVec,FRotator ReturnValue) { return default; }
	public FRotator RotatorFromAxisAndAngle(FVector Axis,float Angle,FRotator ReturnValue) { return default; }
	public FQuat Conv_VectorToQuaternion(FVector InVec,FQuat ReturnValue) { return default; }
	public FVector Vector_SlerpVectorToDirection(FVector Vector,FVector Direction,double Alpha,FVector ReturnValue) { return default; }
	public FVector Vector_SlerpNormals(FVector NormalA,FVector NormalB,double Alpha,FVector ReturnValue) { return default; }
	public FVector Add_VectorVector(FVector A,FVector B,FVector ReturnValue) { return default; }
	public FVector Add_VectorFloat(FVector A,double B,FVector ReturnValue) { return default; }
	public FVector Add_VectorInt(FVector A,int B,FVector ReturnValue) { return default; }
	public FVector Subtract_VectorVector(FVector A,FVector B,FVector ReturnValue) { return default; }
	public FVector Subtract_VectorFloat(FVector A,double B,FVector ReturnValue) { return default; }
	public FVector Subtract_VectorInt(FVector A,int B,FVector ReturnValue) { return default; }
	public FVector Multiply_VectorVector(FVector A,FVector B,FVector ReturnValue) { return default; }
	public FVector Multiply_VectorFloat(FVector A,double B,FVector ReturnValue) { return default; }
	public FVector Multiply_VectorInt(FVector A,int B,FVector ReturnValue) { return default; }
	public FVector Divide_VectorVector(FVector A,FVector B=FVector,FVector ReturnValue) { return default; }
	public FVector Divide_VectorFloat(FVector A,double B=1.f,FVector ReturnValue) { return default; }
	public FVector Divide_VectorInt(FVector A,int B=1,FVector ReturnValue) { return default; }
	public FVector NegateVector(FVector A,FVector ReturnValue) { return default; }
	public bool EqualExactly_VectorVector(FVector A,FVector B,bool ReturnValue) { return default; }
	public bool EqualEqual_VectorVector(FVector A,FVector B,float ErrorTolerance=1.e-4f,bool ReturnValue) { return default; }
	public bool NotEqualExactly_VectorVector(FVector A,FVector B,bool ReturnValue) { return default; }
	public bool NotEqual_VectorVector(FVector A,FVector B,float ErrorTolerance=1.e-4f,bool ReturnValue) { return default; }
	public double Dot_VectorVector(FVector A,FVector B,double ReturnValue) { return default; }
	public FVector Cross_VectorVector(FVector A,FVector B,FVector ReturnValue) { return default; }
	public FVector GreaterGreater_VectorRotator(FVector A,FRotator B,FVector ReturnValue) { return default; }
	public FVector RotateAngleAxis(FVector InVect,float AngleDeg,FVector Axis,FVector ReturnValue) { return default; }
	public FVector LessLess_VectorRotator(FVector A,FRotator B,FVector ReturnValue) { return default; }
	public void Vector_UnwindEuler(FVector A) {}
	public FVector ClampVectorSize(FVector A,double Min,double Max,FVector ReturnValue) { return default; }
	public FVector Vector_ClampSize2D(FVector A,double Min,double Max,FVector ReturnValue) { return default; }
	public FVector Vector_ClampSizeMax(FVector A,double Max,FVector ReturnValue) { return default; }
	public FVector Vector_ClampSizeMax2D(FVector A,double Max,FVector ReturnValue) { return default; }
	public double GetMinElement(FVector A,double ReturnValue) { return default; }
	public double GetMaxElement(FVector A,double ReturnValue) { return default; }
	public double Vector_GetAbsMax(FVector A,double ReturnValue) { return default; }
	public double Vector_GetAbsMin(FVector A,double ReturnValue) { return default; }
	public FVector Vector_GetAbs(FVector A,FVector ReturnValue) { return default; }
	public FVector Vector_ComponentMin(FVector A,FVector B,FVector ReturnValue) { return default; }
	public FVector Vector_ComponentMax(FVector A,FVector B,FVector ReturnValue) { return default; }
	public FVector Vector_GetSignVector(FVector A,FVector ReturnValue) { return default; }
	public FVector Vector_GetProjection(FVector A,FVector ReturnValue) { return default; }
	public double Vector_HeadingAngle(FVector A,double ReturnValue) { return default; }
	public double Vector_CosineAngle2D(FVector A,FVector B,double ReturnValue) { return default; }
	public FVector Vector_ToRadians(FVector A,FVector ReturnValue) { return default; }
	public FVector Vector_ToDegrees(FVector A,FVector ReturnValue) { return default; }
	public FVector2D Vector_UnitCartesianToSpherical(FVector A,FVector2D ReturnValue) { return default; }
	public FVector GetDirectionUnitVector(FVector From,FVector To,FVector ReturnValue) { return default; }
	public void GetYawPitchFromVector(FVector InVec,float Yaw,float Pitch) {}
	public void GetAzimuthAndElevation(FVector InDirection,FTransform ReferenceFrame,float Azimuth,float Elevation) {}
	public FVector GetVectorArrayAverage(TArray<FVector> Vectors,FVector ReturnValue) { return default; }
	public FIntVector FTruncVector(FVector InVector,FIntVector ReturnValue) { return default; }
	public double Vector_Distance(FVector V1,FVector V2,double ReturnValue) { return default; }
	public double Vector_DistanceSquared(FVector V1,FVector V2,double ReturnValue) { return default; }
	public double Vector_Distance2D(FVector V1,FVector V2,double ReturnValue) { return default; }
	public double Vector_Distance2DSquared(FVector V1,FVector V2,double ReturnValue) { return default; }
	public double VSize(FVector A,double ReturnValue) { return default; }
	public double VSizeSquared(FVector A,double ReturnValue) { return default; }
	public double VSizeXY(FVector A,double ReturnValue) { return default; }
	public double VSizeXYSquared(FVector A,double ReturnValue) { return default; }
	public bool Vector_IsNearlyZero(FVector A,float Tolerance=1.e-4f,bool ReturnValue) { return default; }
	public bool Vector_IsZero(FVector A,bool ReturnValue) { return default; }
	public bool Vector_IsNAN(FVector A,bool ReturnValue) { return default; }
	public bool Vector_IsUniform(FVector A,float Tolerance=1.e-4f,bool ReturnValue) { return default; }
	public bool Vector_IsUnit(FVector A,float SquaredLenthTolerance=1.e-4f,bool ReturnValue) { return default; }
	public bool Vector_IsNormal(FVector A,bool ReturnValue) { return default; }
	public FVector Normal(FVector A,float Tolerance=1.e-4f,FVector ReturnValue) { return default; }
	public FVector Vector_Normal2D(FVector A,float Tolerance=1.e-4f,FVector ReturnValue) { return default; }
	public FVector Vector_NormalUnsafe(FVector A,FVector ReturnValue) { return default; }
	public void Vector_Normalize(FVector A,float Tolerance=1.e-8) {}
	public FVector VLerp(FVector A,FVector B,float Alpha,FVector ReturnValue) { return default; }
	public FVector VEase(FVector A,FVector B,float Alpha,byte EasingFunc,float BlendExp=2,int Steps=2,FVector ReturnValue) { return default; }
	public FVector VInterpTo(FVector Current,FVector Target,float DeltaTime,float InterpSpeed,FVector ReturnValue) { return default; }
	public FVector VInterpTo_Constant(FVector Current,FVector Target,float DeltaTime,float InterpSpeed,FVector ReturnValue) { return default; }
	public FVector VectorSpringInterp(FVector Current,FVector Target,FVectorSpringState SpringState,float Stiffness,float CriticalDampingFactor,float DeltaTime,float Mass=1.f,float TargetVelocityAmount=1.f,bool bClamp=false,FVector MinValue=FVector,FVector MaxValue=FVector,bool bInitializeFromTarget=false,FVector ReturnValue) { return default; }
	public FQuat QuaternionSpringInterp(FQuat Current,FQuat Target,FQuaternionSpringState SpringState,float Stiffness,float CriticalDampingFactor,float DeltaTime,float Mass=1.f,float TargetVelocityAmount=1.f,bool bInitializeFromTarget=false,FQuat ReturnValue) { return default; }
	public FVector Vector_Reciprocal(FVector A,FVector ReturnValue) { return default; }
	public FVector GetReflectionVector(FVector Direction,FVector SurfaceNormal,FVector ReturnValue) { return default; }
	public FVector MirrorVectorByNormal(FVector InVect,FVector InNormal,FVector ReturnValue) { return default; }
	public FVector Vector_MirrorByPlane(FVector A,FPlane InPlane,FVector ReturnValue) { return default; }
	public FVector Vector_SnappedToGrid(FVector InVect,float InGridSize,FVector ReturnValue) { return default; }
	public FVector Vector_BoundedToCube(FVector InVect,float InRadius,FVector ReturnValue) { return default; }
	public void Vector_AddBounded(FVector A,FVector InAddVect,float InRadius) {}
	public FVector Vector_BoundedToBox(FVector InVect,FVector InBoxMin,FVector InBoxMax,FVector ReturnValue) { return default; }
	public FVector Vector_ProjectOnToNormal(FVector V,FVector InNormal,FVector ReturnValue) { return default; }
	public FVector ProjectVectorOnToVector(FVector V,FVector Target,FVector ReturnValue) { return default; }
	public FVector ProjectPointOnToPlane(FVector Point,FVector PlaneBase,FVector PlaneNormal,FVector ReturnValue) { return default; }
	public FVector ProjectVectorOnToPlane(FVector V,FVector PlaneNormal,FVector ReturnValue) { return default; }
	public void FindNearestPointsOnLineSegments(FVector Segment1Start,FVector Segment1End,FVector Segment2Start,FVector Segment2End,FVector Segment1Point,FVector Segment2Point) {}
	public FVector FindClosestPointOnSegment(FVector Point,FVector SegmentStart,FVector SegmentEnd,FVector ReturnValue) { return default; }
	public FVector FindClosestPointOnLine(FVector Point,FVector LineOrigin,FVector LineDirection,FVector ReturnValue) { return default; }
	public float GetPointDistanceToSegment(FVector Point,FVector SegmentStart,FVector SegmentEnd,float ReturnValue) { return default; }
	public float GetPointDistanceToLine(FVector Point,FVector LineOrigin,FVector LineDirection,float ReturnValue) { return default; }
	public FVector RandomUnitVector(FVector ReturnValue) { return default; }
	public FVector RandomPointInBoundingBox(FVector Center,FVector HalfSize,FVector ReturnValue) { return default; }
	public FVector RandomPointInBoundingBox_Box(FBox Box,FVector ReturnValue) { return default; }
	public FVector RandomUnitVectorInConeInRadians(FVector ConeDir,float ConeHalfAngleInRadians,FVector ReturnValue) { return default; }
	public FVector RandomUnitVectorInConeInDegrees(FVector ConeDir,float ConeHalfAngleInDegrees,FVector ReturnValue) { return default; }
	public FVector RandomUnitVectorInEllipticalConeInRadians(FVector ConeDir,float MaxYawInRadians,float MaxPitchInRadians,FVector ReturnValue) { return default; }
	public FVector RandomUnitVectorInEllipticalConeInDegrees(FVector ConeDir,float MaxYawInDegrees,float MaxPitchInDegrees,FVector ReturnValue) { return default; }
	public FVector4 Vector4_Zero(FVector4 ReturnValue) { return default; }
	public FVector4 MakeVector4(double X,double Y,double Z,double W,FVector4 ReturnValue) { return default; }
	public void BreakVector4(FVector4 InVec,double X,double Y,double Z,double W) {}
	public FVector Conv_Vector4ToVector(FVector4 InVector4,FVector ReturnValue) { return default; }
	public FRotator Conv_Vector4ToRotator(FVector4 InVec,FRotator ReturnValue) { return default; }
	public FQuat Conv_Vector4ToQuaternion(FVector4 InVec,FQuat ReturnValue) { return default; }
	public FVector4 Add_Vector4Vector4(FVector4 A,FVector4 B,FVector4 ReturnValue) { return default; }
	public FVector4 Subtract_Vector4Vector4(FVector4 A,FVector4 B,FVector4 ReturnValue) { return default; }
	public FVector4 Multiply_Vector4Vector4(FVector4 A,FVector4 B,FVector4 ReturnValue) { return default; }
	public FVector4 Divide_Vector4Vector4(FVector4 A,FVector4 B,FVector4 ReturnValue) { return default; }
	public bool EqualExactly_Vector4Vector4(FVector4 A,FVector4 B,bool ReturnValue) { return default; }
	public bool EqualEqual_Vector4Vector4(FVector4 A,FVector4 B,float ErrorTolerance=1.e-4f,bool ReturnValue) { return default; }
	public bool NotEqualExactly_Vector4Vector4(FVector4 A,FVector4 B,bool ReturnValue) { return default; }
	public bool NotEqual_Vector4Vector4(FVector4 A,FVector4 B,float ErrorTolerance=1.e-4f,bool ReturnValue) { return default; }
	public FVector4 Vector4_Negated(FVector4 A,FVector4 ReturnValue) { return default; }
	public void Vector4_Assign(FVector4 A,FVector4 InVector) {}
	public void Vector4_Set(FVector4 A,double X,double Y,double Z,double W) {}
	public FVector4 Vector4_CrossProduct3(FVector4 A,FVector4 B,FVector4 ReturnValue) { return default; }
	public double Vector4_DotProduct(FVector4 A,FVector4 B,double ReturnValue) { return default; }
	public double Vector4_DotProduct3(FVector4 A,FVector4 B,double ReturnValue) { return default; }
	public bool Vector4_IsNAN(FVector4 A,bool ReturnValue) { return default; }
	public bool Vector4_IsNearlyZero3(FVector4 A,float Tolerance=1.e-4f,bool ReturnValue) { return default; }
	public bool Vector4_IsZero(FVector4 A,bool ReturnValue) { return default; }
	public double Vector4_Size(FVector4 A,double ReturnValue) { return default; }
	public double Vector4_SizeSquared(FVector4 A,double ReturnValue) { return default; }
	public double Vector4_Size3(FVector4 A,double ReturnValue) { return default; }
	public double Vector4_SizeSquared3(FVector4 A,double ReturnValue) { return default; }
	public bool Vector4_IsUnit3(FVector4 A,float SquaredLenthTolerance=1.e-4f,bool ReturnValue) { return default; }
	public bool Vector4_IsNormal3(FVector4 A,bool ReturnValue) { return default; }
	public FVector4 Vector4_Normal3(FVector4 A,float Tolerance=1.e-4f,FVector4 ReturnValue) { return default; }
	public FVector4 Vector4_NormalUnsafe3(FVector4 A,FVector4 ReturnValue) { return default; }
	public void Vector4_Normalize3(FVector4 A,float Tolerance=1.e-8) {}
	public FVector4 Vector4_MirrorByVector3(FVector4 Direction,FVector4 SurfaceNormal,FVector4 ReturnValue) { return default; }
	public FVector4 TransformVector4(FMatrix Matrix,FVector4 Vec4,FVector4 ReturnValue) { return default; }
	public FRotator MakeRotator(float Roll,float Pitch,float Yaw,FRotator ReturnValue) { return default; }
	public FRotator MakeRotFromX(FVector X,FRotator ReturnValue) { return default; }
	public FRotator MakeRotFromY(FVector Y,FRotator ReturnValue) { return default; }
	public FRotator MakeRotFromZ(FVector Z,FRotator ReturnValue) { return default; }
	public FRotator MakeRotFromXY(FVector X,FVector Y,FRotator ReturnValue) { return default; }
	public FRotator MakeRotFromXZ(FVector X,FVector Z,FRotator ReturnValue) { return default; }
	public FRotator MakeRotFromYX(FVector Y,FVector X,FRotator ReturnValue) { return default; }
	public FRotator MakeRotFromYZ(FVector Y,FVector Z,FRotator ReturnValue) { return default; }
	public FRotator MakeRotFromZX(FVector Z,FVector X,FRotator ReturnValue) { return default; }
	public FRotator MakeRotFromZY(FVector Z,FVector Y,FRotator ReturnValue) { return default; }
	public FRotator MakeRotationFromAxes(FVector Forward,FVector Right,FVector Up,FRotator ReturnValue) { return default; }
	public FRotator FindLookAtRotation(FVector Start,FVector Target,FRotator ReturnValue) { return default; }
	public FRotator FindRelativeLookAtRotation(FTransform StartTransform,FVector TargetLocation,FRotator ReturnValue) { return default; }
	public void BreakRotator(FRotator InRot,float Roll,float Pitch,float Yaw) {}
	public void BreakRotIntoAxes(FRotator InRot,FVector X,FVector Y,FVector Z) {}
	public bool EqualEqual_RotatorRotator(FRotator A,FRotator B,float ErrorTolerance=1.e-4f,bool ReturnValue) { return default; }
	public bool NotEqual_RotatorRotator(FRotator A,FRotator B,float ErrorTolerance=1.e-4f,bool ReturnValue) { return default; }
	public FRotator Multiply_RotatorFloat(FRotator A,float B,FRotator ReturnValue) { return default; }
	public FRotator Multiply_RotatorInt(FRotator A,int B,FRotator ReturnValue) { return default; }
	public FRotator ComposeRotators(FRotator A,FRotator B,FRotator ReturnValue) { return default; }
	public FRotator NegateRotator(FRotator A,FRotator ReturnValue) { return default; }
	public FVector GetForwardVector(FRotator InRot,FVector ReturnValue) { return default; }
	public FVector GetRightVector(FRotator InRot,FVector ReturnValue) { return default; }
	public FVector GetUpVector(FRotator InRot,FVector ReturnValue) { return default; }
	public FVector Conv_RotatorToVector(FRotator InRot,FVector ReturnValue) { return default; }
	public FTransform Conv_RotatorToTransform(FRotator InRotator,FTransform ReturnValue) { return default; }
	public void GetAxes(FRotator A,FVector X,FVector Y,FVector Z) {}
	public FRotator RandomRotator(bool bRoll=false,FRotator ReturnValue) { return default; }
	public FRotator RLerp(FRotator A,FRotator B,float Alpha,bool bShortestPath,FRotator ReturnValue) { return default; }
	public FRotator REase(FRotator A,FRotator B,float Alpha,bool bShortestPath,byte EasingFunc,float BlendExp=2,int Steps=2,FRotator ReturnValue) { return default; }
	public FRotator NormalizedDeltaRotator(FRotator A,FRotator B,FRotator ReturnValue) { return default; }
	public float ClampAxis(float Angle,float ReturnValue) { return default; }
	public float NormalizeAxis(float Angle,float ReturnValue) { return default; }
	public FTransform Conv_MatrixToTransform(FMatrix InMatrix,FTransform ReturnValue) { return default; }
	public FRotator Conv_MatrixToRotator(FMatrix InMatrix,FRotator ReturnValue) { return default; }
	public FVector Matrix_GetOrigin(FMatrix InMatrix,FVector ReturnValue) { return default; }
	public FMatrix Matrix_Identity(FMatrix ReturnValue) { return default; }
	public FMatrix Multiply_MatrixMatrix(FMatrix A,FMatrix B,FMatrix ReturnValue) { return default; }
	public FMatrix Add_MatrixMatrix(FMatrix A,FMatrix B,FMatrix ReturnValue) { return default; }
	public FMatrix Multiply_MatrixFloat(FMatrix A,double B,FMatrix ReturnValue) { return default; }
	public bool EqualEqual_MatrixMatrix(FMatrix A,FMatrix B,float Tolerance=1.e-4f,bool ReturnValue) { return default; }
	public bool NotEqual_MatrixMatrix(FMatrix A,FMatrix B,float Tolerance=1.e-4f,bool ReturnValue) { return default; }
	public FVector4 Matrix_TransformVector4(FMatrix M,FVector4 V,FVector4 ReturnValue) { return default; }
	public FVector4 Matrix_TransformPosition(FMatrix M,FVector V,FVector4 ReturnValue) { return default; }
	public FVector Matrix_InverseTransformPosition(FMatrix M,FVector V,FVector ReturnValue) { return default; }
	public FVector4 Matrix_TransformVector(FMatrix M,FVector V,FVector4 ReturnValue) { return default; }
	public FVector Matrix_InverseTransformVector(FMatrix M,FVector V,FVector ReturnValue) { return default; }
	public FMatrix Matrix_GetTransposed(FMatrix M,FMatrix ReturnValue) { return default; }
	public float Matrix_GetDeterminant(FMatrix M,float ReturnValue) { return default; }
	public float Matrix_GetRotDeterminant(FMatrix M,float ReturnValue) { return default; }
	public FMatrix Matrix_GetInverse(FMatrix M,FMatrix ReturnValue) { return default; }
	public FMatrix Matrix_GetTransposeAdjoint(FMatrix M,FMatrix ReturnValue) { return default; }
	public void Matrix_RemoveScaling(FMatrix M,float Tolerance=1.e-8f) {}
	public FMatrix Matrix_GetMatrixWithoutScale(FMatrix M,float Tolerance=1.e-8f,FMatrix ReturnValue) { return default; }
	public FVector Matrix_GetScaleVector(FMatrix M,float Tolerance=1.e-8f,FVector ReturnValue) { return default; }
	public FMatrix Matrix_RemoveTranslation(FMatrix M,FMatrix ReturnValue) { return default; }
	public FMatrix Matrix_ConcatenateTranslation(FMatrix M,FVector Translation,FMatrix ReturnValue) { return default; }
	public bool Matrix_ContainsNaN(FMatrix M,bool ReturnValue) { return default; }
	public FMatrix Matrix_ScaleTranslation(FMatrix M,FVector Scale3D,FMatrix ReturnValue) { return default; }
	public float Matrix_GetMaximumAxisScale(FMatrix M,float ReturnValue) { return default; }
	public FMatrix Matrix_ApplyScale(FMatrix M,float Scale,FMatrix ReturnValue) { return default; }
	public FVector Matrix_GetScaledAxis(FMatrix M,byte Axis,FVector ReturnValue) { return default; }
	public void Matrix_GetScaledAxes(FMatrix M,FVector X,FVector Y,FVector Z) {}
	public FVector Matrix_GetUnitAxis(FMatrix M,byte Axis,FVector ReturnValue) { return default; }
	public void Matrix_GetUnitAxes(FMatrix M,FVector X,FVector Y,FVector Z) {}
	public void Matrix_SetAxis(FMatrix M,byte Axis,FVector AxisVector) {}
	public void Matrix_SetOrigin(FMatrix M,FVector NewOrigin) {}
	public FVector Matrix_GetColumn(FMatrix M,byte Column,FVector ReturnValue) { return default; }
	public void Matrix_SetColumn(FMatrix M,byte Column,FVector Value) {}
	public FRotator Matrix_GetRotator(FMatrix M,FRotator ReturnValue) { return default; }
	public FQuat Matrix_ToQuat(FMatrix M,FQuat ReturnValue) { return default; }
	public bool Matrix_GetFrustumNearPlane(FMatrix M,FPlane OutPlane,bool ReturnValue) { return default; }
	public bool Matrix_GetFrustumFarPlane(FMatrix M,FPlane OutPlane,bool ReturnValue) { return default; }
	public bool Matrix_GetFrustumLeftPlane(FMatrix M,FPlane OutPlane,bool ReturnValue) { return default; }
	public bool Matrix_GetFrustumRightPlane(FMatrix M,FPlane OutPlane,bool ReturnValue) { return default; }
	public bool Matrix_GetFrustumTopPlane(FMatrix M,FPlane OutPlane,bool ReturnValue) { return default; }
	public bool Matrix_GetFrustumBottomPlane(FMatrix M,FPlane OutPlane,bool ReturnValue) { return default; }
	public FMatrix Matrix_Mirror(FMatrix M,byte MirrorAxis,byte FlipAxis,FMatrix ReturnValue) { return default; }
	public FQuat Quat_Identity(FQuat ReturnValue) { return default; }
	public bool EqualEqual_QuatQuat(FQuat A,FQuat B,float Tolerance=1.e-4f,bool ReturnValue) { return default; }
	public bool NotEqual_QuatQuat(FQuat A,FQuat B,float ErrorTolerance=1.e-4f,bool ReturnValue) { return default; }
	public FQuat Add_QuatQuat(FQuat A,FQuat B,FQuat ReturnValue) { return default; }
	public FQuat Subtract_QuatQuat(FQuat A,FQuat B,FQuat ReturnValue) { return default; }
	public FQuat MakeQuat(float X,float Y,float Z,float W,FQuat ReturnValue) { return default; }
	public void BreakQuat(FQuat InQuat,float X,float Y,float Z,float W) {}
	public FQuat Multiply_QuatQuat(FQuat A,FQuat B,FQuat ReturnValue) { return default; }
	public bool Quat_IsIdentity(FQuat Q,float Tolerance=1.e-4f,bool ReturnValue) { return default; }
	public bool Quat_IsNormalized(FQuat Q,bool ReturnValue) { return default; }
	public bool Quat_IsFinite(FQuat Q,bool ReturnValue) { return default; }
	public bool Quat_IsNonFinite(FQuat Q,bool ReturnValue) { return default; }
	public float Quat_AngularDistance(FQuat A,FQuat B,float ReturnValue) { return default; }
	public void Quat_EnforceShortestArcWith(FQuat A,FQuat B) {}
	public FVector Quat_Euler(FQuat Q,FVector ReturnValue) { return default; }
	public FQuat Quat_Exp(FQuat Q,FQuat ReturnValue) { return default; }
	public float Quat_GetAngle(FQuat Q,float ReturnValue) { return default; }
	public FVector Quat_GetAxisX(FQuat Q,FVector ReturnValue) { return default; }
	public FVector Quat_GetAxisY(FQuat Q,FVector ReturnValue) { return default; }
	public FVector Quat_GetAxisZ(FQuat Q,FVector ReturnValue) { return default; }
	public FVector Quat_VectorForward(FQuat Q,FVector ReturnValue) { return default; }
	public FVector Quat_VectorRight(FQuat Q,FVector ReturnValue) { return default; }
	public FVector Quat_VectorUp(FQuat Q,FVector ReturnValue) { return default; }
	public void Quat_Normalize(FQuat Q,float Tolerance=1.e-4f) {}
	public FQuat Quat_Normalized(FQuat Q,float Tolerance=1.e-4f,FQuat ReturnValue) { return default; }
	public FVector Quat_GetRotationAxis(FQuat Q,FVector ReturnValue) { return default; }
	public FQuat Quat_Inversed(FQuat Q,FQuat ReturnValue) { return default; }
	public FQuat Quat_Log(FQuat Q,FQuat ReturnValue) { return default; }
	public void Quat_SetComponents(FQuat Q,float X,float Y,float Z,float W) {}
	public void Quat_SetFromEuler(FQuat Q,FVector Euler) {}
	public FQuat Quat_MakeFromEuler(FVector Euler,FQuat ReturnValue) { return default; }
	public FRotator Quat_Rotator(FQuat Q,FRotator ReturnValue) { return default; }
	public FQuat Conv_RotatorToQuaternion(FRotator InRot,FQuat ReturnValue) { return default; }
	public float Quat_Size(FQuat Q,float ReturnValue) { return default; }
	public float Quat_SizeSquared(FQuat Q,float ReturnValue) { return default; }
	public FVector Quat_RotateVector(FQuat Q,FVector V,FVector ReturnValue) { return default; }
	public FVector Quat_UnrotateVector(FQuat Q,FVector V,FVector ReturnValue) { return default; }
	public FQuat Quat_Slerp(FQuat A,FQuat B,double Alpha,FQuat ReturnValue) { return default; }
	public FQuat Quat_FindBetweenVectors(FVector Start,FVector End,FQuat ReturnValue) { return default; }
	public FQuat Quat_FindBetweenNormals(FVector StartNormal,FVector EndNormal,FQuat ReturnValue) { return default; }
	public FLinearColor LinearColor_White(FLinearColor ReturnValue) { return default; }
	public FLinearColor LinearColor_Gray(FLinearColor ReturnValue) { return default; }
	public FLinearColor LinearColor_Black(FLinearColor ReturnValue) { return default; }
	public FLinearColor LinearColor_Red(FLinearColor ReturnValue) { return default; }
	public FLinearColor LinearColor_Green(FLinearColor ReturnValue) { return default; }
	public FLinearColor LinearColor_Blue(FLinearColor ReturnValue) { return default; }
	public FLinearColor LinearColor_Yellow(FLinearColor ReturnValue) { return default; }
	public FLinearColor LinearColor_Transparent(FLinearColor ReturnValue) { return default; }
	public FLinearColor MakeColor(float R,float G,float B,float A=1.0f,FLinearColor ReturnValue) { return default; }
	public void BreakColor(FLinearColor InColor,float R,float G,float B,float A) {}
	public void LinearColor_Set(FLinearColor InOutColor,FLinearColor InColor) {}
	public void LinearColor_SetRGBA(FLinearColor InOutColor,float R,float G,float B,float A=1.0f) {}
	public void LinearColor_SetFromHSV(FLinearColor InOutColor,float H,float S,float V,float A=1.0f) {}
	public void LinearColor_SetFromSRGB(FLinearColor InOutColor,FColor InSRGB) {}
	public void LinearColor_SetFromPow22(FLinearColor InOutColor,FColor InColor) {}
	public void LinearColor_SetTemperature(FLinearColor InOutColor,float InTemperature) {}
	public void LinearColor_SetRandomHue(FLinearColor InOutColor) {}
	public FLinearColor Conv_DoubleToLinearColor(double InDouble,FLinearColor ReturnValue) { return default; }
	public FLinearColor HSVToRGB(float H,float S,float V,float A=1.0f,FLinearColor ReturnValue) { return default; }
	public void HSVToRGB_Vector(FLinearColor HSV,FLinearColor RGB) {}
	public FLinearColor HSVToRGBLinear(FLinearColor HSV,FLinearColor ReturnValue) { return default; }
	public void RGBToHSV(FLinearColor InColor,float H,float S,float V,float A) {}
	public void RGBToHSV_Vector(FLinearColor RGB,FLinearColor HSV) {}
	public FLinearColor RGBLinearToHSV(FLinearColor RGB,FLinearColor ReturnValue) { return default; }
	public FVector Conv_LinearColorToVector(FLinearColor InLinearColor,FVector ReturnValue) { return default; }
	public FColor LinearColor_ToRGBE(FLinearColor InLinearColor,FColor ReturnValue) { return default; }
	public FColor Conv_LinearColorToColor(FLinearColor InLinearColor,bool InUseSRGB=true,FColor ReturnValue) { return default; }
	public FColor LinearColor_Quantize(FLinearColor InColor,FColor ReturnValue) { return default; }
	public FColor LinearColor_QuantizeRound(FLinearColor InColor,FColor ReturnValue) { return default; }
	public FLinearColor LinearColor_Desaturated(FLinearColor InColor,float InDesaturation,FLinearColor ReturnValue) { return default; }
	public float LinearColor_Distance(FLinearColor C1,FLinearColor C2,float ReturnValue) { return default; }
	public FLinearColor LinearColor_ToNewOpacity(FLinearColor InColor,float InOpacity,FLinearColor ReturnValue) { return default; }
	public float LinearColor_GetLuminance(FLinearColor InColor,float ReturnValue) { return default; }
	public float LinearColor_GetMax(FLinearColor InColor,float ReturnValue) { return default; }
	public float LinearColor_GetMin(FLinearColor InColor,float ReturnValue) { return default; }
	public FLinearColor CInterpTo(FLinearColor Current,FLinearColor Target,float DeltaTime,float InterpSpeed,FLinearColor ReturnValue) { return default; }
	public FLinearColor LinearColorLerp(FLinearColor A,FLinearColor B,float Alpha,FLinearColor ReturnValue) { return default; }
	public FLinearColor LinearColorLerpUsingHSV(FLinearColor A,FLinearColor B,float Alpha,FLinearColor ReturnValue) { return default; }
	public bool LinearColor_IsNearEqual(FLinearColor A,FLinearColor B,float Tolerance=1.e-4f,bool ReturnValue) { return default; }
	public bool EqualEqual_LinearColorLinearColor(FLinearColor A,FLinearColor B,bool ReturnValue) { return default; }
	public bool NotEqual_LinearColorLinearColor(FLinearColor A,FLinearColor B,bool ReturnValue) { return default; }
	public FLinearColor Add_LinearColorLinearColor(FLinearColor A,FLinearColor B,FLinearColor ReturnValue) { return default; }
	public FLinearColor Subtract_LinearColorLinearColor(FLinearColor A,FLinearColor B,FLinearColor ReturnValue) { return default; }
	public FLinearColor Multiply_LinearColorLinearColor(FLinearColor A,FLinearColor B,FLinearColor ReturnValue) { return default; }
	public FLinearColor Multiply_LinearColorFloat(FLinearColor A,float B,FLinearColor ReturnValue) { return default; }
	public FLinearColor Divide_LinearColorLinearColor(FLinearColor A,FLinearColor B,FLinearColor ReturnValue) { return default; }
	public FPlane MakePlaneFromPointAndNormal(FVector Point,FVector Normal,FPlane ReturnValue) { return default; }
	public FDateTime MakeDateTime(int Year,int Month,int Day,int Hour=0,int Minute=0,int Second=0,int Millisecond=0,FDateTime ReturnValue) { return default; }
	public void BreakDateTime(FDateTime InDateTime,int Year,int Month,int Day,int Hour,int Minute,int Second,int Millisecond) {}
	public FDateTime Add_DateTimeTimespan(FDateTime A,FTimespan B,FDateTime ReturnValue) { return default; }
	public FDateTime Subtract_DateTimeTimespan(FDateTime A,FTimespan B,FDateTime ReturnValue) { return default; }
	public FDateTime Add_DateTimeDateTime(FDateTime A,FDateTime B,FDateTime ReturnValue) { return default; }
	public FTimespan Subtract_DateTimeDateTime(FDateTime A,FDateTime B,FTimespan ReturnValue) { return default; }
	public bool EqualEqual_DateTimeDateTime(FDateTime A,FDateTime B,bool ReturnValue) { return default; }
	public bool NotEqual_DateTimeDateTime(FDateTime A,FDateTime B,bool ReturnValue) { return default; }
	public bool Greater_DateTimeDateTime(FDateTime A,FDateTime B,bool ReturnValue) { return default; }
	public bool GreaterEqual_DateTimeDateTime(FDateTime A,FDateTime B,bool ReturnValue) { return default; }
	public bool Less_DateTimeDateTime(FDateTime A,FDateTime B,bool ReturnValue) { return default; }
	public bool LessEqual_DateTimeDateTime(FDateTime A,FDateTime B,bool ReturnValue) { return default; }
	public FDateTime GetDate(FDateTime A,FDateTime ReturnValue) { return default; }
	public int GetDay(FDateTime A,int ReturnValue) { return default; }
	public int GetDayOfYear(FDateTime A,int ReturnValue) { return default; }
	public int GetHour(FDateTime A,int ReturnValue) { return default; }
	public int GetHour12(FDateTime A,int ReturnValue) { return default; }
	public int GetMillisecond(FDateTime A,int ReturnValue) { return default; }
	public int GetMinute(FDateTime A,int ReturnValue) { return default; }
	public int GetMonth(FDateTime A,int ReturnValue) { return default; }
	public int GetSecond(FDateTime A,int ReturnValue) { return default; }
	public FTimespan GetTimeOfDay(FDateTime A,FTimespan ReturnValue) { return default; }
	public int GetYear(FDateTime A,int ReturnValue) { return default; }
	public bool IsAfternoon(FDateTime A,bool ReturnValue) { return default; }
	public bool IsMorning(FDateTime A,bool ReturnValue) { return default; }
	public int DaysInMonth(int Year,int Month,int ReturnValue) { return default; }
	public int DaysInYear(int Year,int ReturnValue) { return default; }
	public bool IsLeapYear(int Year,bool ReturnValue) { return default; }
	public FDateTime DateTimeMaxValue(FDateTime ReturnValue) { return default; }
	public FDateTime DateTimeMinValue(FDateTime ReturnValue) { return default; }
	public FDateTime Now(FDateTime ReturnValue) { return default; }
	public FDateTime Today(FDateTime ReturnValue) { return default; }
	public FDateTime UtcNow(FDateTime ReturnValue) { return default; }
	public bool DateTimeFromIsoString(sbyte IsoString,FDateTime Result,bool ReturnValue) { return default; }
	public bool DateTimeFromString(sbyte DateTimeString,FDateTime Result,bool ReturnValue) { return default; }
	public FTimespan TimespanMaxValue(FTimespan ReturnValue) { return default; }
	public FTimespan TimespanMinValue(FTimespan ReturnValue) { return default; }
	public FTimespan TimespanZeroValue(FTimespan ReturnValue) { return default; }
	public FTimespan MakeTimespan(int Days,int Hours,int Minutes,int Seconds,int Milliseconds,FTimespan ReturnValue) { return default; }
	public FTimespan MakeTimespan2(int Days,int Hours,int Minutes,int Seconds,int FractionNano,FTimespan ReturnValue) { return default; }
	public void BreakTimespan(FTimespan InTimespan,int Days,int Hours,int Minutes,int Seconds,int Milliseconds) {}
	public void BreakTimespan2(FTimespan InTimespan,int Days,int Hours,int Minutes,int Seconds,int FractionNano) {}
	public FTimespan Add_TimespanTimespan(FTimespan A,FTimespan B,FTimespan ReturnValue) { return default; }
	public FTimespan Subtract_TimespanTimespan(FTimespan A,FTimespan B,FTimespan ReturnValue) { return default; }
	public FTimespan Multiply_TimespanFloat(FTimespan A,float Scalar,FTimespan ReturnValue) { return default; }
	public FTimespan Divide_TimespanFloat(FTimespan A,float Scalar,FTimespan ReturnValue) { return default; }
	public bool EqualEqual_TimespanTimespan(FTimespan A,FTimespan B,bool ReturnValue) { return default; }
	public bool NotEqual_TimespanTimespan(FTimespan A,FTimespan B,bool ReturnValue) { return default; }
	public bool Greater_TimespanTimespan(FTimespan A,FTimespan B,bool ReturnValue) { return default; }
	public bool GreaterEqual_TimespanTimespan(FTimespan A,FTimespan B,bool ReturnValue) { return default; }
	public bool Less_TimespanTimespan(FTimespan A,FTimespan B,bool ReturnValue) { return default; }
	public bool LessEqual_TimespanTimespan(FTimespan A,FTimespan B,bool ReturnValue) { return default; }
	public int GetDays(FTimespan A,int ReturnValue) { return default; }
	public FTimespan GetDuration(FTimespan A,FTimespan ReturnValue) { return default; }
	public int GetHours(FTimespan A,int ReturnValue) { return default; }
	public int GetMilliseconds(FTimespan A,int ReturnValue) { return default; }
	public int GetMinutes(FTimespan A,int ReturnValue) { return default; }
	public int GetSeconds(FTimespan A,int ReturnValue) { return default; }
	public float GetTotalDays(FTimespan A,float ReturnValue) { return default; }
	public float GetTotalHours(FTimespan A,float ReturnValue) { return default; }
	public float GetTotalMilliseconds(FTimespan A,float ReturnValue) { return default; }
	public float GetTotalMinutes(FTimespan A,float ReturnValue) { return default; }
	public float GetTotalSeconds(FTimespan A,float ReturnValue) { return default; }
	public FTimespan FromDays(float Days,FTimespan ReturnValue) { return default; }
	public FTimespan FromHours(float Hours,FTimespan ReturnValue) { return default; }
	public FTimespan FromMilliseconds(float Milliseconds,FTimespan ReturnValue) { return default; }
	public FTimespan FromMinutes(float Minutes,FTimespan ReturnValue) { return default; }
	public FTimespan FromSeconds(float Seconds,FTimespan ReturnValue) { return default; }
	public float TimespanRatio(FTimespan A,FTimespan B,float ReturnValue) { return default; }
	public bool TimespanFromString(sbyte TimespanString,FTimespan Result,bool ReturnValue) { return default; }
	public FQualifiedFrameTime MakeQualifiedFrameTime(FFrameNumber Frame,FFrameRate FrameRate,float SubFrame=0.f,FQualifiedFrameTime ReturnValue) { return default; }
	public void BreakQualifiedFrameTime(FQualifiedFrameTime InFrameTime,FFrameNumber Frame,FFrameRate FrameRate,float SubFrame) {}
	public FFrameRate MakeFrameRate(int Numerator,int Denominator=1,FFrameRate ReturnValue) { return default; }
	public void BreakFrameRate(FFrameRate InFrameRate,int Numerator,int Denominator) {}
	public double Conv_ByteToDouble(byte InByte,double ReturnValue) { return default; }
	public double Conv_IntToDouble(int InInt,double ReturnValue) { return default; }
	public long Conv_IntToInt64(int InInt,long ReturnValue) { return default; }
	public byte Conv_IntToByte(int InInt,byte ReturnValue) { return default; }
	public int Conv_Int64ToInt(long InInt,int ReturnValue) { return default; }
	public float Conv_DoubleToFloat(double InDouble,float ReturnValue) { return default; }
	public double Conv_FloatToDouble(float InFloat,double ReturnValue) { return default; }
	public byte Conv_Int64ToByte(long InInt,byte ReturnValue) { return default; }
	public long Conv_DoubleToInt64(double InDouble,long ReturnValue) { return default; }
	public double Conv_Int64ToDouble(long InInt,double ReturnValue) { return default; }
	public FIntVector Conv_IntToIntVector(int InInt,FIntVector ReturnValue) { return default; }
	public FVector Conv_IntToVector(int InInt,FVector ReturnValue) { return default; }
	public bool Conv_IntToBool(int InInt,bool ReturnValue) { return default; }
	public int Conv_BoolToInt(bool InBool,int ReturnValue) { return default; }
	public double Conv_BoolToDouble(bool InBool,double ReturnValue) { return default; }
	public byte Conv_BoolToByte(bool InBool,byte ReturnValue) { return default; }
	public int Conv_ByteToInt(byte InByte,int ReturnValue) { return default; }
	public long Conv_ByteToInt64(byte InByte,long ReturnValue) { return default; }
	public FLinearColor Conv_ColorToLinearColor(FColor InColor,FLinearColor ReturnValue) { return default; }
	public FVector Conv_IntVectorToVector(FIntVector InIntVector,FVector ReturnValue) { return default; }
	public FVector Conv_DoubleToVector(double InDouble,FVector ReturnValue) { return default; }
	public FVector2D Conv_DoubleToVector2D(double InDouble,FVector2D ReturnValue) { return default; }
	public FBox MakeBox(FVector Min,FVector Max,FBox ReturnValue) { return default; }
	public FBox2D MakeBox2D(FVector2D Min,FVector2D Max,FBox2D ReturnValue) { return default; }
	public FBoxSphereBounds MakeBoxSphereBounds(FVector Origin,FVector BoxExtent,float SphereRadius,FBoxSphereBounds ReturnValue) { return default; }
	public void BreakBoxSphereBounds(FBoxSphereBounds InBoxSphereBounds,FVector Origin,FVector BoxExtent,float SphereRadius) {}
	public FRandomStream MakeRandomStream(int InitialSeed,FRandomStream ReturnValue) { return default; }
	public void BreakRandomStream(FRandomStream InRandomStream,int InitialSeed) {}
	public sbyte SelectString(sbyte A,sbyte B,bool bPickA,sbyte ReturnValue) { return default; }
	public int SelectInt(int A,int B,bool bPickA,int ReturnValue) { return default; }
	public double SelectFloat(double A,double B,bool bPickA,double ReturnValue) { return default; }
	public FVector SelectVector(FVector A,FVector B,bool bPickA,FVector ReturnValue) { return default; }
	public FRotator SelectRotator(FRotator A,FRotator B,bool bPickA,FRotator ReturnValue) { return default; }
	public FLinearColor SelectColor(FLinearColor A,FLinearColor B,bool bPickA,FLinearColor ReturnValue) { return default; }
	public FTransform SelectTransform(FTransform A,FTransform B,bool bPickA,FTransform ReturnValue) { return default; }
	public UObject SelectObject(UObject A,UObject B,bool bSelectA,UObject ReturnValue) { return default; }
	public UClass SelectClass(UClass A,UClass B,bool bSelectA,UClass ReturnValue) { return default; }
	public bool EqualEqual_ObjectObject(UObject A,UObject B,bool ReturnValue) { return default; }
	public bool NotEqual_ObjectObject(UObject A,UObject B,bool ReturnValue) { return default; }
	public bool EqualEqual_ClassClass(UClass A,UClass B,bool ReturnValue) { return default; }
	public bool NotEqual_ClassClass(UClass A,UClass B,bool ReturnValue) { return default; }
	public bool ClassIsChildOf(UClass TestClass,UClass ParentClass,bool ReturnValue) { return default; }
	public bool EqualEqual_NameName(sbyte A,sbyte B,bool ReturnValue) { return default; }
	public bool NotEqual_NameName(sbyte A,sbyte B,bool ReturnValue) { return default; }
	public FTransform MakeTransform(FVector Location,FRotator Rotation,FVector Scale=FVector,FTransform ReturnValue) { return default; }
	public void BreakTransform(FTransform InTransform,FVector Location,FRotator Rotation,FVector Scale) {}
	public bool EqualEqual_TransformTransform(FTransform A,FTransform B,bool ReturnValue) { return default; }
	public bool NearlyEqual_TransformTransform(FTransform A,FTransform B,float LocationTolerance=1.e-4f,float RotationTolerance=1.e-4f,float Scale3DTolerance=1.e-4f,bool ReturnValue) { return default; }
	public FTransform ComposeTransforms(FTransform A,FTransform B,FTransform ReturnValue) { return default; }
	public FVector TransformLocation(FTransform T,FVector Location,FVector ReturnValue) { return default; }
	public FVector TransformDirection(FTransform T,FVector Direction,FVector ReturnValue) { return default; }
	public FRotator TransformRotation(FTransform T,FRotator Rotation,FRotator ReturnValue) { return default; }
	public FVector InverseTransformLocation(FTransform T,FVector Location,FVector ReturnValue) { return default; }
	public FVector InverseTransformDirection(FTransform T,FVector Direction,FVector ReturnValue) { return default; }
	public FRotator InverseTransformRotation(FTransform T,FRotator Rotation,FRotator ReturnValue) { return default; }
	public FTransform MakeRelativeTransform(FTransform A,FTransform RelativeTo,FTransform ReturnValue) { return default; }
	public FTransform InvertTransform(FTransform T,FTransform ReturnValue) { return default; }
	public FTransform TLerp(FTransform A,FTransform B,float Alpha,byte InterpMode=ELerpInterpolationMode,FTransform ReturnValue) { return default; }
	public FTransform TEase(FTransform A,FTransform B,float Alpha,byte EasingFunc,float BlendExp=2,int Steps=2,FTransform ReturnValue) { return default; }
	public FTransform TInterpTo(FTransform Current,FTransform Target,float DeltaTime,float InterpSpeed,FTransform ReturnValue) { return default; }
	public float Transform_Determinant(FTransform Transform,float ReturnValue) { return default; }
	public FMatrix Conv_TransformToMatrix(FTransform Transform,FMatrix ReturnValue) { return default; }
	public double FInterpTo(double Current,double Target,double DeltaTime,double InterpSpeed,double ReturnValue) { return default; }
	public double FInterpTo_Constant(double Current,double Target,double DeltaTime,double InterpSpeed,double ReturnValue) { return default; }
	public FRotator RInterpTo(FRotator Current,FRotator Target,float DeltaTime,float InterpSpeed,FRotator ReturnValue) { return default; }
	public FRotator RInterpTo_Constant(FRotator Current,FRotator Target,float DeltaTime,float InterpSpeed,FRotator ReturnValue) { return default; }
	public float FloatSpringInterp(float Current,float Target,FFloatSpringState SpringState,float Stiffness,float CriticalDampingFactor,float DeltaTime,float Mass=1.f,float TargetVelocityAmount=1.f,bool bClamp=false,float MinValue=-1.f,float MaxValue=1.f,bool bInitializeFromTarget=false,float ReturnValue) { return default; }
	public void ResetFloatSpringState(FFloatSpringState SpringState) {}
	public void ResetVectorSpringState(FVectorSpringState SpringState) {}
	public void ResetQuaternionSpringState(FQuaternionSpringState SpringState) {}
	public void SetFloatSpringStateVelocity(FFloatSpringState SpringState,float Velocity) {}
	public void SetVectorSpringStateVelocity(FVectorSpringState SpringState,FVector Velocity) {}
	public void SetQuaternionSpringStateAngularVelocity(FQuaternionSpringState SpringState,FVector AngularVelocity) {}
	public int RandomIntegerFromStream(FRandomStream Stream,int Max,int ReturnValue) { return default; }
	public int RandomIntegerInRangeFromStream(FRandomStream Stream,int Min,int Max,int ReturnValue) { return default; }
	public bool RandomBoolFromStream(FRandomStream Stream,bool ReturnValue) { return default; }
	public float RandomFloatFromStream(FRandomStream Stream,float ReturnValue) { return default; }
	public float RandomFloatInRangeFromStream(FRandomStream Stream,float Min,float Max,float ReturnValue) { return default; }
	public FVector RandomUnitVectorFromStream(FRandomStream Stream,FVector ReturnValue) { return default; }
	public FVector RandomPointInBoundingBoxFromStream(FRandomStream Stream,FVector Center,FVector HalfSize,FVector ReturnValue) { return default; }
	public FVector RandomPointInBoundingBoxFromStream_Box(FRandomStream Stream,FBox Box,FVector ReturnValue) { return default; }
	public FRotator RandomRotatorFromStream(FRandomStream Stream,bool bRoll,FRotator ReturnValue) { return default; }
	public void ResetRandomStream(FRandomStream Stream) {}
	public void SeedRandomStream(FRandomStream Stream) {}
	public void SetRandomStreamSeed(FRandomStream Stream,int NewSeed) {}
	public FVector RandomUnitVectorInConeInRadiansFromStream(FRandomStream Stream,FVector ConeDir,float ConeHalfAngleInRadians,FVector ReturnValue) { return default; }
	public FVector RandomUnitVectorInConeInDegreesFromStream(FRandomStream Stream,FVector ConeDir,float ConeHalfAngleInDegrees,FVector ReturnValue) { return default; }
	public FVector RandomUnitVectorInEllipticalConeInRadiansFromStream(FRandomStream Stream,FVector ConeDir,float MaxYawInRadians,float MaxPitchInRadians,FVector ReturnValue) { return default; }
	public FVector RandomUnitVectorInEllipticalConeInDegreesFromStream(FRandomStream Stream,FVector ConeDir,float MaxYawInDegrees,float MaxPitchInDegrees,FVector ReturnValue) { return default; }
	public float PerlinNoise1D(float Value,float ReturnValue) { return default; }
	public void MinimumAreaRectangle(UObject WorldContextObject,TArray<FVector> InVerts,FVector SampleSurfaceNormal,FVector OutRectCenter,FRotator OutRectRotation,float OutSideLengthX,float OutSideLengthY,bool bDebugDraw=false) {}
	public void MinAreaRectangle(UObject WorldContextObject,TArray<FVector> InPoints,FVector SampleSurfaceNormal,FVector OutRectCenter,FRotator OutRectRotation,float OutRectLengthX,float OutRectLengthY,bool bDebugDraw=false) {}
	public bool PointsAreCoplanar(TArray<FVector> Points,float Tolerance=0.1f,bool ReturnValue) { return default; }
	public bool IsPointInBox(FVector Point,FVector BoxOrigin,FVector BoxExtent,bool ReturnValue) { return default; }
	public bool IsPointInBox_Box(FVector Point,FBox Box,bool ReturnValue) { return default; }
	public bool IsPointInBoxWithTransform(FVector Point,FTransform BoxWorldTransform,FVector BoxExtent,bool ReturnValue) { return default; }
	public bool IsPointInBoxWithTransform_Box(FVector Point,FTransform BoxWorldTransform,FBox BoxExtent,bool ReturnValue) { return default; }
	public void GetSlopeDegreeAngles(FVector MyRightYAxis,FVector FloorNormal,FVector UpVector,float OutSlopePitchDegreeAngle,float OutSlopeRollDegreeAngle) {}
	public bool LinePlaneIntersection(FVector LineStart,FVector LineEnd,FPlane APlane,float T,FVector Intersection,bool ReturnValue) { return default; }
	public bool LinePlaneIntersection_OriginNormal(FVector LineStart,FVector LineEnd,FVector PlaneOrigin,FVector PlaneNormal,float T,FVector Intersection,bool ReturnValue) { return default; }
	public float WeightedMovingAverage_Float(float CurrentSample,float PreviousSample,float Weight,float ReturnValue) { return default; }
	public FVector WeightedMovingAverage_FVector(FVector CurrentSample,FVector PreviousSample,float Weight,FVector ReturnValue) { return default; }
	public FRotator WeightedMovingAverage_FRotator(FRotator CurrentSample,FRotator PreviousSample,float Weight,FRotator ReturnValue) { return default; }
	public float DynamicWeightedMovingAverage_Float(float CurrentSample,float PreviousSample,float MaxDistance,float MinWeight,float MaxWeight,float ReturnValue) { return default; }
	public FVector DynamicWeightedMovingAverage_FVector(FVector CurrentSample,FVector PreviousSample,float MaxDistance,float MinWeight,float MaxWeight,FVector ReturnValue) { return default; }
	public FRotator DynamicWeightedMovingAverage_FRotator(FRotator CurrentSample,FRotator PreviousSample,float MaxDistance,float MinWeight,float MaxWeight,FRotator ReturnValue) { return default; }
	public FVector_NetQuantize MakeVector_NetQuantize(double X,double Y,double Z,FVector_NetQuantize ReturnValue) { return default; }
	public FVector_NetQuantize10 MakeVector_NetQuantize10(double X,double Y,double Z,FVector_NetQuantize10 ReturnValue) { return default; }
	public FVector_NetQuantize100 MakeVector_NetQuantize100(double X,double Y,double Z,FVector_NetQuantize100 ReturnValue) { return default; }
	public FVector_NetQuantizeNormal MakeVector_NetQuantizeNormal(double X,double Y,double Z,FVector_NetQuantizeNormal ReturnValue) { return default; }
	public void BreakVector_NetQuantize(FVector_NetQuantize InVec,double X,double Y,double Z) {}
	public void BreakVector_NetQuantize10(FVector_NetQuantize10 InVec,double X,double Y,double Z) {}
	public void BreakVector_NetQuantize100(FVector_NetQuantize100 InVec,double X,double Y,double Z) {}
	public void BreakVector_NetQuantizeNormal(FVector_NetQuantizeNormal InVec,double X,double Y,double Z) {}
}
