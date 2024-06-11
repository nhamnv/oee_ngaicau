namespace Common.ViewModels
{
    public class MachineStatiticsViewModel
    {
        /// <summary>
        /// Số nhà xưởng
        /// </summary>
        public BoxData BoxTotalWorkshop { get; set; } = new BoxData();
        /// <summary>
        /// Tổng số máy
        /// </summary>
        public BoxData BoxTotalMachine { get; set; } = new BoxData();

        /// <summary>
        /// Số máy theo nhóm
        /// </summary>
        public BoxData BoxTotalMachineByGroup { get; set; } = new BoxData();

        /// <summary>
        /// Tỷ lệ máy theo từng xưởng
        /// </summary>
        public ChartData PieChartRateOfTotalMachineByWorkshop { get; set; } = new ChartData();
        /// <summary>
        /// Tỷ lệ máy theo từng nhóm máy
        /// </summary>
        public ChartData PieChartRateOfTotalMachineByGroup { get; set; } = new ChartData();

        /// <summary>
        /// Tỷ lệ máy theo từng nhóm tài sản
        /// </summary>
        public ChartData PieChartRateOfTotalMachineByAssetGroup { get; set; } = new ChartData();

        /// <summary>
        /// Bảng thống kê theo nhóm máy và xưởng sản xuất
        /// </summary>
        public BarChart BarChartListMachineByGroupAndWorkshop { get; set; } = new BarChart();

        /// <summary>
        /// Bảng thống kê theo nhóm máy và xưởng sản xuất 2
        /// </summary>
        public BarChart BarChartListMachineByGroupAndWorkshop2 { get; set; } = new BarChart();

        //-------- Ngãi Cầu --------------------------------
        /// <summary>
        /// Biêu đồ tròn tỷ lệ máy theo trạng thái
        /// </summary>
        public ChartData PieChartRateOfTotalMachineByStatus { get; set; } = new ChartData();

        /// <summary>
        /// Bảng thống trạng thái máy theo nhóm máy
        /// </summary>
        public BarChart BarChartListMachineStatusByGroup { get; set; } = new BarChart();
    }

    public class BoxData
    {
        /// <summary>
        /// Tiêu đề box
        /// </summary>
        public string Title { get; set; } = string.Empty;

        /// <summary>
        /// Số của box
        /// </summary>
        public int Value { get; set; } = 0;

        /// <summary>
        /// Danh sách item của box
        /// </summary>
        public List<ChartItemViewModel> Data { get; set; } = new List<ChartItemViewModel>();
    }

    /// <summary>
    /// Dữ liệu chart - dùng cho cả pie và bar chart
    /// </summary>
    public class ChartData
    {
        /// <summary>
        /// Tiêu đề chart
        /// </summary>
        public string Title { get; set; } = string.Empty;
        public string ColorCode { get; set; } = string.Empty;
        /// <summary>
        /// Data của chart
        /// </summary>
        public List<ChartItemViewModel> Data { get; set; } = new List<ChartItemViewModel>();
    }

    public class BarChart
    {
        /// <summary>
        /// Tiêu đề chart
        /// </summary>
        public string Title { get; set; } = string.Empty;

        public List<ChartData> Data { get; set; } = new List<ChartData>();
    }
}