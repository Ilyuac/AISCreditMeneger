using Microsoft.VisualStudio.TestTools.UnitTesting;
using ServiceCon.Data.Models.NeurualNetwork;
using System;
using System.Collections.Generic;
using System.Text;

namespace NeurualNetwork.Tests
{
    [TestClass()]
    public class NeuralNetworksTests
    {
        [TestMethod()]
        public void NeuralNetworksTest()
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
            var topology = new Topology(4, 1, 2);//4-входных, 1-выходной, 2-коэффециент обучения
            var neuronNetwork = new NeuralNetworks(topology);
            var defference = neuronNetwork.Learn(dataset, 1000);

            neuronNetwork.Save();
        }
    }
}