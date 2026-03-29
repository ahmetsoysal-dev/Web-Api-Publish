using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace iakademi_WEBAPI_PUBLISH.Models.MVVM
{
    public class Category
    {
        public int CategoryID { get; set; }


        public string? CategoryName { get; set; }


        public int? ParentID { get; set; }


        public bool Active { get; set; }
    }
}
