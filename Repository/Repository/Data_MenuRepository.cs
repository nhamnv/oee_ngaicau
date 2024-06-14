using Repository.Entity;
using Repository.IRepository;

namespace Repository.Repository
{
    public class Data_MenuRepository : GenericRepository<Data_Menu>, IData_MenuRepository
    {
        private readonly AppDBContext _context;
        public Data_MenuRepository(AppDBContext context) : base(context)
        {
            _context = context;
        }

        public List<Data_Menu> GetList()
        {
            // var a = this.GetAllAsync(); ==> Dòng này lỗi
            // fail: Microsoft.EntityFrameworkCore.Database.Connection[20004]
            // An error occurred using the connection to database 'wdi_oee' on server 'nhamnv'.
            // info: Microsoft.Hosting.Lifetime[0]

            List<Data_Menu> reval = new List<Data_Menu>();
            try
            {
                Data_Menu l1 = new Data_Menu();
                Data_Menu l2 = new Data_Menu();

                #region Fake data
                l1 = new Data_Menu() { MenuID = 1, Name = "Báo cáo tổng hợp", ParentID = 0, OrderNo = 1, IsShowMenu = true, Url = "" };  // reval.Add(l1);  
                l1.ChildMenus.Add(new Data_Menu() { MenuID = 2, Name = "Thống kê số lượng máy", ParentID = 1, OrderNo = 2, IsShowMenu = true, Url = "/MachineManagement/Statitics" });
                //l1.ChildMenus.Add(new Data_Menu() { MenuID = 3, Name = "Hiện trạng hoạt động", ParentID = 1, OrderNo = 4, IsShowMenu = true, Url = "/Dashboard/Index" });
                //l1.ChildMenus.Add(new Data_Menu() { MenuID = 5, Name = "Hiện trạng hoạt động (Layout 1)", ParentID = 1, OrderNo = 5, IsShowMenu = true, Url = "/ReportMachineRuningStatus/Layout1" });
                l1.ChildMenus.Add(new Data_Menu() { MenuID = 5, Name = "Hiện trạng hoạt động (Layout 2)", ParentID = 1, OrderNo = 5, IsShowMenu = true, Url = "http://nc.wdi/hien-trang-hoat-dong.html" });// "/ReportMachineRuningStatus/Layout2" });
                l1.ChildMenus.Add(new Data_Menu() { MenuID = 5, Name = "Hiện trạng hoạt động (Layout 3)", ParentID = 1, OrderNo = 5, IsShowMenu = true, Url = "/ReportMachineRuningStatus/Layout3" });
                l1.ChildMenus.Add(new Data_Menu() { MenuID = 5, Name = "Hiện trạng hoạt động (Layout 4)", ParentID = 1, OrderNo = 5, IsShowMenu = true, Url = "/ReportMachineRuningStatus/Layout4" });
                l1.ChildMenus.Add(new Data_Menu() { MenuID = 6, Name = "Thời gian hoạt động", ParentID = 1, OrderNo = 6, IsShowMenu = true, Url = "/ReportMachineRuningStatus/Index" });
                l1.ChildMenus.Add(new Data_Menu() { MenuID = 7, Name = "Chi tiết hoạt động", ParentID = 1, OrderNo = 7, IsShowMenu = true, Url = "/ReportMachineRuningStatus/Detail" });
                l1.ChildMenus.Add(new Data_Menu() { MenuID = 8, Name = "Thống kê lỗi", ParentID = 1, OrderNo = 8, IsShowMenu = true, Url = "/ReportErrorMachine/Index" });
                reval.Add(l1);
                // ------------------------------------------

                l1 = new Data_Menu() { MenuID = 20, Name = "Dịch vụ kỹ thuật", ParentID = 0, OrderNo = 20, IsShowMenu = true, Url = "" };  // reval.Add(l1);  
                l1.ChildMenus.Add(new Data_Menu() { MenuID = 21, Name = "Bảo dưỡng định kỳ", ParentID = 20, OrderNo = 21, IsShowMenu = true, Url = "/TechnicalService/ExecuteChecklist" });
                //l1.ChildMenus.Add(new Data_Menu() { MenuID = 22, Name = "Lệnh lắp đặt, sửa chữa", ParentID = 20, OrderNo = 22, IsShowMenu = true, Url = "" });
                //l1.ChildMenus.Add(new Data_Menu() { MenuID = 23, Name = "Lập lịch làm việc", ParentID = 20, OrderNo = 23, IsShowMenu = true, Url = "" });
                l1.ChildMenus.Add(new Data_Menu() { MenuID = 25, Name = "Truy suất lịch sử máy", ParentID = 20, OrderNo = 25, IsShowMenu = true, Url = "/MachineManagement/List" });
                //l1.ChildMenus.Add(new Data_Menu() { MenuID = 26, Name = "Cập nhật công việc", ParentID = 20, OrderNo = 26, IsShowMenu = true, Url = "" });
                //l1.ChildMenus.Add(new Data_Menu() { MenuID = 27, Name = "Nghiệm thu công việc", ParentID = 20, OrderNo = 27, IsShowMenu = true, Url = "" });
                //l1.ChildMenus.Add(new Data_Menu() { MenuID = 28, Name = "Đánh giá từ khách hàng", ParentID = 20, OrderNo = 28, IsShowMenu = true, Url = "" });
                //reval.Add(l1);
                // ------------------------------------------

                //l1 = new Data_Menu() { MenuID = 29, Name = "Quản lý bảo hành", ParentID = 0, OrderNo = 29, IsShowMenu = true, Url = "" };  // reval.Add(l1);  
                //l2 = new Data_Menu() { MenuID = 30, Name = "Tiếp nhận", ParentID = 29, OrderNo = 30, IsShowMenu = true, Url = "" };
                //l2.ChildMenus.Add(new Data_Menu() { MenuID = 31, Name = "Lập yêu cầu", ParentID = 30, OrderNo = 31, IsShowMenu = true, Url = "" });
                //l2.ChildMenus.Add(new Data_Menu() { MenuID = 32, Name = "Kiểm tra điều kiện, phạm vi Bảo hành", ParentID = 30, OrderNo = 32, IsShowMenu = true, Url = "" });
                //l1.ChildMenus.Add(l2);
                //l2 = new Data_Menu() { MenuID = 33, Name = "Phương án", ParentID = 29, OrderNo = 33, IsShowMenu = true, Url = "" };
                //l2.ChildMenus.Add(new Data_Menu() { MenuID = 34, Name = "Lập phương án xử lý", ParentID = 33, OrderNo = 34, IsShowMenu = true, Url = "" });
                //l2.ChildMenus.Add(new Data_Menu() { MenuID = 35, Name = "Danh mục lỗi", ParentID = 33, OrderNo = 35, IsShowMenu = true, Url = "" });
                //l2.ChildMenus.Add(new Data_Menu() { MenuID = 36, Name = "Chỉ định phương án", ParentID = 33, OrderNo = 36, IsShowMenu = true, Url = "" });
                //l1.ChildMenus.Add(l2);
                //l2 = new Data_Menu() { MenuID = 37, Name = "Thực hiện", ParentID = 29, OrderNo = 37, IsShowMenu = true, Url = "" };
                //l2.ChildMenus.Add(new Data_Menu() { MenuID = 38, Name = "Lập lệnh", ParentID = 37, OrderNo = 38, IsShowMenu = true, Url = "" });
                //l2.ChildMenus.Add(new Data_Menu() { MenuID = 39, Name = "Kiểm soát định mức", ParentID = 37, OrderNo = 39, IsShowMenu = true, Url = "" });
                //l2.ChildMenus.Add(new Data_Menu() { MenuID = 40, Name = "Thống kê chi phí", ParentID = 37, OrderNo = 40, IsShowMenu = true, Url = "" });
                //l2.ChildMenus.Add(new Data_Menu() { MenuID = 41, Name = "Tình trạng thực hiện", ParentID = 37, OrderNo = 41, IsShowMenu = true, Url = "" });
                //l2.ChildMenus.Add(new Data_Menu() { MenuID = 42, Name = "Đóng lệnh", ParentID = 37, OrderNo = 42, IsShowMenu = true, Url = "" });
                //l1.ChildMenus.Add(l2);
                //l2 = new Data_Menu() { MenuID = 43, Name = "Xuất nhập bảo hành", ParentID = 29, OrderNo = 43, IsShowMenu = true, Url = "" };
                //l2.ChildMenus.Add(new Data_Menu() { MenuID = 44, Name = "Gửi hàng bảo hành hãng", ParentID = 43, OrderNo = 44, IsShowMenu = true, Url = "" });
                //l2.ChildMenus.Add(new Data_Menu() { MenuID = 45, Name = "Nhập kho hàng bảo hành", ParentID = 43, OrderNo = 45, IsShowMenu = true, Url = "" });
                //l2.ChildMenus.Add(new Data_Menu() { MenuID = 46, Name = "Xuất mượn máy", ParentID = 43, OrderNo = 46, IsShowMenu = true, Url = "" });
                //l2.ChildMenus.Add(new Data_Menu() { MenuID = 47, Name = "Tồn kho", ParentID = 43, OrderNo = 47, IsShowMenu = true, Url = "" });
                //l1.ChildMenus.Add(l2);
                reval.Add(l1);
                // ------------------------------------------

                //l1 = new Data_Menu() { MenuID = 48, Name = "Guest Portal", ParentID = 0, OrderNo = 48, IsShowMenu = true, Url = "" };  // reval.Add(l1);  
                //l2 = new Data_Menu() { MenuID = 49, Name = "Quản lý tài sản", ParentID = 48, OrderNo = 49, IsShowMenu = true, Url = "" };
                //l2.ChildMenus.Add(new Data_Menu() { MenuID = 50, Name = "Thông số kỹ thuật", ParentID = 49, OrderNo = 50, IsShowMenu = true, Url = "" });
                //l2.ChildMenus.Add(new Data_Menu() { MenuID = 51, Name = "Lịch sử bảo dưỡng", ParentID = 49, OrderNo = 51, IsShowMenu = true, Url = "" });
                //l2.ChildMenus.Add(new Data_Menu() { MenuID = 52, Name = "Lịch sủ bảo dưỡng định kỳ", ParentID = 49, OrderNo = 52, IsShowMenu = true, Url = "" });
                //l1.ChildMenus.Add(l2);
                //l2 = new Data_Menu() { MenuID = 53, Name = "Yêu cầu sửa chữa", ParentID = 48, OrderNo = 53, IsShowMenu = true, Url = "" };
                //l2.ChildMenus.Add(new Data_Menu() { MenuID = 54, Name = "Lập yêu cầu", ParentID = 53, OrderNo = 54, IsShowMenu = true, Url = "" });
                //l2.ChildMenus.Add(new Data_Menu() { MenuID = 55, Name = "Đánh giá chất lượng", ParentID = 53, OrderNo = 55, IsShowMenu = true, Url = "" });
                //l2.ChildMenus.Add(new Data_Menu() { MenuID = 56, Name = "Quản lý chi phí", ParentID = 53, OrderNo = 56, IsShowMenu = true, Url = "" });
                //l1.ChildMenus.Add(l2);
                //l2 = new Data_Menu() { MenuID = 57, Name = "Quản lý cảnh báo", ParentID = 48, OrderNo = 57, IsShowMenu = true, Url = "" };
                //l2.ChildMenus.Add(new Data_Menu() { MenuID = 58, Name = "Thời hạn bảo dưỡng", ParentID = 57, OrderNo = 58, IsShowMenu = true, Url = "" });
                //l2.ChildMenus.Add(new Data_Menu() { MenuID = 59, Name = "Tình hình sửa chữa theo lệnh", ParentID = 57, OrderNo = 59, IsShowMenu = true, Url = "" });
                //l2.ChildMenus.Add(new Data_Menu() { MenuID = 60, Name = "Thông báo từ Weldcom", ParentID = 57, OrderNo = 60, IsShowMenu = true, Url = "" });
                //l1.ChildMenus.Add(l2);
                //reval.Add(l1);
                // ------------------------------------------

                l1 = new Data_Menu() { MenuID = 61, Name = "Hệ thống", ParentID = 0, OrderNo = 61, IsShowMenu = true, Url = "" };  // reval.Add(l1);  
                l2 = new Data_Menu() { MenuID = 62, Name = "Danh mục", ParentID = 61, OrderNo = 62, IsShowMenu = true, Url = "" };
                //l2.ChildMenus.Add(new Data_Menu() { MenuID = 63, Name = "Nhân viên, kỹ sư", ParentID = 62, OrderNo = 63, IsShowMenu = true, Url = "" });
                l2.ChildMenus.Add(new Data_Menu() { MenuID = 64, Name = "Máy móc thiết bị", ParentID = 62, OrderNo = 64, IsShowMenu = true, Url = "/MachineManagement/List" });
                //l2.ChildMenus.Add(new Data_Menu() { MenuID = 65, Name = "Vật tư, phụ tùng, linh kiện", ParentID = 62, OrderNo = 65, IsShowMenu = true, Url = "" });
                l2.ChildMenus.Add(new Data_Menu() { MenuID = 66, Name = "Mã lỗi", ParentID = 62, OrderNo = 66, IsShowMenu = true, Url = "/CategoryManagement/ListError" });
                //l2.ChildMenus.Add(new Data_Menu() { MenuID = 66, Name = "Mã lỗi (local)", ParentID = 62, OrderNo = 66, IsShowMenu = true, Url = "http://dvkt_v1.wdi/ma-loi.html" });
                l1.ChildMenus.Add(l2);
                //l2 = new Data_Menu() { MenuID = 67, Name = "Thiết lập chung", ParentID = 61, OrderNo = 67, IsShowMenu = true, Url = "" };
                //l2.ChildMenus.Add(new Data_Menu() { MenuID = 68, Name = "Thiết lập ngôn ngữ", ParentID = 67, OrderNo = 68, IsShowMenu = true, Url = "" });
                //l2.ChildMenus.Add(new Data_Menu() { MenuID = 69, Name = "Thiết lập múi giờ", ParentID = 67, OrderNo = 69, IsShowMenu = true, Url = "" });
                //l2.ChildMenus.Add(new Data_Menu() { MenuID = 70, Name = "Thiết lập chi nhánh", ParentID = 67, OrderNo = 70, IsShowMenu = true, Url = "" });
                //l2.ChildMenus.Add(new Data_Menu() { MenuID = 71, Name = "Thiết lập email", ParentID = 67, OrderNo = 71, IsShowMenu = true, Url = "" });
                //l2.ChildMenus.Add(new Data_Menu() { MenuID = 72, Name = "Cấu hình chung", ParentID = 67, OrderNo = 72, IsShowMenu = true, Url = "" });
                //l1.ChildMenus.Add(l2);
                l2 = new Data_Menu() { MenuID = 73, Name = "Đăng nhập", ParentID = 61, OrderNo = 73, IsShowMenu = true, Url = "/Authentication/LoginForm" };
                //l1.ChildMenus.Add(l2);
                //l1.ChildMenus.Add(new Data_Menu() { MenuID = 74, Name = "Quản lý người dùng", ParentID = 61, OrderNo = 74, IsShowMenu = true, Url = "" });
                //l2.ChildMenus.Add(new Data_Menu() { MenuID = 75, Name = "Thiết lập người dùng", ParentID = 74, OrderNo = 75, IsShowMenu = true, Url = "" });
                //l2.ChildMenus.Add(new Data_Menu() { MenuID = 76, Name = "Phân quyền", ParentID = 74, OrderNo = 76, IsShowMenu = true, Url = "" });
                l1.ChildMenus.Add(l2);
                reval.Add(l1);
                // ------------------------------------------

                #endregion
            }
            catch (Exception)
            {

            }
            return reval;
        }
    }
}
