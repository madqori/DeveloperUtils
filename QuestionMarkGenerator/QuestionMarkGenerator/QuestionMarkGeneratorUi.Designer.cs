using System.Drawing;
using System.Windows.Forms;

namespace QuestionMarkGenerator
{
    partial class QuestionMarkGeneratorUi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtOutput = new System.Windows.Forms.RichTextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.Panel_LineCode = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLineTo = new System.Windows.Forms.TextBox();
            this.txtLineFrom = new System.Windows.Forms.TextBox();
            this.Panel_SplitByComma = new System.Windows.Forms.Panel();
            this.lblColumn = new System.Windows.Forms.Label();
            this.txtSplitByComma = new System.Windows.Forms.RichTextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.pageLineCode = new System.Windows.Forms.TabPage();
            this.pageSplitByComma = new System.Windows.Forms.TabPage();
            this.Panel_LineCode.SuspendLayout();
            this.Panel_SplitByComma.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.pageLineCode.SuspendLayout();
            this.pageSplitByComma.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(15, 76);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(322, 108);
            this.txtOutput.TabIndex = 4;
            this.txtOutput.Text = "";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(15, 2);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 5;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(96, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // cboType
            // 
            this.cboType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboType.FormattingEnabled = true;
            this.cboType.Location = new System.Drawing.Point(237, 2);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(100, 21);
            this.cboType.TabIndex = 7;
            this.cboType.SelectedIndexChanged += new System.EventHandler(this.cboType_SelectedIndexChanged);
            // 
            // Panel_LineCode
            // 
            this.Panel_LineCode.Controls.Add(this.label2);
            this.Panel_LineCode.Controls.Add(this.label1);
            this.Panel_LineCode.Controls.Add(this.txtLineTo);
            this.Panel_LineCode.Controls.Add(this.txtLineFrom);
            this.Panel_LineCode.Location = new System.Drawing.Point(3, 2);
            this.Panel_LineCode.Name = "Panel_LineCode";
            this.Panel_LineCode.Size = new System.Drawing.Size(322, 31);
            this.Panel_LineCode.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "To Line";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "From Line";
            // 
            // txtLineTo
            // 
            this.txtLineTo.Location = new System.Drawing.Point(219, 5);
            this.txtLineTo.Name = "txtLineTo";
            this.txtLineTo.Size = new System.Drawing.Size(100, 20);
            this.txtLineTo.TabIndex = 5;
            // 
            // txtLineFrom
            // 
            this.txtLineFrom.Location = new System.Drawing.Point(65, 5);
            this.txtLineFrom.Name = "txtLineFrom";
            this.txtLineFrom.Size = new System.Drawing.Size(100, 20);
            this.txtLineFrom.TabIndex = 4;
            // 
            // Panel_SplitByComma
            // 
            this.Panel_SplitByComma.Controls.Add(this.lblColumn);
            this.Panel_SplitByComma.Controls.Add(this.txtSplitByComma);
            this.Panel_SplitByComma.Location = new System.Drawing.Point(3, 4);
            this.Panel_SplitByComma.Name = "Panel_SplitByComma";
            this.Panel_SplitByComma.Size = new System.Drawing.Size(320, 31);
            this.Panel_SplitByComma.TabIndex = 8;
            // 
            // lblColumn
            // 
            this.lblColumn.AutoSize = true;
            this.lblColumn.Location = new System.Drawing.Point(3, 8);
            this.lblColumn.Name = "lblColumn";
            this.lblColumn.Size = new System.Drawing.Size(42, 13);
            this.lblColumn.TabIndex = 1;
            this.lblColumn.Text = "Column";
            // 
            // txtSplitByComma
            // 
            this.txtSplitByComma.Location = new System.Drawing.Point(48, 5);
            this.txtSplitByComma.Name = "txtSplitByComma";
            this.txtSplitByComma.Size = new System.Drawing.Size(265, 20);
            this.txtSplitByComma.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.pageLineCode);
            this.tabControl1.Controls.Add(this.pageSplitByComma);
            this.tabControl1.ImeMode = System.Windows.Forms.ImeMode.Close;
            this.tabControl1.ItemSize = new System.Drawing.Size(0, 1);
            this.tabControl1.Location = new System.Drawing.Point(11, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(337, 44);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 2;
            // 
            // pageLineCode
            // 
            this.pageLineCode.Controls.Add(this.Panel_LineCode);
            this.pageLineCode.Location = new System.Drawing.Point(4, 5);
            this.pageLineCode.Name = "pageLineCode";
            this.pageLineCode.Padding = new System.Windows.Forms.Padding(3);
            this.pageLineCode.Size = new System.Drawing.Size(329, 35);
            this.pageLineCode.TabIndex = 0;
            this.pageLineCode.Text = "1";
            this.pageLineCode.UseVisualStyleBackColor = true;
            // 
            // pageSplitByComma
            // 
            this.pageSplitByComma.Controls.Add(this.Panel_SplitByComma);
            this.pageSplitByComma.Location = new System.Drawing.Point(4, 5);
            this.pageSplitByComma.Name = "pageSplitByComma";
            this.pageSplitByComma.Padding = new System.Windows.Forms.Padding(3);
            this.pageSplitByComma.Size = new System.Drawing.Size(329, 35);
            this.pageSplitByComma.TabIndex = 1;
            this.pageSplitByComma.Text = "tabPage2";
            this.pageSplitByComma.UseVisualStyleBackColor = true;
            // 
            // QuestionMarkGeneratorUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 196);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.cboType);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.txtOutput);
            this.Name = "QuestionMarkGeneratorUi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Question Mark Generator";
            this.Panel_LineCode.ResumeLayout(false);
            this.Panel_LineCode.PerformLayout();
            this.Panel_SplitByComma.ResumeLayout(false);
            this.Panel_SplitByComma.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.pageLineCode.ResumeLayout(false);
            this.pageSplitByComma.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox txtOutput;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.Panel Panel_LineCode;
        private System.Windows.Forms.Panel Panel_SplitByComma;
        private System.Windows.Forms.Label lblColumn;
        private System.Windows.Forms.RichTextBox txtSplitByComma;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLineTo;
        private System.Windows.Forms.TextBox txtLineFrom;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage pageLineCode;
        private System.Windows.Forms.TabPage pageSplitByComma;
    }
}

