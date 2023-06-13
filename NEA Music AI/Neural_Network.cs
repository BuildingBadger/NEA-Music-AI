using Atempt_at_getting_matricies_to_work;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEA_Music_AI
{
    public class Neural_Network
    {
        private int input;
        private int output;
        private int[] layerSizes;
        public Matrix[] weights;
        public Matrix[] biases;
        public double fitness;
        public Func<double, double>[] activationFuncs;
        public Neural_Network(int input, int output, int[] layers, Func<double, double>[] activationFuncs)
        {
            this.input = input;
            this.output = output;
            this.layerSizes = layers;
            this.activationFuncs = activationFuncs;
            weights = new Matrix[layerSizes.Length + 1];
            biases = new Matrix[layerSizes.Length + 1];
            weights[0] = new Matrix(input, layerSizes[0]);
            for(int i = 1; i < layerSizes.Length; i++)
            {
                weights[i] = new Matrix(layerSizes[i - 1], layerSizes[i]);
            }
            weights[weights.Length - 1] = new Matrix(layerSizes[layerSizes.Length - 1], output );
            for (int i = 0; i < weights.Length; i++)
            {
                biases[i] = new Matrix(1, weights[i].GetColumns());

            }
        }

        public double[] Predict(params double[] input)
        {
            Matrix output = Matrix.From1D(input);

            for(int i = 0; i < weights.Length; i++)
            {
                //Console.WriteLine(layer);
                //Console.WriteLine(output);
                
                output*=weights[i];
                output += biases[i];
                output = output.ApplyFunction((double x) => { return activationFuncs[i](x); });
            }
            return output.To1D();
        }
        public void SetRandomWeights(Random rnd)
        {
            foreach(Matrix m in weights)
            {
                for (int i = 0; i < m.GetRows(); i++)
                {
                    for (int j = 0; j < m.GetColumns(); j++)
                    {
                        m[i,j] = rnd.NextDouble()*2-1;
                    }
                }
            }
        }
        public void SetRandomBiases(Random rnd)
        {
            foreach (Matrix m in biases)
            {
                
                for (int i = 0; i < m.GetColumns(); i++)
                {
                    m[0, i] = rnd.NextDouble()*2-1;
                }
                
            }
        }

    }
}
