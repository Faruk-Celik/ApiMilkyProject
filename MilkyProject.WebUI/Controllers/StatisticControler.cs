using Microsoft.AspNetCore.Mvc;

namespace MilkyProject.WebUI.Controllers
{
    public class StatisticControler : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public StatisticControler (IHttpClientFactory httpClientFactory )
        {
            _httpClientFactory = httpClientFactory;
        }
        public async  Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responsemessage = await client.GetAsync("https://localhost:7202/api/StatisticControllers");
            var jsonData =await  responsemessage.Content.ReadAsStringAsync();
            ViewBag.CategoryCount = jsonData;
            return View();
        }
      
    }
}
