namespace IMSPOS_SDSIS.ContextFolder
{
    public class GoodsReceiveDetail
    {
        #region Scalar properties

        public string Id { get; set; }
        public decimal Sequence { get; set; }
        public int WarehouseId { get; set; }
        public DateTime GoodsReceiveDate { get; set; }
        public DateTime GoodsReceiveDetailDate { get; set; }
        public string GoodsReceiveId { get; set; }
        public string PurchaseOrderId { get; set; }
        public string PurchaseOrderDetailId { get; set; }
        public string ItemCategoryId { get; set; }
        public string? ItemSubCategoryId { get; set; }
        public string? ItemSubsidiaryCategoryId { get; set; }
        public string ItemId { get; set; }
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public decimal? ItemStock { get; set; }
        public string UOMId { get; set; }
        public string? SizeId { get; set; }
        public string? ColorId { get; set; }
        public string? GradeId { get; set; }
        public string SupplierId { get; set; }
        public string? BrandId { get; set; }
        public decimal? DemandQty { get; set; }
        public decimal? Boxes { get; set; }
        public decimal? Pcses { get; set; }
        public decimal? DamageBoxes { get; set; }
        public decimal? DamagePcses { get; set; }
        public decimal? MissingBoxes { get; set; }
        public decimal? MissingPcses { get; set; }
        public string? UpperConversion { get; set; }
        public string? LowerConversion { get; set; }
        public decimal Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalAmount { get; set; }
        public bool IsReturned { get; set; }
        public bool IsActive { get; set; }
        public bool IsArchive { get; set; }
        public bool IsSynchronized { get; set; }
        public bool IsUpdated { get; set; }
        public string SynchronizationType { get; set; }
        public string? Comments { get; set; }

        #endregion Scalar properties

        #region Audit Properties

        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedIP { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string? ModifiedIP { get; set; }

        #endregion Audit Properties

        #region Navigation properties

        public int BranchId { get; set; }
        public int CompanyId { get; set; }
        //public virtual GoodsReceive GoodsReceive { get; set; }
        #endregion Navigation properties
    }
}
