
namespace SampleCallerIDNew
{
    partial class Form2
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxCustomer = new System.Windows.Forms.TextBox();
            this.txtBoxNumber = new System.Windows.Forms.TextBox();
            this.btnَAddCostumer = new System.Windows.Forms.Button();
            this.txtSearchByName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSearchByName = new System.Windows.Forms.Button();
            this.txtSearchByNumber = new System.Windows.Forms.TextBox();
            this.btnSearchByNumber = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnStartIDCaller = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "شماره تماس:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "نام مشتری:";
            // 
            // txtBoxCustomer
            // 
            this.txtBoxCustomer.Location = new System.Drawing.Point(79, 6);
            this.txtBoxCustomer.Name = "txtBoxCustomer";
            this.txtBoxCustomer.Size = new System.Drawing.Size(109, 20);
            this.txtBoxCustomer.TabIndex = 7;
            // 
            // txtBoxNumber
            // 
            this.txtBoxNumber.Location = new System.Drawing.Point(79, 32);
            this.txtBoxNumber.Name = "txtBoxNumber";
            this.txtBoxNumber.Size = new System.Drawing.Size(109, 20);
            this.txtBoxNumber.TabIndex = 6;
            // 
            // btnَAddCostumer
            // 
            this.btnَAddCostumer.Location = new System.Drawing.Point(79, 61);
            this.btnَAddCostumer.Name = "btnَAddCostumer";
            this.btnَAddCostumer.Size = new System.Drawing.Size(109, 23);
            this.btnَAddCostumer.TabIndex = 5;
            this.btnَAddCostumer.Text = "ایجاد مشتری جدید";
            this.btnَAddCostumer.UseVisualStyleBackColor = true;
            this.btnَAddCostumer.Click += new System.EventHandler(this.btnAddCostumer_Click);
            // 
            // txtSearchByName
            // 
            this.txtSearchByName.Location = new System.Drawing.Point(79, 114);
            this.txtSearchByName.Name = "txtSearchByName";
            this.txtSearchByName.Size = new System.Drawing.Size(109, 20);
            this.txtSearchByName.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "نام مشتری:";
            // 
            // btnSearchByName
            // 
            this.btnSearchByName.Location = new System.Drawing.Point(79, 143);
            this.btnSearchByName.Name = "btnSearchByName";
            this.btnSearchByName.Size = new System.Drawing.Size(109, 23);
            this.btnSearchByName.TabIndex = 12;
            this.btnSearchByName.Text = "جستجوی شماره";
            this.btnSearchByName.UseVisualStyleBackColor = true;
            this.btnSearchByName.Click += new System.EventHandler(this.btnSearchByName_Click);
            // 
            // txtSearchByNumber
            // 
            this.txtSearchByNumber.Location = new System.Drawing.Point(79, 195);
            this.txtSearchByNumber.Name = "txtSearchByNumber";
            this.txtSearchByNumber.Size = new System.Drawing.Size(109, 20);
            this.txtSearchByNumber.TabIndex = 13;
            // 
            // btnSearchByNumber
            // 
            this.btnSearchByNumber.Location = new System.Drawing.Point(79, 224);
            this.btnSearchByNumber.Name = "btnSearchByNumber";
            this.btnSearchByNumber.Size = new System.Drawing.Size(109, 23);
            this.btnSearchByNumber.TabIndex = 14;
            this.btnSearchByNumber.Text = "جستجوی مشتری";
            this.btnSearchByNumber.UseVisualStyleBackColor = true;
            this.btnSearchByNumber.Click += new System.EventHandler(this.btnSearchByNumber_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "شماره تماس:";
            // 
            // btnStartIDCaller
            // 
            this.btnStartIDCaller.Location = new System.Drawing.Point(79, 254);
            this.btnStartIDCaller.Name = "btnStartIDCaller";
            this.btnStartIDCaller.Size = new System.Drawing.Size(109, 23);
            this.btnStartIDCaller.TabIndex = 16;
            this.btnStartIDCaller.Text = "شروع";
            this.btnStartIDCaller.UseVisualStyleBackColor = true;
            this.btnStartIDCaller.Visible = false;
            this.btnStartIDCaller.Click += new System.EventHandler(this.btnStartIDCaller_Click);
            // 
            // Form2
            // 
            this.ClientSize = new System.Drawing.Size(190, 284);
            this.Controls.Add(this.btnStartIDCaller);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSearchByNumber);
            this.Controls.Add(this.txtSearchByNumber);
            this.Controls.Add(this.btnSearchByName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSearchByName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxCustomer);
            this.Controls.Add(this.txtBoxNumber);
            this.Controls.Add(this.btnَAddCostumer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxUser;
        private System.Windows.Forms.TextBox txtBoxPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnَAddCostumer;
        private System.Windows.Forms.TextBox txtBoxCustomer;
        private System.Windows.Forms.TextBox txtBoxNumber;
        private System.Windows.Forms.TextBox txtSearchByName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSearchByName;
        private System.Windows.Forms.TextBox txtSearchByNumber;
        private System.Windows.Forms.Button btnSearchByNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnStartIDCaller;
    }
}

