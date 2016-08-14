namespace TehQuestsGenerator
{
    partial class LearnControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.levelTextBox = new System.Windows.Forms.TextBox();
            this.knowledgeTypeIdTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // levelTextBox
            // 
            this.levelTextBox.Location = new System.Drawing.Point(102, 34);
            this.levelTextBox.Name = "levelTextBox";
            this.levelTextBox.Size = new System.Drawing.Size(121, 20);
            this.levelTextBox.TabIndex = 14;
            this.levelTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.levelTextBox_KeyPress);
            // 
            // knowledgeTypeIdTextBox
            // 
            this.knowledgeTypeIdTextBox.Location = new System.Drawing.Point(102, 12);
            this.knowledgeTypeIdTextBox.Name = "knowledgeTypeIdTextBox";
            this.knowledgeTypeIdTextBox.Size = new System.Drawing.Size(121, 20);
            this.knowledgeTypeIdTextBox.TabIndex = 13;
            this.knowledgeTypeIdTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.knowledgeTypeIdTextBox_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "level";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "knowledgeTypeId";
            // 
            // LearnControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.levelTextBox);
            this.Controls.Add(this.knowledgeTypeIdTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LearnControl";
            this.Size = new System.Drawing.Size(243, 71);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox levelTextBox;
        public System.Windows.Forms.TextBox knowledgeTypeIdTextBox;
    }
}
