using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SistemaWebVuelos.Validations
{
    public class CheckFecha : ValidationAttribute
    {
        public CheckFecha()
        {
            ErrorMessage = "La fecha es menor a la fecha actual";
        }
        public override bool IsValid(object value)
        {
           

            if (DateTime.Compare(DateTime.Now, Convert.ToDateTime(value)) > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }


    }
}