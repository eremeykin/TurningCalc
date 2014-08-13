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

namespace Project
{
    public partial class Form2 : Form
    {
        public void Form1_Load(object sender, EventArgs e)
        {

        }
        public Form2()
        {
            InitializeComponent();
            CustomInitialization();
            tabControl1Frez.Visible = false;
            //button1.Visible = true;
        }
        private void CustomInitialization()
        {
            i = 0;
            s1 = new Step_frez();
            //ToDo переместить на место
            AList = new ArrayList();
            cellpointer = new MyCellTracking();
            rowpointer = new MyRowTrecking();
            clickEvent = new SourceGrid.Cells.Controllers.CustomEvents();
            clickEvent.Click += new EventHandler(clickEvent_Click);
        }
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
        /// Выделяет все ящейки в строке от 
        /// 2й в строке до последней 
        /// </summary>
        public void MyRowSelector(CellContext context)
        {
            SourceGrid.Range r1 = new SourceGrid.Range(new Position(context.Position.Row, 2), new Position(context.Position.Row, context.Grid.Columns.Count));
            SourceGrid.Range r2 = new SourceGrid.Range(new Position(0, 0), new Position(context.Grid.Rows.Count, context.Grid.Columns.Count));
            context.Grid.Selection.SelectRange(r2, false);
            context.Grid.Selection.SelectRange(r1, true);
        }
        public void MyRowSelector_4(CellContext context)
        {
            SourceGrid.Range r1_1 = new SourceGrid.Range(new Position(context.Position.Row, 4), new Position(context.Position.Row, context.Grid.Columns.Count));
            SourceGrid.Range r2_2 = new SourceGrid.Range(new Position(0, 0), new Position(context.Grid.Rows.Count, context.Grid.Columns.Count));
            context.Grid.Selection.SelectRange(r2_2, false);
            context.Grid.Selection.SelectRange(r1_1, true);
        }

        /// <summary>
        /// Снимает выделение со всех ячеек всех таблиц
        /// </summary>
        private void ClearAllSelection()
        {
            for (int i = 0; i < tabControl1Frez.TabCount; i++)
            {
                foreach (SourceGrid.Grid SGrid in tabControl1Frez.Controls.Find("grid" + i, true))
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
                DevAge.Drawing.ContentAlignment ca = new DevAge.Drawing.ContentAlignment();
                ca = DevAge.Drawing.ContentAlignment.MiddleCenter;
                cellView.TextAlignment = ca;
                sender.Cell.View = cellView;
                sender.Grid.InvalidateCell(sender.Position);
            }
            public
                override void OnMouseLeave(SourceGrid.CellContext sender, EventArgs e)
            {
                cellView = new SourceGrid.Cells.Views.Cell();
                cellView.Background = new DevAge.Drawing.VisualElements.BackgroundSolid(Color.White);
                DevAge.Drawing.ContentAlignment ca = new DevAge.Drawing.ContentAlignment();
                ca = DevAge.Drawing.ContentAlignment.MiddleCenter;
                cellView.TextAlignment = ca;
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
                DevAge.Drawing.ContentAlignment ca = new DevAge.Drawing.ContentAlignment();
                ca = DevAge.Drawing.ContentAlignment.MiddleCenter;
                cellView.TextAlignment = ca;
                for (int c = 0; c < sender.Grid.Columns.Count; c++)
                {
                    if (Convert.ToString(sender.Grid.GetCell(new Position(sender.Position.Row, c)).GetType()) == "SourceGrid.Cells.Cell")
                    {
                        //sender.Grid.GetCell(new Position(sender.Position.Row, c)).View.TextAlignment = DevAge.Drawing.ContentAlignment.MiddleCenter;

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
                DevAge.Drawing.ContentAlignment ca = new DevAge.Drawing.ContentAlignment();
                ca = DevAge.Drawing.ContentAlignment.MiddleCenter;
                cellView.TextAlignment = ca;
                for (int c = 0; c < sender.Grid.Columns.Count; c++)
                {
                    if (Convert.ToString(sender.Grid.GetCell(new Position(sender.Position.Row, c)).GetType()) == "SourceGrid.Cells.Cell")
                    {
                        sender.Grid.GetCell(new Position(sender.Position.Row, c)).View.TextAlignment = DevAge.Drawing.ContentAlignment.MiddleCenter;
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
                DevAge.Drawing.ContentAlignment ca = new DevAge.Drawing.ContentAlignment();
                ca = DevAge.Drawing.ContentAlignment.MiddleCenter;
                cellView.TextAlignment = ca;
                for (int c = 0; c < sender.Grid.Columns.Count; c++)
                {
                    if (Convert.ToString(sender.Grid.GetCell(new Position(sender.Position.Row, c)).GetType()) != "SourceGrid.Cells.Cell")
                    {
                        //sender.Grid.GetCell(new Position(sender.Position.Row, c)).View.TextAlignment = ca;
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
                DevAge.Drawing.ContentAlignment ca = new DevAge.Drawing.ContentAlignment();
                ca = DevAge.Drawing.ContentAlignment.MiddleCenter;
                cellView.TextAlignment = ca;
                for (int c = 0; c < sender.Grid.Columns.Count; c++)
                {
                    if (Convert.ToString(sender.Grid.GetCell(new Position(sender.Position.Row, c)).GetType()) != "SourceGrid.Cells.Cell")
                    {
                        sender.Grid.GetCell(new Position(sender.Position.Row, c)).View.TextAlignment = ca;

                        sender.Grid.GetCell(new Position(sender.Position.Row, c)).View = cellView;
                        sender.Grid.InvalidateCell(new Position(sender.Position.Row, c));
                    }
                }
            }
        }
        private void clickEvent_Click(object sender, EventArgs e)
        {
            SourceGrid.CellContext context = (SourceGrid.CellContext)sender;
            if (context.Grid.Handle == grid1Frez.Handle)
            {
                //ToDo ???можно заменить на public void CeptureCell() и закрыть private все поля в классе Step
                //а метод CeptureCell() будет загонять в поле IData и LCells необходимые значения
                s1.IData.Cv = Convert.ToSingle(grid1Frez[context.Position.Row, 4].Value);
                s1.IData.qv = Convert.ToSingle(grid1Frez[context.Position.Row, 5].Value);
                s1.IData.xv = Convert.ToSingle(grid1Frez[context.Position.Row, 6].Value);
                s1.IData.yv = Convert.ToSingle(grid1Frez[context.Position.Row, 7].Value);
                s1.IData.uv = Convert.ToSingle(grid1Frez[context.Position.Row, 8].Value);
                s1.IData.pv = Convert.ToSingle(grid1Frez[context.Position.Row, 9].Value);
                s1.IData.mv = Convert.ToSingle(grid1Frez[context.Position.Row, 10].Value);
                s1.LCells.grid1 = context;
            }
            if (context.Grid.Handle == grid2Frez.Handle)
            {
                s1.IData.z = Convert.ToSingle(context.Value);
                s1.LCells.grid2 = context;
            }
            if (context.Grid.Handle == grid3Frez.Handle)
            {
                s1.IData.Kv = Convert.ToSingle(context.Value);
                s1.LCells.grid3 = context;
            }
            if (context.Grid.Handle == grid4Frez.Handle)
            {
                s1.IData.Kp = Convert.ToSingle(context.Value);
                s1.LCells.grid4 = context;
            }
            if (context.Grid.Handle == grid5Frez.Handle)
            {
                s1.IData.Cp = Convert.ToSingle(grid5Frez[context.Position.Row, 2].Value);
                s1.IData.xp = Convert.ToSingle(grid5Frez[context.Position.Row, 3].Value);
                s1.IData.yp = Convert.ToSingle(grid5Frez[context.Position.Row, 4].Value);
                s1.IData.up = Convert.ToSingle(grid5Frez[context.Position.Row, 5].Value);
                s1.IData.qp = Convert.ToSingle(grid5Frez[context.Position.Row, 6].Value);
                s1.IData.wp = Convert.ToSingle(grid5Frez[context.Position.Row, 7].Value);
                s1.LCells.grid5 = context;
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
            if ((context.Grid.Handle != grid1Frez.Handle) && (context.Grid.Handle != grid5Frez.Handle))
            {
                //следующий код необходим для верного выделения (click-drop) иначе 
                //click на одной ячейке, select на другой.(+unselectable)
                //+решения проблеммы shift+arrow т.е. выделение только при событии click 
                MyCellSelector(context);
            }
        }
        public void button1_Click(object sender, EventArgs e)
        {
            tabControl1Frez.Visible = true;
            CustomInitialization();
            DoFullTab1_frez();
            DoFullTab2_frez();
            DoFullTab3_frez();
            DoFullTab4_frez();
            DoFullTab5_frez();
            button1.Visible = false;
        }
        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button2_Click(null, null);
            }
        }
        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button2_Click(null, null);
            }
        }
        private void textBox3_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button2_Click(null, null);
            }
        }
        private void textBox10_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button2_Click(null, null);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1Frez.Text = textBox1Frez.Text.Replace(".", ",");
            textBox2Frez.Text = textBox2Frez.Text.Replace(".", ",");
            textBox2Frez.Text = textBox2Frez.Text.Replace(".", ",");
            textBox10Frez.Text = textBox10Frez.Text.Replace(".", ",");
            try
            {
                s1.IData.t = Convert.ToSingle(textBox1Frez.Text);
                s1.IData.B = Convert.ToSingle(textBox2Frez.Text);
                s1.IData.sz = Convert.ToSingle(textBox3Frez.Text);
                s1.IData.D = Convert.ToSingle(textBox10Frez.Text);
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
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1Frez.Text != "")
            {
                s1.CBoxIndex = comboBox1Frez.SelectedIndex;
                s1.IData.T = Convert.ToSingle(comboBox1Frez.Text);
                comboBox1Frez.SelectedIndex = s1.CBoxIndex;
            }
        }
        private void tabPage7_Enter(object sender, EventArgs e)
        {
            ClearTab9();
            textBox4Frez.Text = Convert.ToString(s1.V());
            textBox5Frez.Text = Convert.ToString(s1.Sm());
            textBox6Frez.Text = Convert.ToString(s1.M());
            textBox7Frez.Text = Convert.ToString(s1.n());
            textBox8Frez.Text = Convert.ToString(s1.Pz());
            textBox9Frez.Text = Convert.ToString(s1.N());
        }
        private void ClearTab9()
        {
            comboBox1Frez.SelectedIndex = -1;
            for (int i = 4; i < 10; i++)
            {
                foreach (TextBox TBox in tabPage7Frez.Controls.Find("textBox" + i, false))
                {
                    TBox.Text = "";
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClearTab9();
            textBox4Frez.Text = Convert.ToString(s1.V());
            textBox5Frez.Text = Convert.ToString(s1.Sm());
            textBox6Frez.Text = Convert.ToString(s1.M());
            textBox7Frez.Text = Convert.ToString(s1.n());
            textBox8Frez.Text = Convert.ToString(s1.Pz());
            textBox9Frez.Text = Convert.ToString(s1.N());
        }
    }

}