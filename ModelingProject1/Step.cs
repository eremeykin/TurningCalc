using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Cal
{
    //ToDo написать класс фрезерного перехода
    /// <summary>
    /// Токарный переход
    /// </summary>
    public class Step
    {
        /// <summary>
        /// Объект считается истиным когда выбраны ВСЕ необходимые данные
        /// </summary>
        /// <param name="sp"></param>
        /// <returns></returns>
        public static bool operator true(Step sp)
        {
            if ((sp.LCells.grid1.Cell != null) && (sp.LCells.grid2.Cell != null) && (sp.LCells.grid3.Cell != null) && (sp.LCells.grid4.Cell != null) && (sp.LCells.grid5.Cell != null) && (sp.LCells.grid6.Cell != null) && (sp.LCells.grid7.Cell != null) && (sp.LCells.grid8.Cell != null)&&(sp.IData.D!=0)&&(sp.CBoxIndex!=-1))
                return true;
            else return false;
        }
        /// <summary>
        /// Объект считается ложным когда НЕ выбраны ВСЕ необходимые данные
        /// Перергузка 
        /// </summary>
        /// <param name="sp"></param>
        /// <returns></returns>
        public static bool operator false(Step sp)
        {
            if ((sp.LCells.grid1.Cell != null) || (sp.LCells.grid2.Cell != null) || (sp.LCells.grid3.Cell != null) || (sp.LCells.grid4.Cell != null) || (sp.LCells.grid5.Cell != null) || (sp.LCells.grid6.Cell != null) || (sp.LCells.grid7.Cell != null) || (sp.LCells.grid8.Cell != null) || (sp.IData.D != 0) || (sp.CBoxIndex != -1))
                return true;
            else return false;
        }
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
        /// Хранит номер индекса в ComboBox
        /// </summary>
        public int CBoxIndex=-1;
        /// <summary>
        /// Вычисляет все выходные параметры
        /// </summary>
        private bool calc_all()
        {
            if (((float)(Math.Pow(IData.T, IData.mv)) * ((float)(Math.Pow(IData.t, IData.xv))) * ((float)(Math.Pow(IData.s, IData.yv)))) !=0 && (((float)Math.PI * IData.D)) != 0)
            {
                OData.V = (IData.Cv * IData.Kmv * IData.Kpv * IData.Kiv) / ((float)(Math.Pow(IData.T, IData.mv)) * ((float)(Math.Pow(IData.t, IData.xv))) * ((float)(Math.Pow(IData.s, IData.yv))));
                OData.Pz = 100 * IData.Cp * ((float)Math.Pow(IData.t, IData.xp)) * ((float)Math.Pow(IData.s, IData.yp)) * ((float)Math.Pow(OData.V, IData.np)) * IData.Kmp;
                OData.M = OData.Pz * (IData.D / 2);
                OData.N = (OData.Pz * OData.V) / (1020 * 60);
                OData.n = (1000 * OData.V) / ((float)Math.PI * IData.D);
                return true;
            }
            else
                return false;
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

        public void ReturnSelect()
        {
            if (LCells.grid1.Cell != null)
                CellSelector(LCells.grid1);
            if (LCells.grid2.Cell != null)
                CellSelector(LCells.grid2);
            if (LCells.grid3.Cell != null)
                CellSelector(LCells.grid3);
            if (LCells.grid4.Cell != null)
                CellSelector(LCells.grid4);
            if (LCells.grid5.Cell != null)
                CellSelector(LCells.grid5);
            if (LCells.grid6.Cell != null)
                RowSelector(LCells.grid6);
            if (LCells.grid7.Cell != null)
                RowSelector(LCells.grid7);
            if (LCells.grid8.Cell != null)
                CellSelector(LCells.grid8);
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

        public class InputData
        {
            /// <summary>
            /// глубина резания
            /// </summary>
            public float t;
            /// <summary>
            /// подача
            /// </summary>
            public float s;
            /// <summary>
            /// поправка на материал детали
            /// </summary>
            public float Kmv;
            /// <summary>
            /// поправка на состояние поверхности
            /// </summary>
            public float Kpv;
            /// <summary>
            /// поправка на инструментальный материал
            /// </summary>
            public float Kiv;
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
            public float np;
            /// <summary>
            /// поправка на обрабатываемый материал
            /// </summary>
            public float Kmp;
            /// <summary>
            /// диаметр поверхности
            /// </summary>
            public float D;
            /// <summary>
            /// период стойкости резца
            /// </summary>
            public float T;
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
        }
        //ToDo Написать класс
        public class LinkedCells
        {
            public SourceGrid.CellContext grid1;
            public SourceGrid.CellContext grid2;
            public SourceGrid.CellContext grid3;
            public SourceGrid.CellContext grid4;
            public SourceGrid.CellContext grid5;
            public SourceGrid.CellContext grid6;
            public SourceGrid.CellContext grid7;
            public SourceGrid.CellContext grid8;

        }
    }
}
