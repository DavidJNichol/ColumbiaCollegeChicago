namespace VirtualPetAngelo
{
    partial class PlayPetForm
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
            this.txt_PlayPetMenu = new System.Windows.Forms.TextBox();
            this.list_PlayerItems = new System.Windows.Forms.ListBox();
            this.btn_EnterPlay = new System.Windows.Forms.Button();
            this.txt_MessagePlay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_PlayPetMenu
            // 
            this.txt_PlayPetMenu.Location = new System.Drawing.Point(253, 49);
            this.txt_PlayPetMenu.Name = "txt_PlayPetMenu";
            this.txt_PlayPetMenu.Size = new System.Drawing.Size(224, 20);
            this.txt_PlayPetMenu.TabIndex = 0;
            // 
            // list_PlayerItems
            // 
            this.list_PlayerItems.FormattingEnabled = true;
            this.list_PlayerItems.Location = new System.Drawing.Point(305, 101);
            this.list_PlayerItems.Name = "list_PlayerItems";
            this.list_PlayerItems.Size = new System.Drawing.Size(120, 95);
            this.list_PlayerItems.TabIndex = 1;
            // 
            // btn_EnterPlay
            // 
            this.btn_EnterPlay.Location = new System.Drawing.Point(328, 245);
            this.btn_EnterPlay.Name = "btn_EnterPlay";
            this.btn_EnterPlay.Size = new System.Drawing.Size(75, 23);
            this.btn_EnterPlay.TabIndex = 2;
            this.btn_EnterPlay.Text = "Play";
            this.btn_EnterPlay.UseVisualStyleBackColor = true;
            this.btn_EnterPlay.Click += new System.EventHandler(this.btn_EnterPlay_Click);
            // 
            // txt_MessagePlay
            // 
            this.txt_MessagePlay.Location = new System.Drawing.Point(253, 308);
            this.txt_MessagePlay.Name = "txt_MessagePlay";
            this.txt_MessagePlay.Size = new System.Drawing.Size(224, 20);
            this.txt_MessagePlay.TabIndex = 3;
            // 
            // PlayPetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_MessagePlay);
            this.Controls.Add(this.btn_EnterPlay);
            this.Controls.Add(this.list_PlayerItems);
            this.Controls.Add(this.txt_PlayPetMenu);
            this.Name = "PlayPetForm";
            this.Text = "PlayPetForm";
            this.Load += new System.EventHandler(this.PlayPetForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_PlayPetMenu;
        private System.Windows.Forms.ListBox list_PlayerItems;
        private System.Windows.Forms.Button btn_EnterPlay;
        private System.Windows.Forms.TextBox txt_MessagePlay;
    }
}