using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace finalProject
{
    #region Declaration and intialzation
    public partial class secondForm : Form
    {
        //declaration
        string _foodName;
        string _foodType;
        double _price;
       // adding geter and setter 
        public string FoodName
        {
            get
            {
                return _foodName;
            }

            set
            {
                _foodName = value;
            }
        }

        public string FoodType
        {
            get
            {
                return _foodType;
            }

            set
            {
                _foodType = value;
            }
        }

        public double Price
        {
            get
            {
                return _price;
            }

            set
            {
                _price = value;
            }
        }

        // intialize
        public secondForm()
        {
            InitializeComponent();
        }
        #endregion
        #region _OTHERMEHTOD
        /// <summary>
        /// to select item from combobox or dropdown
        /// combobox2 depends on combobox1 value
        /// when user select the food type then food names will appear.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // combobox1 will show the detail aout food type
            // if condition is to select the first index of dropdown
            if (comboBox1.SelectedIndex==0)
            {
                comboBox2.SelectedItem = null;
                comboBox2.Items.Clear();

                comboBox2.Items.Add(new ListItem("Chicken Kabob", "Chicken kabob"));
                comboBox2.Items.Add(new ListItem("Chicken Tikka", "Chicken Tikka"));

            }
            // if condition is to select the second index of dropdown
            if (comboBox1.SelectedIndex == 1) 
            {
                comboBox2.SelectedItem = null;

                comboBox2.Items.Clear();
                comboBox2.Items.Add(new ListItem("Chicken soup", "Chicken soup"));
                comboBox2.Items.Add(new ListItem("Tomato soup", "Chicken soup"));
                // below your code to get the second drop down list value filtered on first selection


            }
        }

        private void SecondForm_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// on click add the order will take place
        /// in this method value will send to mainform
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnClickAdd(object sender, EventArgs e)
        {
            MainForm form1  = (MainForm)Application.OpenForms["MainForm"]; 
            form1.FoodName = (comboBox2.SelectedItem).ToString();
            form1.FoodType = (comboBox1.SelectedItem).ToString();
            form1.Price = double.Parse(_txtPrice.Text.ToString());
            form1.Calories = double.Parse(_txtCalories.Text.ToString());
            form1.Validation = "Button is Clicked";
            this.Close();
        }
/// <summary>
/// close the window
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
        private void OnClickClose(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        ///  select a price and calaroies
        /// by selecting the value from foodtype
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                if (comboBox2.SelectedIndex == 0)
                {
                    _txtPrice.Text = "17";
                    _txtCalories.Text = "200";
                }
                else if (comboBox2.SelectedIndex == 1)
                {
                    _txtPrice.Text = "25";
                    _txtCalories.Text = "330";
                }
            }
            else if(comboBox1.SelectedIndex == 1)
            {
                if (comboBox2.SelectedIndex == 0)
                {
                    _txtPrice.Text = "16";
                    _txtCalories.Text = "270";
                }
                else if (comboBox2.SelectedIndex == 1)
                {
                    _txtPrice.Text = "20";
                    _txtCalories.Text = "190";
                }
            }
        }
        /// <summary>
        /// to select item from combobox or dropdown
        /// combobox2 depends on combobox1 value
        /// when user select the food type then food names will appear.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void onActivated(object sender, EventArgs e)
        {
            if (_foodType == "Starters")
            {
                comboBox1.SelectedIndex = 0;

                if (_foodName == "Chicken Kabob")
                    comboBox2.SelectedIndex = 0;
                else if (_foodName == "Chicken Tikka")
                    comboBox2.SelectedIndex = 1;
            }
            else if (_foodType == "Soups")
            {
                comboBox1.SelectedIndex = 1;

                if (_foodName == "Chicken soup")
                    comboBox2.SelectedIndex = 0;
                else if (_foodName == "Tomato soup")
                    comboBox2.SelectedIndex = 1;
            }

        }
        #endregion
    }
}
