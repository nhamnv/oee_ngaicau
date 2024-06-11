using Microsoft.AspNetCore.Mvc;
using Service.IService;

namespace WDI.OEE.Controllers
{
    public class CategoryManagementController : Controller
    {
        private readonly IData_ErrorService _data_ErrorService;

        public CategoryManagementController(IData_ErrorService data_ErrorService)
        {
            _data_ErrorService = data_ErrorService;
        }

        #region Danh mục lỗi
        public IActionResult ListError()
        {
            ViewData["Title"] = "Danh mục lỗi";
            // Model sẽ được load qua ajax sau khi pageload!
            //var model = _data_ErrorService.GetCommonList();
            return View();
        }

        [HttpGet]
        public JsonResult _GetListError()
        {
            var model = _data_ErrorService.GetCommonList();
            return new JsonResult(model);
        }

        #endregion
    }
}
