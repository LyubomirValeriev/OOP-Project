using System;
using System.Drawing;
using System.Windows.Forms;

namespace Проект
{
    public partial class AddForm : Form
    {
        public void ChangeShape(Shape shape)
        {
            switch (shape.TypeShape)
            {
                case 0:
                    {
                        radioCircle.Checked = true;

                        radioRectangle.Enabled = false;
                        radioSquare.Enabled = false;
                        radioTriangle.Enabled = false;
                    }
                    break;
                case 1:
                    {
                        radioSquare.Checked = true;

                        radioRectangle.Enabled = false;
                        radioCircle.Enabled = false;
                        radioTriangle.Enabled = false;
                    }
                    break;
                case 2:
                    {
                        radioRectangle.Checked = true;

                        radioSquare.Enabled = false;
                        radioCircle.Enabled = false;
                        radioTriangle.Enabled = false;
                    }
                    break;
            }
        }
        public void RadioButtonsAllowed()
        {
            radioRectangle.Enabled = true;
            radioSquare.Enabled = true;
            radioTriangle.Enabled = true;
            radioCircle.Enabled = true;
        }
        public AddForm()
        {
            InitializeComponent();

        }
        private int _MyHeight;
        public int MyHeight
        {
            get => _MyHeight;
            set
            {
                if (value <= 0)
                    throw new InvalidValueException("Negative value not allowed!!");
                _MyHeight = value;
            }
        }
        private int _MyWidth;
        public int MyWidth
        {
            get => _MyWidth;
            set
            {
                if (value <= 0)
                    throw new InvalidValueException("Negative value not allowed!!");
         
                _MyWidth = value;
            }
        }
        public Color MyColor { get; set; }

        public bool ChooseSquare;
        public bool ChooseTriangle;
        public bool ChooseRectangle;
        public bool ChooseCircle;
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBoxForHeightOrRadius.Visible)
                if (string.IsNullOrEmpty(textBoxForHeightOrRadius.Text))
                {
                    MessageBox.Show("Моля въведете стойност "
                                   , "Опитай пак "
                                    , MessageBoxButtons.OKCancel
                                    , MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    try
                    {
                        MyHeight = int.Parse(textBoxForHeightOrRadius.Text);
                    }
                    catch (InvalidValueException )
                    {
                        MessageBox.Show($"Моля въведете коректна стойност  в полето {labelForHeightOrRadius.Name}  "
                                  , "Опитай пак "
                                   , MessageBoxButtons.OKCancel
                                   , MessageBoxIcon.Warning);
                        return;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Моля въведете число ! "
                                       , "Опитай пак "
                                        , MessageBoxButtons.OKCancel
                                              , MessageBoxIcon.Warning);
                        return; 
                    }
                    DialogResult = DialogResult.OK;
                }
            if (textBoxForWidth.Visible)
                if (string.IsNullOrEmpty(textBoxForWidth.Text))
                {
                    MessageBox.Show("Моля въведете стойност "
                                   , "Опитай пак "
                                    , MessageBoxButtons.OKCancel
                                    , MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    try
                    {
                        MyWidth = int.Parse(textBoxForWidth.Text);

                    }
                    catch (InvalidValueException)
                    {
                        MessageBox.Show($"Моля въведете коректна стойност  стойност в полето {labelForWidth.Name}  "
                                   , "Опитай пак "
                                    , MessageBoxButtons.OKCancel
                                    , MessageBoxIcon.Warning);
                        return;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Моля въведете число ! "
                                       , "Опитай пак "
                                        , MessageBoxButtons.OKCancel
                                              , MessageBoxIcon.Warning);
                        return;
                    }
                    DialogResult = DialogResult.OK;
                }
        }


        private void radioCircle_CheckedChanged(object sender, EventArgs e)
        {
            ChooseRectangle = false;
            ChooseSquare = false;
            ChooseTriangle = false;

            CheckedAndVisible();
            if (radioCircle.Checked
                && radioSquare.Checked == false
                && radioRectangle.Checked == false
                && radioTriangle.Checked == false)

            {
                labelForHeightOrRadius.Visible = true;
                textBoxForHeightOrRadius.Visible = !textBoxForHeightOrRadius.Visible;
                labelForHeightOrRadius.Text = "Radius";
                labelChooseColor.Visible = !labelChooseColor.Visible;
                buttonChooseColor.Visible = !buttonChooseColor.Visible;
                ChooseCircle = true;
            }
        }
        private void radioRectangle_CheckedChanged(object sender, EventArgs e)
        {
            ChooseCircle = false;
            ChooseSquare = false;
            ChooseTriangle = false;

            CheckedAndVisible();
            if (radioCircle.Checked == false
                && radioSquare.Checked == false
                && radioRectangle.Checked
                && radioTriangle.Checked == false)
            {
                textBoxForHeightOrRadius.Visible = !textBoxForHeightOrRadius.Visible;
                textBoxForWidth.Visible = !textBoxForWidth.Visible;
                labelForHeightOrRadius.Visible = !labelForHeightOrRadius.Visible;
                labelForWidth.Visible = !labelForWidth.Visible;
                buttonChooseColor.Visible = !buttonChooseColor.Visible;
                labelChooseColor.Visible = !labelChooseColor.Visible;
                labelForHeightOrRadius.Text = "Height";
                labelForWidth.Text = "Width";
                ChooseRectangle = true;
            }
        }
        private void radioTriangle_CheckedChanged(object sender, EventArgs e)
        {
            ChooseCircle = false;
            ChooseRectangle = false;
            ChooseSquare = false;
            CheckedAndVisible();
            if (radioCircle.Checked == false
                && radioSquare.Checked == false
                && radioRectangle.Checked == false
                && radioTriangle.Checked)
            {
                textBoxForWidth.Visible = true;
                labelForHeightOrRadius.Visible = true;
                labelForHeightOrRadius.Text = "Tedi";
            }
        }
        private void radioSquare_CheckedChanged(object sender, EventArgs e)
        {
            ChooseCircle = false;
            ChooseRectangle = false;
            ChooseTriangle = false;

            CheckedAndVisible();
            if (radioCircle.Checked == false
                && radioSquare.Checked
                && radioRectangle.Checked == false
                && radioTriangle.Checked == false)
            {
                textBoxForHeightOrRadius.Visible = !textBoxForHeightOrRadius.Visible;
                labelForHeightOrRadius.Visible = true;
                labelForHeightOrRadius.Text = "Height";
                labelChooseColor.Visible = !labelChooseColor.Visible;
                buttonChooseColor.Visible = !buttonChooseColor.Visible;
                ChooseSquare = true;
            }
        }
        private void CheckedAndVisible()
        {
            labelChooseColor.Visible = false;
            buttonChooseColor.Visible = false;
            buttonChooseColor.BackColor = Form.DefaultBackColor;

            labelForHeightOrRadius.Visible = false;
            labelForWidth.Visible = false;
            label4.Visible = false;
            textBoxForHeightOrRadius.Visible = false;
            textBoxForWidth.Visible = false;
            textBox3.Visible = false;
        }
        private void buttonColor_Click(object sender, EventArgs e)
        {
            var cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                MyColor = cd.Color;
                buttonChooseColor.BackColor = cd.Color;
            }
        }
    }
}
