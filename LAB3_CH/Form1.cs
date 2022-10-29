namespace LAB3_CH
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var measureItems = new string[] {

            "�/�",
            "��/�",
            "�����",
            "Max",};
       

            // ����������� ������ �������� � ������� ����������
            cmdFirstType.DataSource = new List<string>(measureItems);
            cmdSecondType.DataSource = new List<string>(measureItems);
            cmdResultType.DataSource = new List<string>(measureItems);
        }
        private void Calculate()
        {
            try
            {

                var firstValue = double.Parse(txtFirst.Text);
                var secondValue = double.Parse(txtSecond.Text);

                var firstDistance = new DIstance(firstValue, MeasureType.Ms);
                var secondDistance = new DIstance(secondValue, MeasureType.Ms);

                DIstance sumDistance;
                switch (cmdOperation.Text)
                {
                    case "+":
                        // ���� ������ �������, �� ����������
                        sumDistance = firstDistance + secondDistance;
                        break;
                    case "-":
                        // ���� �����, �� ��������
                        sumDistance = firstDistance - secondDistance;
                        break;
                    default:
                        // � ���� ���-�� ������, �� ������ 0 �������,
                        // ����� ������������, �� ���� ������� ����� �� �����������
                        sumDistance = new DIstance(0, MeasureType.Ms);
                        break;
                }





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

        private void cmdOperation_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calculate();
        }
    }
}