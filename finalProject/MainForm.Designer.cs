namespace finalProject
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.orderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._tsmiLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._lstShow = new System.Windows.Forms.ListBox();
            this._btnEdit = new System.Windows.Forms.Button();
            this._btnPrice = new System.Windows.Forms.Button();
            this._btnDelete = new System.Windows.Forms.Button();
            this._lblFoodName = new System.Windows.Forms.Label();
            this._lblFoodType = new System.Windows.Forms.Label();
            this._lblPrice = new System.Windows.Forms.Label();
            this._lblColories = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.orderToolStripMenuItem,
            this._tsmiLoad,
            this.saveToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // orderToolStripMenuItem
            // 
            this.orderToolStripMenuItem.Name = "orderToolStripMenuItem";
            this.orderToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.orderToolStripMenuItem.Text = "Order";
            this.orderToolStripMenuItem.Click += new System.EventHandler(this.OrderToolStripMenuItem_Click);
            // 
            // _tsmiLoad
            // 
            this._tsmiLoad.Name = "_tsmiLoad";
            this._tsmiLoad.Size = new System.Drawing.Size(45, 20);
            this._tsmiLoad.Text = "Load";
            this._tsmiLoad.Click += new System.EventHandler(this.OnclickLoad);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.saveToolStripMenuItem.Text = "save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // _lstShow
            // 
            this._lstShow.FormattingEnabled = true;
            this._lstShow.Location = new System.Drawing.Point(106, 69);
            this._lstShow.Name = "_lstShow";
            this._lstShow.Size = new System.Drawing.Size(477, 147);
            this._lstShow.TabIndex = 1;
            // 
            // _btnEdit
            // 
            this._btnEdit.Location = new System.Drawing.Point(106, 257);
            this._btnEdit.Name = "_btnEdit";
            this._btnEdit.Size = new System.Drawing.Size(75, 23);
            this._btnEdit.TabIndex = 2;
            this._btnEdit.Text = "Edit";
            this._btnEdit.UseVisualStyleBackColor = true;
            this._btnEdit.Click += new System.EventHandler(this.Button1_Click);
            // 
            // _btnPrice
            // 
            this._btnPrice.Location = new System.Drawing.Point(268, 257);
            this._btnPrice.Name = "_btnPrice";
            this._btnPrice.Size = new System.Drawing.Size(75, 23);
            this._btnPrice.TabIndex = 3;
            this._btnPrice.Text = "Total Price";
            this._btnPrice.UseVisualStyleBackColor = true;
            this._btnPrice.Click += new System.EventHandler(this._btnPrice_Click);
            // 
            // _btnDelete
            // 
            this._btnDelete.Location = new System.Drawing.Point(187, 257);
            this._btnDelete.Name = "_btnDelete";
            this._btnDelete.Size = new System.Drawing.Size(75, 23);
            this._btnDelete.TabIndex = 4;
            this._btnDelete.Text = "Delete";
            this._btnDelete.UseVisualStyleBackColor = true;
            this._btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // _lblFoodName
            // 
            this._lblFoodName.AutoSize = true;
            this._lblFoodName.Location = new System.Drawing.Point(103, 50);
            this._lblFoodName.Name = "_lblFoodName";
            this._lblFoodName.Size = new System.Drawing.Size(62, 13);
            this._lblFoodName.TabIndex = 5;
            this._lblFoodName.Text = "Food Name";
            // 
            // _lblFoodType
            // 
            this._lblFoodType.AutoSize = true;
            this._lblFoodType.Location = new System.Drawing.Point(171, 50);
            this._lblFoodType.Name = "_lblFoodType";
            this._lblFoodType.Size = new System.Drawing.Size(58, 13);
            this._lblFoodType.TabIndex = 6;
            this._lblFoodType.Text = "Food Type";
            // 
            // _lblPrice
            // 
            this._lblPrice.AutoSize = true;
            this._lblPrice.Location = new System.Drawing.Point(232, 50);
            this._lblPrice.Name = "_lblPrice";
            this._lblPrice.Size = new System.Drawing.Size(30, 13);
            this._lblPrice.TabIndex = 7;
            this._lblPrice.Text = "price";
            // 
            // _lblColories
            // 
            this._lblColories.AutoSize = true;
            this._lblColories.Location = new System.Drawing.Point(265, 50);
            this._lblColories.Name = "_lblColories";
            this._lblColories.Size = new System.Drawing.Size(43, 13);
            this._lblColories.TabIndex = 8;
            this._lblColories.Text = "calories";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._lblColories);
            this.Controls.Add(this._lblPrice);
            this.Controls.Add(this._lblFoodType);
            this.Controls.Add(this._lblFoodName);
            this.Controls.Add(this._btnDelete);
            this.Controls.Add(this._btnPrice);
            this.Controls.Add(this._btnEdit);
            this.Controls.Add(this._lstShow);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "bbbb ";
            this.Activated += new System.EventHandler(this.OnActivated);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem orderToolStripMenuItem;
        private System.Windows.Forms.ListBox _lstShow;
        private System.Windows.Forms.Button _btnEdit;
        private System.Windows.Forms.Button _btnPrice;
        private System.Windows.Forms.Button _btnDelete;
        private System.Windows.Forms.ToolStripMenuItem _tsmiLoad;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.Label _lblFoodName;
        private System.Windows.Forms.Label _lblFoodType;
        private System.Windows.Forms.Label _lblPrice;
        private System.Windows.Forms.Label _lblColories;
    }
}

