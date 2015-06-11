namespace MyGraphics
{
    partial class Form1
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
            this.pnlPaint = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbLine = new System.Windows.Forms.RadioButton();
            this.rdbRectangle = new System.Windows.Forms.RadioButton();
            this.rdbEllipse = new System.Windows.Forms.RadioButton();
            this.rdbLozenge = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPaint
            // 
            this.pnlPaint.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPaint.Location = new System.Drawing.Point(147, 12);
            this.pnlPaint.Name = "pnlPaint";
            this.pnlPaint.Size = new System.Drawing.Size(701, 456);
            this.pnlPaint.TabIndex = 0;
            this.pnlPaint.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlPaint_MouseDown);
            this.pnlPaint.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlPaint_MouseMove);
            this.pnlPaint.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlPaint_MouseUp);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbLozenge);
            this.groupBox1.Controls.Add(this.rdbEllipse);
            this.groupBox1.Controls.Add(this.rdbRectangle);
            this.groupBox1.Controls.Add(this.rdbLine);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(113, 204);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Shape";
            // 
            // rdbLine
            // 
            this.rdbLine.AutoSize = true;
            this.rdbLine.Location = new System.Drawing.Point(16, 32);
            this.rdbLine.Name = "rdbLine";
            this.rdbLine.Size = new System.Drawing.Size(45, 17);
            this.rdbLine.TabIndex = 0;
            this.rdbLine.TabStop = true;
            this.rdbLine.Text = "Line";
            this.rdbLine.UseVisualStyleBackColor = true;
            this.rdbLine.CheckedChanged += new System.EventHandler(this.rdbLine_CheckedChanged);
            // 
            // rdbRectangle
            // 
            this.rdbRectangle.AutoSize = true;
            this.rdbRectangle.Location = new System.Drawing.Point(16, 67);
            this.rdbRectangle.Name = "rdbRectangle";
            this.rdbRectangle.Size = new System.Drawing.Size(74, 17);
            this.rdbRectangle.TabIndex = 1;
            this.rdbRectangle.TabStop = true;
            this.rdbRectangle.Text = "Rectangle";
            this.rdbRectangle.UseVisualStyleBackColor = true;
            this.rdbRectangle.CheckedChanged += new System.EventHandler(this.rdbRectangle_CheckedChanged);
            // 
            // rdbEllipse
            // 
            this.rdbEllipse.AutoSize = true;
            this.rdbEllipse.Location = new System.Drawing.Point(16, 108);
            this.rdbEllipse.Name = "rdbEllipse";
            this.rdbEllipse.Size = new System.Drawing.Size(55, 17);
            this.rdbEllipse.TabIndex = 2;
            this.rdbEllipse.TabStop = true;
            this.rdbEllipse.Text = "Ellipse";
            this.rdbEllipse.UseVisualStyleBackColor = true;
            this.rdbEllipse.CheckedChanged += new System.EventHandler(this.rdbEllipse_CheckedChanged);
            // 
            // rdbLozenge
            // 
            this.rdbLozenge.AutoSize = true;
            this.rdbLozenge.Location = new System.Drawing.Point(16, 146);
            this.rdbLozenge.Name = "rdbLozenge";
            this.rdbLozenge.Size = new System.Drawing.Size(66, 17);
            this.rdbLozenge.TabIndex = 3;
            this.rdbLozenge.TabStop = true;
            this.rdbLozenge.Text = "Lozenge";
            this.rdbLozenge.UseVisualStyleBackColor = true;
            this.rdbLozenge.CheckedChanged += new System.EventHandler(this.rdbLozenge_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 480);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnlPaint);
            this.Name = "Form1";
            this.Text = "My Graphics";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPaint;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbLozenge;
        private System.Windows.Forms.RadioButton rdbEllipse;
        private System.Windows.Forms.RadioButton rdbRectangle;
        private System.Windows.Forms.RadioButton rdbLine;
    }
}

