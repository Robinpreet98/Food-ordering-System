using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace finalProject
{
    public partial class MainForm : Form
    {
        #region INTIALIZATION
        List<customer> foodlist; // declaration of list
        string _foodName;
        string _foodType;
        double _calories;
        double _price;
        string _validation;
        double _totalPrice;
        double _totalCalories;
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

        public double Calories
        {
            get
            {
                return _calories;
            }

            set
            {
                _calories = value;
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

     

        public string Validation
        {
            get
            {
                return _validation;
            }

            set
            {
                _validation = value;
            }
        }


        public MainForm()
        {
            InitializeComponent();

            //Adding an elements to lists
            if (foodlist == null)
            {
                foodlist = new List<customer>();

            }
        }
        #endregion
        /// <summary>
        /// when user click on order in menuitem then the second window will appear
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form otherForm = new secondForm(); //declaring object of second form
            otherForm.Show();
        }
        /// <summary>
        /// on activated main form values will get from second form in a list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnActivated(object sender, EventArgs e)
        {
            if (_foodName != String.Empty && _foodType != String.Empty && _price != 0 && _validation == "Button is Clicked")
            {
                customer cust = new customer(_foodName, _foodType, _price,_calories); //getting value from customer
                foodlist.Add(cust); // adding values to list

                _totalPrice += _price;
                _totalCalories += _calories;
                _lstShow.Items.Clear(); // clear the items in listbox


                //adding values in listbox
                foreach (customer student1 in foodlist)
                {
                    _lstShow.Items.Add(student1.ToString());

                }
                _validation = "Not Clicked";
            }

        }
        /// <summary>
        /// on click edit button the following event will call
        /// in this method value will be edited and updated.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button1_Click(object sender, EventArgs e)
        {
            string text = _lstShow.GetItemText(_lstShow.SelectedItem);
            string[] fields = text.Split('\t');
            foodlist.RemoveAt(_lstShow.SelectedIndex);
            secondForm otherForm = new secondForm();
            otherForm.Show();
            secondForm form2 = (secondForm)Application.OpenForms["secondForm"];
            form2.FoodName = fields[0];
            form2.FoodType = fields[1]; 
            
        }
        /// <summary>
        /// on click price the following method will call
        /// to calculate price and calories
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _btnPrice_Click(object sender, EventArgs e)
        {
            Manager manager = new Manager();

           
            _totalPrice = manager.CalculatePrice(_totalPrice);

            _lstShow.Items.Add("Total Price: " + _totalPrice  + "\t"+"Total Calories: " + _totalCalories);



        }
        /// <summary>
        /// this function will delete the order from list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (_lstShow.SelectedIndex != -1)//Make sure a student is selected
            {
                int indexToDelete = _lstShow.SelectedIndex;
                foodlist.RemoveAt(indexToDelete);
                _lstShow.Items.Clear();
                foreach (customer item in foodlist)
                {
                    _totalPrice += _price;
                }

            }
            else
            {
                MessageBox.Show("Please select a student to delete");

            }

            foreach (customer student1 in foodlist)
            {


                _lstShow.Items.Add(student1.ToString());

            }
        }

        /// <summary>
        /// load the data in listbox from saved file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnclickLoad(object sender, EventArgs e)
        {
            var saveFile = new OpenFileDialog
            {
                Filter = "Text (*.txt)|*.txt"
            };

            try
            {
                if (saveFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    using (var streamReader = new StreamReader(saveFile.FileName, false))
                        while (streamReader.Peek() != -1)
                        {

                            string record = streamReader.ReadLine();
                            string[] fields = record.Split('\t');
                            customer s = new customer(fields[0], (fields[1]), double.Parse(fields[2]), double.Parse(fields[3]));
                            foodlist.Add(s);
                            _lstShow.Items.Clear();



                            foreach (customer student1 in foodlist)
                            {


                                _lstShow.Items.Add(student1.ToString());

                            }

                        }
                    MessageBox.Show("Success");
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("File Not Found");
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message, "IOException");

            }
        }
        /// <summary>
        /// save the listbox data to a file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var saveFile = new SaveFileDialog
            {
                Filter = "Text (*.txt)|*.txt"
            };


            try
            {
                if (saveFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    using (var streamWriter = new StreamWriter(saveFile.FileName, false))
                        foreach (customer s in foodlist)
                            streamWriter.WriteLine(s.ToString());
                    MessageBox.Show("Success");
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("File Not Found");
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message, "IOException");

            }
        }
    }
}
