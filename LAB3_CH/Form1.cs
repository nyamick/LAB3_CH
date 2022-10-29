namespace LAB3_CH
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var measureItems = new string[] {

            "м/с",
            "км/ч",
            "узлов",
            "Max",};
      
            cmdFirstType.DataSource = new List<string>(measureItems);
            cmdSecondType.DataSource = new List<string>(measureItems);
            cmdResultType.DataSource = new List<string>(measureItems);
        }

        private MeasureType GetMeasureType(ComboBox comboBox)
        {
            MeasureType measureType;
            switch (comboBox.Text)
            {
                case "м/с":
                    measureType = MeasureType.Ms;
                    break;
                case "км/ч":
                    measureType = MeasureType.KMh;
                    break;
                case "узлов":
                    measureType = MeasureType.Uz;
                    break;
                case "Max":
                    measureType = MeasureType.Max;
                    break;
                default:
                    measureType = MeasureType.Ms;
                    break;
            }
            return measureType;
        }

        private void Calculate()
        {
            try
            {

                var firstValue = double.Parse(txtFirst.Text);
                var secondValue = double.Parse(txtSecond.Text);

                MeasureType firstType = GetMeasureType(cmdFirstType);
                MeasureType secondType = GetMeasureType(cmdSecondType);
                MeasureType resultType = GetMeasureType(cmdResultType);


                var firstDistance = new DIstance(firstValue, firstType);
                var secondDistance = new DIstance(secondValue, secondType);

                DIstance sumDistance;
                switch (cmdOperation.Text)
                {
                    case "+":
                        
                        sumDistance = firstDistance + secondDistance;
                        break;
                    case "-":
                       
                        sumDistance = firstDistance - secondDistance;
                        break;
                    default:
                        
                        sumDistance = new DIstance(0, MeasureType.Ms);
                        break;
                }





                txtResult.Text = sumDistance.To(resultType).Verbose();
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

        private void cmdOperation_SelectedIndexChanged(object sender, EventArgs e)
        { 
            Calculate();
        }

        private void cmdFirstType_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void cmdSecondType_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void cmdResultType_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calculate();
        }
    }
}