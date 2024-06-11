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

                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 1, MachineID = 60, StatusID = 1, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 13, 19, 42, 21) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 2, MachineID = 61, StatusID = 5, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 14, 13, 9, 39) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 3, MachineID = 62, StatusID = 2, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 14, 22, 3, 25) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 4, MachineID = 63, StatusID = 4, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 13, 5, 34, 29) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 5, MachineID = 64, StatusID = 1, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 13, 17, 20, 39) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 6, MachineID = 65, StatusID = 2, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 13, 1, 29, 14) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 7, MachineID = 66, StatusID = 3, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 15, 8, 29, 18) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 8, MachineID = 67, StatusID = 2, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 15, 11, 0, 57) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 9, MachineID = 68, StatusID = 5, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 13, 18, 34, 26) });
                Data_MachineStatusHistory.Add(new Common.Data_MachineStatusHistory() { MachineStatusHistoryID = 10, MachineID = 69, StatusID = 5, MachineLocationID = 1, StatusTime = new DateTime(2024, 5, 12, 14, 19, 31) });

                var d = (DateTime.Now.Subtract(new DateTime(2024, 5, 12))).TotalDays - 30;
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

