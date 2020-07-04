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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Model1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Color1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GosNumber1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.YearRelease1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Model
            // 
            this.Model.AutoSize = true;
            this.Model.Location = new System.Drawing.Point(21, 89);
            this.Model.Name = "Model";
            this.Model.Size = new System.Drawing.Size(72, 13);
            this.Model.TabIndex = 0;
            this.Model.Text = "Модель авто";
            // 
            // Color
            // 
            this.Color.AutoSize = true;
            this.Color.Location = new System.Drawing.Point(21, 168);
            this.Color.Name = "Color";
            this.Color.Size = new System.Drawing.Size(58, 13);
            this.Color.TabIndex = 1;
            this.Color.Text = "Цвет авто";
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Location = new System.Drawing.Point(21, 244);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(33, 13);
            this.Price.TabIndex = 2;
            this.Price.Text = "Цена";
            // 
            // GosNumber
            // 
            this.GosNumber.AutoSize = true;
            this.GosNumber.Location = new System.Drawing.Point(21, 323);
            this.GosNumber.Name = "GosNumber";
            this.GosNumber.Size = new System.Drawing.Size(65, 13);
            this.GosNumber.TabIndex = 3;
            this.GosNumber.Text = "Гос. Номер";
            // 
            // YearRelease
            // 
            this.YearRelease.AutoSize = true;
            this.YearRelease.Location = new System.Drawing.Point(21, 400);
            this.YearRelease.Name = "YearRelease";
            this.YearRelease.Size = new System.Drawing.Size(71, 13);
            this.YearRelease.TabIndex = 4;
            this.YearRelease.Text = "Год выпуска";
            // 
            // textBoxModel
            // 
            this.textBoxModel.Location = new System.Drawing.Point(24, 110);
            this.textBoxModel.Multiline = true;
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.Size = new System.Drawing.Size(200, 36);
            this.textBoxModel.TabIndex = 5;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(24, 260);
            this.textBoxPrice.Multiline = true;
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(200, 36);
            this.textBoxPrice.TabIndex = 7;
            // 
            // textBoxGosNumber
            // 
            this.textBoxGosNumber.Location = new System.Drawing.Point(24, 339);
            this.textBoxGosNumber.Multiline = true;
            this.textBoxGosNumber.Name = "textBoxGosNumber";
            this.textBoxGosNumber.Size = new System.Drawing.Size(200, 36);
            this.textBoxGosNumber.TabIndex = 8;
            // 
            // textBoxYearRelease
            // 
            this.textBoxYearRelease.Location = new System.Drawing.Point(24, 418);
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
            this.listViewCar.FullRowSelect = true;
            this.listViewCar.GridLines = true;
            this.listViewCar.HideSelection = false;
            this.listViewCar.Location = new System.Drawing.Point(255, 110);
            this.listViewCar.MultiSelect = false;
            this.listViewCar.Name = "listViewCar";
            this.listViewCar.Size = new System.Drawing.Size(599, 344);
            this.listViewCar.TabIndex = 10;
            this.listViewCar.UseCompatibleStateImageBehavior = false;
            this.listViewCar.View = System.Windows.Forms.View.Details;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AutosalonProject.Properties.Resources.wire_png_car_6;
            this.pictureBox1.Location = new System.Drawing.Point(24, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 40;
            // 
            // Model1
            // 
            this.Model1.Text = "Модель авто";
            this.Model1.Width = 91;
            // 
            // Color1
            // 
            this.Color1.Text = "Цвет авто";
            this.Color1.Width = 92;
            // 
            // Price1
            // 
            this.Price1.Text = "Цена";
            this.Price1.Width = 88;
            // 
            // GosNumber1
            // 
            this.GosNumber1.Text = "Гос. Номер";
            this.GosNumber1.Width = 115;
            // 
            // YearRelease1
            // 
            this.YearRelease1.Text = "Год выпуска";
            this.YearRelease1.Width = 183;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(360, 478);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 58);
            this.button1.TabIndex = 12;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(534, 478);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 58);
            this.button2.TabIndex = 13;
            this.button2.Text = "Изменить";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(708, 478);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(146, 58);
            this.button3.TabIndex = 14;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Красный",
            "Фиолетовый",
            "Зелёный",
            "Чёрный",
            "Белый",
            "Синий"});
            this.comboBox1.Location = new System.Drawing.Point(24, 191);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 21);
            this.comboBox1.TabIndex = 15;
            // 
            // FormAuto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 615);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
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
            this.Name = "FormAuto";
            this.Text = "FormAuto";
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}