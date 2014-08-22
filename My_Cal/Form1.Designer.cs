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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeView1 = new System.Windows.Forms.TreeView();
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
            this.tabPage20 = new System.Windows.Forms.TabPage();
            this.label59 = new System.Windows.Forms.Label();
            this.label66 = new System.Windows.Forms.Label();
            this.label67 = new System.Windows.Forms.Label();
            this.label68 = new System.Windows.Forms.Label();
            this.label69 = new System.Windows.Forms.Label();
            this.label70 = new System.Windows.Forms.Label();
            this.label71 = new System.Windows.Forms.Label();
            this.label72 = new System.Windows.Forms.Label();
            this.label73 = new System.Windows.Forms.Label();
            this.label74 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label75 = new System.Windows.Forms.Label();
            this.textBox37 = new System.Windows.Forms.TextBox();
            this.label76 = new System.Windows.Forms.Label();
            this.textBox44 = new System.Windows.Forms.TextBox();
            this.label77 = new System.Windows.Forms.Label();
            this.textBox45 = new System.Windows.Forms.TextBox();
            this.label78 = new System.Windows.Forms.Label();
            this.textBox46 = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.textBox47 = new System.Windows.Forms.TextBox();
            this.label79 = new System.Windows.Forms.Label();
            this.label80 = new System.Windows.Forms.Label();
            this.textBox48 = new System.Windows.Forms.TextBox();
            this.label81 = new System.Windows.Forms.Label();
            this.textBox49 = new System.Windows.Forms.TextBox();
            this.label82 = new System.Windows.Forms.Label();
            this.textBox50 = new System.Windows.Forms.TextBox();
            this.textBox51 = new System.Windows.Forms.TextBox();
            this.textBox52 = new System.Windows.Forms.TextBox();
            this.textBox53 = new System.Windows.Forms.TextBox();
            this.textBox54 = new System.Windows.Forms.TextBox();
            this.textBox55 = new System.Windows.Forms.TextBox();
            this.textBox56 = new System.Windows.Forms.TextBox();
            this.textBox57 = new System.Windows.Forms.TextBox();
            this.textBox58 = new System.Windows.Forms.TextBox();
            this.textBox59 = new System.Windows.Forms.TextBox();
            this.textBox60 = new System.Windows.Forms.TextBox();
            this.textBox61 = new System.Windows.Forms.TextBox();
            this.textBox62 = new System.Windows.Forms.TextBox();
            this.textBox63 = new System.Windows.Forms.TextBox();
            this.label83 = new System.Windows.Forms.Label();
            this.label84 = new System.Windows.Forms.Label();
            this.label85 = new System.Windows.Forms.Label();
            this.label86 = new System.Windows.Forms.Label();
            this.label87 = new System.Windows.Forms.Label();
            this.label88 = new System.Windows.Forms.Label();
            this.label89 = new System.Windows.Forms.Label();
            this.label90 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label91 = new System.Windows.Forms.Label();
            this.label92 = new System.Windows.Forms.Label();
            this.label93 = new System.Windows.Forms.Label();
            this.label94 = new System.Windows.Forms.Label();
            this.label95 = new System.Windows.Forms.Label();
            this.label96 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
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
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
            this.textBox9Mill = new System.Windows.Forms.TextBox();
            this.textBox8Mill = new System.Windows.Forms.TextBox();
            this.textBox7Mill = new System.Windows.Forms.TextBox();
            this.textBox6Mill = new System.Windows.Forms.TextBox();
            this.textBox4Mill = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tabPage10 = new System.Windows.Forms.TabPage();
            this.tabPage11 = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menu1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeTurningStepToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeMillingStepToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeDrillStepToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteStepToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage17 = new System.Windows.Forms.TabPage();
            this.grid14 = new SourceGrid.Grid();
            this.tabPage18 = new System.Windows.Forms.TabPage();
            this.grid15 = new SourceGrid.Grid();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl3.SuspendLayout();
            this.tabPage12.SuspendLayout();
            this.tabPage13.SuspendLayout();
            this.tabPage14.SuspendLayout();
            this.tabPage15.SuspendLayout();
            this.tabPage16.SuspendLayout();
            this.tabPage20.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
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
            this.tabControl2.SuspendLayout();
            this.tabPage1Mill.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage2Mill.SuspendLayout();
            this.tabPage3Mill.SuspendLayout();
            this.tabPage4Mill.SuspendLayout();
            this.tabPage5Mill.SuspendLayout();
            this.tabPage6Mill.SuspendLayout();
            this.tabPage7Mill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabPage17.SuspendLayout();
            this.tabPage18.SuspendLayout();
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
            this.splitContainer1.Panel2.Controls.Add(this.tabControl3);
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Panel2.Controls.Add(this.tabControl2);
            this.splitContainer1.Panel2MinSize = 350;
            this.splitContainer1.Size = new System.Drawing.Size(1044, 621);
            this.splitContainer1.SplitterDistance = 194;
            this.splitContainer1.TabIndex = 3;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Margin = new System.Windows.Forms.Padding(2);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(194, 621);
            this.treeView1.TabIndex = 2;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
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
            // tabPage20
            // 
            this.tabPage20.Controls.Add(this.label59);
            this.tabPage20.Controls.Add(this.label66);
            this.tabPage20.Controls.Add(this.label67);
            this.tabPage20.Controls.Add(this.label68);
            this.tabPage20.Controls.Add(this.label69);
            this.tabPage20.Controls.Add(this.label70);
            this.tabPage20.Controls.Add(this.label71);
            this.tabPage20.Controls.Add(this.label72);
            this.tabPage20.Controls.Add(this.label73);
            this.tabPage20.Controls.Add(this.label74);
            this.tabPage20.Controls.Add(this.groupBox6);
            this.tabPage20.Controls.Add(this.groupBox7);
            this.tabPage20.Controls.Add(this.textBox51);
            this.tabPage20.Controls.Add(this.textBox52);
            this.tabPage20.Controls.Add(this.textBox53);
            this.tabPage20.Controls.Add(this.textBox54);
            this.tabPage20.Controls.Add(this.textBox55);
            this.tabPage20.Controls.Add(this.textBox56);
            this.tabPage20.Controls.Add(this.textBox57);
            this.tabPage20.Controls.Add(this.textBox58);
            this.tabPage20.Controls.Add(this.textBox59);
            this.tabPage20.Controls.Add(this.textBox60);
            this.tabPage20.Controls.Add(this.textBox61);
            this.tabPage20.Controls.Add(this.textBox62);
            this.tabPage20.Controls.Add(this.textBox63);
            this.tabPage20.Controls.Add(this.label83);
            this.tabPage20.Controls.Add(this.label84);
            this.tabPage20.Controls.Add(this.label85);
            this.tabPage20.Controls.Add(this.label86);
            this.tabPage20.Controls.Add(this.label87);
            this.tabPage20.Controls.Add(this.label88);
            this.tabPage20.Controls.Add(this.label89);
            this.tabPage20.Controls.Add(this.label90);
            this.tabPage20.Controls.Add(this.button2);
            this.tabPage20.Controls.Add(this.label91);
            this.tabPage20.Controls.Add(this.label92);
            this.tabPage20.Controls.Add(this.label93);
            this.tabPage20.Controls.Add(this.label94);
            this.tabPage20.Controls.Add(this.label95);
            this.tabPage20.Controls.Add(this.label96);
            this.tabPage20.Controls.Add(this.comboBox2);
            this.tabPage20.Controls.Add(this.pictureBox11);
            this.tabPage20.Controls.Add(this.pictureBox12);
            this.tabPage20.Controls.Add(this.pictureBox13);
            this.tabPage20.Controls.Add(this.pictureBox14);
            this.tabPage20.Controls.Add(this.pictureBox15);
            this.tabPage20.Location = new System.Drawing.Point(4, 24);
            this.tabPage20.Name = "tabPage20";
            this.tabPage20.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage20.Size = new System.Drawing.Size(838, 593);
            this.tabPage20.TabIndex = 8;
            this.tabPage20.Text = "Результат";
            this.tabPage20.UseVisualStyleBackColor = true;
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label59.Location = new System.Drawing.Point(716, 481);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(31, 17);
            this.label59.TabIndex = 62;
            this.label59.Text = "кВт";
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label66.Location = new System.Drawing.Point(716, 305);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(18, 17);
            this.label66.TabIndex = 61;
            this.label66.Text = "Н";
            // 
            // label67
            // 
            this.label67.AutoSize = true;
            this.label67.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label67.Location = new System.Drawing.Point(715, 214);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(53, 17);
            this.label67.TabIndex = 60;
            this.label67.Text = "об/мин";
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label68.Location = new System.Drawing.Point(717, 393);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(27, 17);
            this.label68.TabIndex = 59;
            this.label68.Text = "Нм";
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label69.Location = new System.Drawing.Point(716, 124);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(46, 17);
            this.label69.TabIndex = 57;
            this.label69.Text = "м/мин";
            // 
            // label70
            // 
            this.label70.AutoSize = true;
            this.label70.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label70.Location = new System.Drawing.Point(424, 443);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(134, 17);
            this.label70.TabIndex = 56;
            this.label70.Text = "Мощность резания";
            // 
            // label71
            // 
            this.label71.AutoSize = true;
            this.label71.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label71.Location = new System.Drawing.Point(424, 354);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(118, 17);
            this.label71.TabIndex = 55;
            this.label71.Text = "Момент резания";
            // 
            // label72
            // 
            this.label72.AutoSize = true;
            this.label72.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label72.Location = new System.Drawing.Point(424, 264);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(100, 17);
            this.label72.TabIndex = 54;
            this.label72.Text = "Сила резания";
            // 
            // label73
            // 
            this.label73.AutoSize = true;
            this.label73.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label73.Location = new System.Drawing.Point(424, 172);
            this.label73.Name = "label73";
            this.label73.Size = new System.Drawing.Size(133, 17);
            this.label73.TabIndex = 53;
            this.label73.Text = "Частота вращения";
            // 
            // label74
            // 
            this.label74.AutoSize = true;
            this.label74.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label74.Location = new System.Drawing.Point(424, 78);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(128, 17);
            this.label74.TabIndex = 52;
            this.label74.Text = "Скорость резания";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label75);
            this.groupBox6.Controls.Add(this.textBox37);
            this.groupBox6.Controls.Add(this.label76);
            this.groupBox6.Controls.Add(this.textBox44);
            this.groupBox6.Controls.Add(this.label77);
            this.groupBox6.Controls.Add(this.textBox45);
            this.groupBox6.Controls.Add(this.label78);
            this.groupBox6.Controls.Add(this.textBox46);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox6.Location = new System.Drawing.Point(144, 309);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(268, 212);
            this.groupBox6.TabIndex = 47;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Эмпирические коэффициенты силы резания";
            // 
            // label75
            // 
            this.label75.AutoSize = true;
            this.label75.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label75.Location = new System.Drawing.Point(42, 48);
            this.label75.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label75.Name = "label75";
            this.label75.Size = new System.Drawing.Size(33, 17);
            this.label75.TabIndex = 20;
            this.label75.Text = "Cp=";
            // 
            // textBox37
            // 
            this.textBox37.Location = new System.Drawing.Point(82, 48);
            this.textBox37.Margin = new System.Windows.Forms.Padding(2);
            this.textBox37.Name = "textBox37";
            this.textBox37.Size = new System.Drawing.Size(131, 23);
            this.textBox37.TabIndex = 21;
            // 
            // label76
            // 
            this.label76.AutoSize = true;
            this.label76.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label76.Location = new System.Drawing.Point(42, 87);
            this.label76.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label76.Name = "label76";
            this.label76.Size = new System.Drawing.Size(22, 17);
            this.label76.TabIndex = 22;
            this.label76.Text = "x=";
            // 
            // textBox44
            // 
            this.textBox44.Location = new System.Drawing.Point(82, 88);
            this.textBox44.Margin = new System.Windows.Forms.Padding(2);
            this.textBox44.Name = "textBox44";
            this.textBox44.Size = new System.Drawing.Size(131, 23);
            this.textBox44.TabIndex = 23;
            // 
            // label77
            // 
            this.label77.AutoSize = true;
            this.label77.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label77.Location = new System.Drawing.Point(42, 127);
            this.label77.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label77.Name = "label77";
            this.label77.Size = new System.Drawing.Size(23, 17);
            this.label77.TabIndex = 24;
            this.label77.Text = "y=";
            // 
            // textBox45
            // 
            this.textBox45.Location = new System.Drawing.Point(82, 128);
            this.textBox45.Margin = new System.Windows.Forms.Padding(2);
            this.textBox45.Name = "textBox45";
            this.textBox45.Size = new System.Drawing.Size(131, 23);
            this.textBox45.TabIndex = 25;
            // 
            // label78
            // 
            this.label78.AutoSize = true;
            this.label78.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label78.Location = new System.Drawing.Point(42, 167);
            this.label78.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label78.Name = "label78";
            this.label78.Size = new System.Drawing.Size(24, 17);
            this.label78.TabIndex = 26;
            this.label78.Text = "n=";
            // 
            // textBox46
            // 
            this.textBox46.Location = new System.Drawing.Point(82, 167);
            this.textBox46.Margin = new System.Windows.Forms.Padding(2);
            this.textBox46.Name = "textBox46";
            this.textBox46.Size = new System.Drawing.Size(131, 23);
            this.textBox46.TabIndex = 27;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.textBox47);
            this.groupBox7.Controls.Add(this.label79);
            this.groupBox7.Controls.Add(this.label80);
            this.groupBox7.Controls.Add(this.textBox48);
            this.groupBox7.Controls.Add(this.label81);
            this.groupBox7.Controls.Add(this.textBox49);
            this.groupBox7.Controls.Add(this.label82);
            this.groupBox7.Controls.Add(this.textBox50);
            this.groupBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox7.Location = new System.Drawing.Point(144, 75);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(268, 219);
            this.groupBox7.TabIndex = 46;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Эмпирические коэффициенты скорости резания";
            // 
            // textBox47
            // 
            this.textBox47.Location = new System.Drawing.Point(82, 53);
            this.textBox47.Margin = new System.Windows.Forms.Padding(2);
            this.textBox47.Name = "textBox47";
            this.textBox47.Size = new System.Drawing.Size(131, 23);
            this.textBox47.TabIndex = 13;
            // 
            // label79
            // 
            this.label79.AutoSize = true;
            this.label79.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label79.Location = new System.Drawing.Point(42, 52);
            this.label79.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label79.Name = "label79";
            this.label79.Size = new System.Drawing.Size(32, 17);
            this.label79.TabIndex = 12;
            this.label79.Text = "Cv=";
            // 
            // label80
            // 
            this.label80.AutoSize = true;
            this.label80.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label80.Location = new System.Drawing.Point(42, 92);
            this.label80.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label80.Name = "label80";
            this.label80.Size = new System.Drawing.Size(22, 17);
            this.label80.TabIndex = 14;
            this.label80.Text = "x=";
            // 
            // textBox48
            // 
            this.textBox48.Location = new System.Drawing.Point(82, 93);
            this.textBox48.Margin = new System.Windows.Forms.Padding(2);
            this.textBox48.Name = "textBox48";
            this.textBox48.Size = new System.Drawing.Size(131, 23);
            this.textBox48.TabIndex = 15;
            // 
            // label81
            // 
            this.label81.AutoSize = true;
            this.label81.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label81.Location = new System.Drawing.Point(42, 132);
            this.label81.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label81.Name = "label81";
            this.label81.Size = new System.Drawing.Size(23, 17);
            this.label81.TabIndex = 16;
            this.label81.Text = "y=";
            // 
            // textBox49
            // 
            this.textBox49.Location = new System.Drawing.Point(82, 133);
            this.textBox49.Margin = new System.Windows.Forms.Padding(2);
            this.textBox49.Name = "textBox49";
            this.textBox49.Size = new System.Drawing.Size(131, 23);
            this.textBox49.TabIndex = 17;
            // 
            // label82
            // 
            this.label82.AutoSize = true;
            this.label82.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label82.Location = new System.Drawing.Point(42, 172);
            this.label82.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label82.Name = "label82";
            this.label82.Size = new System.Drawing.Size(27, 17);
            this.label82.TabIndex = 18;
            this.label82.Text = "m=";
            // 
            // textBox50
            // 
            this.textBox50.Location = new System.Drawing.Point(82, 172);
            this.textBox50.Margin = new System.Windows.Forms.Padding(2);
            this.textBox50.Name = "textBox50";
            this.textBox50.Size = new System.Drawing.Size(131, 23);
            this.textBox50.TabIndex = 19;
            // 
            // textBox51
            // 
            this.textBox51.Location = new System.Drawing.Point(623, 481);
            this.textBox51.Margin = new System.Windows.Forms.Padding(2);
            this.textBox51.Name = "textBox51";
            this.textBox51.Size = new System.Drawing.Size(87, 20);
            this.textBox51.TabIndex = 44;
            // 
            // textBox52
            // 
            this.textBox52.Location = new System.Drawing.Point(623, 393);
            this.textBox52.Margin = new System.Windows.Forms.Padding(2);
            this.textBox52.Name = "textBox52";
            this.textBox52.Size = new System.Drawing.Size(87, 20);
            this.textBox52.TabIndex = 42;
            // 
            // textBox53
            // 
            this.textBox53.Location = new System.Drawing.Point(623, 304);
            this.textBox53.Margin = new System.Windows.Forms.Padding(2);
            this.textBox53.Name = "textBox53";
            this.textBox53.Size = new System.Drawing.Size(87, 20);
            this.textBox53.TabIndex = 40;
            // 
            // textBox54
            // 
            this.textBox54.Location = new System.Drawing.Point(623, 215);
            this.textBox54.Margin = new System.Windows.Forms.Padding(2);
            this.textBox54.Name = "textBox54";
            this.textBox54.Size = new System.Drawing.Size(87, 20);
            this.textBox54.TabIndex = 38;
            // 
            // textBox55
            // 
            this.textBox55.Location = new System.Drawing.Point(623, 124);
            this.textBox55.Margin = new System.Windows.Forms.Padding(2);
            this.textBox55.Name = "textBox55";
            this.textBox55.Size = new System.Drawing.Size(87, 20);
            this.textBox55.TabIndex = 36;
            // 
            // textBox56
            // 
            this.textBox56.Location = new System.Drawing.Point(613, 14);
            this.textBox56.Margin = new System.Windows.Forms.Padding(2);
            this.textBox56.Name = "textBox56";
            this.textBox56.Size = new System.Drawing.Size(131, 20);
            this.textBox56.TabIndex = 34;
            // 
            // textBox57
            // 
            this.textBox57.Location = new System.Drawing.Point(57, 430);
            this.textBox57.Margin = new System.Windows.Forms.Padding(2);
            this.textBox57.Name = "textBox57";
            this.textBox57.Size = new System.Drawing.Size(67, 20);
            this.textBox57.TabIndex = 32;
            // 
            // textBox58
            // 
            this.textBox58.Location = new System.Drawing.Point(57, 501);
            this.textBox58.Margin = new System.Windows.Forms.Padding(2);
            this.textBox58.Name = "textBox58";
            this.textBox58.Size = new System.Drawing.Size(67, 20);
            this.textBox58.TabIndex = 30;
            // 
            // textBox59
            // 
            this.textBox59.Location = new System.Drawing.Point(57, 359);
            this.textBox59.Margin = new System.Windows.Forms.Padding(2);
            this.textBox59.Name = "textBox59";
            this.textBox59.Size = new System.Drawing.Size(67, 20);
            this.textBox59.TabIndex = 11;
            // 
            // textBox60
            // 
            this.textBox60.Location = new System.Drawing.Point(57, 288);
            this.textBox60.Margin = new System.Windows.Forms.Padding(2);
            this.textBox60.Name = "textBox60";
            this.textBox60.Size = new System.Drawing.Size(67, 20);
            this.textBox60.TabIndex = 9;
            // 
            // textBox61
            // 
            this.textBox61.Location = new System.Drawing.Point(57, 217);
            this.textBox61.Margin = new System.Windows.Forms.Padding(2);
            this.textBox61.Name = "textBox61";
            this.textBox61.Size = new System.Drawing.Size(67, 20);
            this.textBox61.TabIndex = 7;
            // 
            // textBox62
            // 
            this.textBox62.Location = new System.Drawing.Point(57, 146);
            this.textBox62.Margin = new System.Windows.Forms.Padding(2);
            this.textBox62.Name = "textBox62";
            this.textBox62.Size = new System.Drawing.Size(67, 20);
            this.textBox62.TabIndex = 5;
            // 
            // textBox63
            // 
            this.textBox63.Location = new System.Drawing.Point(57, 75);
            this.textBox63.Margin = new System.Windows.Forms.Padding(2);
            this.textBox63.Name = "textBox63";
            this.textBox63.Size = new System.Drawing.Size(67, 20);
            this.textBox63.TabIndex = 3;
            // 
            // label83
            // 
            this.label83.AutoSize = true;
            this.label83.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label83.Location = new System.Drawing.Point(601, 483);
            this.label83.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label83.Name = "label83";
            this.label83.Size = new System.Drawing.Size(16, 17);
            this.label83.TabIndex = 43;
            this.label83.Text = "=";
            // 
            // label84
            // 
            this.label84.AutoSize = true;
            this.label84.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label84.Location = new System.Drawing.Point(601, 395);
            this.label84.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label84.Name = "label84";
            this.label84.Size = new System.Drawing.Size(16, 17);
            this.label84.TabIndex = 41;
            this.label84.Text = "=";
            // 
            // label85
            // 
            this.label85.AutoSize = true;
            this.label85.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label85.Location = new System.Drawing.Point(601, 306);
            this.label85.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label85.Name = "label85";
            this.label85.Size = new System.Drawing.Size(16, 17);
            this.label85.TabIndex = 39;
            this.label85.Text = "=";
            // 
            // label86
            // 
            this.label86.AutoSize = true;
            this.label86.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label86.Location = new System.Drawing.Point(601, 217);
            this.label86.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label86.Name = "label86";
            this.label86.Size = new System.Drawing.Size(16, 17);
            this.label86.TabIndex = 37;
            this.label86.Text = "=";
            // 
            // label87
            // 
            this.label87.AutoSize = true;
            this.label87.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label87.Location = new System.Drawing.Point(601, 126);
            this.label87.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label87.Name = "label87";
            this.label87.Size = new System.Drawing.Size(16, 17);
            this.label87.TabIndex = 35;
            this.label87.Text = "=";
            // 
            // label88
            // 
            this.label88.AutoSize = true;
            this.label88.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label88.Location = new System.Drawing.Point(432, 12);
            this.label88.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label88.Name = "label88";
            this.label88.Size = new System.Drawing.Size(182, 17);
            this.label88.TabIndex = 33;
            this.label88.Text = "Введите диаметр детали=";
            // 
            // label89
            // 
            this.label89.AutoSize = true;
            this.label89.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label89.Location = new System.Drawing.Point(8, 430);
            this.label89.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label89.Name = "label89";
            this.label89.Size = new System.Drawing.Size(44, 17);
            this.label89.TabIndex = 31;
            this.label89.Text = "Kmp=";
            // 
            // label90
            // 
            this.label90.AutoSize = true;
            this.label90.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label90.Location = new System.Drawing.Point(18, 501);
            this.label90.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label90.Name = "label90";
            this.label90.Size = new System.Drawing.Size(25, 17);
            this.label90.TabIndex = 29;
            this.label90.Text = "T=";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(613, 40);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 33);
            this.button2.TabIndex = 28;
            this.button2.Text = "Расчитать";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label91
            // 
            this.label91.AutoSize = true;
            this.label91.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label91.Location = new System.Drawing.Point(13, 359);
            this.label91.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label91.Name = "label91";
            this.label91.Size = new System.Drawing.Size(40, 17);
            this.label91.TabIndex = 10;
            this.label91.Text = "Kиv=";
            // 
            // label92
            // 
            this.label92.AutoSize = true;
            this.label92.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label92.Location = new System.Drawing.Point(10, 288);
            this.label92.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label92.Name = "label92";
            this.label92.Size = new System.Drawing.Size(40, 17);
            this.label92.TabIndex = 8;
            this.label92.Text = "Kпv=";
            // 
            // label93
            // 
            this.label93.AutoSize = true;
            this.label93.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label93.Location = new System.Drawing.Point(9, 217);
            this.label93.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label93.Name = "label93";
            this.label93.Size = new System.Drawing.Size(43, 17);
            this.label93.TabIndex = 6;
            this.label93.Text = "Kmv=";
            // 
            // label94
            // 
            this.label94.AutoSize = true;
            this.label94.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label94.Location = new System.Drawing.Point(19, 146);
            this.label94.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label94.Name = "label94";
            this.label94.Size = new System.Drawing.Size(23, 17);
            this.label94.TabIndex = 4;
            this.label94.Text = "s=";
            // 
            // label95
            // 
            this.label95.AutoSize = true;
            this.label95.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label95.Location = new System.Drawing.Point(20, 75);
            this.label95.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label95.Name = "label95";
            this.label95.Size = new System.Drawing.Size(20, 17);
            this.label95.TabIndex = 2;
            this.label95.Text = "t=";
            // 
            // label96
            // 
            this.label96.AutoSize = true;
            this.label96.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label96.Location = new System.Drawing.Point(5, 13);
            this.label96.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label96.Name = "label96";
            this.label96.Size = new System.Drawing.Size(257, 17);
            this.label96.TabIndex = 1;
            this.label96.Text = "Выбирете период стойкости резца T:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "20",
            "30",
            "40",
            "60",
            "90",
            "120"});
            this.comboBox2.Location = new System.Drawing.Point(265, 14);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(147, 21);
            this.comboBox2.TabIndex = 0;
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = global::My_Cal.Properties.Resources.N__2_;
            this.pictureBox11.Location = new System.Drawing.Point(427, 473);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(169, 49);
            this.pictureBox11.TabIndex = 51;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox12
            // 
            this.pictureBox12.Image = global::My_Cal.Properties.Resources.M;
            this.pictureBox12.Location = new System.Drawing.Point(427, 388);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(169, 43);
            this.pictureBox12.TabIndex = 50;
            this.pictureBox12.TabStop = false;
            // 
            // pictureBox13
            // 
            this.pictureBox13.Image = global::My_Cal.Properties.Resources.Pz;
            this.pictureBox13.Location = new System.Drawing.Point(427, 302);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(169, 35);
            this.pictureBox13.TabIndex = 49;
            this.pictureBox13.TabStop = false;
            // 
            // pictureBox14
            // 
            this.pictureBox14.Image = global::My_Cal.Properties.Resources.n;
            this.pictureBox14.Location = new System.Drawing.Point(427, 205);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(169, 50);
            this.pictureBox14.TabIndex = 48;
            this.pictureBox14.TabStop = false;
            // 
            // pictureBox15
            // 
            this.pictureBox15.Image = global::My_Cal.Properties.Resources.V;
            this.pictureBox15.Location = new System.Drawing.Point(427, 112);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(169, 54);
            this.pictureBox15.TabIndex = 45;
            this.pictureBox15.TabStop = false;
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
            this.tabPage9.Controls.Add(this.textBox20);
            this.tabPage9.Controls.Add(this.textBox19);
            this.tabPage9.Controls.Add(this.textBox18);
            this.tabPage9.Controls.Add(this.textBox17);
            this.tabPage9.Controls.Add(this.textBox16);
            this.tabPage9.Controls.Add(this.textBox15);
            this.tabPage9.Controls.Add(this.textBox14);
            this.tabPage9.Controls.Add(this.textBox5);
            this.tabPage9.Controls.Add(this.textBox4);
            this.tabPage9.Controls.Add(this.textBox3);
            this.tabPage9.Controls.Add(this.textBox2);
            this.tabPage9.Controls.Add(this.textBox1);
            this.tabPage9.Controls.Add(this.label22);
            this.tabPage9.Controls.Add(this.label21);
            this.tabPage9.Controls.Add(this.label20);
            this.tabPage9.Controls.Add(this.label19);
            this.tabPage9.Controls.Add(this.label18);
            this.tabPage9.Controls.Add(this.label17);
            this.tabPage9.Controls.Add(this.label16);
            this.tabPage9.Controls.Add(this.label15);
            this.tabPage9.Controls.Add(this.button1);
            this.tabPage9.Controls.Add(this.label6);
            this.tabPage9.Controls.Add(this.label5);
            this.tabPage9.Controls.Add(this.label4);
            this.tabPage9.Controls.Add(this.label3);
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
            this.tabPage9.Size = new System.Drawing.Size(838, 593);
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
            // textBox20
            // 
            this.textBox20.Location = new System.Drawing.Point(623, 393);
            this.textBox20.Margin = new System.Windows.Forms.Padding(2);
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new System.Drawing.Size(87, 20);
            this.textBox20.TabIndex = 42;
            // 
            // textBox19
            // 
            this.textBox19.Location = new System.Drawing.Point(623, 304);
            this.textBox19.Margin = new System.Windows.Forms.Padding(2);
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new System.Drawing.Size(87, 20);
            this.textBox19.TabIndex = 40;
            // 
            // textBox18
            // 
            this.textBox18.Location = new System.Drawing.Point(623, 215);
            this.textBox18.Margin = new System.Windows.Forms.Padding(2);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(87, 20);
            this.textBox18.TabIndex = 38;
            // 
            // textBox17
            // 
            this.textBox17.Location = new System.Drawing.Point(623, 124);
            this.textBox17.Margin = new System.Windows.Forms.Padding(2);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(87, 20);
            this.textBox17.TabIndex = 36;
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
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(57, 430);
            this.textBox15.Margin = new System.Windows.Forms.Padding(2);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(67, 20);
            this.textBox15.TabIndex = 32;
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(57, 501);
            this.textBox14.Margin = new System.Windows.Forms.Padding(2);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(67, 20);
            this.textBox14.TabIndex = 30;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(57, 359);
            this.textBox5.Margin = new System.Windows.Forms.Padding(2);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(67, 20);
            this.textBox5.TabIndex = 11;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(57, 288);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(67, 20);
            this.textBox4.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(57, 217);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(67, 20);
            this.textBox3.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(57, 146);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(67, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(57, 75);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(67, 20);
            this.textBox1.TabIndex = 3;
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
            this.groupBox3.Size = new System.Drawing.Size(445, 277);
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
            this.button2Mill.Location = new System.Drawing.Point(280, 233);
            this.button2Mill.Name = "button2Mill";
            this.button2Mill.Size = new System.Drawing.Size(75, 23);
            this.button2Mill.TabIndex = 9;
            this.button2Mill.Text = "Ввод данных";
            this.button2Mill.UseVisualStyleBackColor = true;
            this.button2Mill.Click += new System.EventHandler(this.button2Mill_Click);
            // 
            // label7Mill
            // 
            this.label7Mill.AutoSize = true;
            this.label7Mill.Location = new System.Drawing.Point(277, 24);
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
            this.comboBox1Mill.Location = new System.Drawing.Point(280, 48);
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
            this.tabPage7Mill.Controls.Add(this.pictureBox10);
            this.tabPage7Mill.Controls.Add(this.pictureBox9);
            this.tabPage7Mill.Controls.Add(this.pictureBox8);
            this.tabPage7Mill.Controls.Add(this.pictureBox7);
            this.tabPage7Mill.Controls.Add(this.pictureBox6);
            this.tabPage7Mill.Controls.Add(this.label58);
            this.tabPage7Mill.Controls.Add(this.groupBox5);
            this.tabPage7Mill.Controls.Add(this.groupBox4);
            this.tabPage7Mill.Controls.Add(this.label50);
            this.tabPage7Mill.Controls.Add(this.label49);
            this.tabPage7Mill.Controls.Add(this.label48);
            this.tabPage7Mill.Controls.Add(this.label47);
            this.tabPage7Mill.Controls.Add(this.label46);
            this.tabPage7Mill.Controls.Add(this.textBox29);
            this.tabPage7Mill.Controls.Add(this.textBox28);
            this.tabPage7Mill.Controls.Add(this.textBox27);
            this.tabPage7Mill.Controls.Add(this.textBox26);
            this.tabPage7Mill.Controls.Add(this.textBox25);
            this.tabPage7Mill.Controls.Add(this.label44);
            this.tabPage7Mill.Controls.Add(this.label38);
            this.tabPage7Mill.Controls.Add(this.label29);
            this.tabPage7Mill.Controls.Add(this.textBox24);
            this.tabPage7Mill.Controls.Add(this.textBox23);
            this.tabPage7Mill.Controls.Add(this.textBox22);
            this.tabPage7Mill.Controls.Add(this.label34);
            this.tabPage7Mill.Controls.Add(this.label35);
            this.tabPage7Mill.Controls.Add(this.label36);
            this.tabPage7Mill.Controls.Add(this.label37);
            this.tabPage7Mill.Controls.Add(this.label39);
            this.tabPage7Mill.Controls.Add(this.label33);
            this.tabPage7Mill.Controls.Add(this.label32);
            this.tabPage7Mill.Controls.Add(this.label31);
            this.tabPage7Mill.Controls.Add(this.label30);
            this.tabPage7Mill.Controls.Add(this.label28);
            this.tabPage7Mill.Controls.Add(this.textBox9Mill);
            this.tabPage7Mill.Controls.Add(this.textBox8Mill);
            this.tabPage7Mill.Controls.Add(this.textBox7Mill);
            this.tabPage7Mill.Controls.Add(this.textBox6Mill);
            this.tabPage7Mill.Controls.Add(this.textBox4Mill);
            this.tabPage7Mill.Location = new System.Drawing.Point(4, 22);
            this.tabPage7Mill.Name = "tabPage7Mill";
            this.tabPage7Mill.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7Mill.Size = new System.Drawing.Size(838, 595);
            this.tabPage7Mill.TabIndex = 6;
            this.tabPage7Mill.Text = "Результат";
            this.tabPage7Mill.UseVisualStyleBackColor = true;
            this.tabPage7Mill.Enter += new System.EventHandler(this.tabPage7Mill_Enter);
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::My_Cal.Properties.Resources.NN_Mill;
            this.pictureBox10.Location = new System.Drawing.Point(545, 285);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(85, 37);
            this.pictureBox10.TabIndex = 42;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::My_Cal.Properties.Resources.Pz_Mill;
            this.pictureBox9.Location = new System.Drawing.Point(545, 205);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(137, 49);
            this.pictureBox9.TabIndex = 41;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::My_Cal.Properties.Resources.n_Mill;
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
            this.pictureBox6.Image = global::My_Cal.Properties.Resources.V_Mill;
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
            // textBox9Mill
            // 
            this.textBox9Mill.Location = new System.Drawing.Point(708, 290);
            this.textBox9Mill.Name = "textBox9Mill";
            this.textBox9Mill.Size = new System.Drawing.Size(67, 20);
            this.textBox9Mill.TabIndex = 6;
            // 
            // textBox8Mill
            // 
            this.textBox8Mill.Location = new System.Drawing.Point(708, 215);
            this.textBox8Mill.Name = "textBox8Mill";
            this.textBox8Mill.Size = new System.Drawing.Size(67, 20);
            this.textBox8Mill.TabIndex = 5;
            // 
            // textBox7Mill
            // 
            this.textBox7Mill.Location = new System.Drawing.Point(708, 156);
            this.textBox7Mill.Name = "textBox7Mill";
            this.textBox7Mill.Size = new System.Drawing.Size(67, 20);
            this.textBox7Mill.TabIndex = 4;
            // 
            // textBox6Mill
            // 
            this.textBox6Mill.Location = new System.Drawing.Point(708, 88);
            this.textBox6Mill.Name = "textBox6Mill";
            this.textBox6Mill.Size = new System.Drawing.Size(67, 20);
            this.textBox6Mill.TabIndex = 3;
            // 
            // textBox4Mill
            // 
            this.textBox4Mill.Location = new System.Drawing.Point(708, 40);
            this.textBox4Mill.Name = "textBox4Mill";
            this.textBox4Mill.Size = new System.Drawing.Size(67, 20);
            this.textBox4Mill.TabIndex = 1;
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
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu1ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1044, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menu1ToolStripMenuItem
            // 
            this.menu1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.makeTurningStepToolStripMenuItem,
            this.makeMillingStepToolStripMenuItem,
            this.makeDrillStepToolStripMenuItem,
            this.deleteStepToolStripMenuItem,
            this.makeReportToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menu1ToolStripMenuItem.Name = "menu1ToolStripMenuItem";
            this.menu1ToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.menu1ToolStripMenuItem.Text = "Действие";
            this.menu1ToolStripMenuItem.Click += new System.EventHandler(this.menu1ToolStripMenuItem_Click);
            // 
            // makeTurningStepToolStripMenuItem
            // 
            this.makeTurningStepToolStripMenuItem.Name = "makeTurningStepToolStripMenuItem";
            this.makeTurningStepToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.makeTurningStepToolStripMenuItem.Text = "Создать токарный переход";
            this.makeTurningStepToolStripMenuItem.Click += new System.EventHandler(this.makeTurningStepToolStripMenuItem_Click);
            // 
            // makeMillingStepToolStripMenuItem
            // 
            this.makeMillingStepToolStripMenuItem.Name = "makeMillingStepToolStripMenuItem";
            this.makeMillingStepToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.makeMillingStepToolStripMenuItem.Text = "Создать фрезернный переход";
            this.makeMillingStepToolStripMenuItem.Click += new System.EventHandler(this.makeMillStepToolStripMenuItem_Click);
            // 
            // makeDrillStepToolStripMenuItem
            // 
            this.makeDrillStepToolStripMenuItem.Name = "makeDrillStepToolStripMenuItem";
            this.makeDrillStepToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.makeDrillStepToolStripMenuItem.Text = "Создать сверлильный переход";
            this.makeDrillStepToolStripMenuItem.Click += new System.EventHandler(this.создатьСверлильныйПереходToolStripMenuItem_Click);
            // 
            // deleteStepToolStripMenuItem
            // 
            this.deleteStepToolStripMenuItem.Name = "deleteStepToolStripMenuItem";
            this.deleteStepToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.deleteStepToolStripMenuItem.Text = "Удалить выбранный переход";
            this.deleteStepToolStripMenuItem.Click += new System.EventHandler(this.deleteStepToolStripMenuItem_Click);
            // 
            // makeReportToolStripMenuItem
            // 
            this.makeReportToolStripMenuItem.Name = "makeReportToolStripMenuItem";
            this.makeReportToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.makeReportToolStripMenuItem.Text = "Создать отчет";
            this.makeReportToolStripMenuItem.Click += new System.EventHandler(this.makeReportToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.exitToolStripMenuItem.Text = "Выход";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
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
            this.tabControl3.ResumeLayout(false);
            this.tabPage12.ResumeLayout(false);
            this.tabPage13.ResumeLayout(false);
            this.tabPage14.ResumeLayout(false);
            this.tabPage15.ResumeLayout(false);
            this.tabPage16.ResumeLayout(false);
            this.tabPage20.ResumeLayout(false);
            this.tabPage20.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
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
            this.tabControl2.ResumeLayout(false);
            this.tabPage1Mill.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage2Mill.ResumeLayout(false);
            this.tabPage3Mill.ResumeLayout(false);
            this.tabPage4Mill.ResumeLayout(false);
            this.tabPage5Mill.ResumeLayout(false);
            this.tabPage6Mill.ResumeLayout(false);
            this.tabPage7Mill.ResumeLayout(false);
            this.tabPage7Mill.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabPage17.ResumeLayout(false);
            this.tabPage18.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public MyCellTracking cellpointer;
        public MyRowTrecking rowpointer;
        public SourceGrid.Cells.Controllers.CustomEvents clickEvent;
        public SourceGrid.Cells.Controllers.CustomEvents CellChangedEvent;
        public SQLiteConnection sqlite_conn;
        public SQLiteCommand sqlite_cmd;
        public SQLiteDataReader sqlite_datareader;
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
        private TextBox textBox8Mill;
        private TextBox textBox7Mill;
        private TextBox textBox6Mill;
        private TextBox textBox4Mill;
        private TextBox textBox9Mill;
        private TextBox textBox10Mill;
        private Label label7Mill;
        #endregion

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
        private Label label40;
        private Label label41;
        private Label label42;
        private Label label43;
        private Label label45;
        private Label label27;
        private Label label26;
        private Label label25;
        private Label label24;
        private Label label23;
        private GroupBox groupBox2;
        private Label label14;
        private TextBox textBox10;
        private Label label13;
        private TextBox textBox11;
        private Label label12;
        private TextBox textBox12;
        private Label label11;
        private TextBox textBox13;
        private GroupBox groupBox1;
        private TextBox textBox6;
        private Label label7;
        private Label label8;
        private TextBox textBox7;
        private Label label9;
        private TextBox textBox8;
        private Label label10;
        private TextBox textBox9;
        private TextBox textBox21;
        private TextBox textBox20;
        private TextBox textBox19;
        private TextBox textBox18;
        private TextBox textBox17;
        private TextBox textBox16;
        private TextBox textBox15;
        private TextBox textBox14;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label22;
        private Label label21;
        private Label label20;
        private Label label19;
        private Label label18;
        private Label label17;
        private Label label16;
        private Label label15;
        private Button button1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox comboBox1;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menu1ToolStripMenuItem;
        private ToolStripMenuItem makeTurningStepToolStripMenuItem;
        private ToolStripMenuItem makeMillingStepToolStripMenuItem;
        private ToolStripMenuItem makeReportToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private TreeView treeView1;
        private ToolStripMenuItem deleteStepToolStripMenuItem;
        private ToolStripMenuItem makeDrillStepToolStripMenuItem;
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
        private Label label59;
        private Label label66;
        private Label label67;
        private Label label68;
        private Label label69;
        private Label label70;
        private Label label71;
        private Label label72;
        private Label label73;
        private Label label74;
        private GroupBox groupBox6;
        private Label label75;
        private TextBox textBox37;
        private Label label76;
        private TextBox textBox44;
        private Label label77;
        private TextBox textBox45;
        private Label label78;
        private TextBox textBox46;
        private GroupBox groupBox7;
        private TextBox textBox47;
        private Label label79;
        private Label label80;
        private TextBox textBox48;
        private Label label81;
        private TextBox textBox49;
        private Label label82;
        private TextBox textBox50;
        private TextBox textBox51;
        private TextBox textBox52;
        private TextBox textBox53;
        private TextBox textBox54;
        private TextBox textBox55;
        private TextBox textBox56;
        private TextBox textBox57;
        private TextBox textBox58;
        private TextBox textBox59;
        private TextBox textBox60;
        private TextBox textBox61;
        private TextBox textBox62;
        private TextBox textBox63;
        private Label label83;
        private Label label84;
        private Label label85;
        private Label label86;
        private Label label87;
        private Label label88;
        private Label label89;
        private Label label90;
        private Button button2;
        private Label label91;
        private Label label92;
        private Label label93;
        private Label label94;
        private Label label95;
        private Label label96;
        private ComboBox comboBox2;
        private PictureBox pictureBox11;
        private PictureBox pictureBox12;
        private PictureBox pictureBox13;
        private PictureBox pictureBox14;
        private PictureBox pictureBox15;
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
    }
}

