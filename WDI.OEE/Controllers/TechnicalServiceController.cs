using Common;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WDI.OEE.Controllers
{
    /// <summary>
    /// Dịch vụ kỹ thuật
    /// </summary>
    public class TechnicalServiceController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        #region Dịch vụ bảo dưỡng

        public IActionResult ExecuteChecklist()
        {
            ViewData["Title"] = "Thực thi checklist bảo dưỡng";

            #region Dropdown Danh sách máy
            var listMachine = new List<SelectListItem>();
            // listMachineGroup.Add(new SelectListItem() { Text = "-- Tất cả --", Value = "All", Selected = true });
            listMachine.AddRange(
                StaticData.Data_Machine.AsEnumerable().Select(t => new SelectListItem()
                {
                    Text = t.MachineName + " (" + t.Model + ")",
                    Value = t.MachineID.ToString()
                }
             ));

            ViewData["ListMachine"] = listMachine;

            #endregion

            #region Dropdown Chu kỳ bảo dưỡng
            var listMaintenanceInterval = new List<SelectListItem>();
            // listMaintenanceInterval.Add(new SelectListItem() { Text = "-- Tất cả --", Value = "All", Selected = true });
            listMaintenanceInterval.Add(new SelectListItem() { Text = "Hằng ngày", Value = "1" });
            listMaintenanceInterval.Add(new SelectListItem() { Text = "Hằng tuần", Value = "2" });
            listMaintenanceInterval.Add(new SelectListItem() { Text = "Hằng tháng", Value = "3" });
            listMaintenanceInterval.Add(new SelectListItem() { Text = "6 tháng", Value = "4" });
            listMaintenanceInterval.Add(new SelectListItem() { Text = "6 tháng-1 năm", Value = "5" });
            listMaintenanceInterval.Add(new SelectListItem() { Text = "Sau 2000h hoạt động", Value = "6" });

            ViewData["ListMaintenanceInterval"] = listMaintenanceInterval;

            #endregion

            return View();
        }

        #endregion
    }
}
