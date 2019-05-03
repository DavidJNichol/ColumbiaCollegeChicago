namespace VirtualPetAngelo
{
    partial class ProfileForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_PlayerName = new System.Windows.Forms.TextBox();
            this.txt_Wallet = new System.Windows.Forms.TextBox();
            this.txt_MyPet = new System.Windows.Forms.TextBox();
            this.list_Items = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Player Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Wallet";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(126, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "My Pet";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(126, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Items";
            // 
            // txt_PlayerName
            // 
            this.txt_PlayerName.Location = new System.Drawing.Point(250, 101);
            this.txt_PlayerName.Name = "txt_PlayerName";
            this.txt_PlayerName.Size = new System.Drawing.Size(100, 20);
            this.txt_PlayerName.TabIndex = 4;
            // 
            // txt_Wallet
            // 
            this.txt_Wallet.Location = new System.Drawing.Point(250, 150);
            this.txt_Wallet.Name = "txt_Wallet";
            this.txt_Wallet.Size = new System.Drawing.Size(100, 20);
            this.txt_Wallet.TabIndex = 5;
            // 
            // txt_MyPet
            // 
            this.txt_MyPet.Location = new System.Drawing.Point(250, 201);
            this.txt_MyPet.Name = "txt_MyPet";
            this.txt_MyPet.Size = new System.Drawing.Size(100, 20);
            this.txt_MyPet.TabIndex = 6;
            // 
            // list_Items
            // 
            this.list_Items.FormattingEnabled = true;
            this.list_Items.Location = new System.Drawing.Point(250, 264);
            this.list_Items.Name = "list_Items";
            this.list_Items.Size = new System.Drawing.Size(120, 95);
            this.list_Items.TabIndex = 7;
            // 
            // ProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.list_Items);
            this.Controls.Add(this.txt_MyPet);
            this.Controls.Add(this.txt_Wallet);
            this.Controls.Add(this.txt_PlayerName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ProfileForm";
            this.Text = "ProfileForm";
            this.Load += new System.EventHandler(this.ProfileForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_PlayerName;
        private System.Windows.Forms.TextBox txt_Wallet;
        private System.Windows.Forms.TextBox txt_MyPet;
        private System.Windows.Forms.ListBox list_Items;
    }
}