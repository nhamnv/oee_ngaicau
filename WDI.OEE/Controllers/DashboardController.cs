using Microsoft.AspNetCore.Mvc;
using Service.IService;
//using System.Web.Mvc;

namespace WDI.OEE.Controllers
{
    public class DashboardController : BaseController
    {
        private readonly IDashboardService _dashboardService;
        public DashboardController(IDashboardService dashboardService)
        {
            _dashboardService = dashboardService;
        }
        public IActionResult Index()
        {
            @ViewData["Title"] = "Hiện trạng hoạt động các máy";

            DateTime date = DateTime.Now;
            var model = _dashboardService.GetData(date);

            return View(model);
        }

        public ActionResult MachineGroupDetail(string MachineStatusID, string MachineGroupID)
        {
            @ViewData["Title"] = "Danh sách máy theo nhóm và trạng thái hoạt động";

            ViewBag.MachineStatusID = MachineStatusID;
            ViewBag.MachineGroupID = MachineGroupID;
            DateTime repotDate = DateTime.Now;

            var model = _dashboardService.GetMachineByStatusGroupDetail(MachineStatusID, MachineGroupID, repotDate);

            return View(model);
        }

        [HttpPost]
        public JsonResult ChangeMachineGroupDetail(string MachineStatusID, string MachineGroupID)
        {
            @ViewData["Title"] = "Danh sách máy theo nhóm và trạng thái hoạt động";

            ViewBag.MachineStatusID = MachineStatusID;
            ViewBag.MachineGroupID = MachineGroupID;
            DateTime repotDate = DateTime.Now;

            var model = _dashboardService.GetMachineByStatusGroupDetail(MachineStatusID, MachineGroupID, repotDate);


            //var options = new JsonSerializerOptions();
            //options.PropertyNamingPolicy = null;

            return new JsonResult(model);
        }

    }
}
