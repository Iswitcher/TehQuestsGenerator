namespace TehQuestsGenerator
{
    partial class HireControl
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
            this.unitTypeIdTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // counterTypeComboBox
            // 
            this.counterTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.counterTypeComboBox.FormattingEnabled = true;
            this.counterTypeComboBox.Items.AddRange(new object[] {
            "COUNTER_ABSOLUTE",
            "COUNTER_RELATIVE"});
            this.counterTypeComboBox.Location = new System.Drawing.Point(94, 53);
            this.counterTypeComboBox.Name = "counterTypeComboBox";
            this.counterTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.counterTypeComboBox.TabIndex = 11;
            // 
            // countTextBox
            // 
            this.countTextBox.Location = new System.Drawing.Point(94, 31);
            this.countTextBox.Name = "countTextBox";
            this.countTextBox.Size = new System.Drawing.Size(121, 20);
            this.countTextBox.TabIndex = 10;
            this.countTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.countTextBox_KeyPress);
            // 
            // unitTypeIdTextBox
            // 
            this.unitTypeIdTextBox.Location = new System.Drawing.Point(94, 9);
            this.unitTypeIdTextBox.Name = "unitTypeIdTextBox";
            this.unitTypeIdTextBox.Size = new System.Drawing.Size(121, 20);
            this.unitTypeIdTextBox.TabIndex = 9;
            this.unitTypeIdTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.unitTypeIdTextBox_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "counterType";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "count";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "unitTypeId";
            // 
            // HireControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.counterTypeComboBox);
            this.Controls.Add(this.countTextBox);
            this.Controls.Add(this.unitTypeIdTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "HireControl";
            this.Size = new System.Drawing.Size(229, 90);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox countTextBox;
        public System.Windows.Forms.TextBox unitTypeIdTextBox;
        public System.Windows.Forms.ComboBox counterTypeComboBox;
    }
}
