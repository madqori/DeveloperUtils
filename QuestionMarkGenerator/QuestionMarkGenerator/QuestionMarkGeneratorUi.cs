using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuestionMarkGenerator
{
    public partial class QuestionMarkGeneratorUi : Form
    {
        public QuestionMarkGeneratorUi()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                int fromLine = TryParseInt(txtLineFrom.Text);
                int toLine = TryParseInt(txtLineTo.Text);
                ValidateData(fromLine, toLine);
                txtOutput.Text = GenerateParamQuestionMark(fromLine, toLine);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ValidateData(int fromLine, int toLine)
        {
            if (fromLine > toLine)
                throw new Exception("FromLine must be lower than toLine");
        }

        private string GenerateParamQuestionMark(int fromLine, int toLine)
        {
            string output = "(";
            int range = toLine - fromLine;
            for (int i = 0; i < range; i++)
            {
                output += "?";
                if (i + 1 == range)
                    output += ")";
                else
                    output += ",";
            }
            return output;
        }

        private int TryParseInt(string text)
        {
            try
            {
                int result = int.Parse(text);
                if (result == 0)
                    throw new Exception("Field must higher than zero");

                return int.Parse(text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                txtLineFrom.Text = "";
                txtLineTo.Text = "";
                txtOutput.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }



        private void txtLineFrom_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                ValidateTypeNumberOnly(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private static void ValidateTypeNumberOnly(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtLineTo_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                ValidateTypeNumberOnly(sender, e);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
