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
    public partial class ParallelogramEdit : Form
    {
        public ParallelogramEdit()
        {
            InitializeComponent();
        }

        private Parallelogram _parallelogram;
        public Parallelogram Parallelogram
        {
            get
            {
                return _parallelogram;

            }


            set
            {
                _parallelogram = value;
                textBoxHeightP.Text = _parallelogram.HeightP.ToString();
                textBoxWidthP.Text = _parallelogram.WidthP.ToString();
                textBoxParallelogramSide.Text = _parallelogram.y.ToString();
                buttonColorParallelogram.BackColor = _parallelogram.ColorFill;
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            try
            {
                Parallelogram.WidthP = int.Parse(textBoxWidthP.Text);
                Parallelogram.HeightP = int.Parse(textBoxHeightP.Text);
                Parallelogram.y = int.Parse(textBoxParallelogramSide.Text);
                Parallelogram.ColorFill = buttonColorParallelogram.BackColor;

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

        private void buttonColorParallelogram_Click(object sender, EventArgs e)
        {
            var cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                buttonColorParallelogram.BackColor = cd.Color;
            }
        }
    }
}
