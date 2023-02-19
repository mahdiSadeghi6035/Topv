﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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


        private void TabdilMohasebatRiazy_Click(object sender, EventArgs e)
        {
            var price = double.Parse(Price.Text.ToString());
            var month = double.Parse(Price.Text.ToString());
            var percent = double.Parse(Percent.Text.ToString());

            var command = new CalculateModel(price, month, percent);
            var cb = CB.SelectedItem;
            if(cb == null)
            {
                MessageBox.Show("لطفا یک روش را انتخاب کنید","خطا",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
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

        private void Clear_Click(object sender, EventArgs e)
        {
            Price.Text = "";
            Price.Text = "";
            Percent.Text = "";
            Result.Text = "";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
