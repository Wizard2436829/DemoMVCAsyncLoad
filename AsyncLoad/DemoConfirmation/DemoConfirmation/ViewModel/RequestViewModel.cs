using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoConfirmation.ViewModel
{
    /// <summary></summary>
    public class RequestViewModel
    {
        /// <summary>Gets or sets my request.</summary>
        /// <value>My request.</value>
        //public Request MyRequest { get; set; }

        /// <summary>Gets or sets my request list.</summary>
        /// <value>My request list.</value>
        //public List<Request> MyRequestList { get; set; }

        public FlightJourneyModels.Request MyRequestFJ { get; set; }

        public List<FlightJourneyModels.Request> MyRequestFJList { get; set; }

        public FlightJourneyModels.Response MyResponseFJ { get; set; }

        public List<FlightJourneyModels.Response> MyResponseFJList { get; set; }

        public BookingDataLibrary.BookingData MyBookingData { get; set; }
    }
}