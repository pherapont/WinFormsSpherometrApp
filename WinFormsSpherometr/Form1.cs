using System;
using System.Windows.Forms;
using SpheroCalculatorLib;

namespace WinFormsSpherometr
{
    public partial class Form1 : Form, ISpherometrUserInput
    {
        private RadioButton selectedRing;

        private UserInputData userParametrs = new UserInputData();

        public Form1()
        {
            InitializeComponent();
        }
        public UserInputData GetUserParametrs()
        {
            userParametrs.Surface = GetSurfaceType();
            userParametrs.Calculation = GetCalculationType();
            userParametrs.Spherometr = GetSpherometrType();
            userParametrs.RingNumber = GetRingNumber();
            userParametrs.UserMeasureData = GetUserMeasure();
            return userParametrs;
        }

        public void CalculateAndPrint()
        {
            double calculationResult = Controller.GetAndCalculate(userParametrs);
            PrintMessage(calculationResult.ToString());
        }
        private TypeOfSurface GetSurfaceType()
        {
            return surfTypeConcave.Checked == true ? TypeOfSurface.Concave : TypeOfSurface.Convex;
        }

        private TypeOfCalculation GetCalculationType()
        {
            return CalcTypeButRadus.Checked == true ? TypeOfCalculation.Radius : TypeOfCalculation.Height;
        }

        private TypeOfSpherometr GetSpherometrType()
        {
            return SpherometrBig.Checked == true ? TypeOfSpherometr.Big : TypeOfSpherometr.Small;
        }

        private int GetRingNumber()
        {
            string name = selectedRing.Name;
            return Convert.ToInt32(name.Substring(name.Length - 1));
        }

        private double GetUserMeasure()
        {
            return double.Parse(measure.Text);
        }

        private void PrintMessage(string str)
        {
            result.Text = $"Результат: {str}";
        }

        void Form1_Load(object sender, EventArgs e)
        {
            measure.Enabled = false;
        }
        void SpherometrBig_Enter(object sender, EventArgs e)
        {
            foreach (RadioButton button in BigRingsGroup.Controls)
            {
                button.Enabled = true;
            }
            foreach (RadioButton button in SmallRingsGroup.Controls)
            {
                button.Enabled = false;
                button.Checked = false;
            }
        }

        void SpherometrSmall_Enter(object sender, EventArgs e)
        {
            foreach (RadioButton button in SmallRingsGroup.Controls)
            {
                button.Enabled = true;
            }
            foreach (RadioButton button in BigRingsGroup.Controls)
            {
                button.Enabled = false;
                button.Checked = false;
            }
        }
        void measure_TextChanged(object sender, EventArgs e)
        {

        }

        void CalcTypeButHeight_Enter(object sender, EventArgs e)
        {
            measureGroup.Text = "Радиус";
            measure.Enabled = true;
        }

        void CalcTypeButRadus_Enter(object sender, EventArgs e)
        {
            measureGroup.Text = "Данные сферометра";
            measure.Enabled = true;
        }

        private void Ring_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb == null)
            {
                MessageBox.Show("Sender is not a radiobutton");
                return;
            }
            if (rb.Checked)
            {
                selectedRing = rb;
            }
        }

        public void calculateButton_Click(object sender, EventArgs e)
        {
            GetUserParametrs();
            CalculateAndPrint();
        }
    }
}
