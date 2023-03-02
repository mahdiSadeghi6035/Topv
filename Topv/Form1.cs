using System;
using System.Windows.Forms;
using ValidationComponents;

namespace Topv
{
    public partial class Form1 : Form
    {
        ICalculate _calculate;
        public ResultModel result { get; set; }
        public Form1()
        {
            InitializeComponent();
            _calculate = new Calculate();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Space.Visible = true;
            label4.Visible = true;
        }
        private void Price_TextChanged_1(object sender, EventArgs e)
        {

            if (Price.Text != "")
            {
                double price;
                price = double.Parse(Price.Text, System.Globalization.NumberStyles.Currency);
                Price.Text = price.ToString("#,#");
                Price.SelectionStart = Price.TextLength;
            }

        }

        private void btn_Click(object sender, EventArgs e)
        {
            if (BaseValidator.IsFormValid(this.components))
            {
                var price = double.Parse(Price.Text);
                var month = double.Parse(Month.Text);
                var percent = double.Parse(Percent.Text);
                var space = double.Parse(Space.Text);

                var command = new CalculateModel(price, month, percent, space);
                var cb = CB.SelectedItem;


                switch (cb)
                {
                    case "روش قدیم":
                        {
                            result = _calculate.CalculateOld(command);
                            Result.Text = $"سود : {result.Benefit.ToMoney()} -- مبلغ قسط : {result.Paymenet.ToMoney()}";
                            break;
                        }
                    case "روش جدید":
                        {
                            result = _calculate.CalculateNew(command);
                            Result.Text = $"سود : {result.Benefit.ToMoney()} -- مبلغ قسط : {result.Paymenet.ToMoney()}";
                            break;
                        }
                    default:
                        break;
                }
            }
        }

        private void CB_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            var cb = CB.Text;
            if (cb == "روش قدیم")
            {
                Space.Visible = true;
                label4.Visible = true;
            }
            else if (cb == "روش جدید")
            {
                Space.Visible = false;
                label4.Visible = false;
            }

        }

        private void CB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void Price_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char(e);
        }

        private void Month_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char(e);
        }

        private void Percent_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char(e);
        }

        private void Space_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char(e);
        }
        public void Char(KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void Clear_Click_1(object sender, EventArgs e)
        {
            Price.Text = "";
            Month.Text = "";
            Percent.Text = "";
            Result.Text = "";
        }
    }
}
