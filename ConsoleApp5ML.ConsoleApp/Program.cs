// This file was auto-generated by ML.NET Model Builder. 

using System;
using ConsoleApp5ML.Model;

namespace ConsoleApp5ML.ConsoleApp
{
    class Program
    {
        static int Main(string[] args)
        {
            // Create single instance of sample data from first line of dataset for model input
            ModelInput sampleData = new ModelInput()
            {
                ImageSource = args[0],

              //  ImageSource = @"D:\Image\IsRubbish\1HHDCJK8I2.jpg",
            };

            // Make a single prediction on the sample data and print results
            var predictionResult = ConsumeModel.Predict(sampleData);

            Console.WriteLine("Using model to make single prediction -- Comparing actual Label with predicted Label from sample data...\n\n");
            Console.WriteLine($"ImageSource: {sampleData.ImageSource}");
            Console.WriteLine($"\n\nPredicted Label value {predictionResult.Prediction} \nPredicted Label scores: [{String.Join(",", predictionResult.Score)}]\n\n");
            Console.WriteLine("=============== End of process, hit any key to finish ===============");
            if (predictionResult.Prediction == "IsRubbish")
            {
                return 1;
            }
            else
            {
                return 0;
            }
           

        }
    }
}
