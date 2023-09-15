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
    public partial class RectangleEdit : Form
    {

        private Rectangle _rectangle;
        public Rectangle Rectangle
        {
            get 
            { 
             return _rectangle;
            }
            set
            {
                _rectangle = value;
                textBoxWidth.Text = _rectangle.Width.ToString();
                textBoxHeight.Text = _rectangle.Height.ToString();
                buttonColorRectangle.BackColor = _rectangle.ColorFill;
            }        
        }


        public RectangleEdit()
        {
            InitializeComponent();
        }

        private void FormEdit_Load(object sender, EventArgs e)
        {

        }

        private void buttonOK_Click(object sender, EventArgs e)
        { try
            {
                Rectangle.Width = int.Parse(textBoxWidth.Text);
                Rectangle.Height = int.Parse(textBoxHeight.Text);
                Rectangle.ColorFill = buttonColorRectangle.BackColor;   
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

        private void buttonColorRectangle_Click(object sender, EventArgs e)
        {
            var cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                buttonColorRectangle.BackColor = cd.Color;
            }
        }
    }
}
