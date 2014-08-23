using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SourceGrid;

namespace My_Cal
{
    /// <summary>
    /// Содерхит полезные статические методы
    /// </summary>
    class Utils
    {
        /// <summary>
        /// Выделяет ячейку
        /// </summary>
        public static void CellSelector(SourceGrid.CellContext context)
        {
            if (context.Grid != null)
            {
                SourceGrid.Range range = new SourceGrid.Range(new SourceGrid.Position(0, 0), new SourceGrid.Position(context.Grid.Rows.Count, context.Grid.Columns.Count));
                context.Grid.Selection.SelectRange(range, false);
                context.Grid.Selection.SelectCell(context.Position, true);
            }
        }

        /// <summary>
        /// Выделяет строку
        /// </summary>
        public static void RowSelector(SourceGrid.CellContext context)
        {
            if (context.Grid != null)
            {
                int c = 0;
                for (c = 0; c < context.Grid.Columns.Count; c++)
                {
                    if (!(context.Grid.GetCell(context.Position.Row, c) is ColumnHeader || context.Grid.GetCell(context.Position.Row, c) is SourceGrid.Cells.RowHeader))
                        break;
                }
                SourceGrid.Range r1 = new SourceGrid.Range(new SourceGrid.Position(context.Position.Row, c), new SourceGrid.Position(context.Position.Row, context.Grid.Columns.Count));
                SourceGrid.Range r2 = new SourceGrid.Range(new SourceGrid.Position(0, 0), new SourceGrid.Position(context.Grid.Rows.Count, context.Grid.Columns.Count));
                context.Grid.Selection.SelectRange(r2, false);
                context.Grid.Selection.SelectRange(r1, true);
            }
        }

        /// <summary>
        /// Снимает выделение со всех ячеек
        /// </summary>
        /// <param name="f"></param>
        public static void ClearAllSelection(Form1 f)
        {
            for (int t = 1; t < 4; t++)
            {
                foreach (TabControl tc in f.Controls.Find("tabControl" + t, true))
                {
                    for (int i = 0; i < tc.TabCount+20; i++)
                    {
                        foreach (SourceGrid.Grid SGrid in tc.Controls.Find("grid" + i, true))
                        {
                            SourceGrid.Range R = new SourceGrid.Range(0, 0, SGrid.Rows.Count, SGrid.Columns.Count);
                            SGrid.Selection.SelectRange(R, false);
                        }
                        foreach (SourceGrid.Grid SGrid in tc.Controls.Find("grid" + i + "Mill", true))
                        {
                            SourceGrid.Range R = new SourceGrid.Range(0, 0, SGrid.Rows.Count, SGrid.Columns.Count);
                            SGrid.Selection.SelectRange(R, false);
                        }
                    }
                }
            }
        }

    }
}
