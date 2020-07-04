namespace AutosalonProject
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.buttonAuto = new System.Windows.Forms.Button();
            this.buttonBuyer = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAuto
            // 
            this.buttonAuto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(133)))), ((int)(((byte)(38)))));
            this.buttonAuto.FlatAppearance.BorderSize = 0;
            this.buttonAuto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAuto.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAuto.ForeColor = System.Drawing.Color.White;
            this.buttonAuto.Location = new System.Drawing.Point(476, 58);
            this.buttonAuto.Name = "buttonAuto";
            this.buttonAuto.Size = new System.Drawing.Size(294, 81);
            this.buttonAuto.TabIndex = 1;
            this.buttonAuto.Text = "Автомобили";
            this.buttonAuto.UseVisualStyleBackColor = false;
            this.buttonAuto.Click += new System.EventHandler(this.ButtonAuto_Click);
            // 
            // buttonBuyer
            // 
            this.buttonBuyer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(133)))), ((int)(((byte)(38)))));
            this.buttonBuyer.FlatAppearance.BorderSize = 0;
            this.buttonBuyer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuyer.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBuyer.ForeColor = System.Drawing.Color.White;
            this.buttonBuyer.Location = new System.Drawing.Point(476, 166);
            this.buttonBuyer.Name = "buttonBuyer";
            this.buttonBuyer.Size = new System.Drawing.Size(294, 81);
            this.buttonBuyer.TabIndex = 2;
            this.buttonBuyer.Text = "Покупатели";
            this.buttonBuyer.UseVisualStyleBackColor = false;
            this.buttonBuyer.Click += new System.EventHandler(this.ButtonBuyer_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pictureBox1.Image = global::AutosalonProject.Properties.Resources.wire_png_car_6;
            this.pictureBox1.Location = new System.Drawing.Point(12, -22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(417, 354);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AutosalonProject.Properties.Resources.pattern;
            this.ClientSize = new System.Drawing.Size(800, 293);
            this.Controls.Add(this.buttonBuyer);
            this.Controls.Add(this.buttonAuto);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonAuto;
        private System.Windows.Forms.Button buttonBuyer;
    }
}