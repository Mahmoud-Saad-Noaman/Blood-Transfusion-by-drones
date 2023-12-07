namespace Blood_Transformation
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_emai = new System.Windows.Forms.MaskedTextBox();
            this.txt_password = new System.Windows.Forms.MaskedTextBox();
            this.login = new System.Windows.Forms.Button();
            this.signu = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sylfaen", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(280, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "LOGIN";
            // 
            // txt_emai
            // 
            this.txt_emai.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_emai.ForeColor = System.Drawing.Color.Silver;
            this.txt_emai.Location = new System.Drawing.Point(340, 120);
            this.txt_emai.Name = "txt_emai";
            this.txt_emai.Size = new System.Drawing.Size(396, 32);
            this.txt_emai.TabIndex = 2;
            this.txt_emai.Text = "EMAIL ADDRESS";
            this.txt_emai.Enter += new System.EventHandler(this.txt_emai_Enter);
            this.txt_emai.Leave += new System.EventHandler(this.txt_emai_Leave);
            // 
            // txt_password
            // 
            this.txt_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.ForeColor = System.Drawing.Color.Silver;
            this.txt_password.Location = new System.Drawing.Point(340, 228);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(396, 32);
            this.txt_password.TabIndex = 2;
            this.txt_password.Text = "PASSWORD";
            this.txt_password.Enter += new System.EventHandler(this.txt_password_Enter);
            this.txt_password.Leave += new System.EventHandler(this.txt_password_Leave);
            // 
            // login
            // 
            this.login.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.Location = new System.Drawing.Point(340, 313);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(396, 39);
            this.login.TabIndex = 3;
            this.login.Text = "LOGIN";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.button1_Click);
            // 
            // signu
            // 
            this.signu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signu.Location = new System.Drawing.Point(340, 404);
            this.signu.Name = "signu";
            this.signu.Size = new System.Drawing.Size(396, 39);
            this.signu.TabIndex = 3;
            this.signu.Text = "SIGNUP";
            this.signu.UseVisualStyleBackColor = true;
            this.signu.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Blood_Transformation.Properties.Resources.drone_final;
            this.pictureBox1.Location = new System.Drawing.Point(31, 91);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(264, 240);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(337, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(337, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 482);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.signu);
            this.Controls.Add(this.login);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_emai);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txt_emai;
        private System.Windows.Forms.MaskedTextBox txt_password;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Button signu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

