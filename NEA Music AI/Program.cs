using NEA_Music_AI;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace Atempt_at_getting_matricies_to_work
{
    internal class Program
    {
        public static void costFunction(ref Neural_Network nn)
        {
            double c = 0;
            double p = nn.Predict(0, 0)[0];
            c += Math.Abs(0 - p);
            p = nn.Predict(1, 0)[0];
            c += Math.Abs(1 - p);
            p = nn.Predict(0, 1)[0];
            c += Math.Abs(1 - p);
            p = nn.Predict(1, 1)[0];
            c += Math.Abs(0 - p);

            nn.fitness = c;
        }
        public static Neural_Network Train(int populationCount, int maxGeneration=100)
        {
            Random rnd = new Random();

            Neural_Network[] repopulate(Neural_Network[] pop)
            {
                List<Neural_Network> newPop = pop.Take((int)Math.Floor(Math.Sqrt(pop.Length))).ToList();

                for (int nni = 0; nni < newPop.Count; nni++)
                {
                    for (int  nnj = 0; nnj < newPop.Count; nnj++)
                    {
                        if (newPop[nni] != newPop[nnj])
                        {
                            Neural_Network a = newPop[nni];
                            Neural_Network b = newPop[nnj];
                            Neural_Network member = new Neural_Network(2, 1, new int[1]{3}, new Func<double, double>[2] {Activation_Functions.Linear, Activation_Functions.Sigmoid});
                            for (int layer = 0; layer < a.weights.Length; layer++)
                            {
                                for (int row = 0; row < a.weights[layer].GetRows(); row++)
                                {
                                    for(int column = 0; column < a.weights[layer].GetColumns(); column++)
                                    {
                                        member.weights[layer][row, column] = (rnd.NextDouble() > 0.5 ? a.weights[layer][row, column] : b.weights[layer][row, column])+rnd.NextDouble() * 0.01 - 0.005;
                                    }
                                }
                            }
                            for (int layer = 0; layer < a.weights.Length; layer++)
                            {
                                for (int i = 0; i < a.weights[layer].GetColumns(); i++)
                                {
                                    //Console.WriteLine($"cols:{member.biases[layer].GetColumns()}");
                                    //Console.WriteLine($"i = {i}");
                                    member.biases[layer][0, i] = (rnd.NextDouble() > 0.5 ? a.biases[layer][0, i] : b.biases[layer][0, i])+rnd.NextDouble() * 0.01 - 0.005;
                                    //Console.WriteLine($"member.biases[layer][0, i] = {member.biases[layer][0, i]}");

                                }
                            }
                        }
                    }
                }
                return newPop.ToArray();
            }
            Neural_Network[] nns = new Neural_Network[populationCount];



            for(int i = 0; i < nns.Length; i++)
            {
                nns[i] = new Neural_Network(2, 1, new int[1]{3}, new Func<double, double>[2] { Activation_Functions.Linear, Activation_Functions.Sigmoid });
                nns[i].SetRandomBiases(rnd);
                nns[i].SetRandomWeights(rnd);
            }
            bool running = true;
            int generation = 0;
            while (running)
            {
                if (generation == maxGeneration)
                {
                    running = false;
                }
                for (int i = 0; i < nns.Length; i++)
                {
                    costFunction(ref nns[i]);
                }
                nns = nns.OrderByDescending(o => o.fitness).ToArray();
                nns = repopulate(nns);
                generation++;
            }
            return nns[0];
        }
        static void Main(string[] args)
        {
            Random rnd = new Random();
            

            

            Neural_Network best = Train(1000000, 1000000);

            Console.WriteLine(best.Predict(1, 1)[0]);

            Console.ReadKey();
        }
    }
}