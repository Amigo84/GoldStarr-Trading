using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GoldStarr_Trading.Classes
{
    public class MerchandiseClass : INotifyPropertyChanged
    {

        #region Properties
        private string _merchandiseName;
        public string MerchandiseName  //Get ger värde av _merchandiseName till MerchandiseName (som kan inte ändras)
        {
            get => _merchandiseName;
            set
            {
                if (_merchandiseName != value)
                {
                    _merchandiseName = value;
                    this.OnPropertyChanged();
                }
            }
        }

        private string _merchandiseSupplier;
        public string MerchandiseSupplier
        {
            get => _merchandiseSupplier;
            set
            {
                if (_merchandiseSupplier != value)
                {
                    _merchandiseSupplier = value;
                    this.OnPropertyChanged();
                }
            }
        }

        private int _merchandiseStock;
        public int MerchandiseStock
        {
            get => _merchandiseStock;
            set
            {
                if (_merchandiseStock != value)
                {
                    _merchandiseStock = value;
                    this.OnPropertyChanged();
                }
            }
        }

        public string ShowStock => $"Supplier: {MerchandiseSupplier}  Item: {MerchandiseName}  Stock: {MerchandiseStock}";

        #endregion


        #region Constructors
        public MerchandiseClass(string itemName, string inputSupplier, int qty)
        {
            this.MerchandiseName = itemName;
            this.MerchandiseSupplier = inputSupplier;
            this.MerchandiseStock = qty;

        }
        #endregion


        #region OLD
        //public static MerchandiseClass[] merchandiseList =
        //{
        //    new MerchandiseClass { Name = "Hydrospanner",       Supplier = "Acme AB",           Stock = 0 },
        //    new MerchandiseClass { Name = "Airscoop",           Supplier = "Acme AB",           Stock = 1 },
        //    new MerchandiseClass { Name = "Hyper-transceiver",  Supplier = "Corelian Inc",      Stock = 2 },
        //    new MerchandiseClass { Name = "Nanosporoid",        Supplier = "Corelian Inc",      Stock = 3 },
        //    new MerchandiseClass { Name = "Boarding-spike",     Supplier = "Joruba Consortium", Stock = 4 },
        //};
        #endregion


        #region Methods

        public void GetProductInfo()
        {
            throw new System.NotImplementedException();
        }

        #region PropertyChangedEventHandler
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string propertyName = null) =>
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        #endregion

        #endregion


    }
}
