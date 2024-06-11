using Microsoft.AspNetCore.Mvc;

namespace WDI.OEE.Controllers
{
    public class FileController : Controller
    {
        private readonly IWebHostEnvironment _webHostEnvironment;

        public FileController(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }


        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> DownloadBlank(string fName)
        {
            var path = Path.Combine($"{_webHostEnvironment.WebRootPath}\\uploads\\documents\\Weldcom_blank.pdf");
            var memory = new MemoryStream();
            using (var stream = new FileStream(path, FileMode.Open))
            {
                await stream.CopyToAsync(memory);
            }
            memory.Position = 0;
            var ext = Path.GetExtension(fName).ToLowerInvariant();
            return File(memory, Common.FileExtension.GetMimeType(fName), Path.GetFileName(fName));
        }
    }
}
