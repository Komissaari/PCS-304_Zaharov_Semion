using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Laba_2
{
    public static class Valid
    {
        public static void Val (this IValidateble valid)
        {
            var  validcont = new ValidationContext(valid);
            var pole = new List<ValidationResult>();
            bool _true = Validator.TryValidateObject(valid, validcont, pole, true);
            if (_true)
            {
                Console.WriteLine("Всё прошло!");
            }
            else
            {
                Console.WriteLine("Всё плохо!");
            }
        }
    }
}
