using Common;
using Common.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Service.IService;

namespace WDI.OEE.Controllers
{
    /// <summary>
    /// Báo cáo tình trạng hoạt động của máy
    /// </summary>
    public class ReportMachineRuningStatusController : BaseController
    {
        private readonly IReportMachineRuningStatusService _reportMachineRuningStatusService;
        private readonly IRazorPartialToStringRenderer _razorPartialToStringRenderer;
        private readonly IDashboardService _dashboardService;
        private readonly IMachineManagementService _machineManagementService;

        public ReportMachineRuningStatusController(IReportMachineRuningStatusService reportMachineRuningStatusService,
            IRazorPartialToStringRenderer razorPartialToStringRenderer,
            IDashboardService dashboardService,
            IMachineManagementService machineManagementService)
        {
            _reportMachineRuningStatusService = reportMachineRuningStatusService;
            _razorPartialToStringRenderer = razorPartialToStringRenderer;
            _dashboardService = dashboardService;
            _machineManagementService = machineManagementService;
        }


        public IActionResult Index()
        {
            ViewData["Title"] = "Trạng thái hoạt động máy";

            #region // Dropdown Time range
            //var listTimeRange = new List<SelectListItem>();
            //listTimeRange.Add(new SelectListItem() { Text = "-- Tất cả --", Value = "All", Selected = true });

            //listTimeRange.AddRange(
            //    StaticData.TimeRange.Select(t => new SelectListItem()
            //    {
            //        Text = t.TimeRangeName,
            //        Value = t.TimeRangeID.ToString()
            //    })
            //  );

            //ViewData["ListTimeRange"] = listTimeRange;

            #endregion

            #region Dropdown MachineGroup
            var listMachineGroup = new List<SelectListItem>();
            listMachineGroup.Add(new SelectListItem() { Text = "-- Tất cả --", Value = "All", Selected = true });

            listMachineGroup.AddRange(
                StaticData.Data_MachineGroup.AsEnumerable().Select(t => new SelectListItem()
                {
                    Text = t.MachineGroupName,
                    Value = t.MachineGroupID.ToString()
                }
             ));

            ViewData["ListMachineGroup"] = listMachineGroup;

            #endregion

            //#region Dropdown Machine Location
            //var listLocation = new List<SelectListItem>();

            //listLocation.Add(new SelectListItem() { Text = "-- Tất cả --", Value = "All", Selected = true });
            //listLocation.AddRange(
            //    StaticData.Data_MachineLocation.AsEnumerable().Select(t => new SelectListItem()
            //    {
            //        Value = t.LocationID.ToString(),
            //        Text = t.LocationName
            //    })
            //    );

            //ViewData["ListMachineLocation"] = listLocation;

            //#endregion

            #region Dropdown AssetGroup
            var listAssetGroup = new List<SelectListItem>();
            listAssetGroup.Add(new SelectListItem() { Text = "-- Tất cả --", Value = "All", Selected = true });

            listAssetGroup.AddRange(
                StaticData.Data_AssetGroup.AsEnumerable().Select(t => new SelectListItem()
                {
                    Text = t.AssetGroupName,
                    Value = t.AssetGroupID.ToString()
                }
             ));

            ViewData["ListAssetGroup"] = listAssetGroup;

            #endregion

            // mặc định xem dữ liệu 24h gần nhất
            DateTime endDate = DateTime.Now;
            DateTime startDate = endDate.AddHours(-24);

            List<MachineRuningStatusViewModel> model = _reportMachineRuningStatusService.GetReportMachineRuningStatus(startDate, endDate, "all", "all", "all");


            return View(model);
        }
        public JsonResult FilterData(string machineGroupID, string machineLocationID, string machineAssetGroupID)
        {
            try
            {
                // mặc định xem dữ liệu 24h gần nhất
                DateTime endDate = DateTime.Now;
                DateTime startDate = endDate.AddHours(-24);

                List<MachineRuningStatusViewModel> model = _reportMachineRuningStatusService.GetReportMachineRuningStatus(startDate, endDate, machineGroupID, machineLocationID, machineAssetGroupID);

                string machineHTML = "";

                foreach (var data in model)
                {
                    machineHTML += _razorPartialToStringRenderer.RenderPartialToStringAsync("/Views/ReportMachineRuningStatus/_Machine.cshtml", data).Result;
                }

                return new JsonResult(new { success = true, html = machineHTML });
            }
            catch (Exception)
            {

            }
            return new JsonResult("");
        }

        #region Form Detail

        public IActionResult Detail()
        {
            ViewData["Title"] = "Trạng thái hoạt động máy - chi tiết";

            #region Dropdown danh sách máy
            var listTimeRange = new List<SelectListItem>();
            //listTimeRange.Add(new SelectListItem() { Text = "-- Tất cả --", Value = "All", Selected = true });

            listTimeRange.AddRange(
                StaticData.Data_Machine.Select(t => new SelectListItem()
                {
                    Text = t.MachineName + " (" + t.Model + ")",
                    Value = t.MachineID.ToString()
                })
              );

            ViewData["ListMachine"] = listTimeRange;

            #endregion

            #region Dropdown MachineGroup
            var listMachineGroup = new List<SelectListItem>();
            listMachineGroup.Add(new SelectListItem() { Text = "-- Tất cả --", Value = "All", Selected = true });

            listMachineGroup.AddRange(
                StaticData.Data_MachineGroup.AsEnumerable().Select(t => new SelectListItem()
                {
                    Text = t.MachineGroupName,
                    Value = t.MachineGroupID.ToString()
                }
             ));

            ViewData["ListMachineGroup"] = listMachineGroup;

            #endregion

            //#region Dropdown Machine Location
            //var listLocation = new List<SelectListItem>();

            //listLocation.Add(new SelectListItem() { Text = "-- Tất cả --", Value = "All", Selected = true });
            //listLocation.AddRange(
            //    StaticData.Data_MachineLocation.AsEnumerable().Select(t => new SelectListItem()
            //    {
            //        Value = t.LocationID.ToString(),
            //        Text = t.LocationName
            //    })
            //    );

            //ViewData["ListMachineLocation"] = listLocation;

            //#endregion

            #region Dropdown AssetGroup
            var listAssetGroup = new List<SelectListItem>();
            listAssetGroup.Add(new SelectListItem() { Text = "-- Tất cả --", Value = "All", Selected = true });

            listAssetGroup.AddRange(
                StaticData.Data_AssetGroup.AsEnumerable().Select(t => new SelectListItem()
                {
                    Text = t.AssetGroupName,
                    Value = t.AssetGroupID.ToString()
                }
             ));

            ViewData["ListAssetGroup"] = listAssetGroup;

            #endregion

            // mặc định xem dữ liệu 24h gần nhất
            DateTime endDate = DateTime.Now;
            DateTime startDate = endDate.AddHours(-24);

            List<MachineRuningStatusViewModel> model = _reportMachineRuningStatusService.GetReportMachineRuningStatus(startDate, endDate, "all", "all", "all");


            return View(model);
        }

        public JsonResult FilterDataDetail(string MachineID, string MachineGroupID, string MachineLocationID, string MachineAssetGroupID)
        {
            try
            {
                // mặc định xem dữ liệu 24h gần nhất
                DateTime endDate = DateTime.Now;
                DateTime startDate = endDate.AddHours(-24);

                List<MachineRuningStatusViewModel> model = _reportMachineRuningStatusService.GetReportMachineRuningStatus(startDate, endDate, MachineGroupID, MachineLocationID, MachineAssetGroupID, MachineID);

                string machineHTML = "";

                machineHTML += _razorPartialToStringRenderer.RenderPartialToStringAsync("/Views/ReportMachineRuningStatus/_MachineSingle.cshtml", model[0]).Result;

                return new JsonResult(new { success = true, html = machineHTML });
            }
            catch (Exception)
            {

            }
            return new JsonResult("");
        }



        #endregion

        #region Hiện trạng hoạt động các máy

        /// <summary>
        /// Tổng thầu
        /// </summary>
        /// <returns></returns>
        public IActionResult Layout1()
        {
            ViewData["Title"] = "Hiện trạng hoạt động các máy";
            return View();
        }

        /// <summary>
        /// Hiện trạng hoạt động các máy - các box vuông
        /// </summary>
        /// <returns></returns>
        public IActionResult Layout2()
        {
            @ViewData["Title"] = "Hiện trạng hoạt động các máy";

            DateTime date = DateTime.Now;
            var model = _dashboardService.GetData(date);

            return View(model);
        }

        /// <summary>
        /// Hiện trạng hoạt động các máy - biểu đồ tròn + bar
        /// </summary>
        /// <returns></returns>
        public IActionResult Layout3()
        {
            MachineStatiticsViewModel model = new MachineStatiticsViewModel();
            ViewData["Title"] = "Hiện trạng hoạt động các máy";

            try
            {
                model = _machineManagementService.GetStatitics();
            }
            catch (Exception)
            {

            }

            return View(model);
        }

        /// <summary>
        /// Hiện trạng hoạt động các máy - ảnh sơ đồ máy
        /// </summary>
        /// <returns></returns>
        public IActionResult Layout4()
        {
            ViewData["Title"] = "Hiện trạng hoạt động các máy";
            return View();
        }
        #endregion
    }
}
