using System;
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

namespace My_Cal
{
    public partial class Form1 : Form
    {
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
            tabControl1.Visible = false;
            DoFullTab1_frez();
            DoFullTab2_frez();
            DoFullTab3_frez();
            DoFullTab4_frez();
            DoFullTab5_frez();
            tabControl3.Visible = false;
        }
        private void CustomInitialization()
        {

            i = 0;
            AList = new ArrayList();
            cellpointer = new MyCellTracking();
            rowpointer = new MyRowTrecking();
            clickEvent = new SourceGrid.Cells.Controllers.CustomEvents();
            clickEvent.Click += new EventHandler(clickEvent_Click);

            CellChangedEvent = new SourceGrid.Cells.Controllers.CustomEvents();
            CellChangedEvent.EditEnded += new EventHandler(CellEvent_Changed);
            foreach (SourceGrid.Grid GRID in tabControl1.Controls.Find("grid", true))
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


        #region DuFullTab
        private void DoFullTab1()
        {
            #region SQLite Connection
            sqlite_conn = new SQLiteConnection("Data Source=database.sqlite;Version=3;New=True;Compress=True;");// create a new database connection
            sqlite_conn.Open(); // open the connection:
            sqlite_cmd = sqlite_conn.CreateCommand();// create a new SQL command
            sqlite_cmd.CommandText = "SELECT * FROM external_turning";// First lets build a SQL-Query again
            sqlite_datareader = sqlite_cmd.ExecuteReader();// The SQLiteDataReader allows us to run through the result lines 
            #endregion
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
            sqlite_conn.Close();
            #region SQLite Connection
            sqlite_conn = new SQLiteConnection("Data Source=database.sqlite;Version=3;New=True;Compress=True;");    // create a new database connection
            sqlite_conn.Open(); // open the connection:
            sqlite_cmd = sqlite_conn.CreateCommand();                                                               // create a new SQL command
            sqlite_cmd.CommandText = "SELECT * FROM boring";                                                        // First lets build a SQL-Query again
            sqlite_datareader = sqlite_cmd.ExecuteReader();
            #endregion
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
            sqlite_conn.Close();

        }
        private void DoFullTab2()
        {
            #region SQLite Connection
            sqlite_conn = new SQLiteConnection("Data Source=database.sqlite;Version=3;New=True;Compress=True;");// create a new database connection
            sqlite_conn.Open();                                                                                 // open the connection:
            sqlite_cmd = sqlite_conn.CreateCommand();                                                           // create a new SQL command
            sqlite_cmd.CommandText = "SELECT * FROM roughing";                                                  // First lets build a SQL-Query again
            sqlite_datareader = sqlite_cmd.ExecuteReader();                                                     // The SQLiteDataReader allows us to run through the result lines
            #endregion
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
            sqlite_conn.Close();
            #region SQLite Connection
            sqlite_conn = new SQLiteConnection("Data Source=database.sqlite;Version=3;New=True;Compress=True;");    // create a new database connection
            sqlite_conn.Open();                                                                                     // open the connection:
            sqlite_cmd = sqlite_conn.CreateCommand();                                                               // create a new SQL command
            sqlite_cmd.CommandText = "SELECT * FROM finish_turning";                                                // First lets build a SQL-Query again
            sqlite_datareader = sqlite_cmd.ExecuteReader();                                                         // The SQLiteDataReader allows us to run through the result lines
            #endregion
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
            sqlite_conn.Close();// We are ready, now lets cleanup and close our connection
        }
        private void DoFullTab3()
        {
            #region SQLite Connection
            sqlite_conn = new SQLiteConnection("Data Source=database.sqlite;Version=3;New=True;Compress=True;");// create a new database connection
            sqlite_conn.Open();                                                                                 // open the connection:
            sqlite_cmd = sqlite_conn.CreateCommand();                                                           // create a new SQL command
            sqlite_cmd.CommandText = "SELECT * FROM KMV";                                                  // First lets build a SQL-Query again
            sqlite_datareader = sqlite_cmd.ExecuteReader();
            #endregion
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
            sqlite_conn.Close();
        }
        private void DoFullTab4()
        {
            #region SQLite Connection
            sqlite_conn = new SQLiteConnection("Data Source=database.sqlite;Version=3;New=True;Compress=True;");// create a new database connection
            sqlite_conn.Open();                                                                                 // open the connection:
            sqlite_cmd = sqlite_conn.CreateCommand();                                                           // create a new SQL command
            sqlite_cmd.CommandText = "SELECT * FROM KpV";                                                  // First lets build a SQL-Query again
            sqlite_datareader = sqlite_cmd.ExecuteReader();
            #endregion
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
            sqlite_conn.Close();
        }
        private void DoFullTab5()
        {
            #region SQLite Connection
            sqlite_conn = new SQLiteConnection("Data Source=database.sqlite;Version=3;New=True;Compress=True;");// create a new database connection
            sqlite_conn.Open();                                                                                 // open the connection:
            sqlite_cmd = sqlite_conn.CreateCommand();                                                           // create a new SQL command
            sqlite_cmd.CommandText = "SELECT * FROM KiV_hard_alloy";                                                  // First lets build a SQL-Query again
            sqlite_datareader = sqlite_cmd.ExecuteReader();
            #endregion
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
            sqlite_conn.Close();
            #region SQLite Connection
            sqlite_conn = new SQLiteConnection("Data Source=database.sqlite;Version=3;New=True;Compress=True;");// create a new database connection
            sqlite_conn.Open();                                                                                 // open the connection:
            sqlite_cmd = sqlite_conn.CreateCommand();                                                           // create a new SQL command
            sqlite_cmd.CommandText = "SELECT * FROM KiV_high_speed_steel";                                                  // First lets build a SQL-Query again
            sqlite_datareader = sqlite_cmd.ExecuteReader();
            #endregion
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
            sqlite_conn.Close();
        }
        private void DoFullTab6()
        {
            #region SQLite Connection
            sqlite_conn = new SQLiteConnection("Data Source=database.sqlite;Version=3;New=True;Compress=True;");// create a new database connection
            sqlite_conn.Open();                                                                                 // open the connection:
            sqlite_cmd = sqlite_conn.CreateCommand();                                                           // create a new SQL command
            sqlite_cmd.CommandText = "SELECT * FROM EmpParamV";                                                  // First lets build a SQL-Query again
            sqlite_datareader = sqlite_cmd.ExecuteReader();
            #endregion
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

            grid6[7, 2].AddController(CellChangedEvent);
            grid6[8, 2].AddController(CellChangedEvent);
            grid6[14, 2].AddController(CellChangedEvent);

            #endregion
            sqlite_conn.Close();
        }

        private void DoFullTab7()
        {
            #region SQLite Connection

            sqlite_conn = new SQLiteConnection("Data Source=database.sqlite;Version=3;New=True;Compress=True;");// create a new database connection
            sqlite_conn.Open();                                                                                 // open the connection:
            sqlite_cmd = sqlite_conn.CreateCommand();                                                           // create a new SQL command
            sqlite_cmd.CommandText = "SELECT * FROM EmpParamPz";                                                  // First lets build a SQL-Query again
            sqlite_datareader = sqlite_cmd.ExecuteReader();
            #endregion
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
            #region SQLite Connection
            sqlite_conn = new SQLiteConnection("Data Source=database.sqlite;Version=3;New=True;Compress=True;");// create a new database connection
            sqlite_conn.Open();                                                                                 // open the connection:
            sqlite_cmd = sqlite_conn.CreateCommand();                                                           // create a new SQL command
            sqlite_cmd.CommandText = "SELECT * FROM EmpParamPz";                                                  // First lets build a SQL-Query again
            sqlite_datareader = sqlite_cmd.ExecuteReader();
            #endregion
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
            sqlite_conn.Close();
        }
        private void DoFullTab8()
        {
            #region SQLite Connection
            sqlite_conn = new SQLiteConnection("Data Source=database.sqlite;Version=3;New=True;Compress=True;");// create a new database connection
            sqlite_conn.Open();                                                                                 // open the connection:
            sqlite_cmd = sqlite_conn.CreateCommand();                                                           // create a new SQL command
            sqlite_cmd.CommandText = "SELECT * FROM KmP";                                                  // First lets build a SQL-Query again
            sqlite_datareader = sqlite_cmd.ExecuteReader();
            #endregion
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
            sqlite_conn.Close();
        }
        #endregion
        #region Код М DoFullTab
        public void DoFullTab1_frez()
        {
            #region SQLite Connection
            sqlite_conn = new SQLiteConnection("Data Source=databaseF.sqlite;Version=3;New=True;Compress=True;");// create a new databaseF connection
            sqlite_conn.Open(); // open the connection:
            sqlite_cmd = sqlite_conn.CreateCommand();// create a new SQL command
            sqlite_cmd.CommandText = "SELECT * FROM FrEmpParamV";// First lets build a SQL-Query again
            sqlite_datareader = sqlite_cmd.ExecuteReader();// The SQLiteDataReader allows us to run through the result lines 
            #endregion
            #region Код таблицы 1 (твердый сплав)
            grid1Frez.BorderStyle = BorderStyle.FixedSingle;
            grid1Frez.Redim(15, 11);
            //заголовок
            grid1Frez[0, 0] = new SourceGrid.Cells.ColumnHeader("Вид обработки");
            grid1Frez[0, 1] = new SourceGrid.Cells.ColumnHeader("Материал резца");
            grid1Frez[0, 2] = new SourceGrid.Cells.ColumnHeader("t");
            grid1Frez[0, 3] = new SourceGrid.Cells.ColumnHeader("Sz");
            grid1Frez[0, 4] = new SourceGrid.Cells.ColumnHeader("Cv");
            grid1Frez[0, 5] = new SourceGrid.Cells.ColumnHeader("q");
            grid1Frez[0, 6] = new SourceGrid.Cells.ColumnHeader("x");
            grid1Frez[0, 7] = new SourceGrid.Cells.ColumnHeader("y");
            grid1Frez[0, 8] = new SourceGrid.Cells.ColumnHeader("u");
            grid1Frez[0, 9] = new SourceGrid.Cells.ColumnHeader("p");
            grid1Frez[0, 10] = new SourceGrid.Cells.ColumnHeader("m");
            grid1Frez[1, 0] = new SourceGrid.Cells.ColumnHeader("Сталь углеродистая");
            grid1Frez[1, 0].View.TextAlignment = DevAge.Drawing.ContentAlignment.MiddleCenter;
            grid1Frez[1, 0].ColumnSpan = 11;
            //строка 2
            grid1Frez[2, 0] = new SourceGrid.Cells.RowHeader("Торцевое \nфрезерование");
            grid1Frez[2, 0].RowSpan = 2;
            grid1Frez[4, 0] = new SourceGrid.Cells.RowHeader("Боковое \nфрезерование");
            grid1Frez[4, 0].RowSpan = 4;
            grid1Frez[8, 0] = new SourceGrid.Cells.ColumnHeader("Чугун");
            grid1Frez[8, 0].ColumnSpan = 11;
            //строка 2
            grid1Frez[9, 0] = new SourceGrid.Cells.RowHeader("Торцевое \nфрезерование");
            grid1Frez[9, 0].RowSpan = 2;
            grid1Frez[11, 0] = new SourceGrid.Cells.RowHeader("Боковое \nфрезерование");
            grid1Frez[11, 0].RowSpan = 4;
            for (int r = 2; r < 8; r++)
            {
                //grid1.Rows.Insert(r);
                if (sqlite_datareader.Read())
                {
                    grid1Frez[r, 1] = new SourceGrid.Cells.RowHeader(Convert.ToString(sqlite_datareader.GetString(0)));
                    grid1Frez[r, 2] = new SourceGrid.Cells.RowHeader(Convert.ToString(sqlite_datareader.GetString(1)));
                    grid1Frez[r, 3] = new SourceGrid.Cells.RowHeader(Convert.ToString(sqlite_datareader.GetString(2)));
                    grid1Frez[r, 4] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(3)), typeof(float));
                    grid1Frez[r, 5] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(4)), typeof(float));
                    grid1Frez[r, 6] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(5)), typeof(float));
                    grid1Frez[r, 7] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(6)), typeof(float));
                    grid1Frez[r, 8] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(7)), typeof(float));
                    grid1Frez[r, 9] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(8)), typeof(float));
                    grid1Frez[r, 10] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(9)), typeof(float));
                }
                for (int c = 4; c < 11; c++)
                {
                    grid1Frez[r, c].AddController(clickEvent);//клик мыши
                    grid1Frez[r, c].AddController(rowpointer);//наведение
                    grid1Frez[r, c].Editor.EnableEdit = false;//нередактируемые ячейки
                    grid1Frez[r, c].AddController(new SourceGrid.Cells.Controllers.Unselectable());
                    grid1Frez[r, c].AddController(new MyHelpRowTracking());//help row pointer

                }
            }
            for (int r = 9; r < 15; r++)
            {
                if (sqlite_datareader.Read())
                {
                    grid1Frez[r, 1] = new SourceGrid.Cells.RowHeader(Convert.ToString(sqlite_datareader.GetString(0)));
                    grid1Frez[r, 2] = new SourceGrid.Cells.RowHeader(Convert.ToString(sqlite_datareader.GetString(1)));
                    grid1Frez[r, 3] = new SourceGrid.Cells.RowHeader(Convert.ToString(sqlite_datareader.GetString(2)));
                    grid1Frez[r, 4] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(3)), typeof(float));
                    grid1Frez[r, 5] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(4)), typeof(float));
                    grid1Frez[r, 6] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(5)), typeof(float));
                    grid1Frez[r, 7] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(6)), typeof(float));
                    grid1Frez[r, 8] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(7)), typeof(float));
                    grid1Frez[r, 9] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(8)), typeof(float));
                    grid1Frez[r, 10] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(9)), typeof(float));
                }
                for (int c = 4; c < 11; c++)
                {
                    grid1Frez[r, c].AddController(clickEvent);//клик мыши
                    grid1Frez[r, c].AddController(rowpointer);//наведение
                    grid1Frez[r, c].Editor.EnableEdit = false;//нередактируемые ячейки
                    grid1Frez[r, c].AddController(new SourceGrid.Cells.Controllers.Unselectable());
                    grid1Frez[r, c].AddController(new MyHelpRowTracking());//help row pointer
                }
            }
            grid1Frez.AutoSizeCells();
            grid1Frez.EnableSort = false;
            grid1Frez.Selection.EnableMultiSelection = false;
            sqlite_conn.Close();
            #endregion
        }
        public void DoFullTab2_frez()
        {
            #region Код таблицы 2 (Зав z от D)

            grid2Frez.BorderStyle = BorderStyle.FixedSingle;
            grid2Frez.Redim(2, 10);
            //заголовок
            grid2Frez[0, 0] = new SourceGrid.Cells.RowHeader("D, мм");
            grid2Frez[0, 1] = new SourceGrid.Cells.RowHeader("10-18");
            grid2Frez[0, 2] = new SourceGrid.Cells.RowHeader("19-28");
            grid2Frez[0, 3] = new SourceGrid.Cells.RowHeader("29-50");
            grid2Frez[0, 4] = new SourceGrid.Cells.RowHeader("51-63");
            grid2Frez[0, 5] = new SourceGrid.Cells.RowHeader("64-80");
            grid2Frez[0, 6] = new SourceGrid.Cells.RowHeader("81-100");
            grid2Frez[0, 7] = new SourceGrid.Cells.RowHeader("101-125");
            grid2Frez[0, 8] = new SourceGrid.Cells.RowHeader("126-160");
            grid2Frez[0, 9] = new SourceGrid.Cells.RowHeader("161-200");
            grid2Frez[1, 0] = new SourceGrid.Cells.RowHeader("z");
            grid2Frez[0, 0].View.TextAlignment = DevAge.Drawing.ContentAlignment.MiddleCenter;
            grid2Frez[0, 1].View.TextAlignment = DevAge.Drawing.ContentAlignment.MiddleCenter;
            grid2Frez[1, 1] = new SourceGrid.Cells.Cell(Convert.ToString(3), typeof(string));
            grid2Frez[1, 2] = new SourceGrid.Cells.Cell(Convert.ToString(3), typeof(string));
            grid2Frez[1, 3] = new SourceGrid.Cells.Cell(Convert.ToString(4), typeof(string));
            grid2Frez[1, 4] = new SourceGrid.Cells.Cell(Convert.ToString(5), typeof(string));
            grid2Frez[1, 5] = new SourceGrid.Cells.Cell(Convert.ToString(8), typeof(string));
            grid2Frez[1, 6] = new SourceGrid.Cells.Cell(Convert.ToString(10), typeof(string));
            grid2Frez[1, 7] = new SourceGrid.Cells.Cell(Convert.ToString(12), typeof(string));
            grid2Frez[1, 8] = new SourceGrid.Cells.Cell(Convert.ToString(14), typeof(string));
            grid2Frez[1, 9] = new SourceGrid.Cells.Cell(Convert.ToString(18), typeof(string));
            for (int c = 1; c < 10; c++)
            {
                grid2Frez[1, c].AddController(clickEvent);//клик мыши
                grid2Frez[1, c].AddController(cellpointer);//наведение
                grid2Frez[1, c].Editor.EnableEdit = false;//нередактируемые ячейки
                grid2Frez[1, c].AddController(new SourceGrid.Cells.Controllers.Unselectable());
                grid2Frez[1, c].AddController(new MyHelpRowTracking());//help row pointer
            }
            grid2Frez.AutoSizeCells();
            grid2Frez.EnableSort = false;
            grid2Frez.Selection.EnableMultiSelection = false;
            #endregion
        }
        public void DoFullTab3_frez()
        {
            #region SQLite Connection
            sqlite_conn = new SQLiteConnection("Data Source=databaseF.sqlite;Version=3;New=True;Compress=True;");// create a new databaseF connection
            sqlite_conn.Open(); // open the connection:
            sqlite_cmd = sqlite_conn.CreateCommand();// create a new SQL command
            sqlite_cmd.CommandText = "SELECT * FROM FrParamKv";// First lets build a SQL-Query again
            sqlite_datareader = sqlite_cmd.ExecuteReader();// The SQLiteDataReader allows us to run through the result lines 
            #endregion
            #region Код таблицы 3 (Коэф. Kv)
            grid3Frez.BorderStyle = BorderStyle.FixedSingle;
            grid3Frez.Redim(7, 3);

            grid3Frez[0, 0] = new SourceGrid.Cells.ColumnHeader("Коэффициент Kv");
            grid3Frez[0, 0].ColumnSpan = 3;
            grid3Frez[1, 0] = new SourceGrid.Cells.ColumnHeader("Вид загатовки");
            grid3Frez[1, 0].RowSpan = 2;
            grid3Frez[1, 1] = new SourceGrid.Cells.ColumnHeader("Обрабатываемый материал");
            grid3Frez[1, 1].ColumnSpan = 2;
            grid3Frez[2, 1] = new SourceGrid.Cells.ColumnHeader("Конструкционная сталь");
            grid3Frez[2, 2] = new SourceGrid.Cells.ColumnHeader("Серый чугун");
            grid3Frez[0, 0].View.TextAlignment = DevAge.Drawing.ContentAlignment.MiddleCenter;
            grid3Frez[0, 1].View.TextAlignment = DevAge.Drawing.ContentAlignment.MiddleCenter;
            for (int r = 3; r < 7; r++)
            {
                if (sqlite_datareader.Read())
                {
                    grid3Frez[r, 0] = new SourceGrid.Cells.RowHeader(Convert.ToString(sqlite_datareader.GetString(0)));
                    grid3Frez[r, 1] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(1)), typeof(float));
                    grid3Frez[r, 2] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(2)), typeof(float));
                }
                for (int c = 1; c < 3; c++)
                {
                    grid3Frez[r, c].View.TextAlignment = DevAge.Drawing.ContentAlignment.MiddleCenter;
                    grid3Frez[r, c].AddController(clickEvent);//клик мыши
                    grid3Frez[r, c].AddController(cellpointer);//наведение
                    grid3Frez[r, c].Editor.EnableEdit = false;//нередактируемые ячейки
                    grid3Frez[r, c].AddController(new SourceGrid.Cells.Controllers.Unselectable());
                    grid3Frez[r, c].AddController(new MyHelpRowTracking());//help row pointer
                }
            }
            grid3Frez.AutoSizeCells();
            grid3Frez.EnableSort = false;
            grid3Frez.Selection.EnableMultiSelection = false;
            sqlite_conn.Close();
            #endregion
        }
        public void DoFullTab4_frez()
        {
            #region SQLite Connection
            sqlite_conn = new SQLiteConnection("Data Source=databaseF.sqlite;Version=3;New=True;Compress=True;");// create a new databaseF connection
            sqlite_conn.Open(); // open the connection:
            sqlite_cmd = sqlite_conn.CreateCommand();// create a new SQL command
            sqlite_cmd.CommandText = "SELECT * FROM FrParamKp";// First lets build a SQL-Query again
            sqlite_datareader = sqlite_cmd.ExecuteReader();// The SQLiteDataReader allows us to run through the result lines 
            #endregion
            #region Код таблицы 4 (Коэф. Kp)
            grid4Frez.BorderStyle = BorderStyle.FixedSingle;
            grid4Frez.Redim(3, 2);
            grid4Frez[0, 0] = new SourceGrid.Cells.ColumnHeader("Обрабатываемый \nматериал");
            grid4Frez[0, 1] = new SourceGrid.Cells.ColumnHeader("Коэффицент Kp");
            for (int r = 1; r < 3; r++)
            {
                if (sqlite_datareader.Read())
                {
                    grid4Frez[r, 0] = new SourceGrid.Cells.RowHeader(Convert.ToString(sqlite_datareader.GetString(0)));
                    grid4Frez[r, 1] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(1)), typeof(float));
                    grid4Frez[r, 0].View.TextAlignment = DevAge.Drawing.ContentAlignment.MiddleCenter;
                }
                grid4Frez[r, 1].View.TextAlignment = DevAge.Drawing.ContentAlignment.MiddleCenter;
                grid4Frez[r, 1].AddController(clickEvent);//клик мыши
                grid4Frez[r, 1].AddController(cellpointer);//наведение
                grid4Frez[r, 1].Editor.EnableEdit = false;//нередактируемые ячейки
                grid4Frez[r, 1].AddController(new SourceGrid.Cells.Controllers.Unselectable());
                grid4Frez[r, 1].AddController(new MyHelpRowTracking());//help row pointer
            }
            grid4Frez.AutoSizeCells();
            grid4Frez.EnableSort = false;
            grid4Frez.Selection.EnableMultiSelection = false;
            sqlite_conn.Close();
            #endregion
        }
        public void DoFullTab5_frez()
        {
            #region SQLite Connection
            sqlite_conn = new SQLiteConnection("Data Source=databaseF.sqlite;Version=3;New=True;Compress=True;");// create a new databaseF connection
            sqlite_conn.Open(); // open the connection:
            sqlite_cmd = sqlite_conn.CreateCommand();// create a new SQL command
            sqlite_cmd.CommandText = "SELECT * FROM FrParamPz";// First lets build a SQL-Query again
            sqlite_datareader = sqlite_cmd.ExecuteReader();// The SQLiteDataReader allows us to run through the result lines 
            #endregion
            #region Код таблицы 5 (Коэф. к ур. силы резания)
            grid5Frez.BorderStyle = BorderStyle.FixedSingle;
            grid5Frez.Redim(11, 8);
            grid5Frez[0, 0] = new SourceGrid.Cells.ColumnHeader("Вид обработки");
            grid5Frez[0, 1] = new SourceGrid.Cells.ColumnHeader("Материал резца");
            grid5Frez[0, 2] = new SourceGrid.Cells.ColumnHeader("Cр");
            grid5Frez[0, 3] = new SourceGrid.Cells.ColumnHeader("х");
            grid5Frez[0, 4] = new SourceGrid.Cells.ColumnHeader("y");
            grid5Frez[0, 5] = new SourceGrid.Cells.ColumnHeader("u");
            grid5Frez[0, 6] = new SourceGrid.Cells.ColumnHeader("q");
            grid5Frez[0, 7] = new SourceGrid.Cells.ColumnHeader("w");
            grid5Frez[1, 0] = new SourceGrid.Cells.ColumnHeader("Сталь углеродистая");
            grid5Frez[1, 0].ColumnSpan = 8;
            grid5Frez[2, 0] = new SourceGrid.Cells.RowHeader("Торцевое \nфрезерование");
            grid5Frez[2, 0].RowSpan = 2;
            grid5Frez[4, 0] = new SourceGrid.Cells.RowHeader("Боковое \nфрезерование");
            grid5Frez[4, 0].RowSpan = 2;
            grid5Frez[6, 0] = new SourceGrid.Cells.ColumnHeader("Серый чугун");
            grid5Frez[6, 0].ColumnSpan = 8;
            grid5Frez[7, 0] = new SourceGrid.Cells.RowHeader("Торцевое \nфрезерование");
            grid5Frez[7, 0].RowSpan = 2;
            grid5Frez[9, 0] = new SourceGrid.Cells.RowHeader("Боковое \nфрезерование");
            grid5Frez[9, 0].RowSpan = 2;
            for (int r = 2; r < 6; r++)
            {
                if (sqlite_datareader.Read())
                {
                    grid5Frez[r, 1] = new SourceGrid.Cells.RowHeader(Convert.ToString(sqlite_datareader.GetString(0)));
                    grid5Frez[r, 2] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(1)), typeof(float));
                    grid5Frez[r, 3] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(2)), typeof(float));
                    grid5Frez[r, 4] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(3)), typeof(float));
                    grid5Frez[r, 5] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(4)), typeof(float));
                    grid5Frez[r, 6] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(5)), typeof(float));
                    grid5Frez[r, 7] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(6)), typeof(float));
                }
                for (int c = 2; c < 8; c++)
                {
                    grid5Frez[r, c].View.TextAlignment = DevAge.Drawing.ContentAlignment.MiddleCenter;
                    grid5Frez[r, c].AddController(clickEvent);//клик мыши
                    grid5Frez[r, c].AddController(rowpointer);//наведение
                    grid5Frez[r, c].Editor.EnableEdit = false;//нередактируемые ячейки
                    grid5Frez[r, c].AddController(new SourceGrid.Cells.Controllers.Unselectable());
                    grid5Frez[r, c].AddController(new MyHelpRowTracking());//help row pointer
                }
            }
            for (int r = 7; r < 11; r++)
            {
                if (sqlite_datareader.Read())
                {
                    grid5Frez[r, 1] = new SourceGrid.Cells.RowHeader(Convert.ToString(sqlite_datareader.GetString(0)));
                    grid5Frez[r, 2] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(1)), typeof(float));
                    grid5Frez[r, 3] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(2)), typeof(float));
                    grid5Frez[r, 4] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(3)), typeof(float));
                    grid5Frez[r, 5] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(4)), typeof(float));
                    grid5Frez[r, 6] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(5)), typeof(float));
                    grid5Frez[r, 7] = new SourceGrid.Cells.Cell(Convert.ToSingle(sqlite_datareader.GetString(6)), typeof(float));
                }
                for (int c = 2; c < 8; c++)
                {
                    grid5Frez[r, c].AddController(clickEvent);//клик мыши
                    grid5Frez[r, c].AddController(rowpointer);//наведение
                    grid5Frez[r, c].Editor.EnableEdit = false;//нередактируемые ячейки
                    grid5Frez[r, c].AddController(new SourceGrid.Cells.Controllers.Unselectable());
                    grid5Frez[r, c].AddController(new MyHelpRowTracking());//help row pointer
                }
            }
            grid5Frez.AutoSizeCells();
            grid5Frez.EnableSort = false;
            grid5Frez.Selection.EnableMultiSelection = false;
            sqlite_conn.Close();
            #endregion
        }
        #endregion
        /// <summary>
        /// Выделяет ячейку
        /// </summary>
        /// <param name="context"></param>
        public void MyCellSelector(CellContext context)
        {
            SourceGrid.Range r3 = new SourceGrid.Range(new Position(0, 0), new Position(context.Grid.Rows.Count, context.Grid.Columns.Count));
            context.Grid.Selection.SelectRange(r3, false);
            context.Grid.Selection.SelectCell(context.Position, true);
        }

        /// <summary>
        /// Происходит при изменении значения ячейки
        /// нужен для задания значения шага при точении резьбы
        /// </summary>
        /// 
        private void CellEvent_Changed(object sender, EventArgs e)
        {
            SourceGrid.CellContext context = (SourceGrid.CellContext)sender;
            try
            {
                s1.IData.s_rezba = Convert.ToSingle(context.Value);
                context.Value = Convert.ToString(s1.IData.s_rezba);
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
        /// Выделяет все ячейки в строке от 
        /// 2й в строке до последней 
        /// </summary>
        public void MyRowSelector(CellContext context)
        {
            SourceGrid.Range r1 = new SourceGrid.Range(new Position(context.Position.Row, 2), new Position(context.Position.Row, context.Grid.Columns.Count));
            SourceGrid.Range r2 = new SourceGrid.Range(new Position(0, 0), new Position(context.Grid.Rows.Count, context.Grid.Columns.Count));
            context.Grid.Selection.SelectRange(r2, false);
            context.Grid.Selection.SelectRange(r1, true);
        }

        /// <summary>
        /// Снимает выделение со всех ячеек всех таблиц
        /// </summary>
        private void ClearAllSelection()
        {
            for (int i = 0; i < tabControl1.TabCount; i++)
            {
                foreach (SourceGrid.Grid SGrid in tabControl1.Controls.Find("grid" + i, true))
                {
                    SourceGrid.Range R = new Range(0, 0, SGrid.Rows.Count, SGrid.Columns.Count);
                    SGrid.Selection.SelectRange(R, false);
                }
            }
        }

        private void ClearAllSelectionFrez()
        {
            for (int i = 0; i < tabControl3.TabCount; i++)
            {
                foreach (SourceGrid.Grid SGrid in tabControl3.Controls.Find("grid" + i + "Frez", true))
                {
                    SourceGrid.Range R = new Range(0, 0, SGrid.Rows.Count, SGrid.Columns.Count);
                    SGrid.Selection.SelectRange(R, false);
                }
            }
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
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox16_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(null, null);
            }
        }

        /// <summary>
        /// Обработчик события клика на ячейку
        /// </summary>
        private void clickEvent_Click(object sender, EventArgs e)
        {
            SourceGrid.CellContext context = (SourceGrid.CellContext)sender;
            if (context.Grid.Handle == grid1.Handle)
            {
                s1.IData.t = Convert.ToSingle(context.Value);
                s1.LCells.grid1 = context;
            }
            if (context.Grid.Handle == grid2.Handle)
            {
                s1.IData.s = Convert.ToSingle(context.Value);
                s1.LCells.grid2 = context;
            }
            if (context.Grid.Handle == grid3.Handle)
            {
                s1.IData.Kmv = Convert.ToSingle(context.Value);
                s1.LCells.grid3 = context;
            }
            if (context.Grid.Handle == grid4.Handle)
            {
                s1.IData.Kpv = Convert.ToSingle(context.Value);
                s1.LCells.grid4 = context;
            }
            if (context.Grid.Handle == grid5.Handle)
            {
                s1.IData.Kiv = Convert.ToSingle(context.Value);
                s1.LCells.grid5 = context;
            }
            if (context.Grid.Handle == grid6.Handle)
            {
                s1.IData.Cv = Convert.ToSingle(grid6[context.Position.Row, 3].Value);
                s1.IData.xv = Convert.ToSingle(grid6[context.Position.Row, 4].Value);
                s1.IData.yv = Convert.ToSingle(grid6[context.Position.Row, 5].Value);
                s1.IData.mv = Convert.ToSingle(grid6[context.Position.Row, 6].Value);
                s1.LCells.grid6 = context;
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
                        s1.IData.s = Convert.ToSingle(s1.LCells.grid2.Value);
                        s1.IData.s_rezba = 0;
                    }
                    catch
                    {
                        s1.IData.s_rezba = 0;
                    }
                }
            }
            if (context.Grid.Handle == grid7.Handle)
            {
                s1.IData.Cp = Convert.ToSingle(grid7[context.Position.Row, 2].Value);
                s1.IData.xp = Convert.ToSingle(grid7[context.Position.Row, 3].Value);
                s1.IData.yp = Convert.ToSingle(grid7[context.Position.Row, 4].Value);
                s1.IData.np = Convert.ToSingle(grid7[context.Position.Row, 5].Value);
                s1.LCells.grid7 = context;
            }
            if (context.Grid.Handle == grid8.Handle)
            {
                s1.IData.Kmp = Convert.ToSingle(context.Value);
                s1.LCells.grid8 = context;
            }

            //Выделение ячеек (они unselectable)

            if ((context.Grid.Handle == grid6.Handle) | (context.Grid.Handle == grid7.Handle))
            {
                MyRowSelector(context);
            }
            //else
            //{
            //    //следующий код необходим для верного выделения (click-drop) иначе 
            //    //click на одной ячейке, select на другой.(+unselectable)
            //    //+решения проблеммы shift+arrow т.е. выделение только при событии click 
            //    MyCellSelector(context);
            //}
            //
            //
            //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            //
            //
            if (context.Grid.Handle == grid1Frez.Handle)
            {
                s3.IData.Cv = Convert.ToSingle(grid1Frez[context.Position.Row, 4].Value);
                s3.IData.qv = Convert.ToSingle(grid1Frez[context.Position.Row, 5].Value);
                s3.IData.xv = Convert.ToSingle(grid1Frez[context.Position.Row, 6].Value);
                s3.IData.yv = Convert.ToSingle(grid1Frez[context.Position.Row, 7].Value);
                s3.IData.uv = Convert.ToSingle(grid1Frez[context.Position.Row, 8].Value);
                s3.IData.pv = Convert.ToSingle(grid1Frez[context.Position.Row, 9].Value);
                s3.IData.mv = Convert.ToSingle(grid1Frez[context.Position.Row, 10].Value);
                s3.LCells.grid1 = context;
            }
            if (context.Grid.Handle == grid2Frez.Handle)
            {
                s3.IData.z = Convert.ToSingle(context.Value);
                s3.LCells.grid2 = context;
            }
            if (context.Grid.Handle == grid3Frez.Handle)
            {
                s3.IData.Kv = Convert.ToSingle(context.Value);
                s3.LCells.grid3 = context;
            }
            if (context.Grid.Handle == grid4Frez.Handle)
            {
                s3.IData.Kp = Convert.ToSingle(context.Value);
                s3.LCells.grid4 = context;
            }
            if (context.Grid.Handle == grid5Frez.Handle)
            {
                s3.IData.Cp = Convert.ToSingle(grid5Frez[context.Position.Row, 2].Value);
                s3.IData.xp = Convert.ToSingle(grid5Frez[context.Position.Row, 3].Value);
                s3.IData.yp = Convert.ToSingle(grid5Frez[context.Position.Row, 4].Value);
                s3.IData.up = Convert.ToSingle(grid5Frez[context.Position.Row, 5].Value);
                s3.IData.qp = Convert.ToSingle(grid5Frez[context.Position.Row, 6].Value);
                s3.IData.wp = Convert.ToSingle(grid5Frez[context.Position.Row, 7].Value);
                s3.LCells.grid5 = context;
                MyRowSelector(context);
            }
            //Выделение ячеек (они unselectable)

            if (context.Grid.Handle == grid5Frez.Handle)
            {
                MyRowSelector(context);
            }
            if (context.Grid.Handle == grid1Frez.Handle)
            {
                MyRowSelector_4(context);
            }
            if ((context.Grid.Handle != grid1Frez.Handle) && (context.Grid.Handle != grid5Frez.Handle) && (context.Grid.Handle != grid6.Handle) && (context.Grid.Handle != grid7.Handle))
            {
                //следующий код необходим для верного выделения (click-drop) иначе 
                //click на одной ячейке, select на другой.(+unselectable)
                //+решения проблеммы shift+arrow т.е. выделение только при событии click 
                if (!((context.Position.Column == 1) && (context.Position.Row > 10) && (context.Grid.Handle == grid1.Handle)))
                {
                    MyCellSelector(context);
                }
            }
        }

        private void tabPage9_Enter(object sender, EventArgs e)
        {
            ClearTab9();
            if (s1.IData.s_rezba != 0)
            {
                s1.IData.s = s1.IData.s_rezba;
            }
            textBox1.Text = Convert.ToString(s1.IData.t);
            textBox2.Text = Convert.ToString(s1.IData.s);
            textBox3.Text = Convert.ToString(s1.IData.Kmv);
            textBox4.Text = Convert.ToString(s1.IData.Kpv);
            textBox5.Text = Convert.ToString(s1.IData.Kiv);
            textBox6.Text = Convert.ToString(s1.IData.Cv);
            textBox7.Text = Convert.ToString(s1.IData.xv);
            textBox8.Text = Convert.ToString(s1.IData.yv);
            textBox9.Text = Convert.ToString(s1.IData.mv);
            textBox10.Text = Convert.ToString(s1.IData.Cp);
            textBox11.Text = Convert.ToString(s1.IData.xp);
            textBox12.Text = Convert.ToString(s1.IData.yp);
            textBox13.Text = Convert.ToString(s1.IData.np);
            textBox15.Text = Convert.ToString(s1.IData.Kmp);
            textBox16.Text = Convert.ToString(s1.IData.D);
            comboBox1.SelectedIndex = s1.CBoxIndex;
            if (s1)
            {

                textBox17.Text = Convert.ToString(s1.V());
                textBox18.Text = Convert.ToString(s1.n());
                textBox19.Text = Convert.ToString(s1.Pz());
                textBox20.Text = Convert.ToString(s1.M());
                textBox21.Text = Convert.ToString(s1.N());
            }
        }

        /// <summary>
        /// Сбрасывает все значения textBox на 9 вкладке
        /// </summary>
        private void ClearTab9()
        {
            comboBox1.SelectedIndex = -1;
            for (int i = 0; i < tabPage9.Controls.Count; i++)
            {
                foreach (TextBox TBox in tabPage9.Controls.Find("textBox" + i, false))
                {
                    TBox.Text = "";
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text != "")
            {
                s1.CBoxIndex = comboBox1.SelectedIndex;
                textBox14.Text = comboBox1.Text;
                s1.IData.T = Convert.ToSingle(comboBox1.Text);
            }
        }
        /// <summary>
        /// кнопка вычисления
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            textBox16.Text = textBox16.Text.Replace(".", ",");

            try
            {
                s1.IData.D = Convert.ToSingle(textBox16.Text);
                if (s1)
                {
                    textBox17.Text = Convert.ToString(s1.V());
                    textBox18.Text = Convert.ToString(s1.n());
                    textBox19.Text = Convert.ToString(s1.Pz());
                    textBox20.Text = Convert.ToString(s1.M());
                    textBox21.Text = Convert.ToString(s1.N());
                }
                else
                {
                    string str = "\n";
                    if (s1.LCells.grid1.Cell == null)
                    {
                        str = str + tabPage1.Text + "\n";
                    }
                    if (s1.LCells.grid2.Cell == null)
                    {
                        str = str + tabPage2.Text + "\n";
                    }
                    if (s1.LCells.grid3.Cell == null)
                    {
                        str = str + tabPage3.Text + "\n";
                    }

                    if (s1.LCells.grid4.Cell == null)
                    {
                        str = str + tabPage4.Text + "\n";
                    }
                    if (s1.LCells.grid5.Cell == null)
                    {
                        str = str + tabPage5.Text + "\n";
                    }
                    if (s1.LCells.grid6.Cell == null)
                    {
                        str = str + tabPage6.Text + "\n";
                    }
                    if (s1.LCells.grid7.Cell == null)
                    {
                        str = str + tabPage7.Text + "\n";
                    }
                    if (s1.LCells.grid8.Cell == null)
                    {
                        str = str + tabPage8.Text + "\n";
                    }

                    if ((s1.IData.D == 0) || (s1.CBoxIndex == -1))
                    {
                        str = str + tabPage9.Text + "\n";
                    }
                    MessageBox.Show("Не все данные выбраны!\nПроверьте вкладки:" + str);
                }
            }
            catch (System.FormatException)
            {
                textBox16.Text = "";
                MessageBox.Show("Ошибка ввода!\n");
            }
        }


        private void comboBox1Frez_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1Frez.Text != "")
            {
                s3.CBoxIndex = comboBox1Frez.SelectedIndex;
                s3.IData.T = Convert.ToSingle(comboBox1Frez.Text);
                comboBox1Frez.SelectedIndex = s3.CBoxIndex;
            }
        }

        private void button2Frez_Click(object sender, EventArgs e)
        {
            textBox1Frez.Text = textBox1Frez.Text.Replace(".", ",");
            textBox2Frez.Text = textBox2Frez.Text.Replace(".", ",");
            textBox3Frez.Text = textBox3Frez.Text.Replace(".", ",");
            textBox10Frez.Text = textBox10Frez.Text.Replace(".", ",");
            try
            {
                s3.IData.t = Convert.ToSingle(textBox1Frez.Text);
                s3.IData.B = Convert.ToSingle(textBox2Frez.Text);
                s3.IData.sz = Convert.ToSingle(textBox3Frez.Text);
                s3.IData.D = Convert.ToSingle(textBox10Frez.Text);
            }
            catch (System.FormatException)
            {
                textBox1Frez.Text = "";
                textBox2Frez.Text = "";
                textBox3Frez.Text = "";
                textBox10Frez.Text = "";
                MessageBox.Show("Ошибка ввода!\n");
            }

        }

        private void textBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button2_Click(null, null);
            }
        }

        private void tabPage7Frez_Enter(object sender, EventArgs e)
        {
            textBox22.Text = Convert.ToString(s3.IData.t);
            textBox23.Text = Convert.ToString(s3.IData.B);
            textBox24.Text = Convert.ToString(s3.IData.sz);
            textBox25.Text = Convert.ToString(s3.IData.D);
            textBox26.Text = Convert.ToString(s3.IData.T);
            textBox27.Text = Convert.ToString(s3.IData.z);
            textBox28.Text = Convert.ToString(s3.IData.Kv);
            textBox29.Text = Convert.ToString(s3.IData.Kp);
            textBox30.Text = Convert.ToString(s3.IData.mv);
            textBox31.Text = Convert.ToString(s3.IData.pv);
            textBox32.Text = Convert.ToString(s3.IData.uv);
            textBox33.Text = Convert.ToString(s3.IData.yv);
            textBox34.Text = Convert.ToString(s3.IData.xv);
            textBox35.Text = Convert.ToString(s3.IData.qv);
            textBox36.Text = Convert.ToString(s3.IData.Cv);
            textBox38.Text = Convert.ToString(s3.IData.wp);
            textBox39.Text = Convert.ToString(s3.IData.up);
            textBox40.Text = Convert.ToString(s3.IData.yp);
            textBox41.Text = Convert.ToString(s3.IData.xp);
            textBox42.Text = Convert.ToString(s3.IData.qp);
            textBox43.Text = Convert.ToString(s3.IData.Cp);
            textBox4Frez.Text = Convert.ToString(s3.V());
            textBox6Frez.Text = Convert.ToString(s3.M());
            textBox7Frez.Text = Convert.ToString(s3.n());
            textBox8Frez.Text = Convert.ToString(s3.Pz());
            textBox9Frez.Text = Convert.ToString(s3.N());

        }


        void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {

        }
        /// <summary>
        /// очистить операцию
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        //ToDoОчистка дерева 
        //i = 0;
        //AList.Clear();
        //treeView1.Nodes[0].Nodes.Clear();
        //ClearAllSelection();
        //ClearTab9();
        //tabControl1.Visible = false;


        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
        public void MyRowSelector_4(CellContext context)
        {
            SourceGrid.Range r1_1 = new SourceGrid.Range(new Position(context.Position.Row, 4), new Position(context.Position.Row, context.Grid.Columns.Count));
            SourceGrid.Range r2_2 = new SourceGrid.Range(new Position(0, 0), new Position(context.Grid.Rows.Count, context.Grid.Columns.Count));
            context.Grid.Selection.SelectRange(r2_2, false);
            context.Grid.Selection.SelectRange(r1_1, true);
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void menu1ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void makeTurningStepToolStripMenuItem_Click(object sender, EventArgs e)
        {
            i++;
            treeView1.BeginUpdate();
            treeView1.Nodes.Add("Переход" + i + " (токарный)");
            treeView1.Nodes[0].Expand();
            treeView1.EndUpdate();
            Step_turning s2 = new Step_turning();//Создаем ЕЩЁ(!) один объект и помещаем его в коллекцию
            //текущий не трогаем(!) а подменяем его только при выборе!!
            AList.Add(s2);
        }

        private void makeFrezStepToolStripMenuItem_Click(object sender, EventArgs e)
        {
            i++;
            treeView1.BeginUpdate();
            treeView1.Nodes.Add("Переход" + i + " (фрезерный)");
            treeView1.Nodes[0].Expand();
            treeView1.EndUpdate();
            Step_frez s2 = new Step_frez();//Создаем ЕЩЁ(!) один объект и помещаем его в коллекцию
            //текущий не трогаем(!) а подменяем его только при выборе!!
            AList.Add(s2);
        }

        private void makeReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Проверка готовности записи в файл
            string str = "";
            for (int i = 0; i < AList.Count; i++)
            {
                try
                {
                    if ((Step_turning)AList[i])//если объект ложный
                    {

                    }
                    else
                    {
                        str = str + treeView1.Nodes[i].Text + "\n";
                    }
                }
                catch
                {
                }
            }
            if (str != "")
            {
                MessageBox.Show("Не все переходы рассчитаны\nПроверьте переходы:\n" + str);
            }
            else
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
                catch (ArgumentException exc)
                {
                    return;
                }

                // Записываем в файл.
                for (int i = 0; i < AList.Count; i++)
                {
                    try
                    {
                        try
                        {
                            Convert.ToString(((Step_turning)AList[i]).V());
                            fstr_out.Write("\r\n           Переход №" + (i + 1) + " (токарный)\r\n");
                            fstr_out.Write("Скорость резания:   ");
                            fstr_out.Write(Convert.ToString(((Step_turning)AList[i]).V()) + " м/с\r\n");
                            fstr_out.Write("Частота вращения:   ");
                            fstr_out.Write(Convert.ToString(((Step_turning)AList[i]).n()) + " об/мин\r\n");
                            fstr_out.Write("Мощность:           ");
                            fstr_out.Write(Convert.ToString(((Step_turning)AList[i]).N()) + " кВт\r\n");
                            fstr_out.Write("Сила резания:       ");
                            fstr_out.Write(Convert.ToString(((Step_turning)AList[i]).Pz()) + " Н\r\n");
                            fstr_out.Write("Момент:             ");
                            fstr_out.Write(Convert.ToString(((Step_turning)AList[i]).M()) + " Нм\r\n");
                        }
                        catch (InvalidCastException)
                        {
                            fstr_out.Write("\r\n           Переход №" + (i + 1) + "(фрезерный)\r\n");
                            fstr_out.Write("Скорость резания:   ");
                            fstr_out.Write(Convert.ToString(((Step_frez)AList[i]).V()) + " м/с\r\n");
                            fstr_out.Write("Частота вращения:   ");
                            fstr_out.Write(Convert.ToString(((Step_frez)AList[i]).n()) + " об/мин\r\n");
                            fstr_out.Write("Мощность:           ");
                            fstr_out.Write(Convert.ToString(((Step_frez)AList[i]).N()) + " кВт\r\n");
                            fstr_out.Write("Сила резания:       ");
                            fstr_out.Write(Convert.ToString(((Step_frez)AList[i]).Pz()) + " Н\r\n");
                            fstr_out.Write("Момент:             ");
                            fstr_out.Write(Convert.ToString(((Step_frez)AList[i]).M()) + " Нм\r\n");
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

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

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
                        tabControl3.Visible = false;
                    }
                    else
                    {
                        treeView1.SelectedNode = treeView1.GetNodeAt(treeView1.GetNodeCount(true), 0);

                    }
                    break;
                }
            }

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //e = (TreeNodeMouseClickEventArgs)e;

            if ((true))
            {
                //Todo Сделать проверку типа
                try
                {
                    DoFullTab6();
                    s1 = (Step_turning)AList[e.Node.Index];//подмена s1 тем значением который записан в Alist на индексе соответствующем, индексу NODE 
                    tabControl3.Visible = false;
                    tabControl1.Visible = true;
                    tabControl2.Visible = false;
                    this.Text = "Калькулятор режимов резания: " + e.Node.Text;
                    comboBox1.SelectedIndex = -1;
                    if (tabControl1.SelectedIndex == 8)
                    {
                        tabPage9_Enter(null, null);
                    }
                    ClearAllSelection();//почистить выделение всех ячеек всех гридов
                    tabControl1.Visible = true;
                    s1.ReturnSelect();
                }

                catch (InvalidCastException)
                {
                    try
                    {
                        s3 = (Step_frez)AList[e.Node.Index];//подмена s1 тем значением который записан в Alist на индексе соответствующем, индексу NODE 
                        tabControl3.Visible = true;
                        tabControl1.Visible = false;
                        tabControl2.Visible = false;
                        this.Text = "Калькулятор режимов резания: " + e.Node.Text;
                        //comboBox1.SelectedIndex = -1;
                        if (tabControl1.SelectedIndex == 8)
                        {
                            tabPage7Frez_Enter(null, null);
                        }
                        ClearAllSelectionFrez();//почистить выделение всех ячеек всех гридов
                        //tabControl1.Visible = true;
                        s3.ReturnSelect();
                    }
                    catch (InvalidCastException)
                    {

                        s4 = (Step_drill)AList[e.Node.Index];//подмена s1 тем значением который записан в Alist на индексе соответствующем, индексу NODE 
                        tabControl3.Visible = false;
                        tabControl1.Visible = false;
                        tabControl2.Visible = true;
                        this.Text = "Калькулятор режимов резания: " + e.Node.Text;
                        //comboBox1.SelectedIndex = -1;
                        //if (tabControl1.SelectedIndex == 8)
                        //{
                        //    tabPage7Frez_Enter(null, null);
                        //}
                        //ClearAllSelectionFrez();//почистить выделение всех ячеек всех гридов
                        ////tabControl1.Visible = true;
                        //s3.ReturnSelect();

                    }
                }
            }
        }

        private void создатьСверлильныйПереходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            i++;
            treeView1.BeginUpdate();
            treeView1.Nodes.Add("Переход" + i + " (сверлильный)");
            treeView1.Nodes[0].Expand();
            treeView1.EndUpdate();
            Step_drill s2 = new Step_drill();//Создаем ЕЩЁ(!) один объект и помещаем его в коллекцию
            //текущий не трогаем(!) а подменяем его только при выборе!!
            AList.Add(s2);
        }
    }
}
