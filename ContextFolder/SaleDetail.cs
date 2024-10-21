namespace IMSPOS_SDSIS.ContextFolder
{
    public class SaleDetail
    {
        #region Scalar properties
        public string Id { get; set; }
        public decimal Sequence { get; set; }
        public int CompanyId { get; set; }
        public int BranchId { get; set; }
        public string SaleId { get; set; }
        public string ItemId { get; set; }
        public string? ProjectId { get; set; }
        public string? SaleOrderId { get; set; }
        public string? SaleOrderDetailId { get; set; }
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public string UOMId { get; set; }
        public string? SizeId { get; set; }
        public string? ColorId { get; set; }
        public string? GradeId { get; set; }
        public string SupplierId { get; set; }
        public string? BrandId { get; set; }
        public string ItemCategoryId { get; set; }
        public string? ItemSubCategoryId { get; set; }
        public string? ItemSubsidiaryCategoryId { get; set; }
        public DateTime? SaleDate { get; set; }
        public DateTime SaleDetailDate { get; set; }
        public decimal Quantity { get; set; }
        public decimal? Boxes { get; set; }
        public decimal? Pcses { get; set; }
        public string? UpperConversion { get; set; }
        public string? LowerConversion { get; set; }
        public string? Unit { get; set; }
        public decimal StockQty { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal? PurchasePrice { get; set; }
        public decimal? DiscountPerUnit { get; set; }
        public decimal? DiscountAmount { get; set; }
        public decimal? DiscountInPercentage { get; set; }
        public decimal? DiscountInAmount { get; set; }
        public decimal? ProfitPerUnit { get; set; }
        public decimal? LoadingChargePerUnit { get; set; }
        public decimal? LoadingChargeAmount { get; set; }
        public decimal? ProfitAmount { get; set; }
        public decimal? VatInPercentage { get; set; }
        public decimal? VatInAmount { get; set; }
        public decimal? TaxRate { get; set; }
        public decimal? TaxAmount { get; set; }
        public decimal? SDRate { get; set; }
        public decimal? SDAmount { get; set; }
        public decimal? VatPerUnit { get; set; }
        public decimal? VatAmount { get; set; }
        public decimal TotalAmount { get; set; }
        public bool IsReturned { get; set; }
        public bool IsDelivered { get; set; }
        public bool IsActive { get; set; }
        public bool IsArchive { get; set; }
        public bool IsSynchronized { get; set; }
        public bool IsUpdated { get; set; }
        public string SynchronizationType { get; set; }
        public string? Comments { get; set; }
        public decimal? TotalSD { get; set; }
        public int? Gsm { get; set; }
        public bool IsDeliveryConfirm { get; set; }
        public string? SNNumber { get; set; }

        #endregion Scalar properties

        #region Audit Properties

        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedIP { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedIP { get; set; }

        #endregion Audit Properties

        #region Navigation properties
        //public virtual Sale Sale { get; set; }
        #endregion Navigation properties
    }
}
