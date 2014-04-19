using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleCloud
{
    public class PropertyClass : DataClass
    {
        
        //tblcountry

        public int CountryID { get; set; }
        public string CountryName { get; set; }

        //tbluserdata

        public int UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }
}