using Microsoft.AspNetCore.Mvc;
using Repository.Entity;
using Service.IService;

namespace WDI.OEE.Controllers
{
    public class MenuController : Controller
    {
        private readonly IData_MenuService _data_MenuService;

        public MenuController(IData_MenuService data_MenuService)
        {
            _data_MenuService = data_MenuService;
        }

        public IActionResult LoadMenu()
        {
            string htmlMenu = "";

            try
            {
                var data = _data_MenuService.GetList();
                if (data != null && data.Count > 0)
                {
                    foreach (var item in data)
                    {
                        htmlMenu += ExtractMenuItem(item);
                    }
                }
            }
            catch (Exception)
            {

            }

            @ViewBag.Html = htmlMenu;
            return PartialView("_LeftMenu");
        }

        private string ExtractMenuItem(Data_Menu menu)
        {
            string reval = "";

            #region // Template:
            /*
                                <!-- [ menu item ] start -->
                                <!-- Parent = 0 -->
                                <li class="nav-item pcoded-menu-caption">
                                    <label>Navigation Nhieu cap</label>
                                </li>
                                <!-- Parent>0 && Not have child -->
                                <li class="nav-item">
                                    <a href="index.html" class="nav-link "><span class="pcoded-micon"><i class="feather icon-home"></i></span><span class="pcoded-mtext">Dashboard</span></a>
                                </li>
                                <!-- Parent>0 && has child -->
                                <li class="nav-item pcoded-hasmenu">
                                    <a href="#!" class="nav-link "><span class="pcoded-micon"><i class="feather icon-layout"></i></span><span class="pcoded-mtext">Page layouts</span></a>
                                    <ul class="pcoded-submenu">
                                        <li><a href="layout-vertical.html" target="_blank">Vertical</a></li>
                                        <li>
                                            <a href="#!" class="nav-link "><span class="pcoded-micon"><i class="feather icon-layout"></i></span><span class="pcoded-mtext">Con cap 3</span></a>
                                            <ul class="pcoded-submenu">
                                                <li><a href="layout-vertical.html" target="_blank">Con cap 4 - 1</a></li>
                                                <li><a href="layout-horizontal.html" target="_blank">Con cap 4 - 5</a></li>
                                            </ul>
                                        </li>
                                    </ul>
                                </li>
                                <!-- [ menu item ] end -->
             */
            #endregion

            if (menu != null)
            {
                if (menu.ParentID <= 0) // Cấp 1
                {
                    reval += "                    " +
                        "<!-- [ menu item ] start -->\r\n                    " +
                        "<!-- Parent = 0 -->\r\n                    " +
                        "<li class=\"nav-item pcoded-menu-caption\">\r\n                        " +
                        "   <label>" + menu.Name?.Trim() + "</label>\r\n                    " +
                        "</li>";
                }
                //else // Cấp 2 trở lên
                //{
                if (menu.ChildMenus?.Count() == 0) // Không có con
                {
                    reval += "                    " +
                        "<!-- Parent>0 && Not have child -->\r\n                    " +
                        "<li class=\"nav-item\">\r\n                        " +
                        "   <a href=\"" + (menu.Url ?? "#") + "\" class=\"nav-link \"><!--span class=\"pcoded-micon\"><i class=\"feather icon-home\"></i></span--><span class=\"pcoded-mtext\">" + menu.Name + "</span></a>\r\n                    " +
                        "</li>";
                }
                else // Có con
                {
                    //reval += "                    " +
                    //    "<!-- Parent>0 && has child -->\r\n                    " +
                    //    "<li class=\"nav-item pcoded-hasmenu\">\r\n                        " +
                    //    "   <a href=\"" + (menu.Url ?? "#") + "\" class=\"nav-link \"><span class=\"pcoded-micon\"><i class=\"feather icon-layout\"></i></span><span class=\"pcoded-mtext\">" + menu.Name + "</span></a>\r\n                        " +
                    //    "   <ul class=\"pcoded-submenu\">\r\n                            " +
                    //    "       <li><a href=\"layout-vertical.html\" target=\"_blank\">Vertical</a></li>\r\n                            " +
                    //    "       <li>\r\n                                " +
                    //    "           <a href=\"#!\" class=\"nav-link \"><span class=\"pcoded-micon\"><i class=\"feather icon-layout\"></i></span><span class=\"pcoded-mtext\">Con cap 3</span></a>\r\n                                " +
                    //    "           <ul class=\"pcoded-submenu\">\r\n                                    " +
                    //    "               <li><a href=\"layout-vertical.html\" target=\"_blank\">Con cap 4 - 1</a></li>\r\n                                    " +
                    //    "               <li><a href=\"layout-horizontal.html\" target=\"_blank\">Con cap 4 - 5</a></li>\r\n                                " +
                    //    "           </ul>\r\n                            " +
                    //    "       </li>\r\n                        " +
                    //    "   </ul>\r\n                    " +
                    //    "</li>\r\n                    " +
                    //    "<!-- [ menu item ] end -->";

                    reval += "                    " +
                    "<!-- Parent>0 && has child -->\r\n                    " +
                    "<li class=\"nav-item pcoded-hasmenu\">\r\n                        " +
                    "   <a href=\"" + (menu.Url ?? "#") + "\" class=\"nav-link \"><span class=\"pcoded-micon\"><i class=\"feather icon-layout\"></i></span><span class=\"pcoded-mtext\">" + menu.Name + "</span></a>\r\n                        " +
                    "   <ul class=\"pcoded-submenu\">\r\n                            ";


                    foreach (var c in menu.ChildMenus)
                    {
                        reval += ExtractMenuItem(c);
                    }


                    reval +=
                    "   </ul>\r\n                    " +
                    "</li>\r\n                    " +
                    "<!-- [ menu item ] end -->";
                }
                //}

            }

            return reval;
        }
    }
}
