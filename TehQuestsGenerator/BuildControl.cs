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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Form1 f1 = Application.OpenForms["Form1"] as Form1;
            f1.updateBuildingTypeId(int.Parse(textBox1.Text));
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
