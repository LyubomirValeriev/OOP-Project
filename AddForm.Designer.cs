
namespace Проект
{
    partial class AddForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioCircle = new System.Windows.Forms.RadioButton();
            this.radioRectangle = new System.Windows.Forms.RadioButton();
            this.radioTriangle = new System.Windows.Forms.RadioButton();
            this.radioSquare = new System.Windows.Forms.RadioButton();
            this.buttonChooseColor = new System.Windows.Forms.Button();
            this.labelChooseColor = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxForHeightOrRadius = new System.Windows.Forms.TextBox();
            this.textBoxForWidth = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.labelForHeightOrRadius = new System.Windows.Forms.Label();
            this.labelForWidth = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioCircle);
            this.groupBox1.Controls.Add(this.radioRectangle);
            this.groupBox1.Controls.Add(this.radioTriangle);
            this.groupBox1.Controls.Add(this.radioSquare);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(199, 161);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Shapes ";
            // 
            // radioCircle
            // 
            this.radioCircle.AutoSize = true;
            this.radioCircle.Location = new System.Drawing.Point(53, 124);
            this.radioCircle.Name = "radioCircle";
            this.radioCircle.Size = new System.Drawing.Size(51, 17);
            this.radioCircle.TabIndex = 7;
            this.radioCircle.TabStop = true;
            this.radioCircle.Text = "Circle";
            this.radioCircle.UseVisualStyleBackColor = true;
            this.radioCircle.CheckedChanged += new System.EventHandler(this.radioCircle_CheckedChanged);
            // 
            // radioRectangle
            // 
            this.radioRectangle.AutoSize = true;
            this.radioRectangle.Location = new System.Drawing.Point(53, 93);
            this.radioRectangle.Name = "radioRectangle";
            this.radioRectangle.Size = new System.Drawing.Size(74, 17);
            this.radioRectangle.TabIndex = 6;
            this.radioRectangle.TabStop = true;
            this.radioRectangle.Text = "Rectangle";
            this.radioRectangle.UseVisualStyleBackColor = true;
            this.radioRectangle.CheckedChanged += new System.EventHandler(this.radioRectangle_CheckedChanged);
            // 
            // radioTriangle
            // 
            this.radioTriangle.AutoSize = true;
            this.radioTriangle.Location = new System.Drawing.Point(53, 66);
            this.radioTriangle.Name = "radioTriangle";
            this.radioTriangle.Size = new System.Drawing.Size(63, 17);
            this.radioTriangle.TabIndex = 5;
            this.radioTriangle.TabStop = true;
            this.radioTriangle.Text = "Triangle";
            this.radioTriangle.UseVisualStyleBackColor = true;
            this.radioTriangle.CheckedChanged += new System.EventHandler(this.radioTriangle_CheckedChanged);
            // 
            // radioSquare
            // 
            this.radioSquare.AutoSize = true;
            this.radioSquare.Location = new System.Drawing.Point(53, 38);
            this.radioSquare.Name = "radioSquare";
            this.radioSquare.Size = new System.Drawing.Size(59, 17);
            this.radioSquare.TabIndex = 4;
            this.radioSquare.TabStop = true;
            this.radioSquare.Text = "Square";
            this.radioSquare.UseVisualStyleBackColor = true;
            this.radioSquare.CheckedChanged += new System.EventHandler(this.radioSquare_CheckedChanged);
            // 
            // buttonChooseColor
            // 
            this.buttonChooseColor.Location = new System.Drawing.Point(16, 226);
            this.buttonChooseColor.Name = "buttonChooseColor";
            this.buttonChooseColor.Size = new System.Drawing.Size(143, 43);
            this.buttonChooseColor.TabIndex = 1;
            this.buttonChooseColor.UseVisualStyleBackColor = true;
            this.buttonChooseColor.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // labelChooseColor
            // 
            this.labelChooseColor.AutoSize = true;
            this.labelChooseColor.Location = new System.Drawing.Point(9, 210);
            this.labelChooseColor.Name = "labelChooseColor";
            this.labelChooseColor.Size = new System.Drawing.Size(150, 13);
            this.labelChooseColor.TabIndex = 2;
            this.labelChooseColor.Text = "Choose the Color of the shape";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(485, 226);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 43);
            this.button2.TabIndex = 3;
            this.button2.Text = "OK";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxForHeightOrRadius
            // 
            this.textBoxForHeightOrRadius.Location = new System.Drawing.Point(313, 42);
            this.textBoxForHeightOrRadius.Name = "textBoxForHeightOrRadius";
            this.textBoxForHeightOrRadius.Size = new System.Drawing.Size(255, 20);
            this.textBoxForHeightOrRadius.TabIndex = 4;
            // 
            // textBoxForWidth
            // 
            this.textBoxForWidth.Location = new System.Drawing.Point(313, 98);
            this.textBoxForWidth.Name = "textBoxForWidth";
            this.textBoxForWidth.Size = new System.Drawing.Size(255, 20);
            this.textBoxForWidth.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(313, 152);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(255, 20);
            this.textBox3.TabIndex = 6;
            // 
            // labelForHeightOrRadius
            // 
            this.labelForHeightOrRadius.AutoSize = true;
            this.labelForHeightOrRadius.Location = new System.Drawing.Point(313, 23);
            this.labelForHeightOrRadius.Name = "labelForHeightOrRadius";
            this.labelForHeightOrRadius.Size = new System.Drawing.Size(119, 13);
            this.labelForHeightOrRadius.TabIndex = 7;
            this.labelForHeightOrRadius.Text = "labelForHeightOrRadius";
            // 
            // labelForWidth
            // 
            this.labelForWidth.AutoSize = true;
            this.labelForWidth.Location = new System.Drawing.Point(313, 82);
            this.labelForWidth.Name = "labelForWidth";
            this.labelForWidth.Size = new System.Drawing.Size(72, 13);
            this.labelForWidth.TabIndex = 8;
            this.labelForWidth.Text = "labelForWidth";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(313, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "label4";
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 292);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelForWidth);
            this.Controls.Add(this.labelForHeightOrRadius);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBoxForWidth);
            this.Controls.Add(this.textBoxForHeightOrRadius);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.labelChooseColor);
            this.Controls.Add(this.buttonChooseColor);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonChooseColor;
        private System.Windows.Forms.Label labelChooseColor;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBoxForHeightOrRadius;
        private System.Windows.Forms.TextBox textBoxForWidth;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label labelForHeightOrRadius;
        private System.Windows.Forms.Label labelForWidth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioSquare;
        private System.Windows.Forms.RadioButton radioTriangle;
        private System.Windows.Forms.RadioButton radioRectangle;
        private System.Windows.Forms.RadioButton radioCircle;
    }
}