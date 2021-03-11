namespace Modern_UI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.txtuserid = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pctrclose = new System.Windows.Forms.PictureBox();
            this.pctrminimize = new System.Windows.Forms.PictureBox();
            this.btnlogin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctrclose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrminimize)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Copperplate Gothic Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(50, 185);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "User ID";
            // 
            // txtuserid
            // 
            this.txtuserid.BackColor = System.Drawing.Color.Black;
            this.txtuserid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtuserid.ForeColor = System.Drawing.Color.White;
            this.txtuserid.Location = new System.Drawing.Point(125, 180);
            this.txtuserid.Name = "txtuserid";
            this.txtuserid.Size = new System.Drawing.Size(173, 26);
            this.txtuserid.TabIndex = 1;
            // 
            // txtpassword
            // 
            this.txtpassword.BackColor = System.Drawing.Color.Black;
            this.txtpassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtpassword.ForeColor = System.Drawing.Color.White;
            this.txtpassword.Location = new System.Drawing.Point(125, 216);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(173, 26);
            this.txtpassword.TabIndex = 2;
            this.txtpassword.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Copperplate Gothic Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(28, 221);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // pctrclose
            // 
            this.pctrclose.BackColor = System.Drawing.Color.Transparent;
            this.pctrclose.Image = global::Modern_UI.Properties.Resources.closeicon;
            this.pctrclose.Location = new System.Drawing.Point(291, 12);
            this.pctrclose.Name = "pctrclose";
            this.pctrclose.Size = new System.Drawing.Size(25, 25);
            this.pctrclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctrclose.TabIndex = 4;
            this.pctrclose.TabStop = false;
            this.pctrclose.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pctrclose.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pctrclose.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // pctrminimize
            // 
            this.pctrminimize.BackColor = System.Drawing.Color.Transparent;
            this.pctrminimize.Image = ((System.Drawing.Image)(resources.GetObject("pctrminimize.Image")));
            this.pctrminimize.Location = new System.Drawing.Point(260, 12);
            this.pctrminimize.Name = "pctrminimize";
            this.pctrminimize.Size = new System.Drawing.Size(25, 25);
            this.pctrminimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctrminimize.TabIndex = 5;
            this.pctrminimize.TabStop = false;
            this.pctrminimize.Click += new System.EventHandler(this.pictureBox2_Click);
            this.pctrminimize.MouseLeave += new System.EventHandler(this.pictureBox2_MouseLeave);
            this.pctrminimize.MouseHover += new System.EventHandler(this.pictureBox2_MouseHover);
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.Transparent;
            this.btnlogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnlogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogin.ForeColor = System.Drawing.Color.White;
            this.btnlogin.Location = new System.Drawing.Point(227, 255);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(71, 29);
            this.btnlogin.TabIndex = 3;
            this.btnlogin.Text = "LOGIN";
            this.btnlogin.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Modern_UI.Properties.Resources.loginscreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(327, 467);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.pctrminimize);
            this.Controls.Add(this.pctrclose);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtuserid);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pctrclose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrminimize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtuserid;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pctrclose;
        private System.Windows.Forms.PictureBox pctrminimize;
        private System.Windows.Forms.Button btnlogin;
    }
}

