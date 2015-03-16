<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SourceGrid;
using System.Data.SQLite;
using SourceGrid.Selection;
using System.Collections;
using System.IO;
using System.Diagnostics;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;



namespace My_Cal
{
    public partial class Form1 : Form
    {

        static TurningStep ts;
        static MillingStep ms;
        static DrillingStep ds;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CustomInitialization();
            DoFullTab1();
            DoFullTab2();
            DoFullTab3();
            DoFullTab4();
            DoFullTab5();
            DoFullTab6();
            DoFullTab7();
            DoFullTab8();
            DoFullRusultTab1_Turning();
            DoFullResultTab2_Turning();
            tabControl1.Visible = false;
            DoFullTab1_Mill();
            DoFullTab2_Mill();
            DoFullTab3_Mill();
            DoFullTab4_Mill();
            DoFullTab5_Mill();
            DoFullRusultTab1_Milling();
            DoFullResultTab2_Milling();
            tabControl2.Visible = false;
            DoFullTab1_Drill();
            DoFullTab2_Drill();
            DoFullTab3_Drill();
            DoFullTab4_Drill();
            DoFullTab5_Drill();
            DoFullTab6_Drill();
            DoFullTab7_Drill();
            DoFullRusultTab1_Drill();
            DoFullResultTab2_Drill();
            tabControl3.Visible = false;
            #region Изменение шрифта
            foreach (Control contr in this.Controls)
            {
                contr.Font = new Font("Microsoft Sans Serif", 10);
            }
            foreach (TabPage page in tabControl1.Controls)
            {
                foreach (Control grid in page.Controls)
                    grid.Font = new Font("Microsoft Sans Serif", 12);
            }
            foreach (TabPage page in tabControl2.Controls)
            {
                foreach (Control grid in page.Controls)
                    grid.Font = new Font("Microsoft Sans Serif", 12);
            }
            foreach (TabPage page in tabControl3.Controls)
            {
                foreach (Control grid in page.Controls)
                    grid.Font = new Font("Microsoft Sans Serif", 12);
            }
            this.tabControl2.Font = new Font("Microsoft Sans Serif", 8);
            #endregion
        }
        private void CustomInitialization()
        {
            i = 0;
            stepList = new ArrayList();//список переходов
            cellpointer = new MyCellTracking();
            rowpointer = new MyRowTrecking();
            clickEvent = new SourceGrid.Cells.Controllers.CustomEvents();
            clickEvent.Click += new EventHandler(clickEvent_Click);
            // Для резьбы
            CellChangedEvent_rezba = new SourceGrid.Cells.Controllers.CustomEvents();
            CellChangedEvent_rezba.EditEnded += new EventHandler(CellEvent_Changed_rezba);
            // Для вкладки результат 
            CellChangedEvent = new SourceGrid.Cells.Controllers.CustomEvents();
            CellChangedEvent.EditEnded += new EventHandler(CellEvent_Changed);

            foreach (SourceGrid.Grid GRID in tabControl1.Controls.Find("grid", true))//выставить выравнивание по центру для всех ячеек
            {
                for (int r = 0; r < GRID.Rows.Count; r++)
                {
                    for (int c = 0; c < GRID.Columns.Count; c++)
                    {
                        GRID.GetCell(new Position(r, c)).View.TextAlignment = DevAge.Drawing.ContentAlignment.MiddleCenter;
                    }
                }
            }
        }
        // TODO написать отдельный метод соединения с БД
        #region DuFullTab
        private void DoFullTab1()
        {
            SQLreader sqlReader = new SQLreader("database.sqlite");
            SQLiteDataReader sqlite_datareader = sqlReader.getReader("external_turning");
            #region Код таблицы 1 (Наружнее точение)
            grid1.BorderStyle = BorderStyle.FixedSingle;
            grid1.Redim(14, 4);
            grid1.Rows.Insert(0);
            SourceGrid.Cells.Views.Cell viewImage = new SourceGrid.Cells.Views.Cell();
            grid1[0, 0] = new SourceGrid.Cells.ColumnHeader("Наружнее точение");
            grid1[0, 0].ColumnSpan = 4;
            grid1[0, 0].View.TextAlignment = DevAge.Drawing.ContentAlignment.MiddleCenter;
            grid1[1, 0] = new SourceGrid.Cells.ColumnHeader("D, мм");
            grid1[1, 0].RowSpan = 2;
            grid1[1, 1] = new SourceGrid.Cells.ColumnHeader("Черновое");
            grid1[1, 2] = new SourceGrid.Cells.ColumnHeader("Получистовое");
            grid1[1, 3] = new SourceGrid.Cells.ColumnHeader("Чистовое");
            grid1[2, 1] = new SourceGrid.Cells.ColumnHeader("t, мм");
            grid1[2, 1].ColumnSpan = 3;
            for (int r = 3; r < 9; r++)
            {
                grid1.Rows.Insert(r);
                if (sqlite_datareader.Read())
                {
                    grid1[r, 0] = new SourceGrid.Cells.RowHeader(Convert.ToString(sqlite_datareader.GetString(0)));
                    grid1[r, 1] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(1)), typeof(float));
                    grid1[r, 2] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(2)), typeof(float));
                    grid1[r, 3] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(3)), typeof(float));
                }
                SourceGrid.Range R1 = new SourceGrid.Range(new Position(1, 3), new Position(8, 3));
                SourceGrid.RangeRegion rr = new RangeRegion(R1);
                for (int c = 0; c < 4; c++) //задание свойств ячеек
                {
                    if (c != 0)
                    {
                        grid1[r, c].AddController(cellpointer);//наведение
                        grid1[r, c].AddController(clickEvent);//клик мыши
                        grid1[r, c].Editor.EnableEdit = false;
                        grid1[r, c].AddController(new SourceGrid.Cells.Controllers.Unselectable());
                        grid1[r, c].AddController(new MyHelpRowTracking());//help row pointer
                    }
                }
            }
            #endregion
            sqlite_datareader = sqlReader.getReader("boring");
            #region Код таблицы 1 (растачивание)
            grid1[9, 0] = new SourceGrid.Cells.ColumnHeader("Растачивание");
            for (int r = 11; r < 15; r++)
            {
                grid1.Rows.Insert(r);
                if (sqlite_datareader.Read())
                {
                    grid1[r, 0] = new SourceGrid.Cells.RowHeader(Convert.ToString(sqlite_datareader.GetString(0)));
                    grid1[r, 1] = new SourceGrid.Cells.Cell(" ", typeof(string));
                    grid1[r, 2] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(2)), typeof(float));
                    grid1[r, 3] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(3)), typeof(float));
                }
                for (int c = 0; c < 4; c++) //задание свойств ячеек
                {
                    if ((c != 0) & (c != 1))
                    {
                        grid1[r, c].AddController(cellpointer);//наведение
                        grid1[r, c].AddController(clickEvent);//клик мыши
                        grid1[r, c].Editor.EnableEdit = false;
                        grid1[r, c].AddController(new SourceGrid.Cells.Controllers.Unselectable());
                        grid1[r, c].AddController(new MyHelpRowTracking());//help row pointer
                    }
                }
            }
            grid1[11, 1].AddController(new SourceGrid.Cells.Controllers.Unselectable());
            grid1[12, 1].AddController(new SourceGrid.Cells.Controllers.Unselectable());
            grid1[13, 1].AddController(new SourceGrid.Cells.Controllers.Unselectable());
            grid1[14, 1].AddController(new SourceGrid.Cells.Controllers.Unselectable());
            grid1[9, 0].ColumnSpan = 4;
            grid1.AutoSizeCells();
            grid1.EnableSort = false;
            grid1.Selection.EnableMultiSelection = false;
            #endregion

            foreach (SourceGrid.GridColumn col in grid1.Columns)
                col.Width=100;
            grid1.Columns[2].Width = 150;

            foreach (SourceGrid.GridRow row in grid1.Rows)
                row.Height = 25;
        }
        private void DoFullTab2()
        {

            SQLreader sqlReader = new SQLreader("database.sqlite");
            SQLiteDataReader sqlite_datareader = sqlReader.getReader("roughing");
            #region Код таблицы 2(черновое точение)
            grid2.BorderStyle = BorderStyle.FixedSingle;
            grid2.Redim(19, 4);
            grid2[0, 0] = new SourceGrid.Cells.ColumnHeader("Черновое точение");
            grid2[0, 0].ColumnSpan = 4;
            grid2[1, 0] = new SourceGrid.Cells.ColumnHeader("D, мм");
            grid2[1, 0].ColumnSpan = 2;
            grid2[1, 0].RowSpan = 3;
            grid2[1, 2] = new SourceGrid.Cells.ColumnHeader("Материал детали");
            grid2[1, 2].ColumnSpan = 2;
            grid2[2, 2] = new SourceGrid.Cells.ColumnHeader("Сталь углеродистая");
            grid2[2, 2].Column.Width = 40;
            grid2[2, 3] = new SourceGrid.Cells.ColumnHeader("Чугун серый");
            grid2[3, 2] = new SourceGrid.Cells.ColumnHeader("s, мм/об");
            grid2[3, 2].ColumnSpan = 2;
            for (int r = 4; r < 9; r++)
            {
                grid2.Rows.Insert(r);
                if (sqlite_datareader.Read())
                {
                    grid2[r, 0] = new SourceGrid.Cells.RowHeader(Convert.ToString(sqlite_datareader.GetString(0)));
                    grid2[r, 0].ColumnSpan = 2;
                    grid2[r, 2] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(1)), typeof(float));
                    grid2[r, 3] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(2)), typeof(float));
                }
                for (int c = 0; c < 4; c++) //задание свойств ячеек
                {
                    if ((c != 0) & (c != 1)) //для заголовков свойства не задаются
                    {
                        grid2[r, c].AddController(clickEvent);//клик мыши
                        grid2[r, c].AddController(cellpointer);//наведение
                        grid2[r, c].Editor.EnableEdit = false;//нередактируемые ячейки
                        grid2[r, c].AddController(new SourceGrid.Cells.Controllers.Unselectable());
                        grid2[r, c].AddController(new MyHelpRowTracking());//help row pointer
                    }
                }
            }
            #endregion
            sqlite_datareader = sqlReader.getReader("finish_turning");
            #region Код таблицы 3(получистовое и чистовое точение)
            grid2[9, 0] = new SourceGrid.Cells.ColumnHeader("Получистовое и чистовое точение");
            grid2[9, 0].ColumnSpan = 4;
            grid2[10, 0] = new SourceGrid.Cells.ColumnHeader("Шероховатость");
            grid2[10, 0].ColumnSpan = 2;
            grid2[10, 2] = new SourceGrid.Cells.ColumnHeader("Радиус при вершине, R, мм");
            grid2[10, 2].ColumnSpan = 2;
            grid2[11, 0] = new SourceGrid.Cells.ColumnHeader("Ra, мкм");
            grid2[11, 0].RowSpan = 2;
            grid2[11, 1] = new SourceGrid.Cells.ColumnHeader("Rz, мкм");
            grid2[11, 1].RowSpan = 2;
            grid2[11, 2] = new SourceGrid.Cells.ColumnHeader("<0,5");
            grid2[11, 3] = new SourceGrid.Cells.ColumnHeader(">0,5-1,0");
            grid2[12, 2] = new SourceGrid.Cells.ColumnHeader("s, мм/об");
            grid2[12, 2].ColumnSpan = 2;
            for (int r = 13; r < 19; r++)
            {
                grid2.Rows.Insert(r);
                if (sqlite_datareader.Read())
                {
                    grid2[r, 0] = new SourceGrid.Cells.RowHeader(Convert.ToString(sqlite_datareader.GetString(0)));
                    grid2[r, 1] = new SourceGrid.Cells.RowHeader(Convert.ToString(sqlite_datareader.GetString(1)));
                    grid2[r, 2] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(2)), typeof(float));
                    grid2[r, 3] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(3)), typeof(float));
                }
                for (int c = 0; c < 4; c++) //задание свойств ячеек
                {
                    if ((c != 0) & (c != 1)) //для заголовков свойства не задаются
                    {
                        grid2[r, c].AddController(clickEvent);//клик мыши
                        grid2[r, c].AddController(cellpointer);//наведение
                        grid2[r, c].Editor.EnableEdit = false;//нередактируемые ячейки
                        grid2[r, c].AddController(new SourceGrid.Cells.Controllers.Unselectable());
                        grid2[r, c].AddController(new MyHelpRowTracking());//help row pointer
                    }
                }
            }

            grid2.AutoSizeCells();
            grid2.EnableSort = false;
            grid2.Selection.EnableMultiSelection = false;
            #endregion

            foreach (SourceGrid.GridColumn col in grid2.Columns)
                col.Width = 100;
            grid2.Columns[2].Width = 150;

            foreach (SourceGrid.GridRow row in grid2.Rows)
                row.Height = 25;
        }
        private void DoFullTab3()
        {
            SQLreader sqlReader = new SQLreader("database.sqlite");
            SQLiteDataReader sqlite_datareader = sqlReader.getReader(" KMV");
            #region Код таблицы 4
            grid3.BorderStyle = BorderStyle.FixedSingle;
            grid3.Redim(3, 2);
            grid3.Rows.Insert(0);
            grid3[0, 0] = new SourceGrid.Cells.ColumnHeader("Обрабатываемый материал");
            grid3[0, 0].Column.Width = 200;
            grid3[0, 1] = new SourceGrid.Cells.ColumnHeader("Kмv");
            for (int r = 1; r < 3; r++)
            {
                if (sqlite_datareader.Read())
                {
                    grid3[r, 0] = new SourceGrid.Cells.RowHeader(Convert.ToString(sqlite_datareader.GetString(0)));
                    grid3[r, 1] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(1)), typeof(float));
                }
                for (int c = 0; c < 2; c++) //задание свойств ячеек
                {
                    if (c != 0) //для заголовков свойства не задаются
                    {
                        grid3[r, c].AddController(clickEvent);//клик мыши
                        grid3[r, c].AddController(cellpointer);//наведение
                        grid3[r, c].Editor.EnableEdit = false;//нередактируемые ячейки
                        grid3[r, c].AddController(new SourceGrid.Cells.Controllers.Unselectable());
                        grid3[r, c].AddController(new MyHelpRowTracking());//help row pointer
                    }
                }
            }
            grid3.AutoSizeCells();
            grid3.EnableSort = false;
            grid3.Selection.EnableMultiSelection = false;
            #endregion

            foreach (SourceGrid.GridColumn col in grid3.Columns)
                col.Width = 100;
            grid3.Columns[0].Width = 200;
            foreach (SourceGrid.GridRow row in grid3.Rows)
                row.Height = 25;
        }
        private void DoFullTab4()
        {
            SQLreader sqlReader = new SQLreader("database.sqlite");
            SQLiteDataReader sqlite_datareader = sqlReader.getReader("KpV");
            #region Код таблицы 5
            grid4.BorderStyle = BorderStyle.FixedSingle;
            grid4.Redim(4, 5);
            grid4[0, 0] = new SourceGrid.Cells.ColumnHeader("Материалы детали");
            //grid4[0, 0].Column.Width = 200;
            grid4[0, 0].RowSpan = 3;
            grid4[0, 1] = new SourceGrid.Cells.ColumnHeader("Заготовки с коркой");
            grid4[0, 1].ColumnSpan = 3;
            grid4[1, 1] = new SourceGrid.Cells.ColumnHeader("Поковка");
            grid4[1, 2] = new SourceGrid.Cells.ColumnHeader("Отливка");
            grid4[1, 3] = new SourceGrid.Cells.ColumnHeader("Прокат");
            grid4[0, 4] = new SourceGrid.Cells.ColumnHeader("Полуфабрикат \nбез корки");
            grid4[0, 4].RowSpan = 2;
            grid4[2, 1] = new SourceGrid.Cells.ColumnHeader("Kпv");
            grid4[2, 1].ColumnSpan = 4;
            if (sqlite_datareader.Read())
            {
                grid4[3, 0] = new SourceGrid.Cells.RowHeader(Convert.ToString(sqlite_datareader.GetString(0)));
                for (int c = 1; c < 5; c++)
                {
                    grid4[3, c] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(c)), typeof(float));
                    grid4[3, c].AddController(clickEvent);//клик мыши
                    grid4[3, c].AddController(cellpointer);//наведение
                    grid4[3, c].Editor.EnableEdit = false;//нередактируемые ячейки
                    grid4[3, c].AddController(new SourceGrid.Cells.Controllers.Unselectable());
                    grid4[3, c].AddController(new MyHelpRowTracking());//help row pointer
                }
            }
            grid4.AutoSizeCells();
            grid4.EnableSort = false;
            grid4.Selection.EnableMultiSelection = false;
            #endregion
            foreach (SourceGrid.GridColumn col in grid4.Columns)
                col.Width = 100;
            grid4.Columns[0].Width = 200;
            foreach (SourceGrid.GridRow row in grid4.Rows)
                row.Height = 25;
        }
        private void DoFullTab5()
        {
            SQLreader sqlReader = new SQLreader("database.sqlite");
            SQLiteDataReader sqlite_datareader = sqlReader.getReader("KiV_hard_alloy");
            #region Код таблицы 6 (твердый сплав)
            grid5.BorderStyle = BorderStyle.FixedSingle;
            grid5.Redim(7, 7);
            grid5[0, 0] = new SourceGrid.Cells.ColumnHeader("Материалы детали");
            //grid5[0, 0].Column.Width = 200;
            grid5[0, 0].RowSpan = 3;
            grid5[0, 1] = new SourceGrid.Cells.ColumnHeader("Твердый сплав");
            grid5[0, 1].ColumnSpan = 6;
            grid5[1, 1] = new SourceGrid.Cells.ColumnHeader("Т15К10");
            grid5[1, 2] = new SourceGrid.Cells.ColumnHeader("Т15К6");
            grid5[1, 3] = new SourceGrid.Cells.ColumnHeader("Т30К4");
            grid5[1, 4] = new SourceGrid.Cells.ColumnHeader("ВК8");
            grid5[1, 5] = new SourceGrid.Cells.ColumnHeader("ВК6");
            grid5[1, 6] = new SourceGrid.Cells.ColumnHeader("ВК4");
            grid5[2, 1] = new SourceGrid.Cells.ColumnHeader("Kиv");
            grid5[2, 1].ColumnSpan = 6;
            grid5[3, 4] = new SourceGrid.Cells.Cell("", typeof(string));
            grid5[3, 4].ColumnSpan = 3;
            grid5[4, 1] = new SourceGrid.Cells.Cell("", typeof(string));
            grid5[4, 1].ColumnSpan = 3;

            for (int r = 3; r < 5; r++)
            {
                if (sqlite_datareader.Read())
                {
                    grid5[r, 0] = new SourceGrid.Cells.RowHeader(Convert.ToString(sqlite_datareader.GetString(0)));
                    switch (r)
                    {
                        case 3:
                            for (int c = 1; c < 4; c++)
                            {
                                grid5[3, c] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(c)), typeof(float));
                                grid5[3, c].AddController(clickEvent);//клик мыши
                                grid5[3, c].AddController(cellpointer);//наведение
                                grid5[3, c].Editor.EnableEdit = false;//нередактируемые ячейки
                                grid5[3, c].AddController(new SourceGrid.Cells.Controllers.Unselectable());
                                grid5[3, c].AddController(new MyHelpRowTracking());//help row pointer
                            }
                            break;
                        case 4:
                            for (int c = 4; c < 7; c++)
                            {
                                grid5[4, c] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(c)), typeof(float));
                                grid5[4, c].AddController(clickEvent);//клик мыши
                                grid5[4, c].AddController(cellpointer);//наведение
                                grid5[4, c].Editor.EnableEdit = false;//нередактируемые ячейки
                                grid5[4, c].AddController(new SourceGrid.Cells.Controllers.Unselectable());
                                grid5[4, c].AddController(new MyHelpRowTracking());//help row pointer
                            }
                            break;
                    }
                }
            }
            #endregion
            sqlite_datareader = sqlReader.getReader("KiV_high_speed_steel");
            #region Код таблицы 6 (быстрорежущая сталь)

            grid5[5, 0] = new SourceGrid.Cells.ColumnHeader("Материалы детали");
            grid5[5, 1] = new SourceGrid.Cells.ColumnHeader("Быстрорежущая сталь");
            grid5[5, 1].ColumnSpan = 6;

            grid5[6, 1] = new SourceGrid.Cells.Cell("123");

            if (sqlite_datareader.Read())
            {
                grid5[6, 0] = new SourceGrid.Cells.RowHeader(Convert.ToString(sqlite_datareader.GetString(0)));
                grid5[6, 1] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(1)), typeof(float));
                grid5[6, 1].ColumnSpan = 6;
                grid5[6, 1].AddController(clickEvent);//клик мыши
                grid5[6, 1].AddController(cellpointer);//наведение
                grid5[6, 1].Editor.EnableEdit = false;//нередактируемые ячейки
                grid5[6, 1].AddController(new SourceGrid.Cells.Controllers.Unselectable());
                grid5[6, 1].AddController(new MyHelpRowTracking());//help row pointer
            }
            grid5.AutoSizeCells();
            grid5.EnableSort = false;
            grid5.Selection.EnableMultiSelection = false;
            #endregion

            foreach (SourceGrid.GridColumn col in grid5.Columns)
                col.Width = 100;
            grid5.Columns[0].Width = 200;
            foreach (SourceGrid.GridRow row in grid5.Rows)
                row.Height = 25;
        }
        private void DoFullTab6()
        {
            SQLreader sqlReader = new SQLreader("database.sqlite");
            SQLiteDataReader sqlite_datareader = sqlReader.getReader("EmpParamV");
            #region Код таблицы 7 (СтУг)
            grid6.BorderStyle = BorderStyle.FixedSingle;
            grid6.Redim(15, 7);
            //строка0
            grid6[0, 0] = new SourceGrid.Cells.ColumnHeader("Вид обработки");
            grid6[0, 1] = new SourceGrid.Cells.ColumnHeader("Материал резца");
            grid6[0, 2] = new SourceGrid.Cells.ColumnHeader("S");
            grid6[0, 3] = new SourceGrid.Cells.ColumnHeader("Cv");
            grid6[0, 4] = new SourceGrid.Cells.ColumnHeader("x");
            grid6[0, 5] = new SourceGrid.Cells.ColumnHeader("y");
            grid6[0, 6] = new SourceGrid.Cells.ColumnHeader("m");
            //строка1
            grid6[1, 0] = new SourceGrid.Cells.ColumnHeader("Сталь углеродистая");
            grid6[1, 0].ColumnSpan = 7;
            //строка2-4
            grid6[2, 0] = new SourceGrid.Cells.RowHeader("Наружнее точение \n Растачивание");
            grid6[2, 0].RowSpan = 3;

            //строка5-6
            grid6[5, 0] = new SourceGrid.Cells.RowHeader("Подрезание \n отрезание");
            grid6[5, 0].RowSpan = 2;
            //строка7-8
            grid6[7, 0] = new SourceGrid.Cells.RowHeader("Нарезание резьбы \n резцом");
            grid6[7, 0].RowSpan = 2;

            //Строка9
            grid6[9, 0] = new SourceGrid.Cells.ColumnHeader("Серый чугун");
            grid6[9, 0].ColumnSpan = 7;
            //материал резца
            grid6[2, 1] = new SourceGrid.Cells.RowHeader("Твердый \nсплав");
            grid6[2, 1].RowSpan = 4;
            grid6[6, 1] = new SourceGrid.Cells.RowHeader("Быстрорежущая \nсталь");
            grid6[7, 1] = new SourceGrid.Cells.RowHeader("Твердый \nсплав");
            grid6[8, 1] = new SourceGrid.Cells.RowHeader("Быстрорежущая \nсталь");

            for (int r = 2; r < 9; r++)
            {
                if (sqlite_datareader.Read())
                {
                    grid6[r, 2] = new SourceGrid.Cells.Cell(Convert.ToString(sqlite_datareader.GetString(0)), typeof(string));
                    grid6[r, 3] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(1)), typeof(float));
                    grid6[r, 4] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(2)), typeof(float));
                    grid6[r, 5] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(3)), typeof(float));
                    grid6[r, 6] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(4)), typeof(float));
                    for (int c = 2; c < 7; c++)
                    {
                        grid6[r, c].AddController(clickEvent);//клик мыши
                        grid6[r, c].AddController(rowpointer);//наведение
                        if (!((r == 7 && c == 2) || (r == 8 && c == 2)))
                        {
                            grid6[r, c].Editor.EnableEdit = false;//нередактируемые ячейки
                            grid6[r, c].AddController(new SourceGrid.Cells.Controllers.Unselectable());
                        }
                        grid6[r, c].AddController(new MyHelpRowTracking());//help row pointer
                    }
                }

            }
            #endregion
            #region Код таблицы 7 (СЧ)
            grid6[10, 0] = new SourceGrid.Cells.RowHeader("Наружнее точение \nРастачивание");
            grid6[10, 0].RowSpan = 2;
            grid6[12, 0] = new SourceGrid.Cells.RowHeader("Подрезание\nОтрезание");
            grid6[12, 0].RowSpan = 2;
            grid6[14, 0] = new SourceGrid.Cells.RowHeader("Нарезание\nрезьбы");
            //grid6[14, 0].RowSpan = 2;
            grid6[10, 1] = new SourceGrid.Cells.RowHeader("Твердый сплав");
            grid6[10, 1].RowSpan = 5;
            for (int r = 10; r < 15; r++)
            {
                if (sqlite_datareader.Read())
                {
                    grid6[r, 2] = new SourceGrid.Cells.Cell(Convert.ToString(sqlite_datareader.GetString(0)), typeof(string));
                    grid6[r, 3] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(1)), typeof(float));
                    grid6[r, 4] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(2)), typeof(float));
                    grid6[r, 5] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(3)), typeof(float));
                    grid6[r, 6] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(4)), typeof(float));
                    for (int c = 2; c < 7; c++)
                    {
                        grid6[r, c].AddController(clickEvent);//клик мыши
                        grid6[r, c].AddController(rowpointer);//наведение
                        if (!(r == 14 && c == 2))
                        {
                            grid6[r, c].Editor.EnableEdit = false;//нередактируемые ячейки
                            grid6[r, c].AddController(new SourceGrid.Cells.Controllers.Unselectable());
                        }
                        grid6[r, c].AddController(new MyHelpRowTracking());//help row pointer
                    }
                }
            }
            grid6.AutoSizeCells();
            grid6.EnableSort = false;
            grid6.Selection.EnableMultiSelection = false;
            //

            grid6[7, 2].AddController(CellChangedEvent_rezba);
            grid6[8, 2].AddController(CellChangedEvent_rezba);
            grid6[14, 2].AddController(CellChangedEvent_rezba);

            #endregion

            foreach (SourceGrid.GridColumn col in grid6.Columns)
                col.Width = 100;
            grid6.Columns[0].Width = 200;
            foreach (SourceGrid.GridRow row in grid6.Rows)
                row.Height = 25;
        }
        private void DoFullTab7()
        {
            SQLreader sqlReader = new SQLreader("database.sqlite");
            SQLiteDataReader sqlite_datareader = sqlReader.getReader("EmpParamPz");
            #region Код таблицы 8 (СтУг)
            grid7.BorderStyle = BorderStyle.FixedSingle;
            grid7.Redim(15, 6);
            //строка0
            grid7[0, 0] = new SourceGrid.Cells.ColumnHeader("Вид обработки");
            grid7[0, 1] = new SourceGrid.Cells.ColumnHeader("Материал резца");
            grid7[0, 2] = new SourceGrid.Cells.ColumnHeader("Cp");
            grid7[0, 3] = new SourceGrid.Cells.ColumnHeader("x");
            grid7[0, 4] = new SourceGrid.Cells.ColumnHeader("y");
            grid7[0, 5] = new SourceGrid.Cells.ColumnHeader("n");
            //строка1
            grid7[1, 0] = new SourceGrid.Cells.ColumnHeader("Сталь углеродистая");
            grid7[1, 0].ColumnSpan = 6;
            grid7[2, 0] = new SourceGrid.Cells.RowHeader("Наружнее точение \n Растачивание");
            grid7[3, 0] = new SourceGrid.Cells.RowHeader("Подрезание \n отрезание");
            grid7[4, 0] = new SourceGrid.Cells.RowHeader("Нарезание резьбы \n резцом");
            grid7[5, 0] = new SourceGrid.Cells.RowHeader("Наружнее точение \n растачивание");
            grid7[6, 0] = new SourceGrid.Cells.RowHeader("Подрезание \n отрезание");
            //Строка7
            grid7[7, 0] = new SourceGrid.Cells.ColumnHeader("Серый чугун");
            grid7[7, 0].ColumnSpan = 6;
            //материал резца
            grid7[2, 1] = new SourceGrid.Cells.RowHeader("Твердый \nсплав");
            grid7[2, 1].RowSpan = 3;
            grid7[5, 1] = new SourceGrid.Cells.RowHeader("Быстрорежущая \nсталь");
            grid7[5, 1].RowSpan = 2;

            for (int r = 2; r < 7; r++)
            {
                if (sqlite_datareader.Read())
                {
                    grid7[r, 2] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(0)), typeof(float));
                    grid7[r, 3] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(1)), typeof(float));
                    grid7[r, 4] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(2)), typeof(float));
                    grid7[r, 5] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(3)), typeof(float));

                    for (int c = 2; c < 6; c++)
                    {
                        grid7[r, c].AddController(clickEvent);//клик мыши
                        grid7[r, c].AddController(rowpointer);//наведение
                        grid7[r, c].Editor.EnableEdit = false;//нередактируемые ячейки
                        grid7[r, c].AddController(new SourceGrid.Cells.Controllers.Unselectable());
                        grid7[r, c].AddController(new MyHelpRowTracking());//help row pointer
                    }
                }

            }
            #endregion
            sqlite_datareader = sqlReader.getReader("EmpParamPz");
            #region Код таблицы 8 (СЧ)
            grid7[8, 0] = new SourceGrid.Cells.RowHeader("Наружнее точение \nРастачивание");
            grid7[8, 1] = new SourceGrid.Cells.RowHeader("Твердый сплав");
            grid7[9, 0] = new SourceGrid.Cells.RowHeader("Подрезание\nОтрезание");
            grid7[9, 1] = new SourceGrid.Cells.RowHeader("Быстрорежущая сталь");
            grid7[10, 0] = new SourceGrid.Cells.RowHeader("Нарезание\nрезьбы");
            grid7[10, 1] = new SourceGrid.Cells.RowHeader("Твердый сплав");

            for (int r = 8; r < 11; r++)
            {
                if (sqlite_datareader.Read())
                {
                    grid7[r, 2] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(0)), typeof(float));
                    grid7[r, 3] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(1)), typeof(float));
                    grid7[r, 4] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(2)), typeof(float));
                    grid7[r, 5] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(3)), typeof(float));
                    for (int c = 2; c < 6; c++)
                    {
                        grid7[r, c].AddController(clickEvent);//клик мыши
                        grid7[r, c].AddController(rowpointer);//наведение
                        grid7[r, c].Editor.EnableEdit = false;//нередактируемые ячейки
                        grid7[r, c].AddController(new SourceGrid.Cells.Controllers.Unselectable());
                        grid7[r, c].AddController(new MyHelpRowTracking());//help row pointer
                    }
                }
            }
            grid7.AutoSizeCells();
            grid7.EnableSort = false;
            grid7.Selection.EnableMultiSelection = false;
            #endregion

            foreach (SourceGrid.GridColumn col in grid7.Columns)
                col.Width = 100;
            grid7.Columns[0].Width = 200;
            foreach (SourceGrid.GridRow row in grid7.Rows)
                row.Height = 25;
        }
        private void DoFullTab8()
        {

            SQLreader sqlReader = new SQLreader("database.sqlite");
            SQLiteDataReader sqlite_datareader = sqlReader.getReader("KmP");
            #region Код таблицы 9
            grid8.BorderStyle = BorderStyle.FixedSingle;
            grid8.Redim(3, 2);
            grid8.Rows.Insert(0);
            grid8[0, 0] = new SourceGrid.Cells.ColumnHeader("Обрабатываемый материал");
            grid8[0, 0].Column.Width = 200;
            grid8[0, 1] = new SourceGrid.Cells.ColumnHeader("Kmp");
            for (int r = 1; r < 3; r++)
            {
                if (sqlite_datareader.Read())
                {
                    grid8[r, 0] = new SourceGrid.Cells.RowHeader(Convert.ToString(sqlite_datareader.GetString(0)));
                    grid8[r, 1] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(1)), typeof(float));
                }
                for (int c = 0; c < 2; c++) //задание свойств ячеек
                {
                    if (c != 0) //для заголовков свойства не задаются
                    {
                        grid8[r, c].AddController(clickEvent);//клик мыши
                        grid8[r, c].AddController(cellpointer);//наведение
                        grid8[r, c].Editor.EnableEdit = false;//нередактируемые ячейки
                        grid8[r, c].AddController(new SourceGrid.Cells.Controllers.Unselectable());
                        grid8[r, c].AddController(new MyHelpRowTracking());//help row pointer
                    }
                }
            }
            grid8.AutoSizeCells();
            grid8.EnableSort = false;
            grid8.Selection.EnableMultiSelection = false;
            #endregion


            foreach (SourceGrid.GridColumn col in grid8.Columns)
                col.Width = 100;
            grid8.Columns[0].Width = 200;
            foreach (SourceGrid.GridRow row in grid8.Rows)
                row.Height = 25;
        }

        private void DoFullRusultTab1_Turning()
        {
            #region Код таблицы
            grid18.BorderStyle = BorderStyle.FixedSingle;
            grid18.Redim(19, 4);
            SourceGrid.Cells.Views.Cell viewImage = new SourceGrid.Cells.Views.Cell();
            SourceGrid.Cells.Editors.TextBox tb = new SourceGrid.Cells.Editors.TextBox(typeof(float));
            SourceGrid.Cells.Editors.ComboBox cb = new SourceGrid.Cells.Editors.ComboBox(typeof(float), new float[] { 20, 30, 40, 60, 90, 120 }, false);
            int row = 0;
            grid18[row, 0] = new SourceGrid.Cells.ColumnHeader("Входные параметры");
            grid18[row, 0].ColumnSpan = 4;
            row++;
            grid18[row, 0] = new SourceGrid.Cells.RowHeader("Подача");
            grid18[row, 1] = new SourceGrid.Cells.RowHeader("S");
            grid18[row, 2] = new SourceGrid.Cells.Cell();
            grid18[row, 3] = new SourceGrid.Cells.Cell("мм/об");
            grid18[row, 0].Column.Width = 150;
            row++;
            grid18[row, 0] = new SourceGrid.Cells.RowHeader("Глубина резания");
            grid18[row, 1] = new SourceGrid.Cells.RowHeader("t");
            grid18[row, 2] = new SourceGrid.Cells.Cell();
            grid18[row, 3] = new SourceGrid.Cells.Cell("мм");
            row++;
            grid18[row, 0] = new SourceGrid.Cells.RowHeader("Период стойкости резца");
            grid18[row, 1] = new SourceGrid.Cells.RowHeader("T");
            grid18[row, 2] = new SourceGrid.Cells.Cell();
            grid18[row, 2].AddController(CellChangedEvent);
            grid18[row, 3] = new SourceGrid.Cells.Cell("мин");

            grid18[row, 2].Editor = cb;
            grid18[row, 2].Editor.EditableMode = EditableMode.SingleClick;

            row++;
            grid18[row, 0] = new SourceGrid.Cells.RowHeader("Диаметр инструмента");
            grid18[row, 1] = new SourceGrid.Cells.RowHeader("D");
            grid18[row, 2] = new SourceGrid.Cells.Cell();
            grid18[row, 3] = new SourceGrid.Cells.Cell("мм");
            row++;

            grid18[row, 0] = new SourceGrid.Cells.RowHeader("Поправка на инструментальный материал");
            grid18[row, 1] = new SourceGrid.Cells.RowHeader("Киv");
            grid18[row, 2] = new SourceGrid.Cells.Cell();
            grid18[row, 3] = new SourceGrid.Cells.Cell("мм");
            row++;

            grid18[row, 0] = new SourceGrid.Cells.RowHeader("Поправка на обрабатываемый материал");
            grid18[row, 1] = new SourceGrid.Cells.RowHeader("Kмv");
            grid18[row, 2] = new SourceGrid.Cells.Cell();
            grid18[row, 3] = new SourceGrid.Cells.Cell("б/р");
            row++;

            grid18[row, 0] = new SourceGrid.Cells.RowHeader("Поправка на состояние поверхности");
            grid18[row, 1] = new SourceGrid.Cells.RowHeader("Kпv");
            grid18[row, 2] = new SourceGrid.Cells.Cell();
            grid18[row, 3] = new SourceGrid.Cells.Cell("б/р");
            row++;

            grid18[row, 0] = new SourceGrid.Cells.RowHeader("Поправка на глубину отверстия");
            grid18[row, 1] = new SourceGrid.Cells.RowHeader("Kмp");
            grid18[row, 2] = new SourceGrid.Cells.Cell();
            grid18[row, 3] = new SourceGrid.Cells.Cell("б/р");
            row++;

            grid18[row, 0] = new SourceGrid.Cells.ColumnHeader("Эмпирические коэффициенты скорости резания");
            grid18[row, 0].ColumnSpan = 4;
            row++;

            grid18[row, 0] = new SourceGrid.Cells.ColumnHeader("Сv");
            grid18[row, 0].ColumnSpan = 2;
            grid18[row, 2] = new SourceGrid.Cells.Cell();
            grid18[row, 3] = new SourceGrid.Cells.ColumnHeader("б/р");
            row++;

            grid18[row, 0] = new SourceGrid.Cells.ColumnHeader("x");
            grid18[row, 0].ColumnSpan = 2;
            grid18[row, 2] = new SourceGrid.Cells.Cell();
            grid18[row, 3] = new SourceGrid.Cells.ColumnHeader("б/р");
            row++;

            grid18[row, 0] = new SourceGrid.Cells.ColumnHeader("y");
            grid18[row, 0].ColumnSpan = 2;
            grid18[row, 2] = new SourceGrid.Cells.Cell();
            grid18[row, 3] = new SourceGrid.Cells.ColumnHeader("б/р");
            row++;

            grid18[row, 0] = new SourceGrid.Cells.ColumnHeader("m");
            grid18[row, 0].ColumnSpan = 2;
            grid18[row, 2] = new SourceGrid.Cells.Cell();
            grid18[row, 3] = new SourceGrid.Cells.ColumnHeader("б/р");
            row++;

            grid18[row, 0] = new SourceGrid.Cells.ColumnHeader("Эмпирические коэффициенты силы резания");
            grid18[row, 0].ColumnSpan = 4;
            row++;

            grid18[row, 0] = new SourceGrid.Cells.ColumnHeader("Ср");
            grid18[row, 0].ColumnSpan = 2;
            grid18[row, 2] = new SourceGrid.Cells.Cell();
            grid18[row, 3] = new SourceGrid.Cells.ColumnHeader("б/р");
            row++;

            grid18[row, 0] = new SourceGrid.Cells.ColumnHeader("x");
            grid18[row, 0].ColumnSpan = 2;
            grid18[row, 2] = new SourceGrid.Cells.Cell();
            grid18[row, 3] = new SourceGrid.Cells.ColumnHeader("б/р");
            row++;

            grid18[row, 0] = new SourceGrid.Cells.ColumnHeader("y");
            grid18[row, 0].ColumnSpan = 2;
            grid18[row, 2] = new SourceGrid.Cells.Cell();
            grid18[row, 3] = new SourceGrid.Cells.ColumnHeader("б/р");

            row++;

            grid18[row, 0] = new SourceGrid.Cells.ColumnHeader("n");
            grid18[row, 0].ColumnSpan = 2;
            grid18[row, 2] = new SourceGrid.Cells.Cell();
            grid18[row, 3] = new SourceGrid.Cells.ColumnHeader("б/р");

            // Добавляем возможность редактировать и указываем событие при изменении значения
            for (int r = 1; r < grid18.RowsCount; r++)
            {
                if (r != 3 && r != 9 && r != 14)
                {
                    grid18[r, 2].Editor = tb;
                    grid18[r, 2].AddController(CellChangedEvent);
                    grid18[r, 2].AddController(new MyCellTracking());//наведение
                    grid18[r, 2].AddController(new MyHelpRowTracking());//help row pointer
                }
            }


            #endregion


            foreach (SourceGrid.GridColumn col in grid18.Columns)
                col.Width = 80;
            grid18.Columns[0].Width = 100;
            foreach (SourceGrid.GridRow r in grid18.Rows)
                r.Height = 25;
        }
        private void DoFullResultTab2_Turning()
        {
            #region Код таблицы
            grid19.BorderStyle = BorderStyle.FixedSingle;
            grid19.Redim(6, 4);
            int row = 0;
            grid19[row, 0] = new SourceGrid.Cells.ColumnHeader("Выходные параметры");
            grid19[row, 0].ColumnSpan = 4;

            row++;
            grid19[row, 0] = new SourceGrid.Cells.RowHeader("Скорость резания");
            grid19[row, 1] = new SourceGrid.Cells.RowHeader();

            grid19[row, 1] = new SourceGrid.Cells.Cell();
            //Properties.Resources.V2.SetResolution((float)(Properties.Resources.V2.HorizontalResolution * 0.3), (float)(Properties.Resources.V2.VerticalResolution * 0.3));
            grid19[row, 1].Image = Properties.Resources.V;

            grid19[row, 2] = new SourceGrid.Cells.Cell();
            grid19[row, 3] = new SourceGrid.Cells.Cell("м/мин");
            row++;
            grid19[row, 0] = new SourceGrid.Cells.RowHeader("Сила резания");
            grid19[row, 1] = new SourceGrid.Cells.RowHeader();

            grid19[row, 1] = new SourceGrid.Cells.Cell();
            grid19[row, 1].Image = Properties.Resources.P;

            grid19[row, 2] = new SourceGrid.Cells.Cell();
            grid19[row, 3] = new SourceGrid.Cells.Cell("Н");
            row++;
            grid19[row, 0] = new SourceGrid.Cells.RowHeader("Момент резания");
            grid19[row, 1] = new SourceGrid.Cells.RowHeader();

            grid19[row, 1] = new SourceGrid.Cells.Cell();
            Bitmap bm = new Bitmap(Properties.Resources.M);
            bm.SetResolution(96.0F, 96.0F);
            grid19[row, 1].Image = bm;//Properties.Resources.M2;

            grid19[row, 2] = new SourceGrid.Cells.Cell();
            grid19[row, 3] = new SourceGrid.Cells.Cell("Нм");

            row++;
            grid19[row, 0] = new SourceGrid.Cells.RowHeader("Потребляемая мощность");
            grid19[row, 1] = new SourceGrid.Cells.RowHeader();

            grid19[row, 1] = new SourceGrid.Cells.Cell();
            grid19[row, 1].Image = Properties.Resources.N;

            grid19[row, 2] = new SourceGrid.Cells.Cell();
            grid19[row, 3] = new SourceGrid.Cells.Cell("кВт");


            row++;
            grid19[row, 0] = new SourceGrid.Cells.RowHeader("Частота вращения шпинделя");
            grid19[row, 1] = new SourceGrid.Cells.RowHeader();

            grid19[row, 1] = new SourceGrid.Cells.Cell();
            grid19[row, 1].Image = Properties.Resources.n_2_;

            grid19[row, 2] = new SourceGrid.Cells.Cell();
            grid19[row, 3] = new SourceGrid.Cells.Cell("об/мин");

            grid19.Columns[0].Width = 130;
            grid19.Columns[1].Width = 350;
            grid19.Columns[2].Width = 70;
            grid19.Columns[3].Width = 70;

            grid19.Rows[0].Height = 36;
            grid19.Rows[1].Height = 60;
            grid19.Rows[2].Height = 60;
            grid19.Rows[3].Height = 60;
            grid19.Rows[4].Height = 60;
            grid19.Rows[5].Height = 60;



            #endregion
        }
        private void DoFullGrid18_Turning()
        {
            grid18[1, 2].Value = ts.inputData.s;
            grid18[2, 2].Value = ts.inputData.t;
            grid18[3, 2].Value = ts.inputData.T;
            grid18[4, 2].Value = ts.inputData.D;
            grid18[5, 2].Value = ts.inputData.Kiv;
            grid18[6, 2].Value = ts.inputData.Kmv;
            grid18[7, 2].Value = ts.inputData.Kpv;
            grid18[8, 2].Value = ts.inputData.Kmp;

            grid18[10, 2].Value = ts.inputData.Cv;
            grid18[11, 2].Value = ts.inputData.xv;
            grid18[12, 2].Value = ts.inputData.yv;
            grid18[13, 2].Value = ts.inputData.mv;

            grid18[15, 2].Value = ts.inputData.Cp;
            grid18[16, 2].Value = ts.inputData.xp;
            grid18[17, 2].Value = ts.inputData.yp;
            grid18[18, 2].Value = ts.inputData.np;

        }
        private void DoFullGrid19_Turning()
        {
            grid19[1, 2].Value = ts.getV();
            grid19[2, 2].Value = ts.getP();
            grid19[3, 2].Value = ts.getM();
            grid19[4, 2].Value = ts.getN();
            grid19[5, 2].Value = ts.getn();
            //
        }
        #endregion
        #region Код М DoFullTab
        public void DoFullTab1_Mill()
        {
            SQLreader sqlReader = new SQLreader("databaseF.sqlite");
            SQLiteDataReader sqlite_datareader = sqlReader.getReader("FrEmpParamV");
            #region Код таблицы 1 (твердый сплав)
            grid1Mill.BorderStyle = BorderStyle.FixedSingle;
            grid1Mill.Redim(15, 11);
            //заголовок
            grid1Mill[0, 0] = new SourceGrid.Cells.ColumnHeader("Вид обработки");
            grid1Mill[0, 1] = new SourceGrid.Cells.ColumnHeader("Материал резца");
            grid1Mill[0, 2] = new SourceGrid.Cells.ColumnHeader("t");
            grid1Mill[0, 3] = new SourceGrid.Cells.ColumnHeader("Sz");
            grid1Mill[0, 4] = new SourceGrid.Cells.ColumnHeader("Cv");
            grid1Mill[0, 5] = new SourceGrid.Cells.ColumnHeader("q");
            grid1Mill[0, 6] = new SourceGrid.Cells.ColumnHeader("x");
            grid1Mill[0, 7] = new SourceGrid.Cells.ColumnHeader("y");
            grid1Mill[0, 8] = new SourceGrid.Cells.ColumnHeader("u");
            grid1Mill[0, 9] = new SourceGrid.Cells.ColumnHeader("p");
            grid1Mill[0, 10] = new SourceGrid.Cells.ColumnHeader("m");
            grid1Mill[1, 0] = new SourceGrid.Cells.ColumnHeader("Сталь углеродистая");
            grid1Mill[1, 0].View.TextAlignment = DevAge.Drawing.ContentAlignment.MiddleCenter;
            grid1Mill[1, 0].ColumnSpan = 11;
            //строка 2
            grid1Mill[2, 0] = new SourceGrid.Cells.RowHeader("Торцевое \nфрезерование");
            grid1Mill[2, 0].RowSpan = 2;
            grid1Mill[4, 0] = new SourceGrid.Cells.RowHeader("Боковое \nфрезерование");
            grid1Mill[4, 0].RowSpan = 4;
            grid1Mill[8, 0] = new SourceGrid.Cells.ColumnHeader("Чугун");
            grid1Mill[8, 0].ColumnSpan = 11;
            //строка 2
            grid1Mill[9, 0] = new SourceGrid.Cells.RowHeader("Торцевое \nфрезерование");
            grid1Mill[9, 0].RowSpan = 2;
            grid1Mill[11, 0] = new SourceGrid.Cells.RowHeader("Боковое \nфрезерование");
            grid1Mill[11, 0].RowSpan = 4;
            for (int r = 2; r < 8; r++)
            {
                //grid1.Rows.Insert(r);
                if (sqlite_datareader.Read())
                {
                    grid1Mill[r, 1] = new SourceGrid.Cells.RowHeader(Convert.ToString(sqlite_datareader.GetString(0)));
                    grid1Mill[r, 2] = new SourceGrid.Cells.RowHeader(Convert.ToString(sqlite_datareader.GetString(1)));
                    grid1Mill[r, 3] = new SourceGrid.Cells.RowHeader(Convert.ToString(sqlite_datareader.GetString(2)));
                    grid1Mill[r, 4] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(3)), typeof(float));
                    grid1Mill[r, 5] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(4)), typeof(float));
                    grid1Mill[r, 6] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(5)), typeof(float));
                    grid1Mill[r, 7] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(6)), typeof(float));
                    grid1Mill[r, 8] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(7)), typeof(float));
                    grid1Mill[r, 9] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(8)), typeof(float));
                    grid1Mill[r, 10] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(9)), typeof(float));
                }
                for (int c = 4; c < 11; c++)
                {
                    grid1Mill[r, c].AddController(clickEvent);//клик мыши
                    grid1Mill[r, c].AddController(rowpointer);//наведение
                    grid1Mill[r, c].Editor.EnableEdit = false;//нередактируемые ячейки
                    grid1Mill[r, c].AddController(new SourceGrid.Cells.Controllers.Unselectable());
                    grid1Mill[r, c].AddController(new MyHelpRowTracking());//help row pointer

                }
            }
            for (int r = 9; r < 15; r++)
            {
                if (sqlite_datareader.Read())
                {
                    grid1Mill[r, 1] = new SourceGrid.Cells.RowHeader(Convert.ToString(sqlite_datareader.GetString(0)));
                    grid1Mill[r, 2] = new SourceGrid.Cells.RowHeader(Convert.ToString(sqlite_datareader.GetString(1)));
                    grid1Mill[r, 3] = new SourceGrid.Cells.RowHeader(Convert.ToString(sqlite_datareader.GetString(2)));
                    grid1Mill[r, 4] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(3)), typeof(float));
                    grid1Mill[r, 5] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(4)), typeof(float));
                    grid1Mill[r, 6] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(5)), typeof(float));
                    grid1Mill[r, 7] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(6)), typeof(float));
                    grid1Mill[r, 8] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(7)), typeof(float));
                    grid1Mill[r, 9] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(8)), typeof(float));
                    grid1Mill[r, 10] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(9)), typeof(float));
                }
                for (int c = 4; c < 11; c++)
                {
                    grid1Mill[r, c].AddController(clickEvent);//клик мыши
                    grid1Mill[r, c].AddController(rowpointer);//наведение
                    grid1Mill[r, c].Editor.EnableEdit = false;//нередактируемые ячейки
                    grid1Mill[r, c].AddController(new SourceGrid.Cells.Controllers.Unselectable());
                    grid1Mill[r, c].AddController(new MyHelpRowTracking());//help row pointer
                }
            }
            grid1Mill.AutoSizeCells();
            grid1Mill.EnableSort = false;
            grid1Mill.Selection.EnableMultiSelection = false;
            #endregion


            foreach (SourceGrid.GridColumn col in grid1Mill.Columns)
                col.Width = 60;
            grid1Mill.Columns[0].Width = 200;
            foreach (SourceGrid.GridRow row in grid1Mill.Rows)
                row.Height = 25;
        }
        public void DoFullTab2_Mill()
        {
            #region Код таблицы 2 (Зав z от D)

            grid2Mill.BorderStyle = BorderStyle.FixedSingle;
            grid2Mill.Redim(2, 10);
            //заголовок
            grid2Mill[0, 0] = new SourceGrid.Cells.RowHeader("D, мм");
            grid2Mill[0, 1] = new SourceGrid.Cells.RowHeader("10-18");
            grid2Mill[0, 2] = new SourceGrid.Cells.RowHeader("19-28");
            grid2Mill[0, 3] = new SourceGrid.Cells.RowHeader("29-50");
            grid2Mill[0, 4] = new SourceGrid.Cells.RowHeader("51-63");
            grid2Mill[0, 5] = new SourceGrid.Cells.RowHeader("64-80");
            grid2Mill[0, 6] = new SourceGrid.Cells.RowHeader("81-100");
            grid2Mill[0, 7] = new SourceGrid.Cells.RowHeader("101-125");
            grid2Mill[0, 8] = new SourceGrid.Cells.RowHeader("126-160");
            grid2Mill[0, 9] = new SourceGrid.Cells.RowHeader("161-200");
            grid2Mill[1, 0] = new SourceGrid.Cells.RowHeader("z");
            grid2Mill[0, 0].View.TextAlignment = DevAge.Drawing.ContentAlignment.MiddleCenter;
            grid2Mill[0, 1].View.TextAlignment = DevAge.Drawing.ContentAlignment.MiddleCenter;
            grid2Mill[1, 1] = new SourceGrid.Cells.Cell(Convert.ToString(3), typeof(string));
            grid2Mill[1, 2] = new SourceGrid.Cells.Cell(Convert.ToString(3), typeof(string));
            grid2Mill[1, 3] = new SourceGrid.Cells.Cell(Convert.ToString(4), typeof(string));
            grid2Mill[1, 4] = new SourceGrid.Cells.Cell(Convert.ToString(5), typeof(string));
            grid2Mill[1, 5] = new SourceGrid.Cells.Cell(Convert.ToString(8), typeof(string));
            grid2Mill[1, 6] = new SourceGrid.Cells.Cell(Convert.ToString(10), typeof(string));
            grid2Mill[1, 7] = new SourceGrid.Cells.Cell(Convert.ToString(12), typeof(string));
            grid2Mill[1, 8] = new SourceGrid.Cells.Cell(Convert.ToString(14), typeof(string));
            grid2Mill[1, 9] = new SourceGrid.Cells.Cell(Convert.ToString(18), typeof(string));
            for (int c = 1; c < 10; c++)
            {
                grid2Mill[1, c].AddController(clickEvent);//клик мыши
                grid2Mill[1, c].AddController(cellpointer);//наведение
                grid2Mill[1, c].Editor.EnableEdit = false;//нередактируемые ячейки
                grid2Mill[1, c].AddController(new SourceGrid.Cells.Controllers.Unselectable());
                grid2Mill[1, c].AddController(new MyHelpRowTracking());//help row pointer
            }
            grid2Mill.AutoSizeCells();
            grid2Mill.EnableSort = false;
            grid2Mill.Selection.EnableMultiSelection = false;
            #endregion


            foreach (SourceGrid.GridColumn col in grid2Mill.Columns)
                col.Width = 100;
            foreach (SourceGrid.GridRow row in grid2Mill.Rows)
                row.Height = 25;
        }
        public void DoFullTab3_Mill()
        {
            SQLreader sqlReader = new SQLreader("databaseF.sqlite");
            SQLiteDataReader sqlite_datareader = sqlReader.getReader("FrParamKv");
            #region Код таблицы 3 (Коэф. Kv)
            grid3Mill.BorderStyle = BorderStyle.FixedSingle;
            grid3Mill.Redim(7, 3);

            grid3Mill[0, 0] = new SourceGrid.Cells.ColumnHeader("Коэффициент Kv");
            grid3Mill[0, 0].ColumnSpan = 3;
            grid3Mill[1, 0] = new SourceGrid.Cells.ColumnHeader("Вид загатовки");
            grid3Mill[1, 0].RowSpan = 2;
            grid3Mill[1, 1] = new SourceGrid.Cells.ColumnHeader("Обрабатываемый материал");
            grid3Mill[1, 1].ColumnSpan = 2;
            grid3Mill[2, 1] = new SourceGrid.Cells.ColumnHeader("Конструкционная сталь");
            grid3Mill[2, 2] = new SourceGrid.Cells.ColumnHeader("Серый чугун");
            grid3Mill[0, 0].View.TextAlignment = DevAge.Drawing.ContentAlignment.MiddleCenter;
            grid3Mill[0, 1].View.TextAlignment = DevAge.Drawing.ContentAlignment.MiddleCenter;
            for (int r = 3; r < 7; r++)
            {
                if (sqlite_datareader.Read())
                {
                    grid3Mill[r, 0] = new SourceGrid.Cells.RowHeader(Convert.ToString(sqlite_datareader.GetString(0)));
                    grid3Mill[r, 1] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(1)), typeof(float));
                    grid3Mill[r, 2] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(2)), typeof(float));
                }
                for (int c = 1; c < 3; c++)
                {
                    grid3Mill[r, c].View.TextAlignment = DevAge.Drawing.ContentAlignment.MiddleCenter;
                    grid3Mill[r, c].AddController(clickEvent);//клик мыши
                    grid3Mill[r, c].AddController(cellpointer);//наведение
                    grid3Mill[r, c].Editor.EnableEdit = false;//нередактируемые ячейки
                    grid3Mill[r, c].AddController(new SourceGrid.Cells.Controllers.Unselectable());
                    grid3Mill[r, c].AddController(new MyHelpRowTracking());//help row pointer
                }
            }
            grid3Mill.AutoSizeCells();
            grid3Mill.EnableSort = false;
            grid3Mill.Selection.EnableMultiSelection = false;
            #endregion


            foreach (SourceGrid.GridColumn col in grid3Mill.Columns)
                col.Width = 150;
            grid3Mill.Columns[0].Width = 150;
            foreach (SourceGrid.GridRow row in grid3Mill.Rows)
                row.Height = 25;
        }
        public void DoFullTab4_Mill()
        {
            SQLreader sqlReader = new SQLreader("databaseF.sqlite");
            SQLiteDataReader sqlite_datareader = sqlReader.getReader("FrParamKp");
            #region Код таблицы 4 (Коэф. Kp)
            grid4Mill.BorderStyle = BorderStyle.FixedSingle;
            grid4Mill.Redim(3, 2);
            grid4Mill[0, 0] = new SourceGrid.Cells.ColumnHeader("Обрабатываемый \nматериал");
            grid4Mill[0, 1] = new SourceGrid.Cells.ColumnHeader("Коэффицент Kp");
            for (int r = 1; r < 3; r++)
            {
                if (sqlite_datareader.Read())
                {
                    grid4Mill[r, 0] = new SourceGrid.Cells.RowHeader(Convert.ToString(sqlite_datareader.GetString(0)));
                    grid4Mill[r, 1] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(1)), typeof(float));
                    grid4Mill[r, 0].View.TextAlignment = DevAge.Drawing.ContentAlignment.MiddleCenter;
                }
                grid4Mill[r, 1].View.TextAlignment = DevAge.Drawing.ContentAlignment.MiddleCenter;
                grid4Mill[r, 1].AddController(clickEvent);//клик мыши
                grid4Mill[r, 1].AddController(cellpointer);//наведение
                grid4Mill[r, 1].Editor.EnableEdit = false;//нередактируемые ячейки
                grid4Mill[r, 1].AddController(new SourceGrid.Cells.Controllers.Unselectable());
                grid4Mill[r, 1].AddController(new MyHelpRowTracking());//help row pointer
            }
            grid4Mill.AutoSizeCells();
            grid4Mill.EnableSort = false;
            grid4Mill.Selection.EnableMultiSelection = false;
            #endregion


            foreach (SourceGrid.GridColumn col in grid4Mill.Columns)
                col.Width = 100;
            grid4Mill.Columns[0].Width = 150;
            foreach (SourceGrid.GridRow row in grid4Mill.Rows)
                row.Height = 25;
        }
        public void DoFullTab5_Mill()
        {
            SQLreader sqlReader = new SQLreader("databaseF.sqlite");
            SQLiteDataReader sqlite_datareader = sqlReader.getReader("FrParamPz");
            #region Код таблицы 5 (Коэф. к ур. силы резания)
            grid5Mill.BorderStyle = BorderStyle.FixedSingle;
            grid5Mill.Redim(11, 8);
            grid5Mill[0, 0] = new SourceGrid.Cells.ColumnHeader("Вид обработки");
            grid5Mill[0, 1] = new SourceGrid.Cells.ColumnHeader("Материал резца");
            grid5Mill[0, 2] = new SourceGrid.Cells.ColumnHeader("Cр");
            grid5Mill[0, 3] = new SourceGrid.Cells.ColumnHeader("х");
            grid5Mill[0, 4] = new SourceGrid.Cells.ColumnHeader("y");
            grid5Mill[0, 5] = new SourceGrid.Cells.ColumnHeader("u");
            grid5Mill[0, 6] = new SourceGrid.Cells.ColumnHeader("q");
            grid5Mill[0, 7] = new SourceGrid.Cells.ColumnHeader("w");
            grid5Mill[1, 0] = new SourceGrid.Cells.ColumnHeader("Сталь углеродистая");
            grid5Mill[1, 0].ColumnSpan = 8;
            grid5Mill[2, 0] = new SourceGrid.Cells.RowHeader("Торцевое \nфрезерование");
            grid5Mill[2, 0].RowSpan = 2;
            grid5Mill[4, 0] = new SourceGrid.Cells.RowHeader("Боковое \nфрезерование");
            grid5Mill[4, 0].RowSpan = 2;
            grid5Mill[6, 0] = new SourceGrid.Cells.ColumnHeader("Серый чугун");
            grid5Mill[6, 0].ColumnSpan = 8;
            grid5Mill[7, 0] = new SourceGrid.Cells.RowHeader("Торцевое \nфрезерование");
            grid5Mill[7, 0].RowSpan = 2;
            grid5Mill[9, 0] = new SourceGrid.Cells.RowHeader("Боковое \nфрезерование");
            grid5Mill[9, 0].RowSpan = 2;
            for (int r = 2; r < 6; r++)
            {
                if (sqlite_datareader.Read())
                {
                    grid5Mill[r, 1] = new SourceGrid.Cells.RowHeader(Convert.ToString(sqlite_datareader.GetString(0)));
                    grid5Mill[r, 2] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(1)), typeof(float));
                    grid5Mill[r, 3] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(2)), typeof(float));
                    grid5Mill[r, 4] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(3)), typeof(float));
                    grid5Mill[r, 5] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(4)), typeof(float));
                    grid5Mill[r, 6] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(5)), typeof(float));
                    grid5Mill[r, 7] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(6)), typeof(float));
                }
                for (int c = 2; c < 8; c++)
                {
                    grid5Mill[r, c].View.TextAlignment = DevAge.Drawing.ContentAlignment.MiddleCenter;
                    grid5Mill[r, c].AddController(clickEvent);//клик мыши
                    grid5Mill[r, c].AddController(rowpointer);//наведение
                    grid5Mill[r, c].Editor.EnableEdit = false;//нередактируемые ячейки
                    grid5Mill[r, c].AddController(new SourceGrid.Cells.Controllers.Unselectable());
                    grid5Mill[r, c].AddController(new MyHelpRowTracking());//help row pointer
                }
            }
            for (int r = 7; r < 11; r++)
            {
                if (sqlite_datareader.Read())
                {
                    grid5Mill[r, 1] = new SourceGrid.Cells.RowHeader(Convert.ToString(sqlite_datareader.GetString(0)));
                    grid5Mill[r, 2] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(1)), typeof(float));
                    grid5Mill[r, 3] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(2)), typeof(float));
                    grid5Mill[r, 4] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(3)), typeof(float));
                    grid5Mill[r, 5] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(4)), typeof(float));
                    grid5Mill[r, 6] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(5)), typeof(float));
                    grid5Mill[r, 7] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(6)), typeof(float));
                }
                for (int c = 2; c < 8; c++)
                {
                    grid5Mill[r, c].AddController(clickEvent);//клик мыши
                    grid5Mill[r, c].AddController(rowpointer);//наведение
                    grid5Mill[r, c].Editor.EnableEdit = false;//нередактируемые ячейки
                    grid5Mill[r, c].AddController(new SourceGrid.Cells.Controllers.Unselectable());
                    grid5Mill[r, c].AddController(new MyHelpRowTracking());//help row pointer
                }
            }
            grid5Mill.AutoSizeCells();
            grid5Mill.EnableSort = false;
            grid5Mill.Selection.EnableMultiSelection = false;
            #endregion


            foreach (SourceGrid.GridColumn col in grid5Mill.Columns)
                col.Width = 100;
            grid5Mill.Columns[0].Width = 150;
            foreach (SourceGrid.GridRow row in grid5Mill.Rows)
                row.Height = 25;
        }
        #endregion

        private void DoFullRusultTab1_Milling()
        {
            #region Код таблицы
            grid20.BorderStyle = BorderStyle.FixedSingle;
            grid20.Redim(24, 4);
            SourceGrid.Cells.Views.Cell viewImage = new SourceGrid.Cells.Views.Cell();
            SourceGrid.Cells.Editors.TextBox tb = new SourceGrid.Cells.Editors.TextBox(typeof(float));
            SourceGrid.Cells.Editors.ComboBox cb = new SourceGrid.Cells.Editors.ComboBox(typeof(float), new float[] { 20, 30, 40, 60, 90, 120 }, false);
            int row = 0;
            grid20[row, 0] = new SourceGrid.Cells.ColumnHeader("Входные параметры");
            grid20[row, 0].ColumnSpan = 4;
            row++;
            grid20[row, 0] = new SourceGrid.Cells.RowHeader("Подача");
            grid20[row, 1] = new SourceGrid.Cells.RowHeader("S");
            grid20[row, 2] = new SourceGrid.Cells.Cell();
            grid20[row, 3] = new SourceGrid.Cells.Cell("мм/об");
            grid20[row, 0].Column.Width = 150;
            row++;
            grid20[row, 0] = new SourceGrid.Cells.RowHeader("Глубина резания");
            grid20[row, 1] = new SourceGrid.Cells.RowHeader("t");
            grid20[row, 2] = new SourceGrid.Cells.Cell();
            grid20[row, 3] = new SourceGrid.Cells.Cell("мм");
            row++;
            grid20[row, 0] = new SourceGrid.Cells.RowHeader("Период стойкости резца");
            grid20[row, 1] = new SourceGrid.Cells.RowHeader("T");
            grid20[row, 2] = new SourceGrid.Cells.Cell();
            grid20[row, 2].AddController(CellChangedEvent);
            grid20[row, 3] = new SourceGrid.Cells.Cell("мин");

            grid20[row, 2].Editor = cb;
            grid20[row, 2].Editor.EditableMode = EditableMode.SingleClick;

            row++;
            grid20[row, 0] = new SourceGrid.Cells.RowHeader("Диаметр инструмента");
            grid20[row, 1] = new SourceGrid.Cells.RowHeader("D");
            grid20[row, 2] = new SourceGrid.Cells.Cell();
            grid20[row, 3] = new SourceGrid.Cells.Cell("мм");
            row++;

            grid20[row, 0] = new SourceGrid.Cells.RowHeader("Количество зубьев фрезы");
            grid20[row, 1] = new SourceGrid.Cells.RowHeader("z");
            grid20[row, 2] = new SourceGrid.Cells.Cell();
            grid20[row, 3] = new SourceGrid.Cells.Cell("шт");
            row++;

            grid20[row, 0] = new SourceGrid.Cells.RowHeader("Ширина фрезы");
            grid20[row, 1] = new SourceGrid.Cells.RowHeader("B");
            grid20[row, 2] = new SourceGrid.Cells.Cell();
            grid20[row, 3] = new SourceGrid.Cells.Cell("мм");
            row++;

            grid20[row, 0] = new SourceGrid.Cells.RowHeader("Поправка на обрабатываемый материал");
            grid20[row, 1] = new SourceGrid.Cells.RowHeader("Kv");
            grid20[row, 2] = new SourceGrid.Cells.Cell();
            grid20[row, 3] = new SourceGrid.Cells.Cell("б/р");
            row++;

            grid20[row, 0] = new SourceGrid.Cells.RowHeader("Поправка на обрабатываемый материал");
            grid20[row, 1] = new SourceGrid.Cells.RowHeader("Kp");
            grid20[row, 2] = new SourceGrid.Cells.Cell();
            grid20[row, 3] = new SourceGrid.Cells.Cell("б/р");
            row++;

            grid20[row, 0] = new SourceGrid.Cells.ColumnHeader("Эмпирические коэффициенты скорости резания");
            grid20[row, 0].ColumnSpan = 4;
            row++;

            grid20[row, 0] = new SourceGrid.Cells.ColumnHeader("Сv");
            grid20[row, 0].ColumnSpan = 2;
            grid20[row, 2] = new SourceGrid.Cells.Cell();
            grid20[row, 3] = new SourceGrid.Cells.ColumnHeader("б/р");
            row++;

            grid20[row, 0] = new SourceGrid.Cells.ColumnHeader("q");
            grid20[row, 0].ColumnSpan = 2;
            grid20[row, 2] = new SourceGrid.Cells.Cell();
            grid20[row, 3] = new SourceGrid.Cells.ColumnHeader("б/р");
            row++;

            grid20[row, 0] = new SourceGrid.Cells.ColumnHeader("x");
            grid20[row, 0].ColumnSpan = 2;
            grid20[row, 2] = new SourceGrid.Cells.Cell();
            grid20[row, 3] = new SourceGrid.Cells.ColumnHeader("б/р");
            row++;

            grid20[row, 0] = new SourceGrid.Cells.ColumnHeader("y");
            grid20[row, 0].ColumnSpan = 2;
            grid20[row, 2] = new SourceGrid.Cells.Cell();
            grid20[row, 3] = new SourceGrid.Cells.ColumnHeader("б/р");
            row++;

            grid20[row, 0] = new SourceGrid.Cells.ColumnHeader("u");
            grid20[row, 0].ColumnSpan = 2;
            grid20[row, 2] = new SourceGrid.Cells.Cell();
            grid20[row, 3] = new SourceGrid.Cells.ColumnHeader("б/р");
            row++;

            grid20[row, 0] = new SourceGrid.Cells.ColumnHeader("p");
            grid20[row, 0].ColumnSpan = 2;
            grid20[row, 2] = new SourceGrid.Cells.Cell();
            grid20[row, 3] = new SourceGrid.Cells.ColumnHeader("б/р");
            row++;

            grid20[row, 0] = new SourceGrid.Cells.ColumnHeader("m");
            grid20[row, 0].ColumnSpan = 2;
            grid20[row, 2] = new SourceGrid.Cells.Cell();
            grid20[row, 3] = new SourceGrid.Cells.ColumnHeader("б/р");
            row++;

            grid20[row, 0] = new SourceGrid.Cells.ColumnHeader("Эмпирические коэффициенты силы резания");
            grid20[row, 0].ColumnSpan = 4;
            row++;

            grid20[row, 0] = new SourceGrid.Cells.ColumnHeader("Ср");
            grid20[row, 0].ColumnSpan = 2;
            grid20[row, 2] = new SourceGrid.Cells.Cell();
            grid20[row, 3] = new SourceGrid.Cells.ColumnHeader("б/р");
            row++;

            grid20[row, 0] = new SourceGrid.Cells.ColumnHeader("q");
            grid20[row, 0].ColumnSpan = 2;
            grid20[row, 2] = new SourceGrid.Cells.Cell();
            grid20[row, 3] = new SourceGrid.Cells.ColumnHeader("б/р");
            row++;

            grid20[row, 0] = new SourceGrid.Cells.ColumnHeader("x");
            grid20[row, 0].ColumnSpan = 2;
            grid20[row, 2] = new SourceGrid.Cells.Cell();
            grid20[row, 3] = new SourceGrid.Cells.ColumnHeader("б/р");
            row++;

            grid20[row, 0] = new SourceGrid.Cells.ColumnHeader("y");
            grid20[row, 0].ColumnSpan = 2;
            grid20[row, 2] = new SourceGrid.Cells.Cell();
            grid20[row, 3] = new SourceGrid.Cells.ColumnHeader("б/р");
            row++;

            grid20[row, 0] = new SourceGrid.Cells.ColumnHeader("u");
            grid20[row, 0].ColumnSpan = 2;
            grid20[row, 2] = new SourceGrid.Cells.Cell();
            grid20[row, 3] = new SourceGrid.Cells.ColumnHeader("б/р");
            row++;

            grid20[row, 0] = new SourceGrid.Cells.ColumnHeader("w");
            grid20[row, 0].ColumnSpan = 2;
            grid20[row, 2] = new SourceGrid.Cells.Cell();
            grid20[row, 3] = new SourceGrid.Cells.ColumnHeader("б/р");

            // Добавляем возможность редактировать и указываем событие при изменении значения
            for (int r = 1; r < grid20.RowsCount; r++)
            {
                if (r != 3 && r != 9 && r != 14)
                {
                    grid20[r, 2].Editor = tb;
                    grid20[r, 2].AddController(CellChangedEvent);
                    grid20[r, 2].AddController(new MyCellTracking());//наведение
                    grid20[r, 2].AddController(new MyHelpRowTracking());//help row pointer
                }
            }


            #endregion


            foreach (SourceGrid.GridColumn col in grid20.Columns)
                col.Width = 80;
            grid20.Columns[0].Width = 100;
            foreach (SourceGrid.GridRow r in grid20.Rows)
                r.Height = 25;
        }
        private void DoFullResultTab2_Milling()
        {
            #region Код таблицы
            grid21.BorderStyle = BorderStyle.FixedSingle;
            grid21.Redim(6, 4);
            int row = 0;
            grid21[row, 0] = new SourceGrid.Cells.ColumnHeader("Выходные параметры");
            grid21[row, 0].ColumnSpan = 4;

            row++;
            grid21[row, 0] = new SourceGrid.Cells.RowHeader("Скорость резания");
            grid21[row, 1] = new SourceGrid.Cells.RowHeader();

            grid21[row, 1] = new SourceGrid.Cells.Cell();
            //Properties.Resources.V2.SetResolution((float)(Properties.Resources.V2.HorizontalResolution * 0.3), (float)(Properties.Resources.V2.VerticalResolution * 0.3));
            grid21[row, 1].Image = Properties.Resources.V1;

            grid21[row, 2] = new SourceGrid.Cells.Cell();
            grid21[row, 3] = new SourceGrid.Cells.Cell("м/мин");
            row++;
            grid21[row, 0] = new SourceGrid.Cells.RowHeader("Сила резания");
            grid21[row, 1] = new SourceGrid.Cells.RowHeader();

            grid21[row, 1] = new SourceGrid.Cells.Cell();
            grid21[row, 1].Image = Properties.Resources.P1;

            grid21[row, 2] = new SourceGrid.Cells.Cell();
            grid21[row, 3] = new SourceGrid.Cells.Cell("Н");
            row++;
            grid21[row, 0] = new SourceGrid.Cells.RowHeader("Момент резания");
            grid21[row, 1] = new SourceGrid.Cells.RowHeader();

            grid21[row, 1] = new SourceGrid.Cells.Cell();
            Bitmap bm = new Bitmap(Properties.Resources.M1);
            bm.SetResolution(96.0F, 96.0F);
            grid21[row, 1].Image = bm;//Properties.Resources.M2;

            grid21[row, 2] = new SourceGrid.Cells.Cell();
            grid21[row, 3] = new SourceGrid.Cells.Cell("Нм");

            row++;
            grid21[row, 0] = new SourceGrid.Cells.RowHeader("Потребляемая мощность");
            grid21[row, 1] = new SourceGrid.Cells.RowHeader();

            grid21[row, 1] = new SourceGrid.Cells.Cell();
            grid21[row, 1].Image = Properties.Resources.N1;

            grid21[row, 2] = new SourceGrid.Cells.Cell();
            grid21[row, 3] = new SourceGrid.Cells.Cell("кВт");


            row++;
            grid21[row, 0] = new SourceGrid.Cells.RowHeader("Частота вращения шпинделя");
            grid21[row, 1] = new SourceGrid.Cells.RowHeader();

            grid21[row, 1] = new SourceGrid.Cells.Cell();
            grid21[row, 1].Image = Properties.Resources.n_2_1;

            grid21[row, 2] = new SourceGrid.Cells.Cell();
            grid21[row, 3] = new SourceGrid.Cells.Cell("об/мин");

            grid21.Columns[0].Width = 130;
            grid21.Columns[1].Width = 350;
            grid21.Columns[2].Width = 70;
            grid21.Columns[3].Width = 70;

            grid21.Rows[0].Height = 36;
            grid21.Rows[1].Height = 60;
            grid21.Rows[2].Height = 60;
            grid21.Rows[3].Height = 60;
            grid21.Rows[4].Height = 60;
            grid21.Rows[5].Height = 60;

            #endregion
        }
        private void DoFullGrid20_Milling()
        {
            grid20[1, 2].Value = ms.inputData.s;
            grid20[2, 2].Value = ms.inputData.t;
            grid20[3, 2].Value = ms.inputData.T;
            grid20[4, 2].Value = ms.inputData.D;
            grid20[5, 2].Value = ms.inputData.z;
            grid20[6, 2].Value = ms.inputData.B;
            grid20[7, 2].Value = ms.inputData.Kv;
            grid20[8, 2].Value = ms.inputData.Kp;

            grid20[10, 2].Value = ms.inputData.Cv;
            grid20[11, 2].Value = ms.inputData.qv;
            grid20[12, 2].Value = ms.inputData.xv;
            grid20[13, 2].Value = ms.inputData.yv;
            grid20[14, 2].Value = ms.inputData.uv;
            grid20[15, 2].Value = ms.inputData.pv;
            grid20[16, 2].Value = ms.inputData.mv;

            grid20[18, 2].Value = ms.inputData.Cp;
            grid20[19, 2].Value = ms.inputData.qp;
            grid20[20, 2].Value = ms.inputData.xp;
            grid20[21, 2].Value = ms.inputData.yp;
            grid20[22, 2].Value = ms.inputData.up;
            grid20[23, 2].Value = ms.inputData.wp;


        }
        private void DoFullGrid21_Milling()
        {
            grid21[1, 2].Value = ms.getV();
            grid21[2, 2].Value = ms.getP();
            grid21[3, 2].Value = ms.getM();
            grid21[4, 2].Value = ms.getN();
            grid21[5, 2].Value = ms.getn();
            //
        }

        #region Заполнение таблиц сверления
        private void DoFullTab1_Drill()
        {
            SQLreader sqlReader = new SQLreader("databaseD.sqlite");
            SQLiteDataReader sqlite_datareader = sqlReader.getReader("drill_table1");
            #region Код таблицы 1
            grid9.BorderStyle = BorderStyle.FixedSingle;
            grid9.Redim(10, 8);
            grid9.Rows.Insert(0);
            SourceGrid.Cells.Views.Cell viewImage = new SourceGrid.Cells.Views.Cell();
            grid9[0, 0] = new SourceGrid.Cells.ColumnHeader("Сверление");
            grid9[0, 0].ColumnSpan = 8;
            grid9[0, 0].Column.Width = 80;
            grid9[1, 0] = new SourceGrid.Cells.Cell("t=0.5D");
            grid9[1, 0].ColumnSpan = 8;
            grid9[2, 0] = new SourceGrid.Cells.ColumnHeader("Рассверливание");
            grid9[2, 0].ColumnSpan = 8;
            grid9[3, 0] = new SourceGrid.Cells.RowHeader("Предварительное");
            grid9[3, 0].ColumnSpan = 2;
            grid9[4, 0] = new SourceGrid.Cells.RowHeader("Окончательное");
            grid9[4, 0].ColumnSpan = 2;

            for (int r = 3; r < 5; r++)
            {
                if (sqlite_datareader.Read())
                {
                    grid9[r, 2] = new SourceGrid.Cells.ColumnHeader(Convert.ToString(sqlite_datareader.GetString(0)));
                    grid9[r, 2].ColumnSpan = 3;
                    grid9[r, 5] = new SourceGrid.Cells.Cell(Convert.ToString(sqlite_datareader.GetString(1)));
                    grid9[r, 5].ColumnSpan = 3;
                }
            }
            grid9[1, 0].AddController(cellpointer);//наведение
            grid9[1, 0].AddController(clickEvent);//клик мыши
            //Editor.EnableEdit = false;
            grid9[1, 0].AddController(new SourceGrid.Cells.Controllers.Unselectable());
            grid9[1, 0].AddController(new MyHelpRowTracking());//help row pointer

            grid9[3, 5].AddController(cellpointer);//наведение
            grid9[3, 5].AddController(clickEvent);//клик мыши
            //Editor.EnableEdit = false;
            grid9[3, 5].AddController(new SourceGrid.Cells.Controllers.Unselectable());
            grid9[3, 5].AddController(new MyHelpRowTracking());//help row pointer

            grid9[4, 5].AddController(cellpointer);//наведение
            grid9[4, 5].AddController(clickEvent);//клик мыши
            //Editor.EnableEdit = false;
            grid9[4, 5].AddController(new SourceGrid.Cells.Controllers.Unselectable());
            grid9[4, 5].AddController(new MyHelpRowTracking());//help row pointer
            #endregion
            sqlite_datareader = sqlReader.getReader("drill_table2");
            #region Код таблицы 2
            grid9[5, 0] = new SourceGrid.Cells.ColumnHeader("Зенкерование");
            grid9[5, 0].ColumnSpan = 8;
            grid9[6, 0] = new SourceGrid.Cells.ColumnHeader("D, мм");
            grid9[7, 0] = new SourceGrid.Cells.ColumnHeader("t, мм");

            grid9[6, 1] = new SourceGrid.Cells.ColumnHeader("<20");
            grid9[6, 2] = new SourceGrid.Cells.ColumnHeader(">20-35");
            grid9[6, 3] = new SourceGrid.Cells.ColumnHeader(">35-45");
            grid9[6, 4] = new SourceGrid.Cells.ColumnHeader(">45-50");
            grid9[6, 5] = new SourceGrid.Cells.ColumnHeader(">50-60");
            grid9[6, 6] = new SourceGrid.Cells.ColumnHeader(">60-70");
            grid9[6, 7] = new SourceGrid.Cells.ColumnHeader(">70-80");
            for (int r = 7; r < 8; r++)
            {
                if (sqlite_datareader.Read())
                {
                    grid9[r, 1] = new SourceGrid.Cells.Cell(Convert.ToString(sqlite_datareader.GetString(0)));
                    grid9[r, 2] = new SourceGrid.Cells.Cell(Convert.ToString(sqlite_datareader.GetString(1)));
                    grid9[r, 3] = new SourceGrid.Cells.Cell(Convert.ToString(sqlite_datareader.GetString(2)));
                    grid9[r, 4] = new SourceGrid.Cells.Cell(Convert.ToString(sqlite_datareader.GetString(3)));
                    grid9[r, 5] = new SourceGrid.Cells.Cell(Convert.ToString(sqlite_datareader.GetString(4)));
                    grid9[r, 6] = new SourceGrid.Cells.Cell(Convert.ToString(sqlite_datareader.GetString(5)));
                    grid9[r, 7] = new SourceGrid.Cells.Cell(Convert.ToString(sqlite_datareader.GetString(6)));

                }
            }
            //
            #endregion
            sqlite_datareader = sqlReader.getReader("drill_table3");
            #region Код таблицы 3
            grid9[8, 0] = new SourceGrid.Cells.ColumnHeader("Развертывание");
            grid9[8, 0].ColumnSpan = 8;
            grid9[9, 0] = new SourceGrid.Cells.ColumnHeader("D, мм");
            grid9[10, 0] = new SourceGrid.Cells.ColumnHeader("t, мм");

            grid9[9, 1] = new SourceGrid.Cells.ColumnHeader("<5");
            grid9[9, 2] = new SourceGrid.Cells.ColumnHeader(">5-10");
            grid9[9, 3] = new SourceGrid.Cells.ColumnHeader(">10-15");
            grid9[9, 4] = new SourceGrid.Cells.ColumnHeader(">15-30");
            grid9[9, 5] = new SourceGrid.Cells.ColumnHeader(">30-50");
            grid9[9, 6] = new SourceGrid.Cells.ColumnHeader(">50-60");
            grid9[9, 7] = new SourceGrid.Cells.ColumnHeader(">60-80");
            {
                int r = 10;
                if (sqlite_datareader.Read())
                {
                    grid9[r, 1] = new SourceGrid.Cells.Cell(Convert.ToString(sqlite_datareader.GetString(0)));
                    grid9[r, 2] = new SourceGrid.Cells.Cell(Convert.ToString(sqlite_datareader.GetString(1)));
                    grid9[r, 3] = new SourceGrid.Cells.Cell(Convert.ToString(sqlite_datareader.GetString(2)));
                    grid9[r, 4] = new SourceGrid.Cells.Cell(Convert.ToString(sqlite_datareader.GetString(3)));
                    grid9[r, 5] = new SourceGrid.Cells.Cell(Convert.ToString(sqlite_datareader.GetString(4)));
                    grid9[r, 6] = new SourceGrid.Cells.Cell(Convert.ToString(sqlite_datareader.GetString(5)));
                    grid9[r, 7] = new SourceGrid.Cells.Cell(Convert.ToString(sqlite_datareader.GetString(6)));
                }
            }

            for (int r = 7; r < 11; r = r + 3)
            {
                for (int c = 1; c < 8; c++)
                {
                    grid9[r, c].AddController(cellpointer);//наведение
                    grid9[r, c].AddController(clickEvent);//клик мыши
                    //Editor.EnableEdit = false;
                    grid9[r, c].AddController(new SourceGrid.Cells.Controllers.Unselectable());
                    grid9[r, c].AddController(new MyHelpRowTracking());//help row pointer
                }
            }
            #endregion


            foreach (SourceGrid.GridColumn col in grid9.Columns)
                col.Width = 100;
            grid9.Columns[0].Width = 150;
            foreach (SourceGrid.GridRow r in grid9.Rows)
                r.Height = 25;
        }
        private void DoFullTab2_Drill()
        {

            SQLreader sqlReader = new SQLreader("databaseD.sqlite");
            SQLiteDataReader sqlite_datareader = sqlReader.getReader("drill_table4");
            #region Код таблицы
            grid10.BorderStyle = BorderStyle.FixedSingle;
            grid10.Redim(19, 5);
            SourceGrid.Cells.Views.Cell viewImage = new SourceGrid.Cells.Views.Cell();
            grid10[0, 0] = new SourceGrid.Cells.ColumnHeader("Сверление и рассверливание");
            grid10[0, 0].ColumnSpan = 5;
            grid10[0, 0].Column.Width = 80;
            grid10[1, 0] = new SourceGrid.Cells.ColumnHeader("D, мм");
            grid10[1, 0].RowSpan = 3;
            grid10[1, 1] = new SourceGrid.Cells.ColumnHeader("Сверление");
            grid10[1, 1].ColumnSpan = 2;
            grid10[1, 3] = new SourceGrid.Cells.ColumnHeader("Рассверливание");
            grid10[1, 3].ColumnSpan = 2;
            grid10[2, 1] = new SourceGrid.Cells.ColumnHeader("Сталь");
            grid10[2, 2] = new SourceGrid.Cells.ColumnHeader("Серый\nчугун");
            grid10[2, 2].Row.Height = 30;
            grid10[2, 3] = new SourceGrid.Cells.ColumnHeader("Сталь");
            grid10[2, 4] = new SourceGrid.Cells.ColumnHeader("Серый\nчугун");
            grid10[3, 1] = new SourceGrid.Cells.ColumnHeader("S, мм/об");
            grid10[3, 1].ColumnSpan = 4;

            for (int r = 4; r < 9; r++)
            {
                if (sqlite_datareader.Read())
                {
                    grid10[r, 0] = new SourceGrid.Cells.ColumnHeader(Convert.ToString(sqlite_datareader.GetString(0)));
                    grid10[r, 1] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(1)));
                    grid10[r, 2] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(2)));
                    grid10[r, 3] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(3)));
                    grid10[r, 4] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(4)));

                }
                for (int c = 1; c < 5; c++)
                {
                    grid10[r, c].AddController(cellpointer);//наведение
                    grid10[r, c].AddController(clickEvent);//клик мыши
                    //Editor.EnableEdit = false;
                    grid10[r, c].AddController(new SourceGrid.Cells.Controllers.Unselectable());
                    grid10[r, c].AddController(new MyHelpRowTracking());//help row pointer
                }
            }

            #endregion
            sqlite_datareader = sqlReader.getReader("drill_table5");
            #region Код таблицы
            grid10[9, 0] = new SourceGrid.Cells.ColumnHeader("Зенкерование и развертывание");
            grid10[9, 0].ColumnSpan = 5;
            grid10[10, 0] = new SourceGrid.Cells.ColumnHeader("Обрабатываемый материал");
            grid10[10, 0].RowSpan = 3;
            grid10[10, 1] = new SourceGrid.Cells.ColumnHeader("D, мм");
            grid10[10, 1].ColumnSpan = 4;
            grid10[11, 1] = new SourceGrid.Cells.ColumnHeader("<15");
            grid10[11, 2] = new SourceGrid.Cells.ColumnHeader(">15-25");
            grid10[11, 3] = new SourceGrid.Cells.ColumnHeader(">25-35");
            grid10[11, 4] = new SourceGrid.Cells.ColumnHeader(">35-50");
            grid10[12, 1] = new SourceGrid.Cells.ColumnHeader("S, мм/об");
            grid10[12, 1].ColumnSpan = 4;
            grid10[13, 0] = new SourceGrid.Cells.ColumnHeader("Зенкерование");
            grid10[13, 0].ColumnSpan = 5;
            grid10[14, 0] = new SourceGrid.Cells.ColumnHeader("Сталь");
            grid10[15, 0] = new SourceGrid.Cells.ColumnHeader("Серый чугун");
            grid10[17, 0] = new SourceGrid.Cells.ColumnHeader("Сталь");
            grid10[18, 0] = new SourceGrid.Cells.ColumnHeader("Серый чугун");


            for (int r = 14; r < 19; r++)
            {
                if (r == 16)
                {
                    grid10[r, 0] = new SourceGrid.Cells.ColumnHeader("Развертывание");
                    grid10[r, 0].ColumnSpan = 5;
                }
                else
                {
                    if (sqlite_datareader.Read())
                    {
                        grid10[r, 1] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(0)));
                        grid10[r, 2] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(1)));
                        grid10[r, 3] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(2)));
                        grid10[r, 4] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(3)));

                    }
                    for (int c = 1; c < 5; c++)
                    {
                        grid10[r, c].AddController(cellpointer);//наведение
                        grid10[r, c].AddController(clickEvent);//клик мыши
                        //Editor.EnableEdit = false;
                        grid10[r, c].AddController(new SourceGrid.Cells.Controllers.Unselectable());
                        grid10[r, c].AddController(new MyHelpRowTracking());//help row pointer
                    }
                }

            }



            #endregion


            foreach (SourceGrid.GridColumn col in grid10.Columns)
                col.Width = 100;
            grid10.Columns[0].Width = 150;
            foreach (SourceGrid.GridRow r in grid10.Rows)
                r.Height = 25;
        }
        private void DoFullTab3_Drill()
        {
            SQLreader sqlReader = new SQLreader("databaseD.sqlite");
            SQLiteDataReader sqlite_datareader = sqlReader.getReader("drill_table6");
            #region Код таблицы
            grid11.BorderStyle = BorderStyle.FixedSingle;
            grid11.Redim(3, 2);
            SourceGrid.Cells.Views.Cell viewImage = new SourceGrid.Cells.Views.Cell();
            grid11[0, 0] = new SourceGrid.Cells.ColumnHeader("Обрабатываемый материал");
            grid11[0, 0].Column.Width = 200;
            grid11[0, 1] = new SourceGrid.Cells.ColumnHeader("Kмv");
            grid11[1, 0] = new SourceGrid.Cells.RowHeader("Сталь");
            grid11[2, 0] = new SourceGrid.Cells.RowHeader("Серый чугун");

            for (int r = 1; r < 3; r++)
            {
                if (sqlite_datareader.Read())
                {
                    grid11[r, 1] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(0)));
                }
                {
                    int c = 1;
                    grid11[r, c].AddController(cellpointer);//наведение
                    grid11[r, c].AddController(clickEvent);//клик мыши
                    //Editor.EnableEdit = false;
                    grid11[r, c].AddController(new SourceGrid.Cells.Controllers.Unselectable());
                    grid11[r, c].AddController(new MyHelpRowTracking());//help row pointer
                }
            }

            #endregion


            foreach (SourceGrid.GridColumn col in grid11.Columns)
                col.Width = 100;
            grid11.Columns[0].Width = 150;
            foreach (SourceGrid.GridRow r in grid11.Rows)
                r.Height = 25;
        }
        private void DoFullTab4_Drill()
        {
            SQLreader sqlReader = new SQLreader("databaseD.sqlite");
            SQLiteDataReader sqlite_datareader = sqlReader.getReader("drill_table7");
            #region Код таблицы
            grid12.BorderStyle = BorderStyle.FixedSingle;
            grid12.Redim(3, 4);
            SourceGrid.Cells.Views.Cell viewImage = new SourceGrid.Cells.Views.Cell();
            grid12[0, 0] = new SourceGrid.Cells.ColumnHeader("Заготовка не обработанная");
            grid12[0, 0].ColumnSpan = 3;
            grid12[0, 0].Column.Width = 100;
            grid12[0, 3] = new SourceGrid.Cells.ColumnHeader("Полуфабрикаты \n обработанные");
            grid12[0, 3].Column.Width = 100;
            grid12[0, 3].RowSpan = 2;
            grid12[1, 0] = new SourceGrid.Cells.ColumnHeader("Поковка");
            grid12[1, 1] = new SourceGrid.Cells.ColumnHeader("Отливка");
            grid12[1, 1].Column.Width = 80;
            grid12[1, 2] = new SourceGrid.Cells.ColumnHeader("Прокат");

            {
                int r = 2;
                if (sqlite_datareader.Read())
                {
                    grid12[r, 0] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(0)));
                    grid12[r, 1] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(1)));
                    grid12[r, 2] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(2)));
                    grid12[r, 3] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(3)));
                }
                for (int c = 0; c < 4; c++)
                {
                    grid12[r, c].AddController(cellpointer);//наведение
                    grid12[r, c].AddController(clickEvent);//клик мыши
                    //Editor.EnableEdit = false;
                    grid12[r, c].AddController(new SourceGrid.Cells.Controllers.Unselectable());
                    grid12[r, c].AddController(new MyHelpRowTracking());//help row pointer
                }
            }

            #endregion


            foreach (SourceGrid.GridColumn col in grid12.Columns)
                col.Width = 100;
            grid12.Columns[0].Width = 150;
            foreach (SourceGrid.GridRow r in grid12.Rows)
                r.Height = 25;
        }
        private void DoFullTab5_Drill()
        {
            SQLreader sqlReader = new SQLreader("databaseD.sqlite");
            SQLiteDataReader sqlite_datareader = sqlReader.getReader("drill_table8");
            #region Код таблицы
            grid13.BorderStyle = BorderStyle.FixedSingle;
            grid13.Redim(2, 6);
            SourceGrid.Cells.Views.Cell viewImage = new SourceGrid.Cells.Views.Cell();
            grid13[0, 0] = new SourceGrid.Cells.ColumnHeader("L/D");
            grid13[0, 1] = new SourceGrid.Cells.ColumnHeader("<30");
            grid13[0, 2] = new SourceGrid.Cells.ColumnHeader(">30-40");
            grid13[0, 3] = new SourceGrid.Cells.ColumnHeader(">40-50");
            grid13[0, 4] = new SourceGrid.Cells.ColumnHeader(">50-60");
            grid13[0, 5] = new SourceGrid.Cells.ColumnHeader(">60-80");
            grid13[1, 0] = new SourceGrid.Cells.ColumnHeader("Кг");


            {
                int r = 1;
                if (sqlite_datareader.Read())
                {
                    for (int c = 0; c < 5; c++)
                    {
                        grid13[r, c + 1] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(c)));
                        grid13[r, c + 1].AddController(cellpointer);//наведение
                        grid13[r, c + 1].AddController(clickEvent);//клик мыши
                        //Editor.EnableEdit = false;
                        grid13[r, c + 1].AddController(new SourceGrid.Cells.Controllers.Unselectable());
                        grid13[r, c + 1].AddController(new MyHelpRowTracking());//help row pointer
                    }
                }
            }

            #endregion


            foreach (SourceGrid.GridColumn col in grid13.Columns)
                col.Width = 100;
            grid13.Columns[0].Width = 150;
            foreach (SourceGrid.GridRow r in grid13.Rows)
                r.Height = 25;
        }
        private void DoFullTab6_Drill()
        {
            SQLreader sqlReader = new SQLreader("databaseD.sqlite");
            SQLiteDataReader sqlite_datareader = sqlReader.getReader("drill_table9");
            #region Код таблицы
            grid14.BorderStyle = BorderStyle.FixedSingle;
            grid14.Redim(22, 8);
            SourceGrid.Cells.Views.Cell viewImage = new SourceGrid.Cells.Views.Cell();
            grid14[0, 0] = new SourceGrid.Cells.ColumnHeader("Обрабатываемый\nматериал");
            grid14[0, 0].RowSpan = 2;
            grid14[0, 0].Column.Width = 100;
            grid14[0, 1] = new SourceGrid.Cells.ColumnHeader("Инструментальный\nматериал");
            grid14[0, 1].RowSpan = 2;
            grid14[0, 1].Column.Width = 140;
            grid14[0, 2] = new SourceGrid.Cells.ColumnHeader("S, мм/об");
            grid14[0, 2].RowSpan = 2;
            grid14[0, 2].Column.Width = 60;
            grid14[0, 3] = new SourceGrid.Cells.ColumnHeader("Cv");
            grid14[0, 4] = new SourceGrid.Cells.ColumnHeader("q");
            grid14[0, 5] = new SourceGrid.Cells.ColumnHeader("x");
            grid14[0, 6] = new SourceGrid.Cells.ColumnHeader("y");
            grid14[0, 7] = new SourceGrid.Cells.ColumnHeader("m");
            grid14[1, 3] = new SourceGrid.Cells.ColumnHeader("Сверление");
            grid14[1, 3].ColumnSpan = 5;
            grid14[2, 0] = new SourceGrid.Cells.RowHeader("Сталь");
            grid14[2, 0].RowSpan = 2;
            grid14[2, 1] = new SourceGrid.Cells.RowHeader("Быстрорежущая\nсталь");
            grid14[2, 1].RowSpan = 4;
            grid14[4, 0] = new SourceGrid.Cells.RowHeader("Серый чугун");
            grid14[4, 0].RowSpan = 3;
            grid14[6, 1] = new SourceGrid.Cells.RowHeader("Твердый\nсплав");

            for (int r = 2; r < 7; r++)
            {

                if (sqlite_datareader.Read())
                {
                    grid14[r, 2] = new SourceGrid.Cells.Cell(Convert.ToString(sqlite_datareader.GetString(2)));
                    grid14[r, 3] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(3)));
                    grid14[r, 4] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(4)));
                    grid14[r, 5] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(5)));
                    grid14[r, 6] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(6)));
                    grid14[r, 7] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(7)));

                    for (int c = 2; c < 8; c++)
                    {
                        grid14[r, c].AddController(rowpointer);//наведение
                        grid14[r, c].AddController(clickEvent);//клик мыши
                        //Editor.EnableEdit = false;
                        grid14[r, c].AddController(new SourceGrid.Cells.Controllers.Unselectable());
                        grid14[r, c].AddController(new MyHelpRowTracking());//help row pointer
                    }
                }
            }
            grid14[7, 0] = new SourceGrid.Cells.ColumnHeader("Рассверливание");
            grid14[7, 0].ColumnSpan = 8;
            grid14[8, 0] = new SourceGrid.Cells.RowHeader("Сталь");
            grid14[8, 0].RowSpan = 2;
            grid14[10, 0] = new SourceGrid.Cells.RowHeader("Серый чугун");
            grid14[10, 0].RowSpan = 2;


            for (int r = 8; r < 12; r++)
            {

                if (sqlite_datareader.Read())
                {
                    grid14[r, 1] = new SourceGrid.Cells.RowHeader(Convert.ToString(sqlite_datareader.GetString(1)));
                    grid14[r, 2] = new SourceGrid.Cells.Cell(Convert.ToString(sqlite_datareader.GetString(2)));
                    grid14[r, 3] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(3)));
                    grid14[r, 4] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(4)));
                    grid14[r, 5] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(5)));
                    grid14[r, 6] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(6)));
                    grid14[r, 7] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(7)));

                    for (int c = 2; c < 8; c++)
                    {
                        grid14[r, c].AddController(rowpointer);//наведение
                        grid14[r, c].AddController(clickEvent);//клик мыши
                        //Editor.EnableEdit = false;
                        grid14[r, c].AddController(new SourceGrid.Cells.Controllers.Unselectable());
                        grid14[r, c].AddController(new MyHelpRowTracking());//help row pointer
                    }
                }
            }
            grid14[12, 0] = new SourceGrid.Cells.ColumnHeader("Зенкерование");
            grid14[12, 0].ColumnSpan = 8;
            grid14[13, 0] = new SourceGrid.Cells.RowHeader("Сталь");
            grid14[13, 0].RowSpan = 2;
            grid14[15, 0] = new SourceGrid.Cells.RowHeader("Серый чугун");
            grid14[15, 0].RowSpan = 2;


            for (int r = 13; r < 17; r++)
            {

                if (sqlite_datareader.Read())
                {
                    grid14[r, 1] = new SourceGrid.Cells.RowHeader(Convert.ToString(sqlite_datareader.GetString(1)));
                    grid14[r, 2] = new SourceGrid.Cells.Cell(Convert.ToString(sqlite_datareader.GetString(2)));
                    grid14[r, 3] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(3)));
                    grid14[r, 4] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(4)));
                    grid14[r, 5] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(5)));
                    grid14[r, 6] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(6)));
                    grid14[r, 7] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(7)));

                    for (int c = 2; c < 8; c++)
                    {
                        grid14[r, c].AddController(rowpointer);//наведение
                        grid14[r, c].AddController(clickEvent);//клик мыши
                        //Editor.EnableEdit = false;
                        grid14[r, c].AddController(new SourceGrid.Cells.Controllers.Unselectable());
                        grid14[r, c].AddController(new MyHelpRowTracking());//help row pointer
                    }
                }
            }
            grid14[17, 0] = new SourceGrid.Cells.ColumnHeader("Развертывание");
            grid14[17, 0].ColumnSpan = 8;
            grid14[18, 0] = new SourceGrid.Cells.RowHeader("Сталь");
            grid14[18, 0].RowSpan = 2;
            grid14[20, 0] = new SourceGrid.Cells.RowHeader("Серый чугун");
            grid14[20, 0].RowSpan = 2;


            for (int r = 18; r < 22; r++)
            {

                if (sqlite_datareader.Read())
                {
                    grid14[r, 1] = new SourceGrid.Cells.RowHeader(Convert.ToString(sqlite_datareader.GetString(1)));
                    grid14[r, 2] = new SourceGrid.Cells.Cell(Convert.ToString(sqlite_datareader.GetString(2)));
                    grid14[r, 3] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(3)));
                    grid14[r, 4] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(4)));
                    grid14[r, 5] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(5)));
                    grid14[r, 6] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(6)));
                    grid14[r, 7] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(7)));

                    for (int c = 2; c < 8; c++)
                    {
                        grid14[r, c].AddController(rowpointer);//наведение
                        grid14[r, c].AddController(clickEvent);//клик мыши
                        //Editor.EnableEdit = false;
                        grid14[r, c].AddController(new SourceGrid.Cells.Controllers.Unselectable());
                        grid14[r, c].AddController(new MyHelpRowTracking());//help row pointer
                    }
                }
            }

            #endregion


            foreach (SourceGrid.GridColumn col in grid14.Columns)
                col.Width = 80;
            grid14.Columns[0].Width = 100;
            foreach (SourceGrid.GridRow r in grid14.Rows)
                r.Height = 25;
        }
        private void DoFullTab7_Drill()
        {
            SQLreader sqlReader = new SQLreader("databaseD.sqlite");
            SQLiteDataReader sqlite_datareader = sqlReader.getReader("drill_table10");
            #region Код таблицы
            grid15.BorderStyle = BorderStyle.FixedSingle;
            grid15.Redim(10, 11);
            SourceGrid.Cells.Views.Cell viewImage = new SourceGrid.Cells.Views.Cell();
            grid15[0, 0] = new SourceGrid.Cells.ColumnHeader("Обрабатываемый\nматериал");
            grid15[0, 0].RowSpan = 4;
            grid15[0, 0].Column.Width = 100;
            grid15[0, 1] = new SourceGrid.Cells.ColumnHeader("Вид\nобработки");
            grid15[0, 1].RowSpan = 4;
            grid15[0, 1].Column.Width = 100;
            grid15[0, 2] = new SourceGrid.Cells.ColumnHeader("Инструментальный\nматериал");
            grid15[0, 2].RowSpan = 4;
            grid15[0, 2].Column.Width = 100;
            grid15[0, 3] = new SourceGrid.Cells.ColumnHeader("Расчетный параметр режима резания");
            grid15[0, 3].ColumnSpan = 8;
            grid15[1, 3] = new SourceGrid.Cells.ColumnHeader("Mкр");
            grid15[1, 3].ColumnSpan = 4;
            grid15[1, 7] = new SourceGrid.Cells.ColumnHeader("Po");
            grid15[1, 7].ColumnSpan = 4;
            grid15[2, 3] = new SourceGrid.Cells.ColumnHeader("Эмпирические константы");
            grid15[2, 3].ColumnSpan = 8;
            grid15[3, 3] = new SourceGrid.Cells.ColumnHeader("Cм");
            grid15[3, 4] = new SourceGrid.Cells.ColumnHeader("q");
            grid15[3, 5] = new SourceGrid.Cells.ColumnHeader("x");
            grid15[3, 6] = new SourceGrid.Cells.ColumnHeader("y");
            grid15[3, 7] = new SourceGrid.Cells.ColumnHeader("Co");
            grid15[3, 8] = new SourceGrid.Cells.ColumnHeader("q");
            grid15[3, 9] = new SourceGrid.Cells.ColumnHeader("x");
            grid15[3, 10] = new SourceGrid.Cells.ColumnHeader("y");
            grid15[4, 0] = new SourceGrid.Cells.RowHeader("Сталь");
            grid15[4, 0].RowSpan = 2;
            grid15[4, 1] = new SourceGrid.Cells.RowHeader("Сверление");
            grid15[5, 1] = new SourceGrid.Cells.RowHeader("Рассверливание\nзенкерование\nразвертывание");
            grid15[5, 1].Row.Height = 60;
            grid15[4, 2] = new SourceGrid.Cells.RowHeader("Быстрорежущая сталь");
            grid15[4, 2].RowSpan = 2;
            grid15[6, 0] = new SourceGrid.Cells.RowHeader("Серый чугун");
            grid15[6, 0].RowSpan = 4;
            grid15[6, 1] = new SourceGrid.Cells.RowHeader("Сверление");
            grid15[7, 1] = new SourceGrid.Cells.RowHeader("Рассверливание\nзенкерование\nразвертывание");
            grid15[7, 1].Row.Height = 60;
            grid15[6, 2] = new SourceGrid.Cells.RowHeader("Твердый сплав");
            grid15[6, 2].RowSpan = 2;
            grid15[8, 1] = new SourceGrid.Cells.RowHeader("Сверление");
            grid15[9, 1] = new SourceGrid.Cells.RowHeader("Рассверливание\nзенкерование\nразвертывание");
            grid15[9, 1].Row.Height = 60;
            grid15[8, 2] = new SourceGrid.Cells.RowHeader("Быстрорежущая сталь");
            grid15[8, 2].RowSpan = 2;


            for (int r = 4; r < 10; r++)
            {

                if (sqlite_datareader.Read())
                {
                    for (int c = 3; c < 11; c++)
                    {
                        try
                        {
                            grid15[r, c] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(c)));
                        }
                        catch (Exception)
                        {
                            grid15[r, c] = new SourceGrid.Cells.Cell("-");
                        }
                        grid15[r, c].AddController(rowpointer);//наведение
                        grid15[r, c].AddController(clickEvent);//клик мыши
                        //Editor.EnableEdit = false;
                        grid15[r, c].AddController(new SourceGrid.Cells.Controllers.Unselectable());
                        grid15[r, c].AddController(new MyHelpRowTracking());//help row pointer
                    }
                }
            }

            #endregion


            foreach (SourceGrid.GridColumn col in grid15.Columns)
                col.Width = 80;
            grid15.Columns[0].Width = 100;
            foreach (SourceGrid.GridRow r in grid15.Rows)
                r.Height = 25;
        }
        private void DoFullRusultTab1_Drill()
        {
            #region Код таблицы
            grid16.BorderStyle = BorderStyle.FixedSingle;
            grid16.Redim(25, 4);
            SourceGrid.Cells.Views.Cell viewImage = new SourceGrid.Cells.Views.Cell();
            SourceGrid.Cells.Editors.TextBox tb = new SourceGrid.Cells.Editors.TextBox(typeof(float));
            SourceGrid.Cells.Editors.ComboBox cb = new SourceGrid.Cells.Editors.ComboBox(typeof(float), new float[] { 20, 30, 40, 60, 90, 120 }, false);

            grid16[0, 0] = new SourceGrid.Cells.ColumnHeader("Входные параметры");
            grid16[0, 0].ColumnSpan = 4;

            grid16[1, 0] = new SourceGrid.Cells.RowHeader("Подача");
            grid16[1, 1] = new SourceGrid.Cells.RowHeader("S");
            grid16[1, 2] = new SourceGrid.Cells.Cell();
            grid16[1, 3] = new SourceGrid.Cells.Cell("мм/об");
            grid16[1, 0].Column.Width = 150;

            grid16[2, 0] = new SourceGrid.Cells.RowHeader("Глубина резания");
            grid16[2, 1] = new SourceGrid.Cells.RowHeader("t");
            grid16[2, 2] = new SourceGrid.Cells.Cell();
            grid16[2, 3] = new SourceGrid.Cells.Cell("мм");

            grid16[3, 0] = new SourceGrid.Cells.RowHeader("Период стойкости резца");
            grid16[3, 1] = new SourceGrid.Cells.RowHeader("T");
            grid16[3, 2] = new SourceGrid.Cells.Cell();
            grid16[3, 2].AddController(CellChangedEvent);
            grid16[3, 3] = new SourceGrid.Cells.Cell("мин");

            grid16[3, 2].Editor = cb;
            grid16[3, 2].Editor.EditableMode = EditableMode.SingleClick;


            grid16[4, 0] = new SourceGrid.Cells.RowHeader("Диаметр инструмента");
            grid16[4, 1] = new SourceGrid.Cells.RowHeader("D");
            grid16[4, 2] = new SourceGrid.Cells.Cell();
            grid16[4, 3] = new SourceGrid.Cells.Cell("мм");

            grid16[5, 0] = new SourceGrid.Cells.RowHeader("Диаметр исходного отверсития");
            grid16[5, 1] = new SourceGrid.Cells.RowHeader("d");
            grid16[5, 2] = new SourceGrid.Cells.Cell();
            grid16[5, 3] = new SourceGrid.Cells.Cell("мм");

            grid16[6, 0] = new SourceGrid.Cells.RowHeader("Поправка на обрабатываемый материал");
            grid16[6, 1] = new SourceGrid.Cells.RowHeader("Kмv");
            grid16[6, 2] = new SourceGrid.Cells.Cell();
            grid16[6, 3] = new SourceGrid.Cells.Cell("б/р");

            grid16[7, 0] = new SourceGrid.Cells.RowHeader("Поправка на состояние поверхности");
            grid16[7, 1] = new SourceGrid.Cells.RowHeader("Kпv");
            grid16[7, 2] = new SourceGrid.Cells.Cell();
            grid16[7, 3] = new SourceGrid.Cells.Cell("б/р");

            grid16[8, 0] = new SourceGrid.Cells.RowHeader("Поправка на глубину отверстия");
            grid16[8, 1] = new SourceGrid.Cells.RowHeader("Kг");
            grid16[8, 2] = new SourceGrid.Cells.Cell();
            grid16[8, 3] = new SourceGrid.Cells.Cell("б/р");

            grid16[9, 0] = new SourceGrid.Cells.ColumnHeader("Эмпирические коэффициенты скорости резания");
            grid16[9, 0].ColumnSpan = 4;

            grid16[10, 0] = new SourceGrid.Cells.ColumnHeader("Сv");
            grid16[10, 0].ColumnSpan = 2;
            grid16[10, 2] = new SourceGrid.Cells.Cell();
            grid16[10, 3] = new SourceGrid.Cells.ColumnHeader("б/р");

            grid16[11, 0] = new SourceGrid.Cells.ColumnHeader("q");
            grid16[11, 0].ColumnSpan = 2;
            grid16[11, 2] = new SourceGrid.Cells.Cell();
            grid16[11, 3] = new SourceGrid.Cells.ColumnHeader("б/р");

            grid16[12, 0] = new SourceGrid.Cells.ColumnHeader("x");
            grid16[12, 0].ColumnSpan = 2;
            grid16[12, 2] = new SourceGrid.Cells.Cell();
            grid16[12, 3] = new SourceGrid.Cells.ColumnHeader("б/р");

            grid16[13, 0] = new SourceGrid.Cells.ColumnHeader("y");
            grid16[13, 0].ColumnSpan = 2;
            grid16[13, 2] = new SourceGrid.Cells.Cell();
            grid16[13, 3] = new SourceGrid.Cells.ColumnHeader("б/р");

            grid16[14, 0] = new SourceGrid.Cells.ColumnHeader("m");
            grid16[14, 0].ColumnSpan = 2;
            grid16[14, 2] = new SourceGrid.Cells.Cell();
            grid16[14, 3] = new SourceGrid.Cells.ColumnHeader("б/р");

            grid16[15, 0] = new SourceGrid.Cells.ColumnHeader("Эмпирические коэффициенты момента резания");
            grid16[15, 0].ColumnSpan = 4;

            grid16[16, 0] = new SourceGrid.Cells.ColumnHeader("См");
            grid16[16, 0].ColumnSpan = 2;
            grid16[16, 2] = new SourceGrid.Cells.Cell();
            grid16[16, 3] = new SourceGrid.Cells.ColumnHeader("б/р");

            grid16[17, 0] = new SourceGrid.Cells.ColumnHeader("q");
            grid16[17, 0].ColumnSpan = 2;
            grid16[17, 2] = new SourceGrid.Cells.Cell();
            grid16[17, 3] = new SourceGrid.Cells.ColumnHeader("б/р");

            grid16[18, 0] = new SourceGrid.Cells.ColumnHeader("x");
            grid16[18, 0].ColumnSpan = 2;
            grid16[18, 2] = new SourceGrid.Cells.Cell();
            grid16[18, 3] = new SourceGrid.Cells.ColumnHeader("б/р");

            grid16[19, 0] = new SourceGrid.Cells.ColumnHeader("y");
            grid16[19, 0].ColumnSpan = 2;
            grid16[19, 2] = new SourceGrid.Cells.Cell();
            grid16[19, 3] = new SourceGrid.Cells.ColumnHeader("б/р");


            grid16[20, 0] = new SourceGrid.Cells.ColumnHeader("Эмпирические коэффициенты силы резания");
            grid16[20, 0].ColumnSpan = 4;

            grid16[21, 0] = new SourceGrid.Cells.ColumnHeader("Ср");
            grid16[21, 0].ColumnSpan = 2;
            grid16[21, 2] = new SourceGrid.Cells.Cell();
            grid16[21, 3] = new SourceGrid.Cells.ColumnHeader("б/р");

            grid16[22, 0] = new SourceGrid.Cells.ColumnHeader("q");
            grid16[22, 0].ColumnSpan = 2;
            grid16[22, 2] = new SourceGrid.Cells.Cell();
            grid16[22, 3] = new SourceGrid.Cells.ColumnHeader("б/р");

            grid16[23, 0] = new SourceGrid.Cells.ColumnHeader("x");
            grid16[23, 0].ColumnSpan = 2;
            grid16[23, 2] = new SourceGrid.Cells.Cell();
            grid16[23, 3] = new SourceGrid.Cells.ColumnHeader("б/р");

            grid16[24, 0] = new SourceGrid.Cells.ColumnHeader("y");
            grid16[24, 0].ColumnSpan = 2;
            grid16[24, 2] = new SourceGrid.Cells.Cell();
            grid16[24, 3] = new SourceGrid.Cells.ColumnHeader("б/р");

            // Добавляем возможность редактировать и указываем событие при изменении значения
            for (int r = 1; r < 25; r++)
            {
                if (r != 3 && r != 9 && r != 15 && r != 20)
                {
                    grid16[r, 2].Editor = tb;
                    grid16[r, 2].AddController(CellChangedEvent);
                    grid16[r, 2].AddController(new MyCellTracking());//наведение
                    grid16[r, 2].AddController(new MyHelpRowTracking());//help row pointer
                }
            }


            #endregion


            foreach (SourceGrid.GridColumn col in grid16.Columns)
                col.Width = 80;
            grid16.Columns[0].Width = 100;
            foreach (SourceGrid.GridRow r in grid16.Rows)
                r.Height = 25;
        }
        private void DoFullResultTab2_Drill()
        {
            #region Код таблицы
            grid17.BorderStyle = BorderStyle.FixedSingle;
            grid17.Redim(6, 4);
            grid17[0, 0] = new SourceGrid.Cells.ColumnHeader("Выходные параметры");
            grid17[0, 0].ColumnSpan = 4;

            grid17[1, 0] = new SourceGrid.Cells.RowHeader("Скорость резания");
            grid17[1, 1] = new SourceGrid.Cells.RowHeader();

            grid17[1, 1] = new SourceGrid.Cells.Cell();
            //Properties.Resources.V2.SetResolution((float)(Properties.Resources.V2.HorizontalResolution * 0.3), (float)(Properties.Resources.V2.VerticalResolution * 0.3));
            grid17[1, 1].Image = Properties.Resources.V2;

            grid17[1, 2] = new SourceGrid.Cells.Cell();
            grid17[1, 3] = new SourceGrid.Cells.Cell("м/мин");

            grid17[2, 0] = new SourceGrid.Cells.RowHeader("Момент резания");
            grid17[2, 1] = new SourceGrid.Cells.RowHeader();

            grid17[2, 1] = new SourceGrid.Cells.Cell();
            Bitmap bm = new Bitmap(Properties.Resources.M2);
            bm.SetResolution(96.0F, 96.0F);
            grid17[2, 1].Image = bm;//Properties.Resources.M2;

            grid17[2, 2] = new SourceGrid.Cells.Cell();
            grid17[2, 3] = new SourceGrid.Cells.Cell("Нм");

            grid17[3, 0] = new SourceGrid.Cells.RowHeader("Сила резания");
            grid17[3, 1] = new SourceGrid.Cells.RowHeader();

            grid17[3, 1] = new SourceGrid.Cells.Cell();
            grid17[3, 1].Image = Properties.Resources.P2;

            grid17[3, 2] = new SourceGrid.Cells.Cell();
            grid17[3, 3] = new SourceGrid.Cells.Cell("Н");

            grid17[4, 0] = new SourceGrid.Cells.RowHeader("Потребляемая мощность");
            grid17[4, 1] = new SourceGrid.Cells.RowHeader();

            grid17[4, 1] = new SourceGrid.Cells.Cell();
            grid17[4, 1].Image = Properties.Resources.N2;

            grid17[4, 2] = new SourceGrid.Cells.Cell();
            grid17[4, 3] = new SourceGrid.Cells.Cell("кВт");



            grid17[5, 0] = new SourceGrid.Cells.RowHeader("Частота вращения шпинделя");
            grid17[5, 1] = new SourceGrid.Cells.RowHeader();

            grid17[5, 1] = new SourceGrid.Cells.Cell();
            grid17[5, 1].Image = Properties.Resources.n_2_2;

            grid17[5, 2] = new SourceGrid.Cells.Cell();
            grid17[5, 3] = new SourceGrid.Cells.Cell("об/мин");

            grid17.Columns[0].Width = 130;
            grid17.Columns[1].Width = 350;
            grid17.Columns[2].Width = 70;
            grid17.Columns[3].Width = 70;

            grid17.Rows[0].Height = 36;
            grid17.Rows[1].Height = 60;
            grid17.Rows[2].Height = 60;
            grid17.Rows[3].Height = 60;
            grid17.Rows[4].Height = 60;
            grid17.Rows[5].Height = 60;



            #endregion
        }
        private void DoFullGrid16_Drill()
        {
            grid16[1, 2].Value = ds.inputData.s;
            grid16[2, 2].Value = ds.inputData.t;
            grid16[3, 2].Value = ds.inputData.T;
            grid16[4, 2].Value = ds.inputData.D;
            grid16[5, 2].Value = ds.inputData.d;
            grid16[6, 2].Value = ds.inputData.Kmv;
            grid16[7, 2].Value = ds.inputData.Kpv;
            grid16[8, 2].Value = ds.inputData.Kg;

            grid16[10, 2].Value = ds.inputData.Cv;
            grid16[11, 2].Value = ds.inputData.qv;
            grid16[12, 2].Value = ds.inputData.xv;
            grid16[13, 2].Value = ds.inputData.yv;
            grid16[14, 2].Value = ds.inputData.mv;

            grid16[16, 2].Value = ds.inputData.Cm;
            grid16[17, 2].Value = ds.inputData.qm;
            grid16[18, 2].Value = ds.inputData.xm;
            grid16[19, 2].Value = ds.inputData.ym;

            grid16[21, 2].Value = ds.inputData.Cp;
            grid16[22, 2].Value = ds.inputData.qp;
            grid16[23, 2].Value = ds.inputData.xp;
            grid16[24, 2].Value = ds.inputData.yp;


        }
        private void DoFullGrid17_Drill()
        {
            grid17[1, 2].Value = ds.getV();
            grid17[2, 2].Value = ds.getM();
            grid17[3, 2].Value = ds.getP();
            grid17[4, 2].Value = ds.getN();
            grid17[5, 2].Value = ds.getn();
            grid16[5, 2].Value = ds.inputData.d;
            grid16[2, 2].Value = ds.inputData.t;

        }
        #endregion
        /// <summary>
        /// Класс для SQLite соединения
        /// </summary>
        private class SQLreader
        {
            private SQLiteConnection sqlite_conn = new SQLiteConnection();
            public SQLreader(String source)
            {
                if (sqlite_conn.State != ConnectionState.Open)
                {
                    sqlite_conn = new SQLiteConnection("Data Source=" + source + ";Version=3;New=True;Compress=True;");
                    sqlite_conn.Open();
                }
            }
            public SQLiteDataReader getReader(String dataBaseName)
            {
                SQLiteCommand sqlite_cmd = sqlite_conn.CreateCommand();
                sqlite_cmd.CommandText = "SELECT * FROM " + dataBaseName;
                return sqlite_cmd.ExecuteReader();
            }

            ~SQLreader()
            {
                try
                {
                    sqlite_conn.Close();
                }
                catch (Exception)
                {
                }
            }
        }
        /// <summary>
        /// Событие происходит при изменении значения ячейки
        /// нужен для задания значения шага при точении резьбы
        /// </summary>
        private void CellEvent_Changed_rezba(object sender, EventArgs e)
        {
            SourceGrid.CellContext context = (SourceGrid.CellContext)sender;
            try
            {

                ts.inputData.s_rezba = Convert.ToSingle(context.Value);
                context.Value = Convert.ToString(ts.inputData.s_rezba);
                context.Invalidate();
            }
            catch (System.FormatException)
            {
                grid6[14, 2].Value = "s=p";
                grid6[8, 2].Value = "s=p";
                grid6[7, 2].Value = "s=p";
            }

        }

        /// <summary>
        /// Событие происходит при изменении значения ячейки во вкладке "Результат"
        /// </summary>
        private void CellEvent_Changed(object sender, EventArgs e)
        {
            SourceGrid.CellContext context = (SourceGrid.CellContext)sender;

            // Если это вкладка "Результат" для точения
            if (tabControl1.Controls.Find(context.Grid.Name, true).Length != 0)
                turningResultCell_Chenged(context, e);
            // Если это вкладка "Результат" для сверления
            if (tabControl3.Controls.Find(context.Grid.Name, true).Length != 0)
                drillingResultCell_Chenged(context, e);
        }

        /// <summary>
        /// Вызывается когда изменена ячейка на вкладке "Результат" для токарного перехода
        /// </summary>
        private void turningResultCell_Chenged(SourceGrid.CellContext context, EventArgs e)
        {
            switch (context.Position.Row)
            {
                case 1:
                    ts.inputData.s = (float)context.Value;
                    break;
                case 2:
                    ts.inputData.t = (float)context.Value;
                    break;
                case 3:
                    ts.inputData.T = (float)context.Value;
                    break;
                case 4:
                    ts.inputData.D = (float)context.Value;
                    break;
                case 5:
                    ts.inputData.Kiv = (float)context.Value;
                    break;
                case 6:
                    ts.inputData.Kmv = (float)context.Value;
                    break;
                case 7:
                    ts.inputData.Kpv = (float)context.Value;
                    break;
                case 8:
                    ts.inputData.Kmp = (float)context.Value;
                    break;
                case 10:
                    ts.inputData.Cv = (float)context.Value;
                    break;
                case 11:
                    ts.inputData.xv = (float)context.Value;
                    break;
                case 12:
                    ts.inputData.yv = (float)context.Value;
                    break;
                case 13:
                    ts.inputData.mv = (float)context.Value;
                    break;
                case 15:
                    ts.inputData.Cp = (float)context.Value;
                    break;
                case 16:
                    ts.inputData.xp = (float)context.Value;
                    break;
                case 17:
                    ts.inputData.yp = (float)context.Value;
                    break;
                case 18:
                    ts.inputData.np = (float)context.Value;
                    break;
            }
            DoFullGrid19_Turning();
        }

        /// <summary>
        /// Вызывается когда изменена ячейка на вкладке "Результат" для фрезерного перехода
        /// </summary>
        private void millingResultCell_Chenged(SourceGrid.CellContext context, EventArgs e)
        {
            switch (context.Position.Row)
            {
                case 1:
                    ms.inputData.s = (float)context.Value;
                    break;
                case 2:
                    ms.inputData.t = (float)context.Value;
                    break;
                case 3:
                    ms.inputData.T = (float)context.Value;
                    break;
                case 4:
                    ms.inputData.D = (float)context.Value;
                    break;
                case 5:
                    ms.inputData.z = (float)context.Value;
                    break;
                case 6:
                    ms.inputData.B = (float)context.Value;
                    break;
                case 7:
                    ms.inputData.Kv = (float)context.Value;
                    break;
                case 8:
                    ms.inputData.Kp = (float)context.Value;
                    break;
                case 10:
                    ms.inputData.Cv = (float)context.Value;
                    break;
                case 11:
                    ms.inputData.qv = (float)context.Value;
                    break;
                case 12:
                    ms.inputData.xv = (float)context.Value;
                    break;
                case 13:
                    ms.inputData.yv = (float)context.Value;
                    break;
                case 14:
                    ms.inputData.uv = (float)context.Value;
                    break;
                case 15:
                    ms.inputData.pv = (float)context.Value;
                    break;
                case 16:
                    ms.inputData.mv = (float)context.Value;
                    break;

                case 18:
                    ms.inputData.Cp = (float)context.Value;
                    break;
                case 19:
                    ms.inputData.qp = (float)context.Value;
                    break;
                case 20:
                    ms.inputData.xp = (float)context.Value;
                    break;
                case 21:
                    ms.inputData.yp = (float)context.Value;
                    break;
                case 22:
                    ms.inputData.up = (float)context.Value;
                    break;
                case 23:
                    ms.inputData.wp = (float)context.Value;
                    break;
            }
            DoFullGrid19_Turning();
        }

        /// <summary>
        /// Вызывается когда изменена ячейка на вкладке "Результат" для сверлильного перехода
        /// </summary>
        private void drillingResultCell_Chenged(SourceGrid.CellContext context, EventArgs e)
        {
            switch (context.Position.Row)
            {
                case 1:
                    ds.inputData.s = (float)context.Value;
                    break;
                case 2:
                    ds.inputData.t = (float)context.Value;
                    break;
                case 3:
                    ds.inputData.T = (float)context.Value;
                    break;
                case 4:
                    ds.inputData.D = (float)context.Value;
                    break;
                case 5:
                    ds.inputData.d = (float)context.Value;
                    break;
                case 6:
                    ds.inputData.Kmv = (float)context.Value;
                    break;
                case 7:
                    ds.inputData.Kpv = (float)context.Value;
                    break;
                case 8:
                    ds.inputData.Kg = (float)context.Value;
                    break;
                case 10:
                    ds.inputData.Cv = (float)context.Value;
                    break;
                case 11:
                    ds.inputData.qv = (float)context.Value;
                    break;
                case 12:
                    ds.inputData.xv = (float)context.Value;
                    break;
                case 13:
                    ds.inputData.yv = (float)context.Value;
                    break;
                case 14:
                    ds.inputData.mv = (float)context.Value;
                    break;
                case 16:
                    ds.inputData.Cm = (float)context.Value;
                    break;
                case 17:
                    ds.inputData.qm = (float)context.Value;
                    break;
                case 18:
                    ds.inputData.xm = (float)context.Value;
                    break;
                case 19:
                    ds.inputData.ym = (float)context.Value;
                    break;
                case 21:
                    ds.inputData.Cp = (float)context.Value;
                    break;
                case 22:
                    ds.inputData.qp = (float)context.Value;
                    break;
                case 23:
                    ds.inputData.xp = (float)context.Value;
                    break;
                case 24:
                    ds.inputData.yp = (float)context.Value;
                    break;
            }
            DoFullGrid17_Drill();
        }

        /// <summary>
        /// Отслеживание текущей ячейки 
        /// при наведении мыши
        /// небесно-голубым цветом
        /// </summary>
        public class MyCellTracking : SourceGrid.Cells.Controllers.ControllerBase
        {
            private SourceGrid.Cells.Views.Cell cellView;
            public
                override void OnMouseEnter(SourceGrid.CellContext sender, EventArgs e)
            {
                cellView = new SourceGrid.Cells.Views.Cell();
                cellView.Background = new DevAge.Drawing.VisualElements.BackgroundSolid(Color.SkyBlue);
                cellView.TextAlignment = DevAge.Drawing.ContentAlignment.MiddleCenter;
                sender.Cell.View = cellView;
                sender.Grid.InvalidateCell(sender.Position);
            }
            public
                override void OnMouseLeave(SourceGrid.CellContext sender, EventArgs e)
            {
                cellView = new SourceGrid.Cells.Views.Cell();
                cellView.Background = new DevAge.Drawing.VisualElements.BackgroundSolid(Color.White);
                cellView.TextAlignment = DevAge.Drawing.ContentAlignment.MiddleCenter;
                sender.Cell.View = cellView;
                sender.Grid.InvalidateCell(sender.Position);
            }
        }

        /// <summary>
        /// Отслеживание текущей строки
        /// при наведении мыши
        /// небесно-голубым цветом
        /// </summary>
        public class MyRowTrecking : SourceGrid.Cells.Controllers.ControllerBase
        {

            private SourceGrid.Cells.Views.Cell cellView;
            public
                override void OnMouseEnter(SourceGrid.CellContext sender, EventArgs e)
            {
                cellView = new SourceGrid.Cells.Views.Cell();
                cellView.Background = new DevAge.Drawing.VisualElements.BackgroundSolid(Color.SkyBlue);
                cellView.TextAlignment = DevAge.Drawing.ContentAlignment.MiddleCenter;
                for (int c = 0; c < sender.Grid.Columns.Count; c++)
                {
                    if (Convert.ToString(sender.Grid.GetCell(new Position(sender.Position.Row, c)).GetType()) == "SourceGrid.Cells.Cell")
                    {
                        sender.Grid.GetCell(new Position(sender.Position.Row, c)).View = cellView;
                        sender.Grid.InvalidateCell(new Position(sender.Position.Row, c));
                    }
                }

            }
            public
                override void OnMouseLeave(SourceGrid.CellContext sender, EventArgs e)
            {
                cellView = new SourceGrid.Cells.Views.Cell();
                cellView.Background = new DevAge.Drawing.VisualElements.BackgroundSolid(Color.White);
                cellView.TextAlignment = DevAge.Drawing.ContentAlignment.MiddleCenter;
                for (int c = 0; c < sender.Grid.Columns.Count; c++)
                {
                    if (Convert.ToString(sender.Grid.GetCell(new Position(sender.Position.Row, c)).GetType()) == "SourceGrid.Cells.Cell")
                    {
                        sender.Grid.GetCell(new Position(sender.Position.Row, c)).View = cellView;
                        sender.Grid.InvalidateCell(new Position(sender.Position.Row, c));
                    }
                }
            }
        }

        /// <summary>
        /// Отслеживание заголовков
        /// светло-зеленым цветом
        /// </summary>
        public class MyHelpRowTracking : SourceGrid.Cells.Controllers.ControllerBase
        {

            private SourceGrid.Cells.Views.Cell cellView;
            public
                override void OnMouseEnter(SourceGrid.CellContext sender, EventArgs e)
            {
                cellView = new SourceGrid.Cells.Views.Cell();
                cellView.Background = new DevAge.Drawing.VisualElements.BackgroundSolid(Color.LightGreen);
                cellView.TextAlignment = DevAge.Drawing.ContentAlignment.MiddleCenter;
                for (int c = 0; c < sender.Grid.Columns.Count; c++)
                {
                    if (Convert.ToString(sender.Grid.GetCell(new Position(sender.Position.Row, c)).GetType()) != "SourceGrid.Cells.Cell")
                    {
                        sender.Grid.GetCell(new Position(sender.Position.Row, c)).View = cellView;
                        sender.Grid.InvalidateCell(new Position(sender.Position.Row, c));
                    }
                }

            }
            public
                override void OnMouseLeave(SourceGrid.CellContext sender, EventArgs e)
            {
                cellView = new SourceGrid.Cells.Views.Cell();
                cellView.Background = new DevAge.Drawing.VisualElements.BackgroundSolid(Color.White);
                cellView.TextAlignment = DevAge.Drawing.ContentAlignment.MiddleCenter;
                for (int c = 0; c < sender.Grid.Columns.Count; c++)
                {
                    if (Convert.ToString(sender.Grid.GetCell(new Position(sender.Position.Row, c)).GetType()) != "SourceGrid.Cells.Cell")
                    {
                        sender.Grid.GetCell(new Position(sender.Position.Row, c)).View = cellView;
                        sender.Grid.InvalidateCell(new Position(sender.Position.Row, c));
                    }
                }
            }
        }

        /// <summary>
        /// Обработка нажатия Enter в textBox16
        /// </summary>
        //private void textBox16_KeyUp(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.Enter)
        //    {
        //        button1_Click(null, null);
        //    }
        //}

        /// <summary>
        /// Обработчик события клика на ячейку
        /// </summary>
        private void clickEvent_Click(object sender, EventArgs e)
        {
            SourceGrid.CellContext context = (SourceGrid.CellContext)sender;
            if (context.Grid.Parent.Parent == this.tabControl1)
                turningCellClick(context, e);
            if (context.Grid.Parent.Parent == this.tabControl2)
                millingCellClick(context, e);
            if (context.Grid.Parent.Parent == this.tabControl3)
                drillingCellClick(context, e);
        }
        /// <summary>
        /// Нажатие на ячейку для точения
        /// </summary>
        private void turningCellClick(CellContext context, EventArgs e)
        {
            if (context.Grid.Handle == grid1.Handle)
            {
                ts.inputData.t = Convert.ToSingle(context.Value);
                ts.setLCell(1, context);
            }
            if (context.Grid.Handle == grid2.Handle)
            {
                ts.inputData.s = Convert.ToSingle(context.Value);
                ts.setLCell(2, context);
            }
            if (context.Grid.Handle == grid3.Handle)
            {
                ts.inputData.Kmv = Convert.ToSingle(context.Value);
                ts.setLCell(3, context);
            }
            if (context.Grid.Handle == grid4.Handle)
            {
                ts.inputData.Kpv = Convert.ToSingle(context.Value);
                ts.setLCell(4, context);
            }
            if (context.Grid.Handle == grid5.Handle)
            {
                ts.inputData.Kiv = Convert.ToSingle(context.Value);
                ts.setLCell(5, context);
            }
            if (context.Grid.Handle == grid6.Handle)
            {
                ts.inputData.Cv = Convert.ToSingle(grid6[context.Position.Row, 3].Value);
                ts.inputData.xv = Convert.ToSingle(grid6[context.Position.Row, 4].Value);
                ts.inputData.yv = Convert.ToSingle(grid6[context.Position.Row, 5].Value);
                ts.inputData.mv = Convert.ToSingle(grid6[context.Position.Row, 6].Value);
                ts.setLCell(6, context);
                if (context.Position.Row == 7 || context.Position.Row == 8 || context.Position.Row == 14)
                {
                    //Редактирование s сразу после нажатия на строку.
                    context = new CellContext(grid6, new Position(context.Position.Row, 2));
                    context.StartEdit();
                }
                else
                {
                    try
                    {
                        ts.inputData.s = Convert.ToSingle(ts.getLCell(2).Value);
                        ts.inputData.s_rezba = 0;
                    }
                    catch
                    {
                        ts.inputData.s_rezba = 0;
                    }
                }
            }
            if (context.Grid.Handle == grid7.Handle)
            {
                ts.inputData.Cp = Convert.ToSingle(grid7[context.Position.Row, 2].Value);
                ts.inputData.xp = Convert.ToSingle(grid7[context.Position.Row, 3].Value);
                ts.inputData.yp = Convert.ToSingle(grid7[context.Position.Row, 4].Value);
                ts.inputData.np = Convert.ToSingle(grid7[context.Position.Row, 5].Value);
                ts.setLCell(7, context);
            }
            if (context.Grid.Handle == grid8.Handle)
            {
                ts.inputData.Kmp = Convert.ToSingle(context.Value);
                ts.setLCell(8, context);
            }

            //Выделение ячеек (они unselectable)

            if ((context.Grid.Handle == grid6.Handle) | (context.Grid.Handle == grid7.Handle) | (context.Grid.Handle == grid14.Handle) | (context.Grid.Handle == grid15.Handle))
            {
                Utils.RowSelector(context);
            }
            else
            {
                Utils.CellSelector(context);
            }
        }
        /// <summary>
        /// Нажатие на ячейку для фрезерования
        /// </summary>
        private void millingCellClick(CellContext context, EventArgs e)
        {

            if (context.Grid.Handle == grid1Mill.Handle)
            {
                ms.inputData.Cv = Convert.ToSingle(grid1Mill[context.Position.Row, 4].Value);
                ms.inputData.qv = Convert.ToSingle(grid1Mill[context.Position.Row, 5].Value);
                ms.inputData.xv = Convert.ToSingle(grid1Mill[context.Position.Row, 6].Value);
                ms.inputData.yv = Convert.ToSingle(grid1Mill[context.Position.Row, 7].Value);
                ms.inputData.uv = Convert.ToSingle(grid1Mill[context.Position.Row, 8].Value);
                ms.inputData.pv = Convert.ToSingle(grid1Mill[context.Position.Row, 9].Value);
                ms.inputData.mv = Convert.ToSingle(grid1Mill[context.Position.Row, 10].Value);
                ms.setLCell(1, context);
            }
            if (context.Grid.Handle == grid2Mill.Handle)
            {
                ms.inputData.z = Convert.ToSingle(context.Value);
                ms.setLCell(2, context);
            }
            if (context.Grid.Handle == grid3Mill.Handle)
            {
                ms.inputData.Kv = Convert.ToSingle(context.Value);
                ms.setLCell(3, context);
            }
            if (context.Grid.Handle == grid4Mill.Handle)
            {
                ms.inputData.Kp = Convert.ToSingle(context.Value);
                ms.setLCell(4, context);
            }
            if (context.Grid.Handle == grid5Mill.Handle)
            {
                ms.inputData.Cp = Convert.ToSingle(grid5Mill[context.Position.Row, 2].Value);
                ms.inputData.xp = Convert.ToSingle(grid5Mill[context.Position.Row, 3].Value);
                ms.inputData.yp = Convert.ToSingle(grid5Mill[context.Position.Row, 4].Value);
                ms.inputData.up = Convert.ToSingle(grid5Mill[context.Position.Row, 5].Value);
                ms.inputData.qp = Convert.ToSingle(grid5Mill[context.Position.Row, 6].Value);
                ms.inputData.wp = Convert.ToSingle(grid5Mill[context.Position.Row, 7].Value);
                ms.setLCell(5, context);
                Utils.RowSelector(context);
            }
            //Выделение ячеек (они unselectable)

            if (context.Grid.Handle == grid5Mill.Handle)
            {
                Utils.RowSelector(context);
            }
            if (context.Grid.Handle == grid1Mill.Handle)
            {
                Utils.RowSelector(context);
            }
            if ((context.Grid.Handle != grid1Mill.Handle) && (context.Grid.Handle != grid5Mill.Handle) && (context.Grid.Handle != grid6.Handle) && (context.Grid.Handle != grid7.Handle) && (context.Grid.Handle != grid14.Handle) && (context.Grid.Handle != grid15.Handle))
            {
                //следующий код необходим для верного выделения (click-drop) иначе 
                //click на одной ячейке, select на другой.(+unselectable)
                //+решения проблеммы shift+arrow т.е. выделение только при событии click 
                if (!((context.Position.Column == 1) && (context.Position.Row > 10) && (context.Grid.Handle == grid1.Handle)))
                {
                    Utils.CellSelector(context);
                }
            }
        }
        /// <summary>
        /// Нажатие на ячейку для сверления
        /// </summary>
        private void drillingCellClick(CellContext context, EventArgs e)
        {
            if (context.Grid.Handle == grid9.Handle)
            {
                if (context.Position.Row == 3 || context.Position.Row == 4)
                {
                    if (context.Position.Row == 3)
                    {
                        ds.inputData.dk = My_Cal.DrillingStep.drillingKind.PRELIMINARY;
                        ds.setLCell(1, context);
                    }
                    if (context.Position.Row == 4)
                    {
                        ds.inputData.dk = My_Cal.DrillingStep.drillingKind.FINAL;
                        ds.setLCell(1, context);
                    }
                }
                else
                {
                    //ds.inputData.dk = DrillingStep.drillingKind.NONE;
                    ds.inputData.dk = DrillingStep.drillingKind.DRILLING;
                    //ds.inputData.t = Convert.ToSingle(context.Value);
                    ds.setLCell(1, context);
                }
                Utils.CellSelector(context);
            }
            if (context.Grid.Handle == grid10.Handle)
            {
                ds.inputData.s = Convert.ToSingle(context.Value);
                ds.setLCell(2, context);
                Utils.CellSelector(context);
            }
            if (context.Grid.Handle == grid11.Handle)
            {
                ds.inputData.Kmv = Convert.ToSingle(context.Value);
                ds.setLCell(3, context);
                Utils.CellSelector(context);
            }
            if (context.Grid.Handle == grid12.Handle)
            {
                ds.inputData.Kpv = Convert.ToSingle(context.Value);
                ds.setLCell(4, context);
                Utils.CellSelector(context);
            }
            if (context.Grid.Handle == grid13.Handle)
            {
                ds.inputData.Kg = Convert.ToSingle(context.Value);
                ds.setLCell(5, context);
                Utils.CellSelector(context);
            }
            if (context.Grid.Handle == grid14.Handle)
            {
                ds.inputData.Cv = Convert.ToSingle(grid14[context.Position.Row, 3].Value);
                ds.inputData.qv = Convert.ToSingle(grid14[context.Position.Row, 4].Value);
                ds.inputData.xv = Convert.ToSingle(grid14[context.Position.Row, 5].Value);
                ds.inputData.yv = Convert.ToSingle(grid14[context.Position.Row, 6].Value);
                ds.inputData.mv = Convert.ToSingle(grid14[context.Position.Row, 7].Value);
                ds.setLCell(6, context);
                Utils.RowSelector(context);
            }
            if (context.Grid.Handle == grid15.Handle)
            {
                ds.inputData.Cm = Convert.ToSingle(grid15[context.Position.Row, 3].Value);
                ds.inputData.qm = Convert.ToSingle(grid15[context.Position.Row, 4].Value);
                try
                {
                    ds.inputData.xm = Convert.ToSingle(grid15[context.Position.Row, 5].Value);
                    ds.inputData.xp = Convert.ToSingle(grid15[context.Position.Row, 9].Value);
                }
                catch (Exception)
                {
                }
                ds.inputData.ym = Convert.ToSingle(grid15[context.Position.Row, 6].Value);
                ds.inputData.Cp = Convert.ToSingle(grid15[context.Position.Row, 7].Value);
                ds.inputData.qp = Convert.ToSingle(grid15[context.Position.Row, 8].Value);
                ds.inputData.yp = Convert.ToSingle(grid15[context.Position.Row, 10].Value);
                ds.setLCell(7, context);
                Utils.RowSelector(context);
            }
        }

        /// <summary>
        /// Вход на вкладку "Результат" для токарного перехода
        /// </summary>
        private void tabPage9_Enter(object sender, EventArgs e)
        {
            DoFullGrid18_Turning();
            DoFullGrid19_Turning();
            //ClearTab9();
            //if (ts.inputData.s_rezba != 0)
            //{
            //    ts.inputData.s = ts.inputData.s_rezba;
            //}
            //textBox1.Text = Convert.ToString(ts.inputData.t);
            //textBox2.Text = Convert.ToString(ts.inputData.s);
            //textBox3.Text = Convert.ToString(ts.inputData.Kmv);
            //textBox4.Text = Convert.ToString(ts.inputData.Kpv);
            //textBox5.Text = Convert.ToString(ts.inputData.Kiv);
            //textBox6.Text = Convert.ToString(ts.inputData.Cv);
            //textBox7.Text = Convert.ToString(ts.inputData.xv);
            //textBox8.Text = Convert.ToString(ts.inputData.yv);
            //textBox9.Text = Convert.ToString(ts.inputData.mv);
            //textBox10.Text = Convert.ToString(ts.inputData.Cp);
            //textBox11.Text = Convert.ToString(ts.inputData.xp);
            //textBox12.Text = Convert.ToString(ts.inputData.yp);
            //textBox13.Text = Convert.ToString(ts.inputData.np);
            //textBox15.Text = Convert.ToString(ts.inputData.Kmp);
            //textBox16.Text = Convert.ToString(ts.inputData.D);
            //comboBox1.SelectedIndex = ts.cBoxIndex;
            //if (ts)
            //{
            //    textBox17.Text = Convert.ToString(ts.getV());
            //    textBox18.Text = Convert.ToString(ts.getn());
            //    textBox19.Text = Convert.ToString(ts.getP());
            //    textBox20.Text = Convert.ToString(ts.getM());
            //    textBox21.Text = Convert.ToString(ts.getN());
            //}
        }

        /// <summary>
        /// Сбрасывает все значения textBox на 9 вкладке для токарного перехода
        /// </summary>
        //private void ClearTab9()
        //{
        //    comboBox1.SelectedIndex = -1;
        //    for (int i = 0; i < tabPage9.Controls.Count; i++)
        //    {
        //        foreach (TextBox TBox in tabPage9.Controls.Find("textBox" + i, false))
        //        {
        //            TBox.Text = "";
        //        }
        //    }
        //}

        /// <summary>
        /// Событие выбора периода стойкости резца для токарного перехода
        /// </summary>
        //private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (comboBox1.Text != "")
        //    {
        //        ts.cBoxIndex = comboBox1.SelectedIndex;
        //        textBox14.Text = comboBox1.Text;
        //        ts.inputData.T = Convert.ToSingle(comboBox1.Text);
        //    }
        //}
        /// <summary>
        /// Событие для нажатия на кнопку вычисления для токарного перехода
        /// </summary>
        //private void button1_Click(object sender, EventArgs e)
        //{
        //    textBox16.Text = textBox16.Text.Replace(".", ",");

        //    try
        //    {
        //        ts.inputData.D = Convert.ToSingle(textBox16.Text);
        //        if (ts)
        //        {
        //            textBox17.Text = Convert.ToString(ts.getV());
        //            textBox18.Text = Convert.ToString(ts.getn());
        //            textBox19.Text = Convert.ToString(ts.getP());
        //            textBox20.Text = Convert.ToString(ts.getM());
        //            textBox21.Text = Convert.ToString(ts.getN());
        //        }
        //        else
        //        {
        //            string str = "\n";
        //            for (int i = 1; i < 9; i++)
        //            {
        //                if (ts.getLCell(i) == null)
        //                {
        //                    str = str + ((TabPage)tabControl1.Controls.Find("tabPage" + i, false)[0]).Text;// 
        //                }
        //            }

        //            if ((ts.inputData.D == 0) || (ts.cBoxIndex == -1))
        //            {
        //                str = str + tabPage9.Text + "\n";
        //            }
        //            MessageBox.Show("Не все данные выбраны!\nПроверьте вкладки:" + str);
        //        }
        //    }
        //    catch (System.FormatException)
        //    {
        //        textBox16.Text = "";
        //        MessageBox.Show("Ошибка ввода!\n");
        //    }
        //}

        /// <summary>
        /// Событие изменения пункта меню для выбора периода стойкости резца для фрезерного перехода
        /// </summary>
        private void comboBox1Mill_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1Mill.Text != "")
            {
                ms.cBoxIndex = comboBox1Mill.SelectedIndex;
                ms.inputData.T = Convert.ToSingle(comboBox1Mill.Text);
                comboBox1Mill.SelectedIndex = ms.cBoxIndex;
            }
        }

        /// <summary>
        /// Событие нажатия на кнопку "Ввод данных" для фрезерного перехода
        /// </summary>
        private void button2Mill_Click(object sender, EventArgs e)
        {
            textBox1Mill.Text = textBox1Mill.Text.Replace(".", ",");
            textBox2Mill.Text = textBox2Mill.Text.Replace(".", ",");
            textBox3Mill.Text = textBox3Mill.Text.Replace(".", ",");
            textBox10Mill.Text = textBox10Mill.Text.Replace(".", ",");
            try
            {
                ms.inputData.t = Convert.ToSingle(textBox1Mill.Text);
                ms.inputData.B = Convert.ToSingle(textBox2Mill.Text);
                ms.inputData.s = Convert.ToSingle(textBox3Mill.Text);
                ms.inputData.D = Convert.ToSingle(textBox10Mill.Text);
            }
            catch (System.FormatException)
            {
                textBox1Mill.Text = "";
                textBox2Mill.Text = "";
                textBox3Mill.Text = "";
                textBox10Mill.Text = "";
                MessageBox.Show("Ошибка ввода!\n");
            }

        }

        // TODO Выяснить что это и зачем нужно. Похпже на нажатие Enter в каком-то TextBox
        // Так.. это старое наверное уже. Удалил я почти все текстбоксы
        private void textBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button2_Click(null, null);
            }
        }

        /// <summary>
        /// Событие при входе на вкладку "Результат для фрезерного перехода"
        /// </summary>
        private void tabPage7Mill_Enter(object sender, EventArgs e)
        {
            DoFullGrid20_Milling();
            DoFullGrid21_Milling();
        }

        // удалить
        private void button2_Click(object sender, EventArgs e)
        {
        }
        // удалить
        private void button3_Click(object sender, EventArgs e)
        {

        }
        // удалить
        private void button4_Click(object sender, EventArgs e)
        {

        }
        // удалить
        private void menu1ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Событие нажатия на пункт меню "Создать токарный переход."
        /// </summary>
        private void makeTurningStepToolStripMenuItem_Click(object sender, EventArgs e)
        {
            i++;
            treeView1.BeginUpdate();
            treeView1.Nodes.Add("Переход" + i + " (токарный)");
            treeView1.Nodes[0].Expand();
            treeView1.EndUpdate();
            TurningStep s = new TurningStep();
            //Step_turning s2 = new Step_turning();//Создаем ЕЩЁ(!) один объект и помещаем его в коллекцию
            //текущий не трогаем(!) а подменяем его только при выборе!!
            stepList.Add(s);
        }

        /// <summary>
        /// Событие нажатия на пункт меню "Создать фрезерный переход."
        /// </summary>
        private void makeMillStepToolStripMenuItem_Click(object sender, EventArgs e)
        {
            i++;
            treeView1.BeginUpdate();
            treeView1.Nodes.Add("Переход" + i + " (фрезерный)");
            treeView1.Nodes[0].Expand();
            treeView1.EndUpdate();
            MillingStep s = new MillingStep();
            //Step_Mill s2 = new Step_Mill();//Создаем ЕЩЁ(!) один объект и помещаем его в коллекцию
            //текущий не трогаем(!) а подменяем его только при выборе!!
            stepList.Add(s);
        }

        /// <summary>
        /// Событие при нажатии на пункт меню "Создать сверлильный переход"
        /// </summary>
        private void makeDrillStepToolStripMenuItem_Click(object sender, EventArgs e)
        {
            i++;
            treeView1.BeginUpdate();
            treeView1.Nodes.Add("Переход" + i + " (сверлильный)");
            treeView1.Nodes[0].Expand();
            treeView1.EndUpdate();
            DrillingStep s = new DrillingStep();
            stepList.Add(s);
        }

        /// <summary>
        /// Событие при нажатии на пункт меню "Создать отчет"
        /// </summary>
        private void makeReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {

                saveFileDialog1.AddExtension = true;
                saveFileDialog1.ShowDialog();
                StreamWriter fstr_out;
                // Открываем выходной файл.
                try
                {
                    fstr_out = new StreamWriter(saveFileDialog1.FileName);
                    //fstr_out = new StreamWriter(
                }
                catch (IOException exc)
                {
                    Console.WriteLine(
                    exc.Message +
                    "\nОшибка при открытии выходного файла.");
                    return;
                }
                catch (ArgumentException)
                {
                    return;
                }

                // Записываем в файл.
                for (int i = 0; i < stepList.Count; i++)
                {
                    try
                    {
                        try
                        {
                            Convert.ToString(((TurningStep)stepList[i]).getV());
                            fstr_out.Write("\r\n           Переход №" + (i + 1) + " (токарный)\r\n");
                            fstr_out.Write("Скорость резания:   ");
                            fstr_out.Write(Convert.ToString(((TurningStep)stepList[i]).getV()) + " м/с\r\n");
                            fstr_out.Write("Частота вращения:   ");
                            fstr_out.Write(Convert.ToString(((TurningStep)stepList[i]).getn()) + " об/мин\r\n");
                            fstr_out.Write("Мощность:           ");
                            fstr_out.Write(Convert.ToString(((TurningStep)stepList[i]).getN()) + " кВт\r\n");
                            fstr_out.Write("Сила резания:       ");
                            fstr_out.Write(Convert.ToString(((TurningStep)stepList[i]).getP()) + " Н\r\n");
                            fstr_out.Write("Момент:             ");
                            fstr_out.Write(Convert.ToString(((TurningStep)stepList[i]).getM()) + " Нм\r\n");
                        }
                        catch (InvalidCastException)
                        {
                            try
                            {
                                Convert.ToString(((TurningStep)stepList[i]).getV());
                                fstr_out.Write("\r\n           Переход №" + (i + 1) + "(фрезерный)\r\n");
                                fstr_out.Write("Скорость резания:   ");
                                fstr_out.Write(Convert.ToString(((MillingStep)stepList[i]).getV()) + " м/с\r\n");
                                fstr_out.Write("Частота вращения:   ");
                                fstr_out.Write(Convert.ToString(((MillingStep)stepList[i]).getn()) + " об/мин\r\n");
                                fstr_out.Write("Мощность:           ");
                                fstr_out.Write(Convert.ToString(((MillingStep)stepList[i]).getN()) + " кВт\r\n");
                                fstr_out.Write("Сила резания:       ");
                                fstr_out.Write(Convert.ToString(((MillingStep)stepList[i]).getP()) + " Н\r\n");
                                fstr_out.Write("Момент:             ");
                                fstr_out.Write(Convert.ToString(((MillingStep)stepList[i]).getM()) + " Нм\r\n");
                            }
                            catch (InvalidCastException)
                            {
                                fstr_out.Write("\r\n           Переход №" + (i + 1) + "(сверлильный)\r\n");
                                fstr_out.Write("Скорость резания:   ");
                                fstr_out.Write(Convert.ToString(((DrillingStep)stepList[i]).getV()) + " м/с\r\n");
                                fstr_out.Write("Частота вращения:   ");
                                fstr_out.Write(Convert.ToString(((DrillingStep)stepList[i]).getn()) + " об/мин\r\n");
                                fstr_out.Write("Мощность:           ");
                                fstr_out.Write(Convert.ToString(((DrillingStep)stepList[i]).getN()) + " кВт\r\n");
                                fstr_out.Write("Сила резания:       ");
                                fstr_out.Write(Convert.ToString(((DrillingStep)stepList[i]).getP()) + " Н\r\n");
                                fstr_out.Write("Момент:             ");
                                fstr_out.Write(Convert.ToString(((DrillingStep)stepList[i]).getM()) + " Нм\r\n");
                            }
                        }
                    }
                    catch (IOException exc)
                    {
                        MessageBox.Show(exc.Message + " Ошибка при работе с файлом. ");
                        return;
                    }
                }
                fstr_out.Close();
                Process.Start(saveFileDialog1.FileName);
            }
        }

        /// <summary>
        /// Событие при нажатии на пункт меню "Выход" 
        /// </summary>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Событие при нажатии на пункт меню "Удалить переход"
        /// </summary>
        /// TODO Проработать событие (временный код)
        private void deleteStepToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (TreeNode n in treeView1.Nodes)
            {
                if (n.IsSelected)
                {
                    n.Remove();
                    //TODO Важно! Написать удаление из ArrayList
                    if (treeView1.GetNodeCount(true) == 0)
                    {
                        tabControl1.Visible = false;
                        tabControl2.Visible = false;
                    }
                    else
                    {
                        treeView1.SelectedNode = treeView1.GetNodeAt(treeView1.GetNodeCount(true), 0);

                    }
                    break;
                }
            }

        }

        /// <summary>
        /// Событие после выбора пункта в treeView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //e = (TreeNodeMouseClickEventArgs)e;
            object s = stepList[e.Node.Index];
            if (s is TurningStep)
            {
                DoFullTab6();
                ts = (TurningStep)stepList[e.Node.Index];// stepList[e.Node.Index];//подмена s1 тем значением который записан в Alist на индексе соответствующем, индексу NODE 

                DoFullGrid18_Turning();
                DoFullGrid19_Turning();

                tabControl2.Visible = false;
                tabControl1.Visible = true;
                tabControl3.Visible = false;
                this.Text = "Калькулятор режимов резания: " + e.Node.Text;
                //comboBox1.SelectedIndex = -1;
                if (tabControl1.SelectedIndex == 8)
                {
                    tabPage9_Enter(null, null);
                }
                Utils.ClearAllSelection(this);//почистить выделение всех ячеек всех гридов
                tabControl1.Visible = true;
                ts.ReturnSelect();
            }
            if (s is MillingStep)
            {
                ms = (MillingStep)s;
                //s2 = (Step_Mill)stepList[e.Node.Index];//подмена s1 тем значением который записан в Alist на индексе соответствующем, индексу NODE

                DoFullGrid20_Milling();
                DoFullGrid21_Milling();

                tabControl2.Visible = true;
                tabControl1.Visible = false;
                tabControl3.Visible = false;
                this.Text = "Калькулятор режимов резания: " + e.Node.Text;
                //comboBox1.SelectedIndex = -1;
                if (tabControl1.SelectedIndex == 8)
                {
                    tabPage7Mill_Enter(null, null);
                }
                Utils.ClearAllSelection(this);//почистить выделение всех ячеек всех гридов
                ms.ReturnSelect();
            }
            if (s is DrillingStep)
            {
                ds = (DrillingStep)s;
                DoFullGrid16_Drill();
                DoFullGrid17_Drill();
                tabControl2.Visible = false;
                tabControl1.Visible = false;
                tabControl3.Visible = true;
                Utils.ClearAllSelection(this);//почистить выделение всех ячеек всех гридов
                ds.ReturnSelect();
            }
        }

        private void tabPage20_Enter(object sender, EventArgs e)
        {

            DoFullGrid16_Drill();
            DoFullGrid17_Drill();
        }

    }

}
=======
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SourceGrid;
using System.Data.SQLite;
using SourceGrid.Selection;
using System.Collections;
using System.IO;
using System.Diagnostics;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;



namespace My_Cal
{
    public partial class Form1 : Form
    {

        static TurningStep ts;
        static MillingStep ms;
        static DrillingStep ds;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CustomInitialization();
            DoFullTab1();
            DoFullTab2();
            DoFullTab3();
            DoFullTab4();
            DoFullTab5();
            DoFullTab6();
            DoFullTab7();
            DoFullTab8();
            DoFullRusultTab1_Turning();
            DoFullResultTab2_Turning();
            tabControl1.Visible = false;
            DoFullTab1_Mill();
            DoFullTab2_Mill();
            DoFullTab3_Mill();
            DoFullTab4_Mill();
            DoFullTab5_Mill();
            DoFullRusultTab1_Milling();
            DoFullResultTab2_Milling();
            tabControl2.Visible = false;
            DoFullTab1_Drill();
            DoFullTab2_Drill();
            DoFullTab3_Drill();
            DoFullTab4_Drill();
            DoFullTab5_Drill();
            DoFullTab6_Drill();
            DoFullTab7_Drill();
            DoFullRusultTab1_Drill();
            DoFullResultTab2_Drill();
            tabControl3.Visible = false;
            #region Изменение шрифта
            foreach (Control contr in this.Controls)
            {
                contr.Font = new Font("Microsoft Sans Serif", 10);
            }
            foreach (TabPage page in tabControl1.Controls)
            {
                foreach (Control grid in page.Controls)
                    grid.Font = new Font("Microsoft Sans Serif", 12);
            }
            foreach (TabPage page in tabControl2.Controls)
            {
                foreach (Control grid in page.Controls)
                    grid.Font = new Font("Microsoft Sans Serif", 12);
            }
            foreach (TabPage page in tabControl3.Controls)
            {
                foreach (Control grid in page.Controls)
                    grid.Font = new Font("Microsoft Sans Serif", 12);
            }
            this.tabControl2.Font = new Font("Microsoft Sans Serif", 8);
            #endregion
        }
        private void CustomInitialization()
        {
            i = 0;
            stepList = new ArrayList();//список переходов
            cellpointer = new MyCellTracking();
            rowpointer = new MyRowTrecking();
            clickEvent = new SourceGrid.Cells.Controllers.CustomEvents();
            clickEvent.Click += new EventHandler(clickEvent_Click);
            // Для резьбы
            CellChangedEvent_rezba = new SourceGrid.Cells.Controllers.CustomEvents();
            CellChangedEvent_rezba.EditEnded += new EventHandler(CellEvent_Changed_rezba);
            // Для вкладки результат 
            CellChangedEvent = new SourceGrid.Cells.Controllers.CustomEvents();
            CellChangedEvent.EditEnded += new EventHandler(CellEvent_Changed);

            foreach (SourceGrid.Grid GRID in tabControl1.Controls.Find("grid", true))//выставить выравнивание по центру для всех ячеек
            {
                for (int r = 0; r < GRID.Rows.Count; r++)
                {
                    for (int c = 0; c < GRID.Columns.Count; c++)
                    {
                        GRID.GetCell(new Position(r, c)).View.TextAlignment = DevAge.Drawing.ContentAlignment.MiddleCenter;
                    }
                }
            }
        }
        // TODO написать отдельный метод соединения с БД
        #region DuFullTab
        private void DoFullTab1()
        {
            SQLreader sqlReader = new SQLreader("database.sqlite");
            SQLiteDataReader sqlite_datareader = sqlReader.getReader("external_turning");
            #region Код таблицы 1 (Наружнее точение)
            grid1.BorderStyle = BorderStyle.FixedSingle;
            grid1.Redim(14, 4);
            grid1.Rows.Insert(0);
            SourceGrid.Cells.Views.Cell viewImage = new SourceGrid.Cells.Views.Cell();
            grid1[0, 0] = new SourceGrid.Cells.ColumnHeader("Наружнее точение");
            grid1[0, 0].ColumnSpan = 4;
            grid1[0, 0].View.TextAlignment = DevAge.Drawing.ContentAlignment.MiddleCenter;
            grid1[1, 0] = new SourceGrid.Cells.ColumnHeader("D, мм");
            grid1[1, 0].RowSpan = 2;
            grid1[1, 1] = new SourceGrid.Cells.ColumnHeader("Черновое");
            grid1[1, 2] = new SourceGrid.Cells.ColumnHeader("Получистовое");
            grid1[1, 3] = new SourceGrid.Cells.ColumnHeader("Чистовое");
            grid1[2, 1] = new SourceGrid.Cells.ColumnHeader("t, мм");
            grid1[2, 1].ColumnSpan = 3;
            for (int r = 3; r < 9; r++)
            {
                grid1.Rows.Insert(r);
                if (sqlite_datareader.Read())
                {
                    grid1[r, 0] = new SourceGrid.Cells.RowHeader(Convert.ToString(sqlite_datareader.GetString(0)));
                    grid1[r, 1] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(1)), typeof(float));
                    grid1[r, 2] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(2)), typeof(float));
                    grid1[r, 3] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(3)), typeof(float));
                }
                SourceGrid.Range R1 = new SourceGrid.Range(new Position(1, 3), new Position(8, 3));
                SourceGrid.RangeRegion rr = new RangeRegion(R1);
                for (int c = 0; c < 4; c++) //задание свойств ячеек
                {
                    if (c != 0)
                    {
                        grid1[r, c].AddController(cellpointer);//наведение
                        grid1[r, c].AddController(clickEvent);//клик мыши
                        grid1[r, c].Editor.EnableEdit = false;
                        grid1[r, c].AddController(new SourceGrid.Cells.Controllers.Unselectable());
                        grid1[r, c].AddController(new MyHelpRowTracking());//help row pointer
                    }
                }
            }
            #endregion
            sqlite_datareader = sqlReader.getReader("boring");
            #region Код таблицы 1 (растачивание)
            grid1[9, 0] = new SourceGrid.Cells.ColumnHeader("Растачивание");
            for (int r = 11; r < 15; r++)
            {
                grid1.Rows.Insert(r);
                if (sqlite_datareader.Read())
                {
                    grid1[r, 0] = new SourceGrid.Cells.RowHeader(Convert.ToString(sqlite_datareader.GetString(0)));
                    grid1[r, 1] = new SourceGrid.Cells.Cell(" ", typeof(string));
                    grid1[r, 2] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(2)), typeof(float));
                    grid1[r, 3] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(3)), typeof(float));
                }
                for (int c = 0; c < 4; c++) //задание свойств ячеек
                {
                    if ((c != 0) & (c != 1))
                    {
                        grid1[r, c].AddController(cellpointer);//наведение
                        grid1[r, c].AddController(clickEvent);//клик мыши
                        grid1[r, c].Editor.EnableEdit = false;
                        grid1[r, c].AddController(new SourceGrid.Cells.Controllers.Unselectable());
                        grid1[r, c].AddController(new MyHelpRowTracking());//help row pointer
                    }
                }
            }
            grid1[11, 1].AddController(new SourceGrid.Cells.Controllers.Unselectable());
            grid1[12, 1].AddController(new SourceGrid.Cells.Controllers.Unselectable());
            grid1[13, 1].AddController(new SourceGrid.Cells.Controllers.Unselectable());
            grid1[14, 1].AddController(new SourceGrid.Cells.Controllers.Unselectable());
            grid1[9, 0].ColumnSpan = 4;
            grid1.AutoSizeCells();
            grid1.EnableSort = false;
            grid1.Selection.EnableMultiSelection = false;
            #endregion

            foreach (SourceGrid.GridColumn col in grid1.Columns)
                col.Width=100;
            grid1.Columns[2].Width = 150;

            foreach (SourceGrid.GridRow row in grid1.Rows)
                row.Height = 25;
        }
        private void DoFullTab2()
        {

            SQLreader sqlReader = new SQLreader("database.sqlite");
            SQLiteDataReader sqlite_datareader = sqlReader.getReader("roughing");
            #region Код таблицы 2(черновое точение)
            grid2.BorderStyle = BorderStyle.FixedSingle;
            grid2.Redim(19, 4);
            grid2[0, 0] = new SourceGrid.Cells.ColumnHeader("Черновое точение");
            grid2[0, 0].ColumnSpan = 4;
            grid2[1, 0] = new SourceGrid.Cells.ColumnHeader("D, мм");
            grid2[1, 0].ColumnSpan = 2;
            grid2[1, 0].RowSpan = 3;
            grid2[1, 2] = new SourceGrid.Cells.ColumnHeader("Материал детали");
            grid2[1, 2].ColumnSpan = 2;
            grid2[2, 2] = new SourceGrid.Cells.ColumnHeader("Сталь углеродистая");
            grid2[2, 2].Column.Width = 40;
            grid2[2, 3] = new SourceGrid.Cells.ColumnHeader("Чугун серый");
            grid2[3, 2] = new SourceGrid.Cells.ColumnHeader("s, мм/об");
            grid2[3, 2].ColumnSpan = 2;
            for (int r = 4; r < 9; r++)
            {
                grid2.Rows.Insert(r);
                if (sqlite_datareader.Read())
                {
                    grid2[r, 0] = new SourceGrid.Cells.RowHeader(Convert.ToString(sqlite_datareader.GetString(0)));
                    grid2[r, 0].ColumnSpan = 2;
                    grid2[r, 2] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(1)), typeof(float));
                    grid2[r, 3] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(2)), typeof(float));
                }
                for (int c = 0; c < 4; c++) //задание свойств ячеек
                {
                    if ((c != 0) & (c != 1)) //для заголовков свойства не задаются
                    {
                        grid2[r, c].AddController(clickEvent);//клик мыши
                        grid2[r, c].AddController(cellpointer);//наведение
                        grid2[r, c].Editor.EnableEdit = false;//нередактируемые ячейки
                        grid2[r, c].AddController(new SourceGrid.Cells.Controllers.Unselectable());
                        grid2[r, c].AddController(new MyHelpRowTracking());//help row pointer
                    }
                }
            }
            #endregion
            sqlite_datareader = sqlReader.getReader("finish_turning");
            #region Код таблицы 3(получистовое и чистовое точение)
            grid2[9, 0] = new SourceGrid.Cells.ColumnHeader("Получистовое и чистовое точение");
            grid2[9, 0].ColumnSpan = 4;
            grid2[10, 0] = new SourceGrid.Cells.ColumnHeader("Шероховатость");
            grid2[10, 0].ColumnSpan = 2;
            grid2[10, 2] = new SourceGrid.Cells.ColumnHeader("Радиус при вершине, R, мм");
            grid2[10, 2].ColumnSpan = 2;
            grid2[11, 0] = new SourceGrid.Cells.ColumnHeader("Ra, мкм");
            grid2[11, 0].RowSpan = 2;
            grid2[11, 1] = new SourceGrid.Cells.ColumnHeader("Rz, мкм");
            grid2[11, 1].RowSpan = 2;
            grid2[11, 2] = new SourceGrid.Cells.ColumnHeader("<0,5");
            grid2[11, 3] = new SourceGrid.Cells.ColumnHeader(">0,5-1,0");
            grid2[12, 2] = new SourceGrid.Cells.ColumnHeader("s, мм/об");
            grid2[12, 2].ColumnSpan = 2;
            for (int r = 13; r < 19; r++)
            {
                grid2.Rows.Insert(r);
                if (sqlite_datareader.Read())
                {
                    grid2[r, 0] = new SourceGrid.Cells.RowHeader(Convert.ToString(sqlite_datareader.GetString(0)));
                    grid2[r, 1] = new SourceGrid.Cells.RowHeader(Convert.ToString(sqlite_datareader.GetString(1)));
                    grid2[r, 2] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(2)), typeof(float));
                    grid2[r, 3] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(3)), typeof(float));
                }
                for (int c = 0; c < 4; c++) //задание свойств ячеек
                {
                    if ((c != 0) & (c != 1)) //для заголовков свойства не задаются
                    {
                        grid2[r, c].AddController(clickEvent);//клик мыши
                        grid2[r, c].AddController(cellpointer);//наведение
                        grid2[r, c].Editor.EnableEdit = false;//нередактируемые ячейки
                        grid2[r, c].AddController(new SourceGrid.Cells.Controllers.Unselectable());
                        grid2[r, c].AddController(new MyHelpRowTracking());//help row pointer
                    }
                }
            }

            grid2.AutoSizeCells();
            grid2.EnableSort = false;
            grid2.Selection.EnableMultiSelection = false;
            #endregion

            foreach (SourceGrid.GridColumn col in grid2.Columns)
                col.Width = 100;
            grid2.Columns[2].Width = 150;

            foreach (SourceGrid.GridRow row in grid2.Rows)
                row.Height = 25;
        }
        private void DoFullTab3()
        {
            SQLreader sqlReader = new SQLreader("database.sqlite");
            SQLiteDataReader sqlite_datareader = sqlReader.getReader(" KMV");
            #region Код таблицы 4
            grid3.BorderStyle = BorderStyle.FixedSingle;
            grid3.Redim(3, 2);
            grid3.Rows.Insert(0);
            grid3[0, 0] = new SourceGrid.Cells.ColumnHeader("Обрабатываемый материал");
            grid3[0, 0].Column.Width = 200;
            grid3[0, 1] = new SourceGrid.Cells.ColumnHeader("Kмv");
            for (int r = 1; r < 3; r++)
            {
                if (sqlite_datareader.Read())
                {
                    grid3[r, 0] = new SourceGrid.Cells.RowHeader(Convert.ToString(sqlite_datareader.GetString(0)));
                    grid3[r, 1] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(1)), typeof(float));
                }
                for (int c = 0; c < 2; c++) //задание свойств ячеек
                {
                    if (c != 0) //для заголовков свойства не задаются
                    {
                        grid3[r, c].AddController(clickEvent);//клик мыши
                        grid3[r, c].AddController(cellpointer);//наведение
                        grid3[r, c].Editor.EnableEdit = false;//нередактируемые ячейки
                        grid3[r, c].AddController(new SourceGrid.Cells.Controllers.Unselectable());
                        grid3[r, c].AddController(new MyHelpRowTracking());//help row pointer
                    }
                }
            }
            grid3.AutoSizeCells();
            grid3.EnableSort = false;
            grid3.Selection.EnableMultiSelection = false;
            #endregion

            foreach (SourceGrid.GridColumn col in grid3.Columns)
                col.Width = 100;
            grid3.Columns[0].Width = 200;
            foreach (SourceGrid.GridRow row in grid3.Rows)
                row.Height = 25;
        }
        private void DoFullTab4()
        {
            SQLreader sqlReader = new SQLreader("database.sqlite");
            SQLiteDataReader sqlite_datareader = sqlReader.getReader("KpV");
            #region Код таблицы 5
            grid4.BorderStyle = BorderStyle.FixedSingle;
            grid4.Redim(4, 5);
            grid4[0, 0] = new SourceGrid.Cells.ColumnHeader("Материалы детали");
            //grid4[0, 0].Column.Width = 200;
            grid4[0, 0].RowSpan = 3;
            grid4[0, 1] = new SourceGrid.Cells.ColumnHeader("Заготовки с коркой");
            grid4[0, 1].ColumnSpan = 3;
            grid4[1, 1] = new SourceGrid.Cells.ColumnHeader("Поковка");
            grid4[1, 2] = new SourceGrid.Cells.ColumnHeader("Отливка");
            grid4[1, 3] = new SourceGrid.Cells.ColumnHeader("Прокат");
            grid4[0, 4] = new SourceGrid.Cells.ColumnHeader("Полуфабрикат \nбез корки");
            grid4[0, 4].RowSpan = 2;
            grid4[2, 1] = new SourceGrid.Cells.ColumnHeader("Kпv");
            grid4[2, 1].ColumnSpan = 4;
            if (sqlite_datareader.Read())
            {
                grid4[3, 0] = new SourceGrid.Cells.RowHeader(Convert.ToString(sqlite_datareader.GetString(0)));
                for (int c = 1; c < 5; c++)
                {
                    grid4[3, c] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(c)), typeof(float));
                    grid4[3, c].AddController(clickEvent);//клик мыши
                    grid4[3, c].AddController(cellpointer);//наведение
                    grid4[3, c].Editor.EnableEdit = false;//нередактируемые ячейки
                    grid4[3, c].AddController(new SourceGrid.Cells.Controllers.Unselectable());
                    grid4[3, c].AddController(new MyHelpRowTracking());//help row pointer
                }
            }
            grid4.AutoSizeCells();
            grid4.EnableSort = false;
            grid4.Selection.EnableMultiSelection = false;
            #endregion
            foreach (SourceGrid.GridColumn col in grid4.Columns)
                col.Width = 100;
            grid4.Columns[0].Width = 200;
            foreach (SourceGrid.GridRow row in grid4.Rows)
                row.Height = 25;
        }
        private void DoFullTab5()
        {
            SQLreader sqlReader = new SQLreader("database.sqlite");
            SQLiteDataReader sqlite_datareader = sqlReader.getReader("KiV_hard_alloy");
            #region Код таблицы 6 (твердый сплав)
            grid5.BorderStyle = BorderStyle.FixedSingle;
            grid5.Redim(7, 7);
            grid5[0, 0] = new SourceGrid.Cells.ColumnHeader("Материалы детали");
            //grid5[0, 0].Column.Width = 200;
            grid5[0, 0].RowSpan = 3;
            grid5[0, 1] = new SourceGrid.Cells.ColumnHeader("Твердый сплав");
            grid5[0, 1].ColumnSpan = 6;
            grid5[1, 1] = new SourceGrid.Cells.ColumnHeader("Т15К10");
            grid5[1, 2] = new SourceGrid.Cells.ColumnHeader("Т15К6");
            grid5[1, 3] = new SourceGrid.Cells.ColumnHeader("Т30К4");
            grid5[1, 4] = new SourceGrid.Cells.ColumnHeader("ВК8");
            grid5[1, 5] = new SourceGrid.Cells.ColumnHeader("ВК6");
            grid5[1, 6] = new SourceGrid.Cells.ColumnHeader("ВК4");
            grid5[2, 1] = new SourceGrid.Cells.ColumnHeader("Kиv");
            grid5[2, 1].ColumnSpan = 6;
            grid5[3, 4] = new SourceGrid.Cells.Cell("", typeof(string));
            grid5[3, 4].ColumnSpan = 3;
            grid5[4, 1] = new SourceGrid.Cells.Cell("", typeof(string));
            grid5[4, 1].ColumnSpan = 3;

            for (int r = 3; r < 5; r++)
            {
                if (sqlite_datareader.Read())
                {
                    grid5[r, 0] = new SourceGrid.Cells.RowHeader(Convert.ToString(sqlite_datareader.GetString(0)));
                    switch (r)
                    {
                        case 3:
                            for (int c = 1; c < 4; c++)
                            {
                                grid5[3, c] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(c)), typeof(float));
                                grid5[3, c].AddController(clickEvent);//клик мыши
                                grid5[3, c].AddController(cellpointer);//наведение
                                grid5[3, c].Editor.EnableEdit = false;//нередактируемые ячейки
                                grid5[3, c].AddController(new SourceGrid.Cells.Controllers.Unselectable());
                                grid5[3, c].AddController(new MyHelpRowTracking());//help row pointer
                            }
                            break;
                        case 4:
                            for (int c = 4; c < 7; c++)
                            {
                                grid5[4, c] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(c)), typeof(float));
                                grid5[4, c].AddController(clickEvent);//клик мыши
                                grid5[4, c].AddController(cellpointer);//наведение
                                grid5[4, c].Editor.EnableEdit = false;//нередактируемые ячейки
                                grid5[4, c].AddController(new SourceGrid.Cells.Controllers.Unselectable());
                                grid5[4, c].AddController(new MyHelpRowTracking());//help row pointer
                            }
                            break;
                    }
                }
            }
            #endregion
            sqlite_datareader = sqlReader.getReader("KiV_high_speed_steel");
            #region Код таблицы 6 (быстрорежущая сталь)

            grid5[5, 0] = new SourceGrid.Cells.ColumnHeader("Материалы детали");
            grid5[5, 1] = new SourceGrid.Cells.ColumnHeader("Быстрорежущая сталь");
            grid5[5, 1].ColumnSpan = 6;

            grid5[6, 1] = new SourceGrid.Cells.Cell("123");

            if (sqlite_datareader.Read())
            {
                grid5[6, 0] = new SourceGrid.Cells.RowHeader(Convert.ToString(sqlite_datareader.GetString(0)));
                grid5[6, 1] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(1)), typeof(float));
                grid5[6, 1].ColumnSpan = 6;
                grid5[6, 1].AddController(clickEvent);//клик мыши
                grid5[6, 1].AddController(cellpointer);//наведение
                grid5[6, 1].Editor.EnableEdit = false;//нередактируемые ячейки
                grid5[6, 1].AddController(new SourceGrid.Cells.Controllers.Unselectable());
                grid5[6, 1].AddController(new MyHelpRowTracking());//help row pointer
            }
            grid5.AutoSizeCells();
            grid5.EnableSort = false;
            grid5.Selection.EnableMultiSelection = false;
            #endregion

            foreach (SourceGrid.GridColumn col in grid5.Columns)
                col.Width = 100;
            grid5.Columns[0].Width = 200;
            foreach (SourceGrid.GridRow row in grid5.Rows)
                row.Height = 25;
        }
        private void DoFullTab6()
        {
            SQLreader sqlReader = new SQLreader("database.sqlite");
            SQLiteDataReader sqlite_datareader = sqlReader.getReader("EmpParamV");
            #region Код таблицы 7 (СтУг)
            grid6.BorderStyle = BorderStyle.FixedSingle;
            grid6.Redim(15, 7);
            //строка0
            grid6[0, 0] = new SourceGrid.Cells.ColumnHeader("Вид обработки");
            grid6[0, 1] = new SourceGrid.Cells.ColumnHeader("Материал резца");
            grid6[0, 2] = new SourceGrid.Cells.ColumnHeader("S");
            grid6[0, 3] = new SourceGrid.Cells.ColumnHeader("Cv");
            grid6[0, 4] = new SourceGrid.Cells.ColumnHeader("x");
            grid6[0, 5] = new SourceGrid.Cells.ColumnHeader("y");
            grid6[0, 6] = new SourceGrid.Cells.ColumnHeader("m");
            //строка1
            grid6[1, 0] = new SourceGrid.Cells.ColumnHeader("Сталь углеродистая");
            grid6[1, 0].ColumnSpan = 7;
            //строка2-4
            grid6[2, 0] = new SourceGrid.Cells.RowHeader("Наружнее точение \n Растачивание");
            grid6[2, 0].RowSpan = 3;

            //строка5-6
            grid6[5, 0] = new SourceGrid.Cells.RowHeader("Подрезание \n отрезание");
            grid6[5, 0].RowSpan = 2;
            //строка7-8
            grid6[7, 0] = new SourceGrid.Cells.RowHeader("Нарезание резьбы \n резцом");
            grid6[7, 0].RowSpan = 2;

            //Строка9
            grid6[9, 0] = new SourceGrid.Cells.ColumnHeader("Серый чугун");
            grid6[9, 0].ColumnSpan = 7;
            //материал резца
            grid6[2, 1] = new SourceGrid.Cells.RowHeader("Твердый \nсплав");
            grid6[2, 1].RowSpan = 4;
            grid6[6, 1] = new SourceGrid.Cells.RowHeader("Быстрорежущая \nсталь");
            grid6[7, 1] = new SourceGrid.Cells.RowHeader("Твердый \nсплав");
            grid6[8, 1] = new SourceGrid.Cells.RowHeader("Быстрорежущая \nсталь");

            for (int r = 2; r < 9; r++)
            {
                if (sqlite_datareader.Read())
                {
                    grid6[r, 2] = new SourceGrid.Cells.Cell(Convert.ToString(sqlite_datareader.GetString(0)), typeof(string));
                    grid6[r, 3] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(1)), typeof(float));
                    grid6[r, 4] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(2)), typeof(float));
                    grid6[r, 5] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(3)), typeof(float));
                    grid6[r, 6] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(4)), typeof(float));
                    for (int c = 2; c < 7; c++)
                    {
                        grid6[r, c].AddController(clickEvent);//клик мыши
                        grid6[r, c].AddController(rowpointer);//наведение
                        if (!((r == 7 && c == 2) || (r == 8 && c == 2)))
                        {
                            grid6[r, c].Editor.EnableEdit = false;//нередактируемые ячейки
                            grid6[r, c].AddController(new SourceGrid.Cells.Controllers.Unselectable());
                        }
                        grid6[r, c].AddController(new MyHelpRowTracking());//help row pointer
                    }
                }

            }
            #endregion
            #region Код таблицы 7 (СЧ)
            grid6[10, 0] = new SourceGrid.Cells.RowHeader("Наружнее точение \nРастачивание");
            grid6[10, 0].RowSpan = 2;
            grid6[12, 0] = new SourceGrid.Cells.RowHeader("Подрезание\nОтрезание");
            grid6[12, 0].RowSpan = 2;
            grid6[14, 0] = new SourceGrid.Cells.RowHeader("Нарезание\nрезьбы");
            //grid6[14, 0].RowSpan = 2;
            grid6[10, 1] = new SourceGrid.Cells.RowHeader("Твердый сплав");
            grid6[10, 1].RowSpan = 5;
            for (int r = 10; r < 15; r++)
            {
                if (sqlite_datareader.Read())
                {
                    grid6[r, 2] = new SourceGrid.Cells.Cell(Convert.ToString(sqlite_datareader.GetString(0)), typeof(string));
                    grid6[r, 3] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(1)), typeof(float));
                    grid6[r, 4] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(2)), typeof(float));
                    grid6[r, 5] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(3)), typeof(float));
                    grid6[r, 6] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(4)), typeof(float));
                    for (int c = 2; c < 7; c++)
                    {
                        grid6[r, c].AddController(clickEvent);//клик мыши
                        grid6[r, c].AddController(rowpointer);//наведение
                        if (!(r == 14 && c == 2))
                        {
                            grid6[r, c].Editor.EnableEdit = false;//нередактируемые ячейки
                            grid6[r, c].AddController(new SourceGrid.Cells.Controllers.Unselectable());
                        }
                        grid6[r, c].AddController(new MyHelpRowTracking());//help row pointer
                    }
                }
            }
            grid6.AutoSizeCells();
            grid6.EnableSort = false;
            grid6.Selection.EnableMultiSelection = false;
            //

            grid6[7, 2].AddController(CellChangedEvent_rezba);
            grid6[8, 2].AddController(CellChangedEvent_rezba);
            grid6[14, 2].AddController(CellChangedEvent_rezba);

            #endregion

            foreach (SourceGrid.GridColumn col in grid6.Columns)
                col.Width = 100;
            grid6.Columns[0].Width = 200;
            foreach (SourceGrid.GridRow row in grid6.Rows)
                row.Height = 25;
        }
        private void DoFullTab7()
        {
            SQLreader sqlReader = new SQLreader("database.sqlite");
            SQLiteDataReader sqlite_datareader = sqlReader.getReader("EmpParamPz");
            #region Код таблицы 8 (СтУг)
            grid7.BorderStyle = BorderStyle.FixedSingle;
            grid7.Redim(15, 6);
            //строка0
            grid7[0, 0] = new SourceGrid.Cells.ColumnHeader("Вид обработки");
            grid7[0, 1] = new SourceGrid.Cells.ColumnHeader("Материал резца");
            grid7[0, 2] = new SourceGrid.Cells.ColumnHeader("Cp");
            grid7[0, 3] = new SourceGrid.Cells.ColumnHeader("x");
            grid7[0, 4] = new SourceGrid.Cells.ColumnHeader("y");
            grid7[0, 5] = new SourceGrid.Cells.ColumnHeader("n");
            //строка1
            grid7[1, 0] = new SourceGrid.Cells.ColumnHeader("Сталь углеродистая");
            grid7[1, 0].ColumnSpan = 6;
            grid7[2, 0] = new SourceGrid.Cells.RowHeader("Наружнее точение \n Растачивание");
            grid7[3, 0] = new SourceGrid.Cells.RowHeader("Подрезание \n отрезание");
            grid7[4, 0] = new SourceGrid.Cells.RowHeader("Нарезание резьбы \n резцом");
            grid7[5, 0] = new SourceGrid.Cells.RowHeader("Наружнее точение \n растачивание");
            grid7[6, 0] = new SourceGrid.Cells.RowHeader("Подрезание \n отрезание");
            //Строка7
            grid7[7, 0] = new SourceGrid.Cells.ColumnHeader("Серый чугун");
            grid7[7, 0].ColumnSpan = 6;
            //материал резца
            grid7[2, 1] = new SourceGrid.Cells.RowHeader("Твердый \nсплав");
            grid7[2, 1].RowSpan = 3;
            grid7[5, 1] = new SourceGrid.Cells.RowHeader("Быстрорежущая \nсталь");
            grid7[5, 1].RowSpan = 2;

            for (int r = 2; r < 7; r++)
            {
                if (sqlite_datareader.Read())
                {
                    grid7[r, 2] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(0)), typeof(float));
                    grid7[r, 3] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(1)), typeof(float));
                    grid7[r, 4] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(2)), typeof(float));
                    grid7[r, 5] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(3)), typeof(float));

                    for (int c = 2; c < 6; c++)
                    {
                        grid7[r, c].AddController(clickEvent);//клик мыши
                        grid7[r, c].AddController(rowpointer);//наведение
                        grid7[r, c].Editor.EnableEdit = false;//нередактируемые ячейки
                        grid7[r, c].AddController(new SourceGrid.Cells.Controllers.Unselectable());
                        grid7[r, c].AddController(new MyHelpRowTracking());//help row pointer
                    }
                }

            }
            #endregion
            sqlite_datareader = sqlReader.getReader("EmpParamPz");
            #region Код таблицы 8 (СЧ)
            grid7[8, 0] = new SourceGrid.Cells.RowHeader("Наружнее точение \nРастачивание");
            grid7[8, 1] = new SourceGrid.Cells.RowHeader("Твердый сплав");
            grid7[9, 0] = new SourceGrid.Cells.RowHeader("Подрезание\nОтрезание");
            grid7[9, 1] = new SourceGrid.Cells.RowHeader("Быстрорежущая сталь");
            grid7[10, 0] = new SourceGrid.Cells.RowHeader("Нарезание\nрезьбы");
            grid7[10, 1] = new SourceGrid.Cells.RowHeader("Твердый сплав");

            for (int r = 8; r < 11; r++)
            {
                if (sqlite_datareader.Read())
                {
                    grid7[r, 2] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(0)), typeof(float));
                    grid7[r, 3] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(1)), typeof(float));
                    grid7[r, 4] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(2)), typeof(float));
                    grid7[r, 5] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(3)), typeof(float));
                    for (int c = 2; c < 6; c++)
                    {
                        grid7[r, c].AddController(clickEvent);//клик мыши
                        grid7[r, c].AddController(rowpointer);//наведение
                        grid7[r, c].Editor.EnableEdit = false;//нередактируемые ячейки
                        grid7[r, c].AddController(new SourceGrid.Cells.Controllers.Unselectable());
                        grid7[r, c].AddController(new MyHelpRowTracking());//help row pointer
                    }
                }
            }
            grid7.AutoSizeCells();
            grid7.EnableSort = false;
            grid7.Selection.EnableMultiSelection = false;
            #endregion

            foreach (SourceGrid.GridColumn col in grid7.Columns)
                col.Width = 100;
            grid7.Columns[0].Width = 200;
            foreach (SourceGrid.GridRow row in grid7.Rows)
                row.Height = 25;
        }
        private void DoFullTab8()
        {

            SQLreader sqlReader = new SQLreader("database.sqlite");
            SQLiteDataReader sqlite_datareader = sqlReader.getReader("KmP");
            #region Код таблицы 9
            grid8.BorderStyle = BorderStyle.FixedSingle;
            grid8.Redim(3, 2);
            grid8.Rows.Insert(0);
            grid8[0, 0] = new SourceGrid.Cells.ColumnHeader("Обрабатываемый материал");
            grid8[0, 0].Column.Width = 200;
            grid8[0, 1] = new SourceGrid.Cells.ColumnHeader("Kmp");
            for (int r = 1; r < 3; r++)
            {
                if (sqlite_datareader.Read())
                {
                    grid8[r, 0] = new SourceGrid.Cells.RowHeader(Convert.ToString(sqlite_datareader.GetString(0)));
                    grid8[r, 1] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(1)), typeof(float));
                }
                for (int c = 0; c < 2; c++) //задание свойств ячеек
                {
                    if (c != 0) //для заголовков свойства не задаются
                    {
                        grid8[r, c].AddController(clickEvent);//клик мыши
                        grid8[r, c].AddController(cellpointer);//наведение
                        grid8[r, c].Editor.EnableEdit = false;//нередактируемые ячейки
                        grid8[r, c].AddController(new SourceGrid.Cells.Controllers.Unselectable());
                        grid8[r, c].AddController(new MyHelpRowTracking());//help row pointer
                    }
                }
            }
            grid8.AutoSizeCells();
            grid8.EnableSort = false;
            grid8.Selection.EnableMultiSelection = false;
            #endregion


            foreach (SourceGrid.GridColumn col in grid8.Columns)
                col.Width = 100;
            grid8.Columns[0].Width = 200;
            foreach (SourceGrid.GridRow row in grid8.Rows)
                row.Height = 25;
        }

        private void DoFullRusultTab1_Turning()
        {
            #region Код таблицы
            grid18.BorderStyle = BorderStyle.FixedSingle;
            grid18.Redim(19, 4);
            SourceGrid.Cells.Views.Cell viewImage = new SourceGrid.Cells.Views.Cell();
            SourceGrid.Cells.Editors.TextBox tb = new SourceGrid.Cells.Editors.TextBox(typeof(float));
            SourceGrid.Cells.Editors.ComboBox cb = new SourceGrid.Cells.Editors.ComboBox(typeof(float), new float[] { 20, 30, 40, 60, 90, 120 }, false);
            int row = 0;
            grid18[row, 0] = new SourceGrid.Cells.ColumnHeader("Входные параметры");
            grid18[row, 0].ColumnSpan = 4;
            row++;
            grid18[row, 0] = new SourceGrid.Cells.RowHeader("Подача");
            grid18[row, 1] = new SourceGrid.Cells.RowHeader("S");
            grid18[row, 2] = new SourceGrid.Cells.Cell();
            grid18[row, 3] = new SourceGrid.Cells.ColumnHeader("мм/об");
            grid18[row, 0].Column.Width = 150;
            row++;
            grid18[row, 0] = new SourceGrid.Cells.RowHeader("Глубина резания");
            grid18[row, 1] = new SourceGrid.Cells.RowHeader("t");
            grid18[row, 2] = new SourceGrid.Cells.Cell();
            grid18[row, 3] = new SourceGrid.Cells.ColumnHeader("мм");
            row++;
            grid18[row, 0] = new SourceGrid.Cells.RowHeader("Период стойкости резца");
            grid18[row, 1] = new SourceGrid.Cells.RowHeader("T");
            grid18[row, 2] = new SourceGrid.Cells.Cell();
            grid18[row, 2].AddController(CellChangedEvent);
            grid18[row, 3] = new SourceGrid.Cells.ColumnHeader("мин");

            grid18[row, 2].Editor = cb;
            grid18[row, 2].Editor.EditableMode = EditableMode.SingleClick;

            row++;
            grid18[row, 0] = new SourceGrid.Cells.RowHeader("Диаметр инструмента");
            grid18[row, 1] = new SourceGrid.Cells.RowHeader("D");
            grid18[row, 2] = new SourceGrid.Cells.Cell();
            grid18[row, 3] = new SourceGrid.Cells.ColumnHeader("мм");
            row++;

            grid18[row, 0] = new SourceGrid.Cells.RowHeader("Поправка на инструментальный материал");
            grid18[row, 1] = new SourceGrid.Cells.RowHeader("Киv");
            grid18[row, 2] = new SourceGrid.Cells.Cell();
            grid18[row, 3] = new SourceGrid.Cells.ColumnHeader("мм");
            row++;

            grid18[row, 0] = new SourceGrid.Cells.RowHeader("Поправка на обрабатываемый материал");
            grid18[row, 1] = new SourceGrid.Cells.RowHeader("Kмv");
            grid18[row, 2] = new SourceGrid.Cells.Cell();
            grid18[row, 3] = new SourceGrid.Cells.ColumnHeader("б/р");
            row++;

            grid18[row, 0] = new SourceGrid.Cells.RowHeader("Поправка на состояние поверхности");
            grid18[row, 1] = new SourceGrid.Cells.RowHeader("Kпv");
            grid18[row, 2] = new SourceGrid.Cells.Cell();
            grid18[row, 3] = new SourceGrid.Cells.ColumnHeader("б/р");
            row++;

            grid18[row, 0] = new SourceGrid.Cells.RowHeader("Поправка на глубину отверстия");
            grid18[row, 1] = new SourceGrid.Cells.RowHeader("Kмp");
            grid18[row, 2] = new SourceGrid.Cells.Cell();
            grid18[row, 3] = new SourceGrid.Cells.ColumnHeader("б/р");
            row++;

            grid18[row, 0] = new SourceGrid.Cells.ColumnHeader("Эмпирические коэффициенты скорости резания");
            grid18[row, 0].ColumnSpan = 4;
            row++;

            grid18[row, 0] = new SourceGrid.Cells.ColumnHeader("Сv");
            grid18[row, 0].ColumnSpan = 2;
            grid18[row, 2] = new SourceGrid.Cells.Cell();
            grid18[row, 3] = new SourceGrid.Cells.ColumnHeader("б/р");
            row++;

            grid18[row, 0] = new SourceGrid.Cells.ColumnHeader("x");
            grid18[row, 0].ColumnSpan = 2;
            grid18[row, 2] = new SourceGrid.Cells.Cell();
            grid18[row, 3] = new SourceGrid.Cells.ColumnHeader("б/р");
            row++;

            grid18[row, 0] = new SourceGrid.Cells.ColumnHeader("y");
            grid18[row, 0].ColumnSpan = 2;
            grid18[row, 2] = new SourceGrid.Cells.Cell();
            grid18[row, 3] = new SourceGrid.Cells.ColumnHeader("б/р");
            row++;

            grid18[row, 0] = new SourceGrid.Cells.ColumnHeader("m");
            grid18[row, 0].ColumnSpan = 2;
            grid18[row, 2] = new SourceGrid.Cells.Cell();
            grid18[row, 3] = new SourceGrid.Cells.ColumnHeader("б/р");
            row++;

            grid18[row, 0] = new SourceGrid.Cells.ColumnHeader("Эмпирические коэффициенты силы резания");
            grid18[row, 0].ColumnSpan = 4;
            row++;

            grid18[row, 0] = new SourceGrid.Cells.ColumnHeader("Ср");
            grid18[row, 0].ColumnSpan = 2;
            grid18[row, 2] = new SourceGrid.Cells.Cell();
            grid18[row, 3] = new SourceGrid.Cells.ColumnHeader("б/р");
            row++;

            grid18[row, 0] = new SourceGrid.Cells.ColumnHeader("x");
            grid18[row, 0].ColumnSpan = 2;
            grid18[row, 2] = new SourceGrid.Cells.Cell();
            grid18[row, 3] = new SourceGrid.Cells.ColumnHeader("б/р");
            row++;

            grid18[row, 0] = new SourceGrid.Cells.ColumnHeader("y");
            grid18[row, 0].ColumnSpan = 2;
            grid18[row, 2] = new SourceGrid.Cells.Cell();
            grid18[row, 3] = new SourceGrid.Cells.ColumnHeader("б/р");

            row++;

            grid18[row, 0] = new SourceGrid.Cells.ColumnHeader("n");
            grid18[row, 0].ColumnSpan = 2;
            grid18[row, 2] = new SourceGrid.Cells.Cell();
            grid18[row, 3] = new SourceGrid.Cells.ColumnHeader("б/р");

            // Добавляем возможность редактировать и указываем событие при изменении значения
            for (int r = 1; r < grid18.RowsCount; r++)
            {
                if (r != 3 && r != 9 && r != 14)
                {
                    grid18[r, 2].Editor = tb;
                    grid18[r, 2].AddController(CellChangedEvent);
                    grid18[r, 2].AddController(new MyCellTracking());//наведение
                    //grid18[r, 2].AddController(new MyHelpRowTracking());//help row pointer
                }
            }


            #endregion


            foreach (SourceGrid.GridColumn col in grid18.Columns)
                col.Width = 80;
            grid18.Columns[0].Width = 100;
            foreach (SourceGrid.GridRow r in grid18.Rows)
                r.Height = 25;
        }
        private void DoFullResultTab2_Turning()
        {
            #region Код таблицы
            grid19.BorderStyle = BorderStyle.FixedSingle;
            grid19.Redim(6, 4);
            int row = 0;
            grid19[row, 0] = new SourceGrid.Cells.ColumnHeader("Выходные параметры");
            grid19[row, 0].ColumnSpan = 4;

            row++;
            grid19[row, 0] = new SourceGrid.Cells.RowHeader("Скорость резания");
            grid19[row, 1] = new SourceGrid.Cells.RowHeader();

            grid19[row, 1] = new SourceGrid.Cells.Cell();
            //Properties.Resources.V2.SetResolution((float)(Properties.Resources.V2.HorizontalResolution * 0.3), (float)(Properties.Resources.V2.VerticalResolution * 0.3));
            grid19[row, 1].Image = Properties.Resources.V;

            grid19[row, 2] = new SourceGrid.Cells.Cell();
            grid19[row, 3] = new SourceGrid.Cells.Cell("м/мин");
            row++;
            grid19[row, 0] = new SourceGrid.Cells.RowHeader("Сила резания");
            grid19[row, 1] = new SourceGrid.Cells.RowHeader();

            grid19[row, 1] = new SourceGrid.Cells.Cell();
            grid19[row, 1].Image = Properties.Resources.P;

            grid19[row, 2] = new SourceGrid.Cells.Cell();
            grid19[row, 3] = new SourceGrid.Cells.Cell("Н");
            row++;
            grid19[row, 0] = new SourceGrid.Cells.RowHeader("Момент резания");
            grid19[row, 1] = new SourceGrid.Cells.RowHeader();

            grid19[row, 1] = new SourceGrid.Cells.Cell();
            Bitmap bm = new Bitmap(Properties.Resources.M);
            bm.SetResolution(96.0F, 96.0F);
            grid19[row, 1].Image = bm;//Properties.Resources.M2;

            grid19[row, 2] = new SourceGrid.Cells.Cell();
            grid19[row, 3] = new SourceGrid.Cells.Cell("Нм");

            row++;
            grid19[row, 0] = new SourceGrid.Cells.RowHeader("Потребляемая мощность");
            grid19[row, 1] = new SourceGrid.Cells.RowHeader();

            grid19[row, 1] = new SourceGrid.Cells.Cell();
            grid19[row, 1].Image = Properties.Resources.N;

            grid19[row, 2] = new SourceGrid.Cells.Cell();
            grid19[row, 3] = new SourceGrid.Cells.Cell("кВт");


            row++;
            grid19[row, 0] = new SourceGrid.Cells.RowHeader("Частота вращения шпинделя");
            grid19[row, 1] = new SourceGrid.Cells.RowHeader();

            grid19[row, 1] = new SourceGrid.Cells.Cell();
            grid19[row, 1].Image = Properties.Resources.n_2_;

            grid19[row, 2] = new SourceGrid.Cells.Cell();
            grid19[row, 3] = new SourceGrid.Cells.Cell("об/мин");

            grid19.Columns[0].Width = 130;
            grid19.Columns[1].Width = 210;
            grid19.Columns[2].Width = 70;
            grid19.Columns[3].Width = 70;

            grid19.Rows[0].Height = 36;
            grid19.Rows[1].Height = 60;
            grid19.Rows[2].Height = 60;
            grid19.Rows[3].Height = 60;
            grid19.Rows[4].Height = 60;
            grid19.Rows[5].Height = 60;



            #endregion
        }
        private void DoFullGrid18_Turning()
        {
            grid18[1, 2].Value = ts.inputData.s;
            grid18[2, 2].Value = ts.inputData.t;
            grid18[3, 2].Value = ts.inputData.T;
            grid18[4, 2].Value = ts.inputData.D;
            grid18[5, 2].Value = ts.inputData.Kiv;
            grid18[6, 2].Value = ts.inputData.Kmv;
            grid18[7, 2].Value = ts.inputData.Kpv;
            grid18[8, 2].Value = ts.inputData.Kmp;

            grid18[10, 2].Value = ts.inputData.Cv;
            grid18[11, 2].Value = ts.inputData.xv;
            grid18[12, 2].Value = ts.inputData.yv;
            grid18[13, 2].Value = ts.inputData.mv;

            grid18[15, 2].Value = ts.inputData.Cp;
            grid18[16, 2].Value = ts.inputData.xp;
            grid18[17, 2].Value = ts.inputData.yp;
            grid18[18, 2].Value = ts.inputData.np;

        }
        private void DoFullGrid19_Turning()
        {
            grid19[1, 2].Value = ts.getV();
            grid19[2, 2].Value = ts.getP();
            grid19[3, 2].Value = ts.getM();
            grid19[4, 2].Value = ts.getN();
            grid19[5, 2].Value = ts.getn();
            //
        }
        #endregion
        #region Код М DoFullTab
        public void DoFullTab1_Mill()
        {
            SQLreader sqlReader = new SQLreader("databaseF.sqlite");
            SQLiteDataReader sqlite_datareader = sqlReader.getReader("FrEmpParamV");
            #region Код таблицы 1 (твердый сплав)
            grid1Mill.BorderStyle = BorderStyle.FixedSingle;
            grid1Mill.Redim(15, 11);
            //заголовок
            grid1Mill[0, 0] = new SourceGrid.Cells.ColumnHeader("Вид обработки");
            grid1Mill[0, 1] = new SourceGrid.Cells.ColumnHeader("Материал резца");
            grid1Mill[0, 2] = new SourceGrid.Cells.ColumnHeader("t");
            grid1Mill[0, 3] = new SourceGrid.Cells.ColumnHeader("Sz");
            grid1Mill[0, 4] = new SourceGrid.Cells.ColumnHeader("Cv");
            grid1Mill[0, 5] = new SourceGrid.Cells.ColumnHeader("q");
            grid1Mill[0, 6] = new SourceGrid.Cells.ColumnHeader("x");
            grid1Mill[0, 7] = new SourceGrid.Cells.ColumnHeader("y");
            grid1Mill[0, 8] = new SourceGrid.Cells.ColumnHeader("u");
            grid1Mill[0, 9] = new SourceGrid.Cells.ColumnHeader("p");
            grid1Mill[0, 10] = new SourceGrid.Cells.ColumnHeader("m");
            grid1Mill[1, 0] = new SourceGrid.Cells.ColumnHeader("Сталь углеродистая");
            grid1Mill[1, 0].View.TextAlignment = DevAge.Drawing.ContentAlignment.MiddleCenter;
            grid1Mill[1, 0].ColumnSpan = 11;
            //строка 2
            grid1Mill[2, 0] = new SourceGrid.Cells.RowHeader("Торцевое \nфрезерование");
            grid1Mill[2, 0].RowSpan = 2;
            grid1Mill[4, 0] = new SourceGrid.Cells.RowHeader("Боковое \nфрезерование");
            grid1Mill[4, 0].RowSpan = 4;
            grid1Mill[8, 0] = new SourceGrid.Cells.ColumnHeader("Чугун");
            grid1Mill[8, 0].ColumnSpan = 11;
            //строка 2
            grid1Mill[9, 0] = new SourceGrid.Cells.RowHeader("Торцевое \nфрезерование");
            grid1Mill[9, 0].RowSpan = 2;
            grid1Mill[11, 0] = new SourceGrid.Cells.RowHeader("Боковое \nфрезерование");
            grid1Mill[11, 0].RowSpan = 4;
            for (int r = 2; r < 8; r++)
            {
                //grid1.Rows.Insert(r);
                if (sqlite_datareader.Read())
                {
                    grid1Mill[r, 1] = new SourceGrid.Cells.RowHeader(Convert.ToString(sqlite_datareader.GetString(0)));
                    grid1Mill[r, 2] = new SourceGrid.Cells.RowHeader(Convert.ToString(sqlite_datareader.GetString(1)));
                    grid1Mill[r, 3] = new SourceGrid.Cells.RowHeader(Convert.ToString(sqlite_datareader.GetString(2)));
                    grid1Mill[r, 4] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(3)), typeof(float));
                    grid1Mill[r, 5] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(4)), typeof(float));
                    grid1Mill[r, 6] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(5)), typeof(float));
                    grid1Mill[r, 7] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(6)), typeof(float));
                    grid1Mill[r, 8] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(7)), typeof(float));
                    grid1Mill[r, 9] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(8)), typeof(float));
                    grid1Mill[r, 10] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(9)), typeof(float));
                }
                for (int c = 4; c < 11; c++)
                {
                    grid1Mill[r, c].AddController(clickEvent);//клик мыши
                    grid1Mill[r, c].AddController(rowpointer);//наведение
                    grid1Mill[r, c].Editor.EnableEdit = false;//нередактируемые ячейки
                    grid1Mill[r, c].AddController(new SourceGrid.Cells.Controllers.Unselectable());
                    grid1Mill[r, c].AddController(new MyHelpRowTracking());//help row pointer

                }
            }
            for (int r = 9; r < 15; r++)
            {
                if (sqlite_datareader.Read())
                {
                    grid1Mill[r, 1] = new SourceGrid.Cells.RowHeader(Convert.ToString(sqlite_datareader.GetString(0)));
                    grid1Mill[r, 2] = new SourceGrid.Cells.RowHeader(Convert.ToString(sqlite_datareader.GetString(1)));
                    grid1Mill[r, 3] = new SourceGrid.Cells.RowHeader(Convert.ToString(sqlite_datareader.GetString(2)));
                    grid1Mill[r, 4] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(3)), typeof(float));
                    grid1Mill[r, 5] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(4)), typeof(float));
                    grid1Mill[r, 6] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(5)), typeof(float));
                    grid1Mill[r, 7] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(6)), typeof(float));
                    grid1Mill[r, 8] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(7)), typeof(float));
                    grid1Mill[r, 9] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(8)), typeof(float));
                    grid1Mill[r, 10] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(9)), typeof(float));
                }
                for (int c = 4; c < 11; c++)
                {
                    grid1Mill[r, c].AddController(clickEvent);//клик мыши
                    grid1Mill[r, c].AddController(rowpointer);//наведение
                    grid1Mill[r, c].Editor.EnableEdit = false;//нередактируемые ячейки
                    grid1Mill[r, c].AddController(new SourceGrid.Cells.Controllers.Unselectable());
                    grid1Mill[r, c].AddController(new MyHelpRowTracking());//help row pointer
                }
            }
            grid1Mill.AutoSizeCells();
            grid1Mill.EnableSort = false;
            grid1Mill.Selection.EnableMultiSelection = false;
            #endregion


            foreach (SourceGrid.GridColumn col in grid1Mill.Columns)
                col.Width = 60;
            grid1Mill.Columns[0].Width = 200;
            foreach (SourceGrid.GridRow row in grid1Mill.Rows)
                row.Height = 25;
        }
        public void DoFullTab2_Mill()
        {
            #region Код таблицы 2 (Зав z от D)

            grid2Mill.BorderStyle = BorderStyle.FixedSingle;
            grid2Mill.Redim(2, 10);
            //заголовок
            grid2Mill[0, 0] = new SourceGrid.Cells.RowHeader("D, мм");
            grid2Mill[0, 1] = new SourceGrid.Cells.RowHeader("10-18");
            grid2Mill[0, 2] = new SourceGrid.Cells.RowHeader("19-28");
            grid2Mill[0, 3] = new SourceGrid.Cells.RowHeader("29-50");
            grid2Mill[0, 4] = new SourceGrid.Cells.RowHeader("51-63");
            grid2Mill[0, 5] = new SourceGrid.Cells.RowHeader("64-80");
            grid2Mill[0, 6] = new SourceGrid.Cells.RowHeader("81-100");
            grid2Mill[0, 7] = new SourceGrid.Cells.RowHeader("101-125");
            grid2Mill[0, 8] = new SourceGrid.Cells.RowHeader("126-160");
            grid2Mill[0, 9] = new SourceGrid.Cells.RowHeader("161-200");
            grid2Mill[1, 0] = new SourceGrid.Cells.RowHeader("z");
            grid2Mill[0, 0].View.TextAlignment = DevAge.Drawing.ContentAlignment.MiddleCenter;
            grid2Mill[0, 1].View.TextAlignment = DevAge.Drawing.ContentAlignment.MiddleCenter;
            grid2Mill[1, 1] = new SourceGrid.Cells.Cell(Convert.ToString(3), typeof(string));
            grid2Mill[1, 2] = new SourceGrid.Cells.Cell(Convert.ToString(3), typeof(string));
            grid2Mill[1, 3] = new SourceGrid.Cells.Cell(Convert.ToString(4), typeof(string));
            grid2Mill[1, 4] = new SourceGrid.Cells.Cell(Convert.ToString(5), typeof(string));
            grid2Mill[1, 5] = new SourceGrid.Cells.Cell(Convert.ToString(8), typeof(string));
            grid2Mill[1, 6] = new SourceGrid.Cells.Cell(Convert.ToString(10), typeof(string));
            grid2Mill[1, 7] = new SourceGrid.Cells.Cell(Convert.ToString(12), typeof(string));
            grid2Mill[1, 8] = new SourceGrid.Cells.Cell(Convert.ToString(14), typeof(string));
            grid2Mill[1, 9] = new SourceGrid.Cells.Cell(Convert.ToString(18), typeof(string));
            for (int c = 1; c < 10; c++)
            {
                grid2Mill[1, c].AddController(clickEvent);//клик мыши
                grid2Mill[1, c].AddController(cellpointer);//наведение
                grid2Mill[1, c].Editor.EnableEdit = false;//нередактируемые ячейки
                grid2Mill[1, c].AddController(new SourceGrid.Cells.Controllers.Unselectable());
                grid2Mill[1, c].AddController(new MyHelpRowTracking());//help row pointer
            }
            grid2Mill.AutoSizeCells();
            grid2Mill.EnableSort = false;
            grid2Mill.Selection.EnableMultiSelection = false;
            #endregion


            foreach (SourceGrid.GridColumn col in grid2Mill.Columns)
                col.Width = 100;
            foreach (SourceGrid.GridRow row in grid2Mill.Rows)
                row.Height = 25;
        }
        public void DoFullTab3_Mill()
        {
            SQLreader sqlReader = new SQLreader("databaseF.sqlite");
            SQLiteDataReader sqlite_datareader = sqlReader.getReader("FrParamKv");
            #region Код таблицы 3 (Коэф. Kv)
            grid3Mill.BorderStyle = BorderStyle.FixedSingle;
            grid3Mill.Redim(7, 3);

            grid3Mill[0, 0] = new SourceGrid.Cells.ColumnHeader("Коэффициент Kv");
            grid3Mill[0, 0].ColumnSpan = 3;
            grid3Mill[1, 0] = new SourceGrid.Cells.ColumnHeader("Вид загатовки");
            grid3Mill[1, 0].RowSpan = 2;
            grid3Mill[1, 1] = new SourceGrid.Cells.ColumnHeader("Обрабатываемый материал");
            grid3Mill[1, 1].ColumnSpan = 2;
            grid3Mill[2, 1] = new SourceGrid.Cells.ColumnHeader("Конструкционная сталь");
            grid3Mill[2, 2] = new SourceGrid.Cells.ColumnHeader("Серый чугун");
            grid3Mill[0, 0].View.TextAlignment = DevAge.Drawing.ContentAlignment.MiddleCenter;
            grid3Mill[0, 1].View.TextAlignment = DevAge.Drawing.ContentAlignment.MiddleCenter;
            for (int r = 3; r < 7; r++)
            {
                if (sqlite_datareader.Read())
                {
                    grid3Mill[r, 0] = new SourceGrid.Cells.RowHeader(Convert.ToString(sqlite_datareader.GetString(0)));
                    grid3Mill[r, 1] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(1)), typeof(float));
                    grid3Mill[r, 2] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(2)), typeof(float));
                }
                for (int c = 1; c < 3; c++)
                {
                    grid3Mill[r, c].View.TextAlignment = DevAge.Drawing.ContentAlignment.MiddleCenter;
                    grid3Mill[r, c].AddController(clickEvent);//клик мыши
                    grid3Mill[r, c].AddController(cellpointer);//наведение
                    grid3Mill[r, c].Editor.EnableEdit = false;//нередактируемые ячейки
                    grid3Mill[r, c].AddController(new SourceGrid.Cells.Controllers.Unselectable());
                    grid3Mill[r, c].AddController(new MyHelpRowTracking());//help row pointer
                }
            }
            grid3Mill.AutoSizeCells();
            grid3Mill.EnableSort = false;
            grid3Mill.Selection.EnableMultiSelection = false;
            #endregion


            foreach (SourceGrid.GridColumn col in grid3Mill.Columns)
                col.Width = 150;
            grid3Mill.Columns[0].Width = 150;
            foreach (SourceGrid.GridRow row in grid3Mill.Rows)
                row.Height = 25;
        }
        public void DoFullTab4_Mill()
        {
            SQLreader sqlReader = new SQLreader("databaseF.sqlite");
            SQLiteDataReader sqlite_datareader = sqlReader.getReader("FrParamKp");
            #region Код таблицы 4 (Коэф. Kp)
            grid4Mill.BorderStyle = BorderStyle.FixedSingle;
            grid4Mill.Redim(3, 2);
            grid4Mill[0, 0] = new SourceGrid.Cells.ColumnHeader("Обрабатываемый \nматериал");
            grid4Mill[0, 1] = new SourceGrid.Cells.ColumnHeader("Коэффицент Kp");
            for (int r = 1; r < 3; r++)
            {
                if (sqlite_datareader.Read())
                {
                    grid4Mill[r, 0] = new SourceGrid.Cells.RowHeader(Convert.ToString(sqlite_datareader.GetString(0)));
                    grid4Mill[r, 1] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(1)), typeof(float));
                    grid4Mill[r, 0].View.TextAlignment = DevAge.Drawing.ContentAlignment.MiddleCenter;
                }
                grid4Mill[r, 1].View.TextAlignment = DevAge.Drawing.ContentAlignment.MiddleCenter;
                grid4Mill[r, 1].AddController(clickEvent);//клик мыши
                grid4Mill[r, 1].AddController(cellpointer);//наведение
                grid4Mill[r, 1].Editor.EnableEdit = false;//нередактируемые ячейки
                grid4Mill[r, 1].AddController(new SourceGrid.Cells.Controllers.Unselectable());
                grid4Mill[r, 1].AddController(new MyHelpRowTracking());//help row pointer
            }
            grid4Mill.AutoSizeCells();
            grid4Mill.EnableSort = false;
            grid4Mill.Selection.EnableMultiSelection = false;
            #endregion


            foreach (SourceGrid.GridColumn col in grid4Mill.Columns)
                col.Width = 100;
            grid4Mill.Columns[0].Width = 150;
            foreach (SourceGrid.GridRow row in grid4Mill.Rows)
                row.Height = 25;
        }
        public void DoFullTab5_Mill()
        {
            SQLreader sqlReader = new SQLreader("databaseF.sqlite");
            SQLiteDataReader sqlite_datareader = sqlReader.getReader("FrParamPz");
            #region Код таблицы 5 (Коэф. к ур. силы резания)
            grid5Mill.BorderStyle = BorderStyle.FixedSingle;
            grid5Mill.Redim(11, 8);
            grid5Mill[0, 0] = new SourceGrid.Cells.ColumnHeader("Вид обработки");
            grid5Mill[0, 1] = new SourceGrid.Cells.ColumnHeader("Материал резца");
            grid5Mill[0, 2] = new SourceGrid.Cells.ColumnHeader("Cр");
            grid5Mill[0, 3] = new SourceGrid.Cells.ColumnHeader("х");
            grid5Mill[0, 4] = new SourceGrid.Cells.ColumnHeader("y");
            grid5Mill[0, 5] = new SourceGrid.Cells.ColumnHeader("u");
            grid5Mill[0, 6] = new SourceGrid.Cells.ColumnHeader("q");
            grid5Mill[0, 7] = new SourceGrid.Cells.ColumnHeader("w");
            grid5Mill[1, 0] = new SourceGrid.Cells.ColumnHeader("Сталь углеродистая");
            grid5Mill[1, 0].ColumnSpan = 8;
            grid5Mill[2, 0] = new SourceGrid.Cells.RowHeader("Торцевое \nфрезерование");
            grid5Mill[2, 0].RowSpan = 2;
            grid5Mill[4, 0] = new SourceGrid.Cells.RowHeader("Боковое \nфрезерование");
            grid5Mill[4, 0].RowSpan = 2;
            grid5Mill[6, 0] = new SourceGrid.Cells.ColumnHeader("Серый чугун");
            grid5Mill[6, 0].ColumnSpan = 8;
            grid5Mill[7, 0] = new SourceGrid.Cells.RowHeader("Торцевое \nфрезерование");
            grid5Mill[7, 0].RowSpan = 2;
            grid5Mill[9, 0] = new SourceGrid.Cells.RowHeader("Боковое \nфрезерование");
            grid5Mill[9, 0].RowSpan = 2;
            for (int r = 2; r < 6; r++)
            {
                if (sqlite_datareader.Read())
                {
                    grid5Mill[r, 1] = new SourceGrid.Cells.RowHeader(Convert.ToString(sqlite_datareader.GetString(0)));
                    grid5Mill[r, 2] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(1)), typeof(float));
                    grid5Mill[r, 3] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(2)), typeof(float));
                    grid5Mill[r, 4] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(3)), typeof(float));
                    grid5Mill[r, 5] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(4)), typeof(float));
                    grid5Mill[r, 6] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(5)), typeof(float));
                    grid5Mill[r, 7] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(6)), typeof(float));
                }
                for (int c = 2; c < 8; c++)
                {
                    grid5Mill[r, c].View.TextAlignment = DevAge.Drawing.ContentAlignment.MiddleCenter;
                    grid5Mill[r, c].AddController(clickEvent);//клик мыши
                    grid5Mill[r, c].AddController(rowpointer);//наведение
                    grid5Mill[r, c].Editor.EnableEdit = false;//нередактируемые ячейки
                    grid5Mill[r, c].AddController(new SourceGrid.Cells.Controllers.Unselectable());
                    grid5Mill[r, c].AddController(new MyHelpRowTracking());//help row pointer
                }
            }
            for (int r = 7; r < 11; r++)
            {
                if (sqlite_datareader.Read())
                {
                    grid5Mill[r, 1] = new SourceGrid.Cells.RowHeader(Convert.ToString(sqlite_datareader.GetString(0)));
                    grid5Mill[r, 2] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(1)), typeof(float));
                    grid5Mill[r, 3] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(2)), typeof(float));
                    grid5Mill[r, 4] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(3)), typeof(float));
                    grid5Mill[r, 5] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(4)), typeof(float));
                    grid5Mill[r, 6] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(5)), typeof(float));
                    grid5Mill[r, 7] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(6)), typeof(float));
                }
                for (int c = 2; c < 8; c++)
                {
                    grid5Mill[r, c].AddController(clickEvent);//клик мыши
                    grid5Mill[r, c].AddController(rowpointer);//наведение
                    grid5Mill[r, c].Editor.EnableEdit = false;//нередактируемые ячейки
                    grid5Mill[r, c].AddController(new SourceGrid.Cells.Controllers.Unselectable());
                    grid5Mill[r, c].AddController(new MyHelpRowTracking());//help row pointer
                }
            }
            grid5Mill.AutoSizeCells();
            grid5Mill.EnableSort = false;
            grid5Mill.Selection.EnableMultiSelection = false;
            #endregion


            foreach (SourceGrid.GridColumn col in grid5Mill.Columns)
                col.Width = 100;
            grid5Mill.Columns[0].Width = 150;
            foreach (SourceGrid.GridRow row in grid5Mill.Rows)
                row.Height = 25;
        }
        #endregion

        private void DoFullRusultTab1_Milling()
        {
            #region Код таблицы
            grid20.BorderStyle = BorderStyle.FixedSingle;
            grid20.Redim(24, 4);
            SourceGrid.Cells.Views.Cell viewImage = new SourceGrid.Cells.Views.Cell();
            SourceGrid.Cells.Editors.TextBox tb = new SourceGrid.Cells.Editors.TextBox(typeof(float));
            SourceGrid.Cells.Editors.ComboBox cb = new SourceGrid.Cells.Editors.ComboBox(typeof(float), new float[] { 20, 30, 40, 60, 90, 120 }, false);
            int row = 0;
            grid20[row, 0] = new SourceGrid.Cells.ColumnHeader("Входные параметры");
            grid20[row, 0].ColumnSpan = 4;
            row++;
            grid20[row, 0] = new SourceGrid.Cells.RowHeader("Подача");
            grid20[row, 1] = new SourceGrid.Cells.RowHeader("S");
            grid20[row, 2] = new SourceGrid.Cells.Cell();
            grid20[row, 3] = new SourceGrid.Cells.ColumnHeader("мм/об");
            grid20[row, 0].Column.Width = 150;
            row++;
            grid20[row, 0] = new SourceGrid.Cells.RowHeader("Глубина резания");
            grid20[row, 1] = new SourceGrid.Cells.RowHeader("t");
            grid20[row, 2] = new SourceGrid.Cells.Cell();
            grid20[row, 3] = new SourceGrid.Cells.ColumnHeader("мм");
            row++;
            grid20[row, 0] = new SourceGrid.Cells.RowHeader("Период стойкости резца");
            grid20[row, 1] = new SourceGrid.Cells.RowHeader("T");
            grid20[row, 2] = new SourceGrid.Cells.Cell();
            grid20[row, 2].AddController(CellChangedEvent);
            grid20[row, 3] = new SourceGrid.Cells.ColumnHeader("мин");

            grid20[row, 2].Editor = cb;
            grid20[row, 2].Editor.EditableMode = EditableMode.SingleClick;

            row++;
            grid20[row, 0] = new SourceGrid.Cells.RowHeader("Диаметр инструмента");
            grid20[row, 1] = new SourceGrid.Cells.RowHeader("D");
            grid20[row, 2] = new SourceGrid.Cells.Cell();
            grid20[row, 3] = new SourceGrid.Cells.ColumnHeader("мм");
            row++;

            grid20[row, 0] = new SourceGrid.Cells.RowHeader("Количество зубьев фрезы");
            grid20[row, 1] = new SourceGrid.Cells.RowHeader("z");
            grid20[row, 2] = new SourceGrid.Cells.Cell();
            grid20[row, 3] = new SourceGrid.Cells.ColumnHeader("шт");
            row++;

            grid20[row, 0] = new SourceGrid.Cells.RowHeader("Ширина фрезы");
            grid20[row, 1] = new SourceGrid.Cells.RowHeader("B");
            grid20[row, 2] = new SourceGrid.Cells.Cell();
            grid20[row, 3] = new SourceGrid.Cells.ColumnHeader("мм");
            row++;

            grid20[row, 0] = new SourceGrid.Cells.RowHeader("Поправка на обрабатываемый материал");
            grid20[row, 1] = new SourceGrid.Cells.RowHeader("Kv");
            grid20[row, 2] = new SourceGrid.Cells.Cell();
            grid20[row, 3] = new SourceGrid.Cells.ColumnHeader("б/р");
            row++;

            grid20[row, 0] = new SourceGrid.Cells.RowHeader("Поправка на обрабатываемый материал");
            grid20[row, 1] = new SourceGrid.Cells.RowHeader("Kp");
            grid20[row, 2] = new SourceGrid.Cells.Cell();
            grid20[row, 3] = new SourceGrid.Cells.ColumnHeader("б/р");
            row++;

            grid20[row, 0] = new SourceGrid.Cells.ColumnHeader("Эмпирические коэффициенты скорости резания");
            grid20[row, 0].ColumnSpan = 4;
            row++;

            grid20[row, 0] = new SourceGrid.Cells.ColumnHeader("Сv");
            grid20[row, 0].ColumnSpan = 2;
            grid20[row, 2] = new SourceGrid.Cells.Cell();
            grid20[row, 3] = new SourceGrid.Cells.ColumnHeader("б/р");
            row++;

            grid20[row, 0] = new SourceGrid.Cells.ColumnHeader("q");
            grid20[row, 0].ColumnSpan = 2;
            grid20[row, 2] = new SourceGrid.Cells.Cell();
            grid20[row, 3] = new SourceGrid.Cells.ColumnHeader("б/р");
            row++;

            grid20[row, 0] = new SourceGrid.Cells.ColumnHeader("x");
            grid20[row, 0].ColumnSpan = 2;
            grid20[row, 2] = new SourceGrid.Cells.Cell();
            grid20[row, 3] = new SourceGrid.Cells.ColumnHeader("б/р");
            row++;

            grid20[row, 0] = new SourceGrid.Cells.ColumnHeader("y");
            grid20[row, 0].ColumnSpan = 2;
            grid20[row, 2] = new SourceGrid.Cells.Cell();
            grid20[row, 3] = new SourceGrid.Cells.ColumnHeader("б/р");
            row++;

            grid20[row, 0] = new SourceGrid.Cells.ColumnHeader("u");
            grid20[row, 0].ColumnSpan = 2;
            grid20[row, 2] = new SourceGrid.Cells.Cell();
            grid20[row, 3] = new SourceGrid.Cells.ColumnHeader("б/р");
            row++;

            grid20[row, 0] = new SourceGrid.Cells.ColumnHeader("p");
            grid20[row, 0].ColumnSpan = 2;
            grid20[row, 2] = new SourceGrid.Cells.Cell();
            grid20[row, 3] = new SourceGrid.Cells.ColumnHeader("б/р");
            row++;

            grid20[row, 0] = new SourceGrid.Cells.ColumnHeader("m");
            grid20[row, 0].ColumnSpan = 2;
            grid20[row, 2] = new SourceGrid.Cells.Cell();
            grid20[row, 3] = new SourceGrid.Cells.ColumnHeader("б/р");
            row++;

            grid20[row, 0] = new SourceGrid.Cells.ColumnHeader("Эмпирические коэффициенты силы резания");
            grid20[row, 0].ColumnSpan = 4;
            row++;

            grid20[row, 0] = new SourceGrid.Cells.ColumnHeader("Ср");
            grid20[row, 0].ColumnSpan = 2;
            grid20[row, 2] = new SourceGrid.Cells.Cell();
            grid20[row, 3] = new SourceGrid.Cells.ColumnHeader("б/р");
            row++;

            grid20[row, 0] = new SourceGrid.Cells.ColumnHeader("q");
            grid20[row, 0].ColumnSpan = 2;
            grid20[row, 2] = new SourceGrid.Cells.Cell();
            grid20[row, 3] = new SourceGrid.Cells.ColumnHeader("б/р");
            row++;

            grid20[row, 0] = new SourceGrid.Cells.ColumnHeader("x");
            grid20[row, 0].ColumnSpan = 2;
            grid20[row, 2] = new SourceGrid.Cells.Cell();
            grid20[row, 3] = new SourceGrid.Cells.ColumnHeader("б/р");
            row++;

            grid20[row, 0] = new SourceGrid.Cells.ColumnHeader("y");
            grid20[row, 0].ColumnSpan = 2;
            grid20[row, 2] = new SourceGrid.Cells.Cell();
            grid20[row, 3] = new SourceGrid.Cells.ColumnHeader("б/р");
            row++;

            grid20[row, 0] = new SourceGrid.Cells.ColumnHeader("u");
            grid20[row, 0].ColumnSpan = 2;
            grid20[row, 2] = new SourceGrid.Cells.Cell();
            grid20[row, 3] = new SourceGrid.Cells.ColumnHeader("б/р");
            row++;

            grid20[row, 0] = new SourceGrid.Cells.ColumnHeader("w");
            grid20[row, 0].ColumnSpan = 2;
            grid20[row, 2] = new SourceGrid.Cells.Cell();
            grid20[row, 3] = new SourceGrid.Cells.ColumnHeader("б/р");

            // Добавляем возможность редактировать и указываем событие при изменении значения
            for (int r = 1; r < grid20.RowsCount; r++)
            {
                if (r != 3 && r != 9 && r!=17)
                {
                    grid20[r, 2].Editor = tb;
                    grid20[r, 2].AddController(CellChangedEvent);
                    grid20[r, 2].AddController(new MyCellTracking());//наведение
                    //grid20[r, 2].AddController(new MyHelpRowTracking());//help row pointer
                }
            }


            #endregion


            foreach (SourceGrid.GridColumn col in grid20.Columns)
                col.Width = 80;
            grid20.Columns[0].Width = 100;
            foreach (SourceGrid.GridRow r in grid20.Rows)
                r.Height = 25;
        }
        private void DoFullResultTab2_Milling()
        {
            #region Код таблицы
            grid21.BorderStyle = BorderStyle.FixedSingle;
            grid21.Redim(6, 4);
            int row = 0;
            grid21[row, 0] = new SourceGrid.Cells.ColumnHeader("Выходные параметры");
            grid21[row, 0].ColumnSpan = 4;

            row++;
            grid21[row, 0] = new SourceGrid.Cells.RowHeader("Скорость резания");
            grid21[row, 1] = new SourceGrid.Cells.RowHeader();

            grid21[row, 1] = new SourceGrid.Cells.Cell();
            //Properties.Resources.V2.SetResolution((float)(Properties.Resources.V2.HorizontalResolution * 0.3), (float)(Properties.Resources.V2.VerticalResolution * 0.3));
            grid21[row, 1].Image = Properties.Resources.V1;

            grid21[row, 2] = new SourceGrid.Cells.Cell();
            grid21[row, 3] = new SourceGrid.Cells.Cell("м/мин");
            row++;
            grid21[row, 0] = new SourceGrid.Cells.RowHeader("Сила резания");
            grid21[row, 1] = new SourceGrid.Cells.RowHeader();

            grid21[row, 1] = new SourceGrid.Cells.Cell();
            grid21[row, 1].Image = Properties.Resources.P1;

            grid21[row, 2] = new SourceGrid.Cells.Cell();
            grid21[row, 3] = new SourceGrid.Cells.Cell("Н");
            row++;
            grid21[row, 0] = new SourceGrid.Cells.RowHeader("Момент резания");
            grid21[row, 1] = new SourceGrid.Cells.RowHeader();

            grid21[row, 1] = new SourceGrid.Cells.Cell();
            Bitmap bm = new Bitmap(Properties.Resources.M1);
            bm.SetResolution(96.0F, 96.0F);
            grid21[row, 1].Image = bm;//Properties.Resources.M2;

            grid21[row, 2] = new SourceGrid.Cells.Cell();
            grid21[row, 3] = new SourceGrid.Cells.Cell("Нм");

            row++;
            grid21[row, 0] = new SourceGrid.Cells.RowHeader("Потребляемая мощность");
            grid21[row, 1] = new SourceGrid.Cells.RowHeader();

            grid21[row, 1] = new SourceGrid.Cells.Cell();
            grid21[row, 1].Image = Properties.Resources.N1;

            grid21[row, 2] = new SourceGrid.Cells.Cell();
            grid21[row, 3] = new SourceGrid.Cells.Cell("кВт");


            row++;
            grid21[row, 0] = new SourceGrid.Cells.RowHeader("Частота вращения шпинделя");
            grid21[row, 1] = new SourceGrid.Cells.RowHeader();

            grid21[row, 1] = new SourceGrid.Cells.Cell();
            grid21[row, 1].Image = Properties.Resources.n_2_1;

            grid21[row, 2] = new SourceGrid.Cells.Cell();
            grid21[row, 3] = new SourceGrid.Cells.Cell("об/мин");

            grid21.Columns[0].Width = 130;
            grid21.Columns[1].Width = 210;
            grid21.Columns[2].Width = 70;
            grid21.Columns[3].Width = 70;

            grid21.Rows[0].Height = 36;
            grid21.Rows[1].Height = 60;
            grid21.Rows[2].Height = 60;
            grid21.Rows[3].Height = 60;
            grid21.Rows[4].Height = 60;
            grid21.Rows[5].Height = 60;

            #endregion
        }
        private void DoFullGrid20_Milling()
        {
            grid20[1, 2].Value = ms.inputData.s;
            grid20[2, 2].Value = ms.inputData.t;
            grid20[3, 2].Value = ms.inputData.T;
            grid20[4, 2].Value = ms.inputData.D;
            grid20[5, 2].Value = ms.inputData.z;
            grid20[6, 2].Value = ms.inputData.B;
            grid20[7, 2].Value = ms.inputData.Kv;
            grid20[8, 2].Value = ms.inputData.Kp;

            grid20[10, 2].Value = ms.inputData.Cv;
            grid20[11, 2].Value = ms.inputData.qv;
            grid20[12, 2].Value = ms.inputData.xv;
            grid20[13, 2].Value = ms.inputData.yv;
            grid20[14, 2].Value = ms.inputData.uv;
            grid20[15, 2].Value = ms.inputData.pv;
            grid20[16, 2].Value = ms.inputData.mv;

            grid20[18, 2].Value = ms.inputData.Cp;
            grid20[19, 2].Value = ms.inputData.qp;
            grid20[20, 2].Value = ms.inputData.xp;
            grid20[21, 2].Value = ms.inputData.yp;
            grid20[22, 2].Value = ms.inputData.up;
            grid20[23, 2].Value = ms.inputData.wp;


        }
        private void DoFullGrid21_Milling()
        {
            grid21[1, 2].Value = ms.getV();
            grid21[2, 2].Value = ms.getP();
            grid21[3, 2].Value = ms.getM();
            grid21[4, 2].Value = ms.getN();
            grid21[5, 2].Value = ms.getn();
            //
        }

        #region Заполнение таблиц сверления
        private void DoFullTab1_Drill()
        {
            SQLreader sqlReader = new SQLreader("databaseD.sqlite");
            SQLiteDataReader sqlite_datareader = sqlReader.getReader("drill_table1");
            #region Код таблицы 1
            grid9.BorderStyle = BorderStyle.FixedSingle;
            grid9.Redim(10, 8);
            grid9.Rows.Insert(0);
            SourceGrid.Cells.Views.Cell viewImage = new SourceGrid.Cells.Views.Cell();
            grid9[0, 0] = new SourceGrid.Cells.ColumnHeader("Сверление");
            grid9[0, 0].ColumnSpan = 8;
            grid9[0, 0].Column.Width = 80;
            grid9[1, 0] = new SourceGrid.Cells.Cell("t=0.5D");
            grid9[1, 0].ColumnSpan = 8;
            grid9[2, 0] = new SourceGrid.Cells.ColumnHeader("Рассверливание");
            grid9[2, 0].ColumnSpan = 8;
            grid9[3, 0] = new SourceGrid.Cells.RowHeader("Предварительное");
            grid9[3, 0].ColumnSpan = 2;
            grid9[4, 0] = new SourceGrid.Cells.RowHeader("Окончательное");
            grid9[4, 0].ColumnSpan = 2;

            for (int r = 3; r < 5; r++)
            {
                if (sqlite_datareader.Read())
                {
                    grid9[r, 2] = new SourceGrid.Cells.ColumnHeader(Convert.ToString(sqlite_datareader.GetString(0)));
                    grid9[r, 2].ColumnSpan = 3;
                    grid9[r, 5] = new SourceGrid.Cells.Cell(Convert.ToString(sqlite_datareader.GetString(1)));
                    grid9[r, 5].ColumnSpan = 3;
                }
            }
            grid9[1, 0].AddController(cellpointer);//наведение
            grid9[1, 0].AddController(clickEvent);//клик мыши
            //Editor.EnableEdit = false;
            grid9[1, 0].AddController(new SourceGrid.Cells.Controllers.Unselectable());
            grid9[1, 0].AddController(new MyHelpRowTracking());//help row pointer

            grid9[3, 5].AddController(cellpointer);//наведение
            grid9[3, 5].AddController(clickEvent);//клик мыши
            //Editor.EnableEdit = false;
            grid9[3, 5].AddController(new SourceGrid.Cells.Controllers.Unselectable());
            grid9[3, 5].AddController(new MyHelpRowTracking());//help row pointer

            grid9[4, 5].AddController(cellpointer);//наведение
            grid9[4, 5].AddController(clickEvent);//клик мыши
            //Editor.EnableEdit = false;
            grid9[4, 5].AddController(new SourceGrid.Cells.Controllers.Unselectable());
            grid9[4, 5].AddController(new MyHelpRowTracking());//help row pointer
            #endregion
            sqlite_datareader = sqlReader.getReader("drill_table2");
            #region Код таблицы 2
            grid9[5, 0] = new SourceGrid.Cells.ColumnHeader("Зенкерование");
            grid9[5, 0].ColumnSpan = 8;
            grid9[6, 0] = new SourceGrid.Cells.ColumnHeader("D, мм");
            grid9[7, 0] = new SourceGrid.Cells.ColumnHeader("t, мм");

            grid9[6, 1] = new SourceGrid.Cells.ColumnHeader("<20");
            grid9[6, 2] = new SourceGrid.Cells.ColumnHeader(">20-35");
            grid9[6, 3] = new SourceGrid.Cells.ColumnHeader(">35-45");
            grid9[6, 4] = new SourceGrid.Cells.ColumnHeader(">45-50");
            grid9[6, 5] = new SourceGrid.Cells.ColumnHeader(">50-60");
            grid9[6, 6] = new SourceGrid.Cells.ColumnHeader(">60-70");
            grid9[6, 7] = new SourceGrid.Cells.ColumnHeader(">70-80");
            for (int r = 7; r < 8; r++)
            {
                if (sqlite_datareader.Read())
                {
                    grid9[r, 1] = new SourceGrid.Cells.Cell(Convert.ToString(sqlite_datareader.GetString(0)));
                    grid9[r, 2] = new SourceGrid.Cells.Cell(Convert.ToString(sqlite_datareader.GetString(1)));
                    grid9[r, 3] = new SourceGrid.Cells.Cell(Convert.ToString(sqlite_datareader.GetString(2)));
                    grid9[r, 4] = new SourceGrid.Cells.Cell(Convert.ToString(sqlite_datareader.GetString(3)));
                    grid9[r, 5] = new SourceGrid.Cells.Cell(Convert.ToString(sqlite_datareader.GetString(4)));
                    grid9[r, 6] = new SourceGrid.Cells.Cell(Convert.ToString(sqlite_datareader.GetString(5)));
                    grid9[r, 7] = new SourceGrid.Cells.Cell(Convert.ToString(sqlite_datareader.GetString(6)));

                }
            }
            //
            #endregion
            sqlite_datareader = sqlReader.getReader("drill_table3");
            #region Код таблицы 3
            grid9[8, 0] = new SourceGrid.Cells.ColumnHeader("Развертывание");
            grid9[8, 0].ColumnSpan = 8;
            grid9[9, 0] = new SourceGrid.Cells.ColumnHeader("D, мм");
            grid9[10, 0] = new SourceGrid.Cells.ColumnHeader("t, мм");

            grid9[9, 1] = new SourceGrid.Cells.ColumnHeader("<5");
            grid9[9, 2] = new SourceGrid.Cells.ColumnHeader(">5-10");
            grid9[9, 3] = new SourceGrid.Cells.ColumnHeader(">10-15");
            grid9[9, 4] = new SourceGrid.Cells.ColumnHeader(">15-30");
            grid9[9, 5] = new SourceGrid.Cells.ColumnHeader(">30-50");
            grid9[9, 6] = new SourceGrid.Cells.ColumnHeader(">50-60");
            grid9[9, 7] = new SourceGrid.Cells.ColumnHeader(">60-80");
            {
                int r = 10;
                if (sqlite_datareader.Read())
                {
                    grid9[r, 1] = new SourceGrid.Cells.Cell(Convert.ToString(sqlite_datareader.GetString(0)));
                    grid9[r, 2] = new SourceGrid.Cells.Cell(Convert.ToString(sqlite_datareader.GetString(1)));
                    grid9[r, 3] = new SourceGrid.Cells.Cell(Convert.ToString(sqlite_datareader.GetString(2)));
                    grid9[r, 4] = new SourceGrid.Cells.Cell(Convert.ToString(sqlite_datareader.GetString(3)));
                    grid9[r, 5] = new SourceGrid.Cells.Cell(Convert.ToString(sqlite_datareader.GetString(4)));
                    grid9[r, 6] = new SourceGrid.Cells.Cell(Convert.ToString(sqlite_datareader.GetString(5)));
                    grid9[r, 7] = new SourceGrid.Cells.Cell(Convert.ToString(sqlite_datareader.GetString(6)));
                }
            }

            for (int r = 7; r < 11; r = r + 3)
            {
                for (int c = 1; c < 8; c++)
                {
                    grid9[r, c].AddController(cellpointer);//наведение
                    grid9[r, c].AddController(clickEvent);//клик мыши
                    //Editor.EnableEdit = false;
                    grid9[r, c].AddController(new SourceGrid.Cells.Controllers.Unselectable());
                    grid9[r, c].AddController(new MyHelpRowTracking());//help row pointer
                }
            }
            #endregion


            foreach (SourceGrid.GridColumn col in grid9.Columns)
                col.Width = 100;
            grid9.Columns[0].Width = 150;
            foreach (SourceGrid.GridRow r in grid9.Rows)
                r.Height = 25;
        }
        private void DoFullTab2_Drill()
        {

            SQLreader sqlReader = new SQLreader("databaseD.sqlite");
            SQLiteDataReader sqlite_datareader = sqlReader.getReader("drill_table4");
            #region Код таблицы
            grid10.BorderStyle = BorderStyle.FixedSingle;
            grid10.Redim(19, 5);
            SourceGrid.Cells.Views.Cell viewImage = new SourceGrid.Cells.Views.Cell();
            grid10[0, 0] = new SourceGrid.Cells.ColumnHeader("Сверление и рассверливание");
            grid10[0, 0].ColumnSpan = 5;
            grid10[0, 0].Column.Width = 80;
            grid10[1, 0] = new SourceGrid.Cells.ColumnHeader("D, мм");
            grid10[1, 0].RowSpan = 3;
            grid10[1, 1] = new SourceGrid.Cells.ColumnHeader("Сверление");
            grid10[1, 1].ColumnSpan = 2;
            grid10[1, 3] = new SourceGrid.Cells.ColumnHeader("Рассверливание");
            grid10[1, 3].ColumnSpan = 2;
            grid10[2, 1] = new SourceGrid.Cells.ColumnHeader("Сталь");
            grid10[2, 2] = new SourceGrid.Cells.ColumnHeader("Серый\nчугун");
            grid10[2, 2].Row.Height = 30;
            grid10[2, 3] = new SourceGrid.Cells.ColumnHeader("Сталь");
            grid10[2, 4] = new SourceGrid.Cells.ColumnHeader("Серый\nчугун");
            grid10[3, 1] = new SourceGrid.Cells.ColumnHeader("S, мм/об");
            grid10[3, 1].ColumnSpan = 4;

            for (int r = 4; r < 9; r++)
            {
                if (sqlite_datareader.Read())
                {
                    grid10[r, 0] = new SourceGrid.Cells.ColumnHeader(Convert.ToString(sqlite_datareader.GetString(0)));
                    grid10[r, 1] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(1)));
                    grid10[r, 2] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(2)));
                    grid10[r, 3] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(3)));
                    grid10[r, 4] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(4)));

                }
                for (int c = 1; c < 5; c++)
                {
                    grid10[r, c].AddController(cellpointer);//наведение
                    grid10[r, c].AddController(clickEvent);//клик мыши
                    //Editor.EnableEdit = false;
                    grid10[r, c].AddController(new SourceGrid.Cells.Controllers.Unselectable());
                    grid10[r, c].AddController(new MyHelpRowTracking());//help row pointer
                }
            }

            #endregion
            sqlite_datareader = sqlReader.getReader("drill_table5");
            #region Код таблицы
            grid10[9, 0] = new SourceGrid.Cells.ColumnHeader("Зенкерование и развертывание");
            grid10[9, 0].ColumnSpan = 5;
            grid10[10, 0] = new SourceGrid.Cells.ColumnHeader("Обрабатываемый материал");
            grid10[10, 0].RowSpan = 3;
            grid10[10, 1] = new SourceGrid.Cells.ColumnHeader("D, мм");
            grid10[10, 1].ColumnSpan = 4;
            grid10[11, 1] = new SourceGrid.Cells.ColumnHeader("<15");
            grid10[11, 2] = new SourceGrid.Cells.ColumnHeader(">15-25");
            grid10[11, 3] = new SourceGrid.Cells.ColumnHeader(">25-35");
            grid10[11, 4] = new SourceGrid.Cells.ColumnHeader(">35-50");
            grid10[12, 1] = new SourceGrid.Cells.ColumnHeader("S, мм/об");
            grid10[12, 1].ColumnSpan = 4;
            grid10[13, 0] = new SourceGrid.Cells.ColumnHeader("Зенкерование");
            grid10[13, 0].ColumnSpan = 5;
            grid10[14, 0] = new SourceGrid.Cells.ColumnHeader("Сталь");
            grid10[15, 0] = new SourceGrid.Cells.ColumnHeader("Серый чугун");
            grid10[17, 0] = new SourceGrid.Cells.ColumnHeader("Сталь");
            grid10[18, 0] = new SourceGrid.Cells.ColumnHeader("Серый чугун");


            for (int r = 14; r < 19; r++)
            {
                if (r == 16)
                {
                    grid10[r, 0] = new SourceGrid.Cells.ColumnHeader("Развертывание");
                    grid10[r, 0].ColumnSpan = 5;
                }
                else
                {
                    if (sqlite_datareader.Read())
                    {
                        grid10[r, 1] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(0)));
                        grid10[r, 2] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(1)));
                        grid10[r, 3] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(2)));
                        grid10[r, 4] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(3)));

                    }
                    for (int c = 1; c < 5; c++)
                    {
                        grid10[r, c].AddController(cellpointer);//наведение
                        grid10[r, c].AddController(clickEvent);//клик мыши
                        //Editor.EnableEdit = false;
                        grid10[r, c].AddController(new SourceGrid.Cells.Controllers.Unselectable());
                        grid10[r, c].AddController(new MyHelpRowTracking());//help row pointer
                    }
                }

            }



            #endregion


            foreach (SourceGrid.GridColumn col in grid10.Columns)
                col.Width = 100;
            grid10.Columns[0].Width = 150;
            foreach (SourceGrid.GridRow r in grid10.Rows)
                r.Height = 25;
        }
        private void DoFullTab3_Drill()
        {
            SQLreader sqlReader = new SQLreader("databaseD.sqlite");
            SQLiteDataReader sqlite_datareader = sqlReader.getReader("drill_table6");
            #region Код таблицы
            grid11.BorderStyle = BorderStyle.FixedSingle;
            grid11.Redim(3, 2);
            SourceGrid.Cells.Views.Cell viewImage = new SourceGrid.Cells.Views.Cell();
            grid11[0, 0] = new SourceGrid.Cells.ColumnHeader("Обрабатываемый материал");
            grid11[0, 0].Column.Width = 200;
            grid11[0, 1] = new SourceGrid.Cells.ColumnHeader("Kмv");
            grid11[1, 0] = new SourceGrid.Cells.RowHeader("Сталь");
            grid11[2, 0] = new SourceGrid.Cells.RowHeader("Серый чугун");

            for (int r = 1; r < 3; r++)
            {
                if (sqlite_datareader.Read())
                {
                    grid11[r, 1] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(0)));
                }
                {
                    int c = 1;
                    grid11[r, c].AddController(cellpointer);//наведение
                    grid11[r, c].AddController(clickEvent);//клик мыши
                    //Editor.EnableEdit = false;
                    grid11[r, c].AddController(new SourceGrid.Cells.Controllers.Unselectable());
                    grid11[r, c].AddController(new MyHelpRowTracking());//help row pointer
                }
            }

            #endregion


            foreach (SourceGrid.GridColumn col in grid11.Columns)
                col.Width = 100;
            grid11.Columns[0].Width = 150;
            foreach (SourceGrid.GridRow r in grid11.Rows)
                r.Height = 25;
        }
        private void DoFullTab4_Drill()
        {
            SQLreader sqlReader = new SQLreader("databaseD.sqlite");
            SQLiteDataReader sqlite_datareader = sqlReader.getReader("drill_table7");
            #region Код таблицы
            grid12.BorderStyle = BorderStyle.FixedSingle;
            grid12.Redim(3, 4);
            SourceGrid.Cells.Views.Cell viewImage = new SourceGrid.Cells.Views.Cell();
            grid12[0, 0] = new SourceGrid.Cells.ColumnHeader("Заготовка не обработанная");
            grid12[0, 0].ColumnSpan = 3;
            grid12[0, 0].Column.Width = 100;
            grid12[0, 3] = new SourceGrid.Cells.ColumnHeader("Полуфабрикаты \n обработанные");
            grid12[0, 3].Column.Width = 100;
            grid12[0, 3].RowSpan = 2;
            grid12[1, 0] = new SourceGrid.Cells.ColumnHeader("Поковка");
            grid12[1, 1] = new SourceGrid.Cells.ColumnHeader("Отливка");
            grid12[1, 1].Column.Width = 80;
            grid12[1, 2] = new SourceGrid.Cells.ColumnHeader("Прокат");

            {
                int r = 2;
                if (sqlite_datareader.Read())
                {
                    grid12[r, 0] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(0)));
                    grid12[r, 1] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(1)));
                    grid12[r, 2] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(2)));
                    grid12[r, 3] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(3)));
                }
                for (int c = 0; c < 4; c++)
                {
                    grid12[r, c].AddController(cellpointer);//наведение
                    grid12[r, c].AddController(clickEvent);//клик мыши
                    //Editor.EnableEdit = false;
                    grid12[r, c].AddController(new SourceGrid.Cells.Controllers.Unselectable());
                    grid12[r, c].AddController(new MyHelpRowTracking());//help row pointer
                }
            }

            #endregion


            foreach (SourceGrid.GridColumn col in grid12.Columns)
                col.Width = 100;
            grid12.Columns[0].Width = 150;
            foreach (SourceGrid.GridRow r in grid12.Rows)
                r.Height = 25;
        }
        private void DoFullTab5_Drill()
        {
            SQLreader sqlReader = new SQLreader("databaseD.sqlite");
            SQLiteDataReader sqlite_datareader = sqlReader.getReader("drill_table8");
            #region Код таблицы
            grid13.BorderStyle = BorderStyle.FixedSingle;
            grid13.Redim(2, 6);
            SourceGrid.Cells.Views.Cell viewImage = new SourceGrid.Cells.Views.Cell();
            grid13[0, 0] = new SourceGrid.Cells.ColumnHeader("L/D");
            grid13[0, 1] = new SourceGrid.Cells.ColumnHeader("<30");
            grid13[0, 2] = new SourceGrid.Cells.ColumnHeader(">30-40");
            grid13[0, 3] = new SourceGrid.Cells.ColumnHeader(">40-50");
            grid13[0, 4] = new SourceGrid.Cells.ColumnHeader(">50-60");
            grid13[0, 5] = new SourceGrid.Cells.ColumnHeader(">60-80");
            grid13[1, 0] = new SourceGrid.Cells.ColumnHeader("Кг");


            {
                int r = 1;
                if (sqlite_datareader.Read())
                {
                    for (int c = 0; c < 5; c++)
                    {
                        grid13[r, c + 1] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(c)));
                        grid13[r, c + 1].AddController(cellpointer);//наведение
                        grid13[r, c + 1].AddController(clickEvent);//клик мыши
                        //Editor.EnableEdit = false;
                        grid13[r, c + 1].AddController(new SourceGrid.Cells.Controllers.Unselectable());
                        grid13[r, c + 1].AddController(new MyHelpRowTracking());//help row pointer
                    }
                }
            }

            #endregion


            foreach (SourceGrid.GridColumn col in grid13.Columns)
                col.Width = 100;
            grid13.Columns[0].Width = 150;
            foreach (SourceGrid.GridRow r in grid13.Rows)
                r.Height = 25;
        }
        private void DoFullTab6_Drill()
        {
            SQLreader sqlReader = new SQLreader("databaseD.sqlite");
            SQLiteDataReader sqlite_datareader = sqlReader.getReader("drill_table9");
            #region Код таблицы
            grid14.BorderStyle = BorderStyle.FixedSingle;
            grid14.Redim(22, 8);
            SourceGrid.Cells.Views.Cell viewImage = new SourceGrid.Cells.Views.Cell();
            grid14[0, 0] = new SourceGrid.Cells.ColumnHeader("Обрабатываемый\nматериал");
            grid14[0, 0].RowSpan = 2;
            grid14[0, 0].Column.Width = 100;
            grid14[0, 1] = new SourceGrid.Cells.ColumnHeader("Инструментальный\nматериал");
            grid14[0, 1].RowSpan = 2;
            grid14[0, 1].Column.Width = 140;
            grid14[0, 2] = new SourceGrid.Cells.ColumnHeader("S, мм/об");
            grid14[0, 2].RowSpan = 2;
            grid14[0, 2].Column.Width = 60;
            grid14[0, 3] = new SourceGrid.Cells.ColumnHeader("Cv");
            grid14[0, 4] = new SourceGrid.Cells.ColumnHeader("q");
            grid14[0, 5] = new SourceGrid.Cells.ColumnHeader("x");
            grid14[0, 6] = new SourceGrid.Cells.ColumnHeader("y");
            grid14[0, 7] = new SourceGrid.Cells.ColumnHeader("m");
            grid14[1, 3] = new SourceGrid.Cells.ColumnHeader("Сверление");
            grid14[1, 3].ColumnSpan = 5;
            grid14[2, 0] = new SourceGrid.Cells.RowHeader("Сталь");
            grid14[2, 0].RowSpan = 2;
            grid14[2, 1] = new SourceGrid.Cells.RowHeader("Быстрорежущая\nсталь");
            grid14[2, 1].RowSpan = 4;
            grid14[4, 0] = new SourceGrid.Cells.RowHeader("Серый чугун");
            grid14[4, 0].RowSpan = 3;
            grid14[6, 1] = new SourceGrid.Cells.RowHeader("Твердый\nсплав");

            for (int r = 2; r < 7; r++)
            {

                if (sqlite_datareader.Read())
                {
                    grid14[r, 2] = new SourceGrid.Cells.Cell(Convert.ToString(sqlite_datareader.GetString(2)));
                    grid14[r, 3] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(3)));
                    grid14[r, 4] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(4)));
                    grid14[r, 5] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(5)));
                    grid14[r, 6] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(6)));
                    grid14[r, 7] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(7)));

                    for (int c = 2; c < 8; c++)
                    {
                        grid14[r, c].AddController(rowpointer);//наведение
                        grid14[r, c].AddController(clickEvent);//клик мыши
                        //Editor.EnableEdit = false;
                        grid14[r, c].AddController(new SourceGrid.Cells.Controllers.Unselectable());
                        grid14[r, c].AddController(new MyHelpRowTracking());//help row pointer
                    }
                }
            }
            grid14[7, 0] = new SourceGrid.Cells.ColumnHeader("Рассверливание");
            grid14[7, 0].ColumnSpan = 8;
            grid14[8, 0] = new SourceGrid.Cells.RowHeader("Сталь");
            grid14[8, 0].RowSpan = 2;
            grid14[10, 0] = new SourceGrid.Cells.RowHeader("Серый чугун");
            grid14[10, 0].RowSpan = 2;


            for (int r = 8; r < 12; r++)
            {

                if (sqlite_datareader.Read())
                {
                    grid14[r, 1] = new SourceGrid.Cells.RowHeader(Convert.ToString(sqlite_datareader.GetString(1)));
                    grid14[r, 2] = new SourceGrid.Cells.Cell(Convert.ToString(sqlite_datareader.GetString(2)));
                    grid14[r, 3] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(3)));
                    grid14[r, 4] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(4)));
                    grid14[r, 5] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(5)));
                    grid14[r, 6] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(6)));
                    grid14[r, 7] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(7)));

                    for (int c = 2; c < 8; c++)
                    {
                        grid14[r, c].AddController(rowpointer);//наведение
                        grid14[r, c].AddController(clickEvent);//клик мыши
                        //Editor.EnableEdit = false;
                        grid14[r, c].AddController(new SourceGrid.Cells.Controllers.Unselectable());
                        grid14[r, c].AddController(new MyHelpRowTracking());//help row pointer
                    }
                }
            }
            grid14[12, 0] = new SourceGrid.Cells.ColumnHeader("Зенкерование");
            grid14[12, 0].ColumnSpan = 8;
            grid14[13, 0] = new SourceGrid.Cells.RowHeader("Сталь");
            grid14[13, 0].RowSpan = 2;
            grid14[15, 0] = new SourceGrid.Cells.RowHeader("Серый чугун");
            grid14[15, 0].RowSpan = 2;


            for (int r = 13; r < 17; r++)
            {

                if (sqlite_datareader.Read())
                {
                    grid14[r, 1] = new SourceGrid.Cells.RowHeader(Convert.ToString(sqlite_datareader.GetString(1)));
                    grid14[r, 2] = new SourceGrid.Cells.Cell(Convert.ToString(sqlite_datareader.GetString(2)));
                    grid14[r, 3] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(3)));
                    grid14[r, 4] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(4)));
                    grid14[r, 5] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(5)));
                    grid14[r, 6] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(6)));
                    grid14[r, 7] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(7)));

                    for (int c = 2; c < 8; c++)
                    {
                        grid14[r, c].AddController(rowpointer);//наведение
                        grid14[r, c].AddController(clickEvent);//клик мыши
                        //Editor.EnableEdit = false;
                        grid14[r, c].AddController(new SourceGrid.Cells.Controllers.Unselectable());
                        grid14[r, c].AddController(new MyHelpRowTracking());//help row pointer
                    }
                }
            }
            grid14[17, 0] = new SourceGrid.Cells.ColumnHeader("Развертывание");
            grid14[17, 0].ColumnSpan = 8;
            grid14[18, 0] = new SourceGrid.Cells.RowHeader("Сталь");
            grid14[18, 0].RowSpan = 2;
            grid14[20, 0] = new SourceGrid.Cells.RowHeader("Серый чугун");
            grid14[20, 0].RowSpan = 2;


            for (int r = 18; r < 22; r++)
            {

                if (sqlite_datareader.Read())
                {
                    grid14[r, 1] = new SourceGrid.Cells.RowHeader(Convert.ToString(sqlite_datareader.GetString(1)));
                    grid14[r, 2] = new SourceGrid.Cells.Cell(Convert.ToString(sqlite_datareader.GetString(2)));
                    grid14[r, 3] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(3)));
                    grid14[r, 4] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(4)));
                    grid14[r, 5] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(5)));
                    grid14[r, 6] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(6)));
                    grid14[r, 7] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(7)));

                    for (int c = 2; c < 8; c++)
                    {
                        grid14[r, c].AddController(rowpointer);//наведение
                        grid14[r, c].AddController(clickEvent);//клик мыши
                        //Editor.EnableEdit = false;
                        grid14[r, c].AddController(new SourceGrid.Cells.Controllers.Unselectable());
                        grid14[r, c].AddController(new MyHelpRowTracking());//help row pointer
                    }
                }
            }

            #endregion


            foreach (SourceGrid.GridColumn col in grid14.Columns)
                col.Width = 80;
            grid14.Columns[0].Width = 100;
            foreach (SourceGrid.GridRow r in grid14.Rows)
                r.Height = 25;
        }
        private void DoFullTab7_Drill()
        {
            SQLreader sqlReader = new SQLreader("databaseD.sqlite");
            SQLiteDataReader sqlite_datareader = sqlReader.getReader("drill_table10");
            #region Код таблицы
            grid15.BorderStyle = BorderStyle.FixedSingle;
            grid15.Redim(10, 11);
            SourceGrid.Cells.Views.Cell viewImage = new SourceGrid.Cells.Views.Cell();
            grid15[0, 0] = new SourceGrid.Cells.ColumnHeader("Обрабатываемый\nматериал");
            grid15[0, 0].RowSpan = 4;
            grid15[0, 0].Column.Width = 100;
            grid15[0, 1] = new SourceGrid.Cells.ColumnHeader("Вид\nобработки");
            grid15[0, 1].RowSpan = 4;
            grid15[0, 1].Column.Width = 100;
            grid15[0, 2] = new SourceGrid.Cells.ColumnHeader("Инструментальный\nматериал");
            grid15[0, 2].RowSpan = 4;
            grid15[0, 2].Column.Width = 100;
            grid15[0, 3] = new SourceGrid.Cells.ColumnHeader("Расчетный параметр режима резания");
            grid15[0, 3].ColumnSpan = 8;
            grid15[1, 3] = new SourceGrid.Cells.ColumnHeader("Mкр");
            grid15[1, 3].ColumnSpan = 4;
            grid15[1, 7] = new SourceGrid.Cells.ColumnHeader("Po");
            grid15[1, 7].ColumnSpan = 4;
            grid15[2, 3] = new SourceGrid.Cells.ColumnHeader("Эмпирические константы");
            grid15[2, 3].ColumnSpan = 8;
            grid15[3, 3] = new SourceGrid.Cells.ColumnHeader("Cм");
            grid15[3, 4] = new SourceGrid.Cells.ColumnHeader("q");
            grid15[3, 5] = new SourceGrid.Cells.ColumnHeader("x");
            grid15[3, 6] = new SourceGrid.Cells.ColumnHeader("y");
            grid15[3, 7] = new SourceGrid.Cells.ColumnHeader("Co");
            grid15[3, 8] = new SourceGrid.Cells.ColumnHeader("q");
            grid15[3, 9] = new SourceGrid.Cells.ColumnHeader("x");
            grid15[3, 10] = new SourceGrid.Cells.ColumnHeader("y");
            grid15[4, 0] = new SourceGrid.Cells.RowHeader("Сталь");
            grid15[4, 0].RowSpan = 2;
            grid15[4, 1] = new SourceGrid.Cells.RowHeader("Сверление");
            grid15[5, 1] = new SourceGrid.Cells.RowHeader("Рассверливание\nзенкерование\nразвертывание");
            grid15[5, 1].Row.Height = 60;
            grid15[4, 2] = new SourceGrid.Cells.RowHeader("Быстрорежущая сталь");
            grid15[4, 2].RowSpan = 2;
            grid15[6, 0] = new SourceGrid.Cells.RowHeader("Серый чугун");
            grid15[6, 0].RowSpan = 4;
            grid15[6, 1] = new SourceGrid.Cells.RowHeader("Сверление");
            grid15[7, 1] = new SourceGrid.Cells.RowHeader("Рассверливание\nзенкерование\nразвертывание");
            grid15[7, 1].Row.Height = 60;
            grid15[6, 2] = new SourceGrid.Cells.RowHeader("Твердый сплав");
            grid15[6, 2].RowSpan = 2;
            grid15[8, 1] = new SourceGrid.Cells.RowHeader("Сверление");
            grid15[9, 1] = new SourceGrid.Cells.RowHeader("Рассверливание\nзенкерование\nразвертывание");
            grid15[9, 1].Row.Height = 60;
            grid15[8, 2] = new SourceGrid.Cells.RowHeader("Быстрорежущая сталь");
            grid15[8, 2].RowSpan = 2;


            for (int r = 4; r < 10; r++)
            {

                if (sqlite_datareader.Read())
                {
                    for (int c = 3; c < 11; c++)
                    {
                        try
                        {
                            grid15[r, c] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(c)));
                        }
                        catch (Exception)
                        {
                            grid15[r, c] = new SourceGrid.Cells.Cell("-");
                        }
                        grid15[r, c].AddController(rowpointer);//наведение
                        grid15[r, c].AddController(clickEvent);//клик мыши
                        //Editor.EnableEdit = false;
                        grid15[r, c].AddController(new SourceGrid.Cells.Controllers.Unselectable());
                        grid15[r, c].AddController(new MyHelpRowTracking());//help row pointer
                    }
                }
            }

            #endregion


            foreach (SourceGrid.GridColumn col in grid15.Columns)
                col.Width = 80;
            grid15.Columns[0].Width = 100;
            foreach (SourceGrid.GridRow r in grid15.Rows)
                r.Height = 25;
        }
        private void DoFullRusultTab1_Drill()
        {
            #region Код таблицы
            grid16.BorderStyle = BorderStyle.FixedSingle;
            grid16.Redim(25, 4);
            SourceGrid.Cells.Views.Cell viewImage = new SourceGrid.Cells.Views.Cell();
            SourceGrid.Cells.Editors.TextBox tb = new SourceGrid.Cells.Editors.TextBox(typeof(float));
            SourceGrid.Cells.Editors.ComboBox cb = new SourceGrid.Cells.Editors.ComboBox(typeof(float), new float[] { 20, 30, 40, 60, 90, 120 }, false);

            grid16[0, 0] = new SourceGrid.Cells.ColumnHeader("Входные параметры");
            grid16[0, 0].ColumnSpan = 4;

            grid16[1, 0] = new SourceGrid.Cells.RowHeader("Подача");
            grid16[1, 1] = new SourceGrid.Cells.RowHeader("S");
            grid16[1, 2] = new SourceGrid.Cells.Cell();
            grid16[1, 3] = new SourceGrid.Cells.ColumnHeader("мм/об");
            grid16[1, 0].Column.Width = 150;

            grid16[2, 0] = new SourceGrid.Cells.RowHeader("Глубина резания");
            grid16[2, 1] = new SourceGrid.Cells.RowHeader("t");
            grid16[2, 2] = new SourceGrid.Cells.Cell();
            grid16[2, 3] = new SourceGrid.Cells.ColumnHeader("мм");

            grid16[3, 0] = new SourceGrid.Cells.RowHeader("Период стойкости резца");
            grid16[3, 1] = new SourceGrid.Cells.RowHeader("T");
            grid16[3, 2] = new SourceGrid.Cells.Cell();
            grid16[3, 2].AddController(CellChangedEvent);
            grid16[3, 3] = new SourceGrid.Cells.ColumnHeader("мин");

            grid16[3, 2].Editor = cb;
            grid16[3, 2].Editor.EditableMode = EditableMode.SingleClick;


            grid16[4, 0] = new SourceGrid.Cells.RowHeader("Диаметр инструмента");
            grid16[4, 1] = new SourceGrid.Cells.RowHeader("D");
            grid16[4, 2] = new SourceGrid.Cells.Cell();
            grid16[4, 3] = new SourceGrid.Cells.ColumnHeader("мм");

            grid16[5, 0] = new SourceGrid.Cells.RowHeader("Диаметр исходного отверсития");
            grid16[5, 1] = new SourceGrid.Cells.RowHeader("d");
            grid16[5, 2] = new SourceGrid.Cells.Cell();
            grid16[5, 3] = new SourceGrid.Cells.ColumnHeader("мм");

            grid16[6, 0] = new SourceGrid.Cells.RowHeader("Поправка на обрабатываемый материал");
            grid16[6, 1] = new SourceGrid.Cells.RowHeader("Kмv");
            grid16[6, 2] = new SourceGrid.Cells.Cell();
            grid16[6, 3] = new SourceGrid.Cells.ColumnHeader("б/р");

            grid16[7, 0] = new SourceGrid.Cells.RowHeader("Поправка на состояние поверхности");
            grid16[7, 1] = new SourceGrid.Cells.RowHeader("Kпv");
            grid16[7, 2] = new SourceGrid.Cells.Cell();
            grid16[7, 3] = new SourceGrid.Cells.ColumnHeader("б/р");

            grid16[8, 0] = new SourceGrid.Cells.RowHeader("Поправка на глубину отверстия");
            grid16[8, 1] = new SourceGrid.Cells.RowHeader("Kг");
            grid16[8, 2] = new SourceGrid.Cells.Cell();
            grid16[8, 3] = new SourceGrid.Cells.ColumnHeader("б/р");

            grid16[9, 0] = new SourceGrid.Cells.ColumnHeader("Эмпирические коэффициенты скорости резания");
            grid16[9, 0].ColumnSpan = 4;

            grid16[10, 0] = new SourceGrid.Cells.ColumnHeader("Сv");
            grid16[10, 0].ColumnSpan = 2;
            grid16[10, 2] = new SourceGrid.Cells.Cell();
            grid16[10, 3] = new SourceGrid.Cells.ColumnHeader("б/р");

            grid16[11, 0] = new SourceGrid.Cells.ColumnHeader("q");
            grid16[11, 0].ColumnSpan = 2;
            grid16[11, 2] = new SourceGrid.Cells.Cell();
            grid16[11, 3] = new SourceGrid.Cells.ColumnHeader("б/р");

            grid16[12, 0] = new SourceGrid.Cells.ColumnHeader("x");
            grid16[12, 0].ColumnSpan = 2;
            grid16[12, 2] = new SourceGrid.Cells.Cell();
            grid16[12, 3] = new SourceGrid.Cells.ColumnHeader("б/р");

            grid16[13, 0] = new SourceGrid.Cells.ColumnHeader("y");
            grid16[13, 0].ColumnSpan = 2;
            grid16[13, 2] = new SourceGrid.Cells.Cell();
            grid16[13, 3] = new SourceGrid.Cells.ColumnHeader("б/р");

            grid16[14, 0] = new SourceGrid.Cells.ColumnHeader("m");
            grid16[14, 0].ColumnSpan = 2;
            grid16[14, 2] = new SourceGrid.Cells.Cell();
            grid16[14, 3] = new SourceGrid.Cells.ColumnHeader("б/р");

            grid16[15, 0] = new SourceGrid.Cells.ColumnHeader("Эмпирические коэффициенты момента резания");
            grid16[15, 0].ColumnSpan = 4;

            grid16[16, 0] = new SourceGrid.Cells.ColumnHeader("См");
            grid16[16, 0].ColumnSpan = 2;
            grid16[16, 2] = new SourceGrid.Cells.Cell();
            grid16[16, 3] = new SourceGrid.Cells.ColumnHeader("б/р");

            grid16[17, 0] = new SourceGrid.Cells.ColumnHeader("q");
            grid16[17, 0].ColumnSpan = 2;
            grid16[17, 2] = new SourceGrid.Cells.Cell();
            grid16[17, 3] = new SourceGrid.Cells.ColumnHeader("б/р");

            grid16[18, 0] = new SourceGrid.Cells.ColumnHeader("x");
            grid16[18, 0].ColumnSpan = 2;
            grid16[18, 2] = new SourceGrid.Cells.Cell();
            grid16[18, 3] = new SourceGrid.Cells.ColumnHeader("б/р");

            grid16[19, 0] = new SourceGrid.Cells.ColumnHeader("y");
            grid16[19, 0].ColumnSpan = 2;
            grid16[19, 2] = new SourceGrid.Cells.Cell();
            grid16[19, 3] = new SourceGrid.Cells.ColumnHeader("б/р");


            grid16[20, 0] = new SourceGrid.Cells.ColumnHeader("Эмпирические коэффициенты силы резания");
            grid16[20, 0].ColumnSpan = 4;

            grid16[21, 0] = new SourceGrid.Cells.ColumnHeader("Ср");
            grid16[21, 0].ColumnSpan = 2;
            grid16[21, 2] = new SourceGrid.Cells.Cell();
            grid16[21, 3] = new SourceGrid.Cells.ColumnHeader("б/р");

            grid16[22, 0] = new SourceGrid.Cells.ColumnHeader("q");
            grid16[22, 0].ColumnSpan = 2;
            grid16[22, 2] = new SourceGrid.Cells.Cell();
            grid16[22, 3] = new SourceGrid.Cells.ColumnHeader("б/р");

            grid16[23, 0] = new SourceGrid.Cells.ColumnHeader("x");
            grid16[23, 0].ColumnSpan = 2;
            grid16[23, 2] = new SourceGrid.Cells.Cell();
            grid16[23, 3] = new SourceGrid.Cells.ColumnHeader("б/р");

            grid16[24, 0] = new SourceGrid.Cells.ColumnHeader("y");
            grid16[24, 0].ColumnSpan = 2;
            grid16[24, 2] = new SourceGrid.Cells.Cell();
            grid16[24, 3] = new SourceGrid.Cells.ColumnHeader("б/р");

            // Добавляем возможность редактировать и указываем событие при изменении значения
            for (int r = 1; r < 25; r++)
            {
                if (r != 3 && r != 9 && r != 15 && r != 20)
                {
                    grid16[r, 2].Editor = tb;
                    grid16[r, 2].AddController(CellChangedEvent);
                    grid16[r, 2].AddController(new MyCellTracking());//наведение
                    //grid16[r, 2].AddController(new MyHelpRowTracking());//help row pointer
                }
            }
            #endregion

            foreach (SourceGrid.GridColumn col in grid16.Columns)
                col.Width = 80;
            grid16.Columns[0].Width = 100;
            foreach (SourceGrid.GridRow r in grid16.Rows)
                r.Height = 25;
        }
        private void DoFullResultTab2_Drill()
        {
            #region Код таблицы
            grid17.BorderStyle = BorderStyle.FixedSingle;
            grid17.Redim(6, 4);
            grid17[0, 0] = new SourceGrid.Cells.ColumnHeader("Выходные параметры");
            grid17[0, 0].ColumnSpan = 4;

            grid17[1, 0] = new SourceGrid.Cells.RowHeader("Скорость резания");
            grid17[1, 1] = new SourceGrid.Cells.RowHeader();

            grid17[1, 1] = new SourceGrid.Cells.Cell();
            //Properties.Resources.V2.SetResolution((float)(Properties.Resources.V2.HorizontalResolution * 0.3), (float)(Properties.Resources.V2.VerticalResolution * 0.3));
            grid17[1, 1].Image = Properties.Resources.V2;

            grid17[1, 2] = new SourceGrid.Cells.Cell();
            grid17[1, 3] = new SourceGrid.Cells.Cell("м/мин");

            grid17[2, 0] = new SourceGrid.Cells.RowHeader("Момент резания");
            grid17[2, 1] = new SourceGrid.Cells.RowHeader();

            grid17[2, 1] = new SourceGrid.Cells.Cell();
            Bitmap bm = new Bitmap(Properties.Resources.M2);
            bm.SetResolution(96.0F, 96.0F);
            grid17[2, 1].Image = bm;//Properties.Resources.M2;

            grid17[2, 2] = new SourceGrid.Cells.Cell();
            grid17[2, 3] = new SourceGrid.Cells.Cell("Нм");

            grid17[3, 0] = new SourceGrid.Cells.RowHeader("Сила резания");
            grid17[3, 1] = new SourceGrid.Cells.RowHeader();

            grid17[3, 1] = new SourceGrid.Cells.Cell();
            grid17[3, 1].Image = Properties.Resources.P2;

            grid17[3, 2] = new SourceGrid.Cells.Cell();
            grid17[3, 3] = new SourceGrid.Cells.Cell("Н");

            grid17[4, 0] = new SourceGrid.Cells.RowHeader("Потребляемая мощность");
            grid17[4, 1] = new SourceGrid.Cells.RowHeader();

            grid17[4, 1] = new SourceGrid.Cells.Cell();
            grid17[4, 1].Image = Properties.Resources.N2;

            grid17[4, 2] = new SourceGrid.Cells.Cell();
            grid17[4, 3] = new SourceGrid.Cells.Cell("кВт");



            grid17[5, 0] = new SourceGrid.Cells.RowHeader("Частота вращения шпинделя");
            grid17[5, 1] = new SourceGrid.Cells.RowHeader();

            grid17[5, 1] = new SourceGrid.Cells.Cell();
            grid17[5, 1].Image = Properties.Resources.n_2_2;

            grid17[5, 2] = new SourceGrid.Cells.Cell();
            grid17[5, 3] = new SourceGrid.Cells.Cell("об/мин");

            grid17.Columns[0].Width = 130;
            grid17.Columns[1].Width = 210;
            grid17.Columns[2].Width = 70;
            grid17.Columns[3].Width = 70;

            grid17.Rows[0].Height = 36;
            grid17.Rows[1].Height = 60;
            grid17.Rows[2].Height = 60;
            grid17.Rows[3].Height = 60;
            grid17.Rows[4].Height = 60;
            grid17.Rows[5].Height = 60;



            #endregion
        }
        private void DoFullGrid16_Drill()
        {
            grid16[1, 2].Value = ds.inputData.s;
            grid16[2, 2].Value = ds.inputData.t;
            grid16[3, 2].Value = ds.inputData.T;
            grid16[4, 2].Value = ds.inputData.D;
            grid16[5, 2].Value = ds.inputData.d;
            grid16[6, 2].Value = ds.inputData.Kmv;
            grid16[7, 2].Value = ds.inputData.Kpv;
            grid16[8, 2].Value = ds.inputData.Kg;

            grid16[10, 2].Value = ds.inputData.Cv;
            grid16[11, 2].Value = ds.inputData.qv;
            grid16[12, 2].Value = ds.inputData.xv;
            grid16[13, 2].Value = ds.inputData.yv;
            grid16[14, 2].Value = ds.inputData.mv;

            grid16[16, 2].Value = ds.inputData.Cm;
            grid16[17, 2].Value = ds.inputData.qm;
            grid16[18, 2].Value = ds.inputData.xm;
            grid16[19, 2].Value = ds.inputData.ym;

            grid16[21, 2].Value = ds.inputData.Cp;
            grid16[22, 2].Value = ds.inputData.qp;
            grid16[23, 2].Value = ds.inputData.xp;
            grid16[24, 2].Value = ds.inputData.yp;


        }
        private void DoFullGrid17_Drill()
        {
            grid17[1, 2].Value = ds.getV();
            grid17[2, 2].Value = ds.getM();
            grid17[3, 2].Value = ds.getP();
            grid17[4, 2].Value = ds.getN();
            grid17[5, 2].Value = ds.getn();
            grid16[5, 2].Value = ds.inputData.d;
            grid16[2, 2].Value = ds.inputData.t;

        }
        #endregion
        /// <summary>
        /// Класс для SQLite соединения
        /// </summary>
        private class SQLreader
        {
            private SQLiteConnection sqlite_conn = new SQLiteConnection();
            public SQLreader(String source)
            {
                if (sqlite_conn.State != ConnectionState.Open)
                {
                    sqlite_conn = new SQLiteConnection("Data Source=" + source + ";Version=3;New=True;Compress=True;");
                    sqlite_conn.Open();
                }
            }
            public SQLiteDataReader getReader(String dataBaseName)
            {
                SQLiteCommand sqlite_cmd = sqlite_conn.CreateCommand();
                sqlite_cmd.CommandText = "SELECT * FROM " + dataBaseName;
                return sqlite_cmd.ExecuteReader();
            }

            ~SQLreader()
            {
                try
                {
                    sqlite_conn.Close();
                }
                catch (Exception)
                {
                }
            }
        }
        /// <summary>
        /// Событие происходит при изменении значения ячейки
        /// нужен для задания значения шага при точении резьбы
        /// </summary>
        private void CellEvent_Changed_rezba(object sender, EventArgs e)
        {
            SourceGrid.CellContext context = (SourceGrid.CellContext)sender;
            try
            {
                ts.inputData.s_rezba = Convert.ToSingle(context.Value);
                context.Value = Convert.ToString(ts.inputData.s_rezba);
                context.Invalidate();
            }
            catch (System.FormatException)
            {
                grid6[14, 2].Value = "s=p";
                grid6[8, 2].Value = "s=p";
                grid6[7, 2].Value = "s=p";
            }
        }

        /// <summary>
        /// Событие происходит при изменении значения ячейки во вкладке "Результат"
        /// </summary>
        private void CellEvent_Changed(object sender, EventArgs e)
        {
            SourceGrid.CellContext context = (SourceGrid.CellContext)sender;

            // Если это вкладка "Результат" для точения
            if (tabControl1.Controls.Find(context.Grid.Name, true).Length != 0)
                turningResultCell_Chenged(context, e);
            // Если это вкладка "Результат" для фрезерования
            if (tabControl2.Controls.Find(context.Grid.Name, true).Length != 0)
                millingResultCell_Chenged(context, e);
            // Если это вкладка "Результат" для сверления
            if (tabControl3.Controls.Find(context.Grid.Name, true).Length != 0)
                drillingResultCell_Chenged(context, e);
        }

        /// <summary>
        /// Вызывается когда изменена ячейка на вкладке "Результат" для токарного перехода
        /// </summary>
        private void turningResultCell_Chenged(SourceGrid.CellContext context, EventArgs e)
        {
            switch (context.Position.Row)
            {
                case 1:
                    ts.inputData.s = (float)context.Value;
                    break;
                case 2:
                    ts.inputData.t = (float)context.Value;
                    break;
                case 3:
                    ts.inputData.T = (float)context.Value;
                    break;
                case 4:
                    ts.inputData.D = (float)context.Value;
                    break;
                case 5:
                    ts.inputData.Kiv = (float)context.Value;
                    break;
                case 6:
                    ts.inputData.Kmv = (float)context.Value;
                    break;
                case 7:
                    ts.inputData.Kpv = (float)context.Value;
                    break;
                case 8:
                    ts.inputData.Kmp = (float)context.Value;
                    break;
                case 10:
                    ts.inputData.Cv = (float)context.Value;
                    break;
                case 11:
                    ts.inputData.xv = (float)context.Value;
                    break;
                case 12:
                    ts.inputData.yv = (float)context.Value;
                    break;
                case 13:
                    ts.inputData.mv = (float)context.Value;
                    break;
                case 15:
                    ts.inputData.Cp = (float)context.Value;
                    break;
                case 16:
                    ts.inputData.xp = (float)context.Value;
                    break;
                case 17:
                    ts.inputData.yp = (float)context.Value;
                    break;
                case 18:
                    ts.inputData.np = (float)context.Value;
                    break;
            }
            DoFullGrid19_Turning();
        }

        /// <summary>
        /// Вызывается когда изменена ячейка на вкладке "Результат" для фрезерного перехода
        /// </summary>
        private void millingResultCell_Chenged(SourceGrid.CellContext context, EventArgs e)
        {
            switch (context.Position.Row)
            {
                case 1:
                    ms.inputData.s = (float)context.Value;
                    break;
                case 2:
                    ms.inputData.t = (float)context.Value;
                    break;
                case 3:
                    ms.inputData.T = (float)context.Value;
                    break;
                case 4:
                    ms.inputData.D = (float)context.Value;
                    break;
                case 5:
                    ms.inputData.z = (float)context.Value;
                    break;
                case 6:
                    ms.inputData.B = (float)context.Value;
                    break;
                case 7:
                    ms.inputData.Kv = (float)context.Value;
                    break;
                case 8:
                    ms.inputData.Kp = (float)context.Value;
                    break;
                case 10:
                    ms.inputData.Cv = (float)context.Value;
                    break;
                case 11:
                    ms.inputData.qv = (float)context.Value;
                    break;
                case 12:
                    ms.inputData.xv = (float)context.Value;
                    break;
                case 13:
                    ms.inputData.yv = (float)context.Value;
                    break;
                case 14:
                    ms.inputData.uv = (float)context.Value;
                    break;
                case 15:
                    ms.inputData.pv = (float)context.Value;
                    break;
                case 16:
                    ms.inputData.mv = (float)context.Value;
                    break;

                case 18:
                    ms.inputData.Cp = (float)context.Value;
                    break;
                case 19:
                    ms.inputData.qp = (float)context.Value;
                    break;
                case 20:
                    ms.inputData.xp = (float)context.Value;
                    break;
                case 21:
                    ms.inputData.yp = (float)context.Value;
                    break;
                case 22:
                    ms.inputData.up = (float)context.Value;
                    break;
                case 23:
                    ms.inputData.wp = (float)context.Value;
                    break;
            }
            DoFullGrid21_Milling();
        }

        /// <summary>
        /// Вызывается когда изменена ячейка на вкладке "Результат" для сверлильного перехода
        /// </summary>
        private void drillingResultCell_Chenged(SourceGrid.CellContext context, EventArgs e)
        {
            switch (context.Position.Row)
            {
                case 1:
                    ds.inputData.s = (float)context.Value;
                    break;
                case 2:
                    ds.inputData.t = (float)context.Value;
                    break;
                case 3:
                    ds.inputData.T = (float)context.Value;
                    break;
                case 4:
                    ds.inputData.D = (float)context.Value;
                    break;
                case 5:
                    ds.inputData.d = (float)context.Value;
                    break;
                case 6:
                    ds.inputData.Kmv = (float)context.Value;
                    break;
                case 7:
                    ds.inputData.Kpv = (float)context.Value;
                    break;
                case 8:
                    ds.inputData.Kg = (float)context.Value;
                    break;
                case 10:
                    ds.inputData.Cv = (float)context.Value;
                    break;
                case 11:
                    ds.inputData.qv = (float)context.Value;
                    break;
                case 12:
                    ds.inputData.xv = (float)context.Value;
                    break;
                case 13:
                    ds.inputData.yv = (float)context.Value;
                    break;
                case 14:
                    ds.inputData.mv = (float)context.Value;
                    break;
                case 16:
                    ds.inputData.Cm = (float)context.Value;
                    break;
                case 17:
                    ds.inputData.qm = (float)context.Value;
                    break;
                case 18:
                    ds.inputData.xm = (float)context.Value;
                    break;
                case 19:
                    ds.inputData.ym = (float)context.Value;
                    break;
                case 21:
                    ds.inputData.Cp = (float)context.Value;
                    break;
                case 22:
                    ds.inputData.qp = (float)context.Value;
                    break;
                case 23:
                    ds.inputData.xp = (float)context.Value;
                    break;
                case 24:
                    ds.inputData.yp = (float)context.Value;
                    break;
            }
            DoFullGrid17_Drill();
        }

        /// <summary>
        /// Отслеживание текущей ячейки 
        /// при наведении мыши
        /// небесно-голубым цветом
        /// </summary>
        public class MyCellTracking : SourceGrid.Cells.Controllers.ControllerBase
        {
            private SourceGrid.Cells.Views.Cell cellView;
            public
                override void OnMouseEnter(SourceGrid.CellContext sender, EventArgs e)
            {
                cellView = new SourceGrid.Cells.Views.Cell();
                cellView.Background = new DevAge.Drawing.VisualElements.BackgroundSolid(Color.SkyBlue);
                cellView.TextAlignment = DevAge.Drawing.ContentAlignment.MiddleCenter;
                sender.Cell.View = cellView;
                sender.Grid.InvalidateCell(sender.Position);
            }
            public
                override void OnMouseLeave(SourceGrid.CellContext sender, EventArgs e)
            {
                cellView = new SourceGrid.Cells.Views.Cell();
                cellView.Background = new DevAge.Drawing.VisualElements.BackgroundSolid(Color.White);
                cellView.TextAlignment = DevAge.Drawing.ContentAlignment.MiddleCenter;
                sender.Cell.View = cellView;
                sender.Grid.InvalidateCell(sender.Position);
            }
        }

        /// <summary>
        /// Отслеживание текущей строки
        /// при наведении мыши
        /// небесно-голубым цветом
        /// </summary>
        public class MyRowTrecking : SourceGrid.Cells.Controllers.ControllerBase
        {

            private SourceGrid.Cells.Views.Cell cellView;
            public
                override void OnMouseEnter(SourceGrid.CellContext sender, EventArgs e)
            {
                cellView = new SourceGrid.Cells.Views.Cell();
                cellView.Background = new DevAge.Drawing.VisualElements.BackgroundSolid(Color.SkyBlue);
                cellView.TextAlignment = DevAge.Drawing.ContentAlignment.MiddleCenter;
                for (int c = 0; c < sender.Grid.Columns.Count; c++)
                {
                    if (Convert.ToString(sender.Grid.GetCell(new Position(sender.Position.Row, c)).GetType()) == "SourceGrid.Cells.Cell")
                    {
                        sender.Grid.GetCell(new Position(sender.Position.Row, c)).View = cellView;
                        sender.Grid.InvalidateCell(new Position(sender.Position.Row, c));
                    }
                }

            }
            public
                override void OnMouseLeave(SourceGrid.CellContext sender, EventArgs e)
            {
                cellView = new SourceGrid.Cells.Views.Cell();
                cellView.Background = new DevAge.Drawing.VisualElements.BackgroundSolid(Color.White);
                cellView.TextAlignment = DevAge.Drawing.ContentAlignment.MiddleCenter;
                for (int c = 0; c < sender.Grid.Columns.Count; c++)
                {
                    if (Convert.ToString(sender.Grid.GetCell(new Position(sender.Position.Row, c)).GetType()) == "SourceGrid.Cells.Cell")
                    {
                        sender.Grid.GetCell(new Position(sender.Position.Row, c)).View = cellView;
                        sender.Grid.InvalidateCell(new Position(sender.Position.Row, c));
                    }
                }
            }
        }

        /// <summary>
        /// Отслеживание заголовков
        /// светло-зеленым цветом
        /// </summary>
        public class MyHelpRowTracking : SourceGrid.Cells.Controllers.ControllerBase
        {

            private SourceGrid.Cells.Views.Cell cellView;
            public
                override void OnMouseEnter(SourceGrid.CellContext sender, EventArgs e)
            {
                cellView = new SourceGrid.Cells.Views.Cell();
                cellView.Background = new DevAge.Drawing.VisualElements.BackgroundSolid(Color.LightGreen);
                cellView.TextAlignment = DevAge.Drawing.ContentAlignment.MiddleCenter;
                for (int c = 0; c < sender.Grid.Columns.Count; c++)
                {
                    if (Convert.ToString(sender.Grid.GetCell(new Position(sender.Position.Row, c)).GetType()) != "SourceGrid.Cells.Cell")
                    {
                        sender.Grid.GetCell(new Position(sender.Position.Row, c)).View = cellView;
                        sender.Grid.InvalidateCell(new Position(sender.Position.Row, c));
                    }
                }

            }
            public
                override void OnMouseLeave(SourceGrid.CellContext sender, EventArgs e)
            {
                cellView = new SourceGrid.Cells.Views.Cell();
                cellView.Background = new DevAge.Drawing.VisualElements.BackgroundSolid(Color.White);
                cellView.TextAlignment = DevAge.Drawing.ContentAlignment.MiddleCenter;
                for (int c = 0; c < sender.Grid.Columns.Count; c++)
                {
                    if (Convert.ToString(sender.Grid.GetCell(new Position(sender.Position.Row, c)).GetType()) != "SourceGrid.Cells.Cell")
                    {
                        sender.Grid.GetCell(new Position(sender.Position.Row, c)).View = cellView;
                        sender.Grid.InvalidateCell(new Position(sender.Position.Row, c));
                    }
                }
            }
        }

        /// <summary>
        /// Обработчик события клика на ячейку
        /// </summary>
        private void clickEvent_Click(object sender, EventArgs e)
        {
            SourceGrid.CellContext context = (SourceGrid.CellContext)sender;
            if (context.Grid.Parent.Parent == this.tabControl1)
                turningCellClick(context, e);
            if (context.Grid.Parent.Parent == this.tabControl2)
                millingCellClick(context, e);
            if (context.Grid.Parent.Parent == this.tabControl3)
                drillingCellClick(context, e);
        }
        /// <summary>
        /// Нажатие на ячейку для точения
        /// </summary>
        private void turningCellClick(CellContext context, EventArgs e)
        {
            if (context.Grid.Handle == grid1.Handle)
            {
                ts.inputData.t = Convert.ToSingle(context.Value);
                ts.setLCell(1, context);
            }
            if (context.Grid.Handle == grid2.Handle)
            {
                ts.inputData.s = Convert.ToSingle(context.Value);
                ts.setLCell(2, context);
            }
            if (context.Grid.Handle == grid3.Handle)
            {
                ts.inputData.Kmv = Convert.ToSingle(context.Value);
                ts.setLCell(3, context);
            }
            if (context.Grid.Handle == grid4.Handle)
            {
                ts.inputData.Kpv = Convert.ToSingle(context.Value);
                ts.setLCell(4, context);
            }
            if (context.Grid.Handle == grid5.Handle)
            {
                ts.inputData.Kiv = Convert.ToSingle(context.Value);
                ts.setLCell(5, context);
            }
            if (context.Grid.Handle == grid6.Handle)
            {
                ts.inputData.Cv = Convert.ToSingle(grid6[context.Position.Row, 3].Value);
                ts.inputData.xv = Convert.ToSingle(grid6[context.Position.Row, 4].Value);
                ts.inputData.yv = Convert.ToSingle(grid6[context.Position.Row, 5].Value);
                ts.inputData.mv = Convert.ToSingle(grid6[context.Position.Row, 6].Value);
                ts.setLCell(6, context);
                if (context.Position.Row == 7 || context.Position.Row == 8 || context.Position.Row == 14)
                {
                    //Редактирование s сразу после нажатия на строку.
                    context = new CellContext(grid6, new Position(context.Position.Row, 2));
                    context.StartEdit();
                }
                else
                {
                    try
                    {
                        ts.inputData.s = Convert.ToSingle(ts.getLCell(2).Value);
                        ts.inputData.s_rezba = 0;
                    }
                    catch
                    {
                        ts.inputData.s_rezba = 0;
                    }
                }
            }
            if (context.Grid.Handle == grid7.Handle)
            {
                ts.inputData.Cp = Convert.ToSingle(grid7[context.Position.Row, 2].Value);
                ts.inputData.xp = Convert.ToSingle(grid7[context.Position.Row, 3].Value);
                ts.inputData.yp = Convert.ToSingle(grid7[context.Position.Row, 4].Value);
                ts.inputData.np = Convert.ToSingle(grid7[context.Position.Row, 5].Value);
                ts.setLCell(7, context);
            }
            if (context.Grid.Handle == grid8.Handle)
            {
                ts.inputData.Kmp = Convert.ToSingle(context.Value);
                ts.setLCell(8, context);
            }

            //Выделение ячеек (они unselectable)

            if ((context.Grid.Handle == grid6.Handle) | (context.Grid.Handle == grid7.Handle) | (context.Grid.Handle == grid14.Handle) | (context.Grid.Handle == grid15.Handle))
            {
                Utils.RowSelector(context);
            }
            else
            {
                Utils.CellSelector(context);
            }
        }
        /// <summary>
        /// Нажатие на ячейку для фрезерования
        /// </summary>
        private void millingCellClick(CellContext context, EventArgs e)
        {

            if (context.Grid.Handle == grid1Mill.Handle)
            {
                ms.inputData.Cv = Convert.ToSingle(grid1Mill[context.Position.Row, 4].Value);
                ms.inputData.qv = Convert.ToSingle(grid1Mill[context.Position.Row, 5].Value);
                ms.inputData.xv = Convert.ToSingle(grid1Mill[context.Position.Row, 6].Value);
                ms.inputData.yv = Convert.ToSingle(grid1Mill[context.Position.Row, 7].Value);
                ms.inputData.uv = Convert.ToSingle(grid1Mill[context.Position.Row, 8].Value);
                ms.inputData.pv = Convert.ToSingle(grid1Mill[context.Position.Row, 9].Value);
                ms.inputData.mv = Convert.ToSingle(grid1Mill[context.Position.Row, 10].Value);
                ms.setLCell(1, context);
            }
            if (context.Grid.Handle == grid2Mill.Handle)
            {
                ms.inputData.z = Convert.ToSingle(context.Value);
                ms.setLCell(2, context);
            }
            if (context.Grid.Handle == grid3Mill.Handle)
            {
                ms.inputData.Kv = Convert.ToSingle(context.Value);
                ms.setLCell(3, context);
            }
            if (context.Grid.Handle == grid4Mill.Handle)
            {
                ms.inputData.Kp = Convert.ToSingle(context.Value);
                ms.setLCell(4, context);
            }
            if (context.Grid.Handle == grid5Mill.Handle)
            {
                ms.inputData.Cp = Convert.ToSingle(grid5Mill[context.Position.Row, 2].Value);
                ms.inputData.xp = Convert.ToSingle(grid5Mill[context.Position.Row, 3].Value);
                ms.inputData.yp = Convert.ToSingle(grid5Mill[context.Position.Row, 4].Value);
                ms.inputData.up = Convert.ToSingle(grid5Mill[context.Position.Row, 5].Value);
                ms.inputData.qp = Convert.ToSingle(grid5Mill[context.Position.Row, 6].Value);
                ms.inputData.wp = Convert.ToSingle(grid5Mill[context.Position.Row, 7].Value);
                ms.setLCell(5, context);
                Utils.RowSelector(context);
            }
            //Выделение ячеек (они unselectable)

            if (context.Grid.Handle == grid5Mill.Handle)
            {
                Utils.RowSelector(context);
            }
            if (context.Grid.Handle == grid1Mill.Handle)
            {
                Utils.RowSelector(context);
            }
            if ((context.Grid.Handle != grid1Mill.Handle) && (context.Grid.Handle != grid5Mill.Handle) && (context.Grid.Handle != grid6.Handle) && (context.Grid.Handle != grid7.Handle) && (context.Grid.Handle != grid14.Handle) && (context.Grid.Handle != grid15.Handle))
            {
                //следующий код необходим для верного выделения (click-drop) иначе 
                //click на одной ячейке, select на другой.(+unselectable)
                //+решения проблеммы shift+arrow т.е. выделение только при событии click 
                if (!((context.Position.Column == 1) && (context.Position.Row > 10) && (context.Grid.Handle == grid1.Handle)))
                {
                    Utils.CellSelector(context);
                }
            }
        }
        /// <summary>
        /// Нажатие на ячейку для сверления
        /// </summary>
        private void drillingCellClick(CellContext context, EventArgs e)
        {
            if (context.Grid.Handle == grid9.Handle)
            {
                if (context.Position.Row == 3 || context.Position.Row == 4)
                {
                    if (context.Position.Row == 3)
                    {
                        ds.inputData.dk = My_Cal.DrillingStep.drillingKind.PRELIMINARY;
                        ds.setLCell(1, context);
                    }
                    if (context.Position.Row == 4)
                    {
                        ds.inputData.dk = My_Cal.DrillingStep.drillingKind.FINAL;
                        ds.setLCell(1, context);
                    }
                }
                else
                {
                    ds.inputData.dk = DrillingStep.drillingKind.DRILLING;
                    ds.setLCell(1, context);
                }
                Utils.CellSelector(context);
            }
            if (context.Grid.Handle == grid10.Handle)
            {
                ds.inputData.s = Convert.ToSingle(context.Value);
                ds.setLCell(2, context);
                Utils.CellSelector(context);
            }
            if (context.Grid.Handle == grid11.Handle)
            {
                ds.inputData.Kmv = Convert.ToSingle(context.Value);
                ds.setLCell(3, context);
                Utils.CellSelector(context);
            }
            if (context.Grid.Handle == grid12.Handle)
            {
                ds.inputData.Kpv = Convert.ToSingle(context.Value);
                ds.setLCell(4, context);
                Utils.CellSelector(context);
            }
            if (context.Grid.Handle == grid13.Handle)
            {
                ds.inputData.Kg = Convert.ToSingle(context.Value);
                ds.setLCell(5, context);
                Utils.CellSelector(context);
            }
            if (context.Grid.Handle == grid14.Handle)
            {
                ds.inputData.Cv = Convert.ToSingle(grid14[context.Position.Row, 3].Value);
                ds.inputData.qv = Convert.ToSingle(grid14[context.Position.Row, 4].Value);
                ds.inputData.xv = Convert.ToSingle(grid14[context.Position.Row, 5].Value);
                ds.inputData.yv = Convert.ToSingle(grid14[context.Position.Row, 6].Value);
                ds.inputData.mv = Convert.ToSingle(grid14[context.Position.Row, 7].Value);
                ds.setLCell(6, context);
                Utils.RowSelector(context);
            }
            if (context.Grid.Handle == grid15.Handle)
            {
                ds.inputData.Cm = Convert.ToSingle(grid15[context.Position.Row, 3].Value);
                ds.inputData.qm = Convert.ToSingle(grid15[context.Position.Row, 4].Value);
                try
                {
                    ds.inputData.xm = Convert.ToSingle(grid15[context.Position.Row, 5].Value);
                    ds.inputData.xp = Convert.ToSingle(grid15[context.Position.Row, 9].Value);
                }
                catch (Exception)
                {
                }
                ds.inputData.ym = Convert.ToSingle(grid15[context.Position.Row, 6].Value);
                ds.inputData.Cp = Convert.ToSingle(grid15[context.Position.Row, 7].Value);
                ds.inputData.qp = Convert.ToSingle(grid15[context.Position.Row, 8].Value);
                ds.inputData.yp = Convert.ToSingle(grid15[context.Position.Row, 10].Value);
                ds.setLCell(7, context);
                Utils.RowSelector(context);
            }
        }

        /// <summary>
        /// Вход на вкладку "Результат" для токарного перехода
        /// </summary>
        private void tabPage9_Enter(object sender, EventArgs e)
        {
            DoFullGrid18_Turning();
            DoFullGrid19_Turning();
        }


        /// <summary>
        /// Событие изменения пункта меню для выбора периода стойкости резца для фрезерного перехода
        /// </summary>
        private void comboBox1Mill_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1Mill.Text != "")
            {
                ms.cBoxIndex = comboBox1Mill.SelectedIndex;
                ms.inputData.T = Convert.ToSingle(comboBox1Mill.Text);
                comboBox1Mill.SelectedIndex = ms.cBoxIndex;
            }
        }

        /// <summary>
        /// Событие нажатия на кнопку "Ввод данных" для фрезерного перехода
        /// </summary>
        private void button2Mill_Click(object sender, EventArgs e)
        {
            textBox1Mill.Text = textBox1Mill.Text.Replace(".", ",");
            textBox2Mill.Text = textBox2Mill.Text.Replace(".", ",");
            textBox3Mill.Text = textBox3Mill.Text.Replace(".", ",");
            textBox10Mill.Text = textBox10Mill.Text.Replace(".", ",");
            try
            {
                ms.inputData.t = Convert.ToSingle(textBox1Mill.Text);
                ms.inputData.B = Convert.ToSingle(textBox2Mill.Text);
                ms.inputData.s = Convert.ToSingle(textBox3Mill.Text);
                ms.inputData.D = Convert.ToSingle(textBox10Mill.Text);
            }
            catch (System.FormatException)
            {
                textBox1Mill.Text = "";
                textBox2Mill.Text = "";
                textBox3Mill.Text = "";
                textBox10Mill.Text = "";
                MessageBox.Show("Ошибка ввода!\n");
            }

        }

        // удалить
        private void textBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button2_Click(null, null);
            }
        }

        /// <summary>
        /// Событие при входе на вкладку "Результат для фрезерного перехода"
        /// </summary>
        private void tabPage7Mill_Enter(object sender, EventArgs e)
        {
            DoFullGrid20_Milling();
            DoFullGrid21_Milling();
        }

        // удалить
        private void button2_Click(object sender, EventArgs e)
        {
        }
        // удалить
        private void button3_Click(object sender, EventArgs e)
        {

        }
        // удалить
        private void button4_Click(object sender, EventArgs e)
        {

        }
        // удалить
        private void menu1ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Событие нажатия на пункт меню "Создать токарный переход."
        /// </summary>
        private void makeTurningStepToolStripMenuItem_Click(object sender, EventArgs e)
        {
            i++;
            treeView1.BeginUpdate();
            treeView1.Nodes.Add("Переход" + i + " (токарный)");
            treeView1.Nodes[0].Expand();
            treeView1.EndUpdate();
            TurningStep s = new TurningStep();//Создаем ещё один объект и помещаем его в коллекцию
            //текущий не трогаем, а подменяем его только при выборе
            stepList.Add(s);
        }

        /// <summary>
        /// Событие нажатия на пункт меню "Создать фрезерный переход."
        /// </summary>
        private void makeMillStepToolStripMenuItem_Click(object sender, EventArgs e)
        {
            i++;
            treeView1.BeginUpdate();
            treeView1.Nodes.Add("Переход" + i + " (фрезерный)");
            treeView1.Nodes[0].Expand();
            treeView1.EndUpdate();
            MillingStep s = new MillingStep();
            stepList.Add(s);
        }

        /// <summary>
        /// Событие при нажатии на пункт меню "Создать сверлильный переход"
        /// </summary>
        private void makeDrillStepToolStripMenuItem_Click(object sender, EventArgs e)
        {
            i++;
            treeView1.BeginUpdate();
            treeView1.Nodes.Add("Переход" + i + " (сверлильный)");
            treeView1.Nodes[0].Expand();
            treeView1.EndUpdate();
            DrillingStep s = new DrillingStep();
            stepList.Add(s);
        }

        /// <summary>
        /// Событие при нажатии на пункт меню "Создать отчет"
        /// </summary>
        private void makeReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {

                saveFileDialog1.AddExtension = true;
                saveFileDialog1.ShowDialog();
                StreamWriter fstr_out;
                // Открываем выходной файл.
                try
                {
                    fstr_out = new StreamWriter(saveFileDialog1.FileName);
                    //fstr_out = new StreamWriter(
                }
                catch (IOException exc)
                {
                    Console.WriteLine(
                    exc.Message +
                    "\nОшибка при открытии выходного файла.");
                    return;
                }
                catch (ArgumentException)
                {
                    return;
                }

                // Записываем в файл.
                for (int i = 0; i < stepList.Count; i++)
                {
                    try
                    {
                        try
                        {
                            Convert.ToString(((TurningStep)stepList[i]).getV());
                            fstr_out.Write("\r\n           Переход №" + (i + 1) + " (токарный)\r\n");
                            fstr_out.Write("Скорость резания:   ");
                            fstr_out.Write(Convert.ToString(((TurningStep)stepList[i]).getV()) + " м/с\r\n");
                            fstr_out.Write("Частота вращения:   ");
                            fstr_out.Write(Convert.ToString(((TurningStep)stepList[i]).getn()) + " об/мин\r\n");
                            fstr_out.Write("Мощность:           ");
                            fstr_out.Write(Convert.ToString(((TurningStep)stepList[i]).getN()) + " кВт\r\n");
                            fstr_out.Write("Сила резания:       ");
                            fstr_out.Write(Convert.ToString(((TurningStep)stepList[i]).getP()) + " Н\r\n");
                            fstr_out.Write("Момент:             ");
                            fstr_out.Write(Convert.ToString(((TurningStep)stepList[i]).getM()) + " Нм\r\n");
                        }
                        catch (InvalidCastException)
                        {
                            try
                            {
                                Convert.ToString(((TurningStep)stepList[i]).getV());
                                fstr_out.Write("\r\n           Переход №" + (i + 1) + "(фрезерный)\r\n");
                                fstr_out.Write("Скорость резания:   ");
                                fstr_out.Write(Convert.ToString(((MillingStep)stepList[i]).getV()) + " м/с\r\n");
                                fstr_out.Write("Частота вращения:   ");
                                fstr_out.Write(Convert.ToString(((MillingStep)stepList[i]).getn()) + " об/мин\r\n");
                                fstr_out.Write("Мощность:           ");
                                fstr_out.Write(Convert.ToString(((MillingStep)stepList[i]).getN()) + " кВт\r\n");
                                fstr_out.Write("Сила резания:       ");
                                fstr_out.Write(Convert.ToString(((MillingStep)stepList[i]).getP()) + " Н\r\n");
                                fstr_out.Write("Момент:             ");
                                fstr_out.Write(Convert.ToString(((MillingStep)stepList[i]).getM()) + " Нм\r\n");
                            }
                            catch (InvalidCastException)
                            {
                                fstr_out.Write("\r\n           Переход №" + (i + 1) + "(сверлильный)\r\n");
                                fstr_out.Write("Скорость резания:   ");
                                fstr_out.Write(Convert.ToString(((DrillingStep)stepList[i]).getV()) + " м/с\r\n");
                                fstr_out.Write("Частота вращения:   ");
                                fstr_out.Write(Convert.ToString(((DrillingStep)stepList[i]).getn()) + " об/мин\r\n");
                                fstr_out.Write("Мощность:           ");
                                fstr_out.Write(Convert.ToString(((DrillingStep)stepList[i]).getN()) + " кВт\r\n");
                                fstr_out.Write("Сила резания:       ");
                                fstr_out.Write(Convert.ToString(((DrillingStep)stepList[i]).getP()) + " Н\r\n");
                                fstr_out.Write("Момент:             ");
                                fstr_out.Write(Convert.ToString(((DrillingStep)stepList[i]).getM()) + " Нм\r\n");
                            }
                        }
                    }
                    catch (IOException exc)
                    {
                        MessageBox.Show(exc.Message + " Ошибка при работе с файлом. ");
                        return;
                    }
                }
                fstr_out.Close();
                Process.Start(saveFileDialog1.FileName);
            }
        }

        /// <summary>
        /// Событие при нажатии на пункт меню "Выход" 
        /// </summary>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Событие при нажатии на пункт меню "Удалить переход"
        /// </summary>
        /// TODO Проработать событие (временный код)
        private void deleteStepToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (TreeNode n in treeView1.Nodes)
            {
                if (n.IsSelected)
                {
                    n.Remove();
                    //TODO Важно! Написать удаление из ArrayList
                    if (treeView1.GetNodeCount(true) == 0)
                    {
                        tabControl1.Visible = false;
                        tabControl2.Visible = false;
                    }
                    else
                    {
                        treeView1.SelectedNode = treeView1.GetNodeAt(treeView1.GetNodeCount(true), 0);

                    }
                    break;
                }
            }

        }

        /// <summary>
        /// Событие после выбора пункта в treeView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            object s = stepList[e.Node.Index];
            if (s is TurningStep)
            {
                DoFullTab6();
                ts = (TurningStep)stepList[e.Node.Index];//подмена тем значением который записан в Alist на индексе соответствующем, индексу NODE 

                DoFullGrid18_Turning();
                DoFullGrid19_Turning();

                tabControl2.Visible = false;
                tabControl1.Visible = true;
                tabControl3.Visible = false;
                this.Text = "Калькулятор режимов резания: " + e.Node.Text;
                if (tabControl1.SelectedIndex == 8)
                {
                    tabPage9_Enter(null, null);
                }
                Utils.ClearAllSelection(this);//почистить выделение всех ячеек всех гридов
                tabControl1.Visible = true;
                ts.ReturnSelect();
            }
            if (s is MillingStep)
            {
                ms = (MillingStep)s;

                DoFullGrid20_Milling();
                DoFullGrid21_Milling();

                tabControl2.Visible = true;
                tabControl1.Visible = false;
                tabControl3.Visible = false;
                this.Text = "Калькулятор режимов резания: " + e.Node.Text;
                if (tabControl1.SelectedIndex == 8)
                {
                    tabPage7Mill_Enter(null, null);
                }
                Utils.ClearAllSelection(this);//почистить выделение всех ячеек всех гридов
                ms.ReturnSelect();
            }
            if (s is DrillingStep)
            {
                ds = (DrillingStep)s;
                DoFullGrid16_Drill();
                DoFullGrid17_Drill();
                tabControl2.Visible = false;
                tabControl1.Visible = false;
                tabControl3.Visible = true;

                this.Text = "Калькулятор режимов резания: " + e.Node.Text;
                Utils.ClearAllSelection(this);//почистить выделение всех ячеек всех гридов
                ds.ReturnSelect();
            }
        }

        private void tabPage20_Enter(object sender, EventArgs e)
        {

            DoFullGrid16_Drill();
            DoFullGrid17_Drill();
        }

    }

}
>>>>>>> c81d6c6f53c8a3b6c5cbddadd0cda900ad02f65e
