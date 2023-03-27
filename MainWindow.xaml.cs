using System;
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

        private void caculateAnswer(int _kind, double _value)
        {
            if (_kind != 0)
                txta.Text = string.Format("{0:0.##########}", _value);
            if (_kind != 1)
                txtb.Text = string.Format("{0:0.##########}", _value * 0.001);
            if (_kind != 2)
                txtc.Text = string.Format("{0:0.##########}", _value * 0.000001);
            if (_kind != 3)
                txtd.Text = string.Format("{0:0.##########}", _value * 0.000000001);
            if (_kind != 4)
                txte.Text = string.Format("{0:0.##########}", _value * 0.000035);
            if (_kind != 5)
                txtf.Text = string.Format("{0:0.##########}", _value * 0.000002);
        }

        private void txta_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = txta.Text;

            if (double.TryParse(strInput, out douOutput) == true)
            {
                caculateAnswer(0, douOutput);
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
                caculateAnswer(1, douOutput * 1000);
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
                caculateAnswer(2, douOutput * 1000000);
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
                caculateAnswer(3, douOutput * 1000000000);
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
                caculateAnswer(4, douOutput * 350000);
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
                caculateAnswer(5, douOutput * 200000);
            }
            else
            {
                txtInfo.Text = "請輸入數字";
                txtf.Text = "";
            }
        }
    }
    
}
