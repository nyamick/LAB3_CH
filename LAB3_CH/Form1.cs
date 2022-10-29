namespace LAB3_CH
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtFirst_TextChanged(object sender, EventArgs e)
        {
            try
            {
                
                var firstValue = double.Parse(txtFirst.Text);
                var secondValue = double.Parse(txtSecond.Text);
 
                var firstDistance = new DIstance(firstValue, MeasureType.Ms);
                var secondDistance = new DIstance(secondValue, MeasureType.Ms);

                
                var sumLength = firstDistance + secondDistance;

                
                txtResult.Text = sumLength.Verbose();
            }
            catch (FormatException)
            {
                
            }
        }
    }
}