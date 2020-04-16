using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using BookingDataLibrary;
using DemoConfirmation.ViewModel;
using DemoConfirmation.Models;

namespace DemoConfirmation.Controllers
{
    public class ConfirmationController : Controller
    {
        // GET: Confirmation
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult LoadConfirmationView()
        {
            RequestViewModel RVMObj = new RequestViewModel();
            RVMObj.MyBookingData = ReturnTempRequest();

            return View("FinalConfirmation", RVMObj);
        }

        public BookingDataLibrary.BookingData ReturnTempRequest()
        {
            string FilePath = HttpContext.Server.MapPath("~/DemoTextFiles/TempBookingDataFile.txt");
            string TempResults = "";

            var fileStream = new FileStream(FilePath, FileMode.Open, FileAccess.Read);
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
            {
                TempResults = streamReader.ReadToEnd();
            }

            var TempRespObj = JsonConvert.DeserializeObject<BookingDataLibrary.BookingData>(TempResults);

            return TempRespObj;
        }

        public ActionResult DemoDateConvert()
        {
            DateTimeConvert DTC = new DateTimeConvert();

            DTC.DXBDateTimeString = "2020-04-29T10:00:00.000+02:00";
            //DTC.DXBDateTimeString = "2020-04-12T10:35:00.000+04:00";

            DTC.SFODateTimeString = "2020-04-29T12:22:00.000-04:00";
            //DTC.SFODateTimeString = "2020-04-12T10:35:00.000-07:00";

            DTC.SomeDTOffsetDemoDT = DateTimeOffset.Parse("2020-04-18T20:05:00.000-04:00");

            return View("DTCDisplay",DTC);
        }
    }
}