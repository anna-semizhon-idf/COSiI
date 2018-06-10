using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;
using ZedGraph;

namespace lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private Complex Function(Complex x)
        {
            return Complex.Cos(2 * x) + Complex.Sin(5 * x);
        }


        private void DrawOriginal(Complex[] funcValues, ZedGraphControl zedGraphControl)
        {
            // Получим панель для рисования
            GraphPane pane = zedGraphControl.GraphPane;

            pane.XAxis.Title.Text = "N, номер отсчёта";
            pane.YAxis.Title.Text = "Значение функции";
            pane.Title.Text = "Исходная функция";

            // Очистим список кривых на тот случай, если до этого сигналы уже были нарисованы
            pane.CurveList.Clear();

            // Создадим список точек
            PointPairList list = new PointPairList();

            // Заполняем список точек
            for (int i = 0; i < funcValues.Length;  i++)
            {
                // добавим в список точку
                list.Add(i, funcValues[i].Real);
            }

            LineItem myCurve = pane.AddCurve("", list, Color.Blue, SymbolType.None);

            zedGraphControl.AxisChange();

            // Обновляем график
            zedGraphControl.Invalidate();
        }

        private void DrawDFT(Complex[] funcValues, ZedGraphControl zedGraphControl_abs, ZedGraphControl zedGraphControl_phase, 
            ZedGraphControl zedGraphControl_revers)
        {
            // Получим панель для рисования
            GraphPane pane_abs = zedGraphControl_abs.GraphPane;
            GraphPane pane_phase = zedGraphControl_phase.GraphPane;
            GraphPane pane_revers = zedGraphControl_revers.GraphPane;

            pane_abs.XAxis.Title.Text = "k, индекс частоты";
            pane_abs.YAxis.Title.Text = "Значение функции";
            pane_abs.Title.Text = "Амплитудный спектр сигнала";

            pane_phase.XAxis.Title.Text = "k, индекс частоты";
            pane_phase.YAxis.Title.Text = "Значение функции";
            pane_phase.Title.Text = "Фазовый спектр сигнала";

            pane_revers.XAxis.Title.Text = "N, номер отсчёта";
            pane_revers.YAxis.Title.Text = "Значение функции";
            pane_revers.Title.Text = "Обратное преобразование";

            // Очистим список кривых на тот случай, если до этого сигналы уже были нарисованы
            pane_abs.CurveList.Clear();
            pane_phase.CurveList.Clear();
            pane_revers.CurveList.Clear();

            // Создадим список точек
            PointPairList list_abs = new PointPairList();
            PointPairList list_phase = new PointPairList();
            PointPairList list_revers = new PointPairList();

            Complex[] values = Fourier.DiscreteFourierTransform(funcValues, 1);            // Получаем значения прямого преобразования
            Complex[] reverseValues = Fourier.DiscreteFourierTransform(values, -1); ;  // Получаем значения обратного преобразования

            // Заполняем список точек
            for (int i = 0; i < values.Length; i++)
            {
                // добавим в список точку
                list_abs.Add(i, values[i].Magnitude);
                list_phase.Add(i, values[i].Phase);
                list_revers.Add(i, reverseValues[i].Real);
            }


            LineItem curve_abs = pane_abs.AddCurve("", list_abs, Color.Green, SymbolType.None);
            LineItem curve_phase = pane_phase.AddCurve("", list_phase, Color.Red, SymbolType.None);
            LineItem curve_revers = pane_revers.AddCurve("", list_revers, Color.Blue, SymbolType.None);

            zedGraphControl_abs.AxisChange();
            zedGraphControl_phase.AxisChange();
            zedGraphControl_revers.AxisChange();

            // Обновляем график
            zedGraphControl_abs.Invalidate();
            zedGraphControl_phase.Invalidate();
            zedGraphControl_revers.Invalidate();
        }


        private void DrawFFT(Complex[] funcValues, ZedGraphControl zedGraphControl_abs, ZedGraphControl zedGraphControl_phase, 
            ZedGraphControl zedGraphControl_revers)
        {
            // Получим панель для рисования
            GraphPane pane_abs = zedGraphControl_abs.GraphPane;
            GraphPane pane_phase = zedGraphControl_phase.GraphPane;
            GraphPane pane_revers = zedGraphControl_revers.GraphPane;

            pane_abs.XAxis.Title.Text = "k, индекс частоты";
            pane_abs.YAxis.Title.Text = "Значение функции";
            pane_abs.Title.Text = "Амплитудный спектр сигнала";

            pane_phase.XAxis.Title.Text = "k, индекс частоты";
            pane_phase.YAxis.Title.Text = "Значение функции";
            pane_phase.Title.Text = "Фазовый спектр сигнала";

            pane_revers.XAxis.Title.Text = "N, номер отсчёта";
            pane_revers.YAxis.Title.Text = "Значение функции";
            pane_revers.Title.Text = "Обратное преобразование";

            // Очистим список кривых на тот случай, если до этого сигналы уже были нарисованы
            pane_abs.CurveList.Clear();
            pane_phase.CurveList.Clear();
            pane_revers.CurveList.Clear();

            // Создадим список точек
            PointPairList list_abs = new PointPairList();
            PointPairList list_phase = new PointPairList();
            PointPairList list_revers = new PointPairList();

            Complex[] values = Fourier.FastFourierTransform(funcValues, 1);            // Получаем значения прямого преобразования
            Complex[] reverseValues = Fourier.FastFourierTransform(values, -1);  // Получаем значения обратного преобразования

            // Заполняем список точек
            for (int i = 0; i < values.Length; i++)
            {
                // добавим в список точку
                list_abs.Add(i, values[i].Magnitude);
                list_phase.Add(i, values[i].Phase);
                list_revers.Add(i, reverseValues[i].Real);
            }


            LineItem curve_abs = pane_abs.AddCurve("", list_abs, Color.Green, SymbolType.None);
            LineItem curve_phase = pane_phase.AddCurve("", list_phase, Color.Red, SymbolType.None);
            LineItem curve_revers = pane_revers.AddCurve("", list_revers, Color.Blue, SymbolType.None);

            zedGraphControl_abs.AxisChange();
            zedGraphControl_phase.AxisChange();
            zedGraphControl_revers.AxisChange();

            // Обновляем график
            zedGraphControl_abs.Invalidate();
            zedGraphControl_phase.Invalidate();
            zedGraphControl_revers.Invalidate();
        }        



        private void drawButtonDFT_Click(object sender, EventArgs e)
        {
            int N = int.Parse(textBox_N1.Text);
            double period = 2 * Math.PI;
            Complex[] valuesVector = Fourier.GetFunctionValuesVector(Function, period, N);

            DrawOriginal(valuesVector, original_graph1);
            DrawDFT(valuesVector, absDFT_graph, phaseDFT_graph, reverseDFT_graph);
            countLabel1.Text = "Количество операций: " + Fourier.count.ToString();
        }

        private void drawButtonFFT_Click(object sender, EventArgs e)
        {
            int N = int.Parse(textBox_N2.Text);
            double period = 2*Math.PI;

            Complex[] valuesVector = Fourier.GetFunctionValuesVector(Function, period, N);

            DrawOriginal(valuesVector, original_graph2);
            DrawFFT(valuesVector, absFFT_graph, phaseFFT_graph, reverseFFT_graph);
            countLabel2.Text =  "Количество операций: " + Fourier.count.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void reverseFFT_graph_Load(object sender, EventArgs e)
        {

        }
    }
}
