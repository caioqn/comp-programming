using csharp.problemlibrary.LeetCode.Easy;

namespace csharp.tests.LeetCode.Easy
{
    [TestFixture]
    public class ValidParentheses_Cases
    {
        [Test, TestCaseSource(nameof(FalseParenthesisData))]
        public void IsValid_ValueNotValid_ReturnFalse(string value)
        {
            var result = ValidParentheses.IsValidGPT(value);

            Assert.That(result, Is.False);
        }

        [Test, TestCaseSource(nameof(TrueParenthesisData))]
        public void IsValid_ValueIsValid_ReturnTrue(string value)
        {
            var result = ValidParentheses.IsValidGPT(value);

            Assert.That(result, Is.True);
        }


        private static IEnumerable<TestCaseData> FalseParenthesisData()
        {
            yield return new TestCaseData("(}");
            yield return new TestCaseData("(");
            yield return new TestCaseData("}");
            yield return new TestCaseData("({)}");
        }

        private static IEnumerable<TestCaseData> TrueParenthesisData()
        {
            yield return new TestCaseData("{}");
            yield return new TestCaseData("()[]{}");
            yield return new TestCaseData("({[]})");
        }
    }
}