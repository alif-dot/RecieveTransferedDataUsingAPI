namespace IMSPOS_SDSIS.ContextFolder
{
    public class Purchase
    {
        #region Ctor

        public Purchase()
        {
            PurchaseDetails = new List<PurchaseDetail>();
        }

        #endregion Ctor

        #region Scalar properties

        public string Id { get; set; }
        public decimal Sequence { get; set; }
        public string PurchaseNo { get; set; }
        public string? MemoNo { get; set; }
        public string SupplierId { get; set; }
        public string? BrandId { get; set; }
        public DateTime PurchaseDate { get; set; }
        public decimal TotalQuantity { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal? MemoWiseDiscount { get; set; }
        public decimal? NetAmount { get; set; }
        public decimal? OthersCharge { get; set; }
        public decimal? PaidAmount { get; set; }
        public decimal? ChangeAmount { get; set; }
        public decimal? DueAmount { get; set; }
        public bool IsFullyReturned { get; set; }
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
        public virtual ICollection<PurchaseDetail> PurchaseDetails { get; set; }
        #endregion Navigation properties
    }
}
