namespace VirtualPetAngelo
{
    partial class MainMenu
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
            this.txt_mainMenu = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeMoneyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.playWithPetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.evolvePetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.petStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.buyItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sellItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_mainMenu
            // 
            this.txt_mainMenu.Location = new System.Drawing.Point(251, 42);
            this.txt_mainMenu.Name = "txt_mainMenu";
            this.txt_mainMenu.Size = new System.Drawing.Size(270, 20);
            this.txt_mainMenu.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profileToolStripMenuItem,
            this.makeMoneyToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(51, 20);
            this.toolStripMenuItem1.Text = "Player";
            // 
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.profileToolStripMenuItem.Text = "Profile";
            this.profileToolStripMenuItem.Click += new System.EventHandler(this.profileToolStripMenuItem_Click);
            // 
            // makeMoneyToolStripMenuItem
            // 
            this.makeMoneyToolStripMenuItem.Name = "makeMoneyToolStripMenuItem";
            this.makeMoneyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.makeMoneyToolStripMenuItem.Text = "Make Money";
            this.makeMoneyToolStripMenuItem.Click += new System.EventHandler(this.makeMoneyToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playWithPetToolStripMenuItem,
            this.evolvePetToolStripMenuItem,
            this.petStatusToolStripMenuItem});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(36, 20);
            this.toolStripMenuItem2.Text = "Pet";
            // 
            // playWithPetToolStripMenuItem
            // 
            this.playWithPetToolStripMenuItem.Name = "playWithPetToolStripMenuItem";
            this.playWithPetToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.playWithPetToolStripMenuItem.Text = "Play with Pet";
            this.playWithPetToolStripMenuItem.Click += new System.EventHandler(this.playWithPetToolStripMenuItem_Click);
            // 
            // evolvePetToolStripMenuItem
            // 
            this.evolvePetToolStripMenuItem.Name = "evolvePetToolStripMenuItem";
            this.evolvePetToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.evolvePetToolStripMenuItem.Text = "Evolve Pet";
            // 
            // petStatusToolStripMenuItem
            // 
            this.petStatusToolStripMenuItem.Name = "petStatusToolStripMenuItem";
            this.petStatusToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.petStatusToolStripMenuItem.Text = "Pet Status";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buyItemsToolStripMenuItem,
            this.sellItemsToolStripMenuItem});
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(46, 20);
            this.toolStripMenuItem3.Text = "Store";
            // 
            // buyItemsToolStripMenuItem
            // 
            this.buyItemsToolStripMenuItem.Name = "buyItemsToolStripMenuItem";
            this.buyItemsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.buyItemsToolStripMenuItem.Text = "Buy Items";
            this.buyItemsToolStripMenuItem.Click += new System.EventHandler(this.buyItemsToolStripMenuItem_Click);
            // 
            // sellItemsToolStripMenuItem
            // 
            this.sellItemsToolStripMenuItem.Name = "sellItemsToolStripMenuItem";
            this.sellItemsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sellItemsToolStripMenuItem.Text = "Sell Items";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_mainMenu);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_mainMenu;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem playWithPetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem evolvePetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem petStatusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makeMoneyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buyItemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sellItemsToolStripMenuItem;
    }
}