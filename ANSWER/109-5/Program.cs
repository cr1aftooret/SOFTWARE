using System;
using System.Numerics;
using System.Text.RegularExpressions;

Console.WriteLine("請輸入運算式：(輸入@結束)");
string? input;
while (!string.IsNullOrEmpty(input = Console.ReadLine()) && input != "@") {
    MatchCollection matches = Regex.Matches(input, @"(\w+|[+\-*/])");

    List<BigInteger> nums = new List<BigInteger>();
    List<char> ops = new List<char>();

    foreach (Match match in matches) {
        string token = match.Value;
        if (Regex.IsMatch(token, @"\w+")) {
            nums.Add(BigInteger.Parse(token));
        } else {
            ops.Add(token[0]);
        }
    }

    BigInteger result = calc(nums, ops);
    string result_str = result.ToString();
    result_str = result_str.Length >= 4 ?
        int.Parse(result_str.Substring(result_str.Length - 4)).ToString()
        : result_str;

    Console.WriteLine("\n妳輸入的數學算式為：");
    Console.WriteLine(input);
    Console.WriteLine($"運算結果 = {result_str}\n");


    Console.WriteLine("請輸入運算式：(輸入@結束)");
}

BigInteger calc(List<BigInteger> nums, List<char> ops) {
    while (ops.Count != 0) {
        int location = 0;
        for (int i = 0; i < ops.Count; i++) {
            if (ops[i] == '*' || ops[i] == '/') {
                location = i;
                break;
            }
        }

        BigInteger a = nums[location];
        BigInteger b = nums[location + 1];
        char op = ops[location];

        switch (op) {
            case '+':
                a += b;
                break;
            case '-':
                a -= b;
                break;
            case '*':
                a *= b;
                break;
            case '/':
                a /= b;
                break;
        }

        nums[location] = a;
        nums.RemoveAt(location + 1);
        ops.RemoveAt(location);
    }

    return nums[0];
}