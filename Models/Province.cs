using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProvinceCity.Models
{
    public class Province
    {
        [Key]
        public string ProvinceCode { get; set; }
        public string ProvinceName { get; set; }
        public List<City> cities { get; set; }
    }
}