namespace Blood_Transformation
{
    partial class Form4
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txt_city = new System.Windows.Forms.ComboBox();
            this.txt_street = new System.Windows.Forms.TextBox();
            this.street = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.contt = new System.Windows.Forms.Button();
            this.search_for_long_and_lat = new System.Windows.Forms.Button();
            this.txt_latitude = new System.Windows.Forms.TextBox();
            this.txt_hospital_address = new System.Windows.Forms.TextBox();
            this.txt_longitude = new System.Windows.Forms.TextBox();
            this.txt_hospital_name = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.txt_city);
            this.splitContainer1.Panel1.Controls.Add(this.txt_street);
            this.splitContainer1.Panel1.Controls.Add(this.street);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.back);
            this.splitContainer1.Panel1.Controls.Add(this.contt);
            this.splitContainer1.Panel1.Controls.Add(this.search_for_long_and_lat);
            this.splitContainer1.Panel1.Controls.Add(this.txt_latitude);
            this.splitContainer1.Panel1.Controls.Add(this.txt_hospital_address);
            this.splitContainer1.Panel1.Controls.Add(this.txt_longitude);
            this.splitContainer1.Panel1.Controls.Add(this.txt_hospital_name);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.webBrowser1);
            this.splitContainer1.Size = new System.Drawing.Size(1114, 868);
            this.splitContainer1.SplitterDistance = 558;
            this.splitContainer1.TabIndex = 0;
            // 
            // txt_city
            // 
            this.txt_city.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_city.FormattingEnabled = true;
            this.txt_city.Location = new System.Drawing.Point(177, 323);
            this.txt_city.Name = "txt_city";
            this.txt_city.Size = new System.Drawing.Size(338, 34);
            this.txt_city.TabIndex = 16;
            this.txt_city.Text = "CITY";
            this.txt_city.Enter += new System.EventHandler(this.txt_city_Enter);
            this.txt_city.Leave += new System.EventHandler(this.txt_city_Leave);
            // 
            // txt_street
            // 
            this.txt_street.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_street.ForeColor = System.Drawing.Color.Silver;
            this.txt_street.Location = new System.Drawing.Point(177, 420);
            this.txt_street.Name = "txt_street";
            this.txt_street.Size = new System.Drawing.Size(338, 32);
            this.txt_street.TabIndex = 15;
            this.txt_street.Text = "STREET";
            this.txt_street.Enter += new System.EventHandler(this.txt_street_Enter);
            this.txt_street.Leave += new System.EventHandler(this.txt_street_Leave);
            // 
            // street
            // 
            this.street.AutoSize = true;
            this.street.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.street.Location = new System.Drawing.Point(172, 391);
            this.street.Name = "street";
            this.street.Size = new System.Drawing.Size(70, 26);
            this.street.TabIndex = 14;
            this.street.Text = "Street";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(172, 581);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 26);
            this.label5.TabIndex = 13;
            this.label5.Text = "Latitude";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(172, 482);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 26);
            this.label4.TabIndex = 12;
            this.label4.Text = "Longitude";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(172, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 26);
            this.label3.TabIndex = 11;
            this.label3.Text = "City";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(172, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 26);
            this.label2.TabIndex = 10;
            this.label2.Text = "Hospital Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(172, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 26);
            this.label1.TabIndex = 9;
            this.label1.Text = "Hospital Name";
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Location = new System.Drawing.Point(370, 779);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(145, 42);
            this.back.TabIndex = 8;
            this.back.Text = "BACK";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.button3_Click);
            // 
            // contt
            // 
            this.contt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contt.Location = new System.Drawing.Point(177, 779);
            this.contt.Name = "contt";
            this.contt.Size = new System.Drawing.Size(136, 42);
            this.contt.TabIndex = 7;
            this.contt.Text = "CONTINUE";
            this.contt.UseVisualStyleBackColor = true;
            this.contt.Click += new System.EventHandler(this.button2_Click);
            // 
            // search_for_long_and_lat
            // 
            this.search_for_long_and_lat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_for_long_and_lat.Location = new System.Drawing.Point(177, 692);
            this.search_for_long_and_lat.Name = "search_for_long_and_lat";
            this.search_for_long_and_lat.Size = new System.Drawing.Size(338, 44);
            this.search_for_long_and_lat.TabIndex = 6;
            this.search_for_long_and_lat.Text = "search for long. and lat.";
            this.search_for_long_and_lat.UseVisualStyleBackColor = true;
            this.search_for_long_and_lat.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_latitude
            // 
            this.txt_latitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_latitude.ForeColor = System.Drawing.Color.Silver;
            this.txt_latitude.Location = new System.Drawing.Point(177, 610);
            this.txt_latitude.Name = "txt_latitude";
            this.txt_latitude.Size = new System.Drawing.Size(338, 32);
            this.txt_latitude.TabIndex = 5;
            this.txt_latitude.Text = "LATITUDE";
            this.txt_latitude.Enter += new System.EventHandler(this.txt_latitude_Enter);
            this.txt_latitude.Leave += new System.EventHandler(this.txt_latitude_Leave);
            // 
            // txt_hospital_address
            // 
            this.txt_hospital_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_hospital_address.ForeColor = System.Drawing.Color.Silver;
            this.txt_hospital_address.Location = new System.Drawing.Point(177, 222);
            this.txt_hospital_address.Name = "txt_hospital_address";
            this.txt_hospital_address.Size = new System.Drawing.Size(338, 32);
            this.txt_hospital_address.TabIndex = 4;
            this.txt_hospital_address.Text = "HOSPITAL ADDRESS";
            this.txt_hospital_address.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            this.txt_hospital_address.Enter += new System.EventHandler(this.txt_hospital_address_Enter);
            this.txt_hospital_address.Leave += new System.EventHandler(this.txt_hospital_address_Leave);
            // 
            // txt_longitude
            // 
            this.txt_longitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_longitude.ForeColor = System.Drawing.Color.Silver;
            this.txt_longitude.Location = new System.Drawing.Point(177, 511);
            this.txt_longitude.Name = "txt_longitude";
            this.txt_longitude.Size = new System.Drawing.Size(338, 32);
            this.txt_longitude.TabIndex = 3;
            this.txt_longitude.Text = "LONGITUDE";
            this.txt_longitude.Enter += new System.EventHandler(this.txt_longitude_Enter);
            this.txt_longitude.Leave += new System.EventHandler(this.txt_longitude_Leave);
            // 
            // txt_hospital_name
            // 
            this.txt_hospital_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_hospital_name.ForeColor = System.Drawing.Color.Silver;
            this.txt_hospital_name.Location = new System.Drawing.Point(177, 123);
            this.txt_hospital_name.Name = "txt_hospital_name";
            this.txt_hospital_name.Size = new System.Drawing.Size(338, 32);
            this.txt_hospital_name.TabIndex = 1;
            this.txt_hospital_name.Text = "HOSPITAL NAME";
            this.txt_hospital_name.Enter += new System.EventHandler(this.txt_hospital_name_Enter);
            this.txt_hospital_name.Leave += new System.EventHandler(this.txt_hospital_name_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Blood_Transformation.Properties.Resources.drone_final;
            this.pictureBox1.Location = new System.Drawing.Point(12, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(552, 868);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 868);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TextBox txt_latitude;
        private System.Windows.Forms.TextBox txt_hospital_address;
        private System.Windows.Forms.TextBox txt_longitude;
        private System.Windows.Forms.TextBox txt_hospital_name;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button contt;
        private System.Windows.Forms.Button search_for_long_and_lat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label street;
        private System.Windows.Forms.TextBox txt_street;
        private System.Windows.Forms.ComboBox txt_city;
    }
}