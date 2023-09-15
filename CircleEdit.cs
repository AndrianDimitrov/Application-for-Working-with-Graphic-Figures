using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KURSOVA_ETAP1
{
    public partial class CircleEdit : Form
    {
        public CircleEdit()
        {
            InitializeComponent();
        }


        private Circle _circle;

        public Circle Circle
        {
            get
            {

                return _circle;

            }

            set
            {    _circle=value;
                textBoxRadius.Text = _circle.Radius.ToString();
                buttonColorCircle.BackColor = _circle.ColorFill;
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            try
            {
                Circle.Radius = int.Parse(textBoxRadius.Text);
                Circle.ColorFill = buttonColorCircle.BackColor;
                
            }
            catch
            {
                MessageBox.Show("Invalid value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            DialogResult = DialogResult.OK;
        }
    

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonColorCircle_Click(object sender, EventArgs e)
        {
            var cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                buttonColorCircle.BackColor = cd.Color;
            }
        }
    }
}
