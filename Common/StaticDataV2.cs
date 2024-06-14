namespace Common
{
    public static partial class StaticData
    {
        public static readonly List<Data_MachineStatus> Data_MachineStatus = new List<Data_MachineStatus>();
        public static readonly List<Data_MachineStatusHistory> Data_MachineStatusHistory = new List<Data_MachineStatusHistory>();


        public static void StaticDataV2()
        {
            try
            {

                #region Build table Data_MachineStatus --> https://docs.google.com/spreadsheets/d/1PXA7g5p7IdIuuBvkardAjIoThfHFF5lw0biVisA6FWc/edit#gid=487803147&range=B2

                Data_MachineStatus.Add(new Common.Data_MachineStatus() { StatusID = 1, StatusName = "Ready", ColorCode = "#0070c0", StatusDetail = "Sẵn sàng cho sản xuất" });
                Data_MachineStatus.Add(new Common.Data_MachineStatus() { StatusID = 2, StatusName = "Run", ColorCode = "#00b050", StatusDetail = "Đang sản xuất" });
                Data_MachineStatus.Add(new Common.Data_MachineStatus() { StatusID = 3, StatusName = "Not ready", ColorCode = "#ff0000", StatusDetail = "Đang bảo dưỡng, sửa chữa" });
                Data_MachineStatus.Add(new Common.Data_MachineStatus() { StatusID = 4, StatusName = "Alarm", ColorCode = "#ffc000", StatusDetail = "Đang cảnh báo lỗi" });
                Data_MachineStatus.Add(new Common.Data_MachineStatus() { StatusID = 5, StatusName = "Off", ColorCode = "#a6a6a6", StatusDetail = "Đang không vận hành" });

                #endregion

                #region Build table Data_MachineStatusHistory --> https://docs.google.com/spreadsheets/d/1PXA7g5p7IdIuuBvkardAjIoThfHFF5lw0biVisA6FWc/edit#gid=0&range=L5

                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 1, MachineID = 15, StatusID = 1, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 11, 10, 3, 55) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 2, MachineID = 6, StatusID = 1, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 12, 19, 36, 12) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 3, MachineID = 3, StatusID = 2, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 13, 9, 29, 55) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 4, MachineID = 6, StatusID = 2, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 12, 17, 13, 18) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 5, MachineID = 9, StatusID = 5, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 13, 14, 53, 58) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 6, MachineID = 9, StatusID = 5, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 13, 18, 39, 7) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 7, MachineID = 5, StatusID = 4, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 12, 15, 46, 29) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 8, MachineID = 5, StatusID = 1, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 12, 6, 42, 26) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 9, MachineID = 9, StatusID = 3, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 11, 18, 12, 54) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 10, MachineID = 15, StatusID = 1, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 12, 7, 24, 13) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 11, MachineID = 4, StatusID = 2, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 13, 17, 12, 48) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 12, MachineID = 14, StatusID = 3, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 12, 1, 49, 18) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 13, MachineID = 2, StatusID = 3, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 12, 11, 31, 43) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 14, MachineID = 14, StatusID = 3, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 11, 2, 40, 26) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 15, MachineID = 4, StatusID = 1, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 13, 4, 6, 50) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 16, MachineID = 10, StatusID = 4, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 12, 21, 45, 52) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 17, MachineID = 14, StatusID = 4, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 12, 23, 7, 29) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 18, MachineID = 1, StatusID = 3, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 12, 5, 33, 57) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 19, MachineID = 11, StatusID = 4, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 12, 3, 22, 34) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 20, MachineID = 1, StatusID = 3, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 11, 8, 56, 29) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 21, MachineID = 7, StatusID = 5, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 13, 6, 58, 46) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 22, MachineID = 13, StatusID = 2, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 12, 3, 43, 8) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 23, MachineID = 13, StatusID = 2, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 12, 19, 44, 23) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 24, MachineID = 10, StatusID = 1, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 13, 10, 50, 11) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 25, MachineID = 12, StatusID = 4, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 11, 15, 3, 38) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 26, MachineID = 11, StatusID = 5, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 12, 23, 34, 2) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 27, MachineID = 4, StatusID = 2, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 12, 8, 34, 52) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 28, MachineID = 2, StatusID = 2, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 12, 15, 18, 10) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 29, MachineID = 1, StatusID = 4, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 13, 22, 39, 38) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 30, MachineID = 4, StatusID = 2, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 13, 21, 46, 38) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 31, MachineID = 11, StatusID = 3, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 11, 8, 53, 3) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 32, MachineID = 4, StatusID = 3, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 11, 22, 2, 35) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 33, MachineID = 7, StatusID = 4, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 12, 5, 44, 15) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 34, MachineID = 11, StatusID = 1, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 11, 13, 56, 16) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 35, MachineID = 12, StatusID = 3, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 13, 15, 15, 30) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 36, MachineID = 10, StatusID = 3, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 13, 3, 17, 46) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 37, MachineID = 9, StatusID = 5, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 11, 15, 53, 35) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 38, MachineID = 9, StatusID = 4, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 12, 16, 55, 41) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 39, MachineID = 12, StatusID = 4, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 13, 23, 15, 48) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 40, MachineID = 16, StatusID = 2, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 12, 15, 23, 58) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 41, MachineID = 1, StatusID = 5, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 11, 13, 12, 23) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 42, MachineID = 2, StatusID = 1, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 12, 12, 53, 5) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 43, MachineID = 5, StatusID = 5, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 13, 3, 27, 11) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 44, MachineID = 13, StatusID = 3, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 11, 6, 48, 44) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 45, MachineID = 1, StatusID = 3, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 11, 6, 29, 29) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 46, MachineID = 5, StatusID = 3, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 12, 20, 2, 1) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 47, MachineID = 7, StatusID = 4, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 13, 15, 31, 3) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 48, MachineID = 4, StatusID = 3, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 12, 9, 2, 51) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 49, MachineID = 12, StatusID = 1, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 13, 21, 28, 49) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 50, MachineID = 2, StatusID = 5, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 13, 21, 10, 4) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 51, MachineID = 7, StatusID = 2, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 12, 10, 36, 48) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 52, MachineID = 15, StatusID = 4, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 11, 4, 6, 6) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 53, MachineID = 11, StatusID = 1, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 13, 6, 51, 9) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 54, MachineID = 16, StatusID = 3, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 13, 19, 18, 36) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 55, MachineID = 8, StatusID = 1, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 11, 23, 54, 42) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 56, MachineID = 14, StatusID = 1, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 11, 2, 14, 30) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 57, MachineID = 7, StatusID = 5, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 11, 9, 31, 2) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 58, MachineID = 1, StatusID = 5, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 13, 1, 53, 8) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 59, MachineID = 6, StatusID = 1, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 11, 7, 11, 51) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 60, MachineID = 6, StatusID = 4, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 13, 19, 33, 10) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 61, MachineID = 11, StatusID = 4, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 13, 5, 5, 14) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 62, MachineID = 16, StatusID = 5, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 11, 1, 40, 57) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 63, MachineID = 15, StatusID = 1, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 12, 1, 30, 44) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 64, MachineID = 5, StatusID = 3, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 11, 23, 52, 42) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 65, MachineID = 8, StatusID = 2, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 12, 12, 41, 58) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 66, MachineID = 6, StatusID = 5, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 13, 8, 9, 10) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 67, MachineID = 7, StatusID = 5, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 12, 4, 56, 25) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 68, MachineID = 2, StatusID = 1, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 12, 18, 3, 35) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 69, MachineID = 5, StatusID = 1, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 13, 5, 33, 38) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 70, MachineID = 9, StatusID = 3, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 12, 19, 56, 5) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 71, MachineID = 14, StatusID = 5, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 11, 8, 18, 24) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 72, MachineID = 8, StatusID = 1, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 12, 5, 35, 34) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 73, MachineID = 14, StatusID = 5, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 13, 4, 22, 21) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 74, MachineID = 1, StatusID = 3, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 13, 20, 56, 29) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 75, MachineID = 10, StatusID = 5, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 13, 10, 50, 59) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 76, MachineID = 11, StatusID = 1, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 13, 19, 57, 35) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 77, MachineID = 5, StatusID = 5, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 12, 7, 55, 34) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 78, MachineID = 12, StatusID = 2, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 13, 7, 22, 28) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 79, MachineID = 1, StatusID = 1, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 12, 6, 57, 47) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 80, MachineID = 15, StatusID = 2, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 12, 16, 19, 31) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 81, MachineID = 4, StatusID = 3, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 13, 22, 3, 7) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 82, MachineID = 16, StatusID = 2, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 11, 16, 32, 59) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 83, MachineID = 1, StatusID = 4, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 12, 9, 32, 56) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 84, MachineID = 13, StatusID = 5, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 13, 23, 1, 20) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 85, MachineID = 12, StatusID = 3, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 12, 1, 29, 45) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 86, MachineID = 8, StatusID = 5, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 12, 4, 46, 7) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 87, MachineID = 2, StatusID = 1, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 13, 2, 57, 39) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 88, MachineID = 14, StatusID = 3, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 12, 6, 8, 55) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 89, MachineID = 4, StatusID = 3, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 12, 11, 36, 23) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 90, MachineID = 5, StatusID = 3, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 12, 9, 25, 42) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 91, MachineID = 16, StatusID = 2, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 12, 6, 39, 25) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 92, MachineID = 2, StatusID = 3, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 11, 4, 55, 30) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 93, MachineID = 1, StatusID = 5, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 11, 17, 22, 40) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 94, MachineID = 10, StatusID = 4, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 13, 6, 41, 5) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 95, MachineID = 11, StatusID = 3, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 11, 18, 25, 15) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 96, MachineID = 13, StatusID = 1, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 13, 4, 42, 37) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 97, MachineID = 3, StatusID = 3, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 13, 21, 46, 10) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 98, MachineID = 4, StatusID = 3, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 11, 6, 20, 54) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 99, MachineID = 8, StatusID = 1, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 13, 9, 51, 58) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 100, MachineID = 3, StatusID = 5, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 13, 14, 57, 46) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 101, MachineID = 5, StatusID = 5, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 11, 16, 58, 34) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 102, MachineID = 2, StatusID = 5, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 13, 20, 10, 36) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 103, MachineID = 3, StatusID = 4, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 13, 2, 47, 49) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 104, MachineID = 1, StatusID = 3, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 11, 15, 24, 58) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 105, MachineID = 15, StatusID = 2, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 11, 2, 53, 21) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 106, MachineID = 4, StatusID = 1, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 13, 4, 19, 17) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 107, MachineID = 4, StatusID = 3, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 13, 11, 22, 13) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 108, MachineID = 14, StatusID = 1, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 13, 8, 11, 43) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 109, MachineID = 11, StatusID = 5, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 13, 16, 49, 49) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 110, MachineID = 15, StatusID = 2, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 13, 2, 41, 28) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 111, MachineID = 5, StatusID = 3, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 12, 19, 24, 55) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 112, MachineID = 10, StatusID = 1, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 12, 14, 25, 4) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 113, MachineID = 8, StatusID = 5, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 11, 19, 36, 5) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 114, MachineID = 9, StatusID = 5, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 13, 23, 18, 46) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 115, MachineID = 13, StatusID = 4, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 13, 5, 38, 20) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 116, MachineID = 1, StatusID = 2, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 11, 21, 5, 7) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 117, MachineID = 10, StatusID = 2, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 13, 5, 23, 43) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 118, MachineID = 3, StatusID = 4, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 11, 14, 8, 8) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 119, MachineID = 14, StatusID = 2, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 13, 15, 22, 46) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 120, MachineID = 12, StatusID = 5, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 11, 2, 54, 27) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 121, MachineID = 10, StatusID = 1, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 11, 12, 52, 24) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 122, MachineID = 10, StatusID = 4, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 12, 1, 5, 49) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 123, MachineID = 16, StatusID = 4, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 12, 9, 18, 21) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 124, MachineID = 5, StatusID = 5, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 11, 22, 41, 50) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 125, MachineID = 7, StatusID = 2, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 11, 15, 39, 49) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 126, MachineID = 7, StatusID = 5, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 13, 4, 8, 5) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 127, MachineID = 8, StatusID = 4, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 11, 6, 18, 21) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 128, MachineID = 4, StatusID = 3, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 13, 7, 20, 29) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 129, MachineID = 11, StatusID = 3, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 11, 13, 46, 35) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 130, MachineID = 1, StatusID = 1, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 13, 3, 39, 26) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 131, MachineID = 3, StatusID = 3, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 12, 4, 32, 1) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 132, MachineID = 5, StatusID = 4, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 11, 21, 28, 8) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 133, MachineID = 14, StatusID = 2, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 13, 21, 57, 31) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 134, MachineID = 4, StatusID = 2, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 12, 2, 24, 5) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 135, MachineID = 7, StatusID = 5, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 11, 9, 57, 48) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 136, MachineID = 3, StatusID = 1, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 12, 22, 32, 5) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 137, MachineID = 10, StatusID = 5, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 13, 5, 37, 55) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 138, MachineID = 8, StatusID = 3, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 13, 19, 55, 13) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 139, MachineID = 3, StatusID = 3, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 11, 18, 29, 22) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 140, MachineID = 5, StatusID = 5, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 13, 2, 21, 17) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 141, MachineID = 4, StatusID = 4, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 13, 6, 38, 20) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 142, MachineID = 9, StatusID = 4, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 13, 14, 5, 29) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 143, MachineID = 16, StatusID = 3, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 12, 21, 52, 24) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 144, MachineID = 14, StatusID = 3, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 11, 14, 51, 22) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 145, MachineID = 5, StatusID = 5, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 11, 10, 32, 35) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 146, MachineID = 7, StatusID = 5, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 12, 11, 42, 13) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 147, MachineID = 12, StatusID = 2, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 13, 23, 22, 56) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 148, MachineID = 3, StatusID = 5, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 13, 23, 6, 21) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 149, MachineID = 15, StatusID = 3, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 13, 3, 56, 16) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 150, MachineID = 7, StatusID = 2, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 11, 15, 54, 46) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 151, MachineID = 2, StatusID = 4, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 11, 11, 18, 17) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 152, MachineID = 12, StatusID = 5, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 11, 1, 47, 55) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 153, MachineID = 12, StatusID = 3, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 11, 7, 46, 48) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 154, MachineID = 1, StatusID = 5, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 13, 17, 14, 17) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 155, MachineID = 10, StatusID = 5, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 12, 8, 27, 8) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 156, MachineID = 7, StatusID = 3, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 11, 20, 43, 46) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 157, MachineID = 7, StatusID = 4, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 11, 5, 13, 55) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 158, MachineID = 16, StatusID = 4, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 11, 6, 3, 49) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 159, MachineID = 5, StatusID = 5, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 12, 18, 9, 33) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 160, MachineID = 10, StatusID = 1, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 13, 21, 49, 9) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 161, MachineID = 10, StatusID = 1, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 12, 15, 45, 50) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 162, MachineID = 7, StatusID = 5, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 12, 16, 42, 17) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 163, MachineID = 15, StatusID = 1, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 12, 17, 3, 26) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 164, MachineID = 14, StatusID = 3, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 13, 14, 18, 24) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 165, MachineID = 6, StatusID = 3, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 13, 6, 16, 33) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 166, MachineID = 14, StatusID = 3, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 11, 10, 24, 51) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 167, MachineID = 8, StatusID = 2, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 12, 4, 59, 28) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 168, MachineID = 11, StatusID = 5, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 12, 14, 13, 5) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 169, MachineID = 6, StatusID = 4, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 11, 22, 15, 4) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 170, MachineID = 11, StatusID = 3, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 13, 5, 35, 25) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 171, MachineID = 16, StatusID = 2, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 11, 14, 5, 23) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 172, MachineID = 9, StatusID = 5, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 13, 12, 55, 39) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 173, MachineID = 5, StatusID = 5, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 11, 18, 23, 5) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 174, MachineID = 11, StatusID = 4, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 11, 2, 26, 45) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 175, MachineID = 16, StatusID = 2, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 11, 4, 54, 48) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 176, MachineID = 1, StatusID = 4, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 13, 18, 10, 53) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 177, MachineID = 11, StatusID = 4, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 13, 23, 59, 18) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 178, MachineID = 2, StatusID = 5, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 12, 9, 37, 17) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 179, MachineID = 3, StatusID = 5, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 12, 16, 1, 32) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 180, MachineID = 15, StatusID = 4, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 12, 22, 24, 46) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 181, MachineID = 15, StatusID = 4, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 12, 17, 27, 43) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 182, MachineID = 6, StatusID = 3, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 12, 2, 18, 30) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 183, MachineID = 11, StatusID = 3, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 11, 19, 54, 51) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 184, MachineID = 6, StatusID = 2, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 11, 19, 36, 45) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 185, MachineID = 15, StatusID = 3, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 13, 11, 26, 29) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 186, MachineID = 3, StatusID = 2, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 12, 20, 51, 43) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 187, MachineID = 13, StatusID = 4, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 13, 2, 6, 37) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 188, MachineID = 16, StatusID = 3, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 11, 5, 46, 23) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 189, MachineID = 13, StatusID = 4, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 13, 23, 10, 51) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 190, MachineID = 2, StatusID = 4, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 11, 15, 43, 39) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 191, MachineID = 4, StatusID = 1, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 11, 7, 28, 15) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 192, MachineID = 14, StatusID = 2, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 11, 23, 21, 44) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 193, MachineID = 4, StatusID = 2, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 11, 3, 42, 43) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 194, MachineID = 12, StatusID = 4, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 11, 8, 10, 31) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 195, MachineID = 6, StatusID = 5, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 13, 10, 23, 58) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 196, MachineID = 7, StatusID = 4, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 11, 12, 7, 49) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 197, MachineID = 5, StatusID = 1, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 13, 23, 13, 16) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 198, MachineID = 7, StatusID = 1, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 12, 4, 39, 11) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 199, MachineID = 12, StatusID = 3, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 12, 23, 57, 48) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 200, MachineID = 12, StatusID = 3, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 12, 19, 31, 52) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 201, MachineID = 4, StatusID = 1, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 12, 1, 52, 48) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 202, MachineID = 8, StatusID = 4, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 11, 20, 52, 10) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 203, MachineID = 16, StatusID = 2, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 13, 5, 42, 40) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 204, MachineID = 2, StatusID = 2, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 11, 1, 53, 53) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 205, MachineID = 2, StatusID = 1, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 13, 19, 59, 41) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 206, MachineID = 4, StatusID = 4, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 13, 1, 42, 21) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 207, MachineID = 4, StatusID = 3, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 12, 12, 15, 11) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 208, MachineID = 12, StatusID = 3, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 12, 1, 28, 55) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 209, MachineID = 3, StatusID = 4, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 12, 4, 59, 48) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 210, MachineID = 15, StatusID = 1, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 12, 13, 44, 39) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 211, MachineID = 7, StatusID = 1, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 11, 1, 41, 6) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 212, MachineID = 3, StatusID = 5, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 13, 9, 57, 4) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 213, MachineID = 2, StatusID = 1, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 13, 14, 12, 35) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 214, MachineID = 16, StatusID = 1, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 13, 22, 32, 2) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 215, MachineID = 14, StatusID = 1, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 11, 4, 54, 43) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 216, MachineID = 9, StatusID = 1, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 11, 11, 33, 2) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 217, MachineID = 9, StatusID = 1, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 12, 1, 43, 42) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 218, MachineID = 5, StatusID = 1, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 13, 17, 11, 4) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 219, MachineID = 16, StatusID = 3, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 12, 11, 46, 39) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 220, MachineID = 11, StatusID = 3, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 11, 13, 5, 17) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 221, MachineID = 12, StatusID = 5, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 11, 23, 26, 33) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 222, MachineID = 15, StatusID = 1, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 13, 2, 33, 59) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 223, MachineID = 11, StatusID = 2, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 13, 4, 28, 6) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 224, MachineID = 7, StatusID = 1, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 12, 12, 24, 34) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 225, MachineID = 2, StatusID = 5, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 11, 16, 22, 49) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 226, MachineID = 1, StatusID = 5, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 11, 2, 38, 53) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 227, MachineID = 12, StatusID = 1, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 12, 19, 13, 18) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 228, MachineID = 16, StatusID = 2, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 12, 16, 20, 51) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 229, MachineID = 4, StatusID = 5, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 13, 3, 26, 28) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 230, MachineID = 3, StatusID = 5, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 11, 19, 21, 48) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 231, MachineID = 11, StatusID = 2, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 12, 13, 47, 24) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 232, MachineID = 10, StatusID = 2, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 13, 10, 49, 47) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 233, MachineID = 14, StatusID = 1, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 12, 22, 31, 18) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 234, MachineID = 13, StatusID = 4, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 11, 11, 23, 51) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 235, MachineID = 4, StatusID = 1, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 13, 4, 10, 33) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 236, MachineID = 5, StatusID = 2, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 12, 1, 50, 13) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 237, MachineID = 14, StatusID = 4, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 13, 14, 55, 33) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 238, MachineID = 13, StatusID = 3, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 11, 19, 6, 34) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 239, MachineID = 11, StatusID = 2, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 13, 20, 42, 59) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 240, MachineID = 13, StatusID = 4, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 12, 15, 17, 3) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 241, MachineID = 11, StatusID = 5, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 11, 22, 3, 41) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 242, MachineID = 10, StatusID = 4, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 11, 2, 9, 33) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 243, MachineID = 13, StatusID = 1, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 13, 21, 51, 32) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 244, MachineID = 12, StatusID = 5, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 13, 20, 52, 15) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 245, MachineID = 9, StatusID = 4, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 13, 6, 54, 59) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 246, MachineID = 13, StatusID = 4, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 11, 3, 37, 34) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 247, MachineID = 16, StatusID = 1, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 12, 8, 9, 3) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 248, MachineID = 8, StatusID = 2, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 13, 13, 22, 43) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 249, MachineID = 11, StatusID = 2, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 12, 4, 39, 40) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 250, MachineID = 5, StatusID = 1, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 11, 15, 33, 2) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 251, MachineID = 10, StatusID = 4, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 12, 11, 42, 11) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 252, MachineID = 13, StatusID = 5, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 11, 1, 2, 45) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 253, MachineID = 8, StatusID = 1, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 12, 10, 57, 42) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 254, MachineID = 9, StatusID = 5, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 12, 6, 48, 28) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 255, MachineID = 7, StatusID = 4, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 13, 12, 37, 42) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 256, MachineID = 6, StatusID = 3, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 13, 20, 15, 11) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 257, MachineID = 12, StatusID = 5, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 11, 22, 25, 23) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 258, MachineID = 13, StatusID = 1, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 11, 14, 53, 18) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 259, MachineID = 9, StatusID = 3, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 11, 7, 49, 18) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 260, MachineID = 5, StatusID = 5, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 11, 12, 12, 15) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 261, MachineID = 14, StatusID = 3, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 12, 20, 54, 14) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 262, MachineID = 2, StatusID = 3, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 13, 23, 45, 47) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 263, MachineID = 7, StatusID = 3, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 11, 5, 48, 23) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 264, MachineID = 16, StatusID = 3, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 13, 15, 36, 24) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 265, MachineID = 7, StatusID = 5, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 11, 5, 15, 47) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 266, MachineID = 16, StatusID = 4, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 11, 17, 12, 16) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 267, MachineID = 4, StatusID = 3, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 12, 5, 13, 50) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 268, MachineID = 14, StatusID = 2, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 11, 8, 30, 51) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 269, MachineID = 5, StatusID = 1, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 12, 4, 1, 8) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 270, MachineID = 15, StatusID = 1, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 11, 11, 50, 41) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 271, MachineID = 1, StatusID = 4, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 11, 23, 25, 28) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 272, MachineID = 3, StatusID = 3, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 11, 17, 31, 52) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 273, MachineID = 3, StatusID = 4, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 11, 7, 51, 6) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 274, MachineID = 4, StatusID = 2, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 12, 3, 7, 41) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 275, MachineID = 1, StatusID = 1, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 13, 18, 42, 39) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 276, MachineID = 12, StatusID = 5, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 11, 23, 7, 19) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 277, MachineID = 2, StatusID = 5, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 13, 7, 23, 17) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 278, MachineID = 1, StatusID = 4, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 12, 22, 15, 18) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 279, MachineID = 14, StatusID = 2, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 11, 9, 44, 28) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 280, MachineID = 6, StatusID = 1, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 12, 15, 43, 17) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 281, MachineID = 16, StatusID = 5, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 13, 14, 48, 22) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 282, MachineID = 14, StatusID = 1, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 11, 16, 24, 2) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 283, MachineID = 10, StatusID = 5, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 11, 16, 14, 20) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 284, MachineID = 6, StatusID = 5, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 13, 15, 14, 15) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 285, MachineID = 12, StatusID = 4, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 12, 8, 12, 40) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 286, MachineID = 6, StatusID = 2, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 13, 4, 3, 10) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 287, MachineID = 4, StatusID = 5, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 13, 20, 33, 31) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 288, MachineID = 4, StatusID = 2, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 13, 18, 36, 43) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 289, MachineID = 1, StatusID = 4, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 11, 23, 49, 26) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 290, MachineID = 11, StatusID = 3, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 13, 16, 10, 24) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 291, MachineID = 11, StatusID = 2, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 11, 13, 20, 42) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 292, MachineID = 16, StatusID = 4, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 13, 19, 9, 13) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 293, MachineID = 13, StatusID = 5, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 11, 4, 14, 8) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 294, MachineID = 12, StatusID = 1, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 13, 22, 46, 34) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 295, MachineID = 13, StatusID = 3, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 12, 18, 13, 38) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 296, MachineID = 8, StatusID = 1, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 12, 3, 21, 41) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 297, MachineID = 9, StatusID = 3, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 13, 11, 12, 12) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 298, MachineID = 7, StatusID = 2, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 11, 13, 30, 2) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 299, MachineID = 12, StatusID = 5, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 13, 8, 41, 42) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 300, MachineID = 3, StatusID = 4, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 11, 12, 14, 7) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 301, MachineID = 10, StatusID = 4, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 12, 20, 32, 34) });

                var d = (DateTime.Now.Subtract(new DateTime(2024, 5, 12))).TotalDays;
                // Từ dữ liệu fake 3 ngày cố định, biến thành 3 ngày hiện tại
                foreach (var item in StaticData.Data_MachineStatusHistory)
                {
                    if (item != null)
                    {
                        // Data generate tu ngay 12/5/2024
                        item.StatusTime = item.StatusTime.AddDays(d);
                    }
                }

                #endregion

            }
            catch (Exception)
            {

            }
        }
    }


}

