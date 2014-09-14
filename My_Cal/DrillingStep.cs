using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;


namespace My_Cal
{
    //TODO класс заполнен временно просто копированием TurningStep.
    //Исправить!!!
    class DrillingStep : Step
    {
        public enum drillingKind { DRILLING, PRELIMINARY, FINAL, NONE }

        /// <summary>
        /// Поле для хранения входных данных
        /// </summary>
        public DrillingInptuData inputData = new DrillingInptuData();

        /// <summary>
        /// Поле для хранения индекса ComboBox
        /// </summary>
        public int cBoxIndex = -1;

        public static bool operator true(DrillingStep st)
        {
            // TODO Написать содержимое
            return false;
        }

        public static bool operator false(DrillingStep st)
        {
            // TODO Написать содержимое
            return true;
        }

        protected override bool calc_all()
        {
            if (inputData.dk == drillingKind.PRELIMINARY)
            {
                inputData.d = (float)0.45 * inputData.D;
                inputData.t = (float)0.5 * (inputData.D - inputData.d);
            }
            if (inputData.dk == drillingKind.FINAL)
            {
                inputData.d = (float)0.85 * inputData.D;
                inputData.t = (float)0.5 * (inputData.D - inputData.d);
            }
            if (inputData.dk == drillingKind.DRILLING)
            {
                inputData.t = (float)0.5 * (inputData.D);
            }
            //Если никакой из знаменателей не равен нулю
            if (inputData.T != 0 && inputData.t != 0 && inputData.s != 0)
            {
                outputData.V = (inputData.Cv * (float)Math.Pow(inputData.D, inputData.qv) * inputData.Kmv * inputData.Kpv * inputData.Kg) / ((float)Math.Pow(inputData.T, inputData.mv) * (float)Math.Pow(inputData.t, inputData.xv) * (float)Math.Pow(inputData.s, inputData.yv));
                outputData.n = (1000 * outputData.V) / ((float)Math.PI * inputData.D);
                //если сверление простое т.е. без d
                outputData.M = 10 * inputData.Cm * (float)Math.Pow(inputData.D, inputData.qm) * (float)Math.Pow(inputData.s, inputData.ym) * inputData.Kmp;
                outputData.P = 10 * inputData.Cp * (float)Math.Pow(inputData.D, inputData.qp) * (float)Math.Pow(inputData.s, inputData.yp) * inputData.Kmp;
                // если учитывается d
                if (inputData.dk != drillingKind.DRILLING)
                {
                    outputData.M = outputData.M * (float)Math.Pow(inputData.t, inputData.xm);
                    outputData.P = outputData.P * (float)Math.Pow(inputData.t, inputData.xp);
                }
                outputData.N = (outputData.M * outputData.n) / 9750;
                return true;
            }
            else
                return false;
        }

        public override void ReturnSelect()
        {
            for (int i = 1; i < 9; i++)
            {
                if (i != 6)
                {
                    if (checkLCell(i))
                        Utils.CellSelector(getLCell(i));
                }
                else
                {
                    if (checkLCell(i))
                    {
                        Utils.RowSelector(getLCell(i));
                    }
                }
            }
        }

        /// <summary>
        /// Расширение InputData для сверлильного перехода
        /// </summary>
        public class DrillingInptuData : InputData
        {

            public drillingKind dk = drillingKind.NONE;
            /// <summary>
            /// TODO Уточнить откуда брать этот коэффициент! Временно присвоено 1. 
            /// </summary>
            public float Kmp = 1;
            /// <summary>
            /// поправка на обрабатываемый материал
            /// </summary>
            public float Kmv;
            /// <summary>
            /// поправка на состояние поверхности
            /// </summary>
            public float Kpv;
            /// <summary>
            /// поправка на глубину резания
            /// </summary>
            public float Kg;
            /// <summary>
            /// Диаметр исходного отверстия (для растачивания, зенкерования, рассверливания)
            /// </summary>
            public float d;
            /// <summary>
            /// эмпирический коэффициент параметра V
            /// </summary>
            public float Cv;
            /// <summary>
            /// эмпирический коэффициент параметра V
            /// </summary>
            public float qv;
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
            /// эмпирический коэффициент параметра Mкр
            /// </summary>
            public float Cm;
            /// <summary>
            /// эмпирический коэффициент параметра Mкр
            /// </summary>
            public float qm;
            /// <summary>
            /// эмпирический коэффициент параметра Mкр
            /// </summary>
            public float xm;
            /// <summary>
            /// эмпирический коэффициент параметра Mкр
            /// </summary>
            public float ym;
            /// <summary>
            /// эмпирический коэффициент параметра Po
            /// </summary>
            public float Cp;
            /// <summary>
            /// эмпирический коэффициент параметра Po
            /// </summary>
            public float qp;
            /// <summary>
            /// эмпирический коэффициент параметра Po
            /// </summary>
            public float xp;
            /// <summary>
            /// эмпирический коэффициент параметра Po
            /// </summary>
            public float yp;



        }
    }
}

