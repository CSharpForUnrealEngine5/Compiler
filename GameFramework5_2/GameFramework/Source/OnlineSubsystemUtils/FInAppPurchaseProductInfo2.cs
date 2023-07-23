#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("InAppPurchaseCallbackProxy2.h")]
///<summary>Micro-transaction purchase information</summary>
public partial struct FInAppPurchaseProductInfo2 {
// InAppPurchaseProductInfo2
	public sbyte Identifier;
	public sbyte TransactionIdentifier;
	public sbyte DisplayName;
	public sbyte DisplayDescription;
	public sbyte DisplayPrice;
	public float RawPrice;
	public sbyte CurrencyCode;
	public sbyte CurrencySymbol;
	public sbyte DecimalSeparator;
	public sbyte GroupingSeparator;
	public sbyte ReceiptData;
	public TMap<sbyte,sbyte> DynamicFields;
}
