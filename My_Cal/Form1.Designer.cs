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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.grid1 = new SourceGrid.Grid();
            this.grid2 = new SourceGrid.Grid();
            this.grid3 = new SourceGrid.Grid();
            this.grid4 = new SourceGrid.Grid();
            this.grid5 = new SourceGrid.Grid();
            this.grid6 = new SourceGrid.Grid();
            this.grid7 = new SourceGrid.Grid();
            this.grid8 = new SourceGrid.Grid();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.label40 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.tabPage1Frez = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1Frez = new System.Windows.Forms.Label();
            this.button2Frez = new System.Windows.Forms.Button();
            this.label7Frez = new System.Windows.Forms.Label();
            this.textBox1Frez = new System.Windows.Forms.TextBox();
            this.comboBox1Frez = new System.Windows.Forms.ComboBox();
            this.textBox10Frez = new System.Windows.Forms.TextBox();
            this.textBox2Frez = new System.Windows.Forms.TextBox();
            this.label6Frez = new System.Windows.Forms.Label();
            this.textBox3Frez = new System.Windows.Forms.TextBox();
            this.label2Frez = new System.Windows.Forms.Label();
            this.label3Frez = new System.Windows.Forms.Label();
            this.label4Frez = new System.Windows.Forms.Label();
            this.label5Frez = new System.Windows.Forms.Label();
            this.tabPage2Frez = new System.Windows.Forms.TabPage();
            this.grid1Frez = new SourceGrid.Grid();
            this.tabPage3Frez = new System.Windows.Forms.TabPage();
            this.grid2Frez = new SourceGrid.Grid();
            this.tabPage4Frez = new System.Windows.Forms.TabPage();
            this.grid3Frez = new SourceGrid.Grid();
            this.tabPage5Frez = new System.Windows.Forms.TabPage();
            this.grid4Frez = new SourceGrid.Grid();
            this.tabPage6Frez = new System.Windows.Forms.TabPage();
            this.grid5Frez = new SourceGrid.Grid();
            this.tabPage7Frez = new System.Windows.Forms.TabPage();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label58 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label60 = new System.Windows.Forms.Label();
            this.label61 = new System.Windows.Forms.Label();
            this.label62 = new System.Windows.Forms.Label();
            this.label63 = new System.Windows.Forms.Label();
            this.label64 = new System.Windows.Forms.Label();
            this.label65 = new System.Windows.Forms.Label();
            this.textBox38 = new System.Windows.Forms.TextBox();
            this.textBox39 = new System.Windows.Forms.TextBox();
            this.textBox40 = new System.Windows.Forms.TextBox();
            this.textBox41 = new System.Windows.Forms.TextBox();
            this.textBox42 = new System.Windows.Forms.TextBox();
            this.textBox43 = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label51 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.textBox30 = new System.Windows.Forms.TextBox();
            this.textBox31 = new System.Windows.Forms.TextBox();
            this.textBox32 = new System.Windows.Forms.TextBox();
            this.textBox33 = new System.Windows.Forms.TextBox();
            this.textBox34 = new System.Windows.Forms.TextBox();
            this.label56 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.textBox35 = new System.Windows.Forms.TextBox();
            this.textBox36 = new System.Windows.Forms.TextBox();
            this.label50 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.textBox29 = new System.Windows.Forms.TextBox();
            this.textBox28 = new System.Windows.Forms.TextBox();
            this.textBox27 = new System.Windows.Forms.TextBox();
            this.textBox26 = new System.Windows.Forms.TextBox();
            this.textBox25 = new System.Windows.Forms.TextBox();
            this.label44 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.textBox24 = new System.Windows.Forms.TextBox();
            this.textBox23 = new System.Windows.Forms.TextBox();
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.textBox9Frez = new System.Windows.Forms.TextBox();
            this.textBox8Frez = new System.Windows.Forms.TextBox();
            this.textBox7Frez = new System.Windows.Forms.TextBox();
            this.textBox6Frez = new System.Windows.Forms.TextBox();
            this.textBox4Frez = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tabPage10 = new System.Windows.Forms.TabPage();
            this.tabPage11 = new System.Windows.Forms.TabPage();
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
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControl3.SuspendLayout();
            this.tabPage1Frez.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage2Frez.SuspendLayout();
            this.tabPage3Frez.SuspendLayout();
            this.tabPage4Frez.SuspendLayout();
            this.tabPage5Frez.SuspendLayout();
            this.tabPage6Frez.SuspendLayout();
            this.tabPage7Frez.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // grid1
            // 
            this.grid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid1.EnableSort = true;
            this.grid1.Location = new System.Drawing.Point(3, 3);
            this.grid1.Name = "grid1";
            this.grid1.OptimizeMode = SourceGrid.CellOptimizeMode.ForRows;
            this.grid1.SelectionMode = SourceGrid.GridSelectionMode.Cell;
            this.grid1.Size = new System.Drawing.Size(832, 611);
            this.grid1.TabIndex = 0;
            this.grid1.TabStop = true;
            this.grid1.ToolTipText = "";
            // 
            // grid2
            // 
            this.grid2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid2.EnableSort = true;
            this.grid2.Location = new System.Drawing.Point(3, 3);
            this.grid2.Name = "grid2";
            this.grid2.OptimizeMode = SourceGrid.CellOptimizeMode.ForRows;
            this.grid2.SelectionMode = SourceGrid.GridSelectionMode.Cell;
            this.grid2.Size = new System.Drawing.Size(832, 611);
            this.grid2.TabIndex = 0;
            this.grid2.TabStop = true;
            this.grid2.ToolTipText = "";
            // 
            // grid3
            // 
            this.grid3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid3.EnableSort = true;
            this.grid3.Location = new System.Drawing.Point(2, 2);
            this.grid3.Name = "grid3";
            this.grid3.OptimizeMode = SourceGrid.CellOptimizeMode.ForRows;
            this.grid3.SelectionMode = SourceGrid.GridSelectionMode.Cell;
            this.grid3.Size = new System.Drawing.Size(834, 613);
            this.grid3.TabIndex = 1;
            this.grid3.TabStop = true;
            this.grid3.ToolTipText = "";
            // 
            // grid4
            // 
            this.grid4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid4.EnableSort = true;
            this.grid4.Location = new System.Drawing.Point(2, 2);
            this.grid4.Name = "grid4";
            this.grid4.OptimizeMode = SourceGrid.CellOptimizeMode.ForRows;
            this.grid4.SelectionMode = SourceGrid.GridSelectionMode.Cell;
            this.grid4.Size = new System.Drawing.Size(834, 613);
            this.grid4.TabIndex = 2;
            this.grid4.TabStop = true;
            this.grid4.ToolTipText = "";
            // 
            // grid5
            // 
            this.grid5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid5.EnableSort = true;
            this.grid5.Location = new System.Drawing.Point(2, 2);
            this.grid5.Name = "grid5";
            this.grid5.OptimizeMode = SourceGrid.CellOptimizeMode.ForRows;
            this.grid5.SelectionMode = SourceGrid.GridSelectionMode.Cell;
            this.grid5.Size = new System.Drawing.Size(834, 613);
            this.grid5.TabIndex = 3;
            this.grid5.TabStop = true;
            this.grid5.ToolTipText = "";
            // 
            // grid6
            // 
            this.grid6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid6.EnableSort = true;
            this.grid6.Location = new System.Drawing.Point(3, 3);
            this.grid6.Name = "grid6";
            this.grid6.OptimizeMode = SourceGrid.CellOptimizeMode.ForRows;
            this.grid6.SelectionMode = SourceGrid.GridSelectionMode.Cell;
            this.grid6.Size = new System.Drawing.Size(832, 611);
            this.grid6.TabIndex = 3;
            this.grid6.TabStop = true;
            this.grid6.ToolTipText = "";
            // 
            // grid7
            // 
            this.grid7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid7.EnableSort = true;
            this.grid7.Location = new System.Drawing.Point(3, 3);
            this.grid7.Name = "grid7";
            this.grid7.OptimizeMode = SourceGrid.CellOptimizeMode.ForRows;
            this.grid7.SelectionMode = SourceGrid.GridSelectionMode.Cell;
            this.grid7.Size = new System.Drawing.Size(832, 611);
            this.grid7.TabIndex = 4;
            this.grid7.TabStop = true;
            this.grid7.ToolTipText = "";
            // 
            // grid8
            // 
            this.grid8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid8.EnableSort = true;
            this.grid8.Location = new System.Drawing.Point(3, 3);
            this.grid8.Name = "grid8";
            this.grid8.OptimizeMode = SourceGrid.CellOptimizeMode.ForRows;
            this.grid8.SelectionMode = SourceGrid.GridSelectionMode.Cell;
            this.grid8.Size = new System.Drawing.Size(832, 611);
            this.grid8.TabIndex = 4;
            this.grid8.TabStop = true;
            this.grid8.ToolTipText = "";
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
            this.tabControl1.Size = new System.Drawing.Size(846, 645);
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
            this.tabPage1.Size = new System.Drawing.Size(838, 617);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Выбор глубины резания";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.grid2);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(838, 617);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Выбор подачи";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.grid3);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage3.Size = new System.Drawing.Size(838, 617);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Поправка на материал детали";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.grid4);
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage4.Size = new System.Drawing.Size(838, 617);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Поправка на состояние поверхности";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.grid5);
            this.tabPage5.Location = new System.Drawing.Point(4, 24);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage5.Size = new System.Drawing.Size(838, 617);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Поправка на материал инструмента";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.grid6);
            this.tabPage6.Location = new System.Drawing.Point(4, 24);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(838, 617);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Эмпирические коэффициенты скорости резания";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.grid7);
            this.tabPage7.Location = new System.Drawing.Point(4, 24);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(838, 617);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Эмпирические коэффициенты силы резания ";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.grid8);
            this.tabPage8.Location = new System.Drawing.Point(4, 24);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(838, 617);
            this.tabPage8.TabIndex = 7;
            this.tabPage8.Text = "Поправка на обрабатываемый материал";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // tabPage9
            // 
            this.tabPage9.Controls.Add(this.label40);
            this.tabPage9.Controls.Add(this.label41);
            this.tabPage9.Controls.Add(this.label42);
            this.tabPage9.Controls.Add(this.label43);
            this.tabPage9.Controls.Add(this.label45);
            this.tabPage9.Controls.Add(this.label27);
            this.tabPage9.Controls.Add(this.label26);
            this.tabPage9.Controls.Add(this.label25);
            this.tabPage9.Controls.Add(this.label24);
            this.tabPage9.Controls.Add(this.label23);
            this.tabPage9.Controls.Add(this.groupBox2);
            this.tabPage9.Controls.Add(this.groupBox1);
            this.tabPage9.Controls.Add(this.textBox21);
            this.tabPage9.Controls.Add(this.label22);
            this.tabPage9.Controls.Add(this.textBox20);
            this.tabPage9.Controls.Add(this.label21);
            this.tabPage9.Controls.Add(this.textBox19);
            this.tabPage9.Controls.Add(this.label20);
            this.tabPage9.Controls.Add(this.textBox18);
            this.tabPage9.Controls.Add(this.label19);
            this.tabPage9.Controls.Add(this.textBox17);
            this.tabPage9.Controls.Add(this.label18);
            this.tabPage9.Controls.Add(this.textBox16);
            this.tabPage9.Controls.Add(this.label17);
            this.tabPage9.Controls.Add(this.textBox15);
            this.tabPage9.Controls.Add(this.label16);
            this.tabPage9.Controls.Add(this.textBox14);
            this.tabPage9.Controls.Add(this.label15);
            this.tabPage9.Controls.Add(this.button1);
            this.tabPage9.Controls.Add(this.textBox5);
            this.tabPage9.Controls.Add(this.label6);
            this.tabPage9.Controls.Add(this.textBox4);
            this.tabPage9.Controls.Add(this.label5);
            this.tabPage9.Controls.Add(this.textBox3);
            this.tabPage9.Controls.Add(this.label4);
            this.tabPage9.Controls.Add(this.textBox2);
            this.tabPage9.Controls.Add(this.label3);
            this.tabPage9.Controls.Add(this.textBox1);
            this.tabPage9.Controls.Add(this.label2);
            this.tabPage9.Controls.Add(this.label1);
            this.tabPage9.Controls.Add(this.comboBox1);
            this.tabPage9.Controls.Add(this.pictureBox5);
            this.tabPage9.Controls.Add(this.pictureBox4);
            this.tabPage9.Controls.Add(this.pictureBox3);
            this.tabPage9.Controls.Add(this.pictureBox2);
            this.tabPage9.Controls.Add(this.pictureBox1);
            this.tabPage9.Location = new System.Drawing.Point(4, 24);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage9.Size = new System.Drawing.Size(838, 617);
            this.tabPage9.TabIndex = 8;
            this.tabPage9.Text = "Результат";
            this.tabPage9.UseVisualStyleBackColor = true;
            this.tabPage9.Enter += new System.EventHandler(this.tabPage9_Enter);
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label40.Location = new System.Drawing.Point(716, 481);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(31, 17);
            this.label40.TabIndex = 62;
            this.label40.Text = "кВт";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label41.Location = new System.Drawing.Point(716, 305);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(18, 17);
            this.label41.TabIndex = 61;
            this.label41.Text = "Н";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label42.Location = new System.Drawing.Point(715, 214);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(53, 17);
            this.label42.TabIndex = 60;
            this.label42.Text = "об/мин";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label43.Location = new System.Drawing.Point(717, 393);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(27, 17);
            this.label43.TabIndex = 59;
            this.label43.Text = "Нм";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label45.Location = new System.Drawing.Point(716, 124);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(46, 17);
            this.label45.TabIndex = 57;
            this.label45.Text = "м/мин";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label27.Location = new System.Drawing.Point(424, 443);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(134, 17);
            this.label27.TabIndex = 56;
            this.label27.Text = "Мощность резания";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label26.Location = new System.Drawing.Point(424, 354);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(118, 17);
            this.label26.TabIndex = 55;
            this.label26.Text = "Момент резания";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label25.Location = new System.Drawing.Point(424, 264);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(100, 17);
            this.label25.TabIndex = 54;
            this.label25.Text = "Сила резания";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label24.Location = new System.Drawing.Point(424, 172);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(133, 17);
            this.label24.TabIndex = 53;
            this.label24.Text = "Частота вращения";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label23.Location = new System.Drawing.Point(424, 78);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(128, 17);
            this.label23.TabIndex = 52;
            this.label23.Text = "Скорость резания";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.textBox10);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.textBox11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.textBox12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.textBox13);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox2.Location = new System.Drawing.Point(144, 309);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(268, 212);
            this.groupBox2.TabIndex = 47;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Эмпирические коэффициенты силы резания";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label14.Location = new System.Drawing.Point(42, 48);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(33, 17);
            this.label14.TabIndex = 20;
            this.label14.Text = "Cp=";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(82, 48);
            this.textBox10.Margin = new System.Windows.Forms.Padding(2);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(131, 23);
            this.textBox10.TabIndex = 21;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label13.Location = new System.Drawing.Point(42, 87);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(22, 17);
            this.label13.TabIndex = 22;
            this.label13.Text = "x=";
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(82, 88);
            this.textBox11.Margin = new System.Windows.Forms.Padding(2);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(131, 23);
            this.textBox11.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label12.Location = new System.Drawing.Point(42, 127);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(23, 17);
            this.label12.TabIndex = 24;
            this.label12.Text = "y=";
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(82, 128);
            this.textBox12.Margin = new System.Windows.Forms.Padding(2);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(131, 23);
            this.textBox12.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label11.Location = new System.Drawing.Point(42, 167);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 17);
            this.label11.TabIndex = 26;
            this.label11.Text = "n=";
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(82, 167);
            this.textBox13.Margin = new System.Windows.Forms.Padding(2);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(131, 23);
            this.textBox13.TabIndex = 27;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textBox7);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.textBox8);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.textBox9);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox1.Location = new System.Drawing.Point(144, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 219);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Эмпирические коэффициенты скорости резания";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(82, 53);
            this.textBox6.Margin = new System.Windows.Forms.Padding(2);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(131, 23);
            this.textBox6.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(42, 52);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Cv=";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(42, 92);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "x=";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(82, 93);
            this.textBox7.Margin = new System.Windows.Forms.Padding(2);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(131, 23);
            this.textBox7.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.Location = new System.Drawing.Point(42, 132);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "y=";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(82, 133);
            this.textBox8.Margin = new System.Windows.Forms.Padding(2);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(131, 23);
            this.textBox8.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label10.Location = new System.Drawing.Point(42, 172);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 17);
            this.label10.TabIndex = 18;
            this.label10.Text = "m=";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(82, 172);
            this.textBox9.Margin = new System.Windows.Forms.Padding(2);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(131, 23);
            this.textBox9.TabIndex = 19;
            // 
            // textBox21
            // 
            this.textBox21.Location = new System.Drawing.Point(623, 481);
            this.textBox21.Margin = new System.Windows.Forms.Padding(2);
            this.textBox21.Name = "textBox21";
            this.textBox21.Size = new System.Drawing.Size(87, 20);
            this.textBox21.TabIndex = 44;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label22.Location = new System.Drawing.Point(601, 483);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(16, 17);
            this.label22.TabIndex = 43;
            this.label22.Text = "=";
            // 
            // textBox20
            // 
            this.textBox20.Location = new System.Drawing.Point(623, 393);
            this.textBox20.Margin = new System.Windows.Forms.Padding(2);
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new System.Drawing.Size(87, 20);
            this.textBox20.TabIndex = 42;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label21.Location = new System.Drawing.Point(601, 395);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(16, 17);
            this.label21.TabIndex = 41;
            this.label21.Text = "=";
            // 
            // textBox19
            // 
            this.textBox19.Location = new System.Drawing.Point(623, 304);
            this.textBox19.Margin = new System.Windows.Forms.Padding(2);
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new System.Drawing.Size(87, 20);
            this.textBox19.TabIndex = 40;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label20.Location = new System.Drawing.Point(601, 306);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(16, 17);
            this.label20.TabIndex = 39;
            this.label20.Text = "=";
            // 
            // textBox18
            // 
            this.textBox18.Location = new System.Drawing.Point(623, 215);
            this.textBox18.Margin = new System.Windows.Forms.Padding(2);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(87, 20);
            this.textBox18.TabIndex = 38;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label19.Location = new System.Drawing.Point(601, 217);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(16, 17);
            this.label19.TabIndex = 37;
            this.label19.Text = "=";
            // 
            // textBox17
            // 
            this.textBox17.Location = new System.Drawing.Point(623, 124);
            this.textBox17.Margin = new System.Windows.Forms.Padding(2);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(87, 20);
            this.textBox17.TabIndex = 36;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label18.Location = new System.Drawing.Point(601, 126);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(16, 17);
            this.label18.TabIndex = 35;
            this.label18.Text = "=";
            // 
            // textBox16
            // 
            this.textBox16.Location = new System.Drawing.Point(613, 14);
            this.textBox16.Margin = new System.Windows.Forms.Padding(2);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(131, 20);
            this.textBox16.TabIndex = 34;
            this.textBox16.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox16_KeyUp);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label17.Location = new System.Drawing.Point(432, 12);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(182, 17);
            this.label17.TabIndex = 33;
            this.label17.Text = "Введите диаметр детали=";
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(57, 430);
            this.textBox15.Margin = new System.Windows.Forms.Padding(2);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(67, 20);
            this.textBox15.TabIndex = 32;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label16.Location = new System.Drawing.Point(8, 430);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(44, 17);
            this.label16.TabIndex = 31;
            this.label16.Text = "Kmp=";
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(57, 501);
            this.textBox14.Margin = new System.Windows.Forms.Padding(2);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(67, 20);
            this.textBox14.TabIndex = 30;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label15.Location = new System.Drawing.Point(18, 501);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(25, 17);
            this.label15.TabIndex = 29;
            this.label15.Text = "T=";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(613, 40);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 33);
            this.button1.TabIndex = 28;
            this.button1.Text = "Расчитать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(57, 359);
            this.textBox5.Margin = new System.Windows.Forms.Padding(2);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(67, 20);
            this.textBox5.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(13, 359);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Kиv=";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(57, 288);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(67, 20);
            this.textBox4.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(10, 288);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Kпv=";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(57, 217);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(67, 20);
            this.textBox3.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(9, 217);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Kmv=";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(57, 146);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(67, 20);
            this.textBox2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(19, 146);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "s=";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(57, 75);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(67, 20);
            this.textBox1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(20, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "t=";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(5, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выбирете период стойкости резца T:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "20",
            "30",
            "40",
            "60",
            "90",
            "120"});
            this.comboBox1.Location = new System.Drawing.Point(265, 14);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(147, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::My_Cal.Properties.Resources.N__2_;
            this.pictureBox5.Location = new System.Drawing.Point(427, 473);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(169, 49);
            this.pictureBox5.TabIndex = 51;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::My_Cal.Properties.Resources.M;
            this.pictureBox4.Location = new System.Drawing.Point(427, 388);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(169, 43);
            this.pictureBox4.TabIndex = 50;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::My_Cal.Properties.Resources.Pz;
            this.pictureBox3.Location = new System.Drawing.Point(427, 302);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(169, 35);
            this.pictureBox3.TabIndex = 49;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::My_Cal.Properties.Resources.n;
            this.pictureBox2.Location = new System.Drawing.Point(427, 205);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(169, 50);
            this.pictureBox2.TabIndex = 48;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::My_Cal.Properties.Resources.V;
            this.pictureBox1.Location = new System.Drawing.Point(427, 112);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 54);
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            // 
            // treeView1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.treeView1, 2);
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(2, 2);
            this.treeView1.Margin = new System.Windows.Forms.Padding(2);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(190, 561);
            this.treeView1.TabIndex = 2;
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Panel1MinSize = 150;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Panel2.Controls.Add(this.tabControl3);
            this.splitContainer1.Panel2MinSize = 350;
            this.splitContainer1.Size = new System.Drawing.Size(1044, 645);
            this.splitContainer1.SplitterDistance = 194;
            this.splitContainer1.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.button2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.treeView1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button3, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.button4, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(194, 645);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(3, 568);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 34);
            this.button2.TabIndex = 3;
            this.button2.Text = "Добавить токарный переход";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(100, 568);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 34);
            this.button3.TabIndex = 4;
            this.button3.Text = "Добавить фрезерный переход";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.button4, 2);
            this.button4.Location = new System.Drawing.Point(3, 608);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(188, 34);
            this.button4.TabIndex = 5;
            this.button4.Text = "Создать отчет";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // tabControl3
            // 
            this.tabControl3.Controls.Add(this.tabPage1Frez);
            this.tabControl3.Controls.Add(this.tabPage2Frez);
            this.tabControl3.Controls.Add(this.tabPage3Frez);
            this.tabControl3.Controls.Add(this.tabPage4Frez);
            this.tabControl3.Controls.Add(this.tabPage5Frez);
            this.tabControl3.Controls.Add(this.tabPage6Frez);
            this.tabControl3.Controls.Add(this.tabPage7Frez);
            this.tabControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl3.Location = new System.Drawing.Point(0, 0);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(846, 645);
            this.tabControl3.TabIndex = 1;
            // 
            // tabPage1Frez
            // 
            this.tabPage1Frez.Controls.Add(this.groupBox3);
            this.tabPage1Frez.Location = new System.Drawing.Point(4, 22);
            this.tabPage1Frez.Name = "tabPage1Frez";
            this.tabPage1Frez.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1Frez.Size = new System.Drawing.Size(838, 619);
            this.tabPage1Frez.TabIndex = 0;
            this.tabPage1Frez.Text = "Ввод основных параметров";
            this.tabPage1Frez.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1Frez);
            this.groupBox3.Controls.Add(this.button2Frez);
            this.groupBox3.Controls.Add(this.label7Frez);
            this.groupBox3.Controls.Add(this.textBox1Frez);
            this.groupBox3.Controls.Add(this.comboBox1Frez);
            this.groupBox3.Controls.Add(this.textBox10Frez);
            this.groupBox3.Controls.Add(this.textBox2Frez);
            this.groupBox3.Controls.Add(this.label6Frez);
            this.groupBox3.Controls.Add(this.textBox3Frez);
            this.groupBox3.Controls.Add(this.label2Frez);
            this.groupBox3.Controls.Add(this.label3Frez);
            this.groupBox3.Controls.Add(this.label4Frez);
            this.groupBox3.Controls.Add(this.label5Frez);
            this.groupBox3.Location = new System.Drawing.Point(6, 8);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(445, 277);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Основные параметры";
            // 
            // label1Frez
            // 
            this.label1Frez.AutoSize = true;
            this.label1Frez.Location = new System.Drawing.Point(23, 24);
            this.label1Frez.Name = "label1Frez";
            this.label1Frez.Size = new System.Drawing.Size(111, 13);
            this.label1Frez.TabIndex = 3;
            this.label1Frez.Text = "Глубина резания ( t )";
            // 
            // button2Frez
            // 
            this.button2Frez.Location = new System.Drawing.Point(280, 233);
            this.button2Frez.Name = "button2Frez";
            this.button2Frez.Size = new System.Drawing.Size(75, 23);
            this.button2Frez.TabIndex = 9;
            this.button2Frez.Text = "Ввод данных";
            this.button2Frez.UseVisualStyleBackColor = true;
            this.button2Frez.Click += new System.EventHandler(this.button2Frez_Click);
            // 
            // label7Frez
            // 
            this.label7Frez.AutoSize = true;
            this.label7Frez.Location = new System.Drawing.Point(277, 24);
            this.label7Frez.Name = "label7Frez";
            this.label7Frez.Size = new System.Drawing.Size(153, 13);
            this.label7Frez.TabIndex = 11;
            this.label7Frez.Text = "Период стойкости фрезы (Т)";
            // 
            // textBox1Frez
            // 
            this.textBox1Frez.Location = new System.Drawing.Point(17, 49);
            this.textBox1Frez.Name = "textBox1Frez";
            this.textBox1Frez.Size = new System.Drawing.Size(100, 20);
            this.textBox1Frez.TabIndex = 0;
            this.textBox1Frez.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyUp);
            // 
            // comboBox1Frez
            // 
            this.comboBox1Frez.FormattingEnabled = true;
            this.comboBox1Frez.Items.AddRange(new object[] {
            "20",
            "30",
            "40",
            "60",
            "90",
            "120"});
            this.comboBox1Frez.Location = new System.Drawing.Point(280, 48);
            this.comboBox1Frez.Name = "comboBox1Frez";
            this.comboBox1Frez.Size = new System.Drawing.Size(121, 21);
            this.comboBox1Frez.TabIndex = 0;
            this.comboBox1Frez.SelectedIndexChanged += new System.EventHandler(this.comboBox1Frez_SelectedIndexChanged);
            // 
            // textBox10Frez
            // 
            this.textBox10Frez.Location = new System.Drawing.Point(17, 236);
            this.textBox10Frez.Name = "textBox10Frez";
            this.textBox10Frez.Size = new System.Drawing.Size(100, 20);
            this.textBox10Frez.TabIndex = 10;
            this.textBox10Frez.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyUp);
            // 
            // textBox2Frez
            // 
            this.textBox2Frez.Location = new System.Drawing.Point(17, 111);
            this.textBox2Frez.Name = "textBox2Frez";
            this.textBox2Frez.Size = new System.Drawing.Size(100, 20);
            this.textBox2Frez.TabIndex = 1;
            this.textBox2Frez.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyUp);
            // 
            // label6Frez
            // 
            this.label6Frez.AutoSize = true;
            this.label6Frez.Location = new System.Drawing.Point(135, 167);
            this.label6Frez.Name = "label6Frez";
            this.label6Frez.Size = new System.Drawing.Size(150, 26);
            this.label6Frez.TabIndex = 8;
            this.label6Frez.Text = "0,2...0,1 при Ra 20...2,5\r\n0,08...0,04 при Ra 1,25...0,32";
            // 
            // textBox3Frez
            // 
            this.textBox3Frez.Location = new System.Drawing.Point(17, 173);
            this.textBox3Frez.Name = "textBox3Frez";
            this.textBox3Frez.Size = new System.Drawing.Size(100, 20);
            this.textBox3Frez.TabIndex = 2;
            this.textBox3Frez.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyUp);
            // 
            // label2Frez
            // 
            this.label2Frez.AutoSize = true;
            this.label2Frez.Location = new System.Drawing.Point(135, 43);
            this.label2Frez.Name = "label2Frez";
            this.label2Frez.Size = new System.Drawing.Size(120, 26);
            this.label2Frez.TabIndex = 4;
            this.label2Frez.Text = "3...20 при Ra 20...2,5\r\n1...3 при Ra 1,25...0,32";
            // 
            // label3Frez
            // 
            this.label3Frez.AutoSize = true;
            this.label3Frez.Location = new System.Drawing.Point(23, 89);
            this.label3Frez.Name = "label3Frez";
            this.label3Frez.Size = new System.Drawing.Size(99, 13);
            this.label3Frez.TabIndex = 5;
            this.label3Frez.Text = "Ширина фрезы (B)";
            // 
            // label4Frez
            // 
            this.label4Frez.AutoSize = true;
            this.label4Frez.Location = new System.Drawing.Point(23, 212);
            this.label4Frez.Name = "label4Frez";
            this.label4Frez.Size = new System.Drawing.Size(107, 13);
            this.label4Frez.TabIndex = 6;
            this.label4Frez.Text = "Диаметр фрезы (D)";
            // 
            // label5Frez
            // 
            this.label5Frez.AutoSize = true;
            this.label5Frez.Location = new System.Drawing.Point(23, 151);
            this.label5Frez.Name = "label5Frez";
            this.label5Frez.Size = new System.Drawing.Size(94, 13);
            this.label5Frez.TabIndex = 7;
            this.label5Frez.Text = "Подача на зуб Sz";
            // 
            // tabPage2Frez
            // 
            this.tabPage2Frez.Controls.Add(this.grid1Frez);
            this.tabPage2Frez.Location = new System.Drawing.Point(4, 22);
            this.tabPage2Frez.Name = "tabPage2Frez";
            this.tabPage2Frez.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2Frez.Size = new System.Drawing.Size(838, 619);
            this.tabPage2Frez.TabIndex = 1;
            this.tabPage2Frez.Text = "Эмперические параметры скорости резания";
            this.tabPage2Frez.UseVisualStyleBackColor = true;
            // 
            // grid1Frez
            // 
            this.grid1Frez.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid1Frez.EnableSort = true;
            this.grid1Frez.Location = new System.Drawing.Point(3, 3);
            this.grid1Frez.Name = "grid1Frez";
            this.grid1Frez.OptimizeMode = SourceGrid.CellOptimizeMode.ForRows;
            this.grid1Frez.SelectionMode = SourceGrid.GridSelectionMode.Cell;
            this.grid1Frez.Size = new System.Drawing.Size(832, 613);
            this.grid1Frez.TabIndex = 0;
            this.grid1Frez.TabStop = true;
            this.grid1Frez.ToolTipText = "";
            // 
            // tabPage3Frez
            // 
            this.tabPage3Frez.Controls.Add(this.grid2Frez);
            this.tabPage3Frez.Location = new System.Drawing.Point(4, 22);
            this.tabPage3Frez.Name = "tabPage3Frez";
            this.tabPage3Frez.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3Frez.Size = new System.Drawing.Size(838, 619);
            this.tabPage3Frez.TabIndex = 2;
            this.tabPage3Frez.Text = "Количетсво зубьев фрезы";
            this.tabPage3Frez.UseVisualStyleBackColor = true;
            // 
            // grid2Frez
            // 
            this.grid2Frez.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid2Frez.EnableSort = true;
            this.grid2Frez.Location = new System.Drawing.Point(3, 3);
            this.grid2Frez.Name = "grid2Frez";
            this.grid2Frez.OptimizeMode = SourceGrid.CellOptimizeMode.ForRows;
            this.grid2Frez.SelectionMode = SourceGrid.GridSelectionMode.Cell;
            this.grid2Frez.Size = new System.Drawing.Size(832, 613);
            this.grid2Frez.TabIndex = 0;
            this.grid2Frez.TabStop = true;
            this.grid2Frez.ToolTipText = "";
            // 
            // tabPage4Frez
            // 
            this.tabPage4Frez.Controls.Add(this.grid3Frez);
            this.tabPage4Frez.Location = new System.Drawing.Point(4, 22);
            this.tabPage4Frez.Name = "tabPage4Frez";
            this.tabPage4Frez.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4Frez.Size = new System.Drawing.Size(838, 619);
            this.tabPage4Frez.TabIndex = 3;
            this.tabPage4Frez.Text = "Поправочный коэффициент скорости резания";
            this.tabPage4Frez.UseVisualStyleBackColor = true;
            // 
            // grid3Frez
            // 
            this.grid3Frez.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid3Frez.EnableSort = true;
            this.grid3Frez.Location = new System.Drawing.Point(3, 3);
            this.grid3Frez.Name = "grid3Frez";
            this.grid3Frez.OptimizeMode = SourceGrid.CellOptimizeMode.ForRows;
            this.grid3Frez.SelectionMode = SourceGrid.GridSelectionMode.Cell;
            this.grid3Frez.Size = new System.Drawing.Size(832, 613);
            this.grid3Frez.TabIndex = 0;
            this.grid3Frez.TabStop = true;
            this.grid3Frez.ToolTipText = "";
            // 
            // tabPage5Frez
            // 
            this.tabPage5Frez.Controls.Add(this.grid4Frez);
            this.tabPage5Frez.Location = new System.Drawing.Point(4, 22);
            this.tabPage5Frez.Name = "tabPage5Frez";
            this.tabPage5Frez.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5Frez.Size = new System.Drawing.Size(838, 619);
            this.tabPage5Frez.TabIndex = 4;
            this.tabPage5Frez.Text = "Поправочный коэффициент силы резания";
            this.tabPage5Frez.UseVisualStyleBackColor = true;
            // 
            // grid4Frez
            // 
            this.grid4Frez.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid4Frez.EnableSort = true;
            this.grid4Frez.Location = new System.Drawing.Point(3, 3);
            this.grid4Frez.Name = "grid4Frez";
            this.grid4Frez.OptimizeMode = SourceGrid.CellOptimizeMode.ForRows;
            this.grid4Frez.SelectionMode = SourceGrid.GridSelectionMode.Cell;
            this.grid4Frez.Size = new System.Drawing.Size(832, 613);
            this.grid4Frez.TabIndex = 0;
            this.grid4Frez.TabStop = true;
            this.grid4Frez.ToolTipText = "";
            // 
            // tabPage6Frez
            // 
            this.tabPage6Frez.Controls.Add(this.grid5Frez);
            this.tabPage6Frez.Location = new System.Drawing.Point(4, 22);
            this.tabPage6Frez.Name = "tabPage6Frez";
            this.tabPage6Frez.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6Frez.Size = new System.Drawing.Size(838, 619);
            this.tabPage6Frez.TabIndex = 5;
            this.tabPage6Frez.Text = "Эмпирические коэффициенты силы резания";
            this.tabPage6Frez.UseVisualStyleBackColor = true;
            // 
            // grid5Frez
            // 
            this.grid5Frez.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid5Frez.EnableSort = true;
            this.grid5Frez.Location = new System.Drawing.Point(3, 3);
            this.grid5Frez.Name = "grid5Frez";
            this.grid5Frez.OptimizeMode = SourceGrid.CellOptimizeMode.ForRows;
            this.grid5Frez.SelectionMode = SourceGrid.GridSelectionMode.Cell;
            this.grid5Frez.Size = new System.Drawing.Size(832, 613);
            this.grid5Frez.TabIndex = 0;
            this.grid5Frez.TabStop = true;
            this.grid5Frez.ToolTipText = "";
            // 
            // tabPage7Frez
            // 
            this.tabPage7Frez.Controls.Add(this.pictureBox10);
            this.tabPage7Frez.Controls.Add(this.pictureBox9);
            this.tabPage7Frez.Controls.Add(this.pictureBox8);
            this.tabPage7Frez.Controls.Add(this.pictureBox7);
            this.tabPage7Frez.Controls.Add(this.pictureBox6);
            this.tabPage7Frez.Controls.Add(this.label58);
            this.tabPage7Frez.Controls.Add(this.groupBox5);
            this.tabPage7Frez.Controls.Add(this.groupBox4);
            this.tabPage7Frez.Controls.Add(this.label50);
            this.tabPage7Frez.Controls.Add(this.label49);
            this.tabPage7Frez.Controls.Add(this.label48);
            this.tabPage7Frez.Controls.Add(this.label47);
            this.tabPage7Frez.Controls.Add(this.label46);
            this.tabPage7Frez.Controls.Add(this.textBox29);
            this.tabPage7Frez.Controls.Add(this.textBox28);
            this.tabPage7Frez.Controls.Add(this.textBox27);
            this.tabPage7Frez.Controls.Add(this.textBox26);
            this.tabPage7Frez.Controls.Add(this.textBox25);
            this.tabPage7Frez.Controls.Add(this.label44);
            this.tabPage7Frez.Controls.Add(this.label38);
            this.tabPage7Frez.Controls.Add(this.label29);
            this.tabPage7Frez.Controls.Add(this.textBox24);
            this.tabPage7Frez.Controls.Add(this.textBox23);
            this.tabPage7Frez.Controls.Add(this.textBox22);
            this.tabPage7Frez.Controls.Add(this.label34);
            this.tabPage7Frez.Controls.Add(this.label35);
            this.tabPage7Frez.Controls.Add(this.label36);
            this.tabPage7Frez.Controls.Add(this.label37);
            this.tabPage7Frez.Controls.Add(this.label39);
            this.tabPage7Frez.Controls.Add(this.label33);
            this.tabPage7Frez.Controls.Add(this.label32);
            this.tabPage7Frez.Controls.Add(this.label31);
            this.tabPage7Frez.Controls.Add(this.label30);
            this.tabPage7Frez.Controls.Add(this.label28);
            this.tabPage7Frez.Controls.Add(this.textBox9Frez);
            this.tabPage7Frez.Controls.Add(this.textBox8Frez);
            this.tabPage7Frez.Controls.Add(this.textBox7Frez);
            this.tabPage7Frez.Controls.Add(this.textBox6Frez);
            this.tabPage7Frez.Controls.Add(this.textBox4Frez);
            this.tabPage7Frez.Location = new System.Drawing.Point(4, 22);
            this.tabPage7Frez.Name = "tabPage7Frez";
            this.tabPage7Frez.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7Frez.Size = new System.Drawing.Size(838, 619);
            this.tabPage7Frez.TabIndex = 6;
            this.tabPage7Frez.Text = "Результат";
            this.tabPage7Frez.UseVisualStyleBackColor = true;
            this.tabPage7Frez.Enter += new System.EventHandler(this.tabPage7Frez_Enter);
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::My_Cal.Properties.Resources.NN_frez;
            this.pictureBox10.Location = new System.Drawing.Point(545, 285);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(85, 37);
            this.pictureBox10.TabIndex = 42;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::My_Cal.Properties.Resources.Pz_frez;
            this.pictureBox9.Location = new System.Drawing.Point(545, 205);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(137, 49);
            this.pictureBox9.TabIndex = 41;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::My_Cal.Properties.Resources.n_frez;
            this.pictureBox8.Location = new System.Drawing.Point(545, 144);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(85, 32);
            this.pictureBox8.TabIndex = 40;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(545, 82);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(65, 39);
            this.pictureBox7.TabIndex = 39;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::My_Cal.Properties.Resources.V_Frez;
            this.pictureBox6.Location = new System.Drawing.Point(545, 24);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(148, 48);
            this.pictureBox6.TabIndex = 38;
            this.pictureBox6.TabStop = false;
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Location = new System.Drawing.Point(0, 46);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(119, 26);
            this.label58.TabIndex = 37;
            this.label58.Text = "Основные параметры\r\n       для расчета";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label60);
            this.groupBox5.Controls.Add(this.label61);
            this.groupBox5.Controls.Add(this.label62);
            this.groupBox5.Controls.Add(this.label63);
            this.groupBox5.Controls.Add(this.label64);
            this.groupBox5.Controls.Add(this.label65);
            this.groupBox5.Controls.Add(this.textBox38);
            this.groupBox5.Controls.Add(this.textBox39);
            this.groupBox5.Controls.Add(this.textBox40);
            this.groupBox5.Controls.Add(this.textBox41);
            this.groupBox5.Controls.Add(this.textBox42);
            this.groupBox5.Controls.Add(this.textBox43);
            this.groupBox5.Location = new System.Drawing.Point(128, 241);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(272, 174);
            this.groupBox5.TabIndex = 36;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Эмпирические коэффициенты силы резания";
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Location = new System.Drawing.Point(49, 146);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(27, 13);
            this.label60.TabIndex = 56;
            this.label60.Text = "w = ";
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Location = new System.Drawing.Point(49, 120);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(25, 13);
            this.label61.TabIndex = 55;
            this.label61.Text = "u = ";
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Location = new System.Drawing.Point(49, 94);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(24, 13);
            this.label62.TabIndex = 54;
            this.label62.Text = "y = ";
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Location = new System.Drawing.Point(49, 68);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(24, 13);
            this.label63.TabIndex = 53;
            this.label63.Text = "x = ";
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Location = new System.Drawing.Point(49, 42);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(25, 13);
            this.label64.TabIndex = 52;
            this.label64.Text = "q = ";
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.Location = new System.Drawing.Point(49, 16);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(32, 13);
            this.label65.TabIndex = 51;
            this.label65.Text = "Cp = ";
            // 
            // textBox38
            // 
            this.textBox38.Location = new System.Drawing.Point(96, 143);
            this.textBox38.Name = "textBox38";
            this.textBox38.Size = new System.Drawing.Size(108, 20);
            this.textBox38.TabIndex = 44;
            // 
            // textBox39
            // 
            this.textBox39.Location = new System.Drawing.Point(96, 117);
            this.textBox39.Name = "textBox39";
            this.textBox39.Size = new System.Drawing.Size(108, 20);
            this.textBox39.TabIndex = 43;
            // 
            // textBox40
            // 
            this.textBox40.Location = new System.Drawing.Point(96, 91);
            this.textBox40.Name = "textBox40";
            this.textBox40.Size = new System.Drawing.Size(108, 20);
            this.textBox40.TabIndex = 42;
            // 
            // textBox41
            // 
            this.textBox41.Location = new System.Drawing.Point(96, 65);
            this.textBox41.Name = "textBox41";
            this.textBox41.Size = new System.Drawing.Size(108, 20);
            this.textBox41.TabIndex = 41;
            // 
            // textBox42
            // 
            this.textBox42.Location = new System.Drawing.Point(96, 39);
            this.textBox42.Name = "textBox42";
            this.textBox42.Size = new System.Drawing.Size(108, 20);
            this.textBox42.TabIndex = 37;
            // 
            // textBox43
            // 
            this.textBox43.Location = new System.Drawing.Point(96, 13);
            this.textBox43.Name = "textBox43";
            this.textBox43.Size = new System.Drawing.Size(108, 20);
            this.textBox43.TabIndex = 36;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label51);
            this.groupBox4.Controls.Add(this.label52);
            this.groupBox4.Controls.Add(this.label53);
            this.groupBox4.Controls.Add(this.label54);
            this.groupBox4.Controls.Add(this.label55);
            this.groupBox4.Controls.Add(this.textBox30);
            this.groupBox4.Controls.Add(this.textBox31);
            this.groupBox4.Controls.Add(this.textBox32);
            this.groupBox4.Controls.Add(this.textBox33);
            this.groupBox4.Controls.Add(this.textBox34);
            this.groupBox4.Controls.Add(this.label56);
            this.groupBox4.Controls.Add(this.label57);
            this.groupBox4.Controls.Add(this.textBox35);
            this.groupBox4.Controls.Add(this.textBox36);
            this.groupBox4.Location = new System.Drawing.Point(128, 37);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(272, 198);
            this.groupBox4.TabIndex = 35;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Эмпирические коэффициенты скорости резания";
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(49, 178);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(27, 13);
            this.label51.TabIndex = 50;
            this.label51.Text = "m = ";
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(49, 152);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(25, 13);
            this.label52.TabIndex = 49;
            this.label52.Text = "p = ";
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(49, 126);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(25, 13);
            this.label53.TabIndex = 48;
            this.label53.Text = "u = ";
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(49, 100);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(24, 13);
            this.label54.TabIndex = 47;
            this.label54.Text = "y = ";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(49, 74);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(24, 13);
            this.label55.TabIndex = 46;
            this.label55.Text = "x = ";
            // 
            // textBox30
            // 
            this.textBox30.Location = new System.Drawing.Point(96, 175);
            this.textBox30.Name = "textBox30";
            this.textBox30.Size = new System.Drawing.Size(108, 20);
            this.textBox30.TabIndex = 45;
            // 
            // textBox31
            // 
            this.textBox31.Location = new System.Drawing.Point(96, 149);
            this.textBox31.Name = "textBox31";
            this.textBox31.Size = new System.Drawing.Size(108, 20);
            this.textBox31.TabIndex = 44;
            // 
            // textBox32
            // 
            this.textBox32.Location = new System.Drawing.Point(96, 123);
            this.textBox32.Name = "textBox32";
            this.textBox32.Size = new System.Drawing.Size(108, 20);
            this.textBox32.TabIndex = 43;
            // 
            // textBox33
            // 
            this.textBox33.Location = new System.Drawing.Point(96, 97);
            this.textBox33.Name = "textBox33";
            this.textBox33.Size = new System.Drawing.Size(108, 20);
            this.textBox33.TabIndex = 42;
            // 
            // textBox34
            // 
            this.textBox34.Location = new System.Drawing.Point(96, 71);
            this.textBox34.Name = "textBox34";
            this.textBox34.Size = new System.Drawing.Size(108, 20);
            this.textBox34.TabIndex = 41;
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(49, 48);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(25, 13);
            this.label56.TabIndex = 40;
            this.label56.Text = "q = ";
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Location = new System.Drawing.Point(49, 22);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(32, 13);
            this.label57.TabIndex = 39;
            this.label57.Text = "Cv = ";
            // 
            // textBox35
            // 
            this.textBox35.Location = new System.Drawing.Point(96, 45);
            this.textBox35.Name = "textBox35";
            this.textBox35.Size = new System.Drawing.Size(108, 20);
            this.textBox35.TabIndex = 37;
            // 
            // textBox36
            // 
            this.textBox36.Location = new System.Drawing.Point(96, 19);
            this.textBox36.Name = "textBox36";
            this.textBox36.Size = new System.Drawing.Size(108, 20);
            this.textBox36.TabIndex = 36;
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(8, 381);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(32, 13);
            this.label50.TabIndex = 34;
            this.label50.Text = "Kp = ";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(8, 338);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(32, 13);
            this.label49.TabIndex = 33;
            this.label49.Text = "Kv = ";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(8, 293);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(24, 13);
            this.label48.TabIndex = 32;
            this.label48.Text = "z = ";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(8, 250);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(26, 13);
            this.label47.TabIndex = 31;
            this.label47.Text = "T = ";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(8, 208);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(27, 13);
            this.label46.TabIndex = 30;
            this.label46.Text = "D = ";
            // 
            // textBox29
            // 
            this.textBox29.Location = new System.Drawing.Point(55, 378);
            this.textBox29.Name = "textBox29";
            this.textBox29.Size = new System.Drawing.Size(67, 20);
            this.textBox29.TabIndex = 29;
            // 
            // textBox28
            // 
            this.textBox28.Location = new System.Drawing.Point(55, 335);
            this.textBox28.Name = "textBox28";
            this.textBox28.Size = new System.Drawing.Size(67, 20);
            this.textBox28.TabIndex = 28;
            // 
            // textBox27
            // 
            this.textBox27.Location = new System.Drawing.Point(55, 290);
            this.textBox27.Name = "textBox27";
            this.textBox27.Size = new System.Drawing.Size(67, 20);
            this.textBox27.TabIndex = 27;
            // 
            // textBox26
            // 
            this.textBox26.Location = new System.Drawing.Point(55, 247);
            this.textBox26.Name = "textBox26";
            this.textBox26.Size = new System.Drawing.Size(67, 20);
            this.textBox26.TabIndex = 26;
            // 
            // textBox25
            // 
            this.textBox25.Location = new System.Drawing.Point(55, 205);
            this.textBox25.Name = "textBox25";
            this.textBox25.Size = new System.Drawing.Size(67, 20);
            this.textBox25.TabIndex = 25;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(8, 166);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(31, 13);
            this.label44.TabIndex = 24;
            this.label44.Text = "Sz = ";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(8, 129);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(26, 13);
            this.label38.TabIndex = 23;
            this.label38.Text = "B = ";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(8, 88);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(22, 13);
            this.label29.TabIndex = 22;
            this.label29.Text = "t = ";
            // 
            // textBox24
            // 
            this.textBox24.Location = new System.Drawing.Point(55, 163);
            this.textBox24.Name = "textBox24";
            this.textBox24.Size = new System.Drawing.Size(67, 20);
            this.textBox24.TabIndex = 21;
            // 
            // textBox23
            // 
            this.textBox23.Location = new System.Drawing.Point(55, 126);
            this.textBox23.Name = "textBox23";
            this.textBox23.Size = new System.Drawing.Size(67, 20);
            this.textBox23.TabIndex = 20;
            // 
            // textBox22
            // 
            this.textBox22.Location = new System.Drawing.Point(55, 85);
            this.textBox22.Name = "textBox22";
            this.textBox22.Size = new System.Drawing.Size(67, 20);
            this.textBox22.TabIndex = 19;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label34.Location = new System.Drawing.Point(781, 290);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(31, 17);
            this.label34.TabIndex = 18;
            this.label34.Text = "кВт";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label35.Location = new System.Drawing.Point(781, 215);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(18, 17);
            this.label35.TabIndex = 17;
            this.label35.Text = "Н";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label36.Location = new System.Drawing.Point(781, 150);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(53, 17);
            this.label36.TabIndex = 16;
            this.label36.Text = "об/мин";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label37.Location = new System.Drawing.Point(781, 88);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(27, 17);
            this.label37.TabIndex = 15;
            this.label37.Text = "Нм";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label39.Location = new System.Drawing.Point(781, 40);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(28, 17);
            this.label39.TabIndex = 13;
            this.label39.Text = "м/с";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label33.Location = new System.Drawing.Point(411, 290);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(134, 17);
            this.label33.TabIndex = 12;
            this.label33.Text = "Мощность резания";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label32.Location = new System.Drawing.Point(411, 218);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(100, 17);
            this.label32.TabIndex = 11;
            this.label32.Text = "Сила резания";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label31.Location = new System.Drawing.Point(411, 150);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(133, 17);
            this.label31.TabIndex = 10;
            this.label31.Text = "Частота вращения";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label30.Location = new System.Drawing.Point(411, 88);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(118, 17);
            this.label30.TabIndex = 9;
            this.label30.Text = "Момент резания";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label28.Location = new System.Drawing.Point(411, 40);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(128, 17);
            this.label28.TabIndex = 7;
            this.label28.Text = "Скорость резания";
            // 
            // textBox9Frez
            // 
            this.textBox9Frez.Location = new System.Drawing.Point(708, 290);
            this.textBox9Frez.Name = "textBox9Frez";
            this.textBox9Frez.Size = new System.Drawing.Size(67, 20);
            this.textBox9Frez.TabIndex = 6;
            // 
            // textBox8Frez
            // 
            this.textBox8Frez.Location = new System.Drawing.Point(708, 215);
            this.textBox8Frez.Name = "textBox8Frez";
            this.textBox8Frez.Size = new System.Drawing.Size(67, 20);
            this.textBox8Frez.TabIndex = 5;
            // 
            // textBox7Frez
            // 
            this.textBox7Frez.Location = new System.Drawing.Point(708, 156);
            this.textBox7Frez.Name = "textBox7Frez";
            this.textBox7Frez.Size = new System.Drawing.Size(67, 20);
            this.textBox7Frez.TabIndex = 4;
            // 
            // textBox6Frez
            // 
            this.textBox6Frez.Location = new System.Drawing.Point(708, 88);
            this.textBox6Frez.Name = "textBox6Frez";
            this.textBox6Frez.Size = new System.Drawing.Size(67, 20);
            this.textBox6Frez.TabIndex = 3;
            // 
            // textBox4Frez
            // 
            this.textBox4Frez.Location = new System.Drawing.Point(708, 40);
            this.textBox4Frez.Name = "textBox4Frez";
            this.textBox4Frez.Size = new System.Drawing.Size(67, 20);
            this.textBox4Frez.TabIndex = 1;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "*.txt";
            this.saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*\" ";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 645);
            this.Controls.Add(this.splitContainer1);
            this.MinimumSize = new System.Drawing.Size(672, 338);
            this.Name = "Form1";
            this.Text = "Калькулятор режимов резания";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.tabPage7.ResumeLayout(false);
            this.tabPage8.ResumeLayout(false);
            this.tabPage9.ResumeLayout(false);
            this.tabPage9.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tabControl3.ResumeLayout(false);
            this.tabPage1Frez.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage2Frez.ResumeLayout(false);
            this.tabPage3Frez.ResumeLayout(false);
            this.tabPage4Frez.ResumeLayout(false);
            this.tabPage5Frez.ResumeLayout(false);
            this.tabPage6Frez.ResumeLayout(false);
            this.tabPage7Frez.ResumeLayout(false);
            this.tabPage7Frez.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }


        #endregion
                
        private Grid grid1;
        private Grid grid2;
        private Grid grid3;
        private Grid grid4;
        private Grid grid5;
        private Grid grid6;
        private Grid grid7;
        private Grid grid8;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private TabPage tabPage6;
        private TabPage tabPage7;
        private TabPage tabPage8;
        private TabPage tabPage9;
        public MyCellTracking cellpointer;
        public MyRowTrecking rowpointer;
        public SourceGrid.Cells.Controllers.CustomEvents clickEvent;
        public SourceGrid.Cells.Controllers.CustomEvents CellChangedEvent;
        public SQLiteConnection sqlite_conn;
        public SQLiteCommand sqlite_cmd;
        public SQLiteDataReader sqlite_datareader;
        private ComboBox comboBox1;
        private Button button1;
        private TreeView treeView1;
        private SplitContainer splitContainer1;

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label label20;
        private Label label21;
        private Label label22;

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private TextBox textBox9;
        private TextBox textBox10;
        private TextBox textBox11;
        private TextBox textBox12;
        private TextBox textBox13;
        private TextBox textBox14;
        private TextBox textBox15;
        private TextBox textBox16;
        private TextBox textBox17;
        private TextBox textBox18;
        private TextBox textBox19;
        private TextBox textBox20;
        private TextBox textBox21;

        public int i;
        public Step s1;
        private ArrayList AList;
        private SaveFileDialog saveFileDialog1;
        private TableLayoutPanel tableLayoutPanel1;
        private Button button2;
        private Button button3;

        
        private TabControl tabControl3;
        private TabPage tabPage10;
        private TabPage tabPage11;

        #region Код M
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
        //private System.Windows.Forms.TabControl tabControl3;
        //public SQLiteConnection sqlite_conn;
        //public SQLiteCommand sqlite_cmd;
        //public SQLiteDataReader sqlite_datareader;
        //public MyCellTracking cellpointer;
        //public MyRowTrecking rowpointer;
        //public SourceGrid.Cells.Controllers.CustomEvents clickEvent;
        //public int i;
        public Step_frez s3;
        //private ArrayList AList;
        //private Button button1;
        //private SplitContainer splitContainer1;
        private ComboBox comboBox1Frez;
        private Button button2Frez;
        private TextBox textBox8Frez;
        private TextBox textBox7Frez;
        private TextBox textBox6Frez;
        private TextBox textBox4Frez;
        private TextBox textBox9Frez;
        private TextBox textBox10Frez;
        private Label label7Frez;
        #endregion
        private Button button4;
        private PictureBox pictureBox1;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private Label label27;
        private Label label26;
        private Label label25;
        private Label label24;
        private Label label23;
        private Label label33;
        private Label label32;
        private Label label31;
        private Label label30;
        private Label label28;
        private Label label34;
        private Label label35;
        private Label label36;
        private Label label37;
        private Label label39;
        private Label label40;
        private Label label41;
        private Label label42;
        private Label label43;
        private Label label45;
        private GroupBox groupBox3;
        private Label label58;
        private GroupBox groupBox5;
        private Label label60;
        private Label label61;
        private Label label62;
        private Label label63;
        private Label label64;
        private Label label65;
        private TextBox textBox38;
        private TextBox textBox39;
        private TextBox textBox40;
        private TextBox textBox41;
        private TextBox textBox42;
        private TextBox textBox43;
        private GroupBox groupBox4;
        private Label label51;
        private Label label52;
        private Label label53;
        private Label label54;
        private Label label55;
        private TextBox textBox30;
        private TextBox textBox31;
        private TextBox textBox32;
        private TextBox textBox33;
        private TextBox textBox34;
        private Label label56;
        private Label label57;
        private TextBox textBox35;
        private TextBox textBox36;
        private Label label50;
        private Label label49;
        private Label label48;
        private Label label47;
        private Label label46;
        private TextBox textBox29;
        private TextBox textBox28;
        private TextBox textBox27;
        private TextBox textBox26;
        private TextBox textBox25;
        private Label label44;
        private Label label38;
        private Label label29;
        private TextBox textBox24;
        private TextBox textBox23;
        private TextBox textBox22;
        private PictureBox pictureBox10;
        private PictureBox pictureBox9;
        private PictureBox pictureBox8;
        private PictureBox pictureBox7;
        private PictureBox pictureBox6;
    }
}

