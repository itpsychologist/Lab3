using System;
using System.Collections.Generic;

// Абстрактний базовий клас
abstract class Function
{
    // Віртуальна функція для обчислення значення функції від двох аргументів
    public abstract double Evaluate(double x, double y);
}

// Конкретні класи, які наслідують базовий клас Function
class Function1 : Function
{
    public override double Evaluate(double x, double y)
    {
        return x + y;
    }
}

class Function2 : Function
{
    public override double Evaluate(double x, double y)
    {
        return x * y;
    }
}

class Function3 : Function
{
    public override double Evaluate(double x, double y)
    {
        return x - y;
    }
}

// Клас-контейнер
class FunctionContainer
{
    private List<Function> functions;

    // Конструктор за замовчуванням
    public FunctionContainer()
    {
        functions = new List<Function>();
    }

    // Функція для додавання нових елементів у список
    public void AddFunction(Function function)
    {
        functions.Add(function);
    }

    // Функція для обчислення добутку значень всіх функцій
    public double CalculateProduct(double x, double y)
    {
        double product = 1;
        foreach (var function in functions)
        {
            product *= function.Evaluate(x, y);
        }
        return product;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Створення екземплярів похідних класів
        Function f1 = new Function1();
        Function f2 = new Function2();
        Function f3 = new Function3();

        // Створення екземпляра класу-контейнера
        FunctionContainer container = new FunctionContainer();

        // Додавання функцій у контейнер
        container.AddFunction(f1);
        container.AddFunction(f2);
        container.AddFunction(f3);

        // Обчислення добутку значень всіх функцій для заданих аргументів
        double x = 2.0;
        double y = 3.0;
        double result = container.CalculateProduct(x, y);

        // Виведення результату
        Console.WriteLine("Product of function values: " + result);
    }
}
