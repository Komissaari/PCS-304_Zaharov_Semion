using System.ComponentModel.DataAnnotations;
namespace Laba_2
{
    public class NewCar:IValidateble
    {
        
        public string CarBrand { get; set; }
        [StringLength(5)]
        public string CarName { get; set; }
        [Range(2000, 2023)]
        public int CarYear { get; set; }
    }
}
