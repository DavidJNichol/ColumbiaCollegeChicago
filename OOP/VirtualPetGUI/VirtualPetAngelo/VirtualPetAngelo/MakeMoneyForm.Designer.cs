namespace VirtualPetAngelo
{
    partial class MakeMoneyForm
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
            this.txt_MakeMoneyMenu = new System.Windows.Forms.TextBox();
            this.txt_MakeMoneyAnswer = new System.Windows.Forms.TextBox();
            this.btn_MoneyEnter = new System.Windows.Forms.Button();
            this.txt_Status = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_MakeMoneyMenu
            // 
            this.txt_MakeMoneyMenu.Location = new System.Drawing.Point(238, 55);
            this.txt_MakeMoneyMenu.Multiline = true;
            this.txt_MakeMoneyMenu.Name = "txt_MakeMoneyMenu";
            this.txt_MakeMoneyMenu.ReadOnly = true;
            this.txt_MakeMoneyMenu.Size = new System.Drawing.Size(273, 99);
            this.txt_MakeMoneyMenu.TabIndex = 0;
            // 
            // txt_MakeMoneyAnswer
            // 
            this.txt_MakeMoneyAnswer.Location = new System.Drawing.Point(324, 234);
            this.txt_MakeMoneyAnswer.Name = "txt_MakeMoneyAnswer";
            this.txt_MakeMoneyAnswer.Size = new System.Drawing.Size(100, 20);
            this.txt_MakeMoneyAnswer.TabIndex = 1;
            // 
            // btn_MoneyEnter
            // 
            this.btn_MoneyEnter.Location = new System.Drawing.Point(336, 284);
            this.btn_MoneyEnter.Name = "btn_MoneyEnter";
            this.btn_MoneyEnter.Size = new System.Drawing.Size(75, 23);
            this.btn_MoneyEnter.TabIndex = 2;
            this.btn_MoneyEnter.Text = "Enter";
            this.btn_MoneyEnter.UseVisualStyleBackColor = true;
            this.btn_MoneyEnter.Click += new System.EventHandler(this.btn_MoneyEnter_Click);
            // 
            // txt_Status
            // 
            this.txt_Status.Location = new System.Drawing.Point(262, 357);
            this.txt_Status.Multiline = true;
            this.txt_Status.Name = "txt_Status";
            this.txt_Status.Size = new System.Drawing.Size(223, 40);
            this.txt_Status.TabIndex = 3;
            // 
            // MakeMoneyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_Status);
            this.Controls.Add(this.btn_MoneyEnter);
            this.Controls.Add(this.txt_MakeMoneyAnswer);
            this.Controls.Add(this.txt_MakeMoneyMenu);
            this.Name = "MakeMoneyForm";
            this.Text = "MakeMoneyForm";
            this.Load += new System.EventHandler(this.MakeMoneyForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_MakeMoneyMenu;
        private System.Windows.Forms.TextBox txt_MakeMoneyAnswer;
        private System.Windows.Forms.Button btn_MoneyEnter;
        private System.Windows.Forms.TextBox txt_Status;
    }
}