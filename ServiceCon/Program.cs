using ServiceCon.Data.Models.NeurualNetwork;
using System;
using System.Collections.Generic;

namespace ServiceCon
{
    class Program
    {
        static void Main(string[] args)
        {
            var dataset = new List<Tuple<double, double[]>>()
            {
                new Tuple<double, double[]>( 1.0, new double[4]{ 1.0, 1.0, 1.0, 1.0} ),
                new Tuple<double, double[]>( 0.0, new double[4]{ 0.0, 0.0, 0.0, 0.0} ),
                new Tuple<double, double[]>( 1.0, new double[4]{ 1.0, 1.0, 0.0, 1.0} ),
                new Tuple<double, double[]>( 1.0, new double[4]{ 1.0, 0.0, 1.0, 1.0} ),
                new Tuple<double, double[]>( 1.0, new double[4]{ 1.0, 1.0, 1.0, 1.0} ),
                new Tuple<double, double[]>( 0.0, new double[4]{ 1.0, 0.0, 1.0, 0.0} ),
                new Tuple<double, double[]>( 1.0, new double[4]{ 1.0, 1.0, 1.0, 1.0} ),
                new Tuple<double, double[]>( 0.0, new double[4]{ 0.0, 1.0, 1.0, 1.0} ),
                new Tuple<double, double[]>( 1.0, new double[4]{ 1.0, 1.0, 1.0, 0.0} ),
                new Tuple<double, double[]>( 0.0, new double[4]{ 0.0, 0.0, 1.0, 0.0} ),
                new Tuple<double, double[]>( 1.0, new double[4]{ 0.5, 1.0, 1.5, 1.0} ),
                new Tuple<double, double[]>( 1.0, new double[4]{ 1.0, 0.5, 1.0, 1.0} )
            };
            var topology = new Topology(4, 1, 0.05, 2);//4-входных, 1-выходной, 2-коэффециент обучения
            var neuronNetwork = new NeuralNetworks(topology);
            // var defference = neuronNetwork.Learn(dataset, 1000);
            try
            {
                ServiceCon.Data.Controllers.SerializibleController.Save<Topology>(topology, ServiceCon.Data.PublicSettings.Path);
                //neuronNetwork.Save();

                var network = new NeuralNetworks();
                network.Load();
                Console.WriteLine("Load neuronnetwork");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
