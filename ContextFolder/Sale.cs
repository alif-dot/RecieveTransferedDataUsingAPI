namespace IMSPOS_SDSIS.ContextFolder
{
    public class Sale
    {

        #region Scalar properties

        public string Id { get; set; }
        public decimal Sequence { get; set; }
        public int CompanyId { get; set; }
        public int BranchId { get; set; }
        public string? CustomerId { get; set; }
        public string? CustomerName1 { get; set; }
        public string? CustomerName { get; set; }
        public string? CustomerAddress { get; set; }
        public string? CustomerPhone { get; set; }
        public string? SaleOrderId { get; set; }
        public string CustomerType { get; set; }
        public decimal? CustomerDiscountInPercentage { get; set; }
        public decimal? CustomerDiscountInAmount { get; set; }
        public decimal? CustomerDiscountAmount { get; set; }
        public decimal? CustomerTotalDiscountAmount { get; set; }
        public decimal? CustomerDueAmount { get; set; }
        public decimal? CustomerAdvanceAmount { get; set; }
        public string SaleNo { get; set; }
        public DateTime SaleDate { get; set; }
        public decimal LoadingCharge { get; set; }
        public decimal TransportCharge { get; set; }
        public decimal? OthersCharge { get; set; }
        public decimal? TotalBoxes { get; set; }
        public decimal? TotalPcses { get; set; }
        public decimal TotalQuantity { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal DiscountInPercentage { get; set; }
        public decimal DiscountInAmount { get; set; }
        public decimal? DiscountAmount { get; set; }
        public decimal? OverAllDiscount { get; set; }
        public decimal? OverAllDiscountInPercentage { get; set; }
        public decimal TotalDiscount { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal? TotalProfit { get; set; }
        public decimal? TotalVat { get; set; }
        public decimal? TotalSD { get; set; }
        public decimal NetAmount { get; set; }
        public decimal? RetailTotal { get; set; }
        public decimal PaidAmount { get; set; }
        public decimal ChangeAmount { get; set; }
        public decimal DueAmount { get; set; }
        public bool IsApprovedNeeded { get; set; }
        public bool IsApproved { get; set; }
        public string? ApprovedBy { get; set; }
        public bool IsFullyDelivered { get; set; }
        public bool IsFullyReturned { get; set; }
        public string PaymentType { get; set; }
        public string? CardType { get; set; }
        public string? CardNumber { get; set; }
        public string? BankName { get; set; }
        public string? ChequeNo { get; set; }
        public DateTime? ChequeDate { get; set; }
        public bool IsActive { get; set; }
        public bool IsArchive { get; set; }
        public bool IsSynchronized { get; set; }
        public bool IsUpdated { get; set; }
        public string SynchronizationType { get; set; }
        public string? Comments { get; set; }
        public string? DeliveryAddress { get; set; }
        public bool? IsVatApplicable { get; set; }
        public bool IsPosted { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public string? DocumentNo { get; set; }
        public bool IsDeliveryConfirm { get; set; }
        public string? SalePerson { get; set; }
        public decimal? TotalWeight { get; set; }
        public decimal? VATInPercentage { get; set; }
        public string? DriverId { get; set; }
        public string? DriverName { get; set; }
        public string? FitterId { get; set; }

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
        public virtual ICollection<SaleDetail> SaleDetails { get; set; }

        #endregion Navigation properties
    }
}
