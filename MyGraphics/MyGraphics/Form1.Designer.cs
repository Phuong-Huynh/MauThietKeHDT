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
            this.rdbLozenge = new System.Windows.Forms.RadioButton();
            this.rdbEllipse = new System.Windows.Forms.RadioButton();
            this.rdbRectangle = new System.Windows.Forms.RadioButton();
            this.rdbLine = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbPNG = new System.Windows.Forms.RadioButton();
            this.rdbBitMap = new System.Windows.Forms.RadioButton();
            this.rdbJpeg = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdbCairo = new System.Windows.Forms.RadioButton();
            this.rdbGDI = new System.Windows.Forms.RadioButton();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNewDiagram = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
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
            this.groupBox1.Location = new System.Drawing.Point(18, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(113, 160);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Shape";
            // 
            // rdbLozenge
            // 
            this.rdbLozenge.AutoSize = true;
            this.rdbLozenge.Location = new System.Drawing.Point(16, 122);
            this.rdbLozenge.Name = "rdbLozenge";
            this.rdbLozenge.Size = new System.Drawing.Size(66, 17);
            this.rdbLozenge.TabIndex = 3;
            this.rdbLozenge.TabStop = true;
            this.rdbLozenge.Text = "Lozenge";
            this.rdbLozenge.UseVisualStyleBackColor = true;
            this.rdbLozenge.CheckedChanged += new System.EventHandler(this.rdbLozenge_CheckedChanged);
            // 
            // rdbEllipse
            // 
            this.rdbEllipse.AutoSize = true;
            this.rdbEllipse.Location = new System.Drawing.Point(16, 89);
            this.rdbEllipse.Name = "rdbEllipse";
            this.rdbEllipse.Size = new System.Drawing.Size(55, 17);
            this.rdbEllipse.TabIndex = 2;
            this.rdbEllipse.TabStop = true;
            this.rdbEllipse.Text = "Ellipse";
            this.rdbEllipse.UseVisualStyleBackColor = true;
            this.rdbEllipse.CheckedChanged += new System.EventHandler(this.rdbEllipse_CheckedChanged);
            // 
            // rdbRectangle
            // 
            this.rdbRectangle.AutoSize = true;
            this.rdbRectangle.Location = new System.Drawing.Point(16, 57);
            this.rdbRectangle.Name = "rdbRectangle";
            this.rdbRectangle.Size = new System.Drawing.Size(74, 17);
            this.rdbRectangle.TabIndex = 1;
            this.rdbRectangle.TabStop = true;
            this.rdbRectangle.Text = "Rectangle";
            this.rdbRectangle.UseVisualStyleBackColor = true;
            this.rdbRectangle.CheckedChanged += new System.EventHandler(this.rdbRectangle_CheckedChanged);
            // 
            // rdbLine
            // 
            this.rdbLine.AutoSize = true;
            this.rdbLine.Location = new System.Drawing.Point(16, 26);
            this.rdbLine.Name = "rdbLine";
            this.rdbLine.Size = new System.Drawing.Size(45, 17);
            this.rdbLine.TabIndex = 0;
            this.rdbLine.TabStop = true;
            this.rdbLine.Text = "Line";
            this.rdbLine.UseVisualStyleBackColor = true;
            this.rdbLine.CheckedChanged += new System.EventHandler(this.rdbLine_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Controls.Add(this.rdbPNG);
            this.groupBox2.Controls.Add(this.rdbBitMap);
            this.groupBox2.Controls.Add(this.rdbJpeg);
            this.groupBox2.Location = new System.Drawing.Point(18, 270);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(113, 160);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Format";
            // 
            // rdbPNG
            // 
            this.rdbPNG.AutoSize = true;
            this.rdbPNG.Location = new System.Drawing.Point(16, 89);
            this.rdbPNG.Name = "rdbPNG";
            this.rdbPNG.Size = new System.Drawing.Size(48, 17);
            this.rdbPNG.TabIndex = 2;
            this.rdbPNG.TabStop = true;
            this.rdbPNG.Text = "PNG";
            this.rdbPNG.UseVisualStyleBackColor = true;
            // 
            // rdbBitMap
            // 
            this.rdbBitMap.AutoSize = true;
            this.rdbBitMap.Location = new System.Drawing.Point(16, 57);
            this.rdbBitMap.Name = "rdbBitMap";
            this.rdbBitMap.Size = new System.Drawing.Size(58, 17);
            this.rdbBitMap.TabIndex = 1;
            this.rdbBitMap.TabStop = true;
            this.rdbBitMap.Text = "BitMap";
            this.rdbBitMap.UseVisualStyleBackColor = true;
            // 
            // rdbJpeg
            // 
            this.rdbJpeg.AutoSize = true;
            this.rdbJpeg.Location = new System.Drawing.Point(16, 26);
            this.rdbJpeg.Name = "rdbJpeg";
            this.rdbJpeg.Size = new System.Drawing.Size(48, 17);
            this.rdbJpeg.TabIndex = 0;
            this.rdbJpeg.TabStop = true;
            this.rdbJpeg.Text = "Jpeg";
            this.rdbJpeg.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdbCairo);
            this.groupBox3.Controls.Add(this.rdbGDI);
            this.groupBox3.Location = new System.Drawing.Point(18, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(113, 74);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Graphiccs";
            // 
            // rdbCairo
            // 
            this.rdbCairo.AutoSize = true;
            this.rdbCairo.Location = new System.Drawing.Point(16, 46);
            this.rdbCairo.Name = "rdbCairo";
            this.rdbCairo.Size = new System.Drawing.Size(49, 17);
            this.rdbCairo.TabIndex = 1;
            this.rdbCairo.TabStop = true;
            this.rdbCairo.Text = "Cairo";
            this.rdbCairo.UseVisualStyleBackColor = true;
            // 
            // rdbGDI
            // 
            this.rdbGDI.AutoSize = true;
            this.rdbGDI.Location = new System.Drawing.Point(16, 19);
            this.rdbGDI.Name = "rdbGDI";
            this.rdbGDI.Size = new System.Drawing.Size(50, 17);
            this.rdbGDI.TabIndex = 0;
            this.rdbGDI.TabStop = true;
            this.rdbGDI.Text = "GDI+";
            this.rdbGDI.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(17, 120);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(64, 27);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnNewDiagram
            // 
            this.btnNewDiagram.Location = new System.Drawing.Point(20, 441);
            this.btnNewDiagram.Name = "btnNewDiagram";
            this.btnNewDiagram.Size = new System.Drawing.Size(111, 27);
            this.btnNewDiagram.TabIndex = 4;
            this.btnNewDiagram.Text = "New Diagram";
            this.btnNewDiagram.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 480);
            this.Controls.Add(this.btnNewDiagram);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnlPaint);
            this.Name = "Form1";
            this.Text = "My Graphics";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPaint;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbLozenge;
        private System.Windows.Forms.RadioButton rdbEllipse;
        private System.Windows.Forms.RadioButton rdbRectangle;
        private System.Windows.Forms.RadioButton rdbLine;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.RadioButton rdbPNG;
        private System.Windows.Forms.RadioButton rdbBitMap;
        private System.Windows.Forms.RadioButton rdbJpeg;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdbCairo;
        private System.Windows.Forms.RadioButton rdbGDI;
        private System.Windows.Forms.Button btnNewDiagram;
    }
}

