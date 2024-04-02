using Microsoft.AspNetCore.Mvc;

namespace WebApplicationLesson1.Controllers
{
    public class CalcController : Controller
    {
        public string Index(double a, double b, char c)
        {
            if (c == '-') return $"{a} {c} {b} = {a - b}";
            if (c == '*') return $"{a} {c} {b} = {a * b}";
            if (c == '/' && b != 0) return $"{a} {c} {b} = {a / b}";
            if (c == '/' && b == 0) return "Ошибка: делеине на ноль.";
            if (c != '+' && c != 0) return "Некорректная операция. Применяйте операции умножения, сложения и вычитания.";
            return $"{a} + {b} = {a + b}";
        }
    }
}