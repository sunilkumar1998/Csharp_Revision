using System;
using System.Collections.Generic;
using System.Text;

namespace ProductProcessing.Databases
{
	public class BasicProduct : BaseRecordType
    {
        public long ProductCode { get; set; }
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public string ManufacturingDate { get; set; }
        public string ExpiryDate { get; set; }
        public decimal Amount { get; set; }



        public static List<BasicProduct> _products = new List<BasicProduct>()

        {
             new BasicProduct
            {
                categoryCode="bev",
                ProductCode=1,
                Name="frooti",
                Amount=38,
                Manufacturer="Parle",
                ExpiryDate="12-09-2022",
                ManufacturingDate= "25-04-2020",
            },

            new BasicProduct
            {
                categoryCode="bev",
                ProductCode=2,
                Name="pepsi",
                Amount=48,
                Manufacturer="PepsiCo",
                ExpiryDate="12-09-2022",
                ManufacturingDate= "25-04-2020",
            },
                     new BasicProduct
            {
                categoryCode="bev",
                ProductCode=3,
                Name="Appy",
                Amount=180,
                Manufacturer="Parle",
                ExpiryDate="12-09-2022",
                ManufacturingDate= "25-04-2020",
            },


            new BasicProduct
            {
                categoryCode="choc",
                ProductCode=4,
                Name="perk",
                Amount=10,
                Manufacturer="cadbury",
                ExpiryDate="12-09-2022",
                ManufacturingDate= "21-04-2020",
            },

            new BasicProduct
            {
                categoryCode="choc",
                ProductCode=5,
                Name="5 star",
                Amount=10,
                Manufacturer="cadbury",
                ExpiryDate="12-09-2022",
                ManufacturingDate= "21-04-2020",
            },
             new BasicProduct
            {
                categoryCode="choc",
                ProductCode=6,
                Name="Choco",
                Amount=10,
                Manufacturer="cadbury",
                ExpiryDate="12-09-2022",
                ManufacturingDate= "21-04-2020",
            },



            new BasicProduct
            {
                categoryCode="spek",
                ProductCode=7,
                Name="sounDX",
                Amount=5999,
                Manufacturer="portron",
                ExpiryDate="12-09-2022",
                ManufacturingDate= "21-04-2020",
            },


            new BasicProduct
            {
                categoryCode="spek",
                ProductCode=8,
                Name="boat ",
                Amount=4589,
                Manufacturer="boat",
                ExpiryDate="12-09-2022",
                ManufacturingDate= "21-04-2020",
            },
            new BasicProduct
            {
                categoryCode="spek",
                ProductCode=9,
                Name="JBlQ",
                Amount=7899,
                Manufacturer="JBL",
                ExpiryDate="12-09-2022",
                ManufacturingDate= "21-04-2020",
            }
        };
    }
}
