namespace Calculate
{
    public class Calculator
    {
        public static Func<int, int, int> Add = (a, b) => a + b;
        public static Func<int, int , int> Subtract = (a, b) => a - b;
        public static Func<int, int, int> Multiply = (a, b) => a * b;
        public static Func<int, int, int> Divide = (a, b) => a / b;

        public static IReadOnlyDictionary<char, Func<int, int, int>> MathematicalOperations { get; } = new Dictionary<char, Func<int, int, int>>()
        {
            { '+', Add },
            { '-', Subtract },
            { '*', Multiply },
            { '/', Divide }
        };

        public static bool TryCalculate(string input, out int result)
        {
            result = 0;
            string[] opsAndInts = input.Split(" ");
            if (opsAndInts.Length != 3) return false;
            else if (!int.TryParse(opsAndInts[0], out int a) || !int.TryParse(opsAndInts[2], out int b)) return false;
            else if (!MathematicalOperations.TryGetValue(opsAndInts[1][0], out var operation)) return false;
            else
            {
                result = operation(a, b);
                return true;
            }

        }
    }
}
