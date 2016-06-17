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
    public partial class Form1 : Form
    {
        Double rezultat = 0;
        String znak = "";
        bool kliknato = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e) // site brojki
        {
            if (tbResults.Text == "0" || kliknato)
                tbResults.Clear();
            kliknato = false;
            Button btn = (Button)sender;
            if(btn.Text == ",") //za da ne se stavaat mnogu tochki 
            {
                if(!tbResults.Text.Contains(","))
                    tbResults.Text = tbResults.Text + btn.Text;
            }
            else
            tbResults.Text = tbResults.Text + btn.Text;
        }

        private void se_najbolje(object sender, EventArgs e) // site operacii
        {
            Button btn = (Button)sender;

            if(rezultat != 0)
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

        private void btnCE_Click(object sender, EventArgs e)
        {
            tbResults.Text = "0";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            tbResults.Text = "0";
            rezultat = 0;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int length = tbResults.TextLength - 1;
            string text = tbResults.Text;
            tbResults.Clear();
            for (int i = 0; i < length; i++)
                tbResults.Text = tbResults.Text + text[i];
        }

        private void btnEdnakvo_Click(object sender, EventArgs e)
        {
            switch(znak)
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
                default:
                    break;
            }
            rezultat = Double.Parse(tbResults.Text);
            lbPateka.Text = "";
        }

        private void kopchinja(object sender, KeyEventArgs e) // kopchinjata za numpad
        {
            if(e.KeyCode == Keys.NumPad0)
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

        private void cbLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbLista.SelectedItem == "Scientific")
            {
                this.Hide();
                Scientific sc = new Scientific();
                sc.Show();
            }
            
        }
    }
}
