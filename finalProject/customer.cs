using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalProject
{
    class customer
    {
        //declaration of fields variable
        private string _foodName;
        private string _foodType;
        public double _price;
        private double _calories;

        //declaring default constructor
        public customer()
        {

        }
        public customer(string foodName,string foodType, double Price,double calories)
        {
            this._foodName = foodName;
            this._foodType = foodType;
            this._price = Price;
            this._calories = calories;
        }
        // to display the value in string format or display the values in listbox
        public override string ToString()
        {
            return string.Format("{0}\t{1}\t{2}\t{3}", _foodName, _foodType, _price,_calories);
        }

     


       
    }
}