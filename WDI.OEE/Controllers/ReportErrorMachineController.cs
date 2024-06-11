using Common;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Service.IService;
using System.Data;

namespace WDI.OEE.Controllers
{
    /// <summary>
    /// Báo cáo dừng lỗi máy
    /// </summary>
    public class ReportErrorMachineController : BaseController
    {
        private IErrorMachineService _errorMachineService;

        public ReportErrorMachineController(IErrorMachineService errorMachineService)
        {
            _errorMachineService = errorMachineService;
        }



        public IActionResult Index()
        {
            ViewData["Title"] = "Báo cáo máy dừng, lỗi";

            #region Dropdown Time range
            var listTimeRange = new List<SelectListItem>();
            listTimeRange.Add(new SelectListItem() { Text = "Tất cả", Value = "All", Selected = true });

            listTimeRange.AddRange(
                StaticData.TimeRange.Select(t => new SelectListItem()
                {
                    Text = t.TimeRangeName,
                    Value = t.TimeRangeID.ToString()
                })
              );

            ViewData["ListTimeRange"] = listTimeRange;

            #endregion

            #region Dropdown MachineGroup
            var listMachineGroup = new List<SelectListItem>();
            listMachineGroup.Add(new SelectListItem() { Text = "Tất cả", Value = "All", Selected = true });

            listMachineGroup.AddRange(
                StaticData.Data_MachineGroup.AsEnumerable().Select(t => new SelectListItem()
                {
                    Text = t.MachineGroupName,
                    Value = t.MachineGroupID.ToString()
                }
             ));

            ViewData["ListMachineGroup"] = listMachineGroup;

            #endregion

            #region Dropdown Machine Location
            var listLocation = new List<SelectListItem>();

            listLocation.Add(new SelectListItem() { Text = "Tất cả", Value = "All", Selected = true });
            listLocation.AddRange(
                StaticData.Data_MachineLocation.AsEnumerable().Select(t => new SelectListItem()
                {
                    Value = t.LocationID.ToString(),
                    Text = t.LocationName
                })
                );

            ViewData["ListMachineLocation"] = listLocation;

            #endregion

            return View();
        }

        [HttpPost]
        public JsonResult GetErrorList(string TimeRangeID, string MachineGroupID, string MachineLocationID)
        {
            var err = _errorMachineService.GetErrorList(TimeRangeID, MachineGroupID, MachineLocationID);
            return new JsonResult(err);
        }

        [HttpPost]
        /// <summary>
        /// Trả về 3 tham số
        /// </summary>
        /// <param name="TimeRange"></param>
        /// <param name="MachineGroup"></param>
        /// <param name="MachineLocation"></param>
        /// <returns></returns>
        public JsonResult GetErrorSummary(string TimeRangeID, string MachineGroupID, string MachineLocationID)
        {
            bool Success = false;
            string message = "";
            dynamic data = new System.Dynamic.ExpandoObject();
            try
            {

                data = _errorMachineService.GetTop10ErrorList(TimeRangeID, MachineGroupID, MachineLocationID);

                Success = true;
            }
            catch (Exception ex)
            {
                message = ex.Message;
            }
            return new JsonResult(new
            {
                Success = Success,
                Data = data,
                Message = message
            });
        }
    }
}
