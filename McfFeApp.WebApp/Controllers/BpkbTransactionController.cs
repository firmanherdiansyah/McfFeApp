using McfFeApp.WebApp.Dto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace McfFeApp.WebApp.Controllers
{
    public class BpkbTransactionController : Controller
    {

        private readonly IHttpClientFactory _httpClientFactory;

        public BpkbTransactionController(IHttpClientFactory httpClientFactory)
        {
            this._httpClientFactory = httpClientFactory;
        }

        private async Task<T?> InvokeEndpoint<T>(string clientName, string url)
        {
            BpkpTransaction? bpkbTransaction;

            var httpClient = _httpClientFactory.CreateClient(clientName);

            return await httpClient.GetFromJsonAsync<T>(url);
        }

        public async Task<IActionResult> Index()
        {
            using var httpClient = _httpClientFactory.CreateClient("McfAPI");

            var getResult = await httpClient.GetFromJsonAsync<List<StorageLocation>>("StorageLocation");

            ViewBag.Location = getResult.Select(l => new SelectListItem { Text = l.LocationName, Value = l.LocationId });

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(BpkpTransaction bpkpTransaction)
        {
            if (ModelState.IsValid) 
            {
                using var httpClient = _httpClientFactory.CreateClient("McfAPI");

                var result = await httpClient.PostAsJsonAsync("bpkptransaction", bpkpTransaction );

                result.EnsureSuccessStatusCode();
            }

            return RedirectToAction("Index");
        }




    }
}
