namespace IMSPOS_SDSIS.ContextFolder
{
    public class PurchaseDetail
    {
        #region Scalar properties
        public string Id { get; set; }
        public decimal Sequence { get; set; }
        public int CompanyId { get; set; }
        public int BranchId { get; set; }
        public int? WarehouseId { get; set; }
        public string PurchaseId { get; set; }
        public string? PurchaseType { get; set; }
        public string ItemCategoryId { get; set; }
        public string? ItemSubCategoryId { get; set; }
        public string? ItemSubsidiaryCategoryId { get; set; }
        public string ItemId { get; set; }
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public string UOMId { get; set; }
        public string? SizeId { get; set; }
        public string? ColorId { get; set; }
        public string? GradeId { get; set; }
        public string SupplierId { get; set; }
        public string? BrandId { get; set; }
        public string? InputSize { get; set; }
        public DateTime? PurchaseDate { get; set; }
        public DateTime PurchaseDetailDate { get; set; }
        public decimal? ItemStock { get; set; }
        public decimal Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal? SalesPrice { get; set; }
        public string? Unit { get; set; }
        public decimal TotalAmount { get; set; }
        public bool IsReturned { get; set; }
        public bool IsActive { get; set; }
        public bool IsArchive { get; set; }
        public bool IsSynchronized { get; set; }
        public bool IsUpdated { get; set; }
        public string SynchronizationType { get; set; }
        public string? Comments { get; set; }
        public int? Gsm { get; set; }

        #endregion Scalar properties

        #region Audit Properties

        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedIP { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string? ModifiedIP { get; set; }

        #endregion Audit Properties

        #region Navigation properties
        //public virtual Purchase Purchase { get; set; }
        #endregion Navigation properties
    }
}
