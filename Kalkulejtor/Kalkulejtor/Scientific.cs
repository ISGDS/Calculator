using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulejtor
{
    public partial class Scientific : Form
    {
        Double rezultat = 0;
        String znak = "";
        bool kliknato = false;
        public Scientific()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {
            if (tbResults.Text == "0" || kliknato)
                tbResults.Clear();
            kliknato = false;
            Button btn = (Button)sender;
            if (btn.Text == ",") //za da ne se stavaat mnogu tochki 
            {
                if (!tbResults.Text.Contains(","))
                    tbResults.Text = tbResults.Text + btn.Text;
            }
            else
                tbResults.Text = tbResults.Text + btn.Text;
        }

        private void se_najbolje(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (rezultat != 0)
            {
                btnEdnakvo.PerformClick(); // odma da se rachuna pri klikanje operacija
                znak = btn.Text;
                lbPateka.Text = rezultat + " " + znak;
                kliknato = true;
            }
            else
            {
                znak = btn.Text;
                rezultat = Double.Parse(tbResults.Text);
                lbPateka.Text = rezultat + " " + znak;
                kliknato = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int length = tbResults.TextLength - 1;
            string text = tbResults.Text;
            tbResults.Clear();
            for (int i = 0; i < length; i++)
                tbResults.Text = tbResults.Text + text[i];
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            tbResults.Text = "0";
            rezultat = 0;
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            tbResults.Text = "0";
        }

        private void btnEdnakvo_Click(object sender, EventArgs e)
        {
            switch (znak)
            {
                case "+":
                    tbResults.Text = (rezultat + Double.Parse(tbResults.Text)).ToString();
                    break;
                case "-":
                    tbResults.Text = (rezultat - Double.Parse(tbResults.Text)).ToString();
                    break;
                case "*":
                    tbResults.Text = (rezultat * Double.Parse(tbResults.Text)).ToString();
                    break;
                case "/":
                    tbResults.Text = (rezultat / Double.Parse(tbResults.Text)).ToString();
                    break;
                case "x^2":
                    tbResults.Text = (rezultat * rezultat).ToString();
                    break;
                case "x^y":
                    tbResults.Text = (rezultat / Double.Parse(tbResults.Text)).ToString();
                    break;
                case "sin":
                    tbResults.Text = (Math.Sin(rezultat)).ToString();
                    break;
                case "cos":
                    tbResults.Text = (Math.Cos(rezultat) ).ToString();
                    break;
                case "tan":
                    tbResults.Text = (Math.Tan(rezultat)).ToString();
                    break;
                case "√":
                    tbResults.Text = (Math.Sqrt(rezultat)).ToString();
                    break;
                case "10^x":
                    tbResults.Text = (Math.Pow(10,rezultat) ).ToString();
                    break;
                case "log":
                    tbResults.Text = (Math.Log(rezultat)).ToString();
                    break;
                case "Exp":
                    tbResults.Text = (Math.Exp(rezultat)).ToString();
                    break;
                case "Mod":
                    tbResults.Text = (rezultat % Double.Parse(tbResults.Text)).ToString();
                    break;

                default:
                    break;
            }
            rezultat = Double.Parse(tbResults.Text);
            lbPateka.Text = "";
        }

        private void kopchinja(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.NumPad0)
            {
                e.Handled = true;
                btn0.PerformClick();
            }
            if (e.KeyCode == Keys.NumPad1)
            {
                e.Handled = true;
                btn1.PerformClick();
            }
            if (e.KeyCode == Keys.NumPad2)
            {
                e.Handled = true;
                btn2.PerformClick();
            }
            if (e.KeyCode == Keys.NumPad3)
            {
                e.Handled = true;
                btn3.PerformClick();
            }
            if (e.KeyCode == Keys.NumPad4)
            {
                e.Handled = true;
                btn4.PerformClick();
            }
            if (e.KeyCode == Keys.NumPad5)
            {
                e.Handled = true;
                btn5.PerformClick();
            }
            if (e.KeyCode == Keys.NumPad6)
            {
                e.Handled = true;
                btn6.PerformClick();
            }
            if (e.KeyCode == Keys.NumPad7)
            {
                e.Handled = true;
                btn7.PerformClick();
            }
            if (e.KeyCode == Keys.NumPad8)
            {
                e.Handled = true;
                btn8.PerformClick();
            }
            if (e.KeyCode == Keys.NumPad9)
            {
                e.Handled = true;
                btn9.PerformClick();
            }
            if (e.KeyCode == Keys.Return)
            {
                e.Handled = true;
                btnEdnakvo.PerformClick();
            }
            if (e.KeyCode == Keys.Add)
            {
                e.Handled = true;
                btnPlus.PerformClick();
            }
            if (e.KeyCode == Keys.Multiply)
            {
                e.Handled = true;
                btnMnozhenje.PerformClick();
            }
            if (e.KeyCode == Keys.Divide)
            {
                e.Handled = true;
                btnDelenje.PerformClick();
            }
            if (e.KeyCode == Keys.Subtract)
            {
                e.Handled = true;
                btnMinus.PerformClick();
            }
            if (e.KeyCode == Keys.Decimal)
            {
                e.Handled = true;
                btnTochka.PerformClick();
            }
            if (e.KeyCode == Keys.Delete)
            {
                e.Handled = true;
                btnC.PerformClick();
            }
            if (e.KeyCode == Keys.End)
            {
                e.Handled = true;
                btnCE.PerformClick();
            }
            if (e.KeyCode == Keys.Back)
            {
                e.Handled = true;
                btnDelete.PerformClick();
            }
        }

        private void cb1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cb1.SelectedItem == "Normal")
            {
                this.Hide();
                Form1 form = new Form1();
                form.Show();
            }
        }

      
    }
}
