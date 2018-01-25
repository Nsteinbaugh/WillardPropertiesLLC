using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WillardPropertiesLLC.Models
{
    public class PropertyViewModel
    {
        private int description { get; set; }
        private string address { get; set; }
        private string image { get; set; }
        private string numberOfBeds { get; set; }
        private string numberOfBaths { get; set; }
        private bool forRent { get; set; }
        private double rentAmount { get; set; }
    }
}
