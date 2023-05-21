using System.Globalization;
using System.Text.RegularExpressions;

namespace StatisticMVC.Models
{
    public class StatisticCalculator
    {
        public string InputText { get; set; } = "";
        public List<int> Numbers { get; private set; }
        public int MaxNumber { get; private set; } = 0;
        public int MinNumber { get; private set; } = 0;
        public double AvgNumber { get; private set; }
        public string SortedNumbers { get; set; } = "";

        public StatisticCalculator() { 
        Numbers = new List<int>();
        }

        public void GetMaxNumber()
        {
            MaxNumber = Numbers.Max();
        }
        public void GetMinNumber()
        {
            MinNumber = Numbers.Min();
        }
        public void GetAvgNumber()
        {
            AvgNumber = Numbers.Average();
        }
        public void GetSortedNumbers()
        {
            SortedNumbers = String.Join(",", Numbers.ToArray());
        }

        public void ConvertList(string inputText)
        {
            List<string> numbers = new List<string>();
            numbers= inputText.Split(' ').ToList();
            Regex regex = new Regex(@"^\d+");
            foreach (string number in numbers)
            {
                
                if (regex.IsMatch(number)) { 
                Numbers.Add(Convert.ToInt32(number));
                       }
            }
            
            Numbers.Sort();
        }
    }
}
