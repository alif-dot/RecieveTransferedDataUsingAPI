namespace IMSPOS_SDSIS.ContextFolder
{
    public class GoodsReceive
    {
        #region Ctor

        public GoodsReceive()
        {
            GoodsReceiveDetail = new List<GoodsReceiveDetail>();
        }

        #endregion Ctor

        #region Scalar

        public string Id { get; set; }
        public decimal Sequence { get; set; }
        public string PurchaseOrderId { get; set; }
        public string PurchaseRequisitionId { get; set; }
        public int CompanyId { get; set; }
        public int BranchId { get; set; }
        public string SupplierId { get; set; }
        public string? BrandId { get; set; }
        public string GoodsReceiveNo { get; set; }
        public string GoodsReleaseNo { get; set; }
        public string ChalanNo { get; set; }
        public DateTime GoodsReceiveDate { get; set; }
        public decimal? TotalBoxes { get; set; }
        public decimal? TotalPcses { get; set; }
        public decimal? TotalMissingBoxes { get; set; }
        public decimal? TotalMissingPcses { get; set; }
        public decimal? TotalDamageBoxes { get; set; }
        public decimal? TotalDamagePcses { get; set; }
        public decimal TotalQuantity { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal TotalAmount { get; set; }
        public bool IsFullyReturned { get; set; }
        public bool IsActive { get; set; }
        public bool IsArchive { get; set; }
        public bool IsSynchronized { get; set; }
        public bool IsUpdated { get; set; }
        public string SynchronizationType { get; set; }
        public string? Comments { get; set; }

        #endregion Scalar

        #region Audit Properties

        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedIP { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string? ModifiedIP { get; set; }

        #endregion Audit Properties

        #region Navigation properties
        public virtual ICollection<GoodsReceiveDetail> GoodsReceiveDetail { get; set; }

        #endregion Navigation properties
    }
}
