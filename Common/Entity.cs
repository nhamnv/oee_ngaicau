namespace Common
{

    public class TimeRange
    {
        public int TimeRangeID { get; set; }
        public string TimeRangeName { get; set; } = string.Empty;
    }


    /// <summary>
    /// Bảng mã lỗi
    /// </summary>
    public class Data_Error
    {
        public int ID { get; set; }
        public string ErrorName { get; set; } = string.Empty;
        public string ErrorCode { get; set; } = string.Empty;

        public int ParentID { get; set; }

        public int MachineGroupID { get; set; }
        public string MachineGroupName { get; set; } = string.Empty;

        #region Thuộc tính thêm để show cha con
        public string ErrorNameNested { get; set; } = string.Empty;
        public int L { get; set; }
        public string ChildPath { get; set; } = string.Empty;
        public string SearchPattern { get; set; } = string.Empty;

        #endregion
    }
    /// <summary>
    /// Bảng danh sách loai máy 
    /// </summary>
    public class Data_MachineGroup
    {
        public int MachineGroupID { get; set; }
        public string MachineGroupName { get; set; } = string.Empty;
        public string ColorCode { get; set; } = string.Empty;
    }
    /// <summary>
    /// Bảng danh sách máy
    /// </summary>
    public class Data_Machine
    {
        //public int MachineID { get; set; }
        //public string MachineName { get; set; } = string.Empty;
        //public string MachineNameOrigin { get; set; } = string.Empty;
        //public int MachineGroupID { get; set; }
        //public string MachineGroupName { get; set; } = string.Empty;

        //public string Model { get; set; } = string.Empty;
        //public string ImageUrl { get; set; } = string.Empty;

        /*

 
        SELECT ID = m.ID
	        ,  MachineName=m.MachineName
	        ,  ImageUrl = m.ImageUrl
	        ,  AssetGroupName=a.AssetGroupName
	        ,  AssetGroupID=m.AssetGroupID
	        ,  MachineAssetCode=m.MachineAssetCode
	        ,  MachineGroupName=g.MachineGroupName
	        ,  MachineGroupID=m.MachineGroupID
	        ,  AccountantCode=m.AccountantCode
	        ,  MachineLocationName = l.LocationName
	        ,  MachineLocationID = m.MachineLocationID
	        ,  BaseUnitName = u.UnitName
	        ,  BaseUnitID= m.BaseUnitID
	        ,  Model= m.Model
	        ,  SerialNo= m.SerialNo
	        ,  ProviderName = d.ProviderName
	        ,  ProviderID= m.ProviderID
	        ,  FirstUseDate = m.FirstUseDate
        FROM Data_Machine m
        LEFT JOIN Data_AssetGroup a ON a.ID = m.AssetGroupID
        LEFT JOIN Data_MachineGroup g ON g.ID=m.MachineGroupID
        LEFT JOIN Data_Location l ON l.ID = m.MachineLocationID
        LEFT JOIN Data_BaseUnit u ON u.ID = m.BaseUnitID
        LEFT JOIN Data_Provider d ON d.ID= m.ProviderID
         
        Data_Machine.Add(new Common.Data_Machine() { MachineID="&A2&",	MachineName=""&B2&"",ImageUrl=""&C2&"",AssetGroupName=""&D2&"",AssetGroupID="&E2&",MachineAssetCode=""&F2&"",MachineGroupName=""&G2&"",MachineGroupID="&H2&",AccountantCode=""&I2&"",MachineLocationName=""&J2&"",MachineLocationID="&K2&",BaseUnitName=""&L2&"",BaseUnitID="&M2&",Model=""&N2&"",SerialNo=""&O2&"",ProviderName=""&P2&"",ProviderID="&Q2&",FirstUseDate=new DateTime(2018,1,1)});
         */

        public int MachineID { get; set; } = 0;
        public string MachineName { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;
        public string AssetGroupName { get; set; } = string.Empty;
        public int AssetGroupID { get; set; } = 0;
        public string MachineAssetCode { get; set; } = string.Empty;
        public string MachineGroupName { get; set; } = string.Empty;
        public int MachineGroupID { get; set; } = 0;
        public string AccountantCode { get; set; } = string.Empty;
        public string MachineLocationName { get; set; } = string.Empty;
        public int MachineLocationID { get; set; } = 0;
        public string BaseUnitName { get; set; } = string.Empty;
        public int BaseUnitID { get; set; } = 0;
        public string Model { get; set; } = string.Empty;
        public string SerialNo { get; set; } = string.Empty;
        public string ProviderName { get; set; } = string.Empty;
        public string Note { get; set; } = string.Empty;
        public int ProviderID { get; set; } = 0;
        public DateTime? FirstUseDate { get; set; }

        public int Quantity { get; set; } = 0;

        /// <summary>
        /// Linh kiện
        /// </summary>
        public List<Data_MachineComponent> ListComponents { get; set; } = new List<Data_MachineComponent>();
    }
    /// <summary>
    /// Bảng vị trí cài đặt máy
    /// </summary>
    public class Data_MachineLocation
    {
        public int LocationID { get; set; }
        public string LocationName { get; set; } = string.Empty;
    }
    /// <summary>
    /// Bảng map máy nào đặt ở vị trí nào
    /// </summary>
    public class Data_MachineLocationSetup
    {
        public int MachineID { get; set; }
        public string MachineName { get; set; } = string.Empty;
        public int LocationID { get; set; }
        public string LocationName { get; set; } = string.Empty;
    }
    /// <summary>
    /// Bảng máy lỗi
    /// </summary>
    public class Data_ErrorHistory
    {
        public int ErrorHistoryID { get; set; }
        public DateTime ErrorDate { get; set; }

        public int MachineID { get; set; }
        public int ErrorID { get; set; }
    }

    public class Data_MachineComponent
    {
        public int ID { get; set; }
        public int MachineID { get; set; }

        public string ComponentName { get; set; } = string.Empty;
        public string MachineAssetCode { get; set; } = string.Empty;

        public double Price { get; set; }
        public int TimeReplacement { get; set; }
        public string TimeReplacementName { get; set; } = string.Empty;

        /// <summary>
        /// Đơn vị tính
        /// </summary>
        public string BaseUnitName { get; set; } = string.Empty;

    }

    /// <summary>
    /// Các trạng thái hoạt động của máy
    /// </summary>
    public class Data_MachineStatus
    {
        public Data_MachineStatus() { }


        public int StatusID { get; set; }
        public string StatusName { get; set; } = string.Empty;
        public string StatusDetail { get; set; } = string.Empty;
        public string ColorCode { get; set; } = string.Empty;

        public long DataPercent { get; set; } = 0;
    }

    /// <summary>
    /// Lịch sử trạng thái của máy
    /// </summary>
    public class Data_MachineStatusHistory
    {
        public Data_MachineStatusHistory() { }


        public int MachineStatusHistoryID { get; set; }
        public int MachineID { get; set; }
        public int MachineLocationID { get; set; }
        public int StatusID { get; set; }
        public DateTime StatusTime { get; set; }
    }

    public class Data_RepaireHistory
    {
        public int ID { get; set; }
        public int MachineID { get; set; }

        public DateTime DateTaskAssigned { get; set; }

        public string ErrorCode { get; set; } = string.Empty;

        public string Executor { get; set; } = string.Empty;

        public DateTime DateFinishTask { get; set; }
    }

    public class Data_MachineMaintenanceList
    {
        public int ID { get; set; }
        public int MachineID { get; set; }

        public string Content { get; set; } = string.Empty;

        public int IntervalID { get; set; }
        public string IntervalName { get; set; } = string.Empty;
        public string Note { get; set; } = string.Empty;
        /// <summary>
        /// Thời gian thực hiện (số phút)
        /// </summary>
        public int TimeFinish { get; set; }

    }

    public class Data_AssetGroup
    {
        public int AssetGroupID { get; set; }
        public string AssetGroupName { get; set; } = string.Empty;
        public string ColorCode { get; set; } = string.Empty;
    }
}
