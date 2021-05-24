using System;
using System.Collections.Generic;

namespace WebAPIModule.Models.NeurualNetwork
{
    /// <summary>
    /// Нейрон.
    /// </summary>
    public class Neuron
    {
        public List<double> Weights { get; set; }
        public List<double> Inputs { get; set; }
        public NeuronType NeuronType { get; set; }
        public double Output { get; set; }
        public double Delta { get; set; }

        /// <summary>
        /// Конструктор нейрона.
        /// </summary>
        /// <param name="input_Count">Количество нейронов.</param>
        /// <param name="type">Тип нейрона.</param>
        public Neuron(int input_Count, NeuronType type=NeuronType.Normal)
        {
            if (input_Count > 0)
            {
                NeuronType = type;
                Weights = new List<double>();
                Inputs = new List<double>();

                InitWheghtsRandomValue(input_Count);
            }
        }

        /// <summary>
        /// Конструктор нейрона.
        /// </summary>
        public Neuron()
        {

        }

        /// <summary>
        /// Инициализация случайного веса нейрона.
        /// </summary>
        /// <param name="input_Count">Количество нейронов.</param>
        private void InitWheghtsRandomValue(int input_Count)
        {
            var rnd = new Random();

            for (int i = 0; i < input_Count; i++)
            {
                Weights.Add(NeuronType == NeuronType.Input
                            ? 1.0
                            : rnd.NextDouble());

                Inputs.Add(0);
            }
        }

        /// <summary>
        /// Прямое распространение.
        /// </summary>
        /// <param name="inputs">Входные значениянейрона.</param>
        /// <returns>Выходное значение нейрона.</returns>
        public double FeedForward(List<double> inputs)
        {
            if (inputs.Count != 0)
            {
                for (int i = 0; i < inputs.Count; i++)
                {
                    Inputs[i] = inputs[i];
                }

                var sum = 0.0;

                for (int i = 0; i < inputs.Count; i++)
                {
                    sum += inputs[i] * Weights[i];
                }

                Output = (NeuronType == NeuronType.Input
                            ? Sigmoid(sum)
                            : sum);
            }
            else
            {
                Output = -1.0;
            }

            return Output;
        }

        /// <summary>
        /// Функция активации.
        /// </summary>
        /// <param name="x">Параметр функции.</param>
        /// <returns>Результат.</returns>
        private double Sigmoid(double x)
        { 
            return 1.0 / (1.0 + Math.Pow(Math.E, -x)); 
        }

        /// <summary>
        /// Производная функции активации.
        /// </summary>
        /// <param name="x">Параметр функции.</param>
        /// <returns>Результат.</returns>
        private double Sigmoiddx(double x)
        {
            var sigmoid = Sigmoid(x);
            var result = sigmoid / (1 - sigmoid);

            return result;
        }

        /// <summary>
        /// Установка веса.
        /// </summary>
        /// <param name="weights">Веса.</param>
        public void SetWeihts(params double[] weights)
        {
            for (int i= 0;i < weights.Length;i++)
            {
                Weights[i] = weights[i];
            }
        }

        /// <summary>
        /// Обучение нейрона.
        /// </summary>
        /// <param name="error">Ошибка.</param>
        /// <param name="learningRate">Коэфициент обучения.</param>
        public void Learn(double error,double learningRate)
        {
            if (NeuronType == NeuronType.Input)
            {
                return;
            }

            Delta = error * Sigmoiddx(Output);

            for(int i=0;i<Weights.Count;i++)
            {
                var weight = Weights[i];
                var input = Inputs[i];

                var newWeight = weight - input * Delta * learningRate;
                Weights[i] = newWeight;
            }
        }

        /// <summary>
        /// Получение результата работы нейрона.
        /// </summary>
        /// <returns>Результат.</returns>
        public override string ToString()
        { 
            return Output.ToString(); 
        }
    }
}
