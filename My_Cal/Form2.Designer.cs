using System;
using System.Drawing;
using System.Windows.Forms;
using SourceGrid;
using System.Data.SQLite;
using SourceGrid.Selection;
using System.Collections;
using System.ComponentModel;
namespace Project
{
    partial class Form2
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        public void InitializeComponent()
        {

           
            this.tabPage7Frez = new System.Windows.Forms.TabPage();
            this.textBox9Frez = new System.Windows.Forms.TextBox();
            this.textBox8Frez = new System.Windows.Forms.TextBox();
            this.textBox7Frez = new System.Windows.Forms.TextBox();
            this.textBox6Frez = new System.Windows.Forms.TextBox();
            this.textBox5Frez = new System.Windows.Forms.TextBox();
            this.textBox4Frez = new System.Windows.Forms.TextBox();
            this.comboBox1Frez = new System.Windows.Forms.ComboBox();
            this.tabPage6Frez = new System.Windows.Forms.TabPage();
            this.grid5Frez = new SourceGrid.Grid();
            this.tabPage5Frez = new System.Windows.Forms.TabPage();
            this.grid4Frez = new SourceGrid.Grid();
            this.tabPage4Frez = new System.Windows.Forms.TabPage();
            this.grid3Frez = new SourceGrid.Grid();
            this.tabPage3Frez = new System.Windows.Forms.TabPage();
            this.grid2Frez = new SourceGrid.Grid();
            this.tabPage2Frez = new System.Windows.Forms.TabPage();
            this.grid1Frez = new SourceGrid.Grid();
            this.tabPage1Frez = new System.Windows.Forms.TabPage();
            this.button2Frez = new System.Windows.Forms.Button();
            this.label6Frez = new System.Windows.Forms.Label();
            this.label5Frez = new System.Windows.Forms.Label();
            this.label4Frez = new System.Windows.Forms.Label();
            this.label3Frez = new System.Windows.Forms.Label();
            this.label2Frez = new System.Windows.Forms.Label();
            this.label1Frez = new System.Windows.Forms.Label();
            this.textBox3Frez = new System.Windows.Forms.TextBox();
            this.textBox2Frez = new System.Windows.Forms.TextBox();
            this.textBox1Frez = new System.Windows.Forms.TextBox();
            this.tabControl1Frez = new System.Windows.Forms.TabControl();
            this.button1 = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.textBox10Frez = new System.Windows.Forms.TextBox();
            this.label7Frez = new System.Windows.Forms.Label();
            this.tabPage7Frez.SuspendLayout();
            this.tabPage6Frez.SuspendLayout();
            this.tabPage5Frez.SuspendLayout();
            this.tabPage4Frez.SuspendLayout();
            this.tabPage3Frez.SuspendLayout();
            this.tabPage2Frez.SuspendLayout();
            this.tabPage1Frez.SuspendLayout();
            this.tabControl1Frez.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage7
            // 
            this.tabPage7Frez.Controls.Add(this.textBox9Frez);
            this.tabPage7Frez.Controls.Add(this.textBox8Frez);
            this.tabPage7Frez.Controls.Add(this.textBox7Frez);
            this.tabPage7Frez.Controls.Add(this.textBox6Frez);
            this.tabPage7Frez.Controls.Add(this.textBox5Frez);
            this.tabPage7Frez.Controls.Add(this.textBox4Frez);
            this.tabPage7Frez.Location = new System.Drawing.Point(4, 22);
            this.tabPage7Frez.Name = "tabPage7";
            this.tabPage7Frez.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7Frez.Size = new System.Drawing.Size(647, 539);
            this.tabPage7Frez.TabIndex = 6;
            this.tabPage7Frez.Text = "Результат";
            this.tabPage7Frez.UseVisualStyleBackColor = true;
            this.tabPage7Frez.Enter += new System.EventHandler(this.tabPage7_Enter);
            // 
            // textBox9
            // 
            this.textBox9Frez.Location = new System.Drawing.Point(7, 188);
            this.textBox9Frez.Name = "textBox9";
            this.textBox9Frez.Size = new System.Drawing.Size(100, 20);
            this.textBox9Frez.TabIndex = 6;
            // 
            // textBox8
            // 
            this.textBox8Frez.Location = new System.Drawing.Point(7, 162);
            this.textBox8Frez.Name = "textBox8";
            this.textBox8Frez.Size = new System.Drawing.Size(100, 20);
            this.textBox8Frez.TabIndex = 5;
            // 
            // textBox7
            // 
            this.textBox7Frez.Location = new System.Drawing.Point(7, 135);
            this.textBox7Frez.Name = "textBox7";
            this.textBox7Frez.Size = new System.Drawing.Size(100, 20);
            this.textBox7Frez.TabIndex = 4;
            // 
            // textBox6
            // 
            this.textBox6Frez.Location = new System.Drawing.Point(7, 108);
            this.textBox6Frez.Name = "textBox6";
            this.textBox6Frez.Size = new System.Drawing.Size(100, 20);
            this.textBox6Frez.TabIndex = 3;
            // 
            // textBox5
            // 
            this.textBox5Frez.Location = new System.Drawing.Point(7, 81);
            this.textBox5Frez.Name = "textBox5";
            this.textBox5Frez.Size = new System.Drawing.Size(100, 20);
            this.textBox5Frez.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4Frez.Location = new System.Drawing.Point(7, 54);
            this.textBox4Frez.Name = "textBox4";
            this.textBox4Frez.Size = new System.Drawing.Size(100, 20);
            this.textBox4Frez.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1Frez.FormattingEnabled = true;
            this.comboBox1Frez.Items.AddRange(new object[] {
            "20",
            "30",
            "40",
            "60",
            "90",
            "120"});
            this.comboBox1Frez.Location = new System.Drawing.Point(388, 49);
            this.comboBox1Frez.Name = "comboBox1";
            this.comboBox1Frez.Size = new System.Drawing.Size(121, 21);
            this.comboBox1Frez.TabIndex = 0;
            this.comboBox1Frez.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tabPage6
            // 
            this.tabPage6Frez.Controls.Add(this.grid5Frez);
            this.tabPage6Frez.Location = new System.Drawing.Point(4, 22);
            this.tabPage6Frez.Name = "tabPage6";
            this.tabPage6Frez.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6Frez.Size = new System.Drawing.Size(681, 539);
            this.tabPage6Frez.TabIndex = 5;
            this.tabPage6Frez.Text = "Эмпирические коэффициенты силы резания";
            this.tabPage6Frez.UseVisualStyleBackColor = true;
            // 
            // grid5
            // 
            this.grid5Frez.EnableSort = true;
            this.grid5Frez.Location = new System.Drawing.Point(7, 7);
            this.grid5Frez.Name = "grid5";
            this.grid5Frez.OptimizeMode = SourceGrid.CellOptimizeMode.ForRows;
            this.grid5Frez.SelectionMode = SourceGrid.GridSelectionMode.Cell;
            this.grid5Frez.Size = new System.Drawing.Size(743, 502);
            this.grid5Frez.TabIndex = 0;
            this.grid5Frez.TabStop = true;
            this.grid5Frez.ToolTipText = "";
            // 
            // tabPage5
            // 
            this.tabPage5Frez.Controls.Add(this.grid4Frez);
            this.tabPage5Frez.Location = new System.Drawing.Point(4, 22);
            this.tabPage5Frez.Name = "tabPage5";
            this.tabPage5Frez.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5Frez.Size = new System.Drawing.Size(681, 539);
            this.tabPage5Frez.TabIndex = 4;
            this.tabPage5Frez.Text = "Поправочный коэффициент силы резания";
            this.tabPage5Frez.UseVisualStyleBackColor = true;
            // 
            // grid4
            // 
            this.grid4Frez.EnableSort = true;
            this.grid4Frez.Location = new System.Drawing.Point(4, 7);
            this.grid4Frez.Name = "grid4";
            this.grid4Frez.OptimizeMode = SourceGrid.CellOptimizeMode.ForRows;
            this.grid4Frez.SelectionMode = SourceGrid.GridSelectionMode.Cell;
            this.grid4Frez.Size = new System.Drawing.Size(746, 502);
            this.grid4Frez.TabIndex = 0;
            this.grid4Frez.TabStop = true;
            this.grid4Frez.ToolTipText = "";
            // 
            // tabPage4
            // 
            this.tabPage4Frez.Controls.Add(this.grid3Frez);
            this.tabPage4Frez.Location = new System.Drawing.Point(4, 22);
            this.tabPage4Frez.Name = "tabPage4";
            this.tabPage4Frez.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4Frez.Size = new System.Drawing.Size(681, 539);
            this.tabPage4Frez.TabIndex = 3;
            this.tabPage4Frez.Text = "Поправочный коэффициент скорости резания";
            this.tabPage4Frez.UseVisualStyleBackColor = true;
            // 
            // grid3
            // 
            this.grid3Frez.EnableSort = true;
            this.grid3Frez.Location = new System.Drawing.Point(6, 6);
            this.grid3Frez.Name = "grid3";
            this.grid3Frez.OptimizeMode = SourceGrid.CellOptimizeMode.ForRows;
            this.grid3Frez.SelectionMode = SourceGrid.GridSelectionMode.Cell;
            this.grid3Frez.Size = new System.Drawing.Size(744, 503);
            this.grid3Frez.TabIndex = 0;
            this.grid3Frez.TabStop = true;
            this.grid3Frez.ToolTipText = "";
            // 
            // tabPage3
            // 
            this.tabPage3Frez.Controls.Add(this.grid2Frez);
            this.tabPage3Frez.Location = new System.Drawing.Point(4, 22);
            this.tabPage3Frez.Name = "tabPage3";
            this.tabPage3Frez.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3Frez.Size = new System.Drawing.Size(681, 539);
            this.tabPage3Frez.TabIndex = 2;
            this.tabPage3Frez.Text = "Количетсво зубьев фрезы";
            this.tabPage3Frez.UseVisualStyleBackColor = true;
            // 
            // grid2
            // 
            this.grid2Frez.EnableSort = true;
            this.grid2Frez.Location = new System.Drawing.Point(7, 7);
            this.grid2Frez.Name = "grid2";
            this.grid2Frez.OptimizeMode = SourceGrid.CellOptimizeMode.ForRows;
            this.grid2Frez.SelectionMode = SourceGrid.GridSelectionMode.Cell;
            this.grid2Frez.Size = new System.Drawing.Size(743, 502);
            this.grid2Frez.TabIndex = 0;
            this.grid2Frez.TabStop = true;
            this.grid2Frez.ToolTipText = "";
            // 
            // tabPage2
            // 
            this.tabPage2Frez.Controls.Add(this.grid1Frez);
            this.tabPage2Frez.Location = new System.Drawing.Point(4, 22);
            this.tabPage2Frez.Name = "tabPage2";
            this.tabPage2Frez.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2Frez.Size = new System.Drawing.Size(681, 539);
            this.tabPage2Frez.TabIndex = 1;
            this.tabPage2Frez.Text = "Эмперические параметры скорости резания";
            this.tabPage2Frez.UseVisualStyleBackColor = true;
            // 
            // grid1
            // 
            this.grid1Frez.EnableSort = true;
            this.grid1Frez.Location = new System.Drawing.Point(7, 7);
            this.grid1Frez.Name = "grid1";
            this.grid1Frez.OptimizeMode = SourceGrid.CellOptimizeMode.ForRows;
            this.grid1Frez.SelectionMode = SourceGrid.GridSelectionMode.Cell;
            this.grid1Frez.Size = new System.Drawing.Size(743, 502);
            this.grid1Frez.TabIndex = 0;
            this.grid1Frez.TabStop = true;
            this.grid1Frez.ToolTipText = "";
            // 
            // tabPage1
            // 
            this.tabPage1Frez.Controls.Add(this.label7Frez);
            this.tabPage1Frez.Controls.Add(this.textBox10Frez);
            this.tabPage1Frez.Controls.Add(this.button2Frez);
            this.tabPage1Frez.Controls.Add(this.comboBox1Frez);
            this.tabPage1Frez.Controls.Add(this.label6Frez);
            this.tabPage1Frez.Controls.Add(this.label5Frez);
            this.tabPage1Frez.Controls.Add(this.label4Frez);
            this.tabPage1Frez.Controls.Add(this.label3Frez);
            this.tabPage1Frez.Controls.Add(this.label2Frez);
            this.tabPage1Frez.Controls.Add(this.label1Frez);
            this.tabPage1Frez.Controls.Add(this.textBox3Frez);
            this.tabPage1Frez.Controls.Add(this.textBox2Frez);
            this.tabPage1Frez.Controls.Add(this.textBox1Frez);
            this.tabPage1Frez.Location = new System.Drawing.Point(4, 22);
            this.tabPage1Frez.Name = "tabPage1";
            this.tabPage1Frez.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1Frez.Size = new System.Drawing.Size(647, 539);
            this.tabPage1Frez.TabIndex = 0;
            this.tabPage1Frez.Text = "Ввод основных параметров";
            this.tabPage1Frez.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2Frez.Location = new System.Drawing.Point(7, 273);
            this.button2Frez.Name = "button2";
            this.button2Frez.Size = new System.Drawing.Size(75, 23);
            this.button2Frez.TabIndex = 9;
            this.button2Frez.Text = "Ввод данных";
            this.button2Frez.UseVisualStyleBackColor = true;
            this.button2Frez.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6Frez.AutoSize = true;
            this.label6Frez.Location = new System.Drawing.Point(147, 167);
            this.label6Frez.Name = "label6";
            this.label6Frez.Size = new System.Drawing.Size(150, 26);
            this.label6Frez.TabIndex = 8;
            this.label6Frez.Text = "0,2...0,1 при Ra 20...2,5\r\n0,08...0,04 при Ra 1,25...0,32";
            // 
            // label5
            // 
            this.label5Frez.AutoSize = true;
            this.label5Frez.Location = new System.Drawing.Point(10, 148);
            this.label5Frez.Name = "label5";
            this.label5Frez.Size = new System.Drawing.Size(94, 13);
            this.label5Frez.TabIndex = 7;
            this.label5Frez.Text = "Подача на зуб Sz";
            // 
            // label4
            // 
            this.label4Frez.AutoSize = true;
            this.label4Frez.Location = new System.Drawing.Point(10, 209);
            this.label4Frez.Name = "label4";
            this.label4Frez.Size = new System.Drawing.Size(107, 13);
            this.label4Frez.TabIndex = 6;
            this.label4Frez.Text = "Диаметр фрезы (D)";
            // 
            // label3
            // 
            this.label3Frez.AutoSize = true;
            this.label3Frez.Location = new System.Drawing.Point(10, 86);
            this.label3Frez.Name = "label3";
            this.label3Frez.Size = new System.Drawing.Size(99, 13);
            this.label3Frez.TabIndex = 5;
            this.label3Frez.Text = "Ширина фрезы (B)";
            // 
            // label2
            // 
            this.label2Frez.AutoSize = true;
            this.label2Frez.Location = new System.Drawing.Point(147, 43);
            this.label2Frez.Name = "label2";
            this.label2Frez.Size = new System.Drawing.Size(120, 26);
            this.label2Frez.TabIndex = 4;
            this.label2Frez.Text = "3...20 при Ra 20...2,5\r\n1...3 при Ra 1,25...0,32";
            // 
            // label1
            // 
            this.label1Frez.AutoSize = true;
            this.label1Frez.Location = new System.Drawing.Point(10, 21);
            this.label1Frez.Name = "label1";
            this.label1Frez.Size = new System.Drawing.Size(111, 13);
            this.label1Frez.TabIndex = 3;
            this.label1Frez.Text = "Глубина резания ( t )";
            // 
            // textBox3
            // 
            this.textBox3Frez.Location = new System.Drawing.Point(7, 173);
            this.textBox3Frez.Name = "textBox3";
            this.textBox3Frez.Size = new System.Drawing.Size(100, 20);
            this.textBox3Frez.TabIndex = 2;
            this.textBox3Frez.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox3_KeyUp);
            // 
            // textBox2
            // 
            this.textBox2Frez.Location = new System.Drawing.Point(7, 111);
            this.textBox2Frez.Name = "textBox2";
            this.textBox2Frez.Size = new System.Drawing.Size(100, 20);
            this.textBox2Frez.TabIndex = 1;
            this.textBox2Frez.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyUp);
            // 
            // textBox1
            // 
            this.textBox1Frez.Location = new System.Drawing.Point(7, 49);
            this.textBox1Frez.Name = "textBox1";
            this.textBox1Frez.Size = new System.Drawing.Size(100, 20);
            this.textBox1Frez.TabIndex = 0;
            this.textBox1Frez.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // tabControl1
            // 
            this.tabControl1Frez.Controls.Add(this.tabPage1Frez);
            this.tabControl1Frez.Controls.Add(this.tabPage2Frez);
            this.tabControl1Frez.Controls.Add(this.tabPage3Frez);
            this.tabControl1Frez.Controls.Add(this.tabPage4Frez);
            this.tabControl1Frez.Controls.Add(this.tabPage5Frez);
            this.tabControl1Frez.Controls.Add(this.tabPage6Frez);
            this.tabControl1Frez.Controls.Add(this.tabPage7Frez);
            this.tabControl1Frez.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1Frez.Location = new System.Drawing.Point(0, 0);
            this.tabControl1Frez.Name = "tabControl1";
            this.tabControl1Frez.SelectedIndex = 0;
            this.tabControl1Frez.Size = new System.Drawing.Size(655, 565);
            this.tabControl1Frez.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 243);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 35);
            this.button1.TabIndex = 9;
            this.button1.Text = "Добавить \r\nоперацию";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1Frez);
            this.splitContainer1.Size = new System.Drawing.Size(788, 565);
            this.splitContainer1.SplitterDistance = 129;
            this.splitContainer1.TabIndex = 10;
            // 
            // textBox10
            // 
            this.textBox10Frez.Location = new System.Drawing.Point(7, 236);
            this.textBox10Frez.Name = "textBox10";
            this.textBox10Frez.Size = new System.Drawing.Size(100, 20);
            this.textBox10Frez.TabIndex = 10;
            this.textBox10Frez.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox10_KeyUp);
            // 
            // label7
            // 
            this.label7Frez.AutoSize = true;
            this.label7Frez.Location = new System.Drawing.Point(388, 20);
            this.label7Frez.Name = "label7";
            this.label7Frez.Size = new System.Drawing.Size(153, 13);
            this.label7Frez.TabIndex = 11;
            this.label7Frez.Text = "Период стойкости фрезы (Т)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 565);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabPage7Frez.ResumeLayout(false);
            this.tabPage7Frez.PerformLayout();
            this.tabPage6Frez.ResumeLayout(false);
            this.tabPage5Frez.ResumeLayout(false);
            this.tabPage4Frez.ResumeLayout(false);
            this.tabPage3Frez.ResumeLayout(false);
            this.tabPage2Frez.ResumeLayout(false);
            this.tabPage1Frez.ResumeLayout(false);
            this.tabPage1Frez.PerformLayout();
            this.tabControl1Frez.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage7Frez;
        private System.Windows.Forms.TabPage tabPage6Frez;
        private SourceGrid.Grid grid5Frez;
        private System.Windows.Forms.TabPage tabPage5Frez;
        private SourceGrid.Grid grid4Frez;
        private System.Windows.Forms.TabPage tabPage4Frez;
        private SourceGrid.Grid grid3Frez;
        private System.Windows.Forms.TabPage tabPage3Frez;
        private SourceGrid.Grid grid2Frez;
        private System.Windows.Forms.TabPage tabPage2Frez;
        private SourceGrid.Grid grid1Frez;
        private System.Windows.Forms.TabPage tabPage1Frez;
        private System.Windows.Forms.Label label6Frez;
        private System.Windows.Forms.Label label5Frez;
        private System.Windows.Forms.Label label4Frez;
        private System.Windows.Forms.Label label3Frez;
        private System.Windows.Forms.Label label2Frez;
        private System.Windows.Forms.Label label1Frez;
        private System.Windows.Forms.TextBox textBox3Frez;
        private System.Windows.Forms.TextBox textBox2Frez;
        private System.Windows.Forms.TextBox textBox1Frez;
        private System.Windows.Forms.TabControl tabControl1Frez;
        public SQLiteConnection sqlite_conn;
        public SQLiteCommand sqlite_cmd;
        public SQLiteDataReader sqlite_datareader;
        public MyCellTracking cellpointer;
        public MyRowTrecking rowpointer;
        public SourceGrid.Cells.Controllers.CustomEvents clickEvent;
        public int i;
        public Step_frez s1;
        private ArrayList AList;
        private Button button1;
        private SplitContainer splitContainer1;
        private ComboBox comboBox1Frez;
        private Button button2Frez;
        private TextBox textBox8Frez;
        private TextBox textBox7Frez;
        private TextBox textBox6Frez;
        private TextBox textBox5Frez;
        private TextBox textBox4Frez;
        private TextBox textBox9Frez;
        private TextBox textBox10Frez;
        private Label label7Frez;

    }
}

