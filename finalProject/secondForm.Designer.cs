namespace finalProject
{
    partial class secondForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._lblName = new System.Windows.Forms.Label();
            this._lblFoodType = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this._lstFood = new System.Windows.Forms.ListBox();
            this._btnAdd = new System.Windows.Forms.Button();
            this._btnClose = new System.Windows.Forms.Button();
            this._lblPrice = new System.Windows.Forms.Label();
            this._txtPrice = new System.Windows.Forms.TextBox();
            this._lblCalories = new System.Windows.Forms.Label();
            this._txtCalories = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // _lblName
            // 
            this._lblName.AutoSize = true;
            this._lblName.Location = new System.Drawing.Point(152, 81);
            this._lblName.Name = "_lblName";
            this._lblName.Size = new System.Drawing.Size(62, 13);
            this._lblName.TabIndex = 0;
            this._lblName.Text = "Food Name";
            // 
            // _lblFoodType
            // 
            this._lblFoodType.AutoSize = true;
            this._lblFoodType.Location = new System.Drawing.Point(152, 44);
            this._lblFoodType.Name = "_lblFoodType";
            this._lblFoodType.Size = new System.Drawing.Size(58, 13);
            this._lblFoodType.TabIndex = 1;
            this._lblFoodType.Text = "Food Type";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Starters",
            "Soups"});
            this.comboBox1.Location = new System.Drawing.Point(263, 44);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(263, 81);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 3;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.ComboBox2_SelectedIndexChanged);
            // 
            // _lstFood
            // 
            this._lstFood.FormattingEnabled = true;
            this._lstFood.Items.AddRange(new object[] {
            "Food Type        Food Name        Price        Calories",
            "Starters             Chicken kabob   17             200",
            "Starters             Chicken Tikka    25             330",
            "Soups               Chicken soup     16             270",
            "Soups               Tomato soup      20             190"});
            this._lstFood.Location = new System.Drawing.Point(123, 232);
            this._lstFood.Name = "_lstFood";
            this._lstFood.Size = new System.Drawing.Size(392, 108);
            this._lstFood.TabIndex = 4;
            // 
            // _btnAdd
            // 
            this._btnAdd.Location = new System.Drawing.Point(216, 174);
            this._btnAdd.Name = "_btnAdd";
            this._btnAdd.Size = new System.Drawing.Size(75, 23);
            this._btnAdd.TabIndex = 5;
            this._btnAdd.Text = "Add";
            this._btnAdd.UseVisualStyleBackColor = true;
            this._btnAdd.Click += new System.EventHandler(this.OnClickAdd);
            // 
            // _btnClose
            // 
            this._btnClose.Location = new System.Drawing.Point(309, 174);
            this._btnClose.Name = "_btnClose";
            this._btnClose.Size = new System.Drawing.Size(75, 23);
            this._btnClose.TabIndex = 6;
            this._btnClose.Text = "Close";
            this._btnClose.UseVisualStyleBackColor = true;
            this._btnClose.Click += new System.EventHandler(this.OnClickClose);
            // 
            // _lblPrice
            // 
            this._lblPrice.AutoSize = true;
            this._lblPrice.Location = new System.Drawing.Point(155, 110);
            this._lblPrice.Name = "_lblPrice";
            this._lblPrice.Size = new System.Drawing.Size(31, 13);
            this._lblPrice.TabIndex = 7;
            this._lblPrice.Text = "Price";
            // 
            // _txtPrice
            // 
            this._txtPrice.Location = new System.Drawing.Point(263, 110);
            this._txtPrice.Name = "_txtPrice";
            this._txtPrice.ReadOnly = true;
            this._txtPrice.Size = new System.Drawing.Size(121, 20);
            this._txtPrice.TabIndex = 8;
            // 
            // _lblCalories
            // 
            this._lblCalories.AutoSize = true;
            this._lblCalories.Location = new System.Drawing.Point(155, 142);
            this._lblCalories.Name = "_lblCalories";
            this._lblCalories.Size = new System.Drawing.Size(44, 13);
            this._lblCalories.TabIndex = 9;
            this._lblCalories.Text = "Calories";
            // 
            // _txtCalories
            // 
            this._txtCalories.Location = new System.Drawing.Point(263, 139);
            this._txtCalories.Name = "_txtCalories";
            this._txtCalories.ReadOnly = true;
            this._txtCalories.Size = new System.Drawing.Size(121, 20);
            this._txtCalories.TabIndex = 10;
            // 
            // secondForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._txtCalories);
            this.Controls.Add(this._lblCalories);
            this.Controls.Add(this._txtPrice);
            this.Controls.Add(this._lblPrice);
            this.Controls.Add(this._btnClose);
            this.Controls.Add(this._btnAdd);
            this.Controls.Add(this._lstFood);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this._lblFoodType);
            this.Controls.Add(this._lblName);
            this.Name = "secondForm";
            this.Text = "secondForm";
            this.Activated += new System.EventHandler(this.onActivated);
            this.Load += new System.EventHandler(this.SecondForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _lblName;
        private System.Windows.Forms.Label _lblFoodType;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ListBox _lstFood;
        private System.Windows.Forms.Button _btnAdd;
        private System.Windows.Forms.Button _btnClose;
        private System.Windows.Forms.Label _lblPrice;
        private System.Windows.Forms.TextBox _txtPrice;
        private System.Windows.Forms.Label _lblCalories;
        private System.Windows.Forms.TextBox _txtCalories;
    }
}