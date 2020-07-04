namespace AutosalonProject
{
    partial class FormAuto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAuto));
            this.Model = new System.Windows.Forms.Label();
            this.Color = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.Label();
            this.GosNumber = new System.Windows.Forms.Label();
            this.YearRelease = new System.Windows.Forms.Label();
            this.textBoxModel = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxGosNumber = new System.Windows.Forms.TextBox();
            this.textBoxYearRelease = new System.Windows.Forms.TextBox();
            this.listViewCar = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Model1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Color1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GosNumber1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.YearRelease1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comboBoxColor = new System.Windows.Forms.ComboBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Model
            // 
            this.Model.AutoSize = true;
            this.Model.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Model.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Model.Location = new System.Drawing.Point(20, 110);
            this.Model.Name = "Model";
            this.Model.Size = new System.Drawing.Size(97, 19);
            this.Model.TabIndex = 0;
            this.Model.Text = "Модель авто";
            // 
            // Color
            // 
            this.Color.AutoSize = true;
            this.Color.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Color.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Color.Location = new System.Drawing.Point(20, 189);
            this.Color.Name = "Color";
            this.Color.Size = new System.Drawing.Size(75, 19);
            this.Color.TabIndex = 1;
            this.Color.Text = "Цвет авто";
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Price.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Price.Location = new System.Drawing.Point(20, 256);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(44, 19);
            this.Price.TabIndex = 2;
            this.Price.Text = "Цена";
            // 
            // GosNumber
            // 
            this.GosNumber.AutoSize = true;
            this.GosNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.GosNumber.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GosNumber.Location = new System.Drawing.Point(20, 339);
            this.GosNumber.Name = "GosNumber";
            this.GosNumber.Size = new System.Drawing.Size(82, 19);
            this.GosNumber.TabIndex = 3;
            this.GosNumber.Text = "Гос. Номер";
            // 
            // YearRelease
            // 
            this.YearRelease.AutoSize = true;
            this.YearRelease.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.YearRelease.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.YearRelease.Location = new System.Drawing.Point(20, 417);
            this.YearRelease.Name = "YearRelease";
            this.YearRelease.Size = new System.Drawing.Size(91, 19);
            this.YearRelease.TabIndex = 4;
            this.YearRelease.Text = "Год выпуска";
            // 
            // textBoxModel
            // 
            this.textBoxModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxModel.Location = new System.Drawing.Point(23, 131);
            this.textBoxModel.Multiline = true;
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.Size = new System.Drawing.Size(200, 36);
            this.textBoxModel.TabIndex = 5;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPrice.Location = new System.Drawing.Point(23, 278);
            this.textBoxPrice.Multiline = true;
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(200, 36);
            this.textBoxPrice.TabIndex = 7;
            // 
            // textBoxGosNumber
            // 
            this.textBoxGosNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxGosNumber.Location = new System.Drawing.Point(23, 361);
            this.textBoxGosNumber.Multiline = true;
            this.textBoxGosNumber.Name = "textBoxGosNumber";
            this.textBoxGosNumber.Size = new System.Drawing.Size(200, 36);
            this.textBoxGosNumber.TabIndex = 8;
            // 
            // textBoxYearRelease
            // 
            this.textBoxYearRelease.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxYearRelease.Location = new System.Drawing.Point(23, 439);
            this.textBoxYearRelease.Multiline = true;
            this.textBoxYearRelease.Name = "textBoxYearRelease";
            this.textBoxYearRelease.Size = new System.Drawing.Size(200, 36);
            this.textBoxYearRelease.TabIndex = 9;
            // 
            // listViewCar
            // 
            this.listViewCar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Model1,
            this.Color1,
            this.Price1,
            this.GosNumber1,
            this.YearRelease1});
            this.listViewCar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listViewCar.FullRowSelect = true;
            this.listViewCar.GridLines = true;
            this.listViewCar.HideSelection = false;
            this.listViewCar.Location = new System.Drawing.Point(254, 131);
            this.listViewCar.MultiSelect = false;
            this.listViewCar.Name = "listViewCar";
            this.listViewCar.Size = new System.Drawing.Size(675, 344);
            this.listViewCar.TabIndex = 10;
            this.listViewCar.UseCompatibleStateImageBehavior = false;
            this.listViewCar.View = System.Windows.Forms.View.Details;
            this.listViewCar.SelectedIndexChanged += new System.EventHandler(this.ListViewCar_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 40;
            // 
            // Model1
            // 
            this.Model1.Text = "Модель авто";
            this.Model1.Width = 119;
            // 
            // Color1
            // 
            this.Color1.Text = "Цвет авто";
            this.Color1.Width = 119;
            // 
            // Price1
            // 
            this.Price1.Text = "Цена";
            this.Price1.Width = 104;
            // 
            // GosNumber1
            // 
            this.GosNumber1.Text = "Гос. Номер";
            this.GosNumber1.Width = 125;
            // 
            // YearRelease1
            // 
            this.YearRelease1.Text = "Год выпуска";
            this.YearRelease1.Width = 183;
            // 
            // comboBoxColor
            // 
            this.comboBoxColor.FormattingEnabled = true;
            this.comboBoxColor.Items.AddRange(new object[] {
            "Красный",
            "Фиолетовый",
            "Зелёный",
            "Чёрный",
            "Белый",
            "Синий"});
            this.comboBoxColor.Location = new System.Drawing.Point(23, 212);
            this.comboBoxColor.Name = "comboBoxColor";
            this.comboBoxColor.Size = new System.Drawing.Size(200, 21);
            this.comboBoxColor.TabIndex = 15;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(133)))), ((int)(((byte)(38)))));
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.Location = new System.Drawing.Point(428, 501);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(149, 63);
            this.buttonAdd.TabIndex = 16;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(133)))), ((int)(((byte)(38)))));
            this.buttonEdit.FlatAppearance.BorderSize = 0;
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEdit.ForeColor = System.Drawing.Color.White;
            this.buttonEdit.Location = new System.Drawing.Point(604, 501);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(149, 63);
            this.buttonEdit.TabIndex = 17;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.ButtonEdit_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(32)))), ((int)(((byte)(62)))));
            this.buttonDel.FlatAppearance.BorderSize = 0;
            this.buttonDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDel.ForeColor = System.Drawing.Color.White;
            this.buttonDel.Location = new System.Drawing.Point(780, 501);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(149, 63);
            this.buttonDel.TabIndex = 18;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.ButtonDel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pictureBox1.Image = global::AutosalonProject.Properties.Resources.wire_png_car_6;
            this.pictureBox1.Location = new System.Drawing.Point(24, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // FormAuto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AutosalonProject.Properties.Resources.pattern;
            this.ClientSize = new System.Drawing.Size(953, 593);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.comboBoxColor);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listViewCar);
            this.Controls.Add(this.textBoxYearRelease);
            this.Controls.Add(this.textBoxGosNumber);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxModel);
            this.Controls.Add(this.YearRelease);
            this.Controls.Add(this.GosNumber);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.Color);
            this.Controls.Add(this.Model);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAuto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Автомобили";
            this.Load += new System.EventHandler(this.FormAuto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Model;
        private System.Windows.Forms.Label Color;
        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.Label GosNumber;
        private System.Windows.Forms.Label YearRelease;
        private System.Windows.Forms.TextBox textBoxModel;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxGosNumber;
        private System.Windows.Forms.TextBox textBoxYearRelease;
        private System.Windows.Forms.ListView listViewCar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Model1;
        private System.Windows.Forms.ColumnHeader Color1;
        private System.Windows.Forms.ColumnHeader Price1;
        private System.Windows.Forms.ColumnHeader GosNumber1;
        private System.Windows.Forms.ColumnHeader YearRelease1;
        private System.Windows.Forms.ComboBox comboBoxColor;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDel;
    }
}