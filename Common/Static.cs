namespace Common
{
    public static partial class StaticData
    {
        public static readonly List<TimeRange> TimeRange = new List<TimeRange>();
        /// <summary>
        /// Bảng mã lỗi
        /// </summary>
        public static readonly List<Data_Error> Data_Error = new List<Data_Error>();
        /// <summary>
        /// Bảng vị trí cài đặt máy
        /// </summary>
        public static readonly List<Data_MachineLocation> Data_MachineLocation = new List<Data_MachineLocation>();
        /// <summary>
        /// Bảng danh sách loai máy
        /// </summary>
        public static readonly List<Data_MachineGroup> Data_MachineGroup = new List<Data_MachineGroup>();
        /// <summary>
        /// Bảng danh sách máy
        /// </summary>
        public static readonly List<Data_Machine> Data_Machine = new List<Data_Machine>();
        /// <summary>
        /// Bảng map máy nào đặt ở vị trí nào
        /// </summary>
        public static readonly List<Data_MachineLocationSetup> Data_MachineLocationSetup = new List<Data_MachineLocationSetup>();
        /// <summary>
        /// Bảng máy lỗi
        /// </summary>
        public static readonly List<Data_ErrorHistory> Data_ErrorHistory = new List<Data_ErrorHistory>();

        public static readonly List<Data_MachineComponent> Data_MachineComponent = new List<Data_MachineComponent>();

        public static readonly List<Data_AssetGroup> Data_AssetGroup = new List<Data_AssetGroup>();
        static StaticData()
        {
            try
            {
                // Generate du lieu: https://docs.google.com/spreadsheets/d/1UMRjN9evTMvQwJMt31RtQRhMZcriXHBo0uEliIhr05M/edit#gid=1716046326

                #region TimeRange
                TimeRange.Add(new TimeRange() { TimeRangeID = 1, TimeRangeName = "Tháng trước" });
                TimeRange.Add(new TimeRange() { TimeRangeID = 2, TimeRangeName = "Quý trước" });
                TimeRange.Add(new TimeRange() { TimeRangeID = 3, TimeRangeName = "Năm trước" });
                TimeRange.Add(new TimeRange() { TimeRangeID = 4, TimeRangeName = "Tháng này" });
                TimeRange.Add(new TimeRange() { TimeRangeID = 5, TimeRangeName = "Quý này" });
                TimeRange.Add(new TimeRange() { TimeRangeID = 6, TimeRangeName = "Năm nay" });
                #endregion

                #region Data_AssetGroup

                Data_AssetGroup.Add(new Common.Data_AssetGroup() { AssetGroupID = 1, AssetGroupName = "Máy cắt", ColorCode = "#5f9d32" });
                Data_AssetGroup.Add(new Common.Data_AssetGroup() { AssetGroupID = 2, AssetGroupName = "Máy chấn", ColorCode = "#9ccc65" });
                Data_AssetGroup.Add(new Common.Data_AssetGroup() { AssetGroupID = 3, AssetGroupName = "Máy đột", ColorCode = "#E3DA30" });
                Data_AssetGroup.Add(new Common.Data_AssetGroup() { AssetGroupID = 4, AssetGroupName = "Máy hàn", ColorCode = "#ffba57" });
                Data_AssetGroup.Add(new Common.Data_AssetGroup() { AssetGroupID = 5, AssetGroupName = "Máy khoan", ColorCode = "#afabab" });
                Data_AssetGroup.Add(new Common.Data_AssetGroup() { AssetGroupID = 6, AssetGroupName = "Robot", ColorCode = "#ff5252" });

                #endregion

                #region Build table Data_Error --> https://docs.google.com/spreadsheets/d/1UMRjN9evTMvQwJMt31RtQRhMZcriXHBo0uEliIhr05M/edit#gid=1052012425&range=J38


                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 1,
                    ErrorName = "Bộ điều khiển",
                    ErrorNameNested = "Bộ điều khiển",
                    ParentID = 0,
                    ErrorCode = "E01100",
                    MachineGroupID = 1,
                    MachineGroupName = "GCN",
                    L = 1,
                    ChildPath = ",1,",
                    SearchPattern = " , Bộ điều khiển , E01100 , GCN , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 10,
                    ErrorName = "Cơ khí",
                    ErrorNameNested = "Cơ khí",
                    ParentID = 0,
                    ErrorCode = "E02500",
                    MachineGroupID = 5,
                    MachineGroupName = "ROBOT",
                    L = 1,
                    ChildPath = ",10,",
                    SearchPattern = " , Cơ khí , E02500 , ROBOT , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 185,
                    ErrorName = "Gá mỏ súng hàn/ cắt",
                    ErrorNameNested = "      Gá mỏ súng hàn/ cắt",
                    ParentID = 10,
                    ErrorCode = "E02501",
                    MachineGroupID = 5,
                    MachineGroupName = "ROBOT",
                    L = 2,
                    ChildPath = ",10,185,",
                    SearchPattern = " , Gá mỏ súng hàn/ cắt , E02501 , ROBOT , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 186,
                    ErrorName = "Đầu cấp dây",
                    ErrorNameNested = "      Đầu cấp dây",
                    ParentID = 10,
                    ErrorCode = "E02502",
                    MachineGroupID = 5,
                    MachineGroupName = "ROBOT",
                    L = 2,
                    ChildPath = ",10,186,",
                    SearchPattern = " , Đầu cấp dây , E02502 , ROBOT , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 187,
                    ErrorName = "Động cơ các Trục",
                    ErrorNameNested = "      Động cơ các Trục",
                    ParentID = 10,
                    ErrorCode = "E02503",
                    MachineGroupID = 5,
                    MachineGroupName = "ROBOT",
                    L = 2,
                    ChildPath = ",10,187,",
                    SearchPattern = " , Động cơ các Trục , E02503 , ROBOT , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 188,
                    ErrorName = "Hộp số",
                    ErrorNameNested = "      Hộp số",
                    ParentID = 10,
                    ErrorCode = "E02504",
                    MachineGroupID = 5,
                    MachineGroupName = "ROBOT",
                    L = 2,
                    ChildPath = ",10,188,",
                    SearchPattern = " , Hộp số , E02504 , ROBOT , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 189,
                    ErrorName = "Bánh răng",
                    ErrorNameNested = "      Bánh răng",
                    ParentID = 10,
                    ErrorCode = "E02505",
                    MachineGroupID = 5,
                    MachineGroupName = "ROBOT",
                    L = 2,
                    ChildPath = ",10,189,",
                    SearchPattern = " , Bánh răng , E02505 , ROBOT , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 11,
                    ErrorName = "Thủy lực, khí nén",
                    ErrorNameNested = "Thủy lực, khí nén",
                    ParentID = 0,
                    ErrorCode = "E03100",
                    MachineGroupID = 1,
                    MachineGroupName = "GCN",
                    L = 1,
                    ChildPath = ",11,",
                    SearchPattern = " , Thủy lực, khí nén , E03100 , GCN , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 190,
                    ErrorName = "Xilanh thủy lực",
                    ErrorNameNested = "      Xilanh thủy lực",
                    ParentID = 11,
                    ErrorCode = "E03101",
                    MachineGroupID = 1,
                    MachineGroupName = "GCN",
                    L = 2,
                    ChildPath = ",11,190,",
                    SearchPattern = " , Xilanh thủy lực , E03101 , GCN , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 191,
                    ErrorName = "Đầu bơm",
                    ErrorNameNested = "      Đầu bơm",
                    ParentID = 11,
                    ErrorCode = "E03102",
                    MachineGroupID = 1,
                    MachineGroupName = "GCN",
                    L = 2,
                    ChildPath = ",11,191,",
                    SearchPattern = " , Đầu bơm , E03102 , GCN , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 192,
                    ErrorName = "Van thủy lực",
                    ErrorNameNested = "      Van thủy lực",
                    ParentID = 11,
                    ErrorCode = "E03103",
                    MachineGroupID = 1,
                    MachineGroupName = "GCN",
                    L = 2,
                    ChildPath = ",11,192,",
                    SearchPattern = " , Van thủy lực , E03103 , GCN , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 193,
                    ErrorName = "Sin, phốt",
                    ErrorNameNested = "      Sin, phốt",
                    ParentID = 11,
                    ErrorCode = "E03104",
                    MachineGroupID = 1,
                    MachineGroupName = "GCN",
                    L = 2,
                    ChildPath = ",11,193,",
                    SearchPattern = " , Sin, phốt , E03104 , GCN , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 194,
                    ErrorName = "Van khí nén",
                    ErrorNameNested = "      Van khí nén",
                    ParentID = 11,
                    ErrorCode = "E03105",
                    MachineGroupID = 1,
                    MachineGroupName = "GCN",
                    L = 2,
                    ChildPath = ",11,194,",
                    SearchPattern = " , Van khí nén , E03105 , GCN , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 195,
                    ErrorName = "Dây khí nén",
                    ErrorNameNested = "      Dây khí nén",
                    ParentID = 11,
                    ErrorCode = "E03106",
                    MachineGroupID = 1,
                    MachineGroupName = "GCN",
                    L = 2,
                    ChildPath = ",11,195,",
                    SearchPattern = " , Dây khí nén , E03106 , GCN , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 196,
                    ErrorName = "Lọc khí",
                    ErrorNameNested = "      Lọc khí",
                    ParentID = 11,
                    ErrorCode = "E03107",
                    MachineGroupID = 1,
                    MachineGroupName = "GCN",
                    L = 2,
                    ChildPath = ",11,196,",
                    SearchPattern = " , Lọc khí , E03107 , GCN , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 197,
                    ErrorName = "Ống dẫn dầu",
                    ErrorNameNested = "      Ống dẫn dầu",
                    ParentID = 11,
                    ErrorCode = "E03108",
                    MachineGroupID = 1,
                    MachineGroupName = "GCN",
                    L = 2,
                    ChildPath = ",11,197,",
                    SearchPattern = " , Ống dẫn dầu , E03108 , GCN , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 198,
                    ErrorName = "Xilanh hơi",
                    ErrorNameNested = "      Xilanh hơi",
                    ParentID = 11,
                    ErrorCode = "E03109",
                    MachineGroupID = 1,
                    MachineGroupName = "GCN",
                    L = 2,
                    ChildPath = ",11,198,",
                    SearchPattern = " , Xilanh hơi , E03109 , GCN , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 199,
                    ErrorName = "kẹp thủy lực",
                    ErrorNameNested = "      kẹp thủy lực",
                    ParentID = 11,
                    ErrorCode = "E03110",
                    MachineGroupID = 1,
                    MachineGroupName = "GCN",
                    L = 2,
                    ChildPath = ",11,199,",
                    SearchPattern = " , kẹp thủy lực , E03110 , GCN , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 12,
                    ErrorName = "Thủy lực, khí nén",
                    ErrorNameNested = "Thủy lực, khí nén",
                    ParentID = 0,
                    ErrorCode = "E03200",
                    MachineGroupID = 2,
                    MachineGroupName = "DCTH",
                    L = 1,
                    ChildPath = ",12,",
                    SearchPattern = " , Thủy lực, khí nén , E03200 , DCTH , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 200,
                    ErrorName = "Xilanh hơi",
                    ErrorNameNested = "      Xilanh hơi",
                    ParentID = 12,
                    ErrorCode = "E03201",
                    MachineGroupID = 2,
                    MachineGroupName = "DCTH",
                    L = 2,
                    ChildPath = ",12,200,",
                    SearchPattern = " , Xilanh hơi , E03201 , DCTH , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 201,
                    ErrorName = "Bơm thủy lực",
                    ErrorNameNested = "      Bơm thủy lực",
                    ParentID = 12,
                    ErrorCode = "E03202",
                    MachineGroupID = 2,
                    MachineGroupName = "DCTH",
                    L = 2,
                    ChildPath = ",12,201,",
                    SearchPattern = " , Bơm thủy lực , E03202 , DCTH , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 202,
                    ErrorName = "Van phân phối",
                    ErrorNameNested = "      Van phân phối",
                    ParentID = 12,
                    ErrorCode = "E03203",
                    MachineGroupID = 2,
                    MachineGroupName = "DCTH",
                    L = 2,
                    ChildPath = ",12,202,",
                    SearchPattern = " , Van phân phối , E03203 , DCTH , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 203,
                    ErrorName = "Van áp cổng",
                    ErrorNameNested = "      Van áp cổng",
                    ParentID = 12,
                    ErrorCode = "E03204",
                    MachineGroupID = 2,
                    MachineGroupName = "DCTH",
                    L = 2,
                    ChildPath = ",12,203,",
                    SearchPattern = " , Van áp cổng , E03204 , DCTH , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 204,
                    ErrorName = "Van khí nén",
                    ErrorNameNested = "      Van khí nén",
                    ParentID = 12,
                    ErrorCode = "E03205",
                    MachineGroupID = 2,
                    MachineGroupName = "DCTH",
                    L = 2,
                    ChildPath = ",12,204,",
                    SearchPattern = " , Van khí nén , E03205 , DCTH , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 205,
                    ErrorName = "Sin phốt dầu",
                    ErrorNameNested = "      Sin phốt dầu",
                    ParentID = 12,
                    ErrorCode = "E03206",
                    MachineGroupID = 2,
                    MachineGroupName = "DCTH",
                    L = 2,
                    ChildPath = ",12,205,",
                    SearchPattern = " , Sin phốt dầu , E03206 , DCTH , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 206,
                    ErrorName = "Ống dẫn dầu",
                    ErrorNameNested = "      Ống dẫn dầu",
                    ParentID = 12,
                    ErrorCode = "E03207",
                    MachineGroupID = 2,
                    MachineGroupName = "DCTH",
                    L = 2,
                    ChildPath = ",12,206,",
                    SearchPattern = " , Ống dẫn dầu , E03207 , DCTH , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 207,
                    ErrorName = "Lọc dầu",
                    ErrorNameNested = "      Lọc dầu",
                    ParentID = 12,
                    ErrorCode = "E03208",
                    MachineGroupID = 2,
                    MachineGroupName = "DCTH",
                    L = 2,
                    ChildPath = ",12,207,",
                    SearchPattern = " , Lọc dầu , E03208 , DCTH , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 208,
                    ErrorName = "Dây khí nén",
                    ErrorNameNested = "      Dây khí nén",
                    ParentID = 12,
                    ErrorCode = "E03209",
                    MachineGroupID = 2,
                    MachineGroupName = "DCTH",
                    L = 2,
                    ChildPath = ",12,208,",
                    SearchPattern = " , Dây khí nén , E03209 , DCTH , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 209,
                    ErrorName = "Xilanh thủy lực",
                    ErrorNameNested = "      Xilanh thủy lực",
                    ParentID = 12,
                    ErrorCode = "E03210",
                    MachineGroupID = 2,
                    MachineGroupName = "DCTH",
                    L = 2,
                    ChildPath = ",12,209,",
                    SearchPattern = " , Xilanh thủy lực , E03210 , DCTH , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 13,
                    ErrorName = "Thủy lực, khí nén",
                    ErrorNameNested = "Thủy lực, khí nén",
                    ParentID = 0,
                    ErrorCode = "E03300",
                    MachineGroupID = 3,
                    MachineGroupName = "LASER",
                    L = 1,
                    ChildPath = ",13,",
                    SearchPattern = " , Thủy lực, khí nén , E03300 , LASER , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 210,
                    ErrorName = "Xilanh hơi",
                    ErrorNameNested = "      Xilanh hơi",
                    ParentID = 13,
                    ErrorCode = "E03301",
                    MachineGroupID = 3,
                    MachineGroupName = "LASER",
                    L = 2,
                    ChildPath = ",13,210,",
                    SearchPattern = " , Xilanh hơi , E03301 , LASER , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 211,
                    ErrorName = "Đầu bơm",
                    ErrorNameNested = "      Đầu bơm",
                    ParentID = 13,
                    ErrorCode = "E03302",
                    MachineGroupID = 3,
                    MachineGroupName = "LASER",
                    L = 2,
                    ChildPath = ",13,211,",
                    SearchPattern = " , Đầu bơm , E03302 , LASER , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 212,
                    ErrorName = "Van tổng",
                    ErrorNameNested = "      Van tổng",
                    ParentID = 13,
                    ErrorCode = "E03303",
                    MachineGroupID = 3,
                    MachineGroupName = "LASER",
                    L = 2,
                    ChildPath = ",13,212,",
                    SearchPattern = " , Van tổng , E03303 , LASER , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 213,
                    ErrorName = "Van phân phối",
                    ErrorNameNested = "      Van phân phối",
                    ParentID = 13,
                    ErrorCode = "E03304",
                    MachineGroupID = 3,
                    MachineGroupName = "LASER",
                    L = 2,
                    ChildPath = ",13,213,",
                    SearchPattern = " , Van phân phối , E03304 , LASER , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 214,
                    ErrorName = "Lọc khí",
                    ErrorNameNested = "      Lọc khí",
                    ParentID = 13,
                    ErrorCode = "E03305",
                    MachineGroupID = 3,
                    MachineGroupName = "LASER",
                    L = 2,
                    ChildPath = ",13,214,",
                    SearchPattern = " , Lọc khí , E03305 , LASER , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 215,
                    ErrorName = "Van khí",
                    ErrorNameNested = "      Van khí",
                    ParentID = 13,
                    ErrorCode = "E03306",
                    MachineGroupID = 3,
                    MachineGroupName = "LASER",
                    L = 2,
                    ChildPath = ",13,215,",
                    SearchPattern = " , Van khí , E03306 , LASER , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 216,
                    ErrorName = "Cảm biến khí",
                    ErrorNameNested = "      Cảm biến khí",
                    ParentID = 13,
                    ErrorCode = "E03307",
                    MachineGroupID = 3,
                    MachineGroupName = "LASER",
                    L = 2,
                    ChildPath = ",13,216,",
                    SearchPattern = " , Cảm biến khí , E03307 , LASER , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 217,
                    ErrorName = "Xilanh thủy lực",
                    ErrorNameNested = "      Xilanh thủy lực",
                    ParentID = 13,
                    ErrorCode = "E03308",
                    MachineGroupID = 3,
                    MachineGroupName = "LASER",
                    L = 2,
                    ChildPath = ",13,217,",
                    SearchPattern = " , Xilanh thủy lực , E03308 , LASER , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 218,
                    ErrorName = "Đồng hồ khí (O2,N2)",
                    ErrorNameNested = "      Đồng hồ khí (O2,N2)",
                    ParentID = 13,
                    ErrorCode = "E03309",
                    MachineGroupID = 3,
                    MachineGroupName = "LASER",
                    L = 2,
                    ChildPath = ",13,218,",
                    SearchPattern = " , Đồng hồ khí (O2,N2) , E03309 , LASER , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 219,
                    ErrorName = "Dây ống khí",
                    ErrorNameNested = "      Dây ống khí",
                    ParentID = 13,
                    ErrorCode = "E03310",
                    MachineGroupID = 3,
                    MachineGroupName = "LASER",
                    L = 2,
                    ChildPath = ",13,219,",
                    SearchPattern = " , Dây ống khí , E03310 , LASER , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 14,
                    ErrorName = "Thủy lực, khí nén",
                    ErrorNameNested = "Thủy lực, khí nén",
                    ParentID = 0,
                    ErrorCode = "E03400",
                    MachineGroupID = 4,
                    MachineGroupName = "PLASMA",
                    L = 1,
                    ChildPath = ",14,",
                    SearchPattern = " , Thủy lực, khí nén , E03400 , PLASMA , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 220,
                    ErrorName = "Van khí oxygas",
                    ErrorNameNested = "      Van khí oxygas",
                    ParentID = 14,
                    ErrorCode = "E03401",
                    MachineGroupID = 4,
                    MachineGroupName = "PLASMA",
                    L = 2,
                    ChildPath = ",14,220,",
                    SearchPattern = " , Van khí oxygas , E03401 , PLASMA , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 221,
                    ErrorName = "Van khí plasma",
                    ErrorNameNested = "      Van khí plasma",
                    ParentID = 14,
                    ErrorCode = "E03402",
                    MachineGroupID = 4,
                    MachineGroupName = "PLASMA",
                    L = 2,
                    ChildPath = ",14,221,",
                    SearchPattern = " , Van khí plasma , E03402 , PLASMA , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 222,
                    ErrorName = "Lọc khí",
                    ErrorNameNested = "      Lọc khí",
                    ParentID = 14,
                    ErrorCode = "E03403",
                    MachineGroupID = 4,
                    MachineGroupName = "PLASMA",
                    L = 2,
                    ChildPath = ",14,222,",
                    SearchPattern = " , Lọc khí , E03403 , PLASMA , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 223,
                    ErrorName = "Đường dây khí",
                    ErrorNameNested = "      Đường dây khí",
                    ParentID = 14,
                    ErrorCode = "E03404",
                    MachineGroupID = 4,
                    MachineGroupName = "PLASMA",
                    L = 2,
                    ChildPath = ",14,223,",
                    SearchPattern = " , Đường dây khí , E03404 , PLASMA , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 224,
                    ErrorName = "Đồng hồ khí",
                    ErrorNameNested = "      Đồng hồ khí",
                    ParentID = 14,
                    ErrorCode = "E03405",
                    MachineGroupID = 4,
                    MachineGroupName = "PLASMA",
                    L = 2,
                    ChildPath = ",14,224,",
                    SearchPattern = " , Đồng hồ khí , E03405 , PLASMA , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 225,
                    ErrorName = "Bộ bơm thủy lực",
                    ErrorNameNested = "      Bộ bơm thủy lực",
                    ParentID = 14,
                    ErrorCode = "E03406",
                    MachineGroupID = 4,
                    MachineGroupName = "PLASMA",
                    L = 2,
                    ChildPath = ",14,225,",
                    SearchPattern = " , Bộ bơm thủy lực , E03406 , PLASMA , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 226,
                    ErrorName = "Bộ kẹp, đẩy thủy lực",
                    ErrorNameNested = "      Bộ kẹp, đẩy thủy lực",
                    ParentID = 14,
                    ErrorCode = "E03407",
                    MachineGroupID = 4,
                    MachineGroupName = "PLASMA",
                    L = 2,
                    ChildPath = ",14,226,",
                    SearchPattern = " , Bộ kẹp, đẩy thủy lực , E03407 , PLASMA , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 227,
                    ErrorName = "Chất lượng khí",
                    ErrorNameNested = "      Chất lượng khí",
                    ParentID = 14,
                    ErrorCode = "E03408",
                    MachineGroupID = 4,
                    MachineGroupName = "PLASMA",
                    L = 2,
                    ChildPath = ",14,227,",
                    SearchPattern = " , Chất lượng khí , E03408 , PLASMA , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 15,
                    ErrorName = "Thủy lực, khí nén",
                    ErrorNameNested = "Thủy lực, khí nén",
                    ParentID = 0,
                    ErrorCode = "E03500",
                    MachineGroupID = 5,
                    MachineGroupName = "ROBOT",
                    L = 1,
                    ChildPath = ",15,",
                    SearchPattern = " , Thủy lực, khí nén , E03500 , ROBOT , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 228,
                    ErrorName = "Dầu bôi trơn các khớp",
                    ErrorNameNested = "      Dầu bôi trơn các khớp",
                    ParentID = 15,
                    ErrorCode = "E03501",
                    MachineGroupID = 5,
                    MachineGroupName = "ROBOT",
                    L = 2,
                    ChildPath = ",15,228,",
                    SearchPattern = " , Dầu bôi trơn các khớp , E03501 , ROBOT , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 229,
                    ErrorName = "Đồng hồ khí (CO2, argon)",
                    ErrorNameNested = "      Đồng hồ khí (CO2, argon)",
                    ParentID = 15,
                    ErrorCode = "E03502",
                    MachineGroupID = 5,
                    MachineGroupName = "ROBOT",
                    L = 2,
                    ChildPath = ",15,229,",
                    SearchPattern = " , Đồng hồ khí (CO2, argon) , E03502 , ROBOT , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 230,
                    ErrorName = "Dây khí nén",
                    ErrorNameNested = "      Dây khí nén",
                    ParentID = 15,
                    ErrorCode = "E03503",
                    MachineGroupID = 5,
                    MachineGroupName = "ROBOT",
                    L = 2,
                    ChildPath = ",15,230,",
                    SearchPattern = " , Dây khí nén , E03503 , ROBOT , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 231,
                    ErrorName = "Bộ gá xoay",
                    ErrorNameNested = "      Bộ gá xoay",
                    ParentID = 15,
                    ErrorCode = "E03504",
                    MachineGroupID = 5,
                    MachineGroupName = "ROBOT",
                    L = 2,
                    ChildPath = ",15,231,",
                    SearchPattern = " , Bộ gá xoay , E03504 , ROBOT , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 16,
                    ErrorName = "Tủ điện điều khiển",
                    ErrorNameNested = "Tủ điện điều khiển",
                    ParentID = 0,
                    ErrorCode = "E04100",
                    MachineGroupID = 1,
                    MachineGroupName = "GCN",
                    L = 1,
                    ChildPath = ",16,",
                    SearchPattern = " , Tủ điện điều khiển , E04100 , GCN , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 232,
                    ErrorName = "PLC",
                    ErrorNameNested = "      PLC",
                    ParentID = 16,
                    ErrorCode = "E04101",
                    MachineGroupID = 1,
                    MachineGroupName = "GCN",
                    L = 2,
                    ChildPath = ",16,232,",
                    SearchPattern = " , PLC , E04101 , GCN , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 233,
                    ErrorName = "Relay",
                    ErrorNameNested = "      Relay",
                    ParentID = 16,
                    ErrorCode = "E04102",
                    MachineGroupID = 1,
                    MachineGroupName = "GCN",
                    L = 2,
                    ChildPath = ",16,233,",
                    SearchPattern = " , Relay , E04102 , GCN , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 234,
                    ErrorName = "Khởi động từ",
                    ErrorNameNested = "      Khởi động từ",
                    ParentID = 16,
                    ErrorCode = "E04103",
                    MachineGroupID = 1,
                    MachineGroupName = "GCN",
                    L = 2,
                    ChildPath = ",16,234,",
                    SearchPattern = " , Khởi động từ , E04103 , GCN , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 235,
                    ErrorName = "CB nguồn",
                    ErrorNameNested = "      CB nguồn",
                    ParentID = 16,
                    ErrorCode = "E04104",
                    MachineGroupID = 1,
                    MachineGroupName = "GCN",
                    L = 2,
                    ChildPath = ",16,235,",
                    SearchPattern = " , CB nguồn , E04104 , GCN , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 236,
                    ErrorName = "Driver",
                    ErrorNameNested = "      Driver",
                    ParentID = 16,
                    ErrorCode = "E04105",
                    MachineGroupID = 1,
                    MachineGroupName = "GCN",
                    L = 2,
                    ChildPath = ",16,236,",
                    SearchPattern = " , Driver , E04105 , GCN , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 237,
                    ErrorName = "Cầu chì",
                    ErrorNameNested = "      Cầu chì",
                    ParentID = 16,
                    ErrorCode = "E04106",
                    MachineGroupID = 1,
                    MachineGroupName = "GCN",
                    L = 2,
                    ChildPath = ",16,237,",
                    SearchPattern = " , Cầu chì , E04106 , GCN , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 238,
                    ErrorName = "Biến tần",
                    ErrorNameNested = "      Biến tần",
                    ParentID = 16,
                    ErrorCode = "E04107",
                    MachineGroupID = 1,
                    MachineGroupName = "GCN",
                    L = 2,
                    ChildPath = ",16,238,",
                    SearchPattern = " , Biến tần , E04107 , GCN , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 239,
                    ErrorName = "Biến thế",
                    ErrorNameNested = "      Biến thế",
                    ParentID = 16,
                    ErrorCode = "E04108",
                    MachineGroupID = 1,
                    MachineGroupName = "GCN",
                    L = 2,
                    ChildPath = ",16,239,",
                    SearchPattern = " , Biến thế , E04108 , GCN , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 240,
                    ErrorName = "Nguồn tổ Ong",
                    ErrorNameNested = "      Nguồn tổ Ong",
                    ParentID = 16,
                    ErrorCode = "E04109",
                    MachineGroupID = 1,
                    MachineGroupName = "GCN",
                    L = 2,
                    ChildPath = ",16,240,",
                    SearchPattern = " , Nguồn tổ Ong , E04109 , GCN , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 241,
                    ErrorName = "Moduml truyền thông",
                    ErrorNameNested = "      Moduml truyền thông",
                    ParentID = 16,
                    ErrorCode = "E04110",
                    MachineGroupID = 1,
                    MachineGroupName = "GCN",
                    L = 2,
                    ChildPath = ",16,241,",
                    SearchPattern = " , Moduml truyền thông , E04110 , GCN , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 17,
                    ErrorName = "Tủ điện điều khiển",
                    ErrorNameNested = "Tủ điện điều khiển",
                    ParentID = 0,
                    ErrorCode = "E04200",
                    MachineGroupID = 2,
                    MachineGroupName = "DCTH",
                    L = 1,
                    ChildPath = ",17,",
                    SearchPattern = " , Tủ điện điều khiển , E04200 , DCTH , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 242,
                    ErrorName = "PLC",
                    ErrorNameNested = "      PLC",
                    ParentID = 17,
                    ErrorCode = "E04201",
                    MachineGroupID = 2,
                    MachineGroupName = "DCTH",
                    L = 2,
                    ChildPath = ",17,242,",
                    SearchPattern = " , PLC , E04201 , DCTH , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 243,
                    ErrorName = "Relay",
                    ErrorNameNested = "      Relay",
                    ParentID = 17,
                    ErrorCode = "E04202",
                    MachineGroupID = 2,
                    MachineGroupName = "DCTH",
                    L = 2,
                    ChildPath = ",17,243,",
                    SearchPattern = " , Relay , E04202 , DCTH , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 244,
                    ErrorName = "Khởi động từ",
                    ErrorNameNested = "      Khởi động từ",
                    ParentID = 17,
                    ErrorCode = "E04203",
                    MachineGroupID = 2,
                    MachineGroupName = "DCTH",
                    L = 2,
                    ChildPath = ",17,244,",
                    SearchPattern = " , Khởi động từ , E04203 , DCTH , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 245,
                    ErrorName = "CB nguồn",
                    ErrorNameNested = "      CB nguồn",
                    ParentID = 17,
                    ErrorCode = "E04204",
                    MachineGroupID = 2,
                    MachineGroupName = "DCTH",
                    L = 2,
                    ChildPath = ",17,245,",
                    SearchPattern = " , CB nguồn , E04204 , DCTH , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 246,
                    ErrorName = "Driver",
                    ErrorNameNested = "      Driver",
                    ParentID = 17,
                    ErrorCode = "E04205",
                    MachineGroupID = 2,
                    MachineGroupName = "DCTH",
                    L = 2,
                    ChildPath = ",17,246,",
                    SearchPattern = " , Driver , E04205 , DCTH , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 247,
                    ErrorName = "Cầu chì",
                    ErrorNameNested = "      Cầu chì",
                    ParentID = 17,
                    ErrorCode = "E04206",
                    MachineGroupID = 2,
                    MachineGroupName = "DCTH",
                    L = 2,
                    ChildPath = ",17,247,",
                    SearchPattern = " , Cầu chì , E04206 , DCTH , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 248,
                    ErrorName = "Biến tần",
                    ErrorNameNested = "      Biến tần",
                    ParentID = 17,
                    ErrorCode = "E04207",
                    MachineGroupID = 2,
                    MachineGroupName = "DCTH",
                    L = 2,
                    ChildPath = ",17,248,",
                    SearchPattern = " , Biến tần , E04207 , DCTH , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 249,
                    ErrorName = "Biến thế",
                    ErrorNameNested = "      Biến thế",
                    ParentID = 17,
                    ErrorCode = "E04208",
                    MachineGroupID = 2,
                    MachineGroupName = "DCTH",
                    L = 2,
                    ChildPath = ",17,249,",
                    SearchPattern = " , Biến thế , E04208 , DCTH , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 250,
                    ErrorName = "Nguồn tổ Ong",
                    ErrorNameNested = "      Nguồn tổ Ong",
                    ParentID = 17,
                    ErrorCode = "E04209",
                    MachineGroupID = 2,
                    MachineGroupName = "DCTH",
                    L = 2,
                    ChildPath = ",17,250,",
                    SearchPattern = " , Nguồn tổ Ong , E04209 , DCTH , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 251,
                    ErrorName = "Moduml truyền thông",
                    ErrorNameNested = "      Moduml truyền thông",
                    ParentID = 17,
                    ErrorCode = "E04210",
                    MachineGroupID = 2,
                    MachineGroupName = "DCTH",
                    L = 2,
                    ChildPath = ",17,251,",
                    SearchPattern = " , Moduml truyền thông , E04210 , DCTH , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 18,
                    ErrorName = "Tủ điện điều khiển",
                    ErrorNameNested = "Tủ điện điều khiển",
                    ParentID = 0,
                    ErrorCode = "E04300",
                    MachineGroupID = 3,
                    MachineGroupName = "LASER",
                    L = 1,
                    ChildPath = ",18,",
                    SearchPattern = " , Tủ điện điều khiển , E04300 , LASER , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 252,
                    ErrorName = "Plc",
                    ErrorNameNested = "      Plc",
                    ParentID = 18,
                    ErrorCode = "E04301",
                    MachineGroupID = 3,
                    MachineGroupName = "LASER",
                    L = 2,
                    ChildPath = ",18,252,",
                    SearchPattern = " , Plc , E04301 , LASER , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 253,
                    ErrorName = "Relay",
                    ErrorNameNested = "      Relay",
                    ParentID = 18,
                    ErrorCode = "E04302",
                    MachineGroupID = 3,
                    MachineGroupName = "LASER",
                    L = 2,
                    ChildPath = ",18,253,",
                    SearchPattern = " , Relay , E04302 , LASER , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 254,
                    ErrorName = "Khởi đông từ",
                    ErrorNameNested = "      Khởi đông từ",
                    ParentID = 18,
                    ErrorCode = "E04303",
                    MachineGroupID = 3,
                    MachineGroupName = "LASER",
                    L = 2,
                    ChildPath = ",18,254,",
                    SearchPattern = " , Khởi đông từ , E04303 , LASER , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 255,
                    ErrorName = "CB nguồn",
                    ErrorNameNested = "      CB nguồn",
                    ParentID = 18,
                    ErrorCode = "E04304",
                    MachineGroupID = 3,
                    MachineGroupName = "LASER",
                    L = 2,
                    ChildPath = ",18,255,",
                    SearchPattern = " , CB nguồn , E04304 , LASER , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 256,
                    ErrorName = "Driver",
                    ErrorNameNested = "      Driver",
                    ParentID = 18,
                    ErrorCode = "E04305",
                    MachineGroupID = 3,
                    MachineGroupName = "LASER",
                    L = 2,
                    ChildPath = ",18,256,",
                    SearchPattern = " , Driver , E04305 , LASER , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 257,
                    ErrorName = "Cầu chì",
                    ErrorNameNested = "      Cầu chì",
                    ParentID = 18,
                    ErrorCode = "E04306",
                    MachineGroupID = 3,
                    MachineGroupName = "LASER",
                    L = 2,
                    ChildPath = ",18,257,",
                    SearchPattern = " , Cầu chì , E04306 , LASER , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 258,
                    ErrorName = "Biến tần",
                    ErrorNameNested = "      Biến tần",
                    ParentID = 18,
                    ErrorCode = "E04307",
                    MachineGroupID = 3,
                    MachineGroupName = "LASER",
                    L = 2,
                    ChildPath = ",18,258,",
                    SearchPattern = " , Biến tần , E04307 , LASER , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 259,
                    ErrorName = "Biến thế",
                    ErrorNameNested = "      Biến thế",
                    ParentID = 18,
                    ErrorCode = "E04308",
                    MachineGroupID = 3,
                    MachineGroupName = "LASER",
                    L = 2,
                    ChildPath = ",18,259,",
                    SearchPattern = " , Biến thế , E04308 , LASER , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 260,
                    ErrorName = "Nguồn tổ Ong",
                    ErrorNameNested = "      Nguồn tổ Ong",
                    ParentID = 18,
                    ErrorCode = "E04309",
                    MachineGroupID = 3,
                    MachineGroupName = "LASER",
                    L = 2,
                    ChildPath = ",18,260,",
                    SearchPattern = " , Nguồn tổ Ong , E04309 , LASER , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 261,
                    ErrorName = "Bo relay IO",
                    ErrorNameNested = "      Bo relay IO",
                    ParentID = 18,
                    ErrorCode = "E04310",
                    MachineGroupID = 3,
                    MachineGroupName = "LASER",
                    L = 2,
                    ChildPath = ",18,261,",
                    SearchPattern = " , Bo relay IO , E04310 , LASER , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 262,
                    ErrorName = "Module truyền thông",
                    ErrorNameNested = "      Module truyền thông",
                    ParentID = 18,
                    ErrorCode = "E04311",
                    MachineGroupID = 3,
                    MachineGroupName = "LASER",
                    L = 2,
                    ChildPath = ",18,262,",
                    SearchPattern = " , Module truyền thông , E04311 , LASER , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 19,
                    ErrorName = "Tủ điện điều khiển",
                    ErrorNameNested = "Tủ điện điều khiển",
                    ParentID = 0,
                    ErrorCode = "E04400",
                    MachineGroupID = 4,
                    MachineGroupName = "PLASMA",
                    L = 1,
                    ChildPath = ",19,",
                    SearchPattern = " , Tủ điện điều khiển , E04400 , PLASMA , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 263,
                    ErrorName = "Plc",
                    ErrorNameNested = "      Plc",
                    ParentID = 19,
                    ErrorCode = "E04401",
                    MachineGroupID = 4,
                    MachineGroupName = "PLASMA",
                    L = 2,
                    ChildPath = ",19,263,",
                    SearchPattern = " , Plc , E04401 , PLASMA , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 264,
                    ErrorName = "Relay",
                    ErrorNameNested = "      Relay",
                    ParentID = 19,
                    ErrorCode = "E04402",
                    MachineGroupID = 4,
                    MachineGroupName = "PLASMA",
                    L = 2,
                    ChildPath = ",19,264,",
                    SearchPattern = " , Relay , E04402 , PLASMA , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 265,
                    ErrorName = "khởi đông từ",
                    ErrorNameNested = "      khởi đông từ",
                    ParentID = 19,
                    ErrorCode = "E04403",
                    MachineGroupID = 4,
                    MachineGroupName = "PLASMA",
                    L = 2,
                    ChildPath = ",19,265,",
                    SearchPattern = " , khởi đông từ , E04403 , PLASMA , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 266,
                    ErrorName = "CB nguồn",
                    ErrorNameNested = "      CB nguồn",
                    ParentID = 19,
                    ErrorCode = "E04404",
                    MachineGroupID = 4,
                    MachineGroupName = "PLASMA",
                    L = 2,
                    ChildPath = ",19,266,",
                    SearchPattern = " , CB nguồn , E04404 , PLASMA , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 267,
                    ErrorName = "Driver",
                    ErrorNameNested = "      Driver",
                    ParentID = 19,
                    ErrorCode = "E04405",
                    MachineGroupID = 4,
                    MachineGroupName = "PLASMA",
                    L = 2,
                    ChildPath = ",19,267,",
                    SearchPattern = " , Driver , E04405 , PLASMA , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 268,
                    ErrorName = "Cầu chì",
                    ErrorNameNested = "      Cầu chì",
                    ParentID = 19,
                    ErrorCode = "E04406",
                    MachineGroupID = 4,
                    MachineGroupName = "PLASMA",
                    L = 2,
                    ChildPath = ",19,268,",
                    SearchPattern = " , Cầu chì , E04406 , PLASMA , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 269,
                    ErrorName = "Biến tần",
                    ErrorNameNested = "      Biến tần",
                    ParentID = 19,
                    ErrorCode = "E04407",
                    MachineGroupID = 4,
                    MachineGroupName = "PLASMA",
                    L = 2,
                    ChildPath = ",19,269,",
                    SearchPattern = " , Biến tần , E04407 , PLASMA , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 270,
                    ErrorName = "Biến thế",
                    ErrorNameNested = "      Biến thế",
                    ParentID = 19,
                    ErrorCode = "E04408",
                    MachineGroupID = 4,
                    MachineGroupName = "PLASMA",
                    L = 2,
                    ChildPath = ",19,270,",
                    SearchPattern = " , Biến thế , E04408 , PLASMA , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 271,
                    ErrorName = "Nguồn tổ Ong",
                    ErrorNameNested = "      Nguồn tổ Ong",
                    ParentID = 19,
                    ErrorCode = "E04409",
                    MachineGroupID = 4,
                    MachineGroupName = "PLASMA",
                    L = 2,
                    ChildPath = ",19,271,",
                    SearchPattern = " , Nguồn tổ Ong , E04409 , PLASMA , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 272,
                    ErrorName = "Bo relay IO",
                    ErrorNameNested = "      Bo relay IO",
                    ParentID = 19,
                    ErrorCode = "E04410",
                    MachineGroupID = 4,
                    MachineGroupName = "PLASMA",
                    L = 2,
                    ChildPath = ",19,272,",
                    SearchPattern = " , Bo relay IO , E04410 , PLASMA , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 273,
                    ErrorName = "Module truyền thông",
                    ErrorNameNested = "      Module truyền thông",
                    ParentID = 19,
                    ErrorCode = "E04411",
                    MachineGroupID = 4,
                    MachineGroupName = "PLASMA",
                    L = 2,
                    ChildPath = ",19,273,",
                    SearchPattern = " , Module truyền thông , E04411 , PLASMA , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 2,
                    ErrorName = "Bộ điều khiển",
                    ErrorNameNested = "Bộ điều khiển",
                    ParentID = 0,
                    ErrorCode = "E01200",
                    MachineGroupID = 2,
                    MachineGroupName = "DCTH",
                    L = 1,
                    ChildPath = ",2,",
                    SearchPattern = " , Bộ điều khiển , E01200 , DCTH , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 20,
                    ErrorName = "Tủ điện điều khiển",
                    ErrorNameNested = "Tủ điện điều khiển",
                    ParentID = 0,
                    ErrorCode = "E04500",
                    MachineGroupID = 5,
                    MachineGroupName = "ROBOT",
                    L = 1,
                    ChildPath = ",20,",
                    SearchPattern = " , Tủ điện điều khiển , E04500 , ROBOT , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 274,
                    ErrorName = "Plc",
                    ErrorNameNested = "      Plc",
                    ParentID = 20,
                    ErrorCode = "E04501",
                    MachineGroupID = 5,
                    MachineGroupName = "ROBOT",
                    L = 2,
                    ChildPath = ",20,274,",
                    SearchPattern = " , Plc , E04501 , ROBOT , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 275,
                    ErrorName = "Relay",
                    ErrorNameNested = "      Relay",
                    ParentID = 20,
                    ErrorCode = "E04502",
                    MachineGroupID = 5,
                    MachineGroupName = "ROBOT",
                    L = 2,
                    ChildPath = ",20,275,",
                    SearchPattern = " , Relay , E04502 , ROBOT , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 276,
                    ErrorName = "khởi đông từ",
                    ErrorNameNested = "      khởi đông từ",
                    ParentID = 20,
                    ErrorCode = "E04503",
                    MachineGroupID = 5,
                    MachineGroupName = "ROBOT",
                    L = 2,
                    ChildPath = ",20,276,",
                    SearchPattern = " , khởi đông từ , E04503 , ROBOT , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 277,
                    ErrorName = "CB nguồn",
                    ErrorNameNested = "      CB nguồn",
                    ParentID = 20,
                    ErrorCode = "E04504",
                    MachineGroupID = 5,
                    MachineGroupName = "ROBOT",
                    L = 2,
                    ChildPath = ",20,277,",
                    SearchPattern = " , CB nguồn , E04504 , ROBOT , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 278,
                    ErrorName = "Driver control",
                    ErrorNameNested = "      Driver control",
                    ParentID = 20,
                    ErrorCode = "E04505",
                    MachineGroupID = 5,
                    MachineGroupName = "ROBOT",
                    L = 2,
                    ChildPath = ",20,278,",
                    SearchPattern = " , Driver control , E04505 , ROBOT , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 279,
                    ErrorName = "Board I/O",
                    ErrorNameNested = "      Board I/O",
                    ParentID = 20,
                    ErrorCode = "E04506",
                    MachineGroupID = 5,
                    MachineGroupName = "ROBOT",
                    L = 2,
                    ChildPath = ",20,279,",
                    SearchPattern = " , Board I/O , E04506 , ROBOT , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 280,
                    ErrorName = "Moduml truyền thông",
                    ErrorNameNested = "      Moduml truyền thông",
                    ParentID = 20,
                    ErrorCode = "E04507",
                    MachineGroupID = 5,
                    MachineGroupName = "ROBOT",
                    L = 2,
                    ChildPath = ",20,280,",
                    SearchPattern = " , Moduml truyền thông , E04507 , ROBOT , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 21,
                    ErrorName = "Hệ thống điều khiển",
                    ErrorNameNested = "Hệ thống điều khiển",
                    ParentID = 0,
                    ErrorCode = "E05100",
                    MachineGroupID = 1,
                    MachineGroupName = "GCN",
                    L = 1,
                    ChildPath = ",21,",
                    SearchPattern = " , Hệ thống điều khiển , E05100 , GCN , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 79,
                    ErrorName = "Cảm biến hành trình",
                    ErrorNameNested = "      Cảm biến hành trình",
                    ParentID = 21,
                    ErrorCode = "E01101",
                    MachineGroupID = 1,
                    MachineGroupName = "GCN",
                    L = 2,
                    ChildPath = ",21,79,",
                    SearchPattern = " , Cảm biến hành trình , E01101 , GCN , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 80,
                    ErrorName = "Màn hình Delem",
                    ErrorNameNested = "      Màn hình Delem",
                    ParentID = 21,
                    ErrorCode = "E01102",
                    MachineGroupID = 1,
                    MachineGroupName = "GCN",
                    L = 2,
                    ChildPath = ",21,80,",
                    SearchPattern = " , Màn hình Delem , E01102 , GCN , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 81,
                    ErrorName = "Động cơ bước",
                    ErrorNameNested = "      Động cơ bước",
                    ParentID = 21,
                    ErrorCode = "E01103",
                    MachineGroupID = 1,
                    MachineGroupName = "GCN",
                    L = 2,
                    ChildPath = ",21,81,",
                    SearchPattern = " , Động cơ bước , E01103 , GCN , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 82,
                    ErrorName = "Driver",
                    ErrorNameNested = "      Driver",
                    ParentID = 21,
                    ErrorCode = "E01104",
                    MachineGroupID = 1,
                    MachineGroupName = "GCN",
                    L = 2,
                    ChildPath = ",21,82,",
                    SearchPattern = " , Driver , E01104 , GCN , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 83,
                    ErrorName = "Công tắc hành trình/biến trở",
                    ErrorNameNested = "      Công tắc hành trình/biến trở",
                    ParentID = 21,
                    ErrorCode = "E01105",
                    MachineGroupID = 1,
                    MachineGroupName = "GCN",
                    L = 2,
                    ChildPath = ",21,83,",
                    SearchPattern = " , Công tắc hành trình/biến trở , E01105 , GCN , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 84,
                    ErrorName = "Nút nhấn",
                    ErrorNameNested = "      Nút nhấn",
                    ParentID = 21,
                    ErrorCode = "E01106",
                    MachineGroupID = 1,
                    MachineGroupName = "GCN",
                    L = 2,
                    ChildPath = ",21,84,",
                    SearchPattern = " , Nút nhấn , E01106 , GCN , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 85,
                    ErrorName = "Màn hình điều khiển",
                    ErrorNameNested = "      Màn hình điều khiển",
                    ParentID = 21,
                    ErrorCode = "E01107",
                    MachineGroupID = 1,
                    MachineGroupName = "GCN",
                    L = 2,
                    ChildPath = ",21,85,",
                    SearchPattern = " , Màn hình điều khiển , E01107 , GCN , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 86,
                    ErrorName = "Remote",
                    ErrorNameNested = "      Remote",
                    ParentID = 21,
                    ErrorCode = "E01108",
                    MachineGroupID = 1,
                    MachineGroupName = "GCN",
                    L = 2,
                    ChildPath = ",21,86,",
                    SearchPattern = " , Remote , E01108 , GCN , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 87,
                    ErrorName = "Encoder",
                    ErrorNameNested = "      Encoder",
                    ParentID = 21,
                    ErrorCode = "E01109",
                    MachineGroupID = 1,
                    MachineGroupName = "GCN",
                    L = 2,
                    ChildPath = ",21,87,",
                    SearchPattern = " , Encoder , E01109 , GCN , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 88,
                    ErrorName = "Máy tính",
                    ErrorNameNested = "      Máy tính",
                    ParentID = 21,
                    ErrorCode = "E01110",
                    MachineGroupID = 1,
                    MachineGroupName = "GCN",
                    L = 2,
                    ChildPath = ",21,88,",
                    SearchPattern = " , Máy tính , E01110 , GCN , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 22,
                    ErrorName = "Hệ thống điều khiển",
                    ErrorNameNested = "Hệ thống điều khiển",
                    ParentID = 0,
                    ErrorCode = "E05200",
                    MachineGroupID = 2,
                    MachineGroupName = "DCTH",
                    L = 1,
                    ChildPath = ",22,",
                    SearchPattern = " , Hệ thống điều khiển , E05200 , DCTH , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 70,
                    ErrorName = "Cảm biến quang",
                    ErrorNameNested = "      Cảm biến quang",
                    ParentID = 22,
                    ErrorCode = "E01201",
                    MachineGroupID = 2,
                    MachineGroupName = "DCTH",
                    L = 2,
                    ChildPath = ",22,70,",
                    SearchPattern = " , Cảm biến quang , E01201 , DCTH , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 71,
                    ErrorName = "Cảm biến từ",
                    ErrorNameNested = "      Cảm biến từ",
                    ParentID = 22,
                    ErrorCode = "E01202",
                    MachineGroupID = 2,
                    MachineGroupName = "DCTH",
                    L = 2,
                    ChildPath = ",22,71,",
                    SearchPattern = " , Cảm biến từ , E01202 , DCTH , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 72,
                    ErrorName = "Màn hình cảm ứng keyen",
                    ErrorNameNested = "      Màn hình cảm ứng keyen",
                    ParentID = 22,
                    ErrorCode = "E01203",
                    MachineGroupID = 2,
                    MachineGroupName = "DCTH",
                    L = 2,
                    ChildPath = ",22,72,",
                    SearchPattern = " , Màn hình cảm ứng keyen , E01203 , DCTH , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 73,
                    ErrorName = "Nút nhấn",
                    ErrorNameNested = "      Nút nhấn",
                    ParentID = 22,
                    ErrorCode = "E01204",
                    MachineGroupID = 2,
                    MachineGroupName = "DCTH",
                    L = 2,
                    ChildPath = ",22,73,",
                    SearchPattern = " , Nút nhấn , E01204 , DCTH , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 74,
                    ErrorName = "Công tắc gạt",
                    ErrorNameNested = "      Công tắc gạt",
                    ParentID = 22,
                    ErrorCode = "E01205",
                    MachineGroupID = 2,
                    MachineGroupName = "DCTH",
                    L = 2,
                    ChildPath = ",22,74,",
                    SearchPattern = " , Công tắc gạt , E01205 , DCTH , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 75,
                    ErrorName = "Biến trở",
                    ErrorNameNested = "      Biến trở",
                    ParentID = 22,
                    ErrorCode = "E01206",
                    MachineGroupID = 2,
                    MachineGroupName = "DCTH",
                    L = 2,
                    ChildPath = ",22,75,",
                    SearchPattern = " , Biến trở , E01206 , DCTH , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 76,
                    ErrorName = "Động cơ 3 pha",
                    ErrorNameNested = "      Động cơ 3 pha",
                    ParentID = 22,
                    ErrorCode = "E01207",
                    MachineGroupID = 2,
                    MachineGroupName = "DCTH",
                    L = 2,
                    ChildPath = ",22,76,",
                    SearchPattern = " , Động cơ 3 pha , E01207 , DCTH , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 77,
                    ErrorName = "Động cơ servo",
                    ErrorNameNested = "      Động cơ servo",
                    ParentID = 22,
                    ErrorCode = "E01208",
                    MachineGroupID = 2,
                    MachineGroupName = "DCTH",
                    L = 2,
                    ChildPath = ",22,77,",
                    SearchPattern = " , Động cơ servo , E01208 , DCTH , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 78,
                    ErrorName = "Công tắc hành trình",
                    ErrorNameNested = "      Công tắc hành trình",
                    ParentID = 22,
                    ErrorCode = "E01209",
                    MachineGroupID = 2,
                    MachineGroupName = "DCTH",
                    L = 2,
                    ChildPath = ",22,78,",
                    SearchPattern = " , Công tắc hành trình , E01209 , DCTH , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 23,
                    ErrorName = "Hệ thống điều khiển",
                    ErrorNameNested = "Hệ thống điều khiển",
                    ParentID = 0,
                    ErrorCode = "E05300",
                    MachineGroupID = 3,
                    MachineGroupName = "LASER",
                    L = 1,
                    ChildPath = ",23,",
                    SearchPattern = " , Hệ thống điều khiển , E05300 , LASER , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 51,
                    ErrorName = "Cảm biến hành trình",
                    ErrorNameNested = "      Cảm biến hành trình",
                    ParentID = 23,
                    ErrorCode = "E01301",
                    MachineGroupID = 3,
                    MachineGroupName = "LASER",
                    L = 2,
                    ChildPath = ",23,51,",
                    SearchPattern = " , Cảm biến hành trình , E01301 , LASER , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 52,
                    ErrorName = "Máy tính điều khiển",
                    ErrorNameNested = "      Máy tính điều khiển",
                    ParentID = 23,
                    ErrorCode = "E01302",
                    MachineGroupID = 3,
                    MachineGroupName = "LASER",
                    L = 2,
                    ChildPath = ",23,52,",
                    SearchPattern = " , Máy tính điều khiển , E01302 , LASER , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 53,
                    ErrorName = "Card điều khiển tín hiệu",
                    ErrorNameNested = "      Card điều khiển tín hiệu",
                    ParentID = 23,
                    ErrorCode = "E01303",
                    MachineGroupID = 3,
                    MachineGroupName = "LASER",
                    L = 2,
                    ChildPath = ",23,53,",
                    SearchPattern = " , Card điều khiển tín hiệu , E01303 , LASER , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 54,
                    ErrorName = "Encoder",
                    ErrorNameNested = "      Encoder",
                    ParentID = 23,
                    ErrorCode = "E01304",
                    MachineGroupID = 3,
                    MachineGroupName = "LASER",
                    L = 2,
                    ChildPath = ",23,54,",
                    SearchPattern = " , Encoder , E01304 , LASER , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 55,
                    ErrorName = "Động cơ Servo",
                    ErrorNameNested = "      Động cơ Servo",
                    ParentID = 23,
                    ErrorCode = "E01305",
                    MachineGroupID = 3,
                    MachineGroupName = "LASER",
                    L = 2,
                    ChildPath = ",23,55,",
                    SearchPattern = " , Động cơ Servo , E01305 , LASER , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 56,
                    ErrorName = "Màn hình điều khiển",
                    ErrorNameNested = "      Màn hình điều khiển",
                    ParentID = 23,
                    ErrorCode = "E01306",
                    MachineGroupID = 3,
                    MachineGroupName = "LASER",
                    L = 2,
                    ChildPath = ",23,56,",
                    SearchPattern = " , Màn hình điều khiển , E01306 , LASER , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 57,
                    ErrorName = "Nút nhấn",
                    ErrorNameNested = "      Nút nhấn",
                    ParentID = 23,
                    ErrorCode = "E01307",
                    MachineGroupID = 3,
                    MachineGroupName = "LASER",
                    L = 2,
                    ChildPath = ",23,57,",
                    SearchPattern = " , Nút nhấn , E01307 , LASER , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 58,
                    ErrorName = "Bộ điều khiển độ cao đầu cắt laser BCS100",
                    ErrorNameNested = "      Bộ điều khiển độ cao đầu cắt laser BCS100",
                    ParentID = 23,
                    ErrorCode = "E01308",
                    MachineGroupID = 3,
                    MachineGroupName = "LASER",
                    L = 2,
                    ChildPath = ",23,58,",
                    SearchPattern = " , Bộ điều khiển độ cao đầu cắt laser BCS100 , E01308 , LASER , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 59,
                    ErrorName = "Remote",
                    ErrorNameNested = "      Remote",
                    ParentID = 23,
                    ErrorCode = "E01309",
                    MachineGroupID = 3,
                    MachineGroupName = "LASER",
                    L = 2,
                    ChildPath = ",23,59,",
                    SearchPattern = " , Remote , E01309 , LASER , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 60,
                    ErrorName = "Chiller",
                    ErrorNameNested = "      Chiller",
                    ParentID = 23,
                    ErrorCode = "E01310",
                    MachineGroupID = 3,
                    MachineGroupName = "LASER",
                    L = 2,
                    ChildPath = ",23,60,",
                    SearchPattern = " , Chiller , E01310 , LASER , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 24,
                    ErrorName = "Hệ thống điều khiển",
                    ErrorNameNested = "Hệ thống điều khiển",
                    ParentID = 0,
                    ErrorCode = "E05400",
                    MachineGroupID = 4,
                    MachineGroupName = "PLASMA",
                    L = 1,
                    ChildPath = ",24,",
                    SearchPattern = " , Hệ thống điều khiển , E05400 , PLASMA , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 61,
                    ErrorName = "Cảm biến tiệm cận",
                    ErrorNameNested = "      Cảm biến tiệm cận",
                    ParentID = 24,
                    ErrorCode = "E01401",
                    MachineGroupID = 4,
                    MachineGroupName = "PLASMA",
                    L = 2,
                    ChildPath = ",24,61,",
                    SearchPattern = " , Cảm biến tiệm cận , E01401 , PLASMA , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 62,
                    ErrorName = "Bộ nâng hạ tự động THC",
                    ErrorNameNested = "      Bộ nâng hạ tự động THC",
                    ParentID = 24,
                    ErrorCode = "E01402",
                    MachineGroupID = 4,
                    MachineGroupName = "PLASMA",
                    L = 2,
                    ChildPath = ",24,62,",
                    SearchPattern = " , Bộ nâng hạ tự động THC , E01402 , PLASMA , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 63,
                    ErrorName = "Encoder",
                    ErrorNameNested = "      Encoder",
                    ParentID = 24,
                    ErrorCode = "E01403",
                    MachineGroupID = 4,
                    MachineGroupName = "PLASMA",
                    L = 2,
                    ChildPath = ",24,63,",
                    SearchPattern = " , Encoder , E01403 , PLASMA , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 64,
                    ErrorName = "Động cơ Servo",
                    ErrorNameNested = "      Động cơ Servo",
                    ParentID = 24,
                    ErrorCode = "E01404",
                    MachineGroupID = 4,
                    MachineGroupName = "PLASMA",
                    L = 2,
                    ChildPath = ",24,64,",
                    SearchPattern = " , Động cơ Servo , E01404 , PLASMA , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 65,
                    ErrorName = "Bộ điều khiển CCM3",
                    ErrorNameNested = "      Bộ điều khiển CCM3",
                    ParentID = 24,
                    ErrorCode = "E01405",
                    MachineGroupID = 4,
                    MachineGroupName = "PLASMA",
                    L = 2,
                    ChildPath = ",24,65,",
                    SearchPattern = " , Bộ điều khiển CCM3 , E01405 , PLASMA , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 66,
                    ErrorName = "Bộ điều khiển F7000s",
                    ErrorNameNested = "      Bộ điều khiển F7000s",
                    ParentID = 24,
                    ErrorCode = "E01406",
                    MachineGroupID = 4,
                    MachineGroupName = "PLASMA",
                    L = 2,
                    ChildPath = ",24,66,",
                    SearchPattern = " , Bộ điều khiển F7000s , E01406 , PLASMA , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 67,
                    ErrorName = "Bộ điều khiển AMG",
                    ErrorNameNested = "      Bộ điều khiển AMG",
                    ParentID = 24,
                    ErrorCode = "E01407",
                    MachineGroupID = 4,
                    MachineGroupName = "PLASMA",
                    L = 2,
                    ChildPath = ",24,67,",
                    SearchPattern = " , Bộ điều khiển AMG , E01407 , PLASMA , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 68,
                    ErrorName = "Nút nhấn",
                    ErrorNameNested = "      Nút nhấn",
                    ParentID = 24,
                    ErrorCode = "E01408",
                    MachineGroupID = 4,
                    MachineGroupName = "PLASMA",
                    L = 2,
                    ChildPath = ",24,68,",
                    SearchPattern = " , Nút nhấn , E01408 , PLASMA , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 69,
                    ErrorName = "Bộ làm mát rời",
                    ErrorNameNested = "      Bộ làm mát rời",
                    ParentID = 24,
                    ErrorCode = "E01409",
                    MachineGroupID = 4,
                    MachineGroupName = "PLASMA",
                    L = 2,
                    ChildPath = ",24,69,",
                    SearchPattern = " , Bộ làm mát rời , E01409 , PLASMA , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 25,
                    ErrorName = "Hệ thống điều khiển",
                    ErrorNameNested = "Hệ thống điều khiển",
                    ParentID = 0,
                    ErrorCode = "E05500",
                    MachineGroupID = 5,
                    MachineGroupName = "ROBOT",
                    L = 1,
                    ChildPath = ",25,",
                    SearchPattern = " , Hệ thống điều khiển , E05500 , ROBOT , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 89,
                    ErrorName = "board I/O",
                    ErrorNameNested = "      board I/O",
                    ParentID = 25,
                    ErrorCode = "E01501",
                    MachineGroupID = 5,
                    MachineGroupName = "ROBOT",
                    L = 2,
                    ChildPath = ",25,89,",
                    SearchPattern = " , board I/O , E01501 , ROBOT , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 90,
                    ErrorName = "motor các trục",
                    ErrorNameNested = "      motor các trục",
                    ParentID = 25,
                    ErrorCode = "E01502",
                    MachineGroupID = 5,
                    MachineGroupName = "ROBOT",
                    L = 2,
                    ChildPath = ",25,90,",
                    SearchPattern = " , motor các trục , E01502 , ROBOT , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 91,
                    ErrorName = "Tay dạy robot",
                    ErrorNameNested = "      Tay dạy robot",
                    ParentID = 25,
                    ErrorCode = "E01503",
                    MachineGroupID = 5,
                    MachineGroupName = "ROBOT",
                    L = 2,
                    ChildPath = ",25,91,",
                    SearchPattern = " , Tay dạy robot , E01503 , ROBOT , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 92,
                    ErrorName = "Nút nhấn",
                    ErrorNameNested = "      Nút nhấn",
                    ParentID = 25,
                    ErrorCode = "E01504",
                    MachineGroupID = 5,
                    MachineGroupName = "ROBOT",
                    L = 2,
                    ChildPath = ",25,92,",
                    SearchPattern = " , Nút nhấn , E01504 , ROBOT , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 93,
                    ErrorName = "Relay",
                    ErrorNameNested = "      Relay",
                    ParentID = 25,
                    ErrorCode = "E01505",
                    MachineGroupID = 5,
                    MachineGroupName = "ROBOT",
                    L = 2,
                    ChildPath = ",25,93,",
                    SearchPattern = " , Relay , E01505 , ROBOT , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 94,
                    ErrorName = "Máy tính",
                    ErrorNameNested = "      Máy tính",
                    ParentID = 25,
                    ErrorCode = "E01506",
                    MachineGroupID = 5,
                    MachineGroupName = "ROBOT",
                    L = 2,
                    ChildPath = ",25,94,",
                    SearchPattern = " , Máy tính , E01506 , ROBOT , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 26,
                    ErrorName = "Phần mềm",
                    ErrorNameNested = "Phần mềm",
                    ParentID = 0,
                    ErrorCode = "E06100",
                    MachineGroupID = 1,
                    MachineGroupName = "GCN",
                    L = 1,
                    ChildPath = ",26,",
                    SearchPattern = " , Phần mềm , E06100 , GCN , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 281,
                    ErrorName = "Chương trình PLC",
                    ErrorNameNested = "      Chương trình PLC",
                    ParentID = 26,
                    ErrorCode = "E06101",
                    MachineGroupID = 1,
                    MachineGroupName = "GCN",
                    L = 2,
                    ChildPath = ",26,281,",
                    SearchPattern = " , Chương trình PLC , E06101 , GCN , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 282,
                    ErrorName = "Phần mềm Moduml/Driver",
                    ErrorNameNested = "      Phần mềm Moduml/Driver",
                    ParentID = 26,
                    ErrorCode = "E06102",
                    MachineGroupID = 1,
                    MachineGroupName = "GCN",
                    L = 2,
                    ChildPath = ",26,282,",
                    SearchPattern = " , Phần mềm Moduml/Driver , E06102 , GCN , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 283,
                    ErrorName = "HMI",
                    ErrorNameNested = "      HMI",
                    ParentID = 26,
                    ErrorCode = "E06103",
                    MachineGroupID = 1,
                    MachineGroupName = "GCN",
                    L = 2,
                    ChildPath = ",26,283,",
                    SearchPattern = " , HMI , E06103 , GCN , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 27,
                    ErrorName = "Phần mềm",
                    ErrorNameNested = "Phần mềm",
                    ParentID = 0,
                    ErrorCode = "E06200",
                    MachineGroupID = 2,
                    MachineGroupName = "DCTH",
                    L = 1,
                    ChildPath = ",27,",
                    SearchPattern = " , Phần mềm , E06200 , DCTH , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 284,
                    ErrorName = "Chương trình PLC",
                    ErrorNameNested = "      Chương trình PLC",
                    ParentID = 27,
                    ErrorCode = "E06201",
                    MachineGroupID = 2,
                    MachineGroupName = "DCTH",
                    L = 2,
                    ChildPath = ",27,284,",
                    SearchPattern = " , Chương trình PLC , E06201 , DCTH , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 285,
                    ErrorName = "Phần mềm cảm biến",
                    ErrorNameNested = "      Phần mềm cảm biến",
                    ParentID = 27,
                    ErrorCode = "E06202",
                    MachineGroupID = 2,
                    MachineGroupName = "DCTH",
                    L = 2,
                    ChildPath = ",27,285,",
                    SearchPattern = " , Phần mềm cảm biến , E06202 , DCTH , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 286,
                    ErrorName = "HMI",
                    ErrorNameNested = "      HMI",
                    ParentID = 27,
                    ErrorCode = "E06203",
                    MachineGroupID = 2,
                    MachineGroupName = "DCTH",
                    L = 2,
                    ChildPath = ",27,286,",
                    SearchPattern = " , HMI , E06203 , DCTH , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 28,
                    ErrorName = "Phần mềm",
                    ErrorNameNested = "Phần mềm",
                    ParentID = 0,
                    ErrorCode = "E06300",
                    MachineGroupID = 3,
                    MachineGroupName = "LASER",
                    L = 1,
                    ChildPath = ",28,",
                    SearchPattern = " , Phần mềm , E06300 , LASER , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 287,
                    ErrorName = "Sigmanest",
                    ErrorNameNested = "      Sigmanest",
                    ParentID = 28,
                    ErrorCode = "E06301",
                    MachineGroupID = 3,
                    MachineGroupName = "LASER",
                    L = 2,
                    ChildPath = ",28,287,",
                    SearchPattern = " , Sigmanest , E06301 , LASER , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 288,
                    ErrorName = "Virus",
                    ErrorNameNested = "      Virus",
                    ParentID = 28,
                    ErrorCode = "E06302",
                    MachineGroupID = 3,
                    MachineGroupName = "LASER",
                    L = 2,
                    ChildPath = ",28,288,",
                    SearchPattern = " , Virus , E06302 , LASER , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 289,
                    ErrorName = "Key sigmanest (Quá hạn)",
                    ErrorNameNested = "      Key sigmanest (Quá hạn)",
                    ParentID = 28,
                    ErrorCode = "E06303",
                    MachineGroupID = 3,
                    MachineGroupName = "LASER",
                    L = 2,
                    ChildPath = ",28,289,",
                    SearchPattern = " , Key sigmanest (Quá hạn) , E06303 , LASER , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 290,
                    ErrorName = "Chương trình PLC",
                    ErrorNameNested = "      Chương trình PLC",
                    ParentID = 28,
                    ErrorCode = "E06304",
                    MachineGroupID = 3,
                    MachineGroupName = "LASER",
                    L = 2,
                    ChildPath = ",28,290,",
                    SearchPattern = " , Chương trình PLC , E06304 , LASER , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 291,
                    ErrorName = "HMI",
                    ErrorNameNested = "      HMI",
                    ParentID = 28,
                    ErrorCode = "E06305",
                    MachineGroupID = 3,
                    MachineGroupName = "LASER",
                    L = 2,
                    ChildPath = ",28,291,",
                    SearchPattern = " , HMI , E06305 , LASER , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 292,
                    ErrorName = "Windows",
                    ErrorNameNested = "      Windows",
                    ParentID = 28,
                    ErrorCode = "E06306",
                    MachineGroupID = 3,
                    MachineGroupName = "LASER",
                    L = 2,
                    ChildPath = ",28,292,",
                    SearchPattern = " , Windows , E06306 , LASER , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 293,
                    ErrorName = "Phần mềm Tube Pro",
                    ErrorNameNested = "      Phần mềm Tube Pro",
                    ParentID = 28,
                    ErrorCode = "E06307",
                    MachineGroupID = 3,
                    MachineGroupName = "LASER",
                    L = 2,
                    ChildPath = ",28,293,",
                    SearchPattern = " , Phần mềm Tube Pro , E06307 , LASER , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 294,
                    ErrorName = "Chương trình Beckhoff",
                    ErrorNameNested = "      Chương trình Beckhoff",
                    ParentID = 28,
                    ErrorCode = "E06308",
                    MachineGroupID = 3,
                    MachineGroupName = "LASER",
                    L = 2,
                    ChildPath = ",28,294,",
                    SearchPattern = " , Chương trình Beckhoff , E06308 , LASER , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 295,
                    ErrorName = "Chương trình Siemen",
                    ErrorNameNested = "      Chương trình Siemen",
                    ParentID = 28,
                    ErrorCode = "E06309",
                    MachineGroupID = 3,
                    MachineGroupName = "LASER",
                    L = 2,
                    ChildPath = ",28,295,",
                    SearchPattern = " , Chương trình Siemen , E06309 , LASER , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 296,
                    ErrorName = "Phần mềm Cypcut",
                    ErrorNameNested = "      Phần mềm Cypcut",
                    ParentID = 28,
                    ErrorCode = "E06310",
                    MachineGroupID = 3,
                    MachineGroupName = "LASER",
                    L = 2,
                    ChildPath = ",28,296,",
                    SearchPattern = " , Phần mềm Cypcut , E06310 , LASER , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 29,
                    ErrorName = "Phần mềm",
                    ErrorNameNested = "Phần mềm",
                    ParentID = 0,
                    ErrorCode = "E06400",
                    MachineGroupID = 4,
                    MachineGroupName = "PLASMA",
                    L = 1,
                    ChildPath = ",29,",
                    SearchPattern = " , Phần mềm , E06400 , PLASMA , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 297,
                    ErrorName = "Sigmanest",
                    ErrorNameNested = "      Sigmanest",
                    ParentID = 29,
                    ErrorCode = "E06401",
                    MachineGroupID = 4,
                    MachineGroupName = "PLASMA",
                    L = 2,
                    ChildPath = ",29,297,",
                    SearchPattern = " , Sigmanest , E06401 , PLASMA , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 298,
                    ErrorName = "Windows",
                    ErrorNameNested = "      Windows",
                    ParentID = 29,
                    ErrorCode = "E06402",
                    MachineGroupID = 4,
                    MachineGroupName = "PLASMA",
                    L = 2,
                    ChildPath = ",29,298,",
                    SearchPattern = " , Windows , E06402 , PLASMA , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 299,
                    ErrorName = "Chương trình PLC",
                    ErrorNameNested = "      Chương trình PLC",
                    ParentID = 29,
                    ErrorCode = "E06403",
                    MachineGroupID = 4,
                    MachineGroupName = "PLASMA",
                    L = 2,
                    ChildPath = ",29,299,",
                    SearchPattern = " , Chương trình PLC , E06403 , PLASMA , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 300,
                    ErrorName = "Any Pipe",
                    ErrorNameNested = "      Any Pipe",
                    ParentID = 29,
                    ErrorCode = "E06404",
                    MachineGroupID = 4,
                    MachineGroupName = "PLASMA",
                    L = 2,
                    ChildPath = ",29,300,",
                    SearchPattern = " , Any Pipe , E06404 , PLASMA , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 301,
                    ErrorName = "Mach3",
                    ErrorNameNested = "      Mach3",
                    ParentID = 29,
                    ErrorCode = "E06405",
                    MachineGroupID = 4,
                    MachineGroupName = "PLASMA",
                    L = 2,
                    ChildPath = ",29,301,",
                    SearchPattern = " , Mach3 , E06405 , PLASMA , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 3,
                    ErrorName = "Bộ điều khiển",
                    ErrorNameNested = "Bộ điều khiển",
                    ParentID = 0,
                    ErrorCode = "E01300",
                    MachineGroupID = 3,
                    MachineGroupName = "LASER",
                    L = 1,
                    ChildPath = ",3,",
                    SearchPattern = " , Bộ điều khiển , E01300 , LASER , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 30,
                    ErrorName = "Phần mềm",
                    ErrorNameNested = "Phần mềm",
                    ParentID = 0,
                    ErrorCode = "E06500",
                    MachineGroupID = 5,
                    MachineGroupName = "ROBOT",
                    L = 1,
                    ChildPath = ",30,",
                    SearchPattern = " , Phần mềm , E06500 , ROBOT , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 302,
                    ErrorName = "Robot studio",
                    ErrorNameNested = "      Robot studio",
                    ParentID = 30,
                    ErrorCode = "E06501",
                    MachineGroupID = 5,
                    MachineGroupName = "ROBOT",
                    L = 2,
                    ChildPath = ",30,302,",
                    SearchPattern = " , Robot studio , E06501 , ROBOT , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 303,
                    ErrorName = "RobotWare",
                    ErrorNameNested = "      RobotWare",
                    ParentID = 30,
                    ErrorCode = "E06502",
                    MachineGroupID = 5,
                    MachineGroupName = "ROBOT",
                    L = 2,
                    ChildPath = ",30,303,",
                    SearchPattern = " , RobotWare , E06502 , ROBOT , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 31,
                    ErrorName = "Vận hành máy",
                    ErrorNameNested = "Vận hành máy",
                    ParentID = 0,
                    ErrorCode = "E07100",
                    MachineGroupID = 1,
                    MachineGroupName = "GCN",
                    L = 1,
                    ChildPath = ",31,",
                    SearchPattern = " , Vận hành máy , E07100 , GCN , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 32,
                    ErrorName = "Vận hành máy",
                    ErrorNameNested = "Vận hành máy",
                    ParentID = 0,
                    ErrorCode = "E07200",
                    MachineGroupID = 2,
                    MachineGroupName = "DCTH",
                    L = 1,
                    ChildPath = ",32,",
                    SearchPattern = " , Vận hành máy , E07200 , DCTH , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 33,
                    ErrorName = "Vận hành máy",
                    ErrorNameNested = "Vận hành máy",
                    ParentID = 0,
                    ErrorCode = "E07300",
                    MachineGroupID = 3,
                    MachineGroupName = "LASER",
                    L = 1,
                    ChildPath = ",33,",
                    SearchPattern = " , Vận hành máy , E07300 , LASER , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 34,
                    ErrorName = "Vận hành máy",
                    ErrorNameNested = "Vận hành máy",
                    ParentID = 0,
                    ErrorCode = "E07400",
                    MachineGroupID = 4,
                    MachineGroupName = "PLASMA",
                    L = 1,
                    ChildPath = ",34,",
                    SearchPattern = " , Vận hành máy , E07400 , PLASMA , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 35,
                    ErrorName = "Vận hành máy",
                    ErrorNameNested = "Vận hành máy",
                    ParentID = 0,
                    ErrorCode = "E07500",
                    MachineGroupID = 5,
                    MachineGroupName = "ROBOT",
                    L = 1,
                    ChildPath = ",35,",
                    SearchPattern = " , Vận hành máy , E07500 , ROBOT , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 36,
                    ErrorName = "Phụ kiện",
                    ErrorNameNested = "Phụ kiện",
                    ParentID = 0,
                    ErrorCode = "E08100",
                    MachineGroupID = 1,
                    MachineGroupName = "GCN",
                    L = 1,
                    ChildPath = ",36,",
                    SearchPattern = " , Phụ kiện , E08100 , GCN , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 304,
                    ErrorName = "Chíp dao",
                    ErrorNameNested = "      Chíp dao",
                    ParentID = 36,
                    ErrorCode = "E08101",
                    MachineGroupID = 1,
                    MachineGroupName = "GCN",
                    L = 2,
                    ChildPath = ",36,304,",
                    SearchPattern = " , Chíp dao , E08101 , GCN , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 305,
                    ErrorName = "Đầu BT",
                    ErrorNameNested = "      Đầu BT",
                    ParentID = 36,
                    ErrorCode = "E08102",
                    MachineGroupID = 1,
                    MachineGroupName = "GCN",
                    L = 2,
                    ChildPath = ",36,305,",
                    SearchPattern = " , Đầu BT , E08102 , GCN , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 306,
                    ErrorName = "Cán dao",
                    ErrorNameNested = "      Cán dao",
                    ParentID = 36,
                    ErrorCode = "E08103",
                    MachineGroupID = 1,
                    MachineGroupName = "GCN",
                    L = 2,
                    ChildPath = ",36,306,",
                    SearchPattern = " , Cán dao , E08103 , GCN , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 307,
                    ErrorName = "Lưỡi Cưa",
                    ErrorNameNested = "      Lưỡi Cưa",
                    ParentID = 36,
                    ErrorCode = "E08104",
                    MachineGroupID = 1,
                    MachineGroupName = "GCN",
                    L = 2,
                    ChildPath = ",36,307,",
                    SearchPattern = " , Lưỡi Cưa , E08104 , GCN , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 37,
                    ErrorName = "Phụ kiện",
                    ErrorNameNested = "Phụ kiện",
                    ParentID = 0,
                    ErrorCode = "E08200",
                    MachineGroupID = 2,
                    MachineGroupName = "DCTH",
                    L = 1,
                    ChildPath = ",37,",
                    SearchPattern = " , Phụ kiện , E08200 , DCTH , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 308,
                    ErrorName = "Nối bép hàn",
                    ErrorNameNested = "      Nối bép hàn",
                    ParentID = 37,
                    ErrorCode = "E08201",
                    MachineGroupID = 2,
                    MachineGroupName = "DCTH",
                    L = 2,
                    ChildPath = ",37,308,",
                    SearchPattern = " , Nối bép hàn , E08201 , DCTH , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 309,
                    ErrorName = "Dây ruột gà",
                    ErrorNameNested = "      Dây ruột gà",
                    ParentID = 37,
                    ErrorCode = "E08202",
                    MachineGroupID = 2,
                    MachineGroupName = "DCTH",
                    L = 2,
                    ChildPath = ",37,309,",
                    SearchPattern = " , Dây ruột gà , E08202 , DCTH , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 310,
                    ErrorName = "Tắc bép hàn",
                    ErrorNameNested = "      Tắc bép hàn",
                    ParentID = 37,
                    ErrorCode = "E08203",
                    MachineGroupID = 2,
                    MachineGroupName = "DCTH",
                    L = 2,
                    ChildPath = ",37,310,",
                    SearchPattern = " , Tắc bép hàn , E08203 , DCTH , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 38,
                    ErrorName = "Phụ kiện",
                    ErrorNameNested = "Phụ kiện",
                    ParentID = 0,
                    ErrorCode = "E08300",
                    MachineGroupID = 3,
                    MachineGroupName = "LASER",
                    L = 1,
                    ChildPath = ",38,",
                    SearchPattern = " , Phụ kiện , E08300 , LASER , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 311,
                    ErrorName = "Bép cắt",
                    ErrorNameNested = "      Bép cắt",
                    ParentID = 38,
                    ErrorCode = "E08301",
                    MachineGroupID = 3,
                    MachineGroupName = "LASER",
                    L = 2,
                    ChildPath = ",38,311,",
                    SearchPattern = " , Bép cắt , E08301 , LASER , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 312,
                    ErrorName = "Súng cắt",
                    ErrorNameNested = "      Súng cắt",
                    ParentID = 38,
                    ErrorCode = "E08302",
                    MachineGroupID = 3,
                    MachineGroupName = "LASER",
                    L = 2,
                    ChildPath = ",38,312,",
                    SearchPattern = " , Súng cắt , E08302 , LASER , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 313,
                    ErrorName = "Dây súng",
                    ErrorNameNested = "      Dây súng",
                    ParentID = 38,
                    ErrorCode = "E08303",
                    MachineGroupID = 3,
                    MachineGroupName = "LASER",
                    L = 2,
                    ChildPath = ",38,313,",
                    SearchPattern = " , Dây súng , E08303 , LASER , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 314,
                    ErrorName = "Lăng kính (laser)",
                    ErrorNameNested = "      Lăng kính (laser)",
                    ParentID = 38,
                    ErrorCode = "E08304",
                    MachineGroupID = 3,
                    MachineGroupName = "LASER",
                    L = 2,
                    ChildPath = ",38,314,",
                    SearchPattern = " , Lăng kính (laser) , E08304 , LASER , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 315,
                    ErrorName = "Đầu cắt (laser)",
                    ErrorNameNested = "      Đầu cắt (laser)",
                    ParentID = 38,
                    ErrorCode = "E08305",
                    MachineGroupID = 3,
                    MachineGroupName = "LASER",
                    L = 2,
                    ChildPath = ",38,315,",
                    SearchPattern = " , Đầu cắt (laser) , E08305 , LASER , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 316,
                    ErrorName = "Cục sứ gá bép",
                    ErrorNameNested = "      Cục sứ gá bép",
                    ParentID = 38,
                    ErrorCode = "E08306",
                    MachineGroupID = 3,
                    MachineGroupName = "LASER",
                    L = 2,
                    ChildPath = ",38,316,",
                    SearchPattern = " , Cục sứ gá bép , E08306 , LASER , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 317,
                    ErrorName = "Nước làm mát",
                    ErrorNameNested = "      Nước làm mát",
                    ParentID = 38,
                    ErrorCode = "E08307",
                    MachineGroupID = 3,
                    MachineGroupName = "LASER",
                    L = 2,
                    ChildPath = ",38,317,",
                    SearchPattern = " , Nước làm mát , E08307 , LASER , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 39,
                    ErrorName = "Phụ kiện",
                    ErrorNameNested = "Phụ kiện",
                    ParentID = 0,
                    ErrorCode = "E08400",
                    MachineGroupID = 4,
                    MachineGroupName = "PLASMA",
                    L = 1,
                    ChildPath = ",39,",
                    SearchPattern = " , Phụ kiện , E08400 , PLASMA , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 318,
                    ErrorName = "Điện cực",
                    ErrorNameNested = "      Điện cực",
                    ParentID = 39,
                    ErrorCode = "E08401",
                    MachineGroupID = 4,
                    MachineGroupName = "PLASMA",
                    L = 2,
                    ChildPath = ",39,318,",
                    SearchPattern = " , Điện cực , E08401 , PLASMA , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 319,
                    ErrorName = "bép cắt",
                    ErrorNameNested = "      bép cắt",
                    ParentID = 39,
                    ErrorCode = "E08402",
                    MachineGroupID = 4,
                    MachineGroupName = "PLASMA",
                    L = 2,
                    ChildPath = ",39,319,",
                    SearchPattern = " , bép cắt , E08402 , PLASMA , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 320,
                    ErrorName = "vòng tạo lốc",
                    ErrorNameNested = "      vòng tạo lốc",
                    ParentID = 39,
                    ErrorCode = "E08403",
                    MachineGroupID = 4,
                    MachineGroupName = "PLASMA",
                    L = 2,
                    ChildPath = ",39,320,",
                    SearchPattern = " , vòng tạo lốc , E08403 , PLASMA , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 321,
                    ErrorName = "Ty nước",
                    ErrorNameNested = "      Ty nước",
                    ParentID = 39,
                    ErrorCode = "E08404",
                    MachineGroupID = 4,
                    MachineGroupName = "PLASMA",
                    L = 2,
                    ChildPath = ",39,321,",
                    SearchPattern = " , Ty nước , E08404 , PLASMA , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 322,
                    ErrorName = "Dây súng",
                    ErrorNameNested = "      Dây súng",
                    ParentID = 39,
                    ErrorCode = "E08405",
                    MachineGroupID = 4,
                    MachineGroupName = "PLASMA",
                    L = 2,
                    ChildPath = ",39,322,",
                    SearchPattern = " , Dây súng , E08405 , PLASMA , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 323,
                    ErrorName = "nước làm mát",
                    ErrorNameNested = "      nước làm mát",
                    ParentID = 39,
                    ErrorCode = "E08406",
                    MachineGroupID = 4,
                    MachineGroupName = "PLASMA",
                    L = 2,
                    ChildPath = ",39,323,",
                    SearchPattern = " , nước làm mát , E08406 , PLASMA , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 324,
                    ErrorName = "Súng cắt plasma",
                    ErrorNameNested = "      Súng cắt plasma",
                    ParentID = 39,
                    ErrorCode = "E08407",
                    MachineGroupID = 4,
                    MachineGroupName = "PLASMA",
                    L = 2,
                    ChildPath = ",39,324,",
                    SearchPattern = " , Súng cắt plasma , E08407 , PLASMA , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 4,
                    ErrorName = "Bộ điều khiển",
                    ErrorNameNested = "Bộ điều khiển",
                    ParentID = 0,
                    ErrorCode = "E01400",
                    MachineGroupID = 4,
                    MachineGroupName = "PLASMA",
                    L = 1,
                    ChildPath = ",4,",
                    SearchPattern = " , Bộ điều khiển , E01400 , PLASMA , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 40,
                    ErrorName = "Phụ kiện",
                    ErrorNameNested = "Phụ kiện",
                    ParentID = 0,
                    ErrorCode = "E08500",
                    MachineGroupID = 5,
                    MachineGroupName = "ROBOT",
                    L = 1,
                    ChildPath = ",40,",
                    SearchPattern = " , Phụ kiện , E08500 , ROBOT , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 325,
                    ErrorName = "ĐIện cực",
                    ErrorNameNested = "      ĐIện cực",
                    ParentID = 40,
                    ErrorCode = "E08501",
                    MachineGroupID = 5,
                    MachineGroupName = "ROBOT",
                    L = 2,
                    ChildPath = ",40,325,",
                    SearchPattern = " , ĐIện cực , E08501 , ROBOT , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 326,
                    ErrorName = "chụp khí",
                    ErrorNameNested = "      chụp khí",
                    ParentID = 40,
                    ErrorCode = "E08502",
                    MachineGroupID = 5,
                    MachineGroupName = "ROBOT",
                    L = 2,
                    ChildPath = ",40,326,",
                    SearchPattern = " , chụp khí , E08502 , ROBOT , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 327,
                    ErrorName = "chia khí",
                    ErrorNameNested = "      chia khí",
                    ParentID = 40,
                    ErrorCode = "E08503",
                    MachineGroupID = 5,
                    MachineGroupName = "ROBOT",
                    L = 2,
                    ChildPath = ",40,327,",
                    SearchPattern = " , chia khí , E08503 , ROBOT , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 328,
                    ErrorName = "ruột gà dẫn hướng",
                    ErrorNameNested = "      ruột gà dẫn hướng",
                    ParentID = 40,
                    ErrorCode = "E08504",
                    MachineGroupID = 5,
                    MachineGroupName = "ROBOT",
                    L = 2,
                    ChildPath = ",40,328,",
                    SearchPattern = " , ruột gà dẫn hướng , E08504 , ROBOT , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 329,
                    ErrorName = "bánh xe tải dây",
                    ErrorNameNested = "      bánh xe tải dây",
                    ParentID = 40,
                    ErrorCode = "E08505",
                    MachineGroupID = 5,
                    MachineGroupName = "ROBOT",
                    L = 2,
                    ChildPath = ",40,329,",
                    SearchPattern = " , bánh xe tải dây , E08505 , ROBOT , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 330,
                    ErrorName = "nước làm mát",
                    ErrorNameNested = "      nước làm mát",
                    ParentID = 40,
                    ErrorCode = "E08506",
                    MachineGroupID = 5,
                    MachineGroupName = "ROBOT",
                    L = 2,
                    ChildPath = ",40,330,",
                    SearchPattern = " , nước làm mát , E08506 , ROBOT , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 41,
                    ErrorName = "Nguồn",
                    ErrorNameNested = "Nguồn",
                    ParentID = 0,
                    ErrorCode = "E09100",
                    MachineGroupID = 1,
                    MachineGroupName = "GCN",
                    L = 1,
                    ChildPath = ",41,",
                    SearchPattern = " , Nguồn , E09100 , GCN , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 42,
                    ErrorName = "Nguồn",
                    ErrorNameNested = "Nguồn",
                    ParentID = 0,
                    ErrorCode = "E09200",
                    MachineGroupID = 2,
                    MachineGroupName = "DCTH",
                    L = 1,
                    ChildPath = ",42,",
                    SearchPattern = " , Nguồn , E09200 , DCTH , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 331,
                    ErrorName = "IGBT/ Thyristor",
                    ErrorNameNested = "      IGBT/ Thyristor",
                    ParentID = 42,
                    ErrorCode = "E09201",
                    MachineGroupID = 2,
                    MachineGroupName = "DCTH",
                    L = 2,
                    ChildPath = ",42,331,",
                    SearchPattern = " , IGBT/ Thyristor , E09201 , DCTH , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 332,
                    ErrorName = "Diode",
                    ErrorNameNested = "      Diode",
                    ParentID = 42,
                    ErrorCode = "E09202",
                    MachineGroupID = 2,
                    MachineGroupName = "DCTH",
                    L = 2,
                    ChildPath = ",42,332,",
                    SearchPattern = " , Diode , E09202 , DCTH , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 333,
                    ErrorName = "Cầu 3 pha",
                    ErrorNameNested = "      Cầu 3 pha",
                    ParentID = 42,
                    ErrorCode = "E09203",
                    MachineGroupID = 2,
                    MachineGroupName = "DCTH",
                    L = 2,
                    ChildPath = ",42,333,",
                    SearchPattern = " , Cầu 3 pha , E09203 , DCTH , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 334,
                    ErrorName = "Bo điều khiển",
                    ErrorNameNested = "      Bo điều khiển",
                    ParentID = 42,
                    ErrorCode = "E09204",
                    MachineGroupID = 2,
                    MachineGroupName = "DCTH",
                    L = 2,
                    ChildPath = ",42,334,",
                    SearchPattern = " , Bo điều khiển , E09204 , DCTH , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 335,
                    ErrorName = "Bo công suất",
                    ErrorNameNested = "      Bo công suất",
                    ParentID = 42,
                    ErrorCode = "E09205",
                    MachineGroupID = 2,
                    MachineGroupName = "DCTH",
                    L = 2,
                    ChildPath = ",42,335,",
                    SearchPattern = " , Bo công suất , E09205 , DCTH , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 336,
                    ErrorName = "Bo đầu cấp",
                    ErrorNameNested = "      Bo đầu cấp",
                    ParentID = 42,
                    ErrorCode = "E09206",
                    MachineGroupID = 2,
                    MachineGroupName = "DCTH",
                    L = 2,
                    ChildPath = ",42,336,",
                    SearchPattern = " , Bo đầu cấp , E09206 , DCTH , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 337,
                    ErrorName = "Motor tải dây",
                    ErrorNameNested = "      Motor tải dây",
                    ParentID = 42,
                    ErrorCode = "E09207",
                    MachineGroupID = 2,
                    MachineGroupName = "DCTH",
                    L = 2,
                    ChildPath = ",42,337,",
                    SearchPattern = " , Motor tải dây , E09207 , DCTH , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 338,
                    ErrorName = "Cọc hàn",
                    ErrorNameNested = "      Cọc hàn",
                    ParentID = 42,
                    ErrorCode = "E09208",
                    MachineGroupID = 2,
                    MachineGroupName = "DCTH",
                    L = 2,
                    ChildPath = ",42,338,",
                    SearchPattern = " , Cọc hàn , E09208 , DCTH , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 339,
                    ErrorName = "Cáp hàn",
                    ErrorNameNested = "      Cáp hàn",
                    ParentID = 42,
                    ErrorCode = "E09209",
                    MachineGroupID = 2,
                    MachineGroupName = "DCTH",
                    L = 2,
                    ChildPath = ",42,339,",
                    SearchPattern = " , Cáp hàn , E09209 , DCTH , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 43,
                    ErrorName = "Nguồn",
                    ErrorNameNested = "Nguồn",
                    ParentID = 0,
                    ErrorCode = "E09300",
                    MachineGroupID = 3,
                    MachineGroupName = "LASER",
                    L = 1,
                    ChildPath = ",43,",
                    SearchPattern = " , Nguồn , E09300 , LASER , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 340,
                    ErrorName = "Khóa code hết hạn",
                    ErrorNameNested = "      Khóa code hết hạn",
                    ParentID = 43,
                    ErrorCode = "E09301",
                    MachineGroupID = 3,
                    MachineGroupName = "LASER",
                    L = 2,
                    ChildPath = ",43,340,",
                    SearchPattern = " , Khóa code hết hạn , E09301 , LASER , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 341,
                    ErrorName = "Cháy sợi quang",
                    ErrorNameNested = "      Cháy sợi quang",
                    ParentID = 43,
                    ErrorCode = "E09302",
                    MachineGroupID = 3,
                    MachineGroupName = "LASER",
                    L = 2,
                    ChildPath = ",43,341,",
                    SearchPattern = " , Cháy sợi quang , E09302 , LASER , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 342,
                    ErrorName = "Dây fiber",
                    ErrorNameNested = "      Dây fiber",
                    ParentID = 43,
                    ErrorCode = "E09303",
                    MachineGroupID = 3,
                    MachineGroupName = "LASER",
                    L = 2,
                    ChildPath = ",43,342,",
                    SearchPattern = " , Dây fiber , E09303 , LASER , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 343,
                    ErrorName = "Hỏng bo trong nguồn",
                    ErrorNameNested = "      Hỏng bo trong nguồn",
                    ParentID = 43,
                    ErrorCode = "E09304",
                    MachineGroupID = 3,
                    MachineGroupName = "LASER",
                    L = 2,
                    ChildPath = ",43,343,",
                    SearchPattern = " , Hỏng bo trong nguồn , E09304 , LASER , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 344,
                    ErrorName = "Giảm công suất",
                    ErrorNameNested = "      Giảm công suất",
                    ParentID = 43,
                    ErrorCode = "E09305",
                    MachineGroupID = 3,
                    MachineGroupName = "LASER",
                    L = 2,
                    ChildPath = ",43,344,",
                    SearchPattern = " , Giảm công suất , E09305 , LASER , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 345,
                    ErrorName = "Lỗi phần cứng khác",
                    ErrorNameNested = "      Lỗi phần cứng khác",
                    ParentID = 43,
                    ErrorCode = "E09306",
                    MachineGroupID = 3,
                    MachineGroupName = "LASER",
                    L = 2,
                    ChildPath = ",43,345,",
                    SearchPattern = " , Lỗi phần cứng khác , E09306 , LASER , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 44,
                    ErrorName = "Nguồn",
                    ErrorNameNested = "Nguồn",
                    ParentID = 0,
                    ErrorCode = "E09400",
                    MachineGroupID = 4,
                    MachineGroupName = "PLASMA",
                    L = 1,
                    ChildPath = ",44,",
                    SearchPattern = " , Nguồn , E09400 , PLASMA , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 346,
                    ErrorName = "IGBT",
                    ErrorNameNested = "      IGBT",
                    ParentID = 44,
                    ErrorCode = "E09401",
                    MachineGroupID = 4,
                    MachineGroupName = "PLASMA",
                    L = 2,
                    ChildPath = ",44,346,",
                    SearchPattern = " , IGBT , E09401 , PLASMA , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 347,
                    ErrorName = "Diode",
                    ErrorNameNested = "      Diode",
                    ParentID = 44,
                    ErrorCode = "E09402",
                    MachineGroupID = 4,
                    MachineGroupName = "PLASMA",
                    L = 2,
                    ChildPath = ",44,347,",
                    SearchPattern = " , Diode , E09402 , PLASMA , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 348,
                    ErrorName = "Cầu 3 pha",
                    ErrorNameNested = "      Cầu 3 pha",
                    ParentID = 44,
                    ErrorCode = "E09403",
                    MachineGroupID = 4,
                    MachineGroupName = "PLASMA",
                    L = 2,
                    ChildPath = ",44,348,",
                    SearchPattern = " , Cầu 3 pha , E09403 , PLASMA , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 349,
                    ErrorName = "Bo điều khiển IO",
                    ErrorNameNested = "      Bo điều khiển IO",
                    ParentID = 44,
                    ErrorCode = "E09404",
                    MachineGroupID = 4,
                    MachineGroupName = "PLASMA",
                    L = 2,
                    ChildPath = ",44,349,",
                    SearchPattern = " , Bo điều khiển IO , E09404 , PLASMA , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 350,
                    ErrorName = "Bo cao áp",
                    ErrorNameNested = "      Bo cao áp",
                    ParentID = 44,
                    ErrorCode = "E09405",
                    MachineGroupID = 4,
                    MachineGroupName = "PLASMA",
                    L = 2,
                    ChildPath = ",44,350,",
                    SearchPattern = " , Bo cao áp , E09405 , PLASMA , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 351,
                    ErrorName = "Bo điều khiển công suất",
                    ErrorNameNested = "      Bo điều khiển công suất",
                    ParentID = 44,
                    ErrorCode = "E09406",
                    MachineGroupID = 4,
                    MachineGroupName = "PLASMA",
                    L = 2,
                    ChildPath = ",44,351,",
                    SearchPattern = " , Bo điều khiển công suất , E09406 , PLASMA , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 352,
                    ErrorName = "Động cơ bơm nước làm mát",
                    ErrorNameNested = "      Động cơ bơm nước làm mát",
                    ParentID = 44,
                    ErrorCode = "E09407",
                    MachineGroupID = 4,
                    MachineGroupName = "PLASMA",
                    L = 2,
                    ChildPath = ",44,352,",
                    SearchPattern = " , Động cơ bơm nước làm mát , E09407 , PLASMA , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 353,
                    ErrorName = "Van selenoid",
                    ErrorNameNested = "      Van selenoid",
                    ParentID = 44,
                    ErrorCode = "E09408",
                    MachineGroupID = 4,
                    MachineGroupName = "PLASMA",
                    L = 2,
                    ChildPath = ",44,353,",
                    SearchPattern = " , Van selenoid , E09408 , PLASMA , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 354,
                    ErrorName = "Tụ điện",
                    ErrorNameNested = "      Tụ điện",
                    ParentID = 44,
                    ErrorCode = "E09409",
                    MachineGroupID = 4,
                    MachineGroupName = "PLASMA",
                    L = 2,
                    ChildPath = ",44,354,",
                    SearchPattern = " , Tụ điện , E09409 , PLASMA , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 45,
                    ErrorName = "Nguồn",
                    ErrorNameNested = "Nguồn",
                    ParentID = 0,
                    ErrorCode = "E09500",
                    MachineGroupID = 5,
                    MachineGroupName = "ROBOT",
                    L = 1,
                    ChildPath = ",45,",
                    SearchPattern = " , Nguồn , E09500 , ROBOT , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 355,
                    ErrorName = "IGBT",
                    ErrorNameNested = "      IGBT",
                    ParentID = 45,
                    ErrorCode = "E09501",
                    MachineGroupID = 5,
                    MachineGroupName = "ROBOT",
                    L = 2,
                    ChildPath = ",45,355,",
                    SearchPattern = " , IGBT , E09501 , ROBOT , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 356,
                    ErrorName = "Diode",
                    ErrorNameNested = "      Diode",
                    ParentID = 45,
                    ErrorCode = "E09502",
                    MachineGroupID = 5,
                    MachineGroupName = "ROBOT",
                    L = 2,
                    ChildPath = ",45,356,",
                    SearchPattern = " , Diode , E09502 , ROBOT , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 357,
                    ErrorName = "Cầu 3 pha",
                    ErrorNameNested = "      Cầu 3 pha",
                    ParentID = 45,
                    ErrorCode = "E09503",
                    MachineGroupID = 5,
                    MachineGroupName = "ROBOT",
                    L = 2,
                    ChildPath = ",45,357,",
                    SearchPattern = " , Cầu 3 pha , E09503 , ROBOT , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 358,
                    ErrorName = "Bo điều khiển",
                    ErrorNameNested = "      Bo điều khiển",
                    ParentID = 45,
                    ErrorCode = "E09504",
                    MachineGroupID = 5,
                    MachineGroupName = "ROBOT",
                    L = 2,
                    ChildPath = ",45,358,",
                    SearchPattern = " , Bo điều khiển , E09504 , ROBOT , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 359,
                    ErrorName = "Bo cao áp",
                    ErrorNameNested = "      Bo cao áp",
                    ParentID = 45,
                    ErrorCode = "E09505",
                    MachineGroupID = 5,
                    MachineGroupName = "ROBOT",
                    L = 2,
                    ChildPath = ",45,359,",
                    SearchPattern = " , Bo cao áp , E09505 , ROBOT , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 360,
                    ErrorName = "Bo điều khiển khí",
                    ErrorNameNested = "      Bo điều khiển khí",
                    ParentID = 45,
                    ErrorCode = "E09506",
                    MachineGroupID = 5,
                    MachineGroupName = "ROBOT",
                    L = 2,
                    ChildPath = ",45,360,",
                    SearchPattern = " , Bo điều khiển khí , E09506 , ROBOT , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 361,
                    ErrorName = "Động cơ bơm nước làm mát",
                    ErrorNameNested = "      Động cơ bơm nước làm mát",
                    ParentID = 45,
                    ErrorCode = "E09507",
                    MachineGroupID = 5,
                    MachineGroupName = "ROBOT",
                    L = 2,
                    ChildPath = ",45,361,",
                    SearchPattern = " , Động cơ bơm nước làm mát , E09507 , ROBOT , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 362,
                    ErrorName = "Van selenoid",
                    ErrorNameNested = "      Van selenoid",
                    ParentID = 45,
                    ErrorCode = "E09508",
                    MachineGroupID = 5,
                    MachineGroupName = "ROBOT",
                    L = 2,
                    ChildPath = ",45,362,",
                    SearchPattern = " , Van selenoid , E09508 , ROBOT , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 363,
                    ErrorName = "Bo đầu cấp",
                    ErrorNameNested = "      Bo đầu cấp",
                    ParentID = 45,
                    ErrorCode = "E09509",
                    MachineGroupID = 5,
                    MachineGroupName = "ROBOT",
                    L = 2,
                    ChildPath = ",45,363,",
                    SearchPattern = " , Bo đầu cấp , E09509 , ROBOT , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 364,
                    ErrorName = "Motor tải dây",
                    ErrorNameNested = "      Motor tải dây",
                    ParentID = 45,
                    ErrorCode = "E09510",
                    MachineGroupID = 5,
                    MachineGroupName = "ROBOT",
                    L = 2,
                    ChildPath = ",45,364,",
                    SearchPattern = " , Motor tải dây , E09510 , ROBOT , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 46,
                    ErrorName = "Điều chỉnh thông số",
                    ErrorNameNested = "Điều chỉnh thông số",
                    ParentID = 0,
                    ErrorCode = "E10100",
                    MachineGroupID = 1,
                    MachineGroupName = "GCN",
                    L = 1,
                    ChildPath = ",46,",
                    SearchPattern = " , Điều chỉnh thông số , E10100 , GCN , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 108,
                    ErrorName = "Thông số Dao chấn",
                    ErrorNameNested = "      Thông số Dao chấn",
                    ParentID = 46,
                    ErrorCode = "E10101",
                    MachineGroupID = 1,
                    MachineGroupName = "GCN",
                    L = 2,
                    ChildPath = ",46,108,",
                    SearchPattern = " , Thông số Dao chấn , E10101 , GCN , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 109,
                    ErrorName = "Thông số Cối chấn",
                    ErrorNameNested = "      Thông số Cối chấn",
                    ParentID = 46,
                    ErrorCode = "E10102",
                    MachineGroupID = 1,
                    MachineGroupName = "GCN",
                    L = 2,
                    ChildPath = ",46,109,",
                    SearchPattern = " , Thông số Cối chấn , E10102 , GCN , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 110,
                    ErrorName = "Thông số tốc độ cắt",
                    ErrorNameNested = "      Thông số tốc độ cắt",
                    ParentID = 46,
                    ErrorCode = "E10103",
                    MachineGroupID = 1,
                    MachineGroupName = "GCN",
                    L = 2,
                    ChildPath = ",46,110,",
                    SearchPattern = " , Thông số tốc độ cắt , E10103 , GCN , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 47,
                    ErrorName = "Điều chỉnh thông số",
                    ErrorNameNested = "Điều chỉnh thông số",
                    ParentID = 0,
                    ErrorCode = "E10200",
                    MachineGroupID = 2,
                    MachineGroupName = "DCTH",
                    L = 1,
                    ChildPath = ",47,",
                    SearchPattern = " , Điều chỉnh thông số , E10200 , DCTH , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 105,
                    ErrorName = "Tốc độ hàn",
                    ErrorNameNested = "      Tốc độ hàn",
                    ParentID = 47,
                    ErrorCode = "E10201",
                    MachineGroupID = 2,
                    MachineGroupName = "DCTH",
                    L = 2,
                    ChildPath = ",47,105,",
                    SearchPattern = " , Tốc độ hàn , E10201 , DCTH , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 106,
                    ErrorName = "Dòng hàn",
                    ErrorNameNested = "      Dòng hàn",
                    ParentID = 47,
                    ErrorCode = "E10202",
                    MachineGroupID = 2,
                    MachineGroupName = "DCTH",
                    L = 2,
                    ChildPath = ",47,106,",
                    SearchPattern = " , Dòng hàn , E10202 , DCTH , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 107,
                    ErrorName = "Điện áp hàn",
                    ErrorNameNested = "      Điện áp hàn",
                    ParentID = 47,
                    ErrorCode = "E10203",
                    MachineGroupID = 2,
                    MachineGroupName = "DCTH",
                    L = 2,
                    ChildPath = ",47,107,",
                    SearchPattern = " , Điện áp hàn , E10203 , DCTH , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 48,
                    ErrorName = "Điều chỉnh thông số",
                    ErrorNameNested = "Điều chỉnh thông số",
                    ParentID = 0,
                    ErrorCode = "E10300",
                    MachineGroupID = 3,
                    MachineGroupName = "LASER",
                    L = 1,
                    ChildPath = ",48,",
                    SearchPattern = " , Điều chỉnh thông số , E10300 , LASER , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 100,
                    ErrorName = "Lưu nhầm thông số khác",
                    ErrorNameNested = "      Lưu nhầm thông số khác",
                    ParentID = 48,
                    ErrorCode = "E10306",
                    MachineGroupID = 3,
                    MachineGroupName = "LASER",
                    L = 2,
                    ChildPath = ",48,100,",
                    SearchPattern = " , Lưu nhầm thông số khác , E10306 , LASER , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 95,
                    ErrorName = "Bép cắt",
                    ErrorNameNested = "      Bép cắt",
                    ParentID = 48,
                    ErrorCode = "E10301",
                    MachineGroupID = 3,
                    MachineGroupName = "LASER",
                    L = 2,
                    ChildPath = ",48,95,",
                    SearchPattern = " , Bép cắt , E10301 , LASER , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 96,
                    ErrorName = "Tốc độ cắt",
                    ErrorNameNested = "      Tốc độ cắt",
                    ParentID = 48,
                    ErrorCode = "E10302",
                    MachineGroupID = 3,
                    MachineGroupName = "LASER",
                    L = 2,
                    ChildPath = ",48,96,",
                    SearchPattern = " , Tốc độ cắt , E10302 , LASER , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 97,
                    ErrorName = "Áp khí",
                    ErrorNameNested = "      Áp khí",
                    ParentID = 48,
                    ErrorCode = "E10303",
                    MachineGroupID = 3,
                    MachineGroupName = "LASER",
                    L = 2,
                    ChildPath = ",48,97,",
                    SearchPattern = " , Áp khí , E10303 , LASER , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 98,
                    ErrorName = "Công suất nguồn",
                    ErrorNameNested = "      Công suất nguồn",
                    ParentID = 48,
                    ErrorCode = "E10304",
                    MachineGroupID = 3,
                    MachineGroupName = "LASER",
                    L = 2,
                    ChildPath = ",48,98,",
                    SearchPattern = " , Công suất nguồn , E10304 , LASER , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 99,
                    ErrorName = "Chưa dò thông số mẫu",
                    ErrorNameNested = "      Chưa dò thông số mẫu",
                    ParentID = 48,
                    ErrorCode = "E10305",
                    MachineGroupID = 3,
                    MachineGroupName = "LASER",
                    L = 2,
                    ChildPath = ",48,99,",
                    SearchPattern = " , Chưa dò thông số mẫu , E10305 , LASER , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 49,
                    ErrorName = "Điều chỉnh thông số",
                    ErrorNameNested = "Điều chỉnh thông số",
                    ParentID = 0,
                    ErrorCode = "E10400",
                    MachineGroupID = 4,
                    MachineGroupName = "PLASMA",
                    L = 1,
                    ChildPath = ",49,",
                    SearchPattern = " , Điều chỉnh thông số , E10400 , PLASMA , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 101,
                    ErrorName = "Thông số dòng cắt",
                    ErrorNameNested = "      Thông số dòng cắt",
                    ParentID = 49,
                    ErrorCode = "E10401",
                    MachineGroupID = 4,
                    MachineGroupName = "PLASMA",
                    L = 2,
                    ChildPath = ",49,101,",
                    SearchPattern = " , Thông số dòng cắt , E10401 , PLASMA , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 102,
                    ErrorName = "Thông số tốc độ cắt",
                    ErrorNameNested = "      Thông số tốc độ cắt",
                    ParentID = 49,
                    ErrorCode = "E10402",
                    MachineGroupID = 4,
                    MachineGroupName = "PLASMA",
                    L = 2,
                    ChildPath = ",49,102,",
                    SearchPattern = " , Thông số tốc độ cắt , E10402 , PLASMA , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 103,
                    ErrorName = "Độ cao cắt",
                    ErrorNameNested = "      Độ cao cắt",
                    ParentID = 49,
                    ErrorCode = "E10403",
                    MachineGroupID = 4,
                    MachineGroupName = "PLASMA",
                    L = 2,
                    ChildPath = ",49,103,",
                    SearchPattern = " , Độ cao cắt , E10403 , PLASMA , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 104,
                    ErrorName = "Độ cao đục lỗ",
                    ErrorNameNested = "      Độ cao đục lỗ",
                    ParentID = 49,
                    ErrorCode = "E10404",
                    MachineGroupID = 4,
                    MachineGroupName = "PLASMA",
                    L = 2,
                    ChildPath = ",49,104,",
                    SearchPattern = " , Độ cao đục lỗ , E10404 , PLASMA , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 5,
                    ErrorName = "Bộ điều khiển",
                    ErrorNameNested = "Bộ điều khiển",
                    ParentID = 0,
                    ErrorCode = "E01500",
                    MachineGroupID = 5,
                    MachineGroupName = "ROBOT",
                    L = 1,
                    ChildPath = ",5,",
                    SearchPattern = " , Bộ điều khiển , E01500 , ROBOT , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 50,
                    ErrorName = "Điều chỉnh thông số",
                    ErrorNameNested = "Điều chỉnh thông số",
                    ParentID = 0,
                    ErrorCode = "E10500",
                    MachineGroupID = 5,
                    MachineGroupName = "ROBOT",
                    L = 1,
                    ChildPath = ",50,",
                    SearchPattern = " , Điều chỉnh thông số , E10500 , ROBOT , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 111,
                    ErrorName = "Thông số dòng hàn",
                    ErrorNameNested = "      Thông số dòng hàn",
                    ParentID = 50,
                    ErrorCode = "E10501",
                    MachineGroupID = 5,
                    MachineGroupName = "ROBOT",
                    L = 2,
                    ChildPath = ",50,111,",
                    SearchPattern = " , Thông số dòng hàn , E10501 , ROBOT , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 112,
                    ErrorName = "thông số tốc độ hàn",
                    ErrorNameNested = "      thông số tốc độ hàn",
                    ParentID = 50,
                    ErrorCode = "E10502",
                    MachineGroupID = 5,
                    MachineGroupName = "ROBOT",
                    L = 2,
                    ChildPath = ",50,112,",
                    SearchPattern = " , thông số tốc độ hàn , E10502 , ROBOT , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 6,
                    ErrorName = "Cơ khí",
                    ErrorNameNested = "Cơ khí",
                    ParentID = 0,
                    ErrorCode = "E02100",
                    MachineGroupID = 1,
                    MachineGroupName = "GCN",
                    L = 1,
                    ChildPath = ",6,",
                    SearchPattern = " , Cơ khí , E02100 , GCN , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 138,
                    ErrorName = "Bánh răng",
                    ErrorNameNested = "      Bánh răng",
                    ParentID = 6,
                    ErrorCode = "E02101",
                    MachineGroupID = 1,
                    MachineGroupName = "GCN",
                    L = 2,
                    ChildPath = ",6,138,",
                    SearchPattern = " , Bánh răng , E02101 , GCN , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 139,
                    ErrorName = "Thanh dẫn hướng",
                    ErrorNameNested = "      Thanh dẫn hướng",
                    ParentID = 6,
                    ErrorCode = "E02102",
                    MachineGroupID = 1,
                    MachineGroupName = "GCN",
                    L = 2,
                    ChildPath = ",6,139,",
                    SearchPattern = " , Thanh dẫn hướng , E02102 , GCN , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 140,
                    ErrorName = "Đai ốc bi",
                    ErrorNameNested = "      Đai ốc bi",
                    ParentID = 6,
                    ErrorCode = "E02103",
                    MachineGroupID = 1,
                    MachineGroupName = "GCN",
                    L = 2,
                    ChildPath = ",6,140,",
                    SearchPattern = " , Đai ốc bi , E02103 , GCN , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 141,
                    ErrorName = "Hộp số motor",
                    ErrorNameNested = "      Hộp số motor",
                    ParentID = 6,
                    ErrorCode = "E02104",
                    MachineGroupID = 1,
                    MachineGroupName = "GCN",
                    L = 2,
                    ChildPath = ",6,141,",
                    SearchPattern = " , Hộp số motor , E02104 , GCN , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 142,
                    ErrorName = "Khung máy",
                    ErrorNameNested = "      Khung máy",
                    ParentID = 6,
                    ErrorCode = "E02105",
                    MachineGroupID = 1,
                    MachineGroupName = "GCN",
                    L = 2,
                    ChildPath = ",6,142,",
                    SearchPattern = " , Khung máy , E02105 , GCN , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 143,
                    ErrorName = "Bạc đạn",
                    ErrorNameNested = "      Bạc đạn",
                    ParentID = 6,
                    ErrorCode = "E02106",
                    MachineGroupID = 1,
                    MachineGroupName = "GCN",
                    L = 2,
                    ChildPath = ",6,143,",
                    SearchPattern = " , Bạc đạn , E02106 , GCN , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 144,
                    ErrorName = "Khe hở dao",
                    ErrorNameNested = "      Khe hở dao",
                    ParentID = 6,
                    ErrorCode = "E02107",
                    MachineGroupID = 1,
                    MachineGroupName = "GCN",
                    L = 2,
                    ChildPath = ",6,144,",
                    SearchPattern = " , Khe hở dao , E02107 , GCN , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 145,
                    ErrorName = "Con lăn",
                    ErrorNameNested = "      Con lăn",
                    ParentID = 6,
                    ErrorCode = "E02108",
                    MachineGroupID = 1,
                    MachineGroupName = "GCN",
                    L = 2,
                    ChildPath = ",6,145,",
                    SearchPattern = " , Con lăn , E02108 , GCN , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 146,
                    ErrorName = "Vítme bi",
                    ErrorNameNested = "      Vítme bi",
                    ParentID = 6,
                    ErrorCode = "E02109",
                    MachineGroupID = 1,
                    MachineGroupName = "GCN",
                    L = 2,
                    ChildPath = ",6,146,",
                    SearchPattern = " , Vítme bi , E02109 , GCN , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 7,
                    ErrorName = "Cơ khí",
                    ErrorNameNested = "Cơ khí",
                    ParentID = 0,
                    ErrorCode = "E02200",
                    MachineGroupID = 2,
                    MachineGroupName = "DCTH",
                    L = 1,
                    ChildPath = ",7,",
                    SearchPattern = " , Cơ khí , E02200 , DCTH , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 147,
                    ErrorName = "Tấm gang mài mòn buồng phun",
                    ErrorNameNested = "      Tấm gang mài mòn buồng phun",
                    ParentID = 7,
                    ErrorCode = "E02201",
                    MachineGroupID = 2,
                    MachineGroupName = "DCTH",
                    L = 2,
                    ChildPath = ",7,147,",
                    SearchPattern = " , Tấm gang mài mòn buồng phun , E02201 , DCTH , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 148,
                    ErrorName = "Con trượt",
                    ErrorNameNested = "      Con trượt",
                    ParentID = 7,
                    ErrorCode = "E02202",
                    MachineGroupID = 2,
                    MachineGroupName = "DCTH",
                    L = 2,
                    ChildPath = ",7,148,",
                    SearchPattern = " , Con trượt , E02202 , DCTH , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 149,
                    ErrorName = "Tấm gang mài mòn đầu phun",
                    ErrorNameNested = "      Tấm gang mài mòn đầu phun",
                    ParentID = 7,
                    ErrorCode = "E02203",
                    MachineGroupID = 2,
                    MachineGroupName = "DCTH",
                    L = 2,
                    ChildPath = ",7,149,",
                    SearchPattern = " , Tấm gang mài mòn đầu phun , E02203 , DCTH , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 150,
                    ErrorName = "Bạc đạn",
                    ErrorNameNested = "      Bạc đạn",
                    ParentID = 7,
                    ErrorCode = "E02204",
                    MachineGroupID = 2,
                    MachineGroupName = "DCTH",
                    L = 2,
                    ChildPath = ",7,150,",
                    SearchPattern = " , Bạc đạn , E02204 , DCTH , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 151,
                    ErrorName = "Gầu múc bi",
                    ErrorNameNested = "      Gầu múc bi",
                    ParentID = 7,
                    ErrorCode = "E02205",
                    MachineGroupID = 2,
                    MachineGroupName = "DCTH",
                    L = 2,
                    ChildPath = ",7,151,",
                    SearchPattern = " , Gầu múc bi , E02205 , DCTH , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 152,
                    ErrorName = "Tấm chắn cao su",
                    ErrorNameNested = "      Tấm chắn cao su",
                    ParentID = 7,
                    ErrorCode = "E02206",
                    MachineGroupID = 2,
                    MachineGroupName = "DCTH",
                    L = 2,
                    ChildPath = ",7,152,",
                    SearchPattern = " , Tấm chắn cao su , E02206 , DCTH , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 153,
                    ErrorName = "Xích giàn lăn",
                    ErrorNameNested = "      Xích giàn lăn",
                    ParentID = 7,
                    ErrorCode = "E02207",
                    MachineGroupID = 2,
                    MachineGroupName = "DCTH",
                    L = 2,
                    ChildPath = ",7,153,",
                    SearchPattern = " , Xích giàn lăn , E02207 , DCTH , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 154,
                    ErrorName = "Ray",
                    ErrorNameNested = "      Ray",
                    ParentID = 7,
                    ErrorCode = "E02208",
                    MachineGroupID = 2,
                    MachineGroupName = "DCTH",
                    L = 2,
                    ChildPath = ",7,154,",
                    SearchPattern = " , Ray , E02208 , DCTH , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 155,
                    ErrorName = "Con lăn",
                    ErrorNameNested = "      Con lăn",
                    ParentID = 7,
                    ErrorCode = "E02209",
                    MachineGroupID = 2,
                    MachineGroupName = "DCTH",
                    L = 2,
                    ChildPath = ",7,155,",
                    SearchPattern = " , Con lăn , E02209 , DCTH , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 156,
                    ErrorName = "Cốt bạc đạn con lăn",
                    ErrorNameNested = "      Cốt bạc đạn con lăn",
                    ParentID = 7,
                    ErrorCode = "E02210",
                    MachineGroupID = 2,
                    MachineGroupName = "DCTH",
                    L = 2,
                    ChildPath = ",7,156,",
                    SearchPattern = " , Cốt bạc đạn con lăn , E02210 , DCTH , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 157,
                    ErrorName = "Bánh xe tải dây",
                    ErrorNameNested = "      Bánh xe tải dây",
                    ParentID = 7,
                    ErrorCode = "E02211",
                    MachineGroupID = 2,
                    MachineGroupName = "DCTH",
                    L = 2,
                    ChildPath = ",7,157,",
                    SearchPattern = " , Bánh xe tải dây , E02211 , DCTH , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 158,
                    ErrorName = "Thanh trượt",
                    ErrorNameNested = "      Thanh trượt",
                    ParentID = 7,
                    ErrorCode = "E02212",
                    MachineGroupID = 2,
                    MachineGroupName = "DCTH",
                    L = 2,
                    ChildPath = ",7,158,",
                    SearchPattern = " , Thanh trượt , E02212 , DCTH , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 159,
                    ErrorName = "Bánh xe dẫn hướng",
                    ErrorNameNested = "      Bánh xe dẫn hướng",
                    ParentID = 7,
                    ErrorCode = "E02213",
                    MachineGroupID = 2,
                    MachineGroupName = "DCTH",
                    L = 2,
                    ChildPath = ",7,159,",
                    SearchPattern = " , Bánh xe dẫn hướng , E02213 , DCTH , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 8,
                    ErrorName = "Cơ khí",
                    ErrorNameNested = "Cơ khí",
                    ParentID = 0,
                    ErrorCode = "E02300",
                    MachineGroupID = 3,
                    MachineGroupName = "LASER",
                    L = 1,
                    ChildPath = ",8,",
                    SearchPattern = " , Cơ khí , E02300 , LASER , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 113,
                    ErrorName = "Bánh răng",
                    ErrorNameNested = "      Bánh răng",
                    ParentID = 8,
                    ErrorCode = "E02301",
                    MachineGroupID = 3,
                    MachineGroupName = "LASER",
                    L = 2,
                    ChildPath = ",8,113,",
                    SearchPattern = " , Bánh răng , E02301 , LASER , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 114,
                    ErrorName = "Thanh răng",
                    ErrorNameNested = "      Thanh răng",
                    ParentID = 8,
                    ErrorCode = "E02302",
                    MachineGroupID = 3,
                    MachineGroupName = "LASER",
                    L = 2,
                    ChildPath = ",8,114,",
                    SearchPattern = " , Thanh răng , E02302 , LASER , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 115,
                    ErrorName = "Cắt méo vuông ke",
                    ErrorNameNested = "      Cắt méo vuông ke",
                    ParentID = 8,
                    ErrorCode = "E02303",
                    MachineGroupID = 3,
                    MachineGroupName = "LASER",
                    L = 2,
                    ChildPath = ",8,115,",
                    SearchPattern = " , Cắt méo vuông ke , E02303 , LASER , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 116,
                    ErrorName = "Cụm vitme trục Z",
                    ErrorNameNested = "      Cụm vitme trục Z",
                    ParentID = 8,
                    ErrorCode = "E02304",
                    MachineGroupID = 3,
                    MachineGroupName = "LASER",
                    L = 2,
                    ChildPath = ",8,116,",
                    SearchPattern = " , Cụm vitme trục Z , E02304 , LASER , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 117,
                    ErrorName = "Bánh xe dẫn hướng",
                    ErrorNameNested = "      Bánh xe dẫn hướng",
                    ParentID = 8,
                    ErrorCode = "E02305",
                    MachineGroupID = 3,
                    MachineGroupName = "LASER",
                    L = 2,
                    ChildPath = ",8,117,",
                    SearchPattern = " , Bánh xe dẫn hướng , E02305 , LASER , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 118,
                    ErrorName = "Cắt không tròn, méo lỗ",
                    ErrorNameNested = "      Cắt không tròn, méo lỗ",
                    ParentID = 8,
                    ErrorCode = "E02306",
                    MachineGroupID = 3,
                    MachineGroupName = "LASER",
                    L = 2,
                    ChildPath = ",8,118,",
                    SearchPattern = " , Cắt không tròn, méo lỗ , E02306 , LASER , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 119,
                    ErrorName = "Hộp số motor",
                    ErrorNameNested = "      Hộp số motor",
                    ParentID = 8,
                    ErrorCode = "E02307",
                    MachineGroupID = 3,
                    MachineGroupName = "LASER",
                    L = 2,
                    ChildPath = ",8,119,",
                    SearchPattern = " , Hộp số motor , E02307 , LASER , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 120,
                    ErrorName = "Bộ gá động cơ",
                    ErrorNameNested = "      Bộ gá động cơ",
                    ParentID = 8,
                    ErrorCode = "E02308",
                    MachineGroupID = 3,
                    MachineGroupName = "LASER",
                    L = 2,
                    ChildPath = ",8,120,",
                    SearchPattern = " , Bộ gá động cơ , E02308 , LASER , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 121,
                    ErrorName = "Khung máy",
                    ErrorNameNested = "      Khung máy",
                    ParentID = 8,
                    ErrorCode = "E02309",
                    MachineGroupID = 3,
                    MachineGroupName = "LASER",
                    L = 2,
                    ChildPath = ",8,121,",
                    SearchPattern = " , Khung máy , E02309 , LASER , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 122,
                    ErrorName = "Con trượt",
                    ErrorNameNested = "      Con trượt",
                    ParentID = 8,
                    ErrorCode = "E02310",
                    MachineGroupID = 3,
                    MachineGroupName = "LASER",
                    L = 2,
                    ChildPath = ",8,122,",
                    SearchPattern = " , Con trượt , E02310 , LASER , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 123,
                    ErrorName = "Thanh trượt",
                    ErrorNameNested = "      Thanh trượt",
                    ParentID = 8,
                    ErrorCode = "E02311",
                    MachineGroupID = 3,
                    MachineGroupName = "LASER",
                    L = 2,
                    ChildPath = ",8,123,",
                    SearchPattern = " , Thanh trượt , E02311 , LASER , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 124,
                    ErrorName = "Xích chuyển đổi bàn",
                    ErrorNameNested = "      Xích chuyển đổi bàn",
                    ParentID = 8,
                    ErrorCode = "E02312",
                    MachineGroupID = 3,
                    MachineGroupName = "LASER",
                    L = 2,
                    ChildPath = ",8,124,",
                    SearchPattern = " , Xích chuyển đổi bàn , E02312 , LASER , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 160,
                    ErrorName = "Bánh răng",
                    ErrorNameNested = "      Bánh răng",
                    ParentID = 8,
                    ErrorCode = "E02301",
                    MachineGroupID = 3,
                    MachineGroupName = "LASER",
                    L = 2,
                    ChildPath = ",8,160,",
                    SearchPattern = " , Bánh răng , E02301 , LASER , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 161,
                    ErrorName = "Thanh răng",
                    ErrorNameNested = "      Thanh răng",
                    ParentID = 8,
                    ErrorCode = "E02302",
                    MachineGroupID = 3,
                    MachineGroupName = "LASER",
                    L = 2,
                    ChildPath = ",8,161,",
                    SearchPattern = " , Thanh răng , E02302 , LASER , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 162,
                    ErrorName = "Cắt méo vuông ke",
                    ErrorNameNested = "      Cắt méo vuông ke",
                    ParentID = 8,
                    ErrorCode = "E02303",
                    MachineGroupID = 3,
                    MachineGroupName = "LASER",
                    L = 2,
                    ChildPath = ",8,162,",
                    SearchPattern = " , Cắt méo vuông ke , E02303 , LASER , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 163,
                    ErrorName = "Cụm vitme trục Z",
                    ErrorNameNested = "      Cụm vitme trục Z",
                    ParentID = 8,
                    ErrorCode = "E02304",
                    MachineGroupID = 3,
                    MachineGroupName = "LASER",
                    L = 2,
                    ChildPath = ",8,163,",
                    SearchPattern = " , Cụm vitme trục Z , E02304 , LASER , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 164,
                    ErrorName = "Bánh xe dẫn hướng",
                    ErrorNameNested = "      Bánh xe dẫn hướng",
                    ParentID = 8,
                    ErrorCode = "E02305",
                    MachineGroupID = 3,
                    MachineGroupName = "LASER",
                    L = 2,
                    ChildPath = ",8,164,",
                    SearchPattern = " , Bánh xe dẫn hướng , E02305 , LASER , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 165,
                    ErrorName = "Cắt không tròn, méo lỗ",
                    ErrorNameNested = "      Cắt không tròn, méo lỗ",
                    ParentID = 8,
                    ErrorCode = "E02306",
                    MachineGroupID = 3,
                    MachineGroupName = "LASER",
                    L = 2,
                    ChildPath = ",8,165,",
                    SearchPattern = " , Cắt không tròn, méo lỗ , E02306 , LASER , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 166,
                    ErrorName = "Hộp số motor",
                    ErrorNameNested = "      Hộp số motor",
                    ParentID = 8,
                    ErrorCode = "E02307",
                    MachineGroupID = 3,
                    MachineGroupName = "LASER",
                    L = 2,
                    ChildPath = ",8,166,",
                    SearchPattern = " , Hộp số motor , E02307 , LASER , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 167,
                    ErrorName = "Bộ gá động cơ",
                    ErrorNameNested = "      Bộ gá động cơ",
                    ParentID = 8,
                    ErrorCode = "E02308",
                    MachineGroupID = 3,
                    MachineGroupName = "LASER",
                    L = 2,
                    ChildPath = ",8,167,",
                    SearchPattern = " , Bộ gá động cơ , E02308 , LASER , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 168,
                    ErrorName = "Khung máy",
                    ErrorNameNested = "      Khung máy",
                    ParentID = 8,
                    ErrorCode = "E02309",
                    MachineGroupID = 3,
                    MachineGroupName = "LASER",
                    L = 2,
                    ChildPath = ",8,168,",
                    SearchPattern = " , Khung máy , E02309 , LASER , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 169,
                    ErrorName = "Con trượt",
                    ErrorNameNested = "      Con trượt",
                    ParentID = 8,
                    ErrorCode = "E02310",
                    MachineGroupID = 3,
                    MachineGroupName = "LASER",
                    L = 2,
                    ChildPath = ",8,169,",
                    SearchPattern = " , Con trượt , E02310 , LASER , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 170,
                    ErrorName = "Thanh trượt",
                    ErrorNameNested = "      Thanh trượt",
                    ParentID = 8,
                    ErrorCode = "E02311",
                    MachineGroupID = 3,
                    MachineGroupName = "LASER",
                    L = 2,
                    ChildPath = ",8,170,",
                    SearchPattern = " , Thanh trượt , E02311 , LASER , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 171,
                    ErrorName = "Xích chuyển đổi bàn",
                    ErrorNameNested = "      Xích chuyển đổi bàn",
                    ParentID = 8,
                    ErrorCode = "E02312",
                    MachineGroupID = 3,
                    MachineGroupName = "LASER",
                    L = 2,
                    ChildPath = ",8,171,",
                    SearchPattern = " , Xích chuyển đổi bàn , E02312 , LASER , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 9,
                    ErrorName = "Cơ khí",
                    ErrorNameNested = "Cơ khí",
                    ParentID = 0,
                    ErrorCode = "E02400",
                    MachineGroupID = 4,
                    MachineGroupName = "PLASMA",
                    L = 1,
                    ChildPath = ",9,",
                    SearchPattern = " , Cơ khí , E02400 , PLASMA , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 125,
                    ErrorName = "Bánh răng",
                    ErrorNameNested = "      Bánh răng",
                    ParentID = 9,
                    ErrorCode = "E02401",
                    MachineGroupID = 4,
                    MachineGroupName = "PLASMA",
                    L = 2,
                    ChildPath = ",9,125,",
                    SearchPattern = " , Bánh răng , E02401 , PLASMA , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 126,
                    ErrorName = "Thanh răng",
                    ErrorNameNested = "      Thanh răng",
                    ParentID = 9,
                    ErrorCode = "E02402",
                    MachineGroupID = 4,
                    MachineGroupName = "PLASMA",
                    L = 2,
                    ChildPath = ",9,126,",
                    SearchPattern = " , Thanh răng , E02402 , PLASMA , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 127,
                    ErrorName = "Dây đai",
                    ErrorNameNested = "      Dây đai",
                    ParentID = 9,
                    ErrorCode = "E02403",
                    MachineGroupID = 4,
                    MachineGroupName = "PLASMA",
                    L = 2,
                    ChildPath = ",9,127,",
                    SearchPattern = " , Dây đai , E02403 , PLASMA , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 128,
                    ErrorName = "Cụm trục Z",
                    ErrorNameNested = "      Cụm trục Z",
                    ParentID = 9,
                    ErrorCode = "E02404",
                    MachineGroupID = 4,
                    MachineGroupName = "PLASMA",
                    L = 2,
                    ChildPath = ",9,128,",
                    SearchPattern = " , Cụm trục Z , E02404 , PLASMA , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 129,
                    ErrorName = "Bánh xe dẫn hướng",
                    ErrorNameNested = "      Bánh xe dẫn hướng",
                    ParentID = 9,
                    ErrorCode = "E02405",
                    MachineGroupID = 4,
                    MachineGroupName = "PLASMA",
                    L = 2,
                    ChildPath = ",9,129,",
                    SearchPattern = " , Bánh xe dẫn hướng , E02405 , PLASMA , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 130,
                    ErrorName = "Cụm gá mỏ súng plasma",
                    ErrorNameNested = "      Cụm gá mỏ súng plasma",
                    ParentID = 9,
                    ErrorCode = "E02406",
                    MachineGroupID = 4,
                    MachineGroupName = "PLASMA",
                    L = 2,
                    ChildPath = ",9,130,",
                    SearchPattern = " , Cụm gá mỏ súng plasma , E02406 , PLASMA , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 131,
                    ErrorName = "Hộp số motor",
                    ErrorNameNested = "      Hộp số motor",
                    ParentID = 9,
                    ErrorCode = "E02407",
                    MachineGroupID = 4,
                    MachineGroupName = "PLASMA",
                    L = 2,
                    ChildPath = ",9,131,",
                    SearchPattern = " , Hộp số motor , E02407 , PLASMA , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 132,
                    ErrorName = "Đường ray",
                    ErrorNameNested = "      Đường ray",
                    ParentID = 9,
                    ErrorCode = "E02408",
                    MachineGroupID = 4,
                    MachineGroupName = "PLASMA",
                    L = 2,
                    ChildPath = ",9,132,",
                    SearchPattern = " , Đường ray , E02408 , PLASMA , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 133,
                    ErrorName = "Khung máy",
                    ErrorNameNested = "      Khung máy",
                    ParentID = 9,
                    ErrorCode = "E02409",
                    MachineGroupID = 4,
                    MachineGroupName = "PLASMA",
                    L = 2,
                    ChildPath = ",9,133,",
                    SearchPattern = " , Khung máy , E02409 , PLASMA , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 134,
                    ErrorName = "Con trượt",
                    ErrorNameNested = "      Con trượt",
                    ParentID = 9,
                    ErrorCode = "E02410",
                    MachineGroupID = 4,
                    MachineGroupName = "PLASMA",
                    L = 2,
                    ChildPath = ",9,134,",
                    SearchPattern = " , Con trượt , E02410 , PLASMA , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 135,
                    ErrorName = "Thanh trượt",
                    ErrorNameNested = "      Thanh trượt",
                    ParentID = 9,
                    ErrorCode = "E02411",
                    MachineGroupID = 4,
                    MachineGroupName = "PLASMA",
                    L = 2,
                    ChildPath = ",9,135,",
                    SearchPattern = " , Thanh trượt , E02411 , PLASMA , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 136,
                    ErrorName = "Bàn cắt",
                    ErrorNameNested = "      Bàn cắt",
                    ParentID = 9,
                    ErrorCode = "E02412",
                    MachineGroupID = 4,
                    MachineGroupName = "PLASMA",
                    L = 2,
                    ChildPath = ",9,136,",
                    SearchPattern = " , Bàn cắt , E02412 , PLASMA , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 137,
                    ErrorName = "Bộ nâng hạ pha băng",
                    ErrorNameNested = "      Bộ nâng hạ pha băng",
                    ParentID = 9,
                    ErrorCode = "E02413",
                    MachineGroupID = 4,
                    MachineGroupName = "PLASMA",
                    L = 2,
                    ChildPath = ",9,137,",
                    SearchPattern = " , Bộ nâng hạ pha băng , E02413 , PLASMA , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 172,
                    ErrorName = "Bánh răng",
                    ErrorNameNested = "      Bánh răng",
                    ParentID = 9,
                    ErrorCode = "E02401",
                    MachineGroupID = 4,
                    MachineGroupName = "PLASMA",
                    L = 2,
                    ChildPath = ",9,172,",
                    SearchPattern = " , Bánh răng , E02401 , PLASMA , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 173,
                    ErrorName = "Thanh răng",
                    ErrorNameNested = "      Thanh răng",
                    ParentID = 9,
                    ErrorCode = "E02402",
                    MachineGroupID = 4,
                    MachineGroupName = "PLASMA",
                    L = 2,
                    ChildPath = ",9,173,",
                    SearchPattern = " , Thanh răng , E02402 , PLASMA , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 174,
                    ErrorName = "Dây đai",
                    ErrorNameNested = "      Dây đai",
                    ParentID = 9,
                    ErrorCode = "E02403",
                    MachineGroupID = 4,
                    MachineGroupName = "PLASMA",
                    L = 2,
                    ChildPath = ",9,174,",
                    SearchPattern = " , Dây đai , E02403 , PLASMA , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 175,
                    ErrorName = "Cụm trục Z",
                    ErrorNameNested = "      Cụm trục Z",
                    ParentID = 9,
                    ErrorCode = "E02404",
                    MachineGroupID = 4,
                    MachineGroupName = "PLASMA",
                    L = 2,
                    ChildPath = ",9,175,",
                    SearchPattern = " , Cụm trục Z , E02404 , PLASMA , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 176,
                    ErrorName = "Bánh xe dẫn hướng",
                    ErrorNameNested = "      Bánh xe dẫn hướng",
                    ParentID = 9,
                    ErrorCode = "E02405",
                    MachineGroupID = 4,
                    MachineGroupName = "PLASMA",
                    L = 2,
                    ChildPath = ",9,176,",
                    SearchPattern = " , Bánh xe dẫn hướng , E02405 , PLASMA , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 177,
                    ErrorName = "Cụm gá mỏ súng plasma",
                    ErrorNameNested = "      Cụm gá mỏ súng plasma",
                    ParentID = 9,
                    ErrorCode = "E02406",
                    MachineGroupID = 4,
                    MachineGroupName = "PLASMA",
                    L = 2,
                    ChildPath = ",9,177,",
                    SearchPattern = " , Cụm gá mỏ súng plasma , E02406 , PLASMA , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 178,
                    ErrorName = "Hộp số motor",
                    ErrorNameNested = "      Hộp số motor",
                    ParentID = 9,
                    ErrorCode = "E02407",
                    MachineGroupID = 4,
                    MachineGroupName = "PLASMA",
                    L = 2,
                    ChildPath = ",9,178,",
                    SearchPattern = " , Hộp số motor , E02407 , PLASMA , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 179,
                    ErrorName = "Đường ray",
                    ErrorNameNested = "      Đường ray",
                    ParentID = 9,
                    ErrorCode = "E02408",
                    MachineGroupID = 4,
                    MachineGroupName = "PLASMA",
                    L = 2,
                    ChildPath = ",9,179,",
                    SearchPattern = " , Đường ray , E02408 , PLASMA , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 180,
                    ErrorName = "Khung máy",
                    ErrorNameNested = "      Khung máy",
                    ParentID = 9,
                    ErrorCode = "E02409",
                    MachineGroupID = 4,
                    MachineGroupName = "PLASMA",
                    L = 2,
                    ChildPath = ",9,180,",
                    SearchPattern = " , Khung máy , E02409 , PLASMA , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 181,
                    ErrorName = "Con trượt",
                    ErrorNameNested = "      Con trượt",
                    ParentID = 9,
                    ErrorCode = "E02410",
                    MachineGroupID = 4,
                    MachineGroupName = "PLASMA",
                    L = 2,
                    ChildPath = ",9,181,",
                    SearchPattern = " , Con trượt , E02410 , PLASMA , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 182,
                    ErrorName = "Thanh trượt",
                    ErrorNameNested = "      Thanh trượt",
                    ParentID = 9,
                    ErrorCode = "E02411",
                    MachineGroupID = 4,
                    MachineGroupName = "PLASMA",
                    L = 2,
                    ChildPath = ",9,182,",
                    SearchPattern = " , Thanh trượt , E02411 , PLASMA , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 183,
                    ErrorName = "Bàn cắt",
                    ErrorNameNested = "      Bàn cắt",
                    ParentID = 9,
                    ErrorCode = "E02412",
                    MachineGroupID = 4,
                    MachineGroupName = "PLASMA",
                    L = 2,
                    ChildPath = ",9,183,",
                    SearchPattern = " , Bàn cắt , E02412 , PLASMA , "
                });
                Data_Error.Add(new Common.Data_Error()
                {
                    ID = 184,
                    ErrorName = "Bộ nâng hạ pha băng",
                    ErrorNameNested = "      Bộ nâng hạ pha băng",
                    ParentID = 9,
                    ErrorCode = "E02413",
                    MachineGroupID = 4,
                    MachineGroupName = "PLASMA",
                    L = 2,
                    ChildPath = ",9,184,",
                    SearchPattern = " , Bộ nâng hạ pha băng , E02413 , PLASMA , "
                });


                #endregion

                #region Build table Data_MachineLocation --> https://docs.google.com/spreadsheets/d/1UMRjN9evTMvQwJMt31RtQRhMZcriXHBo0uEliIhr05M/edit#gid=1321645102&range=D2

                Data_MachineLocation.Add(new Common.Data_MachineLocation() { LocationID = 1, LocationName = "AH1" });
                //Data_MachineLocation.Add(new Common.Data_MachineLocation() { LocationID = 2, LocationName = "AH1-Tổ Cắt -LAB" });
                //Data_MachineLocation.Add(new Common.Data_MachineLocation() { LocationID = 3, LocationName = "AH1-Tổ Cắt -LCD" });
                //Data_MachineLocation.Add(new Common.Data_MachineLocation() { LocationID = 4, LocationName = "AH1-Tổ Cắt BM-LBC" });
                //Data_MachineLocation.Add(new Common.Data_MachineLocation() { LocationID = 5, LocationName = "AH1-Tổ Tiện-LDE" });
                //Data_MachineLocation.Add(new Common.Data_MachineLocation() { LocationID = 6, LocationName = "AH2" });
                //Data_MachineLocation.Add(new Common.Data_MachineLocation() { LocationID = 7, LocationName = "AH2-L BC" });
                //Data_MachineLocation.Add(new Common.Data_MachineLocation() { LocationID = 8, LocationName = "AH2-LAB" });
                //Data_MachineLocation.Add(new Common.Data_MachineLocation() { LocationID = 9, LocationName = "AH2-LBC" });
                //Data_MachineLocation.Add(new Common.Data_MachineLocation() { LocationID = 10, LocationName = "AH2-LCD" });
                //Data_MachineLocation.Add(new Common.Data_MachineLocation() { LocationID = 11, LocationName = "AH2-T.CK-LBC" });
                //Data_MachineLocation.Add(new Common.Data_MachineLocation() { LocationID = 12, LocationName = "AH2-Tổ HT-BC" });
                //Data_MachineLocation.Add(new Common.Data_MachineLocation() { LocationID = 13, LocationName = "AH2-Tổ HT-LBC" });
                //Data_MachineLocation.Add(new Common.Data_MachineLocation() { LocationID = 14, LocationName = "AH2-Tổ Hàn Thô -L BC" });
                //Data_MachineLocation.Add(new Common.Data_MachineLocation() { LocationID = 15, LocationName = "AH2-Tổ HÀN Thô -LBC" });
                //Data_MachineLocation.Add(new Common.Data_MachineLocation() { LocationID = 16, LocationName = "AH2-Tổ Ráp Thô 1-L AB" });
                //Data_MachineLocation.Add(new Common.Data_MachineLocation() { LocationID = 17, LocationName = "AH3-LBC" });
                //Data_MachineLocation.Add(new Common.Data_MachineLocation() { LocationID = 18, LocationName = "AH3-Tổ Hàn HT" });
                //Data_MachineLocation.Add(new Common.Data_MachineLocation() { LocationID = 19, LocationName = "AH3-Tổ hàn thô-LB" });
                //Data_MachineLocation.Add(new Common.Data_MachineLocation() { LocationID = 20, LocationName = "AH3-Tổ RT+HT-LBC" });

                #endregion

                #region Build table Data_MachineGroup

                Data_MachineGroup.Add(new Common.Data_MachineGroup() { MachineGroupID = 6, MachineGroupName = "Máy cắt", ColorCode = "#5f9d32" });
                Data_MachineGroup.Add(new Common.Data_MachineGroup() { MachineGroupID = 7, MachineGroupName = "Máy chấn", ColorCode = "#9ccc65" });
                Data_MachineGroup.Add(new Common.Data_MachineGroup() { MachineGroupID = 8, MachineGroupName = "Máy đột, khoan, đánh dấu", ColorCode = "#E3DA30" });
                Data_MachineGroup.Add(new Common.Data_MachineGroup() { MachineGroupID = 9, MachineGroupName = "Máy đột, cắt, đóng dấu", ColorCode = "#ffba57" });
                Data_MachineGroup.Add(new Common.Data_MachineGroup() { MachineGroupID = 10, MachineGroupName = "Máy hàn Laser", ColorCode = "#afabab" });
                Data_MachineGroup.Add(new Common.Data_MachineGroup() { MachineGroupID = 11, MachineGroupName = "Máy hàn Mig", ColorCode = "#ff5252" });
                Data_MachineGroup.Add(new Common.Data_MachineGroup() { MachineGroupID = 12, MachineGroupName = "Máy khoan", ColorCode = "#00b050" });
                Data_MachineGroup.Add(new Common.Data_MachineGroup() { MachineGroupID = 13, MachineGroupName = "Robot", ColorCode = "#a6a6a6" });

                #endregion

                #region Build table Data_Machine --> https://docs.google.com/spreadsheets/d/1UMRjN9evTMvQwJMt31RtQRhMZcriXHBo0uEliIhr05M/edit#gid=1716046326&range=D3
                // Data_Machine.Add(new Common.Data_Machine() { MachineID = 1, MachineName = "", AssetGroupName = "", AssetGroupID = 1, MachineGroupName = "", MachineGroupID = 1, Model = "", ProviderName = "", Note = "" });

                Data_Machine.Add(new Common.Data_Machine() { MachineID = 1, MachineName = "Máy cắt Laser sợi quang ", AssetGroupName = "Máy cắt", AssetGroupID = 1, MachineGroupName = "Máy cắt", MachineGroupID = 6, Model = "HLF2060-12KW", ProviderName = "Yawei", Note = "LASER TẤM CNC", Quantity = 1, ImageUrl = "NC_HLF2060.jpg" });
                Data_Machine.Add(new Common.Data_Machine() { MachineID = 2, MachineName = "Máy cắt laser thép hình ", AssetGroupName = "Máy cắt", AssetGroupID = 1, MachineGroupName = "Máy cắt", MachineGroupID = 6, Model = "LT6035-6KW", ProviderName = "ACME", Note = "LASER THÉP HÌNH CNC", Quantity = 1, ImageUrl = "NC_LT6035.jpg" });
                Data_Machine.Add(new Common.Data_Machine() { MachineID = 3, MachineName = "Máy cắt Plasma CNC ", AssetGroupName = "Máy cắt", AssetGroupID = 1, MachineGroupName = "Máy cắt", MachineGroupID = 6, Model = "HNC3000", ProviderName = "Bruco", Note = "PLASMA CNC", Quantity = 1, ImageUrl = "NC_HNC3000.jpg" });
                Data_Machine.Add(new Common.Data_Machine() { MachineID = 4, MachineName = "Máy cắt thủy lực CNC ", AssetGroupName = "Máy cắt", AssetGroupID = 1, MachineGroupName = "Máy cắt", MachineGroupID = 6, Model = "CLS2516", ProviderName = "Kruman", Note = "CT4", Quantity = 1, ImageUrl = "NC_CLS2516.jpg" });
                Data_Machine.Add(new Common.Data_Machine() { MachineID = 5, MachineName = "Máy chấn thủy lực CNC ", AssetGroupName = "Máy chấn", AssetGroupID = 2, MachineGroupName = "Máy chấn", MachineGroupID = 7, Model = "PBH160T/3100", ProviderName = "Yawei", Note = "CHẤN CNC", Quantity = 1, ImageUrl = "NoImage.jpg" });
                Data_Machine.Add(new Common.Data_Machine() { MachineID = 6, MachineName = "Máy đột khoan và đánh dấu thép tấm", AssetGroupName = "Máy đột", AssetGroupID = 3, MachineGroupName = "Máy đột, khoan, đánh dấu", MachineGroupID = 8, Model = "TPPR 103", ProviderName = "Sunrise", Note = "CNCM2", Quantity = 1, ImageUrl = "NC_TPPRD103.jpg" });
                Data_Machine.Add(new Common.Data_Machine() { MachineID = 7, MachineName = "Máy đột, cắt, đóng dấu CNC thép góc ", AssetGroupName = "Máy đột", AssetGroupID = 3, MachineGroupName = "Máy đột, cắt, đóng dấu", MachineGroupID = 9, Model = "TAPM2020A", ProviderName = "Sunrise", Note = "CNCV1", Quantity = 1, ImageUrl = "NC_TAPM2020A.jpg" });
                Data_Machine.Add(new Common.Data_Machine() { MachineID = 8, MachineName = "Máy đột, cắt, đóng dấu CNC thép góc ", AssetGroupName = "Máy đột", AssetGroupID = 3, MachineGroupName = "Máy đột, cắt, đóng dấu", MachineGroupID = 9, Model = "TAPM1516S", ProviderName = "Sunrise", Note = "CNCV2", Quantity = 1, ImageUrl = "NC_TAPM1516S.jpg" });
                Data_Machine.Add(new Common.Data_Machine() { MachineID = 9, MachineName = "Máy đột, cắt, đóng dấu CNC thép góc ", AssetGroupName = "Máy đột", AssetGroupID = 3, MachineGroupName = "Máy đột, cắt, đóng dấu", MachineGroupID = 9, Model = "TAPM1010-3", ProviderName = "Sunrise", Note = "CNCV3", Quantity = 1, ImageUrl = "NC_TAPM1010.jpg" });
                Data_Machine.Add(new Common.Data_Machine() { MachineID = 10, MachineName = "Máy đột, cắt, đóng dấu CNC thép góc", AssetGroupName = "Máy đột", AssetGroupID = 3, MachineGroupName = "Máy đột, cắt, đóng dấu", MachineGroupID = 9, Model = "TAPM1010-3", ProviderName = "Sunrise", Note = "CNCV4", Quantity = 1, ImageUrl = "NC_TAPM1010.jpg" });
                Data_Machine.Add(new Common.Data_Machine() { MachineID = 11, MachineName = "Máy hàn laser ", AssetGroupName = "Máy hàn", AssetGroupID = 4, MachineGroupName = "Máy hàn Laser", MachineGroupID = 10, Model = "LS1500", ProviderName = "Jasic", Note = "HÀN LASER", Quantity = 1, ImageUrl = "NC_LS1500.jpg" });
                Data_Machine.Add(new Common.Data_Machine() { MachineID = 12, MachineName = "Máy hàn mig", AssetGroupName = "Máy hàn", AssetGroupID = 4, MachineGroupName = "Máy hàn Mig", MachineGroupID = 11, Model = "Mig500 (j8110)", ProviderName = "MIG", Note = "MIG", Quantity = 1, ImageUrl = "NC_Mig500_J8110.jpg" });
                Data_Machine.Add(new Common.Data_Machine() { MachineID = 13, MachineName = "Máy hàn mig", AssetGroupName = "Máy hàn", AssetGroupID = 4, MachineGroupName = "Máy hàn Mig", MachineGroupID = 11, Model = "EHAVE 2 CM500B", ProviderName = "Megmeet", Note = "MIG", Quantity = 1, ImageUrl = "NC_Mig500_Ehave2CM.jpg" });
                Data_Machine.Add(new Common.Data_Machine() { MachineID = 14, MachineName = "Máy khoan tấm CNC ", AssetGroupName = "Máy khoan", AssetGroupID = 5, MachineGroupName = "Máy khoan", MachineGroupID = 12, Model = "TPD3016", ProviderName = "Sunrise", Note = "CNCK2", Quantity = 1, ImageUrl = "NC_TPD3016.jpg" });
                Data_Machine.Add(new Common.Data_Machine() { MachineID = 15, MachineName = "Máy khoan, đóng dấu CNC thép góc ", AssetGroupName = "Máy khoan", AssetGroupID = 5, MachineGroupName = "Máy khoan", MachineGroupID = 12, Model = "TBL3635", ProviderName = "Sunrise", Note = "CNCK1", Quantity = 15, ImageUrl = "NC_TBL3635.jpg" });
                Data_Machine.Add(new Common.Data_Machine() { MachineID = 16, MachineName = "Trạm robot hàn, gá xoay đồng bộ ", AssetGroupName = "Robot", AssetGroupID = 6, MachineGroupName = "Robot", MachineGroupID = 13, Model = "QJRH-4-1A-Nguồn Esten 500A", ProviderName = "Qjar", Note = "ROBOT HÀN", Quantity = 5, ImageUrl = "NC_QJRH41A.jpg" });
                #endregion

                #region Build table Data_MachineLocationSetup --> https://docs.google.com/spreadsheets/d/1UMRjN9evTMvQwJMt31RtQRhMZcriXHBo0uEliIhr05M/edit#gid=793389812&range=E2 

                Data_MachineLocationSetup.Add(new Common.Data_MachineLocationSetup() { MachineID = 1, MachineName = "Máy cắt Laser sợi quang", LocationID = 1, LocationName = "Nha may 1" });
                Data_MachineLocationSetup.Add(new Common.Data_MachineLocationSetup() { MachineID = 2, MachineName = "Máy cắt laser thép hình", LocationID = 1, LocationName = "Nha may 1" });
                Data_MachineLocationSetup.Add(new Common.Data_MachineLocationSetup() { MachineID = 3, MachineName = "Máy cắt Plasma CNC", LocationID = 1, LocationName = "Nha may 1" });
                Data_MachineLocationSetup.Add(new Common.Data_MachineLocationSetup() { MachineID = 4, MachineName = "Máy cắt thủy lực CNC", LocationID = 1, LocationName = "Nha may 1" });
                Data_MachineLocationSetup.Add(new Common.Data_MachineLocationSetup() { MachineID = 5, MachineName = "Máy chấn thủy lực CNC", LocationID = 1, LocationName = "Nha may 1" });
                Data_MachineLocationSetup.Add(new Common.Data_MachineLocationSetup() { MachineID = 6, MachineName = "Máy đột khoan và đánh dấu thép tấm", LocationID = 1, LocationName = "Nha may 1" });
                Data_MachineLocationSetup.Add(new Common.Data_MachineLocationSetup() { MachineID = 7, MachineName = "Máy đột, cắt, đóng dấu CNC thép góc", LocationID = 1, LocationName = "Nha may 1" });
                Data_MachineLocationSetup.Add(new Common.Data_MachineLocationSetup() { MachineID = 8, MachineName = "Máy đột, cắt, đóng dấu CNC thép góc", LocationID = 1, LocationName = "Nha may 1" });
                Data_MachineLocationSetup.Add(new Common.Data_MachineLocationSetup() { MachineID = 9, MachineName = "Máy đột, cắt, đóng dấu CNC thép góc", LocationID = 1, LocationName = "Nha may 1" });
                Data_MachineLocationSetup.Add(new Common.Data_MachineLocationSetup() { MachineID = 10, MachineName = "Máy đột, cắt, đóng dấu CNC thép góc", LocationID = 1, LocationName = "Nha may 1" });
                Data_MachineLocationSetup.Add(new Common.Data_MachineLocationSetup() { MachineID = 11, MachineName = "Máy hàn laser", LocationID = 1, LocationName = "Nha may 1" });
                Data_MachineLocationSetup.Add(new Common.Data_MachineLocationSetup() { MachineID = 12, MachineName = "Máy hàn mig", LocationID = 1, LocationName = "Nha may 1" });
                Data_MachineLocationSetup.Add(new Common.Data_MachineLocationSetup() { MachineID = 13, MachineName = "Máy hàn mig", LocationID = 1, LocationName = "Nha may 1" });
                Data_MachineLocationSetup.Add(new Common.Data_MachineLocationSetup() { MachineID = 14, MachineName = "Máy khoan tấm CNC", LocationID = 1, LocationName = "Nha may 1" });
                Data_MachineLocationSetup.Add(new Common.Data_MachineLocationSetup() { MachineID = 15, MachineName = "Máy khoan, đóng dấu CNC thép góc", LocationID = 1, LocationName = "Nha may 1" });
                Data_MachineLocationSetup.Add(new Common.Data_MachineLocationSetup() { MachineID = 16, MachineName = "Trạm robot hàn, gá xoay đồng bộ", LocationID = 1, LocationName = "Nha may 1" });

                #endregion

                #region Build table Data_ErrorHistory --> Fake

                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 1, ErrorDate = new DateTime(2024, 2, 9), ErrorID = 10, MachineID = 22 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 2, ErrorDate = new DateTime(2022, 10, 17), ErrorID = 17, MachineID = 18 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 3, ErrorDate = new DateTime(2020, 8, 19), ErrorID = 10, MachineID = 38 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 4, ErrorDate = new DateTime(2023, 11, 20), ErrorID = 1, MachineID = 12 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 5, ErrorDate = new DateTime(2021, 6, 12), ErrorID = 3, MachineID = 33 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 6, ErrorDate = new DateTime(2023, 7, 3), ErrorID = 4, MachineID = 7 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 7, ErrorDate = new DateTime(2020, 10, 11), ErrorID = 19, MachineID = 35 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 8, ErrorDate = new DateTime(2023, 1, 27), ErrorID = 19, MachineID = 4 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 9, ErrorDate = new DateTime(2023, 11, 17), ErrorID = 9, MachineID = 38 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 10, ErrorDate = new DateTime(2024, 2, 10), ErrorID = 6, MachineID = 3 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 11, ErrorDate = new DateTime(2023, 4, 9), ErrorID = 18, MachineID = 25 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 12, ErrorDate = new DateTime(2020, 12, 29), ErrorID = 12, MachineID = 9 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 13, ErrorDate = new DateTime(2021, 12, 4), ErrorID = 15, MachineID = 15 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 14, ErrorDate = new DateTime(2020, 8, 21), ErrorID = 8, MachineID = 23 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 15, ErrorDate = new DateTime(2023, 2, 5), ErrorID = 17, MachineID = 1 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 16, ErrorDate = new DateTime(2021, 12, 24), ErrorID = 12, MachineID = 31 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 17, ErrorDate = new DateTime(2021, 11, 11), ErrorID = 9, MachineID = 10 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 18, ErrorDate = new DateTime(2021, 11, 3), ErrorID = 15, MachineID = 27 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 19, ErrorDate = new DateTime(2020, 7, 29), ErrorID = 5, MachineID = 30 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 20, ErrorDate = new DateTime(2020, 6, 11), ErrorID = 20, MachineID = 39 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 21, ErrorDate = new DateTime(2020, 5, 13), ErrorID = 16, MachineID = 8 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 22, ErrorDate = new DateTime(2022, 10, 7), ErrorID = 19, MachineID = 10 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 23, ErrorDate = new DateTime(2021, 6, 2), ErrorID = 14, MachineID = 11 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 24, ErrorDate = new DateTime(2020, 10, 9), ErrorID = 7, MachineID = 24 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 25, ErrorDate = new DateTime(2024, 4, 15), ErrorID = 12, MachineID = 10 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 26, ErrorDate = new DateTime(2024, 3, 30), ErrorID = 18, MachineID = 1 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 27, ErrorDate = new DateTime(2021, 9, 7), ErrorID = 12, MachineID = 11 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 28, ErrorDate = new DateTime(2020, 11, 29), ErrorID = 6, MachineID = 20 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 29, ErrorDate = new DateTime(2020, 9, 2), ErrorID = 7, MachineID = 39 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 30, ErrorDate = new DateTime(2023, 2, 28), ErrorID = 2, MachineID = 22 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 31, ErrorDate = new DateTime(2022, 7, 28), ErrorID = 9, MachineID = 34 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 32, ErrorDate = new DateTime(2022, 9, 27), ErrorID = 10, MachineID = 9 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 33, ErrorDate = new DateTime(2023, 11, 14), ErrorID = 8, MachineID = 21 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 34, ErrorDate = new DateTime(2021, 8, 12), ErrorID = 9, MachineID = 8 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 35, ErrorDate = new DateTime(2020, 4, 9), ErrorID = 15, MachineID = 4 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 36, ErrorDate = new DateTime(2021, 6, 7), ErrorID = 15, MachineID = 39 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 37, ErrorDate = new DateTime(2023, 10, 6), ErrorID = 1, MachineID = 38 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 38, ErrorDate = new DateTime(2024, 2, 17), ErrorID = 14, MachineID = 20 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 39, ErrorDate = new DateTime(2023, 4, 12), ErrorID = 4, MachineID = 30 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 40, ErrorDate = new DateTime(2023, 4, 12), ErrorID = 20, MachineID = 14 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 41, ErrorDate = new DateTime(2021, 1, 23), ErrorID = 20, MachineID = 39 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 42, ErrorDate = new DateTime(2023, 4, 29), ErrorID = 16, MachineID = 6 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 43, ErrorDate = new DateTime(2020, 9, 29), ErrorID = 17, MachineID = 25 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 44, ErrorDate = new DateTime(2020, 12, 15), ErrorID = 3, MachineID = 7 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 45, ErrorDate = new DateTime(2021, 2, 18), ErrorID = 16, MachineID = 39 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 46, ErrorDate = new DateTime(2020, 7, 8), ErrorID = 7, MachineID = 39 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 47, ErrorDate = new DateTime(2020, 12, 4), ErrorID = 3, MachineID = 8 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 48, ErrorDate = new DateTime(2021, 4, 4), ErrorID = 9, MachineID = 26 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 49, ErrorDate = new DateTime(2021, 6, 9), ErrorID = 14, MachineID = 32 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 50, ErrorDate = new DateTime(2023, 9, 13), ErrorID = 13, MachineID = 32 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 51, ErrorDate = new DateTime(2020, 12, 9), ErrorID = 4, MachineID = 27 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 52, ErrorDate = new DateTime(2020, 10, 7), ErrorID = 11, MachineID = 40 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 53, ErrorDate = new DateTime(2022, 10, 7), ErrorID = 1, MachineID = 15 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 54, ErrorDate = new DateTime(2023, 7, 14), ErrorID = 17, MachineID = 11 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 55, ErrorDate = new DateTime(2022, 5, 31), ErrorID = 8, MachineID = 38 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 56, ErrorDate = new DateTime(2020, 8, 7), ErrorID = 5, MachineID = 31 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 57, ErrorDate = new DateTime(2020, 8, 11), ErrorID = 18, MachineID = 5 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 58, ErrorDate = new DateTime(2021, 2, 26), ErrorID = 8, MachineID = 29 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 59, ErrorDate = new DateTime(2020, 7, 31), ErrorID = 6, MachineID = 21 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 60, ErrorDate = new DateTime(2023, 2, 22), ErrorID = 10, MachineID = 27 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 61, ErrorDate = new DateTime(2020, 9, 10), ErrorID = 4, MachineID = 21 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 62, ErrorDate = new DateTime(2021, 12, 22), ErrorID = 9, MachineID = 25 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 63, ErrorDate = new DateTime(2023, 2, 21), ErrorID = 1, MachineID = 3 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 64, ErrorDate = new DateTime(2022, 7, 4), ErrorID = 15, MachineID = 17 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 65, ErrorDate = new DateTime(2024, 1, 31), ErrorID = 8, MachineID = 1 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 66, ErrorDate = new DateTime(2020, 11, 24), ErrorID = 18, MachineID = 19 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 67, ErrorDate = new DateTime(2021, 9, 2), ErrorID = 5, MachineID = 35 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 68, ErrorDate = new DateTime(2020, 11, 4), ErrorID = 5, MachineID = 11 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 69, ErrorDate = new DateTime(2020, 10, 4), ErrorID = 9, MachineID = 38 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 70, ErrorDate = new DateTime(2022, 3, 19), ErrorID = 8, MachineID = 19 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 71, ErrorDate = new DateTime(2020, 8, 5), ErrorID = 11, MachineID = 22 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 72, ErrorDate = new DateTime(2023, 1, 6), ErrorID = 3, MachineID = 17 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 73, ErrorDate = new DateTime(2020, 2, 2), ErrorID = 10, MachineID = 29 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 74, ErrorDate = new DateTime(2021, 11, 9), ErrorID = 12, MachineID = 37 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 75, ErrorDate = new DateTime(2022, 10, 9), ErrorID = 1, MachineID = 6 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 76, ErrorDate = new DateTime(2020, 9, 28), ErrorID = 9, MachineID = 4 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 77, ErrorDate = new DateTime(2024, 4, 17), ErrorID = 7, MachineID = 25 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 78, ErrorDate = new DateTime(2022, 9, 29), ErrorID = 18, MachineID = 18 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 79, ErrorDate = new DateTime(2023, 10, 17), ErrorID = 18, MachineID = 36 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 80, ErrorDate = new DateTime(2022, 10, 31), ErrorID = 5, MachineID = 16 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 81, ErrorDate = new DateTime(2020, 1, 26), ErrorID = 8, MachineID = 11 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 82, ErrorDate = new DateTime(2020, 3, 6), ErrorID = 7, MachineID = 26 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 83, ErrorDate = new DateTime(2023, 5, 8), ErrorID = 7, MachineID = 13 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 84, ErrorDate = new DateTime(2020, 3, 1), ErrorID = 12, MachineID = 31 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 85, ErrorDate = new DateTime(2020, 8, 7), ErrorID = 8, MachineID = 5 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 86, ErrorDate = new DateTime(2023, 6, 9), ErrorID = 16, MachineID = 21 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 87, ErrorDate = new DateTime(2020, 12, 4), ErrorID = 20, MachineID = 22 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 88, ErrorDate = new DateTime(2022, 10, 19), ErrorID = 13, MachineID = 23 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 89, ErrorDate = new DateTime(2021, 12, 8), ErrorID = 10, MachineID = 36 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 90, ErrorDate = new DateTime(2023, 6, 20), ErrorID = 9, MachineID = 26 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 91, ErrorDate = new DateTime(2020, 7, 5), ErrorID = 1, MachineID = 12 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 92, ErrorDate = new DateTime(2020, 7, 23), ErrorID = 16, MachineID = 30 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 93, ErrorDate = new DateTime(2021, 11, 7), ErrorID = 7, MachineID = 36 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 94, ErrorDate = new DateTime(2023, 1, 1), ErrorID = 3, MachineID = 27 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 95, ErrorDate = new DateTime(2020, 9, 6), ErrorID = 12, MachineID = 17 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 96, ErrorDate = new DateTime(2022, 11, 26), ErrorID = 10, MachineID = 19 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 97, ErrorDate = new DateTime(2021, 8, 5), ErrorID = 6, MachineID = 1 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 98, ErrorDate = new DateTime(2023, 5, 19), ErrorID = 12, MachineID = 9 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 99, ErrorDate = new DateTime(2020, 11, 9), ErrorID = 3, MachineID = 25 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 100, ErrorDate = new DateTime(2020, 11, 17), ErrorID = 19, MachineID = 8 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 101, ErrorDate = new DateTime(2020, 12, 28), ErrorID = 13, MachineID = 20 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 102, ErrorDate = new DateTime(2020, 1, 29), ErrorID = 11, MachineID = 9 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 103, ErrorDate = new DateTime(2023, 2, 23), ErrorID = 4, MachineID = 11 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 104, ErrorDate = new DateTime(2021, 12, 29), ErrorID = 6, MachineID = 27 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 105, ErrorDate = new DateTime(2021, 3, 23), ErrorID = 6, MachineID = 8 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 106, ErrorDate = new DateTime(2022, 11, 8), ErrorID = 12, MachineID = 2 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 107, ErrorDate = new DateTime(2021, 8, 5), ErrorID = 3, MachineID = 23 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 108, ErrorDate = new DateTime(2021, 1, 27), ErrorID = 11, MachineID = 16 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 109, ErrorDate = new DateTime(2023, 9, 14), ErrorID = 5, MachineID = 35 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 110, ErrorDate = new DateTime(2021, 6, 23), ErrorID = 9, MachineID = 12 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 111, ErrorDate = new DateTime(2020, 7, 30), ErrorID = 15, MachineID = 33 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 112, ErrorDate = new DateTime(2020, 12, 4), ErrorID = 11, MachineID = 6 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 113, ErrorDate = new DateTime(2023, 1, 22), ErrorID = 19, MachineID = 37 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 114, ErrorDate = new DateTime(2024, 4, 14), ErrorID = 15, MachineID = 11 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 115, ErrorDate = new DateTime(2020, 6, 15), ErrorID = 2, MachineID = 21 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 116, ErrorDate = new DateTime(2023, 8, 22), ErrorID = 18, MachineID = 15 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 117, ErrorDate = new DateTime(2024, 3, 16), ErrorID = 7, MachineID = 35 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 118, ErrorDate = new DateTime(2022, 12, 24), ErrorID = 8, MachineID = 20 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 119, ErrorDate = new DateTime(2020, 10, 15), ErrorID = 14, MachineID = 19 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 120, ErrorDate = new DateTime(2024, 3, 5), ErrorID = 5, MachineID = 20 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 121, ErrorDate = new DateTime(2020, 1, 29), ErrorID = 2, MachineID = 3 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 122, ErrorDate = new DateTime(2020, 9, 10), ErrorID = 8, MachineID = 15 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 123, ErrorDate = new DateTime(2023, 11, 8), ErrorID = 17, MachineID = 34 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 124, ErrorDate = new DateTime(2022, 5, 21), ErrorID = 7, MachineID = 10 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 125, ErrorDate = new DateTime(2021, 8, 11), ErrorID = 15, MachineID = 20 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 126, ErrorDate = new DateTime(2020, 7, 13), ErrorID = 4, MachineID = 20 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 127, ErrorDate = new DateTime(2021, 10, 27), ErrorID = 14, MachineID = 1 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 128, ErrorDate = new DateTime(2023, 1, 14), ErrorID = 15, MachineID = 7 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 129, ErrorDate = new DateTime(2022, 4, 11), ErrorID = 12, MachineID = 38 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 130, ErrorDate = new DateTime(2024, 3, 30), ErrorID = 4, MachineID = 17 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 131, ErrorDate = new DateTime(2023, 9, 27), ErrorID = 17, MachineID = 17 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 132, ErrorDate = new DateTime(2020, 8, 23), ErrorID = 18, MachineID = 21 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 133, ErrorDate = new DateTime(2022, 8, 10), ErrorID = 10, MachineID = 28 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 134, ErrorDate = new DateTime(2023, 10, 1), ErrorID = 4, MachineID = 5 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 135, ErrorDate = new DateTime(2024, 1, 27), ErrorID = 19, MachineID = 5 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 136, ErrorDate = new DateTime(2022, 10, 12), ErrorID = 18, MachineID = 33 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 137, ErrorDate = new DateTime(2023, 8, 12), ErrorID = 5, MachineID = 26 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 138, ErrorDate = new DateTime(2020, 1, 16), ErrorID = 2, MachineID = 18 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 139, ErrorDate = new DateTime(2023, 5, 12), ErrorID = 18, MachineID = 18 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 140, ErrorDate = new DateTime(2022, 6, 14), ErrorID = 18, MachineID = 7 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 141, ErrorDate = new DateTime(2020, 11, 7), ErrorID = 8, MachineID = 38 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 142, ErrorDate = new DateTime(2023, 3, 6), ErrorID = 16, MachineID = 15 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 143, ErrorDate = new DateTime(2023, 10, 2), ErrorID = 5, MachineID = 7 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 144, ErrorDate = new DateTime(2020, 12, 6), ErrorID = 2, MachineID = 32 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 145, ErrorDate = new DateTime(2024, 3, 22), ErrorID = 1, MachineID = 4 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 146, ErrorDate = new DateTime(2020, 9, 18), ErrorID = 10, MachineID = 15 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 147, ErrorDate = new DateTime(2023, 10, 1), ErrorID = 18, MachineID = 36 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 148, ErrorDate = new DateTime(2023, 10, 17), ErrorID = 12, MachineID = 29 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 149, ErrorDate = new DateTime(2022, 7, 22), ErrorID = 17, MachineID = 12 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 150, ErrorDate = new DateTime(2020, 1, 12), ErrorID = 13, MachineID = 5 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 151, ErrorDate = new DateTime(2023, 11, 4), ErrorID = 7, MachineID = 23 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 152, ErrorDate = new DateTime(2022, 11, 14), ErrorID = 15, MachineID = 3 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 153, ErrorDate = new DateTime(2023, 11, 15), ErrorID = 10, MachineID = 33 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 154, ErrorDate = new DateTime(2020, 8, 13), ErrorID = 7, MachineID = 27 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 155, ErrorDate = new DateTime(2022, 11, 21), ErrorID = 17, MachineID = 32 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 156, ErrorDate = new DateTime(2023, 5, 25), ErrorID = 12, MachineID = 7 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 157, ErrorDate = new DateTime(2023, 12, 11), ErrorID = 7, MachineID = 2 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 158, ErrorDate = new DateTime(2024, 3, 17), ErrorID = 14, MachineID = 27 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 159, ErrorDate = new DateTime(2021, 9, 14), ErrorID = 7, MachineID = 8 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 160, ErrorDate = new DateTime(2021, 6, 15), ErrorID = 4, MachineID = 18 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 161, ErrorDate = new DateTime(2020, 11, 25), ErrorID = 10, MachineID = 25 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 162, ErrorDate = new DateTime(2023, 1, 23), ErrorID = 11, MachineID = 27 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 163, ErrorDate = new DateTime(2024, 2, 13), ErrorID = 2, MachineID = 34 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 164, ErrorDate = new DateTime(2021, 7, 11), ErrorID = 3, MachineID = 17 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 165, ErrorDate = new DateTime(2021, 1, 14), ErrorID = 19, MachineID = 19 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 166, ErrorDate = new DateTime(2022, 12, 24), ErrorID = 20, MachineID = 14 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 167, ErrorDate = new DateTime(2020, 4, 26), ErrorID = 7, MachineID = 37 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 168, ErrorDate = new DateTime(2020, 6, 1), ErrorID = 6, MachineID = 19 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 169, ErrorDate = new DateTime(2021, 9, 11), ErrorID = 18, MachineID = 14 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 170, ErrorDate = new DateTime(2024, 1, 22), ErrorID = 19, MachineID = 17 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 171, ErrorDate = new DateTime(2021, 1, 5), ErrorID = 18, MachineID = 29 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 172, ErrorDate = new DateTime(2024, 2, 13), ErrorID = 6, MachineID = 7 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 173, ErrorDate = new DateTime(2020, 4, 8), ErrorID = 15, MachineID = 31 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 174, ErrorDate = new DateTime(2023, 9, 5), ErrorID = 1, MachineID = 33 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 175, ErrorDate = new DateTime(2020, 2, 18), ErrorID = 13, MachineID = 32 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 176, ErrorDate = new DateTime(2021, 9, 1), ErrorID = 2, MachineID = 37 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 177, ErrorDate = new DateTime(2023, 3, 21), ErrorID = 16, MachineID = 27 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 178, ErrorDate = new DateTime(2023, 11, 30), ErrorID = 5, MachineID = 32 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 179, ErrorDate = new DateTime(2022, 8, 5), ErrorID = 13, MachineID = 31 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 180, ErrorDate = new DateTime(2022, 11, 18), ErrorID = 19, MachineID = 37 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 181, ErrorDate = new DateTime(2024, 1, 24), ErrorID = 15, MachineID = 6 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 182, ErrorDate = new DateTime(2022, 12, 30), ErrorID = 6, MachineID = 28 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 183, ErrorDate = new DateTime(2023, 4, 26), ErrorID = 2, MachineID = 9 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 184, ErrorDate = new DateTime(2023, 9, 11), ErrorID = 8, MachineID = 2 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 185, ErrorDate = new DateTime(2023, 8, 6), ErrorID = 10, MachineID = 20 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 186, ErrorDate = new DateTime(2021, 11, 11), ErrorID = 20, MachineID = 8 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 187, ErrorDate = new DateTime(2023, 3, 3), ErrorID = 11, MachineID = 7 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 188, ErrorDate = new DateTime(2022, 12, 22), ErrorID = 16, MachineID = 17 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 189, ErrorDate = new DateTime(2022, 11, 22), ErrorID = 14, MachineID = 11 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 190, ErrorDate = new DateTime(2021, 6, 9), ErrorID = 10, MachineID = 36 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 191, ErrorDate = new DateTime(2022, 8, 12), ErrorID = 5, MachineID = 10 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 192, ErrorDate = new DateTime(2022, 11, 10), ErrorID = 17, MachineID = 36 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 193, ErrorDate = new DateTime(2021, 3, 8), ErrorID = 20, MachineID = 19 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 194, ErrorDate = new DateTime(2023, 10, 14), ErrorID = 15, MachineID = 19 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 195, ErrorDate = new DateTime(2021, 12, 1), ErrorID = 7, MachineID = 18 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 196, ErrorDate = new DateTime(2021, 7, 27), ErrorID = 17, MachineID = 7 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 197, ErrorDate = new DateTime(2022, 2, 9), ErrorID = 7, MachineID = 3 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 198, ErrorDate = new DateTime(2020, 2, 26), ErrorID = 13, MachineID = 19 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 199, ErrorDate = new DateTime(2021, 9, 24), ErrorID = 13, MachineID = 27 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 200, ErrorDate = new DateTime(2023, 7, 2), ErrorID = 3, MachineID = 7 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 201, ErrorDate = new DateTime(2020, 2, 5), ErrorID = 20, MachineID = 23 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 202, ErrorDate = new DateTime(2020, 5, 10), ErrorID = 1, MachineID = 2 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 203, ErrorDate = new DateTime(2020, 5, 10), ErrorID = 13, MachineID = 22 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 204, ErrorDate = new DateTime(2024, 2, 14), ErrorID = 1, MachineID = 29 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 205, ErrorDate = new DateTime(2020, 2, 8), ErrorID = 19, MachineID = 14 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 206, ErrorDate = new DateTime(2021, 1, 14), ErrorID = 13, MachineID = 3 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 207, ErrorDate = new DateTime(2022, 8, 13), ErrorID = 17, MachineID = 30 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 208, ErrorDate = new DateTime(2020, 6, 16), ErrorID = 10, MachineID = 2 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 209, ErrorDate = new DateTime(2022, 3, 24), ErrorID = 1, MachineID = 37 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 210, ErrorDate = new DateTime(2024, 5, 4), ErrorID = 8, MachineID = 10 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 211, ErrorDate = new DateTime(2022, 7, 5), ErrorID = 16, MachineID = 31 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 212, ErrorDate = new DateTime(2021, 3, 13), ErrorID = 10, MachineID = 18 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 213, ErrorDate = new DateTime(2020, 4, 29), ErrorID = 10, MachineID = 24 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 214, ErrorDate = new DateTime(2021, 8, 11), ErrorID = 5, MachineID = 14 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 215, ErrorDate = new DateTime(2020, 1, 3), ErrorID = 5, MachineID = 25 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 216, ErrorDate = new DateTime(2022, 11, 12), ErrorID = 9, MachineID = 2 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 217, ErrorDate = new DateTime(2021, 7, 31), ErrorID = 6, MachineID = 5 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 218, ErrorDate = new DateTime(2022, 4, 18), ErrorID = 17, MachineID = 23 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 219, ErrorDate = new DateTime(2020, 3, 7), ErrorID = 17, MachineID = 24 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 220, ErrorDate = new DateTime(2023, 7, 17), ErrorID = 13, MachineID = 22 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 221, ErrorDate = new DateTime(2021, 11, 24), ErrorID = 4, MachineID = 40 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 222, ErrorDate = new DateTime(2023, 5, 10), ErrorID = 14, MachineID = 29 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 223, ErrorDate = new DateTime(2023, 4, 6), ErrorID = 10, MachineID = 26 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 224, ErrorDate = new DateTime(2024, 3, 4), ErrorID = 3, MachineID = 23 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 225, ErrorDate = new DateTime(2022, 2, 23), ErrorID = 15, MachineID = 35 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 226, ErrorDate = new DateTime(2022, 10, 12), ErrorID = 12, MachineID = 15 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 227, ErrorDate = new DateTime(2020, 9, 27), ErrorID = 2, MachineID = 40 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 228, ErrorDate = new DateTime(2023, 12, 8), ErrorID = 3, MachineID = 7 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 229, ErrorDate = new DateTime(2021, 7, 4), ErrorID = 19, MachineID = 35 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 230, ErrorDate = new DateTime(2021, 3, 3), ErrorID = 3, MachineID = 21 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 231, ErrorDate = new DateTime(2022, 3, 8), ErrorID = 12, MachineID = 24 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 232, ErrorDate = new DateTime(2024, 4, 3), ErrorID = 8, MachineID = 22 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 233, ErrorDate = new DateTime(2023, 7, 11), ErrorID = 6, MachineID = 34 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 234, ErrorDate = new DateTime(2023, 10, 4), ErrorID = 1, MachineID = 29 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 235, ErrorDate = new DateTime(2023, 10, 23), ErrorID = 2, MachineID = 34 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 236, ErrorDate = new DateTime(2020, 6, 11), ErrorID = 6, MachineID = 2 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 237, ErrorDate = new DateTime(2021, 3, 7), ErrorID = 14, MachineID = 24 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 238, ErrorDate = new DateTime(2020, 11, 7), ErrorID = 14, MachineID = 9 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 239, ErrorDate = new DateTime(2023, 2, 9), ErrorID = 13, MachineID = 40 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 240, ErrorDate = new DateTime(2023, 8, 26), ErrorID = 8, MachineID = 5 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 241, ErrorDate = new DateTime(2023, 10, 6), ErrorID = 20, MachineID = 22 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 242, ErrorDate = new DateTime(2022, 8, 22), ErrorID = 5, MachineID = 1 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 243, ErrorDate = new DateTime(2023, 10, 8), ErrorID = 13, MachineID = 12 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 244, ErrorDate = new DateTime(2023, 11, 25), ErrorID = 16, MachineID = 37 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 245, ErrorDate = new DateTime(2020, 5, 16), ErrorID = 9, MachineID = 26 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 246, ErrorDate = new DateTime(2023, 12, 30), ErrorID = 18, MachineID = 22 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 247, ErrorDate = new DateTime(2022, 2, 20), ErrorID = 11, MachineID = 10 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 248, ErrorDate = new DateTime(2024, 3, 12), ErrorID = 3, MachineID = 11 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 249, ErrorDate = new DateTime(2020, 7, 2), ErrorID = 11, MachineID = 12 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 250, ErrorDate = new DateTime(2024, 2, 29), ErrorID = 8, MachineID = 22 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 251, ErrorDate = new DateTime(2020, 7, 20), ErrorID = 17, MachineID = 25 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 252, ErrorDate = new DateTime(2021, 5, 17), ErrorID = 9, MachineID = 28 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 253, ErrorDate = new DateTime(2023, 11, 14), ErrorID = 2, MachineID = 12 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 254, ErrorDate = new DateTime(2020, 9, 23), ErrorID = 17, MachineID = 16 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 255, ErrorDate = new DateTime(2022, 3, 22), ErrorID = 11, MachineID = 13 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 256, ErrorDate = new DateTime(2023, 6, 8), ErrorID = 17, MachineID = 9 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 257, ErrorDate = new DateTime(2022, 12, 23), ErrorID = 4, MachineID = 37 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 258, ErrorDate = new DateTime(2024, 1, 7), ErrorID = 5, MachineID = 25 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 259, ErrorDate = new DateTime(2022, 3, 17), ErrorID = 2, MachineID = 24 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 260, ErrorDate = new DateTime(2020, 5, 26), ErrorID = 10, MachineID = 10 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 261, ErrorDate = new DateTime(2020, 1, 25), ErrorID = 6, MachineID = 26 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 262, ErrorDate = new DateTime(2023, 2, 2), ErrorID = 1, MachineID = 6 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 263, ErrorDate = new DateTime(2023, 11, 19), ErrorID = 18, MachineID = 8 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 264, ErrorDate = new DateTime(2021, 10, 16), ErrorID = 17, MachineID = 28 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 265, ErrorDate = new DateTime(2023, 6, 9), ErrorID = 14, MachineID = 15 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 266, ErrorDate = new DateTime(2021, 2, 26), ErrorID = 3, MachineID = 7 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 267, ErrorDate = new DateTime(2023, 11, 21), ErrorID = 3, MachineID = 22 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 268, ErrorDate = new DateTime(2021, 12, 3), ErrorID = 15, MachineID = 40 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 269, ErrorDate = new DateTime(2024, 2, 7), ErrorID = 3, MachineID = 38 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 270, ErrorDate = new DateTime(2020, 11, 17), ErrorID = 12, MachineID = 21 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 271, ErrorDate = new DateTime(2020, 5, 11), ErrorID = 7, MachineID = 15 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 272, ErrorDate = new DateTime(2023, 6, 15), ErrorID = 19, MachineID = 10 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 273, ErrorDate = new DateTime(2020, 10, 28), ErrorID = 1, MachineID = 1 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 274, ErrorDate = new DateTime(2021, 6, 30), ErrorID = 3, MachineID = 19 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 275, ErrorDate = new DateTime(2022, 10, 6), ErrorID = 9, MachineID = 23 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 276, ErrorDate = new DateTime(2022, 11, 24), ErrorID = 7, MachineID = 39 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 277, ErrorDate = new DateTime(2020, 12, 5), ErrorID = 15, MachineID = 32 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 278, ErrorDate = new DateTime(2020, 12, 5), ErrorID = 9, MachineID = 39 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 279, ErrorDate = new DateTime(2020, 4, 21), ErrorID = 5, MachineID = 31 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 280, ErrorDate = new DateTime(2021, 8, 29), ErrorID = 14, MachineID = 25 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 281, ErrorDate = new DateTime(2021, 6, 1), ErrorID = 7, MachineID = 13 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 282, ErrorDate = new DateTime(2022, 12, 18), ErrorID = 14, MachineID = 22 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 283, ErrorDate = new DateTime(2020, 11, 21), ErrorID = 5, MachineID = 23 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 284, ErrorDate = new DateTime(2020, 3, 29), ErrorID = 4, MachineID = 33 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 285, ErrorDate = new DateTime(2022, 4, 21), ErrorID = 13, MachineID = 5 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 286, ErrorDate = new DateTime(2023, 6, 7), ErrorID = 17, MachineID = 2 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 287, ErrorDate = new DateTime(2022, 5, 27), ErrorID = 6, MachineID = 11 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 288, ErrorDate = new DateTime(2021, 1, 16), ErrorID = 14, MachineID = 24 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 289, ErrorDate = new DateTime(2020, 4, 5), ErrorID = 5, MachineID = 13 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 290, ErrorDate = new DateTime(2020, 8, 10), ErrorID = 17, MachineID = 35 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 291, ErrorDate = new DateTime(2021, 5, 9), ErrorID = 20, MachineID = 10 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 292, ErrorDate = new DateTime(2023, 9, 17), ErrorID = 7, MachineID = 4 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 293, ErrorDate = new DateTime(2022, 10, 10), ErrorID = 7, MachineID = 27 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 294, ErrorDate = new DateTime(2020, 3, 22), ErrorID = 18, MachineID = 5 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 295, ErrorDate = new DateTime(2023, 9, 8), ErrorID = 6, MachineID = 30 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 296, ErrorDate = new DateTime(2020, 5, 21), ErrorID = 16, MachineID = 34 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 297, ErrorDate = new DateTime(2020, 7, 9), ErrorID = 10, MachineID = 35 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 298, ErrorDate = new DateTime(2023, 11, 27), ErrorID = 9, MachineID = 18 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 299, ErrorDate = new DateTime(2023, 11, 19), ErrorID = 12, MachineID = 32 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 300, ErrorDate = new DateTime(2021, 3, 1), ErrorID = 10, MachineID = 30 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 301, ErrorDate = new DateTime(2023, 2, 1), ErrorID = 13, MachineID = 32 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 302, ErrorDate = new DateTime(2022, 11, 4), ErrorID = 17, MachineID = 2 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 303, ErrorDate = new DateTime(2022, 11, 4), ErrorID = 12, MachineID = 31 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 304, ErrorDate = new DateTime(2023, 8, 20), ErrorID = 6, MachineID = 28 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 305, ErrorDate = new DateTime(2022, 12, 5), ErrorID = 20, MachineID = 2 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 306, ErrorDate = new DateTime(2022, 11, 25), ErrorID = 20, MachineID = 8 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 307, ErrorDate = new DateTime(2023, 2, 25), ErrorID = 10, MachineID = 22 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 308, ErrorDate = new DateTime(2023, 3, 23), ErrorID = 19, MachineID = 13 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 309, ErrorDate = new DateTime(2021, 2, 25), ErrorID = 2, MachineID = 2 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 310, ErrorDate = new DateTime(2020, 9, 25), ErrorID = 16, MachineID = 26 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 311, ErrorDate = new DateTime(2024, 4, 2), ErrorID = 18, MachineID = 39 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 312, ErrorDate = new DateTime(2022, 2, 5), ErrorID = 17, MachineID = 37 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 313, ErrorDate = new DateTime(2022, 12, 3), ErrorID = 2, MachineID = 23 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 314, ErrorDate = new DateTime(2023, 6, 9), ErrorID = 3, MachineID = 15 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 315, ErrorDate = new DateTime(2022, 6, 24), ErrorID = 15, MachineID = 16 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 316, ErrorDate = new DateTime(2020, 1, 20), ErrorID = 7, MachineID = 2 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 317, ErrorDate = new DateTime(2023, 11, 27), ErrorID = 8, MachineID = 3 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 318, ErrorDate = new DateTime(2022, 11, 2), ErrorID = 17, MachineID = 3 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 319, ErrorDate = new DateTime(2023, 8, 16), ErrorID = 10, MachineID = 19 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 320, ErrorDate = new DateTime(2022, 2, 27), ErrorID = 20, MachineID = 1 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 321, ErrorDate = new DateTime(2023, 9, 3), ErrorID = 20, MachineID = 20 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 322, ErrorDate = new DateTime(2020, 11, 4), ErrorID = 19, MachineID = 17 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 323, ErrorDate = new DateTime(2020, 6, 30), ErrorID = 2, MachineID = 22 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 324, ErrorDate = new DateTime(2022, 11, 9), ErrorID = 17, MachineID = 4 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 325, ErrorDate = new DateTime(2021, 6, 25), ErrorID = 10, MachineID = 19 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 326, ErrorDate = new DateTime(2024, 5, 4), ErrorID = 2, MachineID = 1 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 327, ErrorDate = new DateTime(2022, 3, 21), ErrorID = 15, MachineID = 36 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 328, ErrorDate = new DateTime(2020, 3, 12), ErrorID = 4, MachineID = 12 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 329, ErrorDate = new DateTime(2022, 3, 11), ErrorID = 16, MachineID = 20 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 330, ErrorDate = new DateTime(2021, 5, 19), ErrorID = 4, MachineID = 16 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 331, ErrorDate = new DateTime(2020, 6, 27), ErrorID = 5, MachineID = 24 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 332, ErrorDate = new DateTime(2020, 8, 25), ErrorID = 3, MachineID = 33 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 333, ErrorDate = new DateTime(2022, 8, 16), ErrorID = 15, MachineID = 26 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 334, ErrorDate = new DateTime(2023, 8, 9), ErrorID = 4, MachineID = 35 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 335, ErrorDate = new DateTime(2022, 4, 23), ErrorID = 5, MachineID = 27 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 336, ErrorDate = new DateTime(2022, 11, 27), ErrorID = 2, MachineID = 2 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 337, ErrorDate = new DateTime(2022, 5, 23), ErrorID = 8, MachineID = 17 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 338, ErrorDate = new DateTime(2022, 3, 1), ErrorID = 1, MachineID = 35 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 339, ErrorDate = new DateTime(2022, 1, 19), ErrorID = 15, MachineID = 20 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 340, ErrorDate = new DateTime(2022, 9, 27), ErrorID = 20, MachineID = 10 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 341, ErrorDate = new DateTime(2021, 2, 1), ErrorID = 10, MachineID = 4 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 342, ErrorDate = new DateTime(2020, 1, 27), ErrorID = 1, MachineID = 10 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 343, ErrorDate = new DateTime(2022, 8, 9), ErrorID = 20, MachineID = 3 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 344, ErrorDate = new DateTime(2021, 4, 3), ErrorID = 5, MachineID = 20 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 345, ErrorDate = new DateTime(2021, 5, 15), ErrorID = 10, MachineID = 3 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 346, ErrorDate = new DateTime(2021, 12, 2), ErrorID = 12, MachineID = 10 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 347, ErrorDate = new DateTime(2020, 12, 16), ErrorID = 17, MachineID = 33 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 348, ErrorDate = new DateTime(2023, 12, 22), ErrorID = 7, MachineID = 21 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 349, ErrorDate = new DateTime(2020, 3, 7), ErrorID = 11, MachineID = 12 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 350, ErrorDate = new DateTime(2020, 6, 10), ErrorID = 12, MachineID = 31 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 351, ErrorDate = new DateTime(2020, 8, 6), ErrorID = 12, MachineID = 35 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 352, ErrorDate = new DateTime(2022, 9, 30), ErrorID = 10, MachineID = 10 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 353, ErrorDate = new DateTime(2020, 8, 23), ErrorID = 11, MachineID = 7 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 354, ErrorDate = new DateTime(2023, 3, 18), ErrorID = 15, MachineID = 14 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 355, ErrorDate = new DateTime(2022, 6, 22), ErrorID = 9, MachineID = 31 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 356, ErrorDate = new DateTime(2021, 12, 6), ErrorID = 2, MachineID = 12 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 357, ErrorDate = new DateTime(2022, 2, 22), ErrorID = 2, MachineID = 22 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 358, ErrorDate = new DateTime(2020, 10, 29), ErrorID = 17, MachineID = 8 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 359, ErrorDate = new DateTime(2021, 1, 14), ErrorID = 1, MachineID = 23 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 360, ErrorDate = new DateTime(2022, 1, 14), ErrorID = 12, MachineID = 25 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 361, ErrorDate = new DateTime(2023, 11, 1), ErrorID = 14, MachineID = 6 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 362, ErrorDate = new DateTime(2022, 7, 3), ErrorID = 15, MachineID = 7 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 363, ErrorDate = new DateTime(2022, 4, 14), ErrorID = 5, MachineID = 24 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 364, ErrorDate = new DateTime(2020, 11, 4), ErrorID = 5, MachineID = 26 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 365, ErrorDate = new DateTime(2020, 6, 17), ErrorID = 6, MachineID = 38 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 366, ErrorDate = new DateTime(2020, 6, 8), ErrorID = 18, MachineID = 14 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 367, ErrorDate = new DateTime(2020, 7, 15), ErrorID = 17, MachineID = 35 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 368, ErrorDate = new DateTime(2021, 1, 23), ErrorID = 16, MachineID = 33 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 369, ErrorDate = new DateTime(2022, 7, 10), ErrorID = 2, MachineID = 6 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 370, ErrorDate = new DateTime(2020, 5, 27), ErrorID = 17, MachineID = 8 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 371, ErrorDate = new DateTime(2023, 5, 4), ErrorID = 5, MachineID = 20 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 372, ErrorDate = new DateTime(2023, 4, 24), ErrorID = 5, MachineID = 7 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 373, ErrorDate = new DateTime(2021, 3, 22), ErrorID = 5, MachineID = 33 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 374, ErrorDate = new DateTime(2023, 8, 13), ErrorID = 4, MachineID = 24 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 375, ErrorDate = new DateTime(2021, 10, 25), ErrorID = 8, MachineID = 12 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 376, ErrorDate = new DateTime(2024, 4, 30), ErrorID = 7, MachineID = 40 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 377, ErrorDate = new DateTime(2020, 11, 11), ErrorID = 5, MachineID = 16 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 378, ErrorDate = new DateTime(2020, 3, 2), ErrorID = 15, MachineID = 2 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 379, ErrorDate = new DateTime(2023, 3, 15), ErrorID = 16, MachineID = 37 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 380, ErrorDate = new DateTime(2020, 7, 25), ErrorID = 14, MachineID = 7 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 381, ErrorDate = new DateTime(2020, 11, 28), ErrorID = 5, MachineID = 38 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 382, ErrorDate = new DateTime(2022, 10, 30), ErrorID = 10, MachineID = 12 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 383, ErrorDate = new DateTime(2023, 9, 16), ErrorID = 6, MachineID = 31 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 384, ErrorDate = new DateTime(2022, 10, 27), ErrorID = 11, MachineID = 26 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 385, ErrorDate = new DateTime(2020, 4, 20), ErrorID = 7, MachineID = 36 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 386, ErrorDate = new DateTime(2022, 11, 21), ErrorID = 13, MachineID = 5 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 387, ErrorDate = new DateTime(2020, 8, 12), ErrorID = 20, MachineID = 3 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 388, ErrorDate = new DateTime(2023, 8, 23), ErrorID = 3, MachineID = 29 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 389, ErrorDate = new DateTime(2021, 1, 9), ErrorID = 19, MachineID = 20 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 390, ErrorDate = new DateTime(2021, 6, 17), ErrorID = 11, MachineID = 1 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 391, ErrorDate = new DateTime(2020, 11, 22), ErrorID = 5, MachineID = 9 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 392, ErrorDate = new DateTime(2020, 4, 8), ErrorID = 20, MachineID = 1 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 393, ErrorDate = new DateTime(2021, 7, 1), ErrorID = 17, MachineID = 34 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 394, ErrorDate = new DateTime(2020, 2, 28), ErrorID = 3, MachineID = 9 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 395, ErrorDate = new DateTime(2021, 7, 14), ErrorID = 16, MachineID = 7 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 396, ErrorDate = new DateTime(2022, 6, 10), ErrorID = 18, MachineID = 33 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 397, ErrorDate = new DateTime(2022, 1, 28), ErrorID = 18, MachineID = 34 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 398, ErrorDate = new DateTime(2021, 9, 25), ErrorID = 9, MachineID = 19 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 399, ErrorDate = new DateTime(2022, 6, 12), ErrorID = 20, MachineID = 16 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 400, ErrorDate = new DateTime(2021, 11, 26), ErrorID = 12, MachineID = 2 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 401, ErrorDate = new DateTime(2023, 6, 14), ErrorID = 1, MachineID = 23 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 402, ErrorDate = new DateTime(2020, 9, 18), ErrorID = 8, MachineID = 36 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 403, ErrorDate = new DateTime(2021, 9, 4), ErrorID = 9, MachineID = 16 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 404, ErrorDate = new DateTime(2021, 5, 15), ErrorID = 13, MachineID = 22 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 405, ErrorDate = new DateTime(2023, 2, 8), ErrorID = 2, MachineID = 37 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 406, ErrorDate = new DateTime(2021, 5, 15), ErrorID = 17, MachineID = 28 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 407, ErrorDate = new DateTime(2021, 2, 10), ErrorID = 8, MachineID = 25 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 408, ErrorDate = new DateTime(2024, 3, 6), ErrorID = 15, MachineID = 13 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 409, ErrorDate = new DateTime(2022, 8, 16), ErrorID = 10, MachineID = 30 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 410, ErrorDate = new DateTime(2022, 11, 23), ErrorID = 11, MachineID = 31 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 411, ErrorDate = new DateTime(2021, 10, 19), ErrorID = 19, MachineID = 27 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 412, ErrorDate = new DateTime(2023, 6, 20), ErrorID = 6, MachineID = 4 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 413, ErrorDate = new DateTime(2023, 7, 23), ErrorID = 3, MachineID = 20 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 414, ErrorDate = new DateTime(2020, 5, 7), ErrorID = 19, MachineID = 33 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 415, ErrorDate = new DateTime(2020, 2, 4), ErrorID = 3, MachineID = 21 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 416, ErrorDate = new DateTime(2023, 5, 11), ErrorID = 13, MachineID = 19 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 417, ErrorDate = new DateTime(2020, 4, 15), ErrorID = 16, MachineID = 40 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 418, ErrorDate = new DateTime(2023, 9, 13), ErrorID = 6, MachineID = 20 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 419, ErrorDate = new DateTime(2020, 3, 17), ErrorID = 13, MachineID = 40 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 420, ErrorDate = new DateTime(2022, 7, 29), ErrorID = 1, MachineID = 31 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 421, ErrorDate = new DateTime(2021, 1, 20), ErrorID = 5, MachineID = 18 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 422, ErrorDate = new DateTime(2022, 9, 26), ErrorID = 3, MachineID = 14 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 423, ErrorDate = new DateTime(2021, 1, 26), ErrorID = 1, MachineID = 6 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 424, ErrorDate = new DateTime(2022, 10, 14), ErrorID = 7, MachineID = 1 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 425, ErrorDate = new DateTime(2021, 5, 12), ErrorID = 2, MachineID = 22 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 426, ErrorDate = new DateTime(2021, 11, 14), ErrorID = 13, MachineID = 13 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 427, ErrorDate = new DateTime(2023, 7, 11), ErrorID = 1, MachineID = 29 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 428, ErrorDate = new DateTime(2020, 12, 18), ErrorID = 13, MachineID = 9 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 429, ErrorDate = new DateTime(2021, 6, 30), ErrorID = 17, MachineID = 17 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 430, ErrorDate = new DateTime(2024, 1, 23), ErrorID = 5, MachineID = 34 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 431, ErrorDate = new DateTime(2021, 8, 2), ErrorID = 7, MachineID = 30 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 432, ErrorDate = new DateTime(2024, 3, 6), ErrorID = 7, MachineID = 13 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 433, ErrorDate = new DateTime(2022, 2, 3), ErrorID = 12, MachineID = 4 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 434, ErrorDate = new DateTime(2021, 2, 9), ErrorID = 19, MachineID = 17 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 435, ErrorDate = new DateTime(2022, 5, 4), ErrorID = 16, MachineID = 36 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 436, ErrorDate = new DateTime(2021, 4, 8), ErrorID = 15, MachineID = 1 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 437, ErrorDate = new DateTime(2022, 5, 27), ErrorID = 20, MachineID = 38 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 438, ErrorDate = new DateTime(2023, 7, 16), ErrorID = 12, MachineID = 28 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 439, ErrorDate = new DateTime(2023, 3, 16), ErrorID = 9, MachineID = 34 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 440, ErrorDate = new DateTime(2024, 1, 14), ErrorID = 4, MachineID = 5 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 441, ErrorDate = new DateTime(2024, 2, 19), ErrorID = 18, MachineID = 14 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 442, ErrorDate = new DateTime(2023, 5, 22), ErrorID = 19, MachineID = 14 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 443, ErrorDate = new DateTime(2022, 10, 14), ErrorID = 4, MachineID = 2 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 444, ErrorDate = new DateTime(2020, 12, 20), ErrorID = 19, MachineID = 36 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 445, ErrorDate = new DateTime(2022, 11, 14), ErrorID = 4, MachineID = 28 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 446, ErrorDate = new DateTime(2023, 5, 6), ErrorID = 14, MachineID = 34 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 447, ErrorDate = new DateTime(2022, 8, 25), ErrorID = 10, MachineID = 7 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 448, ErrorDate = new DateTime(2024, 4, 30), ErrorID = 20, MachineID = 20 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 449, ErrorDate = new DateTime(2022, 6, 22), ErrorID = 16, MachineID = 36 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 450, ErrorDate = new DateTime(2020, 9, 11), ErrorID = 11, MachineID = 18 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 451, ErrorDate = new DateTime(2021, 12, 22), ErrorID = 8, MachineID = 11 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 452, ErrorDate = new DateTime(2021, 4, 5), ErrorID = 4, MachineID = 8 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 453, ErrorDate = new DateTime(2023, 4, 4), ErrorID = 16, MachineID = 17 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 454, ErrorDate = new DateTime(2021, 9, 21), ErrorID = 4, MachineID = 7 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 455, ErrorDate = new DateTime(2024, 3, 1), ErrorID = 13, MachineID = 7 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 456, ErrorDate = new DateTime(2024, 5, 3), ErrorID = 8, MachineID = 17 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 457, ErrorDate = new DateTime(2024, 3, 18), ErrorID = 19, MachineID = 7 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 458, ErrorDate = new DateTime(2020, 9, 25), ErrorID = 19, MachineID = 1 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 459, ErrorDate = new DateTime(2020, 7, 6), ErrorID = 1, MachineID = 8 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 460, ErrorDate = new DateTime(2024, 3, 19), ErrorID = 14, MachineID = 36 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 461, ErrorDate = new DateTime(2022, 4, 14), ErrorID = 14, MachineID = 2 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 462, ErrorDate = new DateTime(2020, 9, 11), ErrorID = 14, MachineID = 24 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 463, ErrorDate = new DateTime(2021, 6, 19), ErrorID = 8, MachineID = 18 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 464, ErrorDate = new DateTime(2022, 5, 6), ErrorID = 1, MachineID = 4 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 465, ErrorDate = new DateTime(2021, 11, 10), ErrorID = 16, MachineID = 37 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 466, ErrorDate = new DateTime(2021, 7, 23), ErrorID = 7, MachineID = 17 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 467, ErrorDate = new DateTime(2023, 1, 18), ErrorID = 1, MachineID = 39 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 468, ErrorDate = new DateTime(2023, 8, 30), ErrorID = 20, MachineID = 31 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 469, ErrorDate = new DateTime(2020, 5, 9), ErrorID = 15, MachineID = 19 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 470, ErrorDate = new DateTime(2022, 8, 24), ErrorID = 5, MachineID = 8 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 471, ErrorDate = new DateTime(2020, 2, 1), ErrorID = 17, MachineID = 33 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 472, ErrorDate = new DateTime(2022, 3, 28), ErrorID = 10, MachineID = 6 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 473, ErrorDate = new DateTime(2023, 9, 16), ErrorID = 15, MachineID = 2 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 474, ErrorDate = new DateTime(2020, 8, 4), ErrorID = 6, MachineID = 22 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 475, ErrorDate = new DateTime(2022, 4, 20), ErrorID = 14, MachineID = 1 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 476, ErrorDate = new DateTime(2022, 3, 18), ErrorID = 20, MachineID = 16 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 477, ErrorDate = new DateTime(2021, 7, 22), ErrorID = 17, MachineID = 18 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 478, ErrorDate = new DateTime(2021, 4, 17), ErrorID = 10, MachineID = 38 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 479, ErrorDate = new DateTime(2020, 3, 31), ErrorID = 11, MachineID = 34 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 480, ErrorDate = new DateTime(2023, 10, 22), ErrorID = 9, MachineID = 36 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 481, ErrorDate = new DateTime(2023, 9, 1), ErrorID = 16, MachineID = 13 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 482, ErrorDate = new DateTime(2022, 12, 19), ErrorID = 18, MachineID = 22 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 483, ErrorDate = new DateTime(2023, 12, 21), ErrorID = 20, MachineID = 31 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 484, ErrorDate = new DateTime(2021, 4, 8), ErrorID = 14, MachineID = 33 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 485, ErrorDate = new DateTime(2023, 7, 26), ErrorID = 6, MachineID = 14 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 486, ErrorDate = new DateTime(2024, 5, 5), ErrorID = 10, MachineID = 26 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 487, ErrorDate = new DateTime(2020, 3, 19), ErrorID = 8, MachineID = 24 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 488, ErrorDate = new DateTime(2020, 1, 12), ErrorID = 7, MachineID = 16 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 489, ErrorDate = new DateTime(2024, 1, 15), ErrorID = 8, MachineID = 30 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 490, ErrorDate = new DateTime(2023, 11, 28), ErrorID = 18, MachineID = 7 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 491, ErrorDate = new DateTime(2023, 4, 3), ErrorID = 8, MachineID = 3 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 492, ErrorDate = new DateTime(2023, 1, 3), ErrorID = 1, MachineID = 17 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 493, ErrorDate = new DateTime(2020, 7, 14), ErrorID = 19, MachineID = 1 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 494, ErrorDate = new DateTime(2024, 4, 12), ErrorID = 16, MachineID = 28 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 495, ErrorDate = new DateTime(2023, 3, 25), ErrorID = 18, MachineID = 27 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 496, ErrorDate = new DateTime(2021, 5, 22), ErrorID = 5, MachineID = 1 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 497, ErrorDate = new DateTime(2021, 10, 8), ErrorID = 18, MachineID = 3 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 498, ErrorDate = new DateTime(2023, 6, 10), ErrorID = 8, MachineID = 30 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 499, ErrorDate = new DateTime(2022, 12, 14), ErrorID = 20, MachineID = 18 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 500, ErrorDate = new DateTime(2023, 8, 30), ErrorID = 10, MachineID = 11 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 501, ErrorDate = new DateTime(2023, 5, 7), ErrorID = 18, MachineID = 23 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 502, ErrorDate = new DateTime(2021, 11, 21), ErrorID = 14, MachineID = 38 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 503, ErrorDate = new DateTime(2023, 4, 20), ErrorID = 4, MachineID = 3 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 504, ErrorDate = new DateTime(2024, 1, 25), ErrorID = 3, MachineID = 5 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 505, ErrorDate = new DateTime(2021, 10, 13), ErrorID = 8, MachineID = 10 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 506, ErrorDate = new DateTime(2024, 3, 29), ErrorID = 6, MachineID = 14 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 507, ErrorDate = new DateTime(2023, 6, 14), ErrorID = 1, MachineID = 8 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 508, ErrorDate = new DateTime(2021, 12, 11), ErrorID = 8, MachineID = 27 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 509, ErrorDate = new DateTime(2020, 4, 23), ErrorID = 4, MachineID = 8 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 510, ErrorDate = new DateTime(2021, 3, 11), ErrorID = 6, MachineID = 24 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 511, ErrorDate = new DateTime(2020, 3, 26), ErrorID = 2, MachineID = 31 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 512, ErrorDate = new DateTime(2022, 6, 26), ErrorID = 12, MachineID = 13 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 513, ErrorDate = new DateTime(2020, 6, 19), ErrorID = 3, MachineID = 5 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 514, ErrorDate = new DateTime(2021, 1, 17), ErrorID = 2, MachineID = 20 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 515, ErrorDate = new DateTime(2020, 4, 6), ErrorID = 17, MachineID = 29 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 516, ErrorDate = new DateTime(2024, 2, 2), ErrorID = 14, MachineID = 4 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 517, ErrorDate = new DateTime(2023, 10, 11), ErrorID = 3, MachineID = 6 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 518, ErrorDate = new DateTime(2024, 4, 26), ErrorID = 17, MachineID = 14 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 519, ErrorDate = new DateTime(2024, 1, 21), ErrorID = 10, MachineID = 13 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 520, ErrorDate = new DateTime(2024, 3, 27), ErrorID = 18, MachineID = 39 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 521, ErrorDate = new DateTime(2020, 9, 28), ErrorID = 17, MachineID = 39 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 522, ErrorDate = new DateTime(2021, 5, 20), ErrorID = 10, MachineID = 36 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 523, ErrorDate = new DateTime(2024, 2, 3), ErrorID = 13, MachineID = 8 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 524, ErrorDate = new DateTime(2023, 10, 13), ErrorID = 11, MachineID = 24 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 525, ErrorDate = new DateTime(2023, 9, 8), ErrorID = 19, MachineID = 20 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 526, ErrorDate = new DateTime(2021, 1, 24), ErrorID = 8, MachineID = 19 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 527, ErrorDate = new DateTime(2023, 2, 6), ErrorID = 9, MachineID = 9 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 528, ErrorDate = new DateTime(2022, 5, 18), ErrorID = 17, MachineID = 34 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 529, ErrorDate = new DateTime(2023, 12, 31), ErrorID = 6, MachineID = 28 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 530, ErrorDate = new DateTime(2021, 5, 15), ErrorID = 16, MachineID = 28 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 531, ErrorDate = new DateTime(2024, 1, 2), ErrorID = 6, MachineID = 37 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 532, ErrorDate = new DateTime(2023, 2, 9), ErrorID = 19, MachineID = 39 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 533, ErrorDate = new DateTime(2021, 10, 28), ErrorID = 6, MachineID = 20 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 534, ErrorDate = new DateTime(2021, 2, 24), ErrorID = 10, MachineID = 27 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 535, ErrorDate = new DateTime(2021, 6, 27), ErrorID = 7, MachineID = 19 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 536, ErrorDate = new DateTime(2024, 4, 28), ErrorID = 11, MachineID = 31 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 537, ErrorDate = new DateTime(2023, 5, 6), ErrorID = 20, MachineID = 34 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 538, ErrorDate = new DateTime(2022, 1, 9), ErrorID = 15, MachineID = 12 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 539, ErrorDate = new DateTime(2023, 11, 4), ErrorID = 6, MachineID = 15 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 540, ErrorDate = new DateTime(2022, 11, 7), ErrorID = 4, MachineID = 3 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 541, ErrorDate = new DateTime(2022, 1, 1), ErrorID = 17, MachineID = 14 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 542, ErrorDate = new DateTime(2021, 11, 23), ErrorID = 5, MachineID = 17 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 543, ErrorDate = new DateTime(2022, 7, 15), ErrorID = 14, MachineID = 7 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 544, ErrorDate = new DateTime(2020, 8, 17), ErrorID = 9, MachineID = 11 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 545, ErrorDate = new DateTime(2023, 11, 11), ErrorID = 8, MachineID = 10 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 546, ErrorDate = new DateTime(2020, 7, 26), ErrorID = 2, MachineID = 40 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 547, ErrorDate = new DateTime(2022, 5, 26), ErrorID = 17, MachineID = 16 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 548, ErrorDate = new DateTime(2020, 1, 21), ErrorID = 15, MachineID = 18 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 549, ErrorDate = new DateTime(2021, 11, 10), ErrorID = 3, MachineID = 36 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 550, ErrorDate = new DateTime(2022, 4, 16), ErrorID = 1, MachineID = 23 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 551, ErrorDate = new DateTime(2022, 7, 16), ErrorID = 18, MachineID = 11 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 552, ErrorDate = new DateTime(2021, 2, 11), ErrorID = 6, MachineID = 28 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 553, ErrorDate = new DateTime(2020, 11, 27), ErrorID = 12, MachineID = 36 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 554, ErrorDate = new DateTime(2020, 12, 26), ErrorID = 20, MachineID = 27 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 555, ErrorDate = new DateTime(2021, 12, 15), ErrorID = 5, MachineID = 11 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 556, ErrorDate = new DateTime(2021, 7, 16), ErrorID = 7, MachineID = 3 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 557, ErrorDate = new DateTime(2022, 8, 27), ErrorID = 4, MachineID = 24 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 558, ErrorDate = new DateTime(2021, 10, 17), ErrorID = 6, MachineID = 16 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 559, ErrorDate = new DateTime(2023, 12, 5), ErrorID = 2, MachineID = 34 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 560, ErrorDate = new DateTime(2022, 2, 7), ErrorID = 3, MachineID = 9 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 561, ErrorDate = new DateTime(2020, 10, 15), ErrorID = 15, MachineID = 29 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 562, ErrorDate = new DateTime(2022, 3, 18), ErrorID = 19, MachineID = 13 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 563, ErrorDate = new DateTime(2020, 5, 27), ErrorID = 17, MachineID = 36 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 564, ErrorDate = new DateTime(2022, 3, 18), ErrorID = 18, MachineID = 27 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 565, ErrorDate = new DateTime(2022, 5, 25), ErrorID = 6, MachineID = 26 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 566, ErrorDate = new DateTime(2021, 6, 15), ErrorID = 6, MachineID = 2 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 567, ErrorDate = new DateTime(2021, 7, 14), ErrorID = 4, MachineID = 16 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 568, ErrorDate = new DateTime(2021, 5, 7), ErrorID = 9, MachineID = 7 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 569, ErrorDate = new DateTime(2024, 1, 6), ErrorID = 6, MachineID = 32 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 570, ErrorDate = new DateTime(2021, 8, 14), ErrorID = 6, MachineID = 13 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 571, ErrorDate = new DateTime(2021, 7, 26), ErrorID = 11, MachineID = 21 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 572, ErrorDate = new DateTime(2024, 3, 12), ErrorID = 12, MachineID = 36 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 573, ErrorDate = new DateTime(2023, 11, 15), ErrorID = 8, MachineID = 5 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 574, ErrorDate = new DateTime(2024, 4, 14), ErrorID = 4, MachineID = 21 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 575, ErrorDate = new DateTime(2020, 11, 23), ErrorID = 20, MachineID = 36 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 576, ErrorDate = new DateTime(2020, 6, 4), ErrorID = 16, MachineID = 26 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 577, ErrorDate = new DateTime(2022, 10, 27), ErrorID = 4, MachineID = 28 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 578, ErrorDate = new DateTime(2020, 7, 8), ErrorID = 1, MachineID = 28 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 579, ErrorDate = new DateTime(2021, 2, 20), ErrorID = 1, MachineID = 24 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 580, ErrorDate = new DateTime(2021, 10, 11), ErrorID = 16, MachineID = 40 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 581, ErrorDate = new DateTime(2020, 9, 27), ErrorID = 15, MachineID = 26 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 582, ErrorDate = new DateTime(2024, 4, 24), ErrorID = 3, MachineID = 12 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 583, ErrorDate = new DateTime(2022, 9, 26), ErrorID = 15, MachineID = 1 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 584, ErrorDate = new DateTime(2020, 6, 13), ErrorID = 20, MachineID = 21 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 585, ErrorDate = new DateTime(2022, 4, 13), ErrorID = 4, MachineID = 39 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 586, ErrorDate = new DateTime(2023, 9, 5), ErrorID = 10, MachineID = 27 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 587, ErrorDate = new DateTime(2022, 5, 22), ErrorID = 14, MachineID = 16 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 588, ErrorDate = new DateTime(2021, 8, 4), ErrorID = 7, MachineID = 24 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 589, ErrorDate = new DateTime(2021, 7, 3), ErrorID = 15, MachineID = 35 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 590, ErrorDate = new DateTime(2022, 6, 24), ErrorID = 3, MachineID = 4 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 591, ErrorDate = new DateTime(2021, 10, 12), ErrorID = 12, MachineID = 25 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 592, ErrorDate = new DateTime(2022, 7, 1), ErrorID = 3, MachineID = 3 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 593, ErrorDate = new DateTime(2021, 7, 28), ErrorID = 12, MachineID = 20 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 594, ErrorDate = new DateTime(2021, 9, 12), ErrorID = 8, MachineID = 10 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 595, ErrorDate = new DateTime(2023, 11, 6), ErrorID = 20, MachineID = 4 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 596, ErrorDate = new DateTime(2020, 12, 15), ErrorID = 19, MachineID = 28 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 597, ErrorDate = new DateTime(2020, 4, 2), ErrorID = 17, MachineID = 33 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 598, ErrorDate = new DateTime(2021, 11, 5), ErrorID = 5, MachineID = 7 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 599, ErrorDate = new DateTime(2021, 4, 23), ErrorID = 12, MachineID = 37 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 600, ErrorDate = new DateTime(2023, 6, 14), ErrorID = 6, MachineID = 9 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 601, ErrorDate = new DateTime(2023, 4, 25), ErrorID = 19, MachineID = 24 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 602, ErrorDate = new DateTime(2020, 1, 11), ErrorID = 9, MachineID = 31 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 603, ErrorDate = new DateTime(2022, 4, 15), ErrorID = 17, MachineID = 40 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 604, ErrorDate = new DateTime(2020, 4, 4), ErrorID = 4, MachineID = 37 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 605, ErrorDate = new DateTime(2023, 11, 15), ErrorID = 18, MachineID = 19 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 606, ErrorDate = new DateTime(2020, 10, 24), ErrorID = 11, MachineID = 7 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 607, ErrorDate = new DateTime(2022, 7, 27), ErrorID = 12, MachineID = 26 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 608, ErrorDate = new DateTime(2020, 9, 30), ErrorID = 5, MachineID = 30 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 609, ErrorDate = new DateTime(2022, 10, 14), ErrorID = 5, MachineID = 9 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 610, ErrorDate = new DateTime(2023, 1, 7), ErrorID = 15, MachineID = 25 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 611, ErrorDate = new DateTime(2023, 2, 19), ErrorID = 17, MachineID = 37 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 612, ErrorDate = new DateTime(2020, 7, 2), ErrorID = 6, MachineID = 29 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 613, ErrorDate = new DateTime(2020, 10, 13), ErrorID = 10, MachineID = 40 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 614, ErrorDate = new DateTime(2024, 1, 28), ErrorID = 4, MachineID = 36 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 615, ErrorDate = new DateTime(2023, 1, 21), ErrorID = 10, MachineID = 32 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 616, ErrorDate = new DateTime(2023, 5, 12), ErrorID = 7, MachineID = 39 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 617, ErrorDate = new DateTime(2021, 1, 21), ErrorID = 9, MachineID = 10 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 618, ErrorDate = new DateTime(2021, 8, 13), ErrorID = 7, MachineID = 17 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 619, ErrorDate = new DateTime(2021, 4, 10), ErrorID = 1, MachineID = 33 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 620, ErrorDate = new DateTime(2023, 5, 5), ErrorID = 8, MachineID = 11 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 621, ErrorDate = new DateTime(2020, 6, 11), ErrorID = 16, MachineID = 34 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 622, ErrorDate = new DateTime(2022, 9, 8), ErrorID = 19, MachineID = 29 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 623, ErrorDate = new DateTime(2024, 1, 9), ErrorID = 12, MachineID = 27 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 624, ErrorDate = new DateTime(2023, 10, 10), ErrorID = 5, MachineID = 40 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 625, ErrorDate = new DateTime(2020, 4, 29), ErrorID = 6, MachineID = 39 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 626, ErrorDate = new DateTime(2021, 4, 8), ErrorID = 2, MachineID = 21 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 627, ErrorDate = new DateTime(2020, 5, 28), ErrorID = 12, MachineID = 9 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 628, ErrorDate = new DateTime(2021, 8, 12), ErrorID = 17, MachineID = 27 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 629, ErrorDate = new DateTime(2020, 5, 31), ErrorID = 3, MachineID = 23 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 630, ErrorDate = new DateTime(2021, 9, 1), ErrorID = 8, MachineID = 5 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 631, ErrorDate = new DateTime(2022, 7, 30), ErrorID = 5, MachineID = 16 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 632, ErrorDate = new DateTime(2021, 9, 11), ErrorID = 9, MachineID = 18 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 633, ErrorDate = new DateTime(2021, 8, 17), ErrorID = 17, MachineID = 10 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 634, ErrorDate = new DateTime(2021, 9, 30), ErrorID = 2, MachineID = 25 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 635, ErrorDate = new DateTime(2021, 5, 7), ErrorID = 1, MachineID = 40 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 636, ErrorDate = new DateTime(2021, 7, 21), ErrorID = 13, MachineID = 16 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 637, ErrorDate = new DateTime(2023, 9, 28), ErrorID = 15, MachineID = 20 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 638, ErrorDate = new DateTime(2020, 11, 9), ErrorID = 19, MachineID = 27 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 639, ErrorDate = new DateTime(2021, 5, 8), ErrorID = 16, MachineID = 12 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 640, ErrorDate = new DateTime(2021, 9, 13), ErrorID = 10, MachineID = 9 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 641, ErrorDate = new DateTime(2020, 2, 10), ErrorID = 9, MachineID = 32 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 642, ErrorDate = new DateTime(2022, 6, 6), ErrorID = 5, MachineID = 27 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 643, ErrorDate = new DateTime(2023, 7, 16), ErrorID = 2, MachineID = 33 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 644, ErrorDate = new DateTime(2021, 9, 22), ErrorID = 9, MachineID = 26 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 645, ErrorDate = new DateTime(2022, 1, 23), ErrorID = 12, MachineID = 18 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 646, ErrorDate = new DateTime(2020, 12, 1), ErrorID = 12, MachineID = 21 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 647, ErrorDate = new DateTime(2020, 3, 8), ErrorID = 1, MachineID = 23 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 648, ErrorDate = new DateTime(2023, 11, 11), ErrorID = 11, MachineID = 25 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 649, ErrorDate = new DateTime(2020, 3, 29), ErrorID = 6, MachineID = 35 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 650, ErrorDate = new DateTime(2023, 5, 30), ErrorID = 8, MachineID = 28 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 651, ErrorDate = new DateTime(2020, 1, 25), ErrorID = 4, MachineID = 2 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 652, ErrorDate = new DateTime(2022, 7, 4), ErrorID = 3, MachineID = 3 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 653, ErrorDate = new DateTime(2021, 8, 12), ErrorID = 1, MachineID = 40 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 654, ErrorDate = new DateTime(2023, 3, 30), ErrorID = 11, MachineID = 12 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 655, ErrorDate = new DateTime(2020, 9, 7), ErrorID = 2, MachineID = 9 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 656, ErrorDate = new DateTime(2022, 12, 24), ErrorID = 15, MachineID = 2 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 657, ErrorDate = new DateTime(2020, 7, 8), ErrorID = 12, MachineID = 37 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 658, ErrorDate = new DateTime(2024, 3, 27), ErrorID = 8, MachineID = 34 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 659, ErrorDate = new DateTime(2024, 1, 5), ErrorID = 9, MachineID = 26 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 660, ErrorDate = new DateTime(2023, 8, 17), ErrorID = 3, MachineID = 15 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 661, ErrorDate = new DateTime(2021, 1, 3), ErrorID = 8, MachineID = 2 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 662, ErrorDate = new DateTime(2023, 12, 18), ErrorID = 17, MachineID = 29 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 663, ErrorDate = new DateTime(2023, 4, 17), ErrorID = 6, MachineID = 10 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 664, ErrorDate = new DateTime(2020, 3, 20), ErrorID = 17, MachineID = 4 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 665, ErrorDate = new DateTime(2022, 8, 8), ErrorID = 18, MachineID = 9 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 666, ErrorDate = new DateTime(2023, 4, 10), ErrorID = 15, MachineID = 37 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 667, ErrorDate = new DateTime(2021, 9, 12), ErrorID = 20, MachineID = 7 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 668, ErrorDate = new DateTime(2020, 9, 5), ErrorID = 2, MachineID = 13 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 669, ErrorDate = new DateTime(2020, 2, 19), ErrorID = 15, MachineID = 34 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 670, ErrorDate = new DateTime(2020, 9, 18), ErrorID = 17, MachineID = 21 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 671, ErrorDate = new DateTime(2023, 10, 10), ErrorID = 16, MachineID = 17 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 672, ErrorDate = new DateTime(2021, 7, 14), ErrorID = 11, MachineID = 19 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 673, ErrorDate = new DateTime(2021, 1, 4), ErrorID = 9, MachineID = 26 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 674, ErrorDate = new DateTime(2021, 8, 28), ErrorID = 13, MachineID = 17 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 675, ErrorDate = new DateTime(2023, 2, 8), ErrorID = 1, MachineID = 10 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 676, ErrorDate = new DateTime(2021, 2, 3), ErrorID = 14, MachineID = 12 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 677, ErrorDate = new DateTime(2023, 5, 7), ErrorID = 15, MachineID = 20 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 678, ErrorDate = new DateTime(2021, 8, 7), ErrorID = 12, MachineID = 21 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 679, ErrorDate = new DateTime(2021, 6, 12), ErrorID = 7, MachineID = 17 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 680, ErrorDate = new DateTime(2020, 3, 5), ErrorID = 17, MachineID = 28 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 681, ErrorDate = new DateTime(2021, 9, 25), ErrorID = 6, MachineID = 34 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 682, ErrorDate = new DateTime(2023, 12, 19), ErrorID = 19, MachineID = 23 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 683, ErrorDate = new DateTime(2020, 5, 15), ErrorID = 4, MachineID = 6 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 684, ErrorDate = new DateTime(2023, 2, 11), ErrorID = 13, MachineID = 32 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 685, ErrorDate = new DateTime(2022, 12, 3), ErrorID = 7, MachineID = 33 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 686, ErrorDate = new DateTime(2020, 8, 22), ErrorID = 10, MachineID = 26 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 687, ErrorDate = new DateTime(2022, 2, 3), ErrorID = 8, MachineID = 30 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 688, ErrorDate = new DateTime(2022, 5, 3), ErrorID = 1, MachineID = 29 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 689, ErrorDate = new DateTime(2022, 1, 4), ErrorID = 8, MachineID = 22 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 690, ErrorDate = new DateTime(2020, 1, 17), ErrorID = 15, MachineID = 38 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 691, ErrorDate = new DateTime(2022, 6, 19), ErrorID = 1, MachineID = 31 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 692, ErrorDate = new DateTime(2023, 12, 10), ErrorID = 10, MachineID = 34 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 693, ErrorDate = new DateTime(2023, 8, 26), ErrorID = 15, MachineID = 34 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 694, ErrorDate = new DateTime(2022, 7, 17), ErrorID = 16, MachineID = 29 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 695, ErrorDate = new DateTime(2023, 12, 25), ErrorID = 13, MachineID = 38 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 696, ErrorDate = new DateTime(2024, 3, 14), ErrorID = 17, MachineID = 14 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 697, ErrorDate = new DateTime(2023, 8, 7), ErrorID = 16, MachineID = 40 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 698, ErrorDate = new DateTime(2020, 6, 4), ErrorID = 12, MachineID = 25 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 699, ErrorDate = new DateTime(2022, 7, 10), ErrorID = 4, MachineID = 27 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 700, ErrorDate = new DateTime(2020, 1, 31), ErrorID = 13, MachineID = 30 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 701, ErrorDate = new DateTime(2022, 11, 25), ErrorID = 11, MachineID = 21 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 702, ErrorDate = new DateTime(2022, 6, 19), ErrorID = 16, MachineID = 36 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 703, ErrorDate = new DateTime(2024, 4, 23), ErrorID = 3, MachineID = 12 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 704, ErrorDate = new DateTime(2023, 5, 14), ErrorID = 12, MachineID = 14 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 705, ErrorDate = new DateTime(2022, 7, 13), ErrorID = 10, MachineID = 16 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 706, ErrorDate = new DateTime(2023, 6, 2), ErrorID = 10, MachineID = 8 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 707, ErrorDate = new DateTime(2020, 5, 12), ErrorID = 13, MachineID = 11 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 708, ErrorDate = new DateTime(2020, 6, 20), ErrorID = 15, MachineID = 24 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 709, ErrorDate = new DateTime(2022, 3, 19), ErrorID = 11, MachineID = 16 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 710, ErrorDate = new DateTime(2021, 6, 1), ErrorID = 4, MachineID = 5 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 711, ErrorDate = new DateTime(2023, 7, 16), ErrorID = 17, MachineID = 14 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 712, ErrorDate = new DateTime(2022, 10, 17), ErrorID = 3, MachineID = 1 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 713, ErrorDate = new DateTime(2023, 11, 3), ErrorID = 19, MachineID = 38 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 714, ErrorDate = new DateTime(2023, 3, 16), ErrorID = 6, MachineID = 34 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 715, ErrorDate = new DateTime(2023, 12, 23), ErrorID = 19, MachineID = 14 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 716, ErrorDate = new DateTime(2020, 3, 11), ErrorID = 14, MachineID = 2 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 717, ErrorDate = new DateTime(2021, 9, 6), ErrorID = 12, MachineID = 14 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 718, ErrorDate = new DateTime(2024, 4, 8), ErrorID = 3, MachineID = 17 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 719, ErrorDate = new DateTime(2023, 9, 22), ErrorID = 19, MachineID = 19 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 720, ErrorDate = new DateTime(2021, 4, 13), ErrorID = 20, MachineID = 4 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 721, ErrorDate = new DateTime(2022, 2, 15), ErrorID = 3, MachineID = 11 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 722, ErrorDate = new DateTime(2021, 9, 16), ErrorID = 9, MachineID = 12 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 723, ErrorDate = new DateTime(2020, 1, 26), ErrorID = 9, MachineID = 8 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 724, ErrorDate = new DateTime(2022, 10, 7), ErrorID = 2, MachineID = 33 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 725, ErrorDate = new DateTime(2023, 3, 30), ErrorID = 11, MachineID = 11 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 726, ErrorDate = new DateTime(2020, 8, 5), ErrorID = 20, MachineID = 6 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 727, ErrorDate = new DateTime(2022, 3, 23), ErrorID = 3, MachineID = 17 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 728, ErrorDate = new DateTime(2020, 3, 31), ErrorID = 8, MachineID = 39 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 729, ErrorDate = new DateTime(2020, 4, 5), ErrorID = 9, MachineID = 23 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 730, ErrorDate = new DateTime(2021, 2, 3), ErrorID = 11, MachineID = 21 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 731, ErrorDate = new DateTime(2021, 12, 22), ErrorID = 11, MachineID = 10 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 732, ErrorDate = new DateTime(2021, 10, 9), ErrorID = 2, MachineID = 27 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 733, ErrorDate = new DateTime(2022, 4, 29), ErrorID = 1, MachineID = 36 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 734, ErrorDate = new DateTime(2023, 7, 1), ErrorID = 20, MachineID = 7 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 735, ErrorDate = new DateTime(2020, 9, 19), ErrorID = 8, MachineID = 33 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 736, ErrorDate = new DateTime(2021, 3, 30), ErrorID = 14, MachineID = 35 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 737, ErrorDate = new DateTime(2020, 8, 13), ErrorID = 5, MachineID = 19 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 738, ErrorDate = new DateTime(2022, 8, 26), ErrorID = 14, MachineID = 16 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 739, ErrorDate = new DateTime(2022, 3, 17), ErrorID = 2, MachineID = 10 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 740, ErrorDate = new DateTime(2023, 5, 13), ErrorID = 10, MachineID = 30 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 741, ErrorDate = new DateTime(2020, 7, 15), ErrorID = 10, MachineID = 36 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 742, ErrorDate = new DateTime(2021, 2, 25), ErrorID = 1, MachineID = 20 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 743, ErrorDate = new DateTime(2022, 9, 18), ErrorID = 18, MachineID = 40 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 744, ErrorDate = new DateTime(2020, 3, 14), ErrorID = 10, MachineID = 8 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 745, ErrorDate = new DateTime(2024, 3, 18), ErrorID = 14, MachineID = 5 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 746, ErrorDate = new DateTime(2024, 2, 25), ErrorID = 9, MachineID = 27 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 747, ErrorDate = new DateTime(2020, 12, 4), ErrorID = 19, MachineID = 34 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 748, ErrorDate = new DateTime(2022, 8, 15), ErrorID = 4, MachineID = 23 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 749, ErrorDate = new DateTime(2023, 8, 21), ErrorID = 4, MachineID = 26 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 750, ErrorDate = new DateTime(2022, 8, 8), ErrorID = 20, MachineID = 10 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 751, ErrorDate = new DateTime(2024, 4, 18), ErrorID = 15, MachineID = 6 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 752, ErrorDate = new DateTime(2022, 8, 25), ErrorID = 7, MachineID = 17 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 753, ErrorDate = new DateTime(2022, 2, 2), ErrorID = 10, MachineID = 29 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 754, ErrorDate = new DateTime(2021, 10, 31), ErrorID = 9, MachineID = 6 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 755, ErrorDate = new DateTime(2020, 7, 20), ErrorID = 11, MachineID = 20 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 756, ErrorDate = new DateTime(2021, 9, 18), ErrorID = 8, MachineID = 12 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 757, ErrorDate = new DateTime(2020, 7, 12), ErrorID = 2, MachineID = 31 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 758, ErrorDate = new DateTime(2024, 4, 7), ErrorID = 5, MachineID = 31 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 759, ErrorDate = new DateTime(2021, 3, 15), ErrorID = 7, MachineID = 17 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 760, ErrorDate = new DateTime(2022, 12, 28), ErrorID = 3, MachineID = 1 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 761, ErrorDate = new DateTime(2020, 11, 7), ErrorID = 20, MachineID = 14 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 762, ErrorDate = new DateTime(2024, 4, 26), ErrorID = 7, MachineID = 24 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 763, ErrorDate = new DateTime(2020, 12, 30), ErrorID = 4, MachineID = 31 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 764, ErrorDate = new DateTime(2022, 7, 4), ErrorID = 3, MachineID = 31 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 765, ErrorDate = new DateTime(2022, 8, 9), ErrorID = 7, MachineID = 1 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 766, ErrorDate = new DateTime(2020, 3, 1), ErrorID = 12, MachineID = 38 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 767, ErrorDate = new DateTime(2021, 10, 18), ErrorID = 18, MachineID = 39 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 768, ErrorDate = new DateTime(2022, 1, 26), ErrorID = 6, MachineID = 16 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 769, ErrorDate = new DateTime(2023, 8, 31), ErrorID = 2, MachineID = 35 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 770, ErrorDate = new DateTime(2021, 9, 14), ErrorID = 13, MachineID = 1 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 771, ErrorDate = new DateTime(2020, 11, 10), ErrorID = 16, MachineID = 36 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 772, ErrorDate = new DateTime(2022, 10, 19), ErrorID = 8, MachineID = 21 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 773, ErrorDate = new DateTime(2022, 6, 6), ErrorID = 1, MachineID = 12 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 774, ErrorDate = new DateTime(2023, 5, 29), ErrorID = 15, MachineID = 33 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 775, ErrorDate = new DateTime(2021, 9, 25), ErrorID = 9, MachineID = 40 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 776, ErrorDate = new DateTime(2023, 11, 6), ErrorID = 10, MachineID = 40 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 777, ErrorDate = new DateTime(2023, 11, 13), ErrorID = 17, MachineID = 31 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 778, ErrorDate = new DateTime(2023, 6, 4), ErrorID = 17, MachineID = 15 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 779, ErrorDate = new DateTime(2022, 2, 12), ErrorID = 14, MachineID = 34 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 780, ErrorDate = new DateTime(2020, 8, 9), ErrorID = 14, MachineID = 34 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 781, ErrorDate = new DateTime(2022, 9, 16), ErrorID = 6, MachineID = 34 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 782, ErrorDate = new DateTime(2024, 4, 24), ErrorID = 5, MachineID = 17 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 783, ErrorDate = new DateTime(2023, 3, 13), ErrorID = 20, MachineID = 37 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 784, ErrorDate = new DateTime(2022, 7, 8), ErrorID = 12, MachineID = 32 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 785, ErrorDate = new DateTime(2021, 7, 27), ErrorID = 5, MachineID = 7 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 786, ErrorDate = new DateTime(2023, 7, 14), ErrorID = 16, MachineID = 19 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 787, ErrorDate = new DateTime(2024, 2, 7), ErrorID = 9, MachineID = 39 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 788, ErrorDate = new DateTime(2023, 1, 24), ErrorID = 1, MachineID = 20 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 789, ErrorDate = new DateTime(2022, 9, 26), ErrorID = 2, MachineID = 26 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 790, ErrorDate = new DateTime(2020, 1, 4), ErrorID = 12, MachineID = 4 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 791, ErrorDate = new DateTime(2021, 12, 30), ErrorID = 2, MachineID = 18 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 792, ErrorDate = new DateTime(2022, 11, 25), ErrorID = 11, MachineID = 37 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 793, ErrorDate = new DateTime(2022, 8, 7), ErrorID = 1, MachineID = 10 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 794, ErrorDate = new DateTime(2022, 3, 9), ErrorID = 6, MachineID = 14 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 795, ErrorDate = new DateTime(2023, 11, 19), ErrorID = 1, MachineID = 34 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 796, ErrorDate = new DateTime(2023, 1, 24), ErrorID = 5, MachineID = 31 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 797, ErrorDate = new DateTime(2024, 4, 20), ErrorID = 16, MachineID = 4 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 798, ErrorDate = new DateTime(2021, 3, 18), ErrorID = 14, MachineID = 4 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 799, ErrorDate = new DateTime(2021, 6, 30), ErrorID = 4, MachineID = 16 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 800, ErrorDate = new DateTime(2020, 10, 17), ErrorID = 4, MachineID = 1 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 801, ErrorDate = new DateTime(2023, 9, 8), ErrorID = 12, MachineID = 39 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 802, ErrorDate = new DateTime(2020, 7, 13), ErrorID = 13, MachineID = 22 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 803, ErrorDate = new DateTime(2024, 1, 5), ErrorID = 6, MachineID = 39 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 804, ErrorDate = new DateTime(2020, 8, 12), ErrorID = 2, MachineID = 36 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 805, ErrorDate = new DateTime(2020, 3, 19), ErrorID = 3, MachineID = 36 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 806, ErrorDate = new DateTime(2021, 4, 20), ErrorID = 8, MachineID = 36 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 807, ErrorDate = new DateTime(2020, 7, 6), ErrorID = 3, MachineID = 9 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 808, ErrorDate = new DateTime(2023, 1, 5), ErrorID = 19, MachineID = 3 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 809, ErrorDate = new DateTime(2023, 8, 15), ErrorID = 20, MachineID = 26 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 810, ErrorDate = new DateTime(2020, 3, 3), ErrorID = 19, MachineID = 25 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 811, ErrorDate = new DateTime(2023, 6, 28), ErrorID = 15, MachineID = 34 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 812, ErrorDate = new DateTime(2023, 10, 4), ErrorID = 9, MachineID = 39 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 813, ErrorDate = new DateTime(2020, 11, 21), ErrorID = 10, MachineID = 7 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 814, ErrorDate = new DateTime(2022, 4, 20), ErrorID = 16, MachineID = 22 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 815, ErrorDate = new DateTime(2023, 5, 10), ErrorID = 11, MachineID = 23 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 816, ErrorDate = new DateTime(2022, 11, 27), ErrorID = 20, MachineID = 7 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 817, ErrorDate = new DateTime(2022, 12, 18), ErrorID = 5, MachineID = 37 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 818, ErrorDate = new DateTime(2020, 5, 9), ErrorID = 19, MachineID = 27 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 819, ErrorDate = new DateTime(2021, 2, 24), ErrorID = 4, MachineID = 39 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 820, ErrorDate = new DateTime(2021, 5, 20), ErrorID = 1, MachineID = 1 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 821, ErrorDate = new DateTime(2023, 7, 30), ErrorID = 20, MachineID = 3 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 822, ErrorDate = new DateTime(2022, 6, 16), ErrorID = 4, MachineID = 15 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 823, ErrorDate = new DateTime(2021, 4, 21), ErrorID = 2, MachineID = 29 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 824, ErrorDate = new DateTime(2022, 1, 10), ErrorID = 2, MachineID = 29 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 825, ErrorDate = new DateTime(2023, 11, 7), ErrorID = 1, MachineID = 3 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 826, ErrorDate = new DateTime(2020, 2, 29), ErrorID = 3, MachineID = 27 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 827, ErrorDate = new DateTime(2022, 7, 26), ErrorID = 19, MachineID = 34 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 828, ErrorDate = new DateTime(2021, 4, 4), ErrorID = 11, MachineID = 34 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 829, ErrorDate = new DateTime(2020, 11, 21), ErrorID = 7, MachineID = 11 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 830, ErrorDate = new DateTime(2023, 3, 10), ErrorID = 17, MachineID = 10 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 831, ErrorDate = new DateTime(2021, 11, 12), ErrorID = 5, MachineID = 10 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 832, ErrorDate = new DateTime(2020, 3, 5), ErrorID = 13, MachineID = 4 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 833, ErrorDate = new DateTime(2020, 9, 14), ErrorID = 8, MachineID = 30 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 834, ErrorDate = new DateTime(2021, 1, 16), ErrorID = 6, MachineID = 36 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 835, ErrorDate = new DateTime(2020, 11, 30), ErrorID = 13, MachineID = 35 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 836, ErrorDate = new DateTime(2021, 10, 29), ErrorID = 3, MachineID = 25 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 837, ErrorDate = new DateTime(2020, 7, 20), ErrorID = 15, MachineID = 20 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 838, ErrorDate = new DateTime(2023, 1, 20), ErrorID = 8, MachineID = 30 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 839, ErrorDate = new DateTime(2020, 11, 26), ErrorID = 8, MachineID = 22 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 840, ErrorDate = new DateTime(2023, 4, 8), ErrorID = 18, MachineID = 32 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 841, ErrorDate = new DateTime(2021, 8, 5), ErrorID = 10, MachineID = 32 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 842, ErrorDate = new DateTime(2021, 10, 7), ErrorID = 4, MachineID = 32 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 843, ErrorDate = new DateTime(2023, 5, 30), ErrorID = 12, MachineID = 14 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 844, ErrorDate = new DateTime(2022, 1, 12), ErrorID = 6, MachineID = 23 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 845, ErrorDate = new DateTime(2023, 3, 8), ErrorID = 20, MachineID = 18 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 846, ErrorDate = new DateTime(2023, 12, 4), ErrorID = 20, MachineID = 28 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 847, ErrorDate = new DateTime(2022, 3, 7), ErrorID = 6, MachineID = 6 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 848, ErrorDate = new DateTime(2023, 10, 28), ErrorID = 18, MachineID = 23 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 849, ErrorDate = new DateTime(2023, 10, 6), ErrorID = 19, MachineID = 11 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 850, ErrorDate = new DateTime(2020, 9, 1), ErrorID = 17, MachineID = 4 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 851, ErrorDate = new DateTime(2021, 12, 22), ErrorID = 16, MachineID = 1 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 852, ErrorDate = new DateTime(2022, 4, 27), ErrorID = 7, MachineID = 4 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 853, ErrorDate = new DateTime(2023, 6, 5), ErrorID = 16, MachineID = 6 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 854, ErrorDate = new DateTime(2023, 7, 11), ErrorID = 18, MachineID = 38 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 855, ErrorDate = new DateTime(2023, 4, 2), ErrorID = 11, MachineID = 21 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 856, ErrorDate = new DateTime(2023, 1, 23), ErrorID = 19, MachineID = 29 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 857, ErrorDate = new DateTime(2024, 4, 23), ErrorID = 17, MachineID = 5 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 858, ErrorDate = new DateTime(2023, 10, 16), ErrorID = 19, MachineID = 33 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 859, ErrorDate = new DateTime(2021, 1, 18), ErrorID = 15, MachineID = 2 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 860, ErrorDate = new DateTime(2023, 5, 16), ErrorID = 8, MachineID = 10 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 861, ErrorDate = new DateTime(2022, 6, 22), ErrorID = 3, MachineID = 26 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 862, ErrorDate = new DateTime(2021, 9, 16), ErrorID = 14, MachineID = 17 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 863, ErrorDate = new DateTime(2022, 5, 9), ErrorID = 1, MachineID = 11 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 864, ErrorDate = new DateTime(2021, 3, 6), ErrorID = 18, MachineID = 6 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 865, ErrorDate = new DateTime(2022, 2, 22), ErrorID = 18, MachineID = 11 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 866, ErrorDate = new DateTime(2023, 10, 30), ErrorID = 19, MachineID = 32 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 867, ErrorDate = new DateTime(2023, 5, 27), ErrorID = 20, MachineID = 30 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 868, ErrorDate = new DateTime(2021, 5, 25), ErrorID = 3, MachineID = 15 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 869, ErrorDate = new DateTime(2023, 12, 3), ErrorID = 17, MachineID = 9 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 870, ErrorDate = new DateTime(2021, 2, 22), ErrorID = 9, MachineID = 26 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 871, ErrorDate = new DateTime(2023, 11, 12), ErrorID = 17, MachineID = 30 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 872, ErrorDate = new DateTime(2020, 11, 17), ErrorID = 20, MachineID = 22 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 873, ErrorDate = new DateTime(2020, 6, 26), ErrorID = 3, MachineID = 30 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 874, ErrorDate = new DateTime(2020, 3, 6), ErrorID = 1, MachineID = 23 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 875, ErrorDate = new DateTime(2023, 10, 18), ErrorID = 6, MachineID = 20 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 876, ErrorDate = new DateTime(2021, 8, 21), ErrorID = 8, MachineID = 12 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 877, ErrorDate = new DateTime(2020, 8, 1), ErrorID = 11, MachineID = 25 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 878, ErrorDate = new DateTime(2021, 7, 25), ErrorID = 9, MachineID = 21 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 879, ErrorDate = new DateTime(2020, 12, 8), ErrorID = 6, MachineID = 18 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 880, ErrorDate = new DateTime(2020, 9, 24), ErrorID = 3, MachineID = 21 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 881, ErrorDate = new DateTime(2023, 1, 3), ErrorID = 20, MachineID = 17 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 882, ErrorDate = new DateTime(2021, 1, 27), ErrorID = 8, MachineID = 39 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 883, ErrorDate = new DateTime(2022, 3, 30), ErrorID = 2, MachineID = 28 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 884, ErrorDate = new DateTime(2023, 5, 19), ErrorID = 6, MachineID = 15 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 885, ErrorDate = new DateTime(2020, 3, 5), ErrorID = 6, MachineID = 22 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 886, ErrorDate = new DateTime(2020, 10, 8), ErrorID = 17, MachineID = 33 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 887, ErrorDate = new DateTime(2021, 12, 4), ErrorID = 12, MachineID = 25 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 888, ErrorDate = new DateTime(2023, 11, 2), ErrorID = 20, MachineID = 8 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 889, ErrorDate = new DateTime(2022, 1, 3), ErrorID = 18, MachineID = 3 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 890, ErrorDate = new DateTime(2022, 2, 10), ErrorID = 8, MachineID = 26 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 891, ErrorDate = new DateTime(2021, 11, 16), ErrorID = 1, MachineID = 40 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 892, ErrorDate = new DateTime(2021, 12, 21), ErrorID = 9, MachineID = 15 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 893, ErrorDate = new DateTime(2024, 2, 9), ErrorID = 6, MachineID = 24 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 894, ErrorDate = new DateTime(2023, 10, 15), ErrorID = 4, MachineID = 36 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 895, ErrorDate = new DateTime(2023, 3, 25), ErrorID = 15, MachineID = 5 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 896, ErrorDate = new DateTime(2023, 3, 7), ErrorID = 15, MachineID = 1 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 897, ErrorDate = new DateTime(2021, 8, 21), ErrorID = 17, MachineID = 10 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 898, ErrorDate = new DateTime(2021, 8, 16), ErrorID = 19, MachineID = 14 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 899, ErrorDate = new DateTime(2021, 2, 4), ErrorID = 4, MachineID = 31 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 900, ErrorDate = new DateTime(2022, 6, 14), ErrorID = 2, MachineID = 40 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 901, ErrorDate = new DateTime(2022, 7, 14), ErrorID = 6, MachineID = 25 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 902, ErrorDate = new DateTime(2023, 5, 23), ErrorID = 15, MachineID = 15 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 903, ErrorDate = new DateTime(2023, 5, 14), ErrorID = 6, MachineID = 25 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 904, ErrorDate = new DateTime(2021, 9, 25), ErrorID = 14, MachineID = 1 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 905, ErrorDate = new DateTime(2022, 12, 5), ErrorID = 10, MachineID = 4 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 906, ErrorDate = new DateTime(2021, 7, 17), ErrorID = 16, MachineID = 35 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 907, ErrorDate = new DateTime(2023, 8, 13), ErrorID = 20, MachineID = 11 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 908, ErrorDate = new DateTime(2021, 3, 12), ErrorID = 10, MachineID = 14 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 909, ErrorDate = new DateTime(2021, 12, 8), ErrorID = 2, MachineID = 32 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 910, ErrorDate = new DateTime(2020, 9, 6), ErrorID = 2, MachineID = 39 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 911, ErrorDate = new DateTime(2022, 3, 10), ErrorID = 4, MachineID = 8 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 912, ErrorDate = new DateTime(2020, 6, 29), ErrorID = 2, MachineID = 37 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 913, ErrorDate = new DateTime(2020, 2, 29), ErrorID = 1, MachineID = 36 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 914, ErrorDate = new DateTime(2024, 4, 15), ErrorID = 6, MachineID = 29 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 915, ErrorDate = new DateTime(2021, 10, 9), ErrorID = 15, MachineID = 12 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 916, ErrorDate = new DateTime(2021, 11, 11), ErrorID = 17, MachineID = 30 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 917, ErrorDate = new DateTime(2022, 11, 24), ErrorID = 19, MachineID = 5 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 918, ErrorDate = new DateTime(2020, 10, 4), ErrorID = 6, MachineID = 23 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 919, ErrorDate = new DateTime(2024, 1, 20), ErrorID = 7, MachineID = 7 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 920, ErrorDate = new DateTime(2021, 7, 30), ErrorID = 11, MachineID = 18 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 921, ErrorDate = new DateTime(2020, 1, 10), ErrorID = 3, MachineID = 3 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 922, ErrorDate = new DateTime(2024, 4, 23), ErrorID = 13, MachineID = 5 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 923, ErrorDate = new DateTime(2022, 5, 6), ErrorID = 15, MachineID = 17 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 924, ErrorDate = new DateTime(2022, 7, 25), ErrorID = 19, MachineID = 36 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 925, ErrorDate = new DateTime(2022, 12, 29), ErrorID = 1, MachineID = 6 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 926, ErrorDate = new DateTime(2022, 3, 5), ErrorID = 11, MachineID = 15 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 927, ErrorDate = new DateTime(2021, 5, 22), ErrorID = 14, MachineID = 3 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 928, ErrorDate = new DateTime(2020, 11, 20), ErrorID = 12, MachineID = 3 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 929, ErrorDate = new DateTime(2022, 4, 22), ErrorID = 12, MachineID = 3 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 930, ErrorDate = new DateTime(2024, 4, 13), ErrorID = 18, MachineID = 33 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 931, ErrorDate = new DateTime(2020, 4, 11), ErrorID = 7, MachineID = 19 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 932, ErrorDate = new DateTime(2020, 11, 19), ErrorID = 17, MachineID = 38 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 933, ErrorDate = new DateTime(2021, 1, 15), ErrorID = 15, MachineID = 2 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 934, ErrorDate = new DateTime(2024, 4, 14), ErrorID = 16, MachineID = 22 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 935, ErrorDate = new DateTime(2023, 2, 10), ErrorID = 9, MachineID = 17 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 936, ErrorDate = new DateTime(2022, 4, 1), ErrorID = 4, MachineID = 39 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 937, ErrorDate = new DateTime(2023, 7, 24), ErrorID = 1, MachineID = 5 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 938, ErrorDate = new DateTime(2020, 5, 13), ErrorID = 13, MachineID = 35 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 939, ErrorDate = new DateTime(2022, 2, 27), ErrorID = 16, MachineID = 31 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 940, ErrorDate = new DateTime(2023, 9, 24), ErrorID = 2, MachineID = 8 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 941, ErrorDate = new DateTime(2021, 9, 16), ErrorID = 11, MachineID = 12 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 942, ErrorDate = new DateTime(2021, 3, 25), ErrorID = 11, MachineID = 36 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 943, ErrorDate = new DateTime(2023, 12, 28), ErrorID = 7, MachineID = 4 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 944, ErrorDate = new DateTime(2023, 8, 20), ErrorID = 11, MachineID = 36 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 945, ErrorDate = new DateTime(2023, 10, 5), ErrorID = 16, MachineID = 39 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 946, ErrorDate = new DateTime(2023, 5, 29), ErrorID = 1, MachineID = 9 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 947, ErrorDate = new DateTime(2022, 8, 23), ErrorID = 7, MachineID = 5 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 948, ErrorDate = new DateTime(2023, 11, 14), ErrorID = 11, MachineID = 19 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 949, ErrorDate = new DateTime(2023, 3, 2), ErrorID = 15, MachineID = 32 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 950, ErrorDate = new DateTime(2021, 10, 29), ErrorID = 18, MachineID = 16 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 951, ErrorDate = new DateTime(2020, 8, 27), ErrorID = 14, MachineID = 30 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 952, ErrorDate = new DateTime(2022, 8, 7), ErrorID = 4, MachineID = 5 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 953, ErrorDate = new DateTime(2021, 4, 20), ErrorID = 13, MachineID = 5 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 954, ErrorDate = new DateTime(2023, 7, 31), ErrorID = 14, MachineID = 1 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 955, ErrorDate = new DateTime(2020, 6, 26), ErrorID = 5, MachineID = 38 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 956, ErrorDate = new DateTime(2023, 7, 17), ErrorID = 2, MachineID = 8 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 957, ErrorDate = new DateTime(2023, 9, 19), ErrorID = 19, MachineID = 39 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 958, ErrorDate = new DateTime(2022, 11, 22), ErrorID = 16, MachineID = 18 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 959, ErrorDate = new DateTime(2020, 4, 16), ErrorID = 15, MachineID = 31 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 960, ErrorDate = new DateTime(2024, 2, 4), ErrorID = 8, MachineID = 38 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 961, ErrorDate = new DateTime(2022, 1, 20), ErrorID = 18, MachineID = 38 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 962, ErrorDate = new DateTime(2024, 1, 3), ErrorID = 11, MachineID = 28 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 963, ErrorDate = new DateTime(2022, 12, 24), ErrorID = 11, MachineID = 29 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 964, ErrorDate = new DateTime(2021, 6, 1), ErrorID = 3, MachineID = 6 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 965, ErrorDate = new DateTime(2023, 8, 10), ErrorID = 15, MachineID = 8 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 966, ErrorDate = new DateTime(2020, 11, 15), ErrorID = 15, MachineID = 20 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 967, ErrorDate = new DateTime(2023, 12, 9), ErrorID = 6, MachineID = 21 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 968, ErrorDate = new DateTime(2021, 10, 15), ErrorID = 9, MachineID = 3 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 969, ErrorDate = new DateTime(2023, 11, 28), ErrorID = 14, MachineID = 36 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 970, ErrorDate = new DateTime(2022, 8, 1), ErrorID = 6, MachineID = 18 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 971, ErrorDate = new DateTime(2023, 5, 31), ErrorID = 17, MachineID = 30 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 972, ErrorDate = new DateTime(2023, 9, 18), ErrorID = 10, MachineID = 35 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 973, ErrorDate = new DateTime(2020, 12, 29), ErrorID = 8, MachineID = 40 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 974, ErrorDate = new DateTime(2021, 10, 30), ErrorID = 17, MachineID = 10 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 975, ErrorDate = new DateTime(2023, 11, 2), ErrorID = 9, MachineID = 20 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 976, ErrorDate = new DateTime(2020, 9, 30), ErrorID = 20, MachineID = 1 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 977, ErrorDate = new DateTime(2022, 1, 9), ErrorID = 10, MachineID = 24 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 978, ErrorDate = new DateTime(2021, 12, 15), ErrorID = 20, MachineID = 26 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 979, ErrorDate = new DateTime(2024, 1, 28), ErrorID = 16, MachineID = 32 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 980, ErrorDate = new DateTime(2024, 1, 1), ErrorID = 6, MachineID = 24 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 981, ErrorDate = new DateTime(2023, 11, 29), ErrorID = 18, MachineID = 38 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 982, ErrorDate = new DateTime(2023, 12, 19), ErrorID = 1, MachineID = 18 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 983, ErrorDate = new DateTime(2020, 8, 2), ErrorID = 2, MachineID = 20 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 984, ErrorDate = new DateTime(2022, 9, 6), ErrorID = 19, MachineID = 31 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 985, ErrorDate = new DateTime(2020, 3, 4), ErrorID = 3, MachineID = 26 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 986, ErrorDate = new DateTime(2022, 11, 30), ErrorID = 18, MachineID = 39 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 987, ErrorDate = new DateTime(2022, 3, 3), ErrorID = 6, MachineID = 16 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 988, ErrorDate = new DateTime(2023, 4, 29), ErrorID = 2, MachineID = 6 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 989, ErrorDate = new DateTime(2022, 11, 18), ErrorID = 14, MachineID = 8 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 990, ErrorDate = new DateTime(2021, 10, 1), ErrorID = 13, MachineID = 6 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 991, ErrorDate = new DateTime(2023, 8, 3), ErrorID = 3, MachineID = 13 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 992, ErrorDate = new DateTime(2022, 1, 8), ErrorID = 7, MachineID = 17 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 993, ErrorDate = new DateTime(2021, 9, 5), ErrorID = 18, MachineID = 14 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 994, ErrorDate = new DateTime(2022, 6, 27), ErrorID = 6, MachineID = 1 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 995, ErrorDate = new DateTime(2020, 3, 29), ErrorID = 18, MachineID = 23 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 996, ErrorDate = new DateTime(2020, 1, 2), ErrorID = 10, MachineID = 36 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 997, ErrorDate = new DateTime(2022, 1, 17), ErrorID = 20, MachineID = 37 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 998, ErrorDate = new DateTime(2021, 1, 6), ErrorID = 16, MachineID = 4 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 999, ErrorDate = new DateTime(2020, 12, 26), ErrorID = 10, MachineID = 13 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 1000, ErrorDate = new DateTime(2023, 2, 11), ErrorID = 3, MachineID = 5 });

                #endregion

                #region Build table Data_MachineComponent

                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 1, MachineID = 7, TimeReplacement = 1, TimeReplacementName = "1 (năm)", ComponentName = "Zơle trung gian", BaseUnitName = "Cái " });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 2, MachineID = 7, TimeReplacement = 1, TimeReplacementName = "1 (năm)", ComponentName = "Cảm biến", BaseUnitName = "Cái " });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 3, MachineID = 7, TimeReplacement = 1, TimeReplacementName = "1 (năm)", ComponentName = "Lọc dầu", BaseUnitName = "Cái " });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 4, MachineID = 7, TimeReplacement = 1, TimeReplacementName = "1 (năm)", ComponentName = "Dao chày cối đột", BaseUnitName = "Bộ" });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 5, MachineID = 7, TimeReplacement = 1, TimeReplacementName = "1 (năm)", ComponentName = "Zoăng , Sim phớt van, đường ống, xilanh", BaseUnitName = "Bộ" });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 6, MachineID = 7, TimeReplacement = 2, TimeReplacementName = "2 (năm)", ComponentName = "Van thủy lực", BaseUnitName = "Cái " });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 7, MachineID = 7, TimeReplacement = 2, TimeReplacementName = "2 (năm)", ComponentName = "PLC", BaseUnitName = "Cái " });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 8, MachineID = 7, TimeReplacement = 2, TimeReplacementName = "2 (năm)", ComponentName = "Động cơ + Driver", BaseUnitName = "Bộ" });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 9, MachineID = 7, TimeReplacement = 2, TimeReplacementName = "2 (năm)", ComponentName = "Màn hình + case máy tính", BaseUnitName = "Bộ" });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 10, MachineID = 7, TimeReplacement = 2, TimeReplacementName = "2 (năm)", ComponentName = "Dây culoa", BaseUnitName = "Cái " });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 11, MachineID = 7, TimeReplacement = 2, TimeReplacementName = "2 (năm)", ComponentName = "Encoder", BaseUnitName = "Cái " });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 12, MachineID = 7, TimeReplacement = 2, TimeReplacementName = "2 (năm)", ComponentName = "Dầu thủy lực", BaseUnitName = "Lít" });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 13, MachineID = 7, TimeReplacement = 2, TimeReplacementName = "2 (năm)", ComponentName = "Bơm dầu", BaseUnitName = "Cái " });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 14, MachineID = 7, TimeReplacement = 2, TimeReplacementName = "2 (năm)", ComponentName = "Đồng hồ áp", BaseUnitName = "Cái " });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 15, MachineID = 7, TimeReplacement = 2, TimeReplacementName = "2 (năm)", ComponentName = "Khởi động từ", BaseUnitName = "Cái " });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 16, MachineID = 7, TimeReplacement = 2, TimeReplacementName = "2 (năm)", ComponentName = "Biến áp", BaseUnitName = "Cái " });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 17, MachineID = 8, TimeReplacement = 1, TimeReplacementName = "1 (năm)", ComponentName = "Zơle trung gian", BaseUnitName = "Cái " });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 18, MachineID = 8, TimeReplacement = 1, TimeReplacementName = "1 (năm)", ComponentName = "Cảm biến", BaseUnitName = "Cái " });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 19, MachineID = 8, TimeReplacement = 1, TimeReplacementName = "1 (năm)", ComponentName = "Lọc dầu", BaseUnitName = "Cái " });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 20, MachineID = 8, TimeReplacement = 1, TimeReplacementName = "1 (năm)", ComponentName = "Dao chày cối đột", BaseUnitName = "Bộ" });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 21, MachineID = 8, TimeReplacement = 1, TimeReplacementName = "1 (năm)", ComponentName = "Zoăng , Sim phớt van, đường ống, xilanh", BaseUnitName = "Bộ" });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 22, MachineID = 8, TimeReplacement = 2, TimeReplacementName = "2 (năm)", ComponentName = "Van thủy lực", BaseUnitName = "Cái " });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 23, MachineID = 8, TimeReplacement = 2, TimeReplacementName = "2 (năm)", ComponentName = "PLC", BaseUnitName = "Cái " });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 24, MachineID = 8, TimeReplacement = 2, TimeReplacementName = "2 (năm)", ComponentName = "Động cơ + Driver", BaseUnitName = "Bộ" });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 25, MachineID = 8, TimeReplacement = 2, TimeReplacementName = "2 (năm)", ComponentName = "Màn hình + case máy tính", BaseUnitName = "Bộ" });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 26, MachineID = 8, TimeReplacement = 2, TimeReplacementName = "2 (năm)", ComponentName = "Dây culoa", BaseUnitName = "Cái " });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 27, MachineID = 8, TimeReplacement = 2, TimeReplacementName = "2 (năm)", ComponentName = "Encoder", BaseUnitName = "Cái " });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 28, MachineID = 8, TimeReplacement = 2, TimeReplacementName = "2 (năm)", ComponentName = "Dầu thủy lực", BaseUnitName = "Lít" });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 29, MachineID = 8, TimeReplacement = 2, TimeReplacementName = "2 (năm)", ComponentName = "Bơm dầu", BaseUnitName = "Cái " });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 30, MachineID = 8, TimeReplacement = 2, TimeReplacementName = "2 (năm)", ComponentName = "Đồng hồ áp", BaseUnitName = "Cái " });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 31, MachineID = 8, TimeReplacement = 2, TimeReplacementName = "2 (năm)", ComponentName = "Khởi động từ", BaseUnitName = "Cái " });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 32, MachineID = 8, TimeReplacement = 2, TimeReplacementName = "2 (năm)", ComponentName = "Biến áp", BaseUnitName = "Cái " });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 33, MachineID = 9, TimeReplacement = 1, TimeReplacementName = "1 (năm)", ComponentName = "Zơle trung gian", BaseUnitName = "Cái " });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 34, MachineID = 9, TimeReplacement = 1, TimeReplacementName = "1 (năm)", ComponentName = "Cảm biến", BaseUnitName = "Cái " });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 35, MachineID = 9, TimeReplacement = 1, TimeReplacementName = "1 (năm)", ComponentName = "Lọc dầu", BaseUnitName = "Cái " });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 36, MachineID = 9, TimeReplacement = 1, TimeReplacementName = "1 (năm)", ComponentName = "Dao chày cối đột", BaseUnitName = "Bộ" });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 37, MachineID = 9, TimeReplacement = 1, TimeReplacementName = "1 (năm)", ComponentName = "Zoăng , Sim phớt van, đường ống, xilanh", BaseUnitName = "Bộ" });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 38, MachineID = 9, TimeReplacement = 2, TimeReplacementName = "2 (năm)", ComponentName = "Van thủy lực", BaseUnitName = "Cái " });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 39, MachineID = 9, TimeReplacement = 2, TimeReplacementName = "2 (năm)", ComponentName = "PLC", BaseUnitName = "Cái " });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 40, MachineID = 9, TimeReplacement = 2, TimeReplacementName = "2 (năm)", ComponentName = "Động cơ + Driver", BaseUnitName = "Bộ" });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 41, MachineID = 9, TimeReplacement = 2, TimeReplacementName = "2 (năm)", ComponentName = "Màn hình + case máy tính", BaseUnitName = "Bộ" });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 42, MachineID = 9, TimeReplacement = 2, TimeReplacementName = "2 (năm)", ComponentName = "Dây culoa", BaseUnitName = "Cái " });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 43, MachineID = 9, TimeReplacement = 2, TimeReplacementName = "2 (năm)", ComponentName = "Encoder", BaseUnitName = "Cái " });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 44, MachineID = 9, TimeReplacement = 2, TimeReplacementName = "2 (năm)", ComponentName = "Dầu thủy lực", BaseUnitName = "Lít" });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 45, MachineID = 9, TimeReplacement = 2, TimeReplacementName = "2 (năm)", ComponentName = "Bơm dầu", BaseUnitName = "Cái " });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 46, MachineID = 9, TimeReplacement = 2, TimeReplacementName = "2 (năm)", ComponentName = "Đồng hồ áp", BaseUnitName = "Cái " });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 47, MachineID = 9, TimeReplacement = 2, TimeReplacementName = "2 (năm)", ComponentName = "Khởi động từ", BaseUnitName = "Cái " });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 48, MachineID = 9, TimeReplacement = 2, TimeReplacementName = "2 (năm)", ComponentName = "Biến áp", BaseUnitName = "Cái " });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 49, MachineID = 15, TimeReplacement = 1, TimeReplacementName = "1 (năm)", ComponentName = "Zơle trung gian", BaseUnitName = "Cái " });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 50, MachineID = 15, TimeReplacement = 1, TimeReplacementName = "1 (năm)", ComponentName = "Cảm biến", BaseUnitName = "Cái " });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 51, MachineID = 15, TimeReplacement = 1, TimeReplacementName = "1 (năm)", ComponentName = "Lọc dầu", BaseUnitName = "Cái " });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 52, MachineID = 15, TimeReplacement = 1, TimeReplacementName = "1 (năm)", ComponentName = "Dao chày cối đột", BaseUnitName = "Bộ" });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 53, MachineID = 15, TimeReplacement = 1, TimeReplacementName = "1 (năm)", ComponentName = "Zoăng , Sim phớt van, đường ống, xilanh", BaseUnitName = "Bộ" });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 54, MachineID = 15, TimeReplacement = 2, TimeReplacementName = "2 (năm)", ComponentName = "Van thủy lực", BaseUnitName = "Cái " });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 55, MachineID = 15, TimeReplacement = 2, TimeReplacementName = "2 (năm)", ComponentName = "PLC", BaseUnitName = "Cái " });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 56, MachineID = 15, TimeReplacement = 2, TimeReplacementName = "2 (năm)", ComponentName = "Động cơ + Driver", BaseUnitName = "Bộ" });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 57, MachineID = 15, TimeReplacement = 2, TimeReplacementName = "2 (năm)", ComponentName = "Màn hình + case máy tính", BaseUnitName = "Bộ" });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 58, MachineID = 15, TimeReplacement = 2, TimeReplacementName = "2 (năm)", ComponentName = "Dây culoa", BaseUnitName = "Cái " });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 59, MachineID = 15, TimeReplacement = 2, TimeReplacementName = "2 (năm)", ComponentName = "Encoder", BaseUnitName = "Cái " });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 60, MachineID = 15, TimeReplacement = 2, TimeReplacementName = "2 (năm)", ComponentName = "Dầu thủy lực", BaseUnitName = "Lít" });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 61, MachineID = 15, TimeReplacement = 2, TimeReplacementName = "2 (năm)", ComponentName = "Bơm dầu", BaseUnitName = "Cái " });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 62, MachineID = 15, TimeReplacement = 2, TimeReplacementName = "2 (năm)", ComponentName = "Đồng hồ áp", BaseUnitName = "Cái " });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 63, MachineID = 15, TimeReplacement = 2, TimeReplacementName = "2 (năm)", ComponentName = "Khởi động từ", BaseUnitName = "Cái " });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 64, MachineID = 15, TimeReplacement = 2, TimeReplacementName = "2 (năm)", ComponentName = "Biến áp", BaseUnitName = "Cái " });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 65, MachineID = 5, TimeReplacement = 1, TimeReplacementName = "1 (năm)", ComponentName = "Zơle trung gian", BaseUnitName = "Cái " });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 66, MachineID = 5, TimeReplacement = 1, TimeReplacementName = "1 (năm)", ComponentName = "Cảm biến", BaseUnitName = "Cái " });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 67, MachineID = 5, TimeReplacement = 1, TimeReplacementName = "1 (năm)", ComponentName = "Lọc dầu", BaseUnitName = "Cái " });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 68, MachineID = 5, TimeReplacement = 1, TimeReplacementName = "1 (năm)", ComponentName = "Dao chày cối đột", BaseUnitName = "Bộ" });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 69, MachineID = 5, TimeReplacement = 1, TimeReplacementName = "1 (năm)", ComponentName = "Zoăng , Sim phớt van, đường ống, xilanh", BaseUnitName = "Bộ" });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 70, MachineID = 5, TimeReplacement = 2, TimeReplacementName = "2 (năm)", ComponentName = "Van thủy lực", BaseUnitName = "Cái" });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 71, MachineID = 5, TimeReplacement = 2, TimeReplacementName = "2 (năm)", ComponentName = "Bơm dầu", BaseUnitName = "Cái" });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 72, MachineID = 5, TimeReplacement = 2, TimeReplacementName = "2 (năm)", ComponentName = "Động cơ + Driver", BaseUnitName = "Bộ" });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 73, MachineID = 5, TimeReplacement = 2, TimeReplacementName = "2 (năm)", ComponentName = "Thước quang tuyến tính", BaseUnitName = "Cái" });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 74, MachineID = 5, TimeReplacement = 2, TimeReplacementName = "2 (năm)", ComponentName = "Dây culoa", BaseUnitName = "Cái" });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 75, MachineID = 5, TimeReplacement = 2, TimeReplacementName = "2 (năm)", ComponentName = "Biến áp", BaseUnitName = "Cái" });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 76, MachineID = 5, TimeReplacement = 2, TimeReplacementName = "2 (năm)", ComponentName = "Bộ điều khiển", BaseUnitName = "Cái" });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 77, MachineID = 5, TimeReplacement = 2, TimeReplacementName = "2 (năm)", ComponentName = "Đồng hồ áp", BaseUnitName = "Cái" });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 78, MachineID = 5, TimeReplacement = 2, TimeReplacementName = "2 (năm)", ComponentName = "Khởi động từ", BaseUnitName = "Cái" });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 79, MachineID = 5, TimeReplacement = 2, TimeReplacementName = "2 (năm)", ComponentName = "Con trượt , bi vit me", BaseUnitName = "Con" });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 80, MachineID = 14, TimeReplacement = 1, TimeReplacementName = "1 (năm)", ComponentName = "Zơle trung gian", BaseUnitName = "Cái " });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 81, MachineID = 14, TimeReplacement = 1, TimeReplacementName = "1 (năm)", ComponentName = "Cảm biến", BaseUnitName = "Cái " });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 82, MachineID = 14, TimeReplacement = 1, TimeReplacementName = "1 (năm)", ComponentName = "Lọc dầu", BaseUnitName = "Cái " });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 83, MachineID = 14, TimeReplacement = 1, TimeReplacementName = "1 (năm)", ComponentName = "Dao chày cối đột", BaseUnitName = "Bộ" });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 84, MachineID = 14, TimeReplacement = 1, TimeReplacementName = "1 (năm)", ComponentName = "Zoăng , Sim phớt van, đường ống, xilanh", BaseUnitName = "Bộ" });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 85, MachineID = 14, TimeReplacement = 2, TimeReplacementName = "2 (năm)", ComponentName = "Van thủy lực", BaseUnitName = "Cái " });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 86, MachineID = 14, TimeReplacement = 2, TimeReplacementName = "2 (năm)", ComponentName = "PLC", BaseUnitName = "Cái " });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 87, MachineID = 14, TimeReplacement = 2, TimeReplacementName = "2 (năm)", ComponentName = "Động cơ + Driver", BaseUnitName = "Bộ" });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 88, MachineID = 14, TimeReplacement = 2, TimeReplacementName = "2 (năm)", ComponentName = "Màn hình + case máy tính", BaseUnitName = "Bộ" });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 89, MachineID = 14, TimeReplacement = 2, TimeReplacementName = "2 (năm)", ComponentName = "Dây culoa", BaseUnitName = "Cái " });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 90, MachineID = 14, TimeReplacement = 2, TimeReplacementName = "2 (năm)", ComponentName = "Encoder", BaseUnitName = "Cái " });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 91, MachineID = 14, TimeReplacement = 2, TimeReplacementName = "2 (năm)", ComponentName = "Dầu thủy lực", BaseUnitName = "Lít" });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 92, MachineID = 14, TimeReplacement = 2, TimeReplacementName = "2 (năm)", ComponentName = "Bơm dầu", BaseUnitName = "Cái " });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 93, MachineID = 14, TimeReplacement = 2, TimeReplacementName = "2 (năm)", ComponentName = "Đồng hồ áp", BaseUnitName = "Cái " });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 94, MachineID = 14, TimeReplacement = 2, TimeReplacementName = "2 (năm)", ComponentName = "Khởi động từ", BaseUnitName = "Cái " });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 95, MachineID = 14, TimeReplacement = 2, TimeReplacementName = "2 (năm)", ComponentName = "Biến áp", BaseUnitName = "Cái " });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 96, MachineID = 4, TimeReplacement = 1, TimeReplacementName = "1 (năm)", ComponentName = "Zơle trung gian", BaseUnitName = "Cái " });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 97, MachineID = 4, TimeReplacement = 1, TimeReplacementName = "1 (năm)", ComponentName = "Cảm biến", BaseUnitName = "Cái " });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 98, MachineID = 4, TimeReplacement = 1, TimeReplacementName = "1 (năm)", ComponentName = "Lọc dầu", BaseUnitName = "Cái " });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 99, MachineID = 4, TimeReplacement = 1, TimeReplacementName = "1 (năm)", ComponentName = "Zoăng , Sim phớt van, đường ống, xilanh", BaseUnitName = "Bộ" });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 100, MachineID = 4, TimeReplacement = 2, TimeReplacementName = "2 (năm)", ComponentName = "Van thủy lực", BaseUnitName = "Cái " });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 101, MachineID = 4, TimeReplacement = 2, TimeReplacementName = "2 (năm)", ComponentName = "Bơm dầu", BaseUnitName = "Cái " });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 102, MachineID = 4, TimeReplacement = 2, TimeReplacementName = "2 (năm)", ComponentName = "Động cơ + Biến tần", BaseUnitName = "Bộ" });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 103, MachineID = 4, TimeReplacement = 2, TimeReplacementName = "2 (năm)", ComponentName = "Bình tích áp", BaseUnitName = "Cái" });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 104, MachineID = 4, TimeReplacement = 2, TimeReplacementName = "2 (năm)", ComponentName = "Dây culoa", BaseUnitName = "Cái" });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 105, MachineID = 4, TimeReplacement = 2, TimeReplacementName = "2 (năm)", ComponentName = "Biến áp", BaseUnitName = "Cái" });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 106, MachineID = 4, TimeReplacement = 2, TimeReplacementName = "2 (năm)", ComponentName = "Con trượt , bi vit me", BaseUnitName = "Con" });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 107, MachineID = 4, TimeReplacement = 2, TimeReplacementName = "2 (năm)", ComponentName = "Bộ điều khiển", BaseUnitName = "Cái" });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 108, MachineID = 4, TimeReplacement = 2, TimeReplacementName = "2 (năm)", ComponentName = "Đồng hồ áp", BaseUnitName = "Cái" });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 109, MachineID = 4, TimeReplacement = 2, TimeReplacementName = "2 (năm)", ComponentName = "Khởi động từ", BaseUnitName = "Con" });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 110, MachineID = 3, TimeReplacement = 1, TimeReplacementName = "1 (năm)", ComponentName = "Tay súng Plasma", BaseUnitName = "Bộ" });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 111, MachineID = 3, TimeReplacement = 1, TimeReplacementName = "1 (năm)", ComponentName = "Động cơ,driver các trục X,Y", BaseUnitName = "Cái" });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 112, MachineID = 3, TimeReplacement = 1, TimeReplacementName = "1 (năm)", ComponentName = "Màn hình điều khiển", BaseUnitName = "Bộ" });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 113, MachineID = 1, TimeReplacement = 1, TimeReplacementName = "1 (năm)", ComponentName = "Thấu kính laser", BaseUnitName = "Cái" });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 114, MachineID = 1, TimeReplacement = 1, TimeReplacementName = "1 (năm)", ComponentName = "Lọc khí nén", BaseUnitName = "Cái" });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 115, MachineID = 1, TimeReplacement = 1, TimeReplacementName = "1 (năm)", ComponentName = "Con trượt các trục X,Y", BaseUnitName = "Cái" });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 116, MachineID = 1, TimeReplacement = 1, TimeReplacementName = "1 (năm)", ComponentName = "Hệ thống vitme,vòng bi trục Z", BaseUnitName = "Cái" });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 117, MachineID = 1, TimeReplacement = 1, TimeReplacementName = "1 (năm)", ComponentName = "Các bộ lọc nước của chiller làm mát", BaseUnitName = "Bộ" });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 118, MachineID = 1, TimeReplacement = 1, TimeReplacementName = "1 (năm)", ComponentName = "Linh kiện tủ điện,relay contactor", BaseUnitName = "Cái" });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 119, MachineID = 1, TimeReplacement = 1, TimeReplacementName = "1 (năm)", ComponentName = "Dây tín hiệu từ tủ điện đến thân máy chính", BaseUnitName = "Mét" });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 120, MachineID = 1, TimeReplacement = 1, TimeReplacementName = "1 (năm)", ComponentName = "Linh kiện chiller", BaseUnitName = "Cái" });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 121, MachineID = 1, TimeReplacement = 1, TimeReplacementName = "1 (năm)", ComponentName = "Cover che ray", BaseUnitName = "Cái" });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 122, MachineID = 1, TimeReplacement = 2, TimeReplacementName = "2 (năm)", ComponentName = "Linh kiện màn hình điều khiển máy", BaseUnitName = "Cái" });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 123, MachineID = 1, TimeReplacement = 2, TimeReplacementName = "2 (năm)", ComponentName = "Linh kiện driver Siemen Double, NCU và bộ nguồn Siemen", BaseUnitName = "Cái" });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 124, MachineID = 1, TimeReplacement = 2, TimeReplacementName = "2 (năm)", ComponentName = "Van khí Solenoid và van tuyến tính Lanny", BaseUnitName = "Cái" });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 125, MachineID = 1, TimeReplacement = 2, TimeReplacementName = "2 (năm)", ComponentName = "Linh kiện động cơ servo khi phát sinh X, Y, Z", BaseUnitName = "Cái" });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 126, MachineID = 1, TimeReplacement = 2, TimeReplacementName = "2 (năm)", ComponentName = "Hộp số servo trục X,Y", BaseUnitName = "Cái" });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 127, MachineID = 2, TimeReplacement = 1, TimeReplacementName = "1 (năm)", ComponentName = "Thấu kính laser", BaseUnitName = "Cái" });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 128, MachineID = 2, TimeReplacement = 1, TimeReplacementName = "1 (năm)", ComponentName = "Dây đai truyền động", BaseUnitName = "Cái" });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 129, MachineID = 2, TimeReplacement = 1, TimeReplacementName = "1 (năm)", ComponentName = "Linh kiện Chiler, khí", BaseUnitName = "Cái" });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 130, MachineID = 2, TimeReplacement = 1, TimeReplacementName = "1 (năm)", ComponentName = "Dây tín hiệu từ tủ điện đến thân máy chính", BaseUnitName = "Cái" });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 131, MachineID = 2, TimeReplacement = 1, TimeReplacementName = "1 (năm)", ComponentName = "Linh kiện tủ điện,relay,contactor", BaseUnitName = "Cái" });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 132, MachineID = 2, TimeReplacement = 1, TimeReplacementName = "1 (năm)", ComponentName = "Cảm biến,công tắc hành trình", BaseUnitName = "Cái" });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 133, MachineID = 2, TimeReplacement = 1, TimeReplacementName = "1 (năm)", ComponentName = "Xi lanh khí", BaseUnitName = "Cái" });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 134, MachineID = 2, TimeReplacement = 1, TimeReplacementName = "1 (năm)", ComponentName = "Cụm cảm biến đầu cắt", BaseUnitName = "Cái" });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 135, MachineID = 2, TimeReplacement = 2, TimeReplacementName = "2 (năm)", ComponentName = "Động cơ,driver các trục", BaseUnitName = "Cái" });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 136, MachineID = 2, TimeReplacement = 2, TimeReplacementName = "2 (năm)", ComponentName = "ĐỘng cơ bộ cấp phôi(Sửa chữa)", BaseUnitName = "Cái" });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 137, MachineID = 2, TimeReplacement = 2, TimeReplacementName = "2 (năm)", ComponentName = "Biến tần bộ cấp phôi", BaseUnitName = "Cái" });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 138, MachineID = 2, TimeReplacement = 2, TimeReplacementName = "2 (năm)", ComponentName = "Bo mạch chính,màn hình", BaseUnitName = "Cái" });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 139, MachineID = 2, TimeReplacement = 2, TimeReplacementName = "2 (năm)", ComponentName = "Con trượt các trục", BaseUnitName = "Cái" });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 140, MachineID = 2, TimeReplacement = 2, TimeReplacementName = "2 (năm)", ComponentName = "Hộp số các trục", BaseUnitName = "Cái" });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 141, MachineID = 2, TimeReplacement = 2, TimeReplacementName = "2 (năm)", ComponentName = "Vitme ,bi các trục", BaseUnitName = "Cái" });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 142, MachineID = 2, TimeReplacement = 2, TimeReplacementName = "2 (năm)", ComponentName = "Van đóng mở khí", BaseUnitName = "Cái" });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 143, MachineID = 16, TimeReplacement = 1, TimeReplacementName = "1 (năm)", ComponentName = "Súng hàn", BaseUnitName = "Cái" });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 144, MachineID = 16, TimeReplacement = 1, TimeReplacementName = "1 (năm)", ComponentName = "Đồng Hồ", BaseUnitName = "Cái" });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 145, MachineID = 16, TimeReplacement = 1, TimeReplacementName = "1 (năm)", ComponentName = "Dây khí", BaseUnitName = "Cái" });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 146, MachineID = 16, TimeReplacement = 1, TimeReplacementName = "1 (năm)", ComponentName = "Relay, contactor", BaseUnitName = "Cái" });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 147, MachineID = 16, TimeReplacement = 2, TimeReplacementName = "2 (năm)", ComponentName = "Nguồn hàn", BaseUnitName = "Bộ" });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 148, MachineID = 16, TimeReplacement = 2, TimeReplacementName = "2 (năm)", ComponentName = "Pin robot", BaseUnitName = "Bộ" });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 149, MachineID = 16, TimeReplacement = 2, TimeReplacementName = "2 (năm)", ComponentName = "Máy tính", BaseUnitName = "Bộ" });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 150, MachineID = 11, TimeReplacement = 1, TimeReplacementName = "1 (năm)", ComponentName = "Súng hàn", BaseUnitName = "Cái" });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 151, MachineID = 11, TimeReplacement = 1, TimeReplacementName = "1 (năm)", ComponentName = "Bộ cấp dây", BaseUnitName = "Bộ" });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 152, MachineID = 11, TimeReplacement = 1, TimeReplacementName = "1 (năm)", ComponentName = "Linh kiện súng hàn", BaseUnitName = "Cái" });
                Data_MachineComponent.Add(new Common.Data_MachineComponent() { ID = 153, MachineID = 11, TimeReplacement = 2, TimeReplacementName = "2 (năm)", ComponentName = "Nguồn hàn", BaseUnitName = "Bộ" });

                #endregion

                // Add linh kiện vào máy
                foreach (var m in StaticData.Data_Machine)
                {
                    m.ListComponents.AddRange(
                        StaticData.Data_MachineComponent.Where(t => t.MachineID == m.MachineID).ToList()
                    );
                }



                // Init trong file StaticDataV2
                StaticDataV2();

                // Init trong file StaticDataV3
                StaticDataV3();
            }
            catch (Exception)
            {

            }
        }

    }
}
