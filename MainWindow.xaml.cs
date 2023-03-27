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
    }
}
