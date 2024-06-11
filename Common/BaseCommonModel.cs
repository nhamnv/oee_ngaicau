namespace Common
{
    public class BaseCommonModel
    {
        #region Base properties

        public string Note { get; set; } = string.Empty;

        public int Status { get; set; } = 0;
        public DateTime? CreatedDate { get; set; }

        public DateTime? UpdatedDate { get; set; }

        #endregion
    }
}
