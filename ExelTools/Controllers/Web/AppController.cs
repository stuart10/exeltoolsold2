﻿using Microsoft.AspNetCore.Mvc;



namespace ExelTools.Controllers.Web
{
    public class AppController : Controller
    {

        private readonly string workspaceCollection;
        private readonly string workspaceId;
        private readonly string accessKey;
        private readonly string apiUrl;

        public AppController()
        {
            //this.workspaceCollection = System.Configuration.ConfigurationManager.AppSettings["powerbi:WorkspaceCollection"];
            //this.workspaceId = ConfigurationManager.AppSettings["powerbi:WorkspaceId"];
            //this.accessKey = ConfigurationManager.AppSettings["powerbi:AccessKey"];
            //this.apiUrl = ConfigurationManager.AppSettings["powerbi:ApiUrl"];
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Sales()
        {
            return View();
        }

        public IActionResult Customers()
        {
            return View();
        }

        public IActionResult Products()
        {
            return View();
        }

        public IActionResult Suppliers()
        {
            return View();
        }
        public IActionResult Traffic()
        {
            return View();
        }
        public IActionResult Campaigns()
        {
            return View();
        }

        public IActionResult UpdateWebProducts()
        {
            return View();
        }

        //[ChildActionOnly]
        //public ActionResult Reports()
        //{
        //    using (var client = this.CreatePowerBIClient())
        //    {
        //        var reportsResponse = client.Reports.GetReports(this.workspaceCollection, this.workspaceId);

        //        var viewModel = new ReportsViewModel
        //        {
        //            Reports = reportsResponse.Value.ToList()
        //        };

        //        return PartialView(viewModel);
        //    }
        //}

        //private IPowerBIClient CreatePowerBIClient()
        //{
        //    var credentials = new TokenCredentials(accessKey, "AppKey");
        //    var client = new PowerBIClient(credentials)
        //    {
        //        BaseUri = new Uri(apiUrl)
        //    };

        //    return client;
        //}

    }
}
