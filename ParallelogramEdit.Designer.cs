namespace KURSOVA_ETAP1
{
    partial class ParallelogramEdit
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxWidthP = new System.Windows.Forms.TextBox();
            this.textBoxParallelogramSide = new System.Windows.Forms.TextBox();
            this.textBoxHeightP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonColorParallelogram = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(199, 270);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(110, 42);
            this.buttonCancel.TabIndex = 0;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(315, 270);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(96, 42);
            this.buttonOK.TabIndex = 1;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "WidthP";
            // 
            // textBoxWidthP
            // 
            this.textBoxWidthP.Location = new System.Drawing.Point(12, 37);
            this.textBoxWidthP.Name = "textBoxWidthP";
            this.textBoxWidthP.Size = new System.Drawing.Size(341, 22);
            this.textBoxWidthP.TabIndex = 3;
            // 
            // textBoxParallelogramSide
            // 
            this.textBoxParallelogramSide.Location = new System.Drawing.Point(15, 134);
            this.textBoxParallelogramSide.Name = "textBoxParallelogramSide";
            this.textBoxParallelogramSide.Size = new System.Drawing.Size(341, 22);
            this.textBoxParallelogramSide.TabIndex = 4;
            // 
            // textBoxHeightP
            // 
            this.textBoxHeightP.Location = new System.Drawing.Point(15, 88);
            this.textBoxHeightP.Name = "textBoxHeightP";
            this.textBoxHeightP.Size = new System.Drawing.Size(341, 22);
            this.textBoxHeightP.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "HeightP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Parallelogram Side";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Color";
            // 
            // buttonColorParallelogram
            // 
            this.buttonColorParallelogram.Location = new System.Drawing.Point(15, 200);
            this.buttonColorParallelogram.Name = "buttonColorParallelogram";
            this.buttonColorParallelogram.Size = new System.Drawing.Size(134, 54);
            this.buttonColorParallelogram.TabIndex = 9;
            this.buttonColorParallelogram.UseVisualStyleBackColor = true;
            this.buttonColorParallelogram.Click += new System.EventHandler(this.buttonColorParallelogram_Click);
            // 
            // ParallelogramEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 324);
            this.Controls.Add(this.buttonColorParallelogram);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxHeightP);
            this.Controls.Add(this.textBoxParallelogramSide);
            this.Controls.Add(this.textBoxWidthP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ParallelogramEdit";
            this.Text = "ParallelogramEdit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxWidthP;
        private System.Windows.Forms.TextBox textBoxParallelogramSide;
        private System.Windows.Forms.TextBox textBoxHeightP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonColorParallelogram;
    }
}