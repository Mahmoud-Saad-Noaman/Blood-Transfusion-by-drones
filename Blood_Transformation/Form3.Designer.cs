namespace Blood_Transformation
{
    partial class Form3
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.txt_patients_fname = new System.Windows.Forms.TextBox();
            this.txt_patients_lname = new System.Windows.Forms.TextBox();
            this.cont = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Blood_Transformation.Properties.Resources.drone_final;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txt_phone
            // 
            this.txt_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_phone.ForeColor = System.Drawing.Color.Silver;
            this.txt_phone.Location = new System.Drawing.Point(173, 333);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(396, 32);
            this.txt_phone.TabIndex = 1;
            this.txt_phone.Text = "PHONE NUMBER";
            this.txt_phone.TextChanged += new System.EventHandler(this.txt_phone_TextChanged);
            this.txt_phone.Enter += new System.EventHandler(this.txt_phone_Enter);
            this.txt_phone.Leave += new System.EventHandler(this.txt_phone_Leave);
            // 
            // txt_patients_fname
            // 
            this.txt_patients_fname.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_patients_fname.ForeColor = System.Drawing.Color.Silver;
            this.txt_patients_fname.Location = new System.Drawing.Point(173, 125);
            this.txt_patients_fname.Name = "txt_patients_fname";
            this.txt_patients_fname.Size = new System.Drawing.Size(396, 32);
            this.txt_patients_fname.TabIndex = 1;
            this.txt_patients_fname.Text = "PATIENT FIRST NAME";
            this.txt_patients_fname.Enter += new System.EventHandler(this.txt_patients_fname_Enter);
            this.txt_patients_fname.Leave += new System.EventHandler(this.txt_patients_fname_Leave);
            // 
            // txt_patients_lname
            // 
            this.txt_patients_lname.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_patients_lname.ForeColor = System.Drawing.Color.Silver;
            this.txt_patients_lname.Location = new System.Drawing.Point(173, 228);
            this.txt_patients_lname.Name = "txt_patients_lname";
            this.txt_patients_lname.Size = new System.Drawing.Size(396, 32);
            this.txt_patients_lname.TabIndex = 1;
            this.txt_patients_lname.Text = "PATIENT LAST NAME";
            this.txt_patients_lname.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.txt_patients_lname.Enter += new System.EventHandler(this.txt_patients_lname_Enter);
            this.txt_patients_lname.Leave += new System.EventHandler(this.txt_patients_lname_Leave);
            // 
            // cont
            // 
            this.cont.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cont.Location = new System.Drawing.Point(173, 411);
            this.cont.Name = "cont";
            this.cont.Size = new System.Drawing.Size(171, 37);
            this.cont.TabIndex = 2;
            this.cont.Text = "CONTINUE";
            this.cont.UseVisualStyleBackColor = true;
            this.cont.Click += new System.EventHandler(this.cont_Click);
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Location = new System.Drawing.Point(401, 411);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(168, 37);
            this.back.TabIndex = 2;
            this.back.Text = "BACK";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(167, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Patient First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(167, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Patient Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(168, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "Phone Number";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 518);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.back);
            this.Controls.Add(this.cont);
            this.Controls.Add(this.txt_patients_fname);
            this.Controls.Add(this.txt_patients_lname);
            this.Controls.Add(this.txt_phone);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.TextBox txt_patients_fname;
        private System.Windows.Forms.TextBox txt_patients_lname;
        private System.Windows.Forms.Button cont;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}