﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp3
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        string strInput;
        double douOutput;


        private void txta_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = txta.Text;

            if (double.TryParse(strInput, out douOutput) == true)
            {
                txtb.Text = string.Format("{0:0.##########}", douOutput * 0.001);
                txtc.Text = string.Format("{0:0.##########}", douOutput * 0.000001);
                txtd.Text = string.Format("{0:0.##########}", douOutput * 0.000000001);
                txte.Text = string.Format("{0:0.##########}", douOutput * 0.000035274);
                txtf.Text = string.Format("{0:0.##########}", douOutput * 0.000002205);
            }
            else
            {
                txtInfo.Text = "請輸入數字";
                txta.Text = "";
            }
        }

        private void btnAllClear_Click_1(object sender, RoutedEventArgs e)
        {
            txta.Text = "";
            txtb.Text = "";
            txtc.Text = "";
            txtd.Text = "";
            txte.Text = "";
            txtf.Text = "";
        }

        private void txtb_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = txtb.Text;

            if (double.TryParse(strInput, out douOutput) == true)
            {
                txta.Text = string.Format("{0:0.##########}", douOutput * 1000);
                txtc.Text = string.Format("{0:0.##########}", douOutput * 0.001);
                txtd.Text = string.Format("{0:0.##########}", douOutput * 0.000001);
                txte.Text = string.Format("{0:0.##########}", douOutput * 0.035274);
                txtf.Text = string.Format("{0:0.##########}", douOutput * 0.002205);
            }
            else
            {
                txtInfo.Text = "請輸入數字";
                txtb.Text = "";
            }
        }

        private void txtc_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = txtc.Text;

            if (double.TryParse(strInput, out douOutput) == true)
            {
                txta.Text = string.Format("{0:0.###########}", douOutput * 1000000);
                txtb.Text = string.Format("{0:0.###########}", douOutput * 1000);
                txtd.Text = string.Format("{0:0.###########}", douOutput * 0.001);
                txte.Text = string.Format("{0:0.###########}", douOutput * 35.273962);
                txtf.Text = string.Format("{0:0.###########}", douOutput * 2.204623);
            }
            else
            {
                txtInfo.Text = "請輸入數字";
                txtc.Text = "";
            }
        }

        private void txtd_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = txtd.Text;

            if (double.TryParse(strInput, out douOutput) == true)
            {
                txta.Text = string.Format("{0:0.################}", douOutput * 10001000000000);
                txtb.Text = string.Format("{0:0.################}", douOutput * 1000000);
                txtc.Text = string.Format("{0:0.################}", douOutput * 1000);
                txte.Text = string.Format("{0:0.################}", douOutput * 35273.96195);
                txtf.Text = string.Format("{0:0.################}", douOutput * 2204.622622);
            }
            else
            {
                txtInfo.Text = "請輸入數字";
                txtd.Text = "";
            }
        }

        private void txte_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = txte.Text;

            if (double.TryParse(strInput, out douOutput) == true)
            {
                txta.Text = string.Format("{0:0.################}", douOutput * 28349.523125);
                txtb.Text = string.Format("{0:0.################}", douOutput * 28.349523);
                txtc.Text = string.Format("{0:0.################}", douOutput * 0.02835);
                txtd.Text = string.Format("{0:0.################}", douOutput * 0.000028);
                txtf.Text = string.Format("{0:0.################}", douOutput * 0.0625);
            }
            else
            {
                txtInfo.Text = "請輸入數字";
                txte.Text = "";
            }
        }

        private void txtf_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = txtf.Text;

            if (double.TryParse(strInput, out douOutput) == true)
            {
                txta.Text = string.Format("{0:0.################}", douOutput * 453592.37);
                txtb.Text = string.Format("{0:0.################}", douOutput * 453.59237);
                txtc.Text = string.Format("{0:0.################}", douOutput * 0.453592);
                txtd.Text = string.Format("{0:0.################}", douOutput * 0.000454);
                txte.Text = string.Format("{0:0.################}", douOutput * 16);
            }
            else
            {
                txtInfo.Text = "請輸入數字";
                txtf.Text = "";
            }
        }
    }
    
}
