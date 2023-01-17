
namespace SampleCallerIDNew
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
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxCustomer = new System.Windows.Forms.TextBox();
            this.txtBoxNumber = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.btnDeleteCustomer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 36);
            this.label2.TabIndex = 13;
            this.label2.Text = "شماره تماس:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 19);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 36);
            this.label3.TabIndex = 12;
            this.label3.Text = "نام مشتری:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtBoxCustomer
            // 
            this.txtBoxCustomer.BackColor = System.Drawing.Color.LightCyan;
            this.txtBoxCustomer.Font = new System.Drawing.Font("B Titr", 15F);
            this.txtBoxCustomer.Location = new System.Drawing.Point(118, 16);
            this.txtBoxCustomer.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtBoxCustomer.Name = "txtBoxCustomer";
            this.txtBoxCustomer.Size = new System.Drawing.Size(258, 43);
            this.txtBoxCustomer.TabIndex = 11;
            this.txtBoxCustomer.Text = "جناب آقای مهندس میلاد آبائی راد ";
            this.txtBoxCustomer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxCustomer.TextChanged += new System.EventHandler(this.txtBoxCustomer_TextChanged);
            // 
            // txtBoxNumber
            // 
            this.txtBoxNumber.BackColor = System.Drawing.Color.LightCyan;
            this.txtBoxNumber.Font = new System.Drawing.Font("B Titr", 15F);
            this.txtBoxNumber.Location = new System.Drawing.Point(118, 70);
            this.txtBoxNumber.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtBoxNumber.Name = "txtBoxNumber";
            this.txtBoxNumber.Size = new System.Drawing.Size(258, 43);
            this.txtBoxNumber.TabIndex = 10;
            this.txtBoxNumber.Text = "09125433186";
            this.txtBoxNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxNumber.TextChanged += new System.EventHandler(this.txtBoxNumber_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 60000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.BackColor = System.Drawing.Color.Lime;
            this.btnAddCustomer.Font = new System.Drawing.Font("B Titr", 15F);
            this.btnAddCustomer.Location = new System.Drawing.Point(118, 123);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(258, 41);
            this.btnAddCustomer.TabIndex = 14;
            this.btnAddCustomer.Text = "افزودن مشتری جدید";
            this.btnAddCustomer.UseVisualStyleBackColor = false;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.BackColor = System.Drawing.Color.Lime;
            this.btnDeleteCustomer.Font = new System.Drawing.Font("B Titr", 15F);
            this.btnDeleteCustomer.Location = new System.Drawing.Point(118, 170);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(258, 41);
            this.btnDeleteCustomer.TabIndex = 15;
            this.btnDeleteCustomer.Text = "حذف مشتری";
            this.btnDeleteCustomer.UseVisualStyleBackColor = false;
            this.btnDeleteCustomer.Click += new System.EventHandler(this.btnDeleteCustomer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Cyan;
            this.label1.Location = new System.Drawing.Point(3, 125);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 36);
            this.label1.TabIndex = 16;
            this.label1.Text = "شناسه";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(3, 161);
            this.lblID.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(65, 36);
            this.lblID.TabIndex = 17;
            this.lblID.Text = "99999";
            this.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(383, 217);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDeleteCustomer);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBoxCustomer);
            this.Controls.Add(this.txtBoxNumber);
            this.Font = new System.Drawing.Font("B Titr", 15F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form3";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxCustomer;
        private System.Windows.Forms.TextBox txtBoxNumber;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Button btnDeleteCustomer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblID;
    }
}