using System;
using Microsoft.AspNetCore.Mvc;

namespace MasterDetailTwoDataGrid.Controllers
{
    public partial class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
