namespace LAB3_CH
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Calculate()
        {
            try
            {

                var firstValue = double.Parse(txtFirst.Text);
                var secondValue = double.Parse(txtSecond.Text);

                var firstDistance = new DIstance(firstValue, MeasureType.Ms);
                var secondDistance = new DIstance(secondValue, MeasureType.Ms);


                var sumDistance = firstDistance + secondDistance;


                txtResult.Text = sumDistance.Verbose();
            }
            catch (FormatException)
            {

            }
        }

        private void txtFirst_TextChanged(object sender, EventArgs e)
        {
            Calculate();      
        }

        private void txtSecond_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }
    }
}