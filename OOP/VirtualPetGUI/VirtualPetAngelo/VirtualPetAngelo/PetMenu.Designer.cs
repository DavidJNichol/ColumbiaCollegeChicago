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
            this.listView1 = new System.Windows.Forms.ListView();
            this.Pet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lb_Player
            // 
            this.lb_Player.AutoSize = true;
            this.lb_Player.Location = new System.Drawing.Point(12, 9);
            this.lb_Player.Name = "lb_Player";
            this.lb_Player.Size = new System.Drawing.Size(60, 20);
            this.lb_Player.TabIndex = 0;
            this.lb_Player.Text = "Player :";
            // 
            // lb_Wallet
            // 
            this.lb_Wallet.AutoSize = true;
            this.lb_Wallet.Location = new System.Drawing.Point(283, 9);
            this.lb_Wallet.Name = "lb_Wallet";
            this.lb_Wallet.Size = new System.Drawing.Size(61, 20);
            this.lb_Wallet.TabIndex = 1;
            this.lb_Wallet.Text = "Wallet :";
            // 
            // txb_PlayerName
            // 
            this.txb_PlayerName.Location = new System.Drawing.Point(78, 6);
            this.txb_PlayerName.Name = "txb_PlayerName";
            this.txb_PlayerName.ReadOnly = true;
            this.txb_PlayerName.Size = new System.Drawing.Size(187, 26);
            this.txb_PlayerName.TabIndex = 2;
            // 
            // txb_PlayerWallet
            // 
            this.txb_PlayerWallet.Location = new System.Drawing.Point(350, 6);
            this.txb_PlayerWallet.Name = "txb_PlayerWallet";
            this.txb_PlayerWallet.ReadOnly = true;
            this.txb_PlayerWallet.Size = new System.Drawing.Size(146, 26);
            this.txb_PlayerWallet.TabIndex = 3;
            // 
            // btn_SelectPet
            // 
            this.btn_SelectPet.Location = new System.Drawing.Point(360, 309);
            this.btn_SelectPet.Name = "btn_SelectPet";
            this.btn_SelectPet.Size = new System.Drawing.Size(75, 53);
            this.btn_SelectPet.TabIndex = 5;
            this.btn_SelectPet.Text = "Select";
            this.btn_SelectPet.UseVisualStyleBackColor = true;
            this.btn_SelectPet.Click += new System.EventHandler(this.btn_SelectPet_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Pet,
            this.Price});
            this.listView1.Location = new System.Drawing.Point(16, 74);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(772, 124);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Pet
            // 
            this.Pet.Width = 120;
            // 
            // PetMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btn_SelectPet);
            this.Controls.Add(this.txb_PlayerWallet);
            this.Controls.Add(this.txb_PlayerName);
            this.Controls.Add(this.lb_Wallet);
            this.Controls.Add(this.lb_Player);
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
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Pet;
        private System.Windows.Forms.ColumnHeader Price;
    }
}