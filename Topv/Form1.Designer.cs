namespace Topv
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Clear = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Result = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TabdilMohasebatRiazy = new System.Windows.Forms.Button();
            this.CB = new System.Windows.Forms.ComboBox();
            this.Price = new System.Windows.Forms.TextBox();
            this.Month = new System.Windows.Forms.TextBox();
            this.Percent = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.panel1.Controls.Add(this.Percent);
            this.panel1.Controls.Add(this.Month);
            this.panel1.Controls.Add(this.Price);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Clear);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.Result);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.TabdilMohasebatRiazy);
            this.panel1.Controls.Add(this.CB);
            this.panel1.Font = new System.Drawing.Font("Vazir", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1145, 531);
            this.panel1.TabIndex = 14;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Vazir", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(669, 126);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(223, 42);
            this.label5.TabIndex = 27;
            this.label5.Text = "قیمت را وارد کنید : ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Vazir", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(669, 188);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(195, 42);
            this.label2.TabIndex = 26;
            this.label2.Text = "ماه را وارد کنید : ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Clear
            // 
            this.Clear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(11)))), ((int)(((byte)(245)))));
            this.Clear.Font = new System.Drawing.Font("Vazir", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Clear.ForeColor = System.Drawing.Color.White;
            this.Clear.Location = new System.Drawing.Point(333, 415);
            this.Clear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(167, 68);
            this.Clear.TabIndex = 25;
            this.Clear.Text = "پاک کن";
            this.Clear.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Vazir", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(872, 337);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(92, 42);
            this.label6.TabIndex = 24;
            this.label6.Text = "نتیجه :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Result
            // 
            this.Result.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Result.AutoEllipsis = true;
            this.Result.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(30)))));
            this.Result.Font = new System.Drawing.Font("Vazir", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Result.ForeColor = System.Drawing.Color.White;
            this.Result.Location = new System.Drawing.Point(161, 327);
            this.Result.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Result.Name = "Result";
            this.Result.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Result.Size = new System.Drawing.Size(703, 63);
            this.Result.TabIndex = 23;
            this.Result.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Vazir", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(669, 55);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(317, 42);
            this.label3.TabIndex = 22;
            this.label3.Text = "نوع محاسبه را انتخاب کنید :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Vazir", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(669, 257);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(201, 42);
            this.label1.TabIndex = 20;
            this.label1.Text = "نرخ را وارد کنید : ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TabdilMohasebatRiazy
            // 
            this.TabdilMohasebatRiazy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TabdilMohasebatRiazy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(11)))), ((int)(((byte)(245)))));
            this.TabdilMohasebatRiazy.Font = new System.Drawing.Font("Vazir", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TabdilMohasebatRiazy.ForeColor = System.Drawing.Color.White;
            this.TabdilMohasebatRiazy.Location = new System.Drawing.Point(158, 415);
            this.TabdilMohasebatRiazy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TabdilMohasebatRiazy.Name = "TabdilMohasebatRiazy";
            this.TabdilMohasebatRiazy.Size = new System.Drawing.Size(167, 68);
            this.TabdilMohasebatRiazy.TabIndex = 21;
            this.TabdilMohasebatRiazy.Text = "محاسبه";
            this.TabdilMohasebatRiazy.UseVisualStyleBackColor = false;
            // 
            // CB
            // 
            this.CB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CB.Font = new System.Drawing.Font("Vazir", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.CB.FormattingEnabled = true;
            this.CB.Items.AddRange(new object[] {
            "روش قدیم",
            "روش جدید"});
            this.CB.Location = new System.Drawing.Point(162, 47);
            this.CB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CB.Name = "CB";
            this.CB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CB.Size = new System.Drawing.Size(499, 48);
            this.CB.TabIndex = 19;
            // 
            // Price
            // 
            this.Price.Location = new System.Drawing.Point(162, 126);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(500, 39);
            this.Price.TabIndex = 28;
            this.Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Month
            // 
            this.Month.Location = new System.Drawing.Point(162, 191);
            this.Month.Name = "Month";
            this.Month.Size = new System.Drawing.Size(500, 39);
            this.Month.TabIndex = 29;
            this.Month.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Percent
            // 
            this.Percent.Location = new System.Drawing.Point(162, 257);
            this.Percent.Name = "Percent";
            this.Percent.Size = new System.Drawing.Size(500, 39);
            this.Percent.TabIndex = 30;
            this.Percent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 541);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Vazir", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "محاسبه سود قسط";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button TabdilMohasebatRiazy;
        private System.Windows.Forms.ComboBox CB;
        private System.Windows.Forms.TextBox Percent;
        private System.Windows.Forms.TextBox Month;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

