using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExceptionsAndDelegates
{
    public partial class Form1 : Form
    {
        //public delegate void ReturnResult(string text);
        Action<string> result;
        //private ReturnResult result; 
        Func<double, double> operation1;
        Func<double, double, double> operation2;

        public Form1()
        {
            InitializeComponent();
        }

        private void chbxShowDialog_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxShowDialog.Checked)
            {
                result += Output.ShowDialogBox;
                btnGo.Enabled = true;
            }
            else
            {
                result -= Output.ShowDialogBox;
            }

            if (!chbxShowDialog.Checked & !chbxSaveToFile.Checked)
            {
                btnGo.Enabled = false;
            }
        }

        private void chbxSaveToFile_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxSaveToFile.Checked)
            {
                result += Output.SaveToFile;
                btnGo.Enabled = true;
            }
            else
            {
                result -= Output.SaveToFile;
            }

            if (!chbxShowDialog.Checked & !chbxSaveToFile.Checked)
            {
                btnGo.Enabled = false;
            }
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            try
            {
                RestOfTheProgram.FunctionWith1Param(operation1, Double.Parse(textBoxDef1.Text));
                RestOfTheProgram.FunctionWith2Params(operation2, Double.Parse(textBoxDef1.Text), Double.Parse(textBoxDef2.Text));
            }
            catch (Exception ex)
            {

            }

            //string result0 = "Result: 0";
            //result(result0);
        }

        private void btnOneArgument_CheckedChanged(object sender, EventArgs e)
        {
            if (btnOneArgument.Checked)
            {
                btnTwoArguments.Checked = false;
                textBoxDef2.Hide();// = false;
                textBoxDef1.Show();// = true;
                comboBoxDef.Items.Clear();
                comboBoxDef.Items.Add("sqrt");
                comboBoxDef.Items.Add("factorial");
            }
        }

        private void btnTwoArguments_CheckedChanged(object sender, EventArgs e)
        {
            if (btnTwoArguments.Checked)
            {
                btnOneArgument.Checked = false;
                textBoxDef1.Show();// = true;
                textBoxDef2.Show();// = true;
                comboBoxDef.Items.Clear();
                comboBoxDef.Items.Add("+");
                comboBoxDef.Items.Add("-");
                comboBoxDef.Items.Add("/");
                comboBoxDef.Items.Add("*");
            }
        }

        private void comboBoxDef_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxDef.Text == "sqrt")
            {
                operation1 = (x) => Math.Sqrt(x);
            }
            else if (comboBoxDef.Text == "factorial")
            {
                operation1 = (x) => x <= 1 ? 1 : x * operation1(x - 1);
            }
            else if (comboBoxDef.Text == "+")
            {
                operation2 = (x, y) => x+y;
            }
            else if (comboBoxDef.Text == "-")
            {
                operation2 = (x, y) => x - y;
            }
            else if (comboBoxDef.Text == "/")
            {
                operation2 = (x, y) => x / y;
            }
            else if (comboBoxDef.Text == "*")
            {
                operation2 = (x, y) => x * y;
            }
        }
    }
}
