namespace VirtualPetAngelo
{
    partial class CreatePlayerName
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
            this.menu_QuestionName = new System.Windows.Forms.TextBox();
            this.menu_AnswerName = new System.Windows.Forms.TextBox();
            this.btn_createPlayerName = new System.Windows.Forms.Button();
            this.btn_NextForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // menu_QuestionName
            // 
            this.menu_QuestionName.Location = new System.Drawing.Point(223, 113);
            this.menu_QuestionName.Name = "menu_QuestionName";
            this.menu_QuestionName.ReadOnly = true;
            this.menu_QuestionName.Size = new System.Drawing.Size(316, 26);
            this.menu_QuestionName.TabIndex = 0;
            this.menu_QuestionName.Text = " ";
            this.menu_QuestionName.TextChanged += new System.EventHandler(this.menu_QuestionName_TextChanged);
            // 
            // menu_AnswerName
            // 
            this.menu_AnswerName.Location = new System.Drawing.Point(276, 202);
            this.menu_AnswerName.Name = "menu_AnswerName";
            this.menu_AnswerName.Size = new System.Drawing.Size(208, 26);
            this.menu_AnswerName.TabIndex = 1;
            // 
            // btn_createPlayerName
            // 
            this.btn_createPlayerName.Location = new System.Drawing.Point(343, 298);
            this.btn_createPlayerName.Name = "btn_createPlayerName";
            this.btn_createPlayerName.Size = new System.Drawing.Size(75, 34);
            this.btn_createPlayerName.TabIndex = 2;
            this.btn_createPlayerName.Text = "Create";
            this.btn_createPlayerName.UseVisualStyleBackColor = true;
            this.btn_createPlayerName.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_NextForm
            // 
            this.btn_NextForm.Enabled = false;
            this.btn_NextForm.Location = new System.Drawing.Point(343, 376);
            this.btn_NextForm.Name = "btn_NextForm";
            this.btn_NextForm.Size = new System.Drawing.Size(75, 34);
            this.btn_NextForm.TabIndex = 3;
            this.btn_NextForm.Text = "Next";
            this.btn_NextForm.UseVisualStyleBackColor = true;
            this.btn_NextForm.Click += new System.EventHandler(this.btn_NextForm_Click);
            // 
            // CreatePlayerName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_NextForm);
            this.Controls.Add(this.btn_createPlayerName);
            this.Controls.Add(this.menu_AnswerName);
            this.Controls.Add(this.menu_QuestionName);
            this.Name = "CreatePlayerName";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox menu_QuestionName;
        private System.Windows.Forms.TextBox menu_AnswerName;
        private System.Windows.Forms.Button btn_createPlayerName;
        private System.Windows.Forms.Button btn_NextForm;
    }
}