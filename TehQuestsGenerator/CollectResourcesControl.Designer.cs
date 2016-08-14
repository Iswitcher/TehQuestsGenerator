namespace TehQuestsGenerator
{
    partial class CollectResourcesControl
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
            this.counterTypeComboBox = new System.Windows.Forms.ComboBox();
            this.countTextBox = new System.Windows.Forms.TextBox();
            this.resTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // counterTypeComboBox
            // 
            this.counterTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.counterTypeComboBox.FormattingEnabled = true;
            this.counterTypeComboBox.Items.AddRange(new object[] {
            "COUNTER_ABSOLUTE",
            "COUNTER_RELATIVE"});
            this.counterTypeComboBox.Location = new System.Drawing.Point(93, 52);
            this.counterTypeComboBox.Name = "counterTypeComboBox";
            this.counterTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.counterTypeComboBox.TabIndex = 11;
            // 
            // countTextBox
            // 
            this.countTextBox.Location = new System.Drawing.Point(93, 30);
            this.countTextBox.Name = "countTextBox";
            this.countTextBox.Size = new System.Drawing.Size(121, 20);
            this.countTextBox.TabIndex = 10;
            this.countTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.countTextBox_KeyPress);
            // 
            // resTextBox
            // 
            this.resTextBox.Location = new System.Drawing.Point(93, 8);
            this.resTextBox.Name = "resTextBox";
            this.resTextBox.Size = new System.Drawing.Size(121, 20);
            this.resTextBox.TabIndex = 9;
            this.resTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.resTextBox_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "counterType";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "count";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(66, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "res";
            // 
            // CollectResourcesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.counterTypeComboBox);
            this.Controls.Add(this.countTextBox);
            this.Controls.Add(this.resTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Name = "CollectResourcesControl";
            this.Size = new System.Drawing.Size(235, 81);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.ComboBox counterTypeComboBox;
        public System.Windows.Forms.TextBox countTextBox;
        public System.Windows.Forms.TextBox resTextBox;
    }
}
