﻿// Статичні поля зберігають стан всього класу/структури.
// Статичне поле визначається як і просте, лише перед типом поля вказується ключове слово static. 
// На рівні пам'яті для статичних полів створюватиметься ділянка в пам'яті,
// яка буде спільною для всіх об'єктів класу.

namespace Lesson1.StaticClassesExamples
{
	public class Person
	{
		readonly int age;
		public static int retirementAge = 65;

		// статичне свойство
		public static int RetirementAge
		{
			get { return retirementAge; }
			set { if (value > 1 && value < 100) retirementAge = value; }
		}

		public Person(int age)
		{
			this.age = age;
		}

		//Крім звичайних конструкторів, у класу також можуть бути статичні конструктори.
		//Статичні конструктори мають такі відмінні риси:
		//- Статичні конструктори не повинні мати модифікатор доступу та не приймають параметрів
		//- Як і в статичних методах, в статичних конструкторах не можна використовувати
		//ключове слово для посилання на поточний об'єкт класу і можна звертатися тільки
		//до статичних членів класу
		//- Статичні конструктори не можна викликати у програмі вручну.Вони виконуються
		//автоматично при першому створенні об'єкта даного класу або при першому зверненні
		//до його статичних членів (якщо такі є)

		// Статичні конструктори зазвичай використовуються для ініціалізації статичних даних,
		// або виконують дії, які потрібно виконати лише один раз

		static Person()
		{
			if (DateTime.Now.Year == 2023)
				retirementAge = 65;
			else
				retirementAge = 70;
		}

		public void Print()
		{
			Console.WriteLine($"Age: {age}");
		}

		// статичний метод
		public static void CheckRetirementStatus(Person person)
		{
			if (person.age >= retirementAge)
				Console.WriteLine("Вже на пенсії");
			else
				Console.WriteLine($"Скільки років залишилося до пенсії: {retirementAge - person.age}");
		}
	}
}
