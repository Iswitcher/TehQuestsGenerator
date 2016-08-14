namespace TehQuestsGenerator
{
    partial class BuildControl
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
            this.label3 = new System.Windows.Forms.Label();
            this.buildingTypeIdTextBox = new System.Windows.Forms.TextBox();
            this.countTextBox = new System.Windows.Forms.TextBox();
            this.counterTypeComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "buildingTypeId";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "count";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "counterType";
            // 
            // buildingTypeIdTextBox
            // 
            this.buildingTypeIdTextBox.Location = new System.Drawing.Point(94, 8);
            this.buildingTypeIdTextBox.Name = "buildingTypeIdTextBox";
            this.buildingTypeIdTextBox.Size = new System.Drawing.Size(146, 20);
            this.buildingTypeIdTextBox.TabIndex = 3;
            this.buildingTypeIdTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.buildingTypeIdTextBox_KeyPress);
            // 
            // countTextBox
            // 
            this.countTextBox.Location = new System.Drawing.Point(94, 30);
            this.countTextBox.Name = "countTextBox";
            this.countTextBox.Size = new System.Drawing.Size(146, 20);
            this.countTextBox.TabIndex = 4;
            this.countTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.countTextBox_KeyPress);
            // 
            // counterTypeComboBox
            // 
            this.counterTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.counterTypeComboBox.FormattingEnabled = true;
            this.counterTypeComboBox.Items.AddRange(new object[] {
            "COUNTER_ABSOLUTE",
            "COUNTER_RELATIVE"});
            this.counterTypeComboBox.Location = new System.Drawing.Point(94, 52);
            this.counterTypeComboBox.Name = "counterTypeComboBox";
            this.counterTypeComboBox.Size = new System.Drawing.Size(146, 21);
            this.counterTypeComboBox.TabIndex = 5;
            // 
            // BuildControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.counterTypeComboBox);
            this.Controls.Add(this.countTextBox);
            this.Controls.Add(this.buildingTypeIdTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BuildControl";
            this.Size = new System.Drawing.Size(273, 80);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox buildingTypeIdTextBox;
        public System.Windows.Forms.TextBox countTextBox;
        public System.Windows.Forms.ComboBox counterTypeComboBox;
    }
}
