using System;
using System.Collections.Generic;

namespace NeurualNetwork
{
    public class Neuron
    {
        public List<double> Weights { get; }
        public List<double> Inputs { get; }
        public NeuronType NeuronType { get; }
        public double Output { get; private set; }
        public double Delta { get; private set; }

        public Neuron(int input_Count, NeuronType type=NeuronType.Normal)
        {
            if (input_Count > 0)
            {
                NeuronType = type;
                Weights = new List<double>();
                Inputs = new List<double>();

                InitWheghtsRandomValue(input_Count);
            }//TODOO: Возможна проверка на корректность данных
        }

        private void InitWheghtsRandomValue(int input_Count)
        {
            var rnd = new Random();

            for (int i = 0; i < input_Count; i++)
            {
                if (NeuronType == NeuronType.Input)
                    Weights.Add(1);
                else
                    Weights.Add(rnd.NextDouble());
                Inputs.Add(0);
            }
        }

        public double FeedForward(List<double> inputs)
        {
            if (inputs.Count != 0)
            {
                for(int i=0;i<inputs.Count;i++)
                {
                    Inputs[i] = inputs[i];
                }
                var sum = 0.0;
                for (int i = 0; i < inputs.Count; i++)
                {
                    sum += inputs[i] * Weights[i];
                }
                if (NeuronType == NeuronType.Input)
                {
                    Output = Sigmoid(sum);
                }
                else
                    Output = sum;
            }
            else Output = -1.0;//TODO: Возможна проверка на корректность данных
            return Output;
        }

        private double Sigmoid(double x)
        { return 1.0 / (1.0 + Math.Pow(Math.E, -x)); }

        private double Sigmoiddx(double x)
        {
            var sigmoid = Sigmoid(x);
            var result = sigmoid / (1 - sigmoid);
            return result;
        }

        public void SetWeihts(params double[] weights)
        {
            //TODO: удалить после создания обучения
            for (int i= 0;i < weights.Length;i++)
            {
                Weights[i] = weights[i];
            }
        }

        public void Learn(double error,double learningRate)
        {
            if (NeuronType == NeuronType.Input) return;

            Delta = error * Sigmoiddx(Output);

            for(int i=0;i<Weights.Count;i++)
            {
                var weight = Weights[i];
                var input = Inputs[i];

                var newWeight = weight - input * Delta * learningRate;
                Weights[i] = newWeight;
            }
        }

        public override string ToString()//Отладчик
        { return Output.ToString(); }
    }
}
