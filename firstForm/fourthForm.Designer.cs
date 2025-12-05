namespace firstForm
{
    partial class fourthForm
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
            this.printBtn = new System.Windows.Forms.Button();
            this.reportBtn = new System.Windows.Forms.Button();
            this.orderBtn = new System.Windows.Forms.Button();
            this.mainBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // printBtn
            // 
            this.printBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.printBtn.Location = new System.Drawing.Point(11, 360);
            this.printBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.printBtn.Name = "printBtn";
            this.printBtn.Size = new System.Drawing.Size(94, 35);
            this.printBtn.TabIndex = 22;
            this.printBtn.Text = "Печать";
            this.printBtn.UseVisualStyleBackColor = true;
            this.printBtn.Click += new System.EventHandler(this.printBtn_Click);
            // 
            // reportBtn
            // 
            this.reportBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.reportBtn.Location = new System.Drawing.Point(171, 10);
            this.reportBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.reportBtn.Name = "reportBtn";
            this.reportBtn.Size = new System.Drawing.Size(75, 31);
            this.reportBtn.TabIndex = 23;
            this.reportBtn.Text = "Отчеты";
            this.reportBtn.UseVisualStyleBackColor = true;
            this.reportBtn.Click += new System.EventHandler(this.reportBtn_Click);
            // 
            // orderBtn
            // 
            this.orderBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.orderBtn.Location = new System.Drawing.Point(92, 10);
            this.orderBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.orderBtn.Name = "orderBtn";
            this.orderBtn.Size = new System.Drawing.Size(75, 31);
            this.orderBtn.TabIndex = 24;
            this.orderBtn.Text = "Заказы";
            this.orderBtn.UseVisualStyleBackColor = true;
            this.orderBtn.Click += new System.EventHandler(this.orderBtn_Click);
            // 
            // mainBtn
            // 
            this.mainBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.mainBtn.Location = new System.Drawing.Point(12, 10);
            this.mainBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mainBtn.Name = "mainBtn";
            this.mainBtn.Size = new System.Drawing.Size(75, 31);
            this.mainBtn.TabIndex = 25;
            this.mainBtn.Text = "Главная";
            this.mainBtn.UseVisualStyleBackColor = true;
            this.mainBtn.Click += new System.EventHandler(this.mainBtn_Click);
            // 
            // fourthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 406);
            this.Controls.Add(this.reportBtn);
            this.Controls.Add(this.orderBtn);
            this.Controls.Add(this.mainBtn);
            this.Controls.Add(this.printBtn);
            this.Name = "fourthForm";
            this.Text = "Печать отчета";
            this.Load += new System.EventHandler(this.fourthForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button printBtn;
        private System.Windows.Forms.Button reportBtn;
        private System.Windows.Forms.Button orderBtn;
        private System.Windows.Forms.Button mainBtn;
    }
}