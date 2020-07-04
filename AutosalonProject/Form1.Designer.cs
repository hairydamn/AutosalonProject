namespace AutosalonProject
{
    partial class FormRegistration
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegistration));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonReg = new System.Windows.Forms.Button();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(133)))), ((int)(((byte)(38)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-5, -9);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(417, 78);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(118, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Регистрация";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelName.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(25, 177);
            this.labelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(44, 23);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Имя";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(30, 204);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxName.Multiline = true;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(331, 49);
            this.textBoxName.TabIndex = 5;
            // 
            // buttonReg
            // 
            this.buttonReg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(47)))), ((int)(((byte)(57)))));
            this.buttonReg.FlatAppearance.BorderSize = 0;
            this.buttonReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReg.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonReg.ForeColor = System.Drawing.Color.White;
            this.buttonReg.Location = new System.Drawing.Point(29, 467);
            this.buttonReg.Margin = new System.Windows.Forms.Padding(4);
            this.buttonReg.Name = "buttonReg";
            this.buttonReg.Size = new System.Drawing.Size(332, 82);
            this.buttonReg.TabIndex = 8;
            this.buttonReg.Text = "Зарегистрироваться";
            this.buttonReg.UseVisualStyleBackColor = false;
            this.buttonReg.Click += new System.EventHandler(this.ButtonReg_Click);
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(30, 296);
            this.textBoxLogin.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxLogin.Multiline = true;
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(331, 49);
            this.textBoxLogin.TabIndex = 10;
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelLogin.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLogin.Location = new System.Drawing.Point(26, 269);
            this.labelLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(59, 23);
            this.labelLogin.TabIndex = 9;
            this.labelLogin.Text = "Логин";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(30, 390);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPassword.Multiline = true;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(331, 49);
            this.textBoxPassword.TabIndex = 12;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelPassword.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPassword.Location = new System.Drawing.Point(26, 364);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(70, 23);
            this.labelPassword.TabIndex = 11;
            this.labelPassword.Text = "Пароль";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(27, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 23);
            this.label3.TabIndex = 24;
            this.label3.Text = "Зарегистрироваться как:";
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Покупатель",
            "Менеджер"});
            this.comboBoxType.Location = new System.Drawing.Point(30, 109);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(329, 27);
            this.comboBoxType.TabIndex = 23;
            // 
            // FormRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AutosalonProject.Properties.Resources.pattern;
            this.ClientSize = new System.Drawing.Size(397, 581);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.buttonReg);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация";
            this.Load += new System.EventHandler(this.FormRegistration_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonReg;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxType;
    }
}

