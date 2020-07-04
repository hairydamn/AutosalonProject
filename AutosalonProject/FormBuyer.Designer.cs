namespace AutosalonProject
{
    partial class FormBuyer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBuyer));
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.labelLastName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxMiddleName = new System.Windows.Forms.TextBox();
            this.labelMiddleName = new System.Windows.Forms.Label();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.textBoxMail = new System.Windows.Forms.TextBox();
            this.labelMail = new System.Windows.Forms.Label();
            this.listViewBuyer = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Name1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LastName1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MiddleName1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Phone1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Email1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLastName.Location = new System.Drawing.Point(12, 236);
            this.textBoxLastName.Multiline = true;
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(183, 34);
            this.textBoxLastName.TabIndex = 7;
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelLastName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLastName.Location = new System.Drawing.Point(10, 212);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(73, 19);
            this.labelLastName.TabIndex = 6;
            this.labelLastName.Text = "Фамилия";
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxName.Location = new System.Drawing.Point(12, 162);
            this.textBoxName.Multiline = true;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(183, 34);
            this.textBoxName.TabIndex = 5;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(9, 138);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(38, 19);
            this.labelName.TabIndex = 4;
            this.labelName.Text = "Имя";
            // 
            // textBoxMiddleName
            // 
            this.textBoxMiddleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxMiddleName.Location = new System.Drawing.Point(12, 306);
            this.textBoxMiddleName.Multiline = true;
            this.textBoxMiddleName.Name = "textBoxMiddleName";
            this.textBoxMiddleName.Size = new System.Drawing.Size(183, 34);
            this.textBoxMiddleName.TabIndex = 11;
            // 
            // labelMiddleName
            // 
            this.labelMiddleName.AutoSize = true;
            this.labelMiddleName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelMiddleName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMiddleName.Location = new System.Drawing.Point(9, 283);
            this.labelMiddleName.Name = "labelMiddleName";
            this.labelMiddleName.Size = new System.Drawing.Size(71, 19);
            this.labelMiddleName.TabIndex = 10;
            this.labelMiddleName.Text = "Отчество";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPhone.Location = new System.Drawing.Point(12, 379);
            this.textBoxPhone.Multiline = true;
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(183, 34);
            this.textBoxPhone.TabIndex = 9;
            this.textBoxPhone.TextChanged += new System.EventHandler(this.TextBoxPhone_TextChanged);
            this.textBoxPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxPhone_KeyPress);
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelPhone.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPhone.Location = new System.Drawing.Point(10, 356);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(67, 19);
            this.labelPhone.TabIndex = 8;
            this.labelPhone.Text = "Телефон";
            // 
            // textBoxMail
            // 
            this.textBoxMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxMail.Location = new System.Drawing.Point(12, 447);
            this.textBoxMail.Multiline = true;
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.Size = new System.Drawing.Size(183, 34);
            this.textBoxMail.TabIndex = 13;
            // 
            // labelMail
            // 
            this.labelMail.AutoSize = true;
            this.labelMail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelMail.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMail.Location = new System.Drawing.Point(9, 424);
            this.labelMail.Name = "labelMail";
            this.labelMail.Size = new System.Drawing.Size(72, 19);
            this.labelMail.TabIndex = 12;
            this.labelMail.Text = "Эл. почта";
            // 
            // listViewBuyer
            // 
            this.listViewBuyer.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Name1,
            this.LastName1,
            this.MiddleName1,
            this.Phone1,
            this.Email1});
            this.listViewBuyer.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listViewBuyer.FullRowSelect = true;
            this.listViewBuyer.GridLines = true;
            this.listViewBuyer.HideSelection = false;
            this.listViewBuyer.Location = new System.Drawing.Point(233, 162);
            this.listViewBuyer.MultiSelect = false;
            this.listViewBuyer.Name = "listViewBuyer";
            this.listViewBuyer.Size = new System.Drawing.Size(585, 319);
            this.listViewBuyer.TabIndex = 14;
            this.listViewBuyer.UseCompatibleStateImageBehavior = false;
            this.listViewBuyer.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 33;
            // 
            // Name1
            // 
            this.Name1.Text = "Имя";
            this.Name1.Width = 78;
            // 
            // LastName1
            // 
            this.LastName1.Text = "Фамилия";
            this.LastName1.Width = 93;
            // 
            // MiddleName1
            // 
            this.MiddleName1.Text = "Отчество";
            this.MiddleName1.Width = 96;
            // 
            // Phone1
            // 
            this.Phone1.Text = "Телефон";
            this.Phone1.Width = 101;
            // 
            // Email1
            // 
            this.Email1.Text = "Эл. почта";
            this.Email1.Width = 185;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(133)))), ((int)(((byte)(38)))));
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.Location = new System.Drawing.Point(294, 500);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(157, 56);
            this.buttonAdd.TabIndex = 15;
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
            this.buttonEdit.Location = new System.Drawing.Point(478, 500);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(157, 56);
            this.buttonEdit.TabIndex = 16;
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
            this.buttonDel.Location = new System.Drawing.Point(661, 500);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(157, 56);
            this.buttonDel.TabIndex = 17;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.ButtonDel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pictureBox1.Image = global::AutosalonProject.Properties.Resources.wire_png_car_6;
            this.pictureBox1.Location = new System.Drawing.Point(12, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // FormBuyer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AutosalonProject.Properties.Resources.pattern;
            this.ClientSize = new System.Drawing.Size(835, 578);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listViewBuyer);
            this.Controls.Add(this.textBoxMail);
            this.Controls.Add(this.labelMail);
            this.Controls.Add(this.textBoxMiddleName);
            this.Controls.Add(this.labelMiddleName);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormBuyer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Покупатели";
            this.Load += new System.EventHandler(this.FormBuyer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxMiddleName;
        private System.Windows.Forms.Label labelMiddleName;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.TextBox textBoxMail;
        private System.Windows.Forms.Label labelMail;
        private System.Windows.Forms.ListView listViewBuyer;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Name1;
        private System.Windows.Forms.ColumnHeader LastName1;
        private System.Windows.Forms.ColumnHeader MiddleName1;
        private System.Windows.Forms.ColumnHeader Phone1;
        private System.Windows.Forms.ColumnHeader Email1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}