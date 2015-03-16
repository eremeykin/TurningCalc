using System;
using System.Drawing;
using System.Windows.Forms;
using SourceGrid;
using System.Data.SQLite;
using SourceGrid.Selection;
using System.Collections;
using System.ComponentModel;
//using System.
namespace My_Cal
{
    partial class Form1
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
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage1Mill = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1Mill = new System.Windows.Forms.Label();
            this.button2Mill = new System.Windows.Forms.Button();
            this.label7Mill = new System.Windows.Forms.Label();
            this.textBox1Mill = new System.Windows.Forms.TextBox();
            this.comboBox1Mill = new System.Windows.Forms.ComboBox();
            this.textBox10Mill = new System.Windows.Forms.TextBox();
            this.textBox2Mill = new System.Windows.Forms.TextBox();
            this.label6Mill = new System.Windows.Forms.Label();
            this.textBox3Mill = new System.Windows.Forms.TextBox();
            this.label2Mill = new System.Windows.Forms.Label();
            this.label3Mill = new System.Windows.Forms.Label();
            this.label4Mill = new System.Windows.Forms.Label();
            this.label5Mill = new System.Windows.Forms.Label();
            this.tabPage2Mill = new System.Windows.Forms.TabPage();
            this.grid1Mill = new SourceGrid.Grid();
            this.tabPage3Mill = new System.Windows.Forms.TabPage();
            this.grid2Mill = new SourceGrid.Grid();
            this.tabPage4Mill = new System.Windows.Forms.TabPage();
            this.grid3Mill = new SourceGrid.Grid();
            this.tabPage5Mill = new System.Windows.Forms.TabPage();
            this.grid4Mill = new SourceGrid.Grid();
            this.tabPage6Mill = new System.Windows.Forms.TabPage();
            this.grid5Mill = new SourceGrid.Grid();
            this.tabPage7Mill = new System.Windows.Forms.TabPage();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.grid20 = new SourceGrid.Grid();
            this.grid21 = new SourceGrid.Grid();
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.tabPage12 = new System.Windows.Forms.TabPage();
            this.grid9 = new SourceGrid.Grid();
            this.tabPage13 = new System.Windows.Forms.TabPage();
            this.grid10 = new SourceGrid.Grid();
            this.tabPage14 = new System.Windows.Forms.TabPage();
            this.grid11 = new SourceGrid.Grid();
            this.tabPage15 = new System.Windows.Forms.TabPage();
            this.grid12 = new SourceGrid.Grid();
            this.tabPage16 = new System.Windows.Forms.TabPage();
            this.grid13 = new SourceGrid.Grid();
            this.tabPage17 = new System.Windows.Forms.TabPage();
            this.grid14 = new SourceGrid.Grid();
            this.tabPage18 = new System.Windows.Forms.TabPage();
            this.grid15 = new SourceGrid.Grid();
            this.tabPage20 = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.grid16 = new SourceGrid.Grid();
            this.grid17 = new SourceGrid.Grid();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.grid1 = new SourceGrid.Grid();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.grid2 = new SourceGrid.Grid();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.grid3 = new SourceGrid.Grid();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.grid4 = new SourceGrid.Grid();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.grid5 = new SourceGrid.Grid();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.grid6 = new SourceGrid.Grid();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.grid7 = new SourceGrid.Grid();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.grid8 = new SourceGrid.Grid();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.grid18 = new SourceGrid.Grid();
            this.grid19 = new SourceGrid.Grid();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tabPage10 = new System.Windows.Forms.TabPage();
            this.tabPage11 = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menu1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.переходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьТокарныйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьФрезерныйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьСверлилдныйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage1Mill.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage2Mill.SuspendLayout();
            this.tabPage3Mill.SuspendLayout();
            this.tabPage4Mill.SuspendLayout();
            this.tabPage5Mill.SuspendLayout();
            this.tabPage6Mill.SuspendLayout();
            this.tabPage7Mill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            this.tabControl3.SuspendLayout();
            this.tabPage12.SuspendLayout();
            this.tabPage13.SuspendLayout();
            this.tabPage14.SuspendLayout();
            this.tabPage15.SuspendLayout();
            this.tabPage16.SuspendLayout();
            this.tabPage17.SuspendLayout();
            this.tabPage18.SuspendLayout();
            this.tabPage20.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.tabPage8.SuspendLayout();
            this.tabPage9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);
            this.splitContainer1.Panel1MinSize = 150;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl2);
            this.splitContainer1.Panel2.Controls.Add(this.tabControl3);
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Panel2MinSize = 350;
            this.splitContainer1.Size = new System.Drawing.Size(1044, 621);
            this.splitContainer1.SplitterDistance = 194;
            this.splitContainer1.TabIndex = 3;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.HideSelection = false;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Margin = new System.Windows.Forms.Padding(2);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(194, 621);
            this.treeView1.TabIndex = 2;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage1Mill);
            this.tabControl2.Controls.Add(this.tabPage2Mill);
            this.tabControl2.Controls.Add(this.tabPage3Mill);
            this.tabControl2.Controls.Add(this.tabPage4Mill);
            this.tabControl2.Controls.Add(this.tabPage5Mill);
            this.tabControl2.Controls.Add(this.tabPage6Mill);
            this.tabControl2.Controls.Add(this.tabPage7Mill);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(846, 621);
            this.tabControl2.TabIndex = 1;
            // 
            // tabPage1Mill
            // 
            this.tabPage1Mill.Controls.Add(this.groupBox3);
            this.tabPage1Mill.Location = new System.Drawing.Point(4, 22);
            this.tabPage1Mill.Name = "tabPage1Mill";
            this.tabPage1Mill.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1Mill.Size = new System.Drawing.Size(838, 595);
            this.tabPage1Mill.TabIndex = 0;
            this.tabPage1Mill.Text = "Ввод основных параметров";
            this.tabPage1Mill.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1Mill);
            this.groupBox3.Controls.Add(this.button2Mill);
            this.groupBox3.Controls.Add(this.label7Mill);
            this.groupBox3.Controls.Add(this.textBox1Mill);
            this.groupBox3.Controls.Add(this.comboBox1Mill);
            this.groupBox3.Controls.Add(this.textBox10Mill);
            this.groupBox3.Controls.Add(this.textBox2Mill);
            this.groupBox3.Controls.Add(this.label6Mill);
            this.groupBox3.Controls.Add(this.textBox3Mill);
            this.groupBox3.Controls.Add(this.label2Mill);
            this.groupBox3.Controls.Add(this.label3Mill);
            this.groupBox3.Controls.Add(this.label4Mill);
            this.groupBox3.Controls.Add(this.label5Mill);
            this.groupBox3.Location = new System.Drawing.Point(6, 8);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(634, 277);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Основные параметры";
            // 
            // label1Mill
            // 
            this.label1Mill.AutoSize = true;
            this.label1Mill.Location = new System.Drawing.Point(23, 24);
            this.label1Mill.Name = "label1Mill";
            this.label1Mill.Size = new System.Drawing.Size(111, 13);
            this.label1Mill.TabIndex = 3;
            this.label1Mill.Text = "Глубина резания ( t )";
            // 
            // button2Mill
            // 
            this.button2Mill.Location = new System.Drawing.Point(491, 226);
            this.button2Mill.Name = "button2Mill";
            this.button2Mill.Size = new System.Drawing.Size(81, 30);
            this.button2Mill.TabIndex = 9;
            this.button2Mill.Text = "Ввод данных";
            this.button2Mill.UseVisualStyleBackColor = true;
            this.button2Mill.Click += new System.EventHandler(this.button2Mill_Click);
            // 
            // label7Mill
            // 
            this.label7Mill.AutoSize = true;
            this.label7Mill.Location = new System.Drawing.Point(396, 24);
            this.label7Mill.Name = "label7Mill";
            this.label7Mill.Size = new System.Drawing.Size(153, 13);
            this.label7Mill.TabIndex = 11;
            this.label7Mill.Text = "Период стойкости фрезы (Т)";
            // 
            // textBox1Mill
            // 
            this.textBox1Mill.Location = new System.Drawing.Point(17, 49);
            this.textBox1Mill.Name = "textBox1Mill";
            this.textBox1Mill.Size = new System.Drawing.Size(100, 20);
            this.textBox1Mill.TabIndex = 0;
            this.textBox1Mill.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyUp);
            // 
            // comboBox1Mill
            // 
            this.comboBox1Mill.FormattingEnabled = true;
            this.comboBox1Mill.Items.AddRange(new object[] {
            "20",
            "30",
            "40",
            "60",
            "90",
            "120"});
            this.comboBox1Mill.Location = new System.Drawing.Point(399, 48);
            this.comboBox1Mill.Name = "comboBox1Mill";
            this.comboBox1Mill.Size = new System.Drawing.Size(121, 21);
            this.comboBox1Mill.TabIndex = 0;
            this.comboBox1Mill.SelectedIndexChanged += new System.EventHandler(this.comboBox1Mill_SelectedIndexChanged);
            // 
            // textBox10Mill
            // 
            this.textBox10Mill.Location = new System.Drawing.Point(17, 236);
            this.textBox10Mill.Name = "textBox10Mill";
            this.textBox10Mill.Size = new System.Drawing.Size(100, 20);
            this.textBox10Mill.TabIndex = 10;
            this.textBox10Mill.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyUp);
            // 
            // textBox2Mill
            // 
            this.textBox2Mill.Location = new System.Drawing.Point(17, 111);
            this.textBox2Mill.Name = "textBox2Mill";
            this.textBox2Mill.Size = new System.Drawing.Size(100, 20);
            this.textBox2Mill.TabIndex = 1;
            this.textBox2Mill.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyUp);
            // 
            // label6Mill
            // 
            this.label6Mill.AutoSize = true;
            this.label6Mill.Location = new System.Drawing.Point(135, 167);
            this.label6Mill.Name = "label6Mill";
            this.label6Mill.Size = new System.Drawing.Size(150, 26);
            this.label6Mill.TabIndex = 8;
            this.label6Mill.Text = "0,2...0,1 при Ra 20...2,5\r\n0,08...0,04 при Ra 1,25...0,32";
            // 
            // textBox3Mill
            // 
            this.textBox3Mill.Location = new System.Drawing.Point(17, 173);
            this.textBox3Mill.Name = "textBox3Mill";
            this.textBox3Mill.Size = new System.Drawing.Size(100, 20);
            this.textBox3Mill.TabIndex = 2;
            this.textBox3Mill.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyUp);
            // 
            // label2Mill
            // 
            this.label2Mill.AutoSize = true;
            this.label2Mill.Location = new System.Drawing.Point(135, 43);
            this.label2Mill.Name = "label2Mill";
            this.label2Mill.Size = new System.Drawing.Size(120, 26);
            this.label2Mill.TabIndex = 4;
            this.label2Mill.Text = "3...20 при Ra 20...2,5\r\n1...3 при Ra 1,25...0,32";
            // 
            // label3Mill
            // 
            this.label3Mill.AutoSize = true;
            this.label3Mill.Location = new System.Drawing.Point(23, 89);
            this.label3Mill.Name = "label3Mill";
            this.label3Mill.Size = new System.Drawing.Size(99, 13);
            this.label3Mill.TabIndex = 5;
            this.label3Mill.Text = "Ширина фрезы (B)";
            // 
            // label4Mill
            // 
            this.label4Mill.AutoSize = true;
            this.label4Mill.Location = new System.Drawing.Point(23, 212);
            this.label4Mill.Name = "label4Mill";
            this.label4Mill.Size = new System.Drawing.Size(107, 13);
            this.label4Mill.TabIndex = 6;
            this.label4Mill.Text = "Диаметр фрезы (D)";
            // 
            // label5Mill
            // 
            this.label5Mill.AutoSize = true;
            this.label5Mill.Location = new System.Drawing.Point(23, 151);
            this.label5Mill.Name = "label5Mill";
            this.label5Mill.Size = new System.Drawing.Size(94, 13);
            this.label5Mill.TabIndex = 7;
            this.label5Mill.Text = "Подача на зуб Sz";
            // 
            // tabPage2Mill
            // 
            this.tabPage2Mill.Controls.Add(this.grid1Mill);
            this.tabPage2Mill.Location = new System.Drawing.Point(4, 22);
            this.tabPage2Mill.Name = "tabPage2Mill";
            this.tabPage2Mill.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2Mill.Size = new System.Drawing.Size(838, 595);
            this.tabPage2Mill.TabIndex = 1;
            this.tabPage2Mill.Text = "Эмперические параметры скорости резания";
            this.tabPage2Mill.UseVisualStyleBackColor = true;
            // 
            // grid1Mill
            // 
            this.grid1Mill.AutoSize = true;
            this.grid1Mill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid1Mill.EnableSort = true;
            this.grid1Mill.Location = new System.Drawing.Point(3, 3);
            this.grid1Mill.Name = "grid1Mill";
            this.grid1Mill.OptimizeMode = SourceGrid.CellOptimizeMode.ForRows;
            this.grid1Mill.SelectionMode = SourceGrid.GridSelectionMode.Cell;
            this.grid1Mill.Size = new System.Drawing.Size(832, 589);
            this.grid1Mill.TabIndex = 0;
            this.grid1Mill.TabStop = true;
            this.grid1Mill.ToolTipText = "";
            // 
            // tabPage3Mill
            // 
            this.tabPage3Mill.Controls.Add(this.grid2Mill);
            this.tabPage3Mill.Location = new System.Drawing.Point(4, 22);
            this.tabPage3Mill.Name = "tabPage3Mill";
            this.tabPage3Mill.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3Mill.Size = new System.Drawing.Size(838, 595);
            this.tabPage3Mill.TabIndex = 2;
            this.tabPage3Mill.Text = "Количетсво зубьев фрезы";
            this.tabPage3Mill.UseVisualStyleBackColor = true;
            // 
            // grid2Mill
            // 
            this.grid2Mill.AutoSize = true;
            this.grid2Mill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid2Mill.EnableSort = true;
            this.grid2Mill.Location = new System.Drawing.Point(3, 3);
            this.grid2Mill.Name = "grid2Mill";
            this.grid2Mill.OptimizeMode = SourceGrid.CellOptimizeMode.ForRows;
            this.grid2Mill.SelectionMode = SourceGrid.GridSelectionMode.Cell;
            this.grid2Mill.Size = new System.Drawing.Size(832, 589);
            this.grid2Mill.TabIndex = 0;
            this.grid2Mill.TabStop = true;
            this.grid2Mill.ToolTipText = "";
            // 
            // tabPage4Mill
            // 
            this.tabPage4Mill.Controls.Add(this.grid3Mill);
            this.tabPage4Mill.Location = new System.Drawing.Point(4, 22);
            this.tabPage4Mill.Name = "tabPage4Mill";
            this.tabPage4Mill.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4Mill.Size = new System.Drawing.Size(838, 595);
            this.tabPage4Mill.TabIndex = 3;
            this.tabPage4Mill.Text = "Поправочный коэффициент скорости резания";
            this.tabPage4Mill.UseVisualStyleBackColor = true;
            // 
            // grid3Mill
            // 
            this.grid3Mill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid3Mill.EnableSort = true;
            this.grid3Mill.Location = new System.Drawing.Point(3, 3);
            this.grid3Mill.Name = "grid3Mill";
            this.grid3Mill.OptimizeMode = SourceGrid.CellOptimizeMode.ForRows;
            this.grid3Mill.SelectionMode = SourceGrid.GridSelectionMode.Cell;
            this.grid3Mill.Size = new System.Drawing.Size(832, 589);
            this.grid3Mill.TabIndex = 0;
            this.grid3Mill.TabStop = true;
            this.grid3Mill.ToolTipText = "";
            // 
            // tabPage5Mill
            // 
            this.tabPage5Mill.Controls.Add(this.grid4Mill);
            this.tabPage5Mill.Location = new System.Drawing.Point(4, 22);
            this.tabPage5Mill.Name = "tabPage5Mill";
            this.tabPage5Mill.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5Mill.Size = new System.Drawing.Size(838, 595);
            this.tabPage5Mill.TabIndex = 4;
            this.tabPage5Mill.Text = "Поправочный коэффициент силы резания";
            this.tabPage5Mill.UseVisualStyleBackColor = true;
            // 
            // grid4Mill
            // 
            this.grid4Mill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid4Mill.EnableSort = true;
            this.grid4Mill.Location = new System.Drawing.Point(3, 3);
            this.grid4Mill.Name = "grid4Mill";
            this.grid4Mill.OptimizeMode = SourceGrid.CellOptimizeMode.ForRows;
            this.grid4Mill.SelectionMode = SourceGrid.GridSelectionMode.Cell;
            this.grid4Mill.Size = new System.Drawing.Size(832, 589);
            this.grid4Mill.TabIndex = 0;
            this.grid4Mill.TabStop = true;
            this.grid4Mill.ToolTipText = "";
            // 
            // tabPage6Mill
            // 
            this.tabPage6Mill.Controls.Add(this.grid5Mill);
            this.tabPage6Mill.Location = new System.Drawing.Point(4, 22);
            this.tabPage6Mill.Name = "tabPage6Mill";
            this.tabPage6Mill.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6Mill.Size = new System.Drawing.Size(838, 595);
            this.tabPage6Mill.TabIndex = 5;
            this.tabPage6Mill.Text = "Эмпирические коэффициенты силы резания";
            this.tabPage6Mill.UseVisualStyleBackColor = true;
            // 
            // grid5Mill
            // 
            this.grid5Mill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid5Mill.EnableSort = true;
            this.grid5Mill.Location = new System.Drawing.Point(3, 3);
            this.grid5Mill.Name = "grid5Mill";
            this.grid5Mill.OptimizeMode = SourceGrid.CellOptimizeMode.ForRows;
            this.grid5Mill.SelectionMode = SourceGrid.GridSelectionMode.Cell;
            this.grid5Mill.Size = new System.Drawing.Size(832, 589);
            this.grid5Mill.TabIndex = 0;
            this.grid5Mill.TabStop = true;
            this.grid5Mill.ToolTipText = "";
            // 
            // tabPage7Mill
            // 
            this.tabPage7Mill.Controls.Add(this.splitContainer4);
            this.tabPage7Mill.Location = new System.Drawing.Point(4, 22);
            this.tabPage7Mill.Name = "tabPage7Mill";
            this.tabPage7Mill.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7Mill.Size = new System.Drawing.Size(838, 595);
            this.tabPage7Mill.TabIndex = 6;
            this.tabPage7Mill.Text = "Результат";
            this.tabPage7Mill.UseVisualStyleBackColor = true;
            this.tabPage7Mill.Enter += new System.EventHandler(this.tabPage7Mill_Enter);
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(3, 3);
            this.splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.grid20);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.grid21);
            this.splitContainer4.Size = new System.Drawing.Size(832, 589);
            this.splitContainer4.SplitterDistance = 277;
            this.splitContainer4.TabIndex = 8;
            // 
            // grid20
            // 
            this.grid20.AutoSize = true;
            this.grid20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid20.EnableSort = false;
            this.grid20.Location = new System.Drawing.Point(0, 0);
            this.grid20.Margin = new System.Windows.Forms.Padding(5);
            this.grid20.Name = "grid20";
            this.grid20.OptimizeMode = SourceGrid.CellOptimizeMode.ForRows;
            this.grid20.SelectionMode = SourceGrid.GridSelectionMode.Cell;
            this.grid20.Size = new System.Drawing.Size(277, 589);
            this.grid20.TabIndex = 6;
            this.grid20.TabStop = true;
            this.grid20.ToolTipText = "";
            // 
            // grid21
            // 
            this.grid21.AutoSize = true;
            this.grid21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid21.EnableSort = false;
            this.grid21.Location = new System.Drawing.Point(0, 0);
            this.grid21.Margin = new System.Windows.Forms.Padding(5);
            this.grid21.Name = "grid21";
            this.grid21.OptimizeMode = SourceGrid.CellOptimizeMode.ForRows;
            this.grid21.SelectionMode = SourceGrid.GridSelectionMode.Cell;
            this.grid21.Size = new System.Drawing.Size(551, 589);
            this.grid21.TabIndex = 7;
            this.grid21.TabStop = true;
            this.grid21.ToolTipText = "";
            // 
            // tabControl3
            // 
            this.tabControl3.Controls.Add(this.tabPage12);
            this.tabControl3.Controls.Add(this.tabPage13);
            this.tabControl3.Controls.Add(this.tabPage14);
            this.tabControl3.Controls.Add(this.tabPage15);
            this.tabControl3.Controls.Add(this.tabPage16);
            this.tabControl3.Controls.Add(this.tabPage17);
            this.tabControl3.Controls.Add(this.tabPage18);
            this.tabControl3.Controls.Add(this.tabPage20);
            this.tabControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl3.ItemSize = new System.Drawing.Size(131, 20);
            this.tabControl3.Location = new System.Drawing.Point(0, 0);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(846, 621);
            this.tabControl3.TabIndex = 2;
            this.tabControl3.Visible = false;
            // 
            // tabPage12
            // 
            this.tabPage12.BackColor = System.Drawing.Color.Transparent;
            this.tabPage12.Controls.Add(this.grid9);
            this.tabPage12.Location = new System.Drawing.Point(4, 24);
            this.tabPage12.Name = "tabPage12";
            this.tabPage12.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage12.Size = new System.Drawing.Size(838, 593);
            this.tabPage12.TabIndex = 0;
            this.tabPage12.Text = "Выбор глубины резания";
            this.tabPage12.UseVisualStyleBackColor = true;
            // 
            // grid9
            // 
            this.grid9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid9.EnableSort = false;
            this.grid9.Location = new System.Drawing.Point(3, 3);
            this.grid9.Name = "grid9";
            this.grid9.OptimizeMode = SourceGrid.CellOptimizeMode.ForRows;
            this.grid9.SelectionMode = SourceGrid.GridSelectionMode.Cell;
            this.grid9.Size = new System.Drawing.Size(832, 587);
            this.grid9.TabIndex = 0;
            this.grid9.TabStop = true;
            this.grid9.ToolTipText = "";
            // 
            // tabPage13
            // 
            this.tabPage13.Controls.Add(this.grid10);
            this.tabPage13.Location = new System.Drawing.Point(4, 24);
            this.tabPage13.Name = "tabPage13";
            this.tabPage13.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage13.Size = new System.Drawing.Size(838, 593);
            this.tabPage13.TabIndex = 9;
            this.tabPage13.Text = "Выбор подачи";
            this.tabPage13.UseVisualStyleBackColor = true;
            // 
            // grid10
            // 
            this.grid10.AutoSize = true;
            this.grid10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid10.EnableSort = false;
            this.grid10.Location = new System.Drawing.Point(3, 3);
            this.grid10.Name = "grid10";
            this.grid10.OptimizeMode = SourceGrid.CellOptimizeMode.ForRows;
            this.grid10.SelectionMode = SourceGrid.GridSelectionMode.Cell;
            this.grid10.Size = new System.Drawing.Size(832, 587);
            this.grid10.TabIndex = 1;
            this.grid10.TabStop = true;
            this.grid10.ToolTipText = "";
            // 
            // tabPage14
            // 
            this.tabPage14.Controls.Add(this.grid11);
            this.tabPage14.Location = new System.Drawing.Point(4, 24);
            this.tabPage14.Name = "tabPage14";
            this.tabPage14.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage14.Size = new System.Drawing.Size(838, 593);
            this.tabPage14.TabIndex = 10;
            this.tabPage14.Text = "Поправка на обр. материал";
            this.tabPage14.UseVisualStyleBackColor = true;
            // 
            // grid11
            // 
            this.grid11.AutoSize = true;
            this.grid11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid11.EnableSort = false;
            this.grid11.Location = new System.Drawing.Point(3, 3);
            this.grid11.Name = "grid11";
            this.grid11.OptimizeMode = SourceGrid.CellOptimizeMode.ForRows;
            this.grid11.SelectionMode = SourceGrid.GridSelectionMode.Cell;
            this.grid11.Size = new System.Drawing.Size(832, 587);
            this.grid11.TabIndex = 1;
            this.grid11.TabStop = true;
            this.grid11.ToolTipText = "";
            // 
            // tabPage15
            // 
            this.tabPage15.Controls.Add(this.grid12);
            this.tabPage15.Location = new System.Drawing.Point(4, 24);
            this.tabPage15.Name = "tabPage15";
            this.tabPage15.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage15.Size = new System.Drawing.Size(838, 593);
            this.tabPage15.TabIndex = 11;
            this.tabPage15.Text = "Поправка на сост. обр. пов-ти";
            this.tabPage15.UseVisualStyleBackColor = true;
            // 
            // grid12
            // 
            this.grid12.AutoSize = true;
            this.grid12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid12.EnableSort = false;
            this.grid12.Location = new System.Drawing.Point(3, 3);
            this.grid12.Name = "grid12";
            this.grid12.OptimizeMode = SourceGrid.CellOptimizeMode.ForRows;
            this.grid12.SelectionMode = SourceGrid.GridSelectionMode.Cell;
            this.grid12.Size = new System.Drawing.Size(832, 587);
            this.grid12.TabIndex = 2;
            this.grid12.TabStop = true;
            this.grid12.ToolTipText = "";
            // 
            // tabPage16
            // 
            this.tabPage16.Controls.Add(this.grid13);
            this.tabPage16.Location = new System.Drawing.Point(4, 24);
            this.tabPage16.Name = "tabPage16";
            this.tabPage16.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage16.Size = new System.Drawing.Size(838, 593);
            this.tabPage16.TabIndex = 12;
            this.tabPage16.Text = "Поправка на глубину отвертия";
            this.tabPage16.UseVisualStyleBackColor = true;
            // 
            // grid13
            // 
            this.grid13.AutoSize = true;
            this.grid13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid13.EnableSort = false;
            this.grid13.Location = new System.Drawing.Point(3, 3);
            this.grid13.Name = "grid13";
            this.grid13.OptimizeMode = SourceGrid.CellOptimizeMode.ForRows;
            this.grid13.SelectionMode = SourceGrid.GridSelectionMode.Cell;
            this.grid13.Size = new System.Drawing.Size(832, 587);
            this.grid13.TabIndex = 3;
            this.grid13.TabStop = true;
            this.grid13.ToolTipText = "";
            // 
            // tabPage17
            // 
            this.tabPage17.Controls.Add(this.grid14);
            this.tabPage17.Location = new System.Drawing.Point(4, 24);
            this.tabPage17.Name = "tabPage17";
            this.tabPage17.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage17.Size = new System.Drawing.Size(838, 593);
            this.tabPage17.TabIndex = 13;
            this.tabPage17.Text = "Эмпирические коэффициенты";
            this.tabPage17.UseVisualStyleBackColor = true;
            // 
            // grid14
            // 
            this.grid14.AutoSize = true;
            this.grid14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid14.EnableSort = false;
            this.grid14.Location = new System.Drawing.Point(3, 3);
            this.grid14.Name = "grid14";
            this.grid14.OptimizeMode = SourceGrid.CellOptimizeMode.ForRows;
            this.grid14.SelectionMode = SourceGrid.GridSelectionMode.Cell;
            this.grid14.Size = new System.Drawing.Size(832, 587);
            this.grid14.TabIndex = 4;
            this.grid14.TabStop = true;
            this.grid14.ToolTipText = "";
            // 
            // tabPage18
            // 
            this.tabPage18.Controls.Add(this.grid15);
            this.tabPage18.Location = new System.Drawing.Point(4, 24);
            this.tabPage18.Name = "tabPage18";
            this.tabPage18.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage18.Size = new System.Drawing.Size(838, 593);
            this.tabPage18.TabIndex = 14;
            this.tabPage18.Text = "Параметры режима резания";
            this.tabPage18.UseVisualStyleBackColor = true;
            // 
            // grid15
            // 
            this.grid15.AutoSize = true;
            this.grid15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid15.EnableSort = false;
            this.grid15.Location = new System.Drawing.Point(3, 3);
            this.grid15.Name = "grid15";
            this.grid15.OptimizeMode = SourceGrid.CellOptimizeMode.ForRows;
            this.grid15.SelectionMode = SourceGrid.GridSelectionMode.Cell;
            this.grid15.Size = new System.Drawing.Size(832, 587);
            this.grid15.TabIndex = 5;
            this.grid15.TabStop = true;
            this.grid15.ToolTipText = "";
            // 
            // tabPage20
            // 
            this.tabPage20.Controls.Add(this.splitContainer2);
            this.tabPage20.Location = new System.Drawing.Point(4, 24);
            this.tabPage20.Name = "tabPage20";
            this.tabPage20.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage20.Size = new System.Drawing.Size(838, 593);
            this.tabPage20.TabIndex = 8;
            this.tabPage20.Text = "Результат";
            this.tabPage20.UseVisualStyleBackColor = true;
            this.tabPage20.Enter += new System.EventHandler(this.tabPage20_Enter);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.grid16);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.grid17);
            this.splitContainer2.Size = new System.Drawing.Size(832, 587);
            this.splitContainer2.SplitterDistance = 277;
            this.splitContainer2.TabIndex = 7;
            // 
            // grid16
            // 
            this.grid16.AutoSize = true;
            this.grid16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid16.EnableSort = false;
            this.grid16.Location = new System.Drawing.Point(0, 0);
            this.grid16.Margin = new System.Windows.Forms.Padding(5);
            this.grid16.Name = "grid16";
            this.grid16.OptimizeMode = SourceGrid.CellOptimizeMode.ForRows;
            this.grid16.SelectionMode = SourceGrid.GridSelectionMode.Cell;
            this.grid16.Size = new System.Drawing.Size(277, 587);
            this.grid16.TabIndex = 6;
            this.grid16.TabStop = true;
            this.grid16.ToolTipText = "";
            // 
            // grid17
            // 
            this.grid17.AutoSize = true;
            this.grid17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid17.EnableSort = false;
            this.grid17.Location = new System.Drawing.Point(0, 0);
            this.grid17.Margin = new System.Windows.Forms.Padding(5);
            this.grid17.Name = "grid17";
            this.grid17.OptimizeMode = SourceGrid.CellOptimizeMode.ForRows;
            this.grid17.SelectionMode = SourceGrid.GridSelectionMode.Cell;
            this.grid17.Size = new System.Drawing.Size(551, 587);
            this.grid17.TabIndex = 7;
            this.grid17.TabStop = true;
            this.grid17.ToolTipText = "";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Controls.Add(this.tabPage8);
            this.tabControl1.Controls.Add(this.tabPage9);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.ItemSize = new System.Drawing.Size(131, 20);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(846, 621);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.Visible = false;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.grid1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(838, 593);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Выбор глубины резания";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // grid1
            // 
            this.grid1.AutoSize = true;
            this.grid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid1.EnableSort = true;
            this.grid1.Location = new System.Drawing.Point(3, 3);
            this.grid1.Name = "grid1";
            this.grid1.OptimizeMode = SourceGrid.CellOptimizeMode.ForRows;
            this.grid1.SelectionMode = SourceGrid.GridSelectionMode.Cell;
            this.grid1.Size = new System.Drawing.Size(832, 587);
            this.grid1.TabIndex = 0;
            this.grid1.TabStop = true;
            this.grid1.ToolTipText = "";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.grid2);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(838, 593);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Выбор подачи";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // grid2
            // 
            this.grid2.AutoSize = true;
            this.grid2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid2.EnableSort = true;
            this.grid2.Location = new System.Drawing.Point(3, 3);
            this.grid2.Name = "grid2";
            this.grid2.OptimizeMode = SourceGrid.CellOptimizeMode.ForRows;
            this.grid2.SelectionMode = SourceGrid.GridSelectionMode.Cell;
            this.grid2.Size = new System.Drawing.Size(832, 587);
            this.grid2.TabIndex = 0;
            this.grid2.TabStop = true;
            this.grid2.ToolTipText = "";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.grid3);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage3.Size = new System.Drawing.Size(838, 593);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Поправка на материал детали";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // grid3
            // 
            this.grid3.AutoSize = true;
            this.grid3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid3.EnableSort = true;
            this.grid3.Location = new System.Drawing.Point(2, 2);
            this.grid3.Name = "grid3";
            this.grid3.OptimizeMode = SourceGrid.CellOptimizeMode.ForRows;
            this.grid3.SelectionMode = SourceGrid.GridSelectionMode.Cell;
            this.grid3.Size = new System.Drawing.Size(834, 589);
            this.grid3.TabIndex = 1;
            this.grid3.TabStop = true;
            this.grid3.ToolTipText = "";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.grid4);
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage4.Size = new System.Drawing.Size(838, 593);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Поправка на состояние поверхности";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // grid4
            // 
            this.grid4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid4.EnableSort = true;
            this.grid4.Location = new System.Drawing.Point(2, 2);
            this.grid4.Name = "grid4";
            this.grid4.OptimizeMode = SourceGrid.CellOptimizeMode.ForRows;
            this.grid4.SelectionMode = SourceGrid.GridSelectionMode.Cell;
            this.grid4.Size = new System.Drawing.Size(834, 589);
            this.grid4.TabIndex = 2;
            this.grid4.TabStop = true;
            this.grid4.ToolTipText = "";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.grid5);
            this.tabPage5.Location = new System.Drawing.Point(4, 24);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage5.Size = new System.Drawing.Size(838, 593);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Поправка на материал инструмента";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // grid5
            // 
            this.grid5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid5.EnableSort = true;
            this.grid5.Location = new System.Drawing.Point(2, 2);
            this.grid5.Name = "grid5";
            this.grid5.OptimizeMode = SourceGrid.CellOptimizeMode.ForRows;
            this.grid5.SelectionMode = SourceGrid.GridSelectionMode.Cell;
            this.grid5.Size = new System.Drawing.Size(834, 589);
            this.grid5.TabIndex = 3;
            this.grid5.TabStop = true;
            this.grid5.ToolTipText = "";
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.grid6);
            this.tabPage6.Location = new System.Drawing.Point(4, 24);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(838, 593);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Эмпирические коэффициенты скорости резания";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // grid6
            // 
            this.grid6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid6.EnableSort = true;
            this.grid6.Location = new System.Drawing.Point(3, 3);
            this.grid6.Name = "grid6";
            this.grid6.OptimizeMode = SourceGrid.CellOptimizeMode.ForRows;
            this.grid6.SelectionMode = SourceGrid.GridSelectionMode.Cell;
            this.grid6.Size = new System.Drawing.Size(832, 587);
            this.grid6.TabIndex = 3;
            this.grid6.TabStop = true;
            this.grid6.ToolTipText = "";
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.grid7);
            this.tabPage7.Location = new System.Drawing.Point(4, 24);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(838, 593);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Эмпирические коэффициенты силы резания ";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // grid7
            // 
            this.grid7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid7.EnableSort = true;
            this.grid7.Location = new System.Drawing.Point(3, 3);
            this.grid7.Name = "grid7";
            this.grid7.OptimizeMode = SourceGrid.CellOptimizeMode.ForRows;
            this.grid7.SelectionMode = SourceGrid.GridSelectionMode.Cell;
            this.grid7.Size = new System.Drawing.Size(832, 587);
            this.grid7.TabIndex = 4;
            this.grid7.TabStop = true;
            this.grid7.ToolTipText = "";
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.grid8);
            this.tabPage8.Location = new System.Drawing.Point(4, 24);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(838, 593);
            this.tabPage8.TabIndex = 7;
            this.tabPage8.Text = "Поправка на обрабатываемый материал";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // grid8
            // 
            this.grid8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid8.EnableSort = true;
            this.grid8.Location = new System.Drawing.Point(3, 3);
            this.grid8.Name = "grid8";
            this.grid8.OptimizeMode = SourceGrid.CellOptimizeMode.ForRows;
            this.grid8.SelectionMode = SourceGrid.GridSelectionMode.Cell;
            this.grid8.Size = new System.Drawing.Size(832, 587);
            this.grid8.TabIndex = 4;
            this.grid8.TabStop = true;
            this.grid8.ToolTipText = "";
            // 
            // tabPage9
            // 
            this.tabPage9.Controls.Add(this.splitContainer3);
            this.tabPage9.Location = new System.Drawing.Point(4, 24);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage9.Size = new System.Drawing.Size(838, 593);
            this.tabPage9.TabIndex = 8;
            this.tabPage9.Text = "Результат";
            this.tabPage9.UseVisualStyleBackColor = true;
            this.tabPage9.Enter += new System.EventHandler(this.tabPage9_Enter);
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(3, 3);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.grid18);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.grid19);
            this.splitContainer3.Size = new System.Drawing.Size(832, 587);
            this.splitContainer3.SplitterDistance = 277;
            this.splitContainer3.TabIndex = 8;
            // 
            // grid18
            // 
            this.grid18.AutoSize = true;
            this.grid18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid18.EnableSort = false;
            this.grid18.Location = new System.Drawing.Point(0, 0);
            this.grid18.Margin = new System.Windows.Forms.Padding(5);
            this.grid18.Name = "grid18";
            this.grid18.OptimizeMode = SourceGrid.CellOptimizeMode.ForRows;
            this.grid18.SelectionMode = SourceGrid.GridSelectionMode.Cell;
            this.grid18.Size = new System.Drawing.Size(277, 587);
            this.grid18.TabIndex = 6;
            this.grid18.TabStop = true;
            this.grid18.ToolTipText = "";
            // 
            // grid19
            // 
            this.grid19.AutoSize = true;
            this.grid19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid19.EnableSort = false;
            this.grid19.Location = new System.Drawing.Point(0, 0);
            this.grid19.Margin = new System.Windows.Forms.Padding(5);
            this.grid19.Name = "grid19";
            this.grid19.OptimizeMode = SourceGrid.CellOptimizeMode.ForRows;
            this.grid19.SelectionMode = SourceGrid.GridSelectionMode.Cell;
            this.grid19.Size = new System.Drawing.Size(551, 587);
            this.grid19.TabIndex = 7;
            this.grid19.TabStop = true;
            this.grid19.ToolTipText = "";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "xml files (*.xml)|*.xml|txt files (*.txt)|*.txt|All files (*.*)|*.*\" ";
            // 
            // tabPage10
            // 
            this.tabPage10.Location = new System.Drawing.Point(4, 22);
            this.tabPage10.Name = "tabPage10";
            this.tabPage10.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage10.Size = new System.Drawing.Size(650, 448);
            this.tabPage10.TabIndex = 0;
            this.tabPage10.Text = "tabPage10";
            this.tabPage10.UseVisualStyleBackColor = true;
            // 
            // tabPage11
            // 
            this.tabPage11.Location = new System.Drawing.Point(4, 22);
            this.tabPage11.Name = "tabPage11";
            this.tabPage11.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage11.Size = new System.Drawing.Size(192, 74);
            this.tabPage11.TabIndex = 1;
            this.tabPage11.Text = "tabPage11";
            this.tabPage11.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu1ToolStripMenuItem,
            this.переходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1044, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menu1ToolStripMenuItem
            // 
            this.menu1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.makeReportToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menu1ToolStripMenuItem.Name = "menu1ToolStripMenuItem";
            this.menu1ToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.menu1ToolStripMenuItem.Text = "Файл";
            // 
            // makeReportToolStripMenuItem
            // 
            this.makeReportToolStripMenuItem.Name = "makeReportToolStripMenuItem";
            this.makeReportToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.makeReportToolStripMenuItem.Text = "Создать отчет";
            this.makeReportToolStripMenuItem.Click += new System.EventHandler(this.makeReportToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Выход";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // переходToolStripMenuItem
            // 
            this.переходToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьТокарныйToolStripMenuItem,
            this.создатьФрезерныйToolStripMenuItem,
            this.создатьСверлилдныйToolStripMenuItem});
            this.переходToolStripMenuItem.Name = "переходToolStripMenuItem";
            this.переходToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.переходToolStripMenuItem.Text = "Переход";
            // 
            // создатьТокарныйToolStripMenuItem
            // 
            this.создатьТокарныйToolStripMenuItem.Name = "создатьТокарныйToolStripMenuItem";
            this.создатьТокарныйToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.создатьТокарныйToolStripMenuItem.Text = "Создать токарный";
            this.создатьТокарныйToolStripMenuItem.Click += new System.EventHandler(this.makeTurningStepToolStripMenuItem_Click);
            // 
            // создатьФрезерныйToolStripMenuItem
            // 
            this.создатьФрезерныйToolStripMenuItem.Name = "создатьФрезерныйToolStripMenuItem";
            this.создатьФрезерныйToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.создатьФрезерныйToolStripMenuItem.Text = "Создать фрезерный";
            this.создатьФрезерныйToolStripMenuItem.Click += new System.EventHandler(this.makeMillStepToolStripMenuItem_Click);
            // 
            // создатьСверлилдныйToolStripMenuItem
            // 
            this.создатьСверлилдныйToolStripMenuItem.Name = "создатьСверлилдныйToolStripMenuItem";
            this.создатьСверлилдныйToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.создатьСверлилдныйToolStripMenuItem.Text = "Создать сверлильный";
            this.создатьСверлилдныйToolStripMenuItem.Click += new System.EventHandler(this.makeDrillStepToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 645);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(672, 338);
            this.Name = "Form1";
            this.Text = "Калькулятор режимов резания";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage1Mill.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage2Mill.ResumeLayout(false);
            this.tabPage2Mill.PerformLayout();
            this.tabPage3Mill.ResumeLayout(false);
            this.tabPage3Mill.PerformLayout();
            this.tabPage4Mill.ResumeLayout(false);
            this.tabPage5Mill.ResumeLayout(false);
            this.tabPage6Mill.ResumeLayout(false);
            this.tabPage7Mill.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel1.PerformLayout();
            this.splitContainer4.Panel2.ResumeLayout(false);
            this.splitContainer4.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.tabControl3.ResumeLayout(false);
            this.tabPage12.ResumeLayout(false);
            this.tabPage13.ResumeLayout(false);
            this.tabPage13.PerformLayout();
            this.tabPage14.ResumeLayout(false);
            this.tabPage14.PerformLayout();
            this.tabPage15.ResumeLayout(false);
            this.tabPage15.PerformLayout();
            this.tabPage16.ResumeLayout(false);
            this.tabPage16.PerformLayout();
            this.tabPage17.ResumeLayout(false);
            this.tabPage17.PerformLayout();
            this.tabPage18.ResumeLayout(false);
            this.tabPage18.PerformLayout();
            this.tabPage20.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.tabPage7.ResumeLayout(false);
            this.tabPage8.ResumeLayout(false);
            this.tabPage9.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public MyCellTracking cellpointer;
        public MyRowTrecking rowpointer;
        public SourceGrid.Cells.Controllers.CustomEvents clickEvent;
        public SourceGrid.Cells.Controllers.CustomEvents CellChangedEvent_rezba;
        public SourceGrid.Cells.Controllers.CustomEvents CellChangedEvent;
        public SQLiteConnection sqlite_conn;
        private SplitContainer splitContainer1;

        public int i;
        public Step s;
        private ArrayList stepList;
        private SaveFileDialog saveFileDialog1;
        
        private TabControl tabControl2;
        private TabPage tabPage10;
        private TabPage tabPage11;

        #region Код M
        private System.Windows.Forms.TabPage tabPage7Mill;
        private System.Windows.Forms.TabPage tabPage6Mill;
        private SourceGrid.Grid grid5Mill;
        private System.Windows.Forms.TabPage tabPage5Mill;
        private SourceGrid.Grid grid4Mill;
        private System.Windows.Forms.TabPage tabPage4Mill;
        private SourceGrid.Grid grid3Mill;
        private System.Windows.Forms.TabPage tabPage3Mill;
        private SourceGrid.Grid grid2Mill;
        private System.Windows.Forms.TabPage tabPage2Mill;
        private SourceGrid.Grid grid1Mill;
        private System.Windows.Forms.TabPage tabPage1Mill;
        private System.Windows.Forms.Label label6Mill;
        private System.Windows.Forms.Label label5Mill;
        private System.Windows.Forms.Label label4Mill;
        private System.Windows.Forms.Label label3Mill;
        private System.Windows.Forms.Label label2Mill;
        private System.Windows.Forms.Label label1Mill;
        private System.Windows.Forms.TextBox textBox3Mill;
        private System.Windows.Forms.TextBox textBox2Mill;
        private System.Windows.Forms.TextBox textBox1Mill;
        private ComboBox comboBox1Mill;
        private Button button2Mill;
        private TextBox textBox10Mill;
        private Label label7Mill;
        #endregion

        private GroupBox groupBox3;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Grid grid1;
        private TabPage tabPage2;
        private Grid grid2;
        private TabPage tabPage3;
        private Grid grid3;
        private TabPage tabPage4;
        private Grid grid4;
        private TabPage tabPage5;
        private Grid grid5;
        private TabPage tabPage6;
        private Grid grid6;
        private TabPage tabPage7;
        private Grid grid7;
        private TabPage tabPage8;
        private Grid grid8;
        private TabPage tabPage9;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menu1ToolStripMenuItem;
        private ToolStripMenuItem makeReportToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private TreeView treeView1;
        //public Step_Mill s2;
        //public Step_turning s1;
        //public Step_drill s3;
        public Step step;
        private TabControl tabControl3;
        private TabPage tabPage12;
        private Grid grid9;
        private TabPage tabPage13;
        private Grid grid10;
        private TabPage tabPage20;
        private TabPage tabPage14;
        private Grid grid11;
        private TabPage tabPage15;
        private Grid grid12;
        private TabPage tabPage16;
        private Grid grid13;
        private TabPage tabPage17;
        private Grid grid14;
        private TabPage tabPage18;
        private Grid grid15;
        private Grid grid16;
        private SplitContainer splitContainer2;
        private Grid grid17;
        private SplitContainer splitContainer3;
        private Grid grid18;
        private Grid grid19;
        private SplitContainer splitContainer4;
        private Grid grid20;
        private Grid grid21;
        private ToolStripMenuItem переходToolStripMenuItem;
        private ToolStripMenuItem создатьТокарныйToolStripMenuItem;
        private ToolStripMenuItem создатьФрезерныйToolStripMenuItem;
        private ToolStripMenuItem создатьСверлилдныйToolStripMenuItem;
    }
}

