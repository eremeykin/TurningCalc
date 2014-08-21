﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Cal
{
    class MillingStep : Step
    {
        /// <summary>
        /// Поле для хранения входных данных
        /// </summary>
        public MillingInptutData inputData = new MillingInptutData();

        /// <summary>
        /// Поле для хранения выходных данных
        /// </summary>
        public MillingOutputData outputData = new MillingOutputData();

        /// <summary>
        /// Поле для хранения индекса ComboBox
        /// </summary>
        public int cBoxIndex = -1;
        
        public static bool operator true(MillingStep st)
        {
            //TODO Написать логику
            throw new Exception();
        }

        public static bool operator false(MillingStep st)
        {
            //TODO написать логику
            throw new Exception();
        }

        protected override bool calc_all()
        {

            if (((float)(Math.Pow(inputData.T, inputData.mv)) * ((float)(Math.Pow(inputData.t, inputData.xv))) * ((float)(Math.Pow(inputData.s, inputData.yv)))) != 0 && (((float)Math.Pow(inputData.B, inputData.uv)) != 0))
            {
                outputData.V = (inputData.Cv * inputData.Kv * (float)Math.Pow(inputData.D, inputData.qv)) / ((float)(Math.Pow(inputData.T, inputData.mv)) * ((float)(Math.Pow(inputData.t, inputData.xv))) * ((float)(Math.Pow(inputData.s, inputData.yv))) * ((float)(Math.Pow(inputData.B, inputData.uv))) * ((float)(Math.Pow(inputData.z, inputData.pv))));
                outputData.n = (1000 * outputData.V) / ((float)Math.PI * inputData.D);
                outputData.Pz = (10 * inputData.Cp * ((float)Math.Pow(inputData.t, inputData.xp)) * ((float)Math.Pow(inputData.s, inputData.yp)) * ((float)Math.Pow(inputData.B, inputData.up)) * inputData.z) / (((float)Math.Pow(inputData.D, inputData.qp)) * ((float)Math.Pow(outputData.n, inputData.wp)));
                outputData.M = outputData.Pz * (inputData.D / 200);
                outputData.N = (outputData.Pz * outputData.V) / (1020 * 60);
                outputData.Sm = inputData.s * inputData.z * outputData.n;//s - подача на зуб!
                return true;
            }
            else
                return false;
        }

        public override float getV()
        {
            if (calc_all())
                return outputData.V;
            else
                return 0;
        }

        public override float getM()
        {
            if (calc_all())
                return outputData.M;
            else return 0;

        }

        public override float getN()
        {
            if (calc_all())
                return outputData.N;
            else
                return 0;
        }

        public override float getn()
        {
            if (calc_all())
                return outputData.n;
            else
                return 0;
        }

        public override float getPz()
        {
            if (calc_all())
                return outputData.Pz;
            else
                return 0;
        }

        public float getSm()
        {
            if (calc_all())
                return outputData.Sm;
            else
                return 0;
        }

        public override void ReturnSelect()
        {

            for (int i = 2; i < 5; i++)
            {
                if (checkLCell(i))
                    Utils.CellSelector(getLCell(i));
            }

            if (checkLCell(1))
                Utils.RowSelector(getLCell(1));
            if (checkLCell(5))
            {
                Utils.RowSelector(getLCell(5));
            }
        }

        /// <summary>
        /// Расширение InputData для фрезерного перехода
        /// </summary>
        public class MillingInptutData : InputData
        {
            #region Основные параметры
            /// <summary>
            /// Ширина фрезы
            /// </summary>
            public float B;
            /// <summary>
            /// Количество зубьев фрезы
            /// </summary>
            public float z;
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

        /// <summary>
        /// Расширение OutputData для фрезерного перехода
        /// </summary>
        /// TODO заменить public на  private внутри
        public class MillingOutputData : OutputData
        {
            /// <summary>
            /// минутная подача
            /// </summary>
            public float Sm;
        }

    }
}