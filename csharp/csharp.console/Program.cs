using csharp.problemlibrary.LeetCode.Easy;

namespace csharp.console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine() ?? throw new ArgumentException("Argumentos do console inválidos!!");
            // var inputList = new List<string>() { "()", "()[]{}" };

            var response = ValidParentheses.IsValidGPT(input);

            Console.WriteLine(response);

        }
    }
}
