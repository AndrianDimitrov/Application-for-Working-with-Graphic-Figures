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
    public partial class TriangleEdit : Form
    {
        public TriangleEdit()
        {
            InitializeComponent();
        }


        private Triangle _triangle;
        public Triangle Triangle
        {
            get
            {
                return _triangle;

            }


            set
            {
                _triangle = value;
                textBoxTriangleSide.Text = _triangle.TriangleSide.ToString();
                buttonColorTriangle.BackColor = _triangle.ColorFill;
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            try
            {
                Triangle.TriangleSide = int.Parse(textBoxTriangleSide.Text);
                Triangle.ColorFill = buttonColorTriangle.BackColor;
               
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

        private void buttonColorTriangle_Click(object sender, EventArgs e)
        {
            var cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                buttonColorTriangle.BackColor = cd.Color;
            }
        }
    }
}
