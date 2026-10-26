public class Solution {
    public int EvalRPN(string[] tokens) {
        if (tokens is null) {
            throw new ArgumentNullException(nameof(tokens));
        }

        var stack = new Stack<int>();

        foreach (var token in tokens) {
            if (int.TryParse(token, out var number)) {
                stack.Push(number);
                continue;
            }

            if (token is not("+" or "-" or "*" or "/")) {
                throw new ArgumentException($"Неизвестный токен: '{token}'.", nameof(tokens));
            }

            if (stack.Count < 2) {
                throw new ArgumentException($"Недостаточно операндов для операции '{token}'.",
                                            nameof(tokens));
            }

            var right = stack.Pop();
            var left = stack.Pop();

            var result = token switch {
                "+" => left + right, "-" => left - right, "*" => left * right, "/" => left / right,
                _ => throw new InvalidOperationException("Оператор уже должен быть проверен.")
            };

            stack.Push(result);
        }

        if (stack.Count != 1) {
            throw new ArgumentException("Выражение должно давать ровно один результат.",
                                        nameof(tokens));
        }

        return stack.Pop();
    }
}
