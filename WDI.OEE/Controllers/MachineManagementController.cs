using Common;
using Common.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json.Linq;
using Service.IService;


namespace WDI.OEE.Controllers
{
    /// <summary>
    /// Quản lý máy
    /// </summary>
    public class MachineManagementController : BaseController
    {
        private readonly IMachineManagementService _machineManagementService;
        private readonly IErrorMachineService _errorMachineService;
        private readonly IReportMachineRuningStatusService _reportMachineRuningStatusService;

        public MachineManagementController(IMachineManagementService machineManagementService, IErrorMachineService errorMachineService, IReportMachineRuningStatusService reportMachineRuningStatusService)
        {
            _machineManagementService = machineManagementService;
            _errorMachineService = errorMachineService;
            _reportMachineRuningStatusService = reportMachineRuningStatusService;
        }

        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Danh mục máy, có 2 param để open form từ các trang khác truyền vào
        /// </summary>
        /// <param name="machineGroupID"></param>
        /// <param name="workshopID"></param>
        /// <returns></returns>
        public ActionResult List(int machineGroupID = 0
            , int workshopID = 0
            , int machineAssetGroupID = 0
            , int machineLocationID = 0)
        {
            ViewData["machineGroupID"] = machineGroupID;
            ViewData["workshopID"] = workshopID;
            ViewData["machineAssetGroupID"] = machineAssetGroupID;
            ViewData["machineLocationID"] = machineLocationID;

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

            return View();
        }

        /// <summary>
        /// Thống kê số lượng máy
        /// </summary>
        /// <param name="stringData">string dạng JObject</param>
        /// <returns></returns>
        public ActionResult Statitics(string stringData)
        {
            MachineStatiticsViewModel model = new MachineStatiticsViewModel();
            ViewData["Title"] = "Thống kê số lượng máy";

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
        /// Load chi tiết máy
        /// </summary>
        /// <param name="stringData">
        /// Json data gồm các trường:
        /// <para>machineID: id máy</para>
        /// <para>machineLocationID: id vị trí lắp máy</para>
        /// <para>formType: kiểu form: 1=load to view; 2=load to edit</para>
        /// </param>
        /// <returns></returns>
        public ActionResult MachineDetail(string stringData)
        {
            MachineDetailViewModel model = new MachineDetailViewModel();
            ViewData["Title"] = "Xem chi tiết máy";

            try
            {
                dynamic d = JObject.Parse(stringData);
                int machineID = d.machineID;
                int machineLocationID = d.machineLocationID;
                int formType = d.formType;

                model = _machineManagementService.GetDetails(machineID, machineLocationID);
            }
            catch (Exception)
            {

            }

            return View(model);
        }


        #region Get data các tab

        [HttpGet]
        public JsonResult GetMachineErrorList(int machineID)
        {
            var data = _errorMachineService.GetErrorListByMachineID(machineID);
            return new JsonResult(data);
        }

        [HttpGet]
        public JsonResult GetSeriesTimeLine(int machineID)
        {
            // mặc định xem dữ liệu 24h gần nhất
            DateTime endDate = DateTime.Now;
            DateTime startDate = endDate.AddHours(-24);

            var data = _reportMachineRuningStatusService.GetListTimelineByMachineID(machineID, startDate, endDate);
            return new JsonResult(data);
        }

        [HttpGet]
        public JsonResult GetListStatusPercent(int machineID)
        {
            // mặc định xem dữ liệu 24h gần nhất
            DateTime endDate = DateTime.Now;
            DateTime startDate = endDate.AddHours(-24);

            var data = _reportMachineRuningStatusService.GetListStatusPercentByMachineID(machineID, startDate, endDate);
            return new JsonResult(data);
        }


        [HttpGet]
        public JsonResult GetListRepaireHistory(int machineID)
        {
            var data = _machineManagementService.GetMachineRepaireHistory(machineID);
            return new JsonResult(data);
        }

        [HttpGet]
        public JsonResult GetListMaintenanceChecklist(int machineID)
        {
            var data = _machineManagementService.GetMachineMaintenanceList(machineID);
            return new JsonResult(data);
        }


        [HttpGet]
        public JsonResult GetListMachineStatus()
        {
            var data = _machineManagementService.GetMachineStatusList();
            return new JsonResult(data);
        }

        [HttpGet]
        public JsonResult GetListMachine()
        {
            var data = _machineManagementService.GetListMachine();
            return new JsonResult(data);
        }
        #endregion
    }
}
