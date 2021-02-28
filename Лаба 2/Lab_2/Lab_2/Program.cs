using System;
using System.Threading;
using System.Media;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;

namespace Lab_2
{
	class Docs
	{
		public static int count;

		public string name = "Не указано";
		public string autor = "Не указано";
		public string keyWords = "Не указано";
		public string subject = "Не указано";
		public string pathOfFile = "Не указано";

		public Docs()
		{
			string name = "История и всё что не связано с ней";
			string autor = "Студент один";
			string keyWords = "история";
			string subject = "Рим и его короли";
			string pathOfFile = "C:/trashcan";
			++count;
			PrintInfo ();
		}
		public Docs (string name_, string autor_, string keyWords_, string subject_, string pathOfFile_)
		{
			name = name_;
			autor = autor_;
			keyWords = keyWords_;
			subject = subject_;
			pathOfFile = pathOfFile_;
			++count;
			PrintInfo();
		}
		public void PrintInfo ()
		{
			Console.WriteLine("Название : " + name);
			Console.WriteLine("Автор : " + autor);
			Console.WriteLine("Ключевые слова : " + keyWords);
			Console.WriteLine("Тематика : " + subject);
			Console.WriteLine("Путь : " + pathOfFile);
		}
		/**/
	}

	class MSWord : Docs
	{

	}

	class PDF : Docs
	{

	}

	class TXT : Docs
	{

	}

	class Excel : Docs
	{

	}

	class Html : Docs
	{

	}

	public class Singleton
	{
		public static Singleton Instance
		{
			get
			{
				if (instance == null) instance = new Singleton();
				return instance;
			}
		}
		public void Method1() { Console.WriteLine("Singleton.Method1"); }
		public void Method2() { Console.WriteLine("Singleton.Method2"); }
		private Singleton() { }
		private static Singleton instance;
	}
	class Program
	{
		static void Main(string[] args)
		{
			Singleton.Instance.Method1();
			Singleton.Instance.Method2();
		}
	}

	Применение
	class Program
	{
		static void Main(string[] args)
		{

			Docs referat = new Docs();
			Console.WriteLine();
			Docs referat2 = new Docs("Реферат крутой", "Студент", "круто", "рефератная", "C:/TrashCan");
			html goga = new html ();
			goga.autor = "pcrl";
			goga.PrintInfo();


			/*
			Random randNum = new Random();
			int num = randNum.Next(1, 9);
			int input = randNum.Next(1, 999);
			int ToTa = Boop(input, num);
			for (int index = 0; index < 10; ++index)
			{
				input = randNum.Next(1, 9999);
				Beep(input);
				
				switch (index)
				{
					case 1:
						Console.WriteLine("Is one! " + num);
						Console.Beep(325, 614);
						Console.Beep(3136, 213);
						break;
					case 2:
						Console.Beep(627, 500);
						Console.Beep(1907, 300);
						Console.WriteLine("Its two! " + num);
						break;
					default:
						Console.WriteLine("Wtf it is " + num);
						break;
				}
			}
			Console.WriteLine(ToTa); */

		}
		public static void Beep (int ror) {
			Console.WriteLine("Лол кек " + ror*ror/4);
		}

		public static int Boop (int ttt, int y)
		{
			for (int i = 0; i < y; ++i)
			{
				ttt *= 2;
			}
			return ttt;
		}
	}

}
