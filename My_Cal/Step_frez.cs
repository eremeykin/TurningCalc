using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Cal
{
    public class Step_Mill
    {
        /// <summary>
        /// Входные данные
        /// </summary>
        public InputData IData = new InputData();
        /// <summary>
        /// Выходные данные
        /// </summary>
        private OutputData OData = new OutputData();
        /// <summary>
        /// Хранит данные для возврата выбора ячеек
        /// </summary>
        public LinkedCells LCells = new LinkedCells();
        /// <summary>
        /// Вычисляет все выходные параметры
        /// </summary>
        public int CBoxIndex = -1;
        public void ReturnSelect()
        {
            if (LCells.grid1.Cell != null)
                RowSelector_4(LCells.grid1);
            if (LCells.grid2.Cell != null)
                CellSelector(LCells.grid2);
            if (LCells.grid3.Cell != null)
                CellSelector(LCells.grid3);
            if (LCells.grid4.Cell != null)
                CellSelector(LCells.grid4);
            if (LCells.grid5.Cell != null)
                RowSelector(LCells.grid5);
        }
        private bool calc_all()
        {
            if (((float)(Math.Pow(IData.T, IData.mv)) * ((float)(Math.Pow(IData.t, IData.xv))) * ((float)(Math.Pow(IData.sz, IData.yv)))) != 0 && (((float)Math.Pow(IData.B, IData.uv)) != 0))
            {
                OData.V = (IData.Cv * IData.Kv * (float)Math.Pow(IData.D, IData.qv)) / ((float)(Math.Pow(IData.T, IData.mv)) * ((float)(Math.Pow(IData.t, IData.xv))) * ((float)(Math.Pow(IData.sz, IData.yv))) * ((float)(Math.Pow(IData.B, IData.uv))) * ((float)(Math.Pow(IData.z, IData.pv))));
                OData.n = (1000 * OData.V) / ((float)Math.PI * IData.D);
                OData.Pz = (10 * IData.Cp * ((float)Math.Pow(IData.t, IData.xp)) * ((float)Math.Pow(IData.sz, IData.yp)) * ((float)Math.Pow(IData.B, IData.up)) * IData.z) / (((float)Math.Pow(IData.D, IData.qp)) * ((float)Math.Pow(OData.n, IData.wp)));
                OData.M = OData.Pz * (IData.D / 200);
                OData.N = (OData.Pz * OData.V) / (1020 * 60);
                OData.Sm = IData.sz * IData.z * OData.n;
                return true;
            }
            else
                return false;
        }
        private void CellSelector(SourceGrid.CellContext context)
        {
            SourceGrid.Range r3 = new SourceGrid.Range(new SourceGrid.Position(0, 0), new SourceGrid.Position(context.Grid.Rows.Count, context.Grid.Columns.Count));
            context.Grid.Selection.SelectRange(r3, false);
            context.Grid.Selection.SelectCell(context.Position, true);
        }

        private void RowSelector(SourceGrid.CellContext context)
        {
            SourceGrid.Range r1 = new SourceGrid.Range(new SourceGrid.Position(context.Position.Row, 2), new SourceGrid.Position(context.Position.Row, context.Grid.Columns.Count));
            SourceGrid.Range r2 = new SourceGrid.Range(new SourceGrid.Position(0, 0), new SourceGrid.Position(context.Grid.Rows.Count, context.Grid.Columns.Count));
            context.Grid.Selection.SelectRange(r2, false);
            context.Grid.Selection.SelectRange(r1, true);
        }
        private void RowSelector_4(SourceGrid.CellContext context)
        {
            SourceGrid.Range r1_1 = new SourceGrid.Range(new SourceGrid.Position(context.Position.Row, 4), new SourceGrid.Position(context.Position.Row, context.Grid.Columns.Count));
            SourceGrid.Range r2_2 = new SourceGrid.Range(new SourceGrid.Position(0, 0), new SourceGrid.Position(context.Grid.Rows.Count, context.Grid.Columns.Count));
            context.Grid.Selection.SelectRange(r2_2, false);
            context.Grid.Selection.SelectRange(r1_1, true);
        }
        /// <summary>
        /// Возвращает скорость резания текущего перехода
        /// </summary>
        /// <returns></returns>
        public float V()
        {
            if (calc_all())
                return OData.V;
            else
                return 0;
        }
        /// <summary>
        /// Возвращает силу резания текущего перехода
        /// </summary>
        /// <returns></returns>
        public float Pz()
        {
            if (calc_all())
                return OData.Pz;
            else
                return 0;
        }
        /// <summary>
        /// Возвращает момент резания текущего перехода
        /// </summary>
        /// <returns></returns>
        public float M()
        {
            if (calc_all())
                return OData.M;
            else return 0;
        }
        /// <summary>
        /// Возвращает мощность текущего перехода
        /// </summary>
        /// <returns></returns>
        public float N()
        {
            if (calc_all())
                return OData.N;
            else
                return 0;
        }
        /// <summary>
        /// Возвращает частоту вращения текущего перехода
        /// </summary>
        /// <returns></returns>
        public float n()
        {
            if (calc_all())
                return OData.n;
            else
                return 0;
        }
        /// <summary>
        /// Возвращает минутную подачу
        /// </summary>
        /// <returns></returns>
        public float Sm()
        {
            if (calc_all())
                return OData.Sm;
            else
                return 0;
        }
        public class InputData
        {
            #region Основные параметры
            /// <summary>
            /// глубина резания
            /// </summary>
            public float t;
            /// <summary>
            /// подача на один зуб фрезы
            /// </summary>
            public float sz;
            /// <summary>
            /// Ширина фрезы
            /// </summary>
            public float B;
            /// <summary>
            /// Диаметр фрезы
            /// </summary>
            public float D;
            /// <summary>
            /// Количество зубьев фрезы
            /// </summary>
            public float z;
            /// <summary>
            /// период стойкости фрезы
            /// </summary>
            public float T;
            #endregion
            #region Параметры для определения скорости резания
            /// <summary>
            /// Поправочный коэффициент
            /// </summary>
            public float Kv;
            /// <summary>
            /// эмпирический коэффициент параметра V
            /// </summary>
            public float qv;
            /// <summary>
            /// эмпирический коэффициент параметра V
            /// </summary>
            public float Cv;
            /// <summary>
            /// эмпирический коэффициент параметра V
            /// </summary>
            public float xv;
            /// <summary>
            /// эмпирический коэффициент параметра V
            /// </summary>
            public float yv;
            /// <summary>
            /// эмпирический коэффициент параметра V
            /// </summary>
            public float mv;
            /// <summary>
            /// эмпирический коэффициент параметра V
            /// </summary>
            public float uv;
            /// <summary>
            /// эмпирический коэффициент параметра V
            /// </summary>
            public float pv;
            #endregion
            #region Параметры для определения мощности
            /// <summary>
            /// эмпирический коэффициент параметра Pz
            /// </summary>
            public float Cp;
            /// <summary>
            /// эмпирический коэффициент параметра Pz
            /// </summary>
            public float xp;
            /// <summary>
            /// эмпирический коэффициент параметра Pz
            /// </summary>
            public float yp;
            /// <summary>
            /// эмпирический коэффициент параметра Pz
            /// </summary>
            public float up;
            /// <summary>
            /// поправка на обрабатываемый материал
            /// </summary>
            public float Kp;
            /// <summary>
            /// поправка на обрабатываемый материал
            /// </summary>
            public float qp;
            /// <summary>
            /// поправка на обрабатываемый материал
            /// </summary>
            public float wp;
            #endregion

        }

        private class OutputData
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
            /// <summary>
            /// минутная подача
            /// </summary>
            public float Sm;
        }
        //ToDo Написать класс
        public class LinkedCells
        {
            public SourceGrid.CellContext grid1;
            public SourceGrid.CellContext grid2;
            public SourceGrid.CellContext grid3;
            public SourceGrid.CellContext grid4;
            public SourceGrid.CellContext grid5;
        }
    }
}
