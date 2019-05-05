namespace VirtualPetAngelo.Forms
{
    partial class PetStatusForm
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
            this.txt_Pet = new System.Windows.Forms.TextBox();
            this.txt_PetSkill = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_Pet
            // 
            this.txt_Pet.Location = new System.Drawing.Point(192, 122);
            this.txt_Pet.Name = "txt_Pet";
            this.txt_Pet.Size = new System.Drawing.Size(277, 44);
            this.txt_Pet.TabIndex = 0;
            // 
            // txt_PetSkill
            // 
            this.txt_PetSkill.Location = new System.Drawing.Point(192, 255);
            this.txt_PetSkill.Name = "txt_PetSkill";
            this.txt_PetSkill.Size = new System.Drawing.Size(277, 44);
            this.txt_PetSkill.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 37);
            this.label2.TabIndex = 3;
            this.label2.Text = "Skill";
            // 
            // PetStatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 424);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_PetSkill);
            this.Controls.Add(this.txt_Pet);
            this.Name = "PetStatusForm";
            this.Text = "PetStatusForm";
            this.Load += new System.EventHandler(this.PetStatusForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Pet;
        private System.Windows.Forms.TextBox txt_PetSkill;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}