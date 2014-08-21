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
        private SourceGrid.CellContext[] linkedCells = new SourceGrid.CellContext[9];

        /// <summary>
        /// Инкапсулирует получение связанных ячеек
        /// </summary>
        public SourceGrid.CellContext getLCell(int i)
        {
                return (SourceGrid.CellContext)this.linkedCells[i];
        }

        public bool checkLCell(int i)
        {
            try
            {
                SourceGrid.CellContext c =(SourceGrid.CellContext)this.linkedCells[i];
                return true;
            }
            catch (ArgumentOutOfRangeException)
            {
                return false;
            }
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
        public abstract void ReturnSelect();


        /// <summary>
        /// Возвращает момент на шпинделе
        /// </summary>
        public abstract float getM();

        /// <summary>
        /// Возвращает потребляемую мощность
        /// </summary>
        public abstract float getN();

        /// <summary>
        /// Возвращает частоту вращения шпинделя
        /// </summary>
        public abstract float getn();

        /// <summary>
        /// Возвращает скорость резания
        /// </summary>
        public abstract float getV();

        /// <summary>
        /// Возвращает силу резания
        /// </summary>
        public abstract float getPz();

        /// <summary>
        /// Класс для хранения входных данных
        /// </summary>
        /// TODO заменить public на  private внутри
        /// 
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
