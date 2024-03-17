using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewPredict
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Provide a Review here. The App will predict if its Positive or Negative : ");
            var input = Console.ReadLine(); 
            var output = PredictReview.Predict(new PredictReview.ModelInput() { Review = input });
            Console.WriteLine($"Predicted Sentiment :-> {output.PredictedLabel}");
            Console.ReadLine();
        }
    }
}
