using Microsoft.AspNetCore.Mvc;

namespace WebApplicationLesson1.Controllers
{
    public class CalculatorController : Controller
    {
        public string Index(double a, double b, char sign)
        {
            if (sign == '-') return $"{a} {sign} {b} = {a - b}";
            if (sign == '*') return $"{a} {sign} {b} = {a * b}";
            if (sign != '+' && sign != 0) return "Некорректная операция. Применяйте операции умножения, сложения и вычитания.";
            return $"{a} + {b} = {a + b}";
        }
    }
}
