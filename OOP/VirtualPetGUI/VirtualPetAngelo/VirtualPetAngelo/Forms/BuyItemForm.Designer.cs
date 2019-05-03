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
            this.listBox1.ItemHeight = 37;
            this.listBox1.Location = new System.Drawing.Point(141, 252);
            this.listBox1.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(331, 226);
            this.listBox1.TabIndex = 0;
            // 
            // txt_Wallet
            // 
            this.txt_Wallet.Location = new System.Drawing.Point(700, 52);
            this.txt_Wallet.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.txt_Wallet.Name = "txt_Wallet";
            this.txt_Wallet.Size = new System.Drawing.Size(245, 44);
            this.txt_Wallet.TabIndex = 9;
            // 
            // txt_PlayerName
            // 
            this.txt_PlayerName.Location = new System.Drawing.Point(182, 52);
            this.txt_PlayerName.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.txt_PlayerName.Name = "txt_PlayerName";
            this.txt_PlayerName.Size = new System.Drawing.Size(308, 44);
            this.txt_PlayerName.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(557, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 37);
            this.label2.TabIndex = 7;
            this.label2.Text = "Wallet";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 37);
            this.label1.TabIndex = 6;
            this.label1.Text = "Player";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 37;
            this.listBox2.Location = new System.Drawing.Point(564, 252);
            this.listBox2.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.listBox2.Name = "listBox2";
            this.listBox2.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBox2.Size = new System.Drawing.Size(338, 226);
            this.listBox2.TabIndex = 10;
            // 
            // btn_buyItem
            // 
            this.btn_buyItem.Location = new System.Drawing.Point(406, 581);
            this.btn_buyItem.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.btn_buyItem.Name = "btn_buyItem";
            this.btn_buyItem.Size = new System.Drawing.Size(238, 65);
            this.btn_buyItem.TabIndex = 11;
            this.btn_buyItem.Text = "Buy";
            this.btn_buyItem.UseVisualStyleBackColor = true;
            this.btn_buyItem.Click += new System.EventHandler(this.btn_buyItem_Click);
            // 
            // txt_BuyMessage
            // 
            this.txt_BuyMessage.Location = new System.Drawing.Point(182, 735);
            this.txt_BuyMessage.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.txt_BuyMessage.Name = "txt_BuyMessage";
            this.txt_BuyMessage.Size = new System.Drawing.Size(720, 44);
            this.txt_BuyMessage.TabIndex = 12;
            // 
            // BuyItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 824);
            this.Controls.Add(this.txt_BuyMessage);
            this.Controls.Add(this.btn_buyItem);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.txt_Wallet);
            this.Controls.Add(this.txt_PlayerName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
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