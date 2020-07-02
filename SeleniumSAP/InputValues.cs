using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumSAP
{
    public class InputValues
    {
        public static string QuantityInCloningWizard { get; set; }
        public static string DateInCloningWizard { get; set; } 

    public static void SetValues()
    {
        QuantityInCloningWizard = "25";

            //Format : mm/dd/yy
            DateInCloningWizard = "04/21/20";


    }

    }

}
