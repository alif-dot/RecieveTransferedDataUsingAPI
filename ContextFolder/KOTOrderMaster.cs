namespace IMSPOS_SDSIS.ContextFolder
{
    public class KOTOrderMaster
    {
        #region Ctor

        public KOTOrderMaster()
        {
            KOTOrderDetails = new List<KOTOrderDetail>();
        }

        #endregion Ctor

        #region Scalar properties

        public string Id { get; set; }
        public string OrderNo { get; set; }
        public DateTime OrderDate { get; set; }
        public int? CompanyId { get; set; }
        public int? BranchId { get; set; }
        public bool IsSynchronized { get; set; }
        public string SynchronizationType { get; set; }

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

        public virtual ICollection<KOTOrderDetail> KOTOrderDetails { get; set; }

        #endregion Navigation properties
    }
}
