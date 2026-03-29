using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace iakademi_WEBAPI_PUBLISH.Models.MVVM
{
    public class Product
    {
        public int ProductID { get; set; }

        private string? _ProductName { get; set; }

        public string? ProductName
        {
            get { return _ProductName; }
            set { _ProductName = value?.ToUpper(); }
        }


        public decimal UnitPrice { get; set; }


        public int CategoryID { get; set; }


        public int SupplierID { get; set; }


        public int StatusID { get; set; }


        public int Stock { get; set; }


        public int Discount { get; set; }


        public DateTime AddDate { get; set; }


        public string? Keywords { get; set; }


        //Encapsulation = Kapsülleme
        private int _Kdv { get; set; }
        public int Kdv
        {
            get { return _Kdv; }
            set { _Kdv = Math.Abs(value); }
        }

        public int HighLighted { get; set; } //öne cıkanlar = like


        public int TopSeller { get; set; } //CokSatanlar


        public int Related { get; set; } //BunaBakanlar


        public string? Notes { get; set; }


        public string? PhotoPath { get; set; }


        public bool Active { get; set; }
    }
}
