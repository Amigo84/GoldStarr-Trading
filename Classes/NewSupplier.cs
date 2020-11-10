using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldStarr_Trading.Classes
{
    class NewSupplier
    {
        
        //Skapar NewSupVariabel som ska lagra namnet och tillhöra alla instanser av klssen New
        public string varNewSupName { get; set; }


        //Metoden tar emot ny namn och ändrar namnet och returnera den nya namnet
        public  void NewSupplierName(string _newname)
        {
            this.varNewSupName = _newname;
            //return varNewSupName;
            
        }

        /*
        public string NewSupplierName
        {
            get { return NewSupName; }
            set { NewSupName = value; }
        } */
    }
}
