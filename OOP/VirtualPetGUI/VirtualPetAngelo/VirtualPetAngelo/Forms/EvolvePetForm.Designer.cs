namespace VirtualPetAngelo.Forms
{
    partial class EvolvePetForm
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
            this.txt_PlayerName = new System.Windows.Forms.TextBox();
            this.txt_PlayerScore = new System.Windows.Forms.TextBox();
            this.txt_PlayerWallet = new System.Windows.Forms.TextBox();
            this.txt_PlayerPet = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_evolveMessage = new System.Windows.Forms.TextBox();
            this.btn_Evolve = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_PlayerName
            // 
            this.txt_PlayerName.Location = new System.Drawing.Point(363, 134);
            this.txt_PlayerName.Name = "txt_PlayerName";
            this.txt_PlayerName.Size = new System.Drawing.Size(314, 44);
            this.txt_PlayerName.TabIndex = 0;
            // 
            // txt_PlayerScore
            // 
            this.txt_PlayerScore.Location = new System.Drawing.Point(363, 290);
            this.txt_PlayerScore.Name = "txt_PlayerScore";
            this.txt_PlayerScore.Size = new System.Drawing.Size(314, 44);
            this.txt_PlayerScore.TabIndex = 1;
            // 
            // txt_PlayerWallet
            // 
            this.txt_PlayerWallet.Location = new System.Drawing.Point(363, 455);
            this.txt_PlayerWallet.Name = "txt_PlayerWallet";
            this.txt_PlayerWallet.Size = new System.Drawing.Size(314, 44);
            this.txt_PlayerWallet.TabIndex = 2;
            // 
            // txt_PlayerPet
            // 
            this.txt_PlayerPet.Location = new System.Drawing.Point(363, 614);
            this.txt_PlayerPet.Name = "txt_PlayerPet";
            this.txt_PlayerPet.Size = new System.Drawing.Size(314, 44);
            this.txt_PlayerPet.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "Player";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 297);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 37);
            this.label2.TabIndex = 5;
            this.label2.Text = "Score";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 458);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 37);
            this.label3.TabIndex = 6;
            this.label3.Text = "Wallet";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 614);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 37);
            this.label4.TabIndex = 7;
            this.label4.Text = "Pet";
            // 
            // txt_evolveMessage
            // 
            this.txt_evolveMessage.Location = new System.Drawing.Point(447, 783);
            this.txt_evolveMessage.Name = "txt_evolveMessage";
            this.txt_evolveMessage.Size = new System.Drawing.Size(625, 44);
            this.txt_evolveMessage.TabIndex = 8;
            // 
            // btn_Evolve
            // 
            this.btn_Evolve.Location = new System.Drawing.Point(1063, 268);
            this.btn_Evolve.Name = "btn_Evolve";
            this.btn_Evolve.Size = new System.Drawing.Size(259, 247);
            this.btn_Evolve.TabIndex = 9;
            this.btn_Evolve.Text = "Evolve";
            this.btn_Evolve.UseVisualStyleBackColor = true;
            this.btn_Evolve.Click += new System.EventHandler(this.btn_Evolve_Click);
            // 
            // EvolvePetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1581, 975);
            this.Controls.Add(this.btn_Evolve);
            this.Controls.Add(this.txt_evolveMessage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_PlayerPet);
            this.Controls.Add(this.txt_PlayerWallet);
            this.Controls.Add(this.txt_PlayerScore);
            this.Controls.Add(this.txt_PlayerName);
            this.Name = "EvolvePetForm";
            this.Text = "EvolvePetForm";
            this.Load += new System.EventHandler(this.EvolvePetForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_PlayerName;
        private System.Windows.Forms.TextBox txt_PlayerScore;
        private System.Windows.Forms.TextBox txt_PlayerWallet;
        private System.Windows.Forms.TextBox txt_PlayerPet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_evolveMessage;
        private System.Windows.Forms.Button btn_Evolve;
    }
}