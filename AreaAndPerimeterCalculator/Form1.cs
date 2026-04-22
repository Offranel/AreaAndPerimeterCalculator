using System;
using System.Windows.Forms;

namespace AreaAndPerimeterCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int length = int.Parse(txtLenght.Text);
            int width = int.Parse(txtWidth.Text);

            int area = length * width;
            int perimeter = 2 * (length + width);

            txtArea.Text = area.ToString();
            txtPerimeter.Text = perimeter.ToString();
        }
    }
}
