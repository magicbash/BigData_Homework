using FileHelpers;

namespace BigData.Model
{
    [DelimitedRecord(",")]
    public class Product
    {
        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public string Title { get; set; }
        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public string TitleOrg { get; set; }
        public double Price { get; set; }
        public double RetailPrice { get; set; }
        public string Currency { get; set; }
        public int UnitSold { get; set; }
        public bool UserAdBoost { get; set; }
        public double Rating { get; set; }
        public int RatingCount { get; set; }
        public int? RatingFiveCount { get; set; }
        public int? RatingFourCount { get; set; }
        public int? RatingThreeCount { get; set; }
        public int? RatingTwoCount { get; set; }
        public int? RatingOneCount { get; set; }
        public int BadgeCount { get; set; }
        public int BadgeLocalProduct { get; set; }
        public int BadgeProductQuality { get; set; }
        public int BadgeFastShipping { get; set; }
        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public string Tags { get; set; }
        public string ProductColor { get; set; }
        public string ProductVariationSizeId { get; set; }
        public int ProductVariationInventory { get; set; }
        public string ShippingOptionName { get; set; }
        public int ShippingOptionPrice { get; set; }
        public bool ShippingIsExpress { get; set; }
        public int CountriesShippedTo { get; set; }
        public int InventoryTotal { get; set; }
        public bool? HasUrgencyBanner { get; set; }
        public string UrgencyText { get; set; }
        public string OriginCountry { get; set; }
        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public string MerchantTitle { get; set; }
        public string MerchantName { get; set; }
        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public string MerchantInfoSubtitle { get; set; }
        public int MerchantRatingCount { get; set; }
        public double MerchantRating { get; set; }
        public string MerchantId { get; set; }
        public bool MerchantHasProfilePicture { get; set; }
        public string MerchantProfilePicture { get; set; }
        public string ProductUrl { get; set; }
        public string ProductPicture { get; set; }
        public string ProductId { get; set; }
        public string Theme { get; set; }
        public string CrawlMonth { get; set; }
    }
}