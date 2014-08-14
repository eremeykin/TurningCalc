using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Cal
{
    class TurningStep : Step
    {

        /// <summary>
        /// Поле для хранения входных данных
        /// </summary>
        public TurningInptuData inputData = new TurningInptuData();

        /// <summary>
        /// Поле для хранения выходных данных
        /// </summary>
        public TurningOutputData outputData = new TurningOutputData();

        public static bool operator true(TurningStep st)
        {
            for (int i = 1; i < 9; i++)
            {
                if (st.getLCell(i) == null)
                    return false;
            }
            if (st.inputData.D == 0 || st.inputData.T == 0)
                return false;
            return true;
        }

        public static bool operator false(TurningStep st)
        {
            if (st)
            {
                return true;
            }
            return false;
        }

        protected override bool calc_all()
        {
            if (((float)(Math.Pow(inputData.T, inputData.mv)) * ((float)(Math.Pow(inputData.t, inputData.xv))) * ((float)(Math.Pow(inputData.s, inputData.yv)))) != 0 && (((float)Math.PI * inputData.D)) != 0)
            {
                outputData.V = (inputData.Cv * inputData.Kmv * inputData.Kpv * inputData.Kiv) / ((float)(Math.Pow(inputData.T, inputData.mv)) * ((float)(Math.Pow(inputData.t, inputData.xv))) * ((float)(Math.Pow(inputData.s, inputData.yv))));
                outputData.Pz = 10 * inputData.Cp * ((float)Math.Pow(inputData.t, inputData.xp)) * ((float)Math.Pow(inputData.s, inputData.yp)) * ((float)Math.Pow(outputData.V, inputData.np)) * inputData.Kmp;
                outputData.M = outputData.Pz * (inputData.D / (2 * 1000));
                outputData.N = (outputData.Pz * outputData.V) / (1020 * 60);
                outputData.n = (1000 * outputData.V) / ((float)Math.PI * inputData.D);
                return true;
            }
            else
                return false;
        }

        protected override float getV()
        {
            if (calc_all())
                return outputData.V;
            else
                return 0;
        }

        protected override float getM()
        {

            if (calc_all())
                return outputData.M;
            else return 0;
        }

        protected override float getN()
        {
            if (calc_all())
                return outputData.N;
            else
                return 0;
        }

        protected override float getn()
        {
            if (calc_all())
                return outputData.n;
            else
                return 0;
        }

        protected override void RowSelector(SourceGrid.CellContext context)
        {
            SourceGrid.Range r1 = new SourceGrid.Range(new SourceGrid.Position(context.Position.Row, 2), new SourceGrid.Position(context.Position.Row, context.Grid.Columns.Count));
            SourceGrid.Range r2 = new SourceGrid.Range(new SourceGrid.Position(0, 0), new SourceGrid.Position(context.Grid.Rows.Count, context.Grid.Columns.Count));
            context.Grid.Selection.SelectRange(r2, false);
            context.Grid.Selection.SelectRange(r1, true);
        }

        protected override void ReturnSelect()
        {
            for (int i = 1; i < 9; i++)
            {
                if (i != 6)
                {
                    if (getLCell(i) != null)
                        CellSelector(getLCell(i));
                }
                else
                {
                    RowSelector(getLCell(i));
                    if(getLCell(i).Position.Row == 7 || getLCell(i).Position.Row == 8 || getLCell(i).Position.Row == 14)
                    {
                    SourceGrid.Position P = new SourceGrid.Position(getLCell(i).Position.Row, 2);
                    ((SourceGrid.Cells.Cell)getLCell(i).Grid.GetCell(P)).Value = inputData.s_rezba;
                    }
                }
            }
        }

        /// <summary>
        /// Расширение InputData для токарного перехода
        /// </summary>
        public class TurningInptuData : InputData
        {
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
            /// подача при нарезании резьбы
            /// </summary>
            public float s_rezba = 0;

        }

        /// <summary>
        /// Расширение OutputData для токарного перехода
        /// </summary>
        public class TurningOutputData : OutputData
        {
        }



    }
}
