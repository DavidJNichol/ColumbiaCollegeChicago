namespace VirtualPetAngelo.Forms
{
    partial class SellItemForm
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
            this.list_Items = new System.Windows.Forms.ListBox();
            this.list_itemsPrice = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_playerName = new System.Windows.Forms.TextBox();
            this.txt_playerWallet = new System.Windows.Forms.TextBox();
            this.btn_SellItem = new System.Windows.Forms.Button();
            this.txt_messageSell = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // list_Items
            // 
            this.list_Items.FormattingEnabled = true;
            this.list_Items.ItemHeight = 37;
            this.list_Items.Location = new System.Drawing.Point(162, 248);
            this.list_Items.Name = "list_Items";
            this.list_Items.Size = new System.Drawing.Size(293, 226);
            this.list_Items.TabIndex = 0;
            // 
            // list_itemsPrice
            // 
            this.list_itemsPrice.FormattingEnabled = true;
            this.list_itemsPrice.ItemHeight = 37;
            this.list_itemsPrice.Location = new System.Drawing.Point(613, 248);
            this.list_itemsPrice.Name = "list_itemsPrice";
            this.list_itemsPrice.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.list_itemsPrice.Size = new System.Drawing.Size(298, 226);
            this.list_itemsPrice.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Player";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(485, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 37);
            this.label2.TabIndex = 3;
            this.label2.Text = "Wallet";
            // 
            // txt_playerName
            // 
            this.txt_playerName.Location = new System.Drawing.Point(162, 59);
            this.txt_playerName.Name = "txt_playerName";
            this.txt_playerName.Size = new System.Drawing.Size(297, 44);
            this.txt_playerName.TabIndex = 4;
            // 
            // txt_playerWallet
            // 
            this.txt_playerWallet.Location = new System.Drawing.Point(613, 63);
            this.txt_playerWallet.Name = "txt_playerWallet";
            this.txt_playerWallet.Size = new System.Drawing.Size(298, 44);
            this.txt_playerWallet.TabIndex = 5;
            // 
            // btn_SellItem
            // 
            this.btn_SellItem.Location = new System.Drawing.Point(437, 600);
            this.btn_SellItem.Name = "btn_SellItem";
            this.btn_SellItem.Size = new System.Drawing.Size(181, 81);
            this.btn_SellItem.TabIndex = 6;
            this.btn_SellItem.Text = "Sell";
            this.btn_SellItem.UseVisualStyleBackColor = true;
            this.btn_SellItem.Click += new System.EventHandler(this.btn_SellItem_Click);
            // 
            // txt_messageSell
            // 
            this.txt_messageSell.Location = new System.Drawing.Point(237, 729);
            this.txt_messageSell.Name = "txt_messageSell";
            this.txt_messageSell.Size = new System.Drawing.Size(570, 44);
            this.txt_messageSell.TabIndex = 7;
            // 
            // SellItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 820);
            this.Controls.Add(this.txt_messageSell);
            this.Controls.Add(this.btn_SellItem);
            this.Controls.Add(this.txt_playerWallet);
            this.Controls.Add(this.txt_playerName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.list_itemsPrice);
            this.Controls.Add(this.list_Items);
            this.Name = "SellItemForm";
            this.Text = "SellItemForm";
            this.Load += new System.EventHandler(this.SellItemForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox list_Items;
        private System.Windows.Forms.ListBox list_itemsPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_playerName;
        private System.Windows.Forms.TextBox txt_playerWallet;
        private System.Windows.Forms.Button btn_SellItem;
        private System.Windows.Forms.TextBox txt_messageSell;
    }
}