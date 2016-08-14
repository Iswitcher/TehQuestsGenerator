namespace TehQuestsGenerator
{
    partial class UpgradeControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buildingTypeIdTextBox = new System.Windows.Forms.TextBox();
            this.upgradeLevelTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "buildingTypeId";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "level";
            // 
            // buildingTypeIdTextBox
            // 
            this.buildingTypeIdTextBox.Location = new System.Drawing.Point(99, 10);
            this.buildingTypeIdTextBox.Name = "buildingTypeIdTextBox";
            this.buildingTypeIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.buildingTypeIdTextBox.TabIndex = 2;
            this.buildingTypeIdTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.buildingTypeIdTextBox_KeyPress);
            // 
            // upgradeLevelTextBox
            // 
            this.upgradeLevelTextBox.Location = new System.Drawing.Point(99, 36);
            this.upgradeLevelTextBox.Name = "upgradeLevelTextBox";
            this.upgradeLevelTextBox.Size = new System.Drawing.Size(100, 20);
            this.upgradeLevelTextBox.TabIndex = 3;
            this.upgradeLevelTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.upgradeLevelTextBox_KeyPress);
            // 
            // UpgradeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.upgradeLevelTextBox);
            this.Controls.Add(this.buildingTypeIdTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UpgradeControl";
            this.Size = new System.Drawing.Size(226, 89);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox buildingTypeIdTextBox;
        public System.Windows.Forms.TextBox upgradeLevelTextBox;
    }
}
