namespace UIAssignment
{
    partial class Form1
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
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonTakeOff = new System.Windows.Forms.Button();
            this.buttonFlyUp = new System.Windows.Forms.Button();
            this.buttonFlyDown = new System.Windows.Forms.Button();
            this.button_About = new System.Windows.Forms.Button();
            this.textBoxAbout = new System.Windows.Forms.TextBox();
            this.comboBoxVehicle = new System.Windows.Forms.ComboBox();
            this.panelAerialVehicle = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(14, 134);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonTakeOff
            // 
            this.buttonTakeOff.Location = new System.Drawing.Point(14, 194);
            this.buttonTakeOff.Name = "buttonTakeOff";
            this.buttonTakeOff.Size = new System.Drawing.Size(75, 23);
            this.buttonTakeOff.TabIndex = 1;
            this.buttonTakeOff.Text = "Take Off";
            this.buttonTakeOff.UseVisualStyleBackColor = true;
            this.buttonTakeOff.Click += new System.EventHandler(this.buttonTakeOff_Click);
            // 
            // buttonFlyUp
            // 
            this.buttonFlyUp.Location = new System.Drawing.Point(122, 134);
            this.buttonFlyUp.Name = "buttonFlyUp";
            this.buttonFlyUp.Size = new System.Drawing.Size(75, 23);
            this.buttonFlyUp.TabIndex = 3;
            this.buttonFlyUp.Text = "Fly Up";
            this.buttonFlyUp.UseVisualStyleBackColor = true;
            this.buttonFlyUp.Click += new System.EventHandler(this.buttonFlyUp_Click);
            // 
            // buttonFlyDown
            // 
            this.buttonFlyDown.Location = new System.Drawing.Point(122, 194);
            this.buttonFlyDown.Name = "buttonFlyDown";
            this.buttonFlyDown.Size = new System.Drawing.Size(75, 23);
            this.buttonFlyDown.TabIndex = 4;
            this.buttonFlyDown.Text = "Fly Down";
            this.buttonFlyDown.UseVisualStyleBackColor = true;
            this.buttonFlyDown.Click += new System.EventHandler(this.buttonFlyDown_Click);
            // 
            // button_About
            // 
            this.button_About.Location = new System.Drawing.Point(69, 79);
            this.button_About.Name = "button_About";
            this.button_About.Size = new System.Drawing.Size(75, 23);
            this.button_About.TabIndex = 5;
            this.button_About.Text = "About";
            this.button_About.UseVisualStyleBackColor = true;
            this.button_About.Click += new System.EventHandler(this.button_About_Click);
            // 
            // textBoxAbout
            // 
            this.textBoxAbout.Location = new System.Drawing.Point(14, 242);
            this.textBoxAbout.Multiline = true;
            this.textBoxAbout.Name = "textBoxAbout";
            this.textBoxAbout.ReadOnly = true;
            this.textBoxAbout.Size = new System.Drawing.Size(294, 156);
            this.textBoxAbout.TabIndex = 6;
            // 
            // comboBoxVehicle
            // 
            this.comboBoxVehicle.FormattingEnabled = true;
            this.comboBoxVehicle.Items.AddRange(new object[] {
            "Airplane",
            "Helicopter"});
            this.comboBoxVehicle.Location = new System.Drawing.Point(50, 36);
            this.comboBoxVehicle.Name = "comboBoxVehicle";
            this.comboBoxVehicle.Size = new System.Drawing.Size(121, 21);
            this.comboBoxVehicle.TabIndex = 7;
            this.comboBoxVehicle.SelectedIndexChanged += new System.EventHandler(this.comboBoxVehicle_SelectedIndexChanged);
            // 
            // panelAerialVehicle
            // 
            this.panelAerialVehicle.Location = new System.Drawing.Point(314, 69);
            this.panelAerialVehicle.Name = "panelAerialVehicle";
            this.panelAerialVehicle.Size = new System.Drawing.Size(238, 329);
            this.panelAerialVehicle.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 450);
            this.Controls.Add(this.panelAerialVehicle);
            this.Controls.Add(this.comboBoxVehicle);
            this.Controls.Add(this.textBoxAbout);
            this.Controls.Add(this.button_About);
            this.Controls.Add(this.buttonFlyDown);
            this.Controls.Add(this.buttonFlyUp);
            this.Controls.Add(this.buttonTakeOff);
            this.Controls.Add(this.buttonStart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonTakeOff;
        private System.Windows.Forms.Button buttonFlyUp;
        private System.Windows.Forms.Button buttonFlyDown;
        private System.Windows.Forms.Button button_About;
        private System.Windows.Forms.TextBox textBoxAbout;
        private System.Windows.Forms.ComboBox comboBoxVehicle;
        private System.Windows.Forms.Panel panelAerialVehicle;
    }
}

