using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Cal
{
    public abstract class Step 
    {
        /// <summary>
        ///  
        /// </summary>
        private System.Collections.ArrayList linkedCells = new System.Collections.ArrayList();

        /// <summary>
        /// Выделяет ячейку
        /// </summary>
        protected static void CellSelector(SourceGrid.CellContext context)
        {
            SourceGrid.Range range = new SourceGrid.Range(new SourceGrid.Position(0, 0), new SourceGrid.Position(context.Grid.Rows.Count, context.Grid.Columns.Count));
            context.Grid.Selection.SelectRange(range, false);
            context.Grid.Selection.SelectCell(context.Position, true);
        }

        /// <summary>
        /// Инкапсулирует получение связанных ячеек
        /// </summary>
        public SourceGrid.CellContext getLCell(int i)
        {
            return (SourceGrid.CellContext)this.linkedCells[i];
        }

        /// <summary>
        /// Инкупсулирует запись связанных ячеек
        /// </summary>
        public void setLCell(int i, SourceGrid.CellContext cellContext)
        {
            this.linkedCells[i] = cellContext;
        }

        /// <summary>
        /// Вычисляет все выходные параметры
        /// </summary>
        protected abstract bool calc_all();

        /// <summary>
        /// Сбрасывает выделение ячеек
        /// </summary>
        protected abstract void ReturnSelect();

        /// <summary>
        /// Выделяет строку
        /// </summary>
         protected abstract void RowSelector(SourceGrid.CellContext context);

        /// <summary>
        /// Возвращает момент на шпинделе
        /// </summary>
        protected abstract float getM();

        /// <summary>
        /// Возвращает потребляемую мощность
        /// </summary>
        protected abstract float getN();

        /// <summary>
        /// Возвращает частоту вращения шпинделя
        /// </summary>
        protected abstract float getn();

        /// <summary>
        /// Возвращает скорость резания
        /// </summary>
        protected abstract float getV();

        /// <summary>
        /// Класс для хранения входных данных
        /// </summary>
        public abstract class InputData
        {
            /// <summary>
            /// диаметр поверхности
            /// </summary>
            public float D;
            /// <summary>
            /// глубина резания
            /// </summary>
            public float t;
            /// <summary>
            /// период стойкости резца
            /// </summary>
            public float T;
            /// <summary>
            /// подача (для фрезерования подача на зуб)
            /// </summary>
            public float s;
        }

        /// <summary>
        /// Класс для хранения выходных данных
        /// </summary>
        public abstract class OutputData
        {
            /// <summary>
            /// частота вращенния шпинделя
            /// </summary>
            public float n;
            /// <summary>
            /// скорость резания
            /// </summary>
            public float V;
            /// <summary>
            /// сила резания
            /// </summary>
            public float Pz;
            /// <summary>
            /// момент резания
            /// </summary>
            public float M;
            /// <summary>
            /// мощность резания
            /// </summary>
            public float N;
        }



    }
}
