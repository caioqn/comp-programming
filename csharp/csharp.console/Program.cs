using csharp.problemlibrary.LeetCode.Easy;

namespace csharp.console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // var input = Console.ReadLine() ?? throw new ArgumentException("Argumentos do console inválidos!!");
            // var inputList = new List<string>() { "()", "()[]{}" };

            int[] nums = [2, 7, 11, 15];
            var target = 9;

            var response = TwoSum.Resolution(nums, target);

            Console.WriteLine(response);

        }
    }
}
