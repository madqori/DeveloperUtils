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
        private string selectedType = "";
        public QuestionMarkGeneratorUi()
        {
            InitializeComponent();
            InitObject();
            HideAndShowPanel();
        }

        private void HideAndShowPanel()
        {
            pageLineCode.Show();
            pageSplitByComma.Show();
            if (selectedType.ToUpper() == Type.LINE_CODE.ToUpper())
                pageSplitByComma.Hide();
            else if (selectedType.ToUpper() == Type.SPLIT_BY_COMMA.ToUpper())
                pageLineCode.Hide();
        }

        private void InitObject()
        {
            cboType.Items.Add(Type.LINE_CODE);
            cboType.Items.Add(Type.SPLIT_BY_COMMA);
            cboType.SelectedIndex = 0;
        }

        private static class Type
        {
            public const string LINE_CODE = "Line Code";
            public const string SPLIT_BY_COMMA = "Split by Comma";
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                string type = cboType.SelectedItem.ToString();

                if (type.ToUpper() == Type.LINE_CODE.ToUpper())
                {
                    int fromLine = TryParseInt(txtLineFrom.Text);
                    int toLine = TryParseInt(txtLineTo.Text);
                    int totalQuestionmark = toLine - fromLine + 1;
                    
                    ValidateData(fromLine, toLine);
                    txtOutput.Text = GenerateParamQuestionMark(totalQuestionmark);

                }
                else if (type.ToUpper() == Type.SPLIT_BY_COMMA.ToUpper())
                {
                    int totalQuestionMark = txtSplitByComma.Text.Split(',').Count();
                    string szClassDataName = txtClassData.Text;

                    if (string.IsNullOrEmpty(txtClassData.Text))
                        txtOutput.Text = GenerateParamQuestionMark(totalQuestionMark);
                    else
                        txtOutput.Text = GenerateParamQuestionMarkWithClassData(szClassDataName, totalQuestionMark);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private string GenerateParamQuestionMarkWithClassData(string szClassDataName, int totalQuestionMark)
        {
            List<string> listField = txtSplitByComma.Text.Split(',').ToList();

            string output = "VALUES (";
            for (int i = 0; i < totalQuestionMark; i++)
            {
                output += "?";
                if (i + 1 == totalQuestionMark)
                    output += ")\";";
                else
                    output += ",";
            }
            foreach (var field in listField)
            {
                output += " \n cmd.Parameters.AddWithValue(\""+field.Trim()+"\"," + szClassDataName + "." + field.Trim() + ");";
            }

            return output;
        }

        private void ValidateData(int fromLine, int toLine)
        {
            if (fromLine > toLine)
                throw new Exception("FromLine must be lower than toLine");
        }

        private string GenerateParamQuestionMark(int totalQuestionMark)
        {
            string output = "(";
            for (int i = 0; i < totalQuestionMark; i++)
            {
                output += "?";
                if (i + 1 == totalQuestionMark)
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
                txtSplitByComma.Text = "";
                txtClassData.Text = "";
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cboType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ComboBox cmb = (ComboBox)sender;
                object selectedItem = cmb.SelectedItem;
                selectedType = selectedItem.ToString();
                HideAndShowPanel();
                ClearUI();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ClearUI()
        {
            txtLineFrom.Text = "";
            txtLineTo.Text = "";
            txtSplitByComma.Text = "";
            txtOutput.Text = "";
        }
    }
}
