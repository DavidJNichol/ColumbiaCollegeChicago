namespace VirtualPetAngelo
{
    partial class PetMenu
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
            this.lb_Player = new System.Windows.Forms.Label();
            this.lb_Wallet = new System.Windows.Forms.Label();
            this.txb_PlayerName = new System.Windows.Forms.TextBox();
            this.txb_PlayerWallet = new System.Windows.Forms.TextBox();
            this.btn_SelectPet = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lb_Player
            // 
            this.lb_Player.AutoSize = true;
            this.lb_Player.Location = new System.Drawing.Point(8, 6);
            this.lb_Player.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Player.Name = "lb_Player";
            this.lb_Player.Size = new System.Drawing.Size(42, 13);
            this.lb_Player.TabIndex = 0;
            this.lb_Player.Text = "Player :";
            // 
            // lb_Wallet
            // 
            this.lb_Wallet.AutoSize = true;
            this.lb_Wallet.Location = new System.Drawing.Point(189, 6);
            this.lb_Wallet.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Wallet.Name = "lb_Wallet";
            this.lb_Wallet.Size = new System.Drawing.Size(43, 13);
            this.lb_Wallet.TabIndex = 1;
            this.lb_Wallet.Text = "Wallet :";
            // 
            // txb_PlayerName
            // 
            this.txb_PlayerName.Location = new System.Drawing.Point(52, 4);
            this.txb_PlayerName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txb_PlayerName.Name = "txb_PlayerName";
            this.txb_PlayerName.ReadOnly = true;
            this.txb_PlayerName.Size = new System.Drawing.Size(126, 20);
            this.txb_PlayerName.TabIndex = 2;
            // 
            // txb_PlayerWallet
            // 
            this.txb_PlayerWallet.Location = new System.Drawing.Point(233, 4);
            this.txb_PlayerWallet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txb_PlayerWallet.Name = "txb_PlayerWallet";
            this.txb_PlayerWallet.ReadOnly = true;
            this.txb_PlayerWallet.Size = new System.Drawing.Size(99, 20);
            this.txb_PlayerWallet.TabIndex = 3;
            // 
            // btn_SelectPet
            // 
            this.btn_SelectPet.Location = new System.Drawing.Point(240, 201);
            this.btn_SelectPet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_SelectPet.Name = "btn_SelectPet";
            this.btn_SelectPet.Size = new System.Drawing.Size(50, 34);
            this.btn_SelectPet.TabIndex = 5;
            this.btn_SelectPet.Text = "Select";
            this.btn_SelectPet.UseVisualStyleBackColor = true;
            this.btn_SelectPet.Click += new System.EventHandler(this.btn_SelectPet_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(96, 70);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(162, 95);
            this.listBox1.TabIndex = 6;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(277, 70);
            this.listBox2.Name = "listBox2";
            this.listBox2.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBox2.Size = new System.Drawing.Size(162, 95);
            this.listBox2.TabIndex = 7;
            // 
            // PetMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_SelectPet);
            this.Controls.Add(this.txb_PlayerWallet);
            this.Controls.Add(this.txb_PlayerName);
            this.Controls.Add(this.lb_Wallet);
            this.Controls.Add(this.lb_Player);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PetMenu";
            this.Text = "PetMenu";
            this.Load += new System.EventHandler(this.PetMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Player;
        private System.Windows.Forms.Label lb_Wallet;
        private System.Windows.Forms.TextBox txb_PlayerName;
        private System.Windows.Forms.TextBox txb_PlayerWallet;
        private System.Windows.Forms.Button btn_SelectPet;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
    }
}