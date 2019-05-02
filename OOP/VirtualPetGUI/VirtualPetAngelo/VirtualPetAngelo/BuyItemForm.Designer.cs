namespace VirtualPetAngelo
{
    partial class BuyItemForm
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txt_Wallet = new System.Windows.Forms.TextBox();
            this.txt_PlayerName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.btn_buyItem = new System.Windows.Forms.Button();
            this.txt_BuyMessage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(210, 132);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(148, 95);
            this.listBox1.TabIndex = 0;
            // 
            // txt_Wallet
            // 
            this.txt_Wallet.Location = new System.Drawing.Point(136, 84);
            this.txt_Wallet.Name = "txt_Wallet";
            this.txt_Wallet.Size = new System.Drawing.Size(100, 20);
            this.txt_Wallet.TabIndex = 9;
            // 
            // txt_PlayerName
            // 
            this.txt_PlayerName.Location = new System.Drawing.Point(136, 35);
            this.txt_PlayerName.Name = "txt_PlayerName";
            this.txt_PlayerName.Size = new System.Drawing.Size(100, 20);
            this.txt_PlayerName.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Wallet";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Player Name";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(381, 132);
            this.listBox2.Name = "listBox2";
            this.listBox2.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBox2.Size = new System.Drawing.Size(148, 95);
            this.listBox2.TabIndex = 10;
            // 
            // btn_buyItem
            // 
            this.btn_buyItem.Location = new System.Drawing.Point(330, 310);
            this.btn_buyItem.Name = "btn_buyItem";
            this.btn_buyItem.Size = new System.Drawing.Size(75, 23);
            this.btn_buyItem.TabIndex = 11;
            this.btn_buyItem.Text = "Buy";
            this.btn_buyItem.UseVisualStyleBackColor = true;
            this.btn_buyItem.Click += new System.EventHandler(this.btn_buyItem_Click);
            // 
            // txt_BuyMessage
            // 
            this.txt_BuyMessage.Location = new System.Drawing.Point(258, 379);
            this.txt_BuyMessage.Name = "txt_BuyMessage";
            this.txt_BuyMessage.Size = new System.Drawing.Size(230, 20);
            this.txt_BuyMessage.TabIndex = 12;
            // 
            // BuyItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_BuyMessage);
            this.Controls.Add(this.btn_buyItem);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.txt_Wallet);
            this.Controls.Add(this.txt_PlayerName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Name = "BuyItemForm";
            this.Text = "BuyItemForm";
            this.Load += new System.EventHandler(this.BuyItemForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txt_Wallet;
        private System.Windows.Forms.TextBox txt_PlayerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button btn_buyItem;
        private System.Windows.Forms.TextBox txt_BuyMessage;
    }
}