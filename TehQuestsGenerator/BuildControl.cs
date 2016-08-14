using System;
using System.Windows.Forms;

namespace TehQuestsGenerator
{
    public partial class BuildControl : UserControl
    {
        public BuildControl()
        {
            InitializeComponent();
        }

        private void buildingTypeIdTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), "\\d+"))
                e.Handled = true;
        }

        private void countTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), "\\d+"))
                e.Handled = true;
        }
    }
}
