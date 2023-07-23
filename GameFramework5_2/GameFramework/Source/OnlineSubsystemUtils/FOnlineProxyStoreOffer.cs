#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("InAppPurchaseQueryCallbackProxy2.h")]
///<summary>Offer entry for display from online store</summary>
public partial struct FOnlineProxyStoreOffer {
// OnlineProxyStoreOffer
	public sbyte OfferId;
	public sbyte Title;
	public sbyte Description;
	public sbyte LongDescription;
	public sbyte RegularPriceText;
	public int RegularPrice;
	public sbyte PriceText;
	public int NumericPrice;
	public sbyte CurrencyCode;
	public FDateTime ReleaseDate;
	public FDateTime ExpirationDate;
	public EOnlineProxyStoreOfferDiscountType DiscountType;
	public TMap<sbyte,sbyte> DynamicFields;
}
