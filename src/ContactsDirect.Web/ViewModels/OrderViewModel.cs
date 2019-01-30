using ContactsDirect.Data.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContactsDirect.Web.ViewModels
{
    public class OrderViewModel
    {
        public List<lenstype> lenstype { get; set; }
        public List<subscriptionlength> subscriptionlength { get; set; }
        public List<paymentmethod> paymentmethod { get; set; }
        public List<prescriptiontype> prescriptiontype { get; set; }
        public List<optionalproduct> optionalproduct { get; set; }
    }
}