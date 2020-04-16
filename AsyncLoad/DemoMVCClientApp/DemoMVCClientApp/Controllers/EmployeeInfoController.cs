using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using DemoMVCClientApp.Models;
using Newtonsoft.Json;

namespace DemoMVCClientApp.Controllers
{
    public class EmployeeInfoController : Controller
    {
        HttpClient client;
        //The URL of the WEB API Service
        string url = "https://localhost:44390/api/EmployeeInfoAPI";

        //The HttpClient Class, this will be used for performing 
        //HTTP Operations, GET, POST, PUT, DELETE
        //Set the base address and the Header Formatter
        public EmployeeInfoController()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri(url);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        // GET: EmployeeInfo
        public async Task<ActionResult> Index()
        {
            HttpResponseMessage responseMessage = await client.GetAsync(url);
            if (responseMessage.IsSuccessStatusCode)
            {
                var responseData = responseMessage.Content.ReadAsStringAsync().Result;

                var Employees = JsonConvert.DeserializeObject<List<EmployeeInfo>>(responseData);

                return View("EmployeeList",Employees);
            }
            return View("Error");
        }

        public ActionResult Create()
        {
            return View("CreateEmployee",new EmployeeInfo());
        }

        //The Post method
        [HttpPost]
        public async Task<ActionResult> Create(EmployeeInfo Emp)
        {
            var json = JsonConvert.SerializeObject(Emp);
            var stringContent = new StringContent(json, UnicodeEncoding.UTF8, "application/json");

            HttpResponseMessage responseMessage = await client.PostAsync(url, stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return RedirectToAction("Error");
        }

        public async Task<ActionResult> Edit(int id)
        {
            HttpResponseMessage responseMessage = await client.GetAsync(url + "/" + id);
            if (responseMessage.IsSuccessStatusCode)
            {
                var responseData = responseMessage.Content.ReadAsStringAsync().Result;

                var Employee = JsonConvert.DeserializeObject<EmployeeInfo>(responseData);

                return View("EditEmployee",Employee);
            }
            return View("Error");
        }

        //The PUT Method
        [HttpPost]
        public async Task<ActionResult> Edit(int id, EmployeeInfo Emp)
        {
            var json = JsonConvert.SerializeObject(Emp);
            var stringContent = new StringContent(json, UnicodeEncoding.UTF8, "application/json");

            HttpResponseMessage responseMessage = await client.PutAsync(url + "/" + id, stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return RedirectToAction("Error");
        }

        public async Task<ActionResult> Delete(int id)
        {
            HttpResponseMessage responseMessage = await client.GetAsync(url + "/" + id);
            if (responseMessage.IsSuccessStatusCode)
            {
                var responseData = responseMessage.Content.ReadAsStringAsync().Result;

                var Employee = JsonConvert.DeserializeObject<EmployeeInfo>(responseData);

                return View("DeleteEmployee",Employee);
            }
            return View("Error");
        }

        //The DELETE method
        [HttpPost]
        public async Task<ActionResult> Delete(int id, EmployeeInfo Emp)
        {

            HttpResponseMessage responseMessage = await client.DeleteAsync(url + "/" + id);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return RedirectToAction("Error");
        }
    }
}