namespace Blood_Transformation
{
    partial class Form5
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
            this.txt_blood_type = new System.Windows.Forms.ComboBox();
            this.txt_liters_blood = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            // txt_blood_type
            // 
            this.txt_blood_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_blood_type.ForeColor = System.Drawing.Color.Silver;
            this.txt_blood_type.FormattingEnabled = true;
            this.txt_blood_type.Location = new System.Drawing.Point(182, 125);
            this.txt_blood_type.Name = "txt_blood_type";
            this.txt_blood_type.Size = new System.Drawing.Size(329, 34);
            this.txt_blood_type.TabIndex = 1;
            this.txt_blood_type.Text = "BLOOD TYPE";
            this.txt_blood_type.SelectedIndexChanged += new System.EventHandler(this.txt_blood_type_SelectedIndexChanged);
            this.txt_blood_type.Enter += new System.EventHandler(this.txt_blood_type_Enter);
            this.txt_blood_type.Leave += new System.EventHandler(this.txt_blood_type_Leave);
            // 
            // txt_liters_blood
            // 
            this.txt_liters_blood.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_liters_blood.ForeColor = System.Drawing.Color.Silver;
            this.txt_liters_blood.Location = new System.Drawing.Point(182, 230);
            this.txt_liters_blood.Name = "txt_liters_blood";
            this.txt_liters_blood.Size = new System.Drawing.Size(329, 32);
            this.txt_liters_blood.TabIndex = 2;
            this.txt_liters_blood.Text = "LITERS OF BLOOD NEEDED";
            this.txt_liters_blood.Enter += new System.EventHandler(this.txt_liters_blood_Enter);
            this.txt_liters_blood.Leave += new System.EventHandler(this.txt_liters_blood_Leave);
            // 
            // submit
            // 
            this.submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit.Location = new System.Drawing.Point(182, 311);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(152, 45);
            this.submit.TabIndex = 3;
            this.submit.Text = "SUBMIT";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Location = new System.Drawing.Point(359, 311);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(152, 45);
            this.back.TabIndex = 4;
            this.back.Text = "BACK";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(177, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "Blood Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(177, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "Liters Of Blood Needed";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 422);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.back);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.txt_liters_blood);
            this.Controls.Add(this.txt_blood_type);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox txt_blood_type;
        private System.Windows.Forms.TextBox txt_liters_blood;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}