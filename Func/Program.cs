namespace Func;

class Run
{
	public void RunFunc(Func funcDell, string text) => funcDell(text);
}

delegate void Func(string text);
class Program
{
	static void Main()
	{
		
		Console.Write("Daxil et : ");
		var s = Console.ReadLine();
		MyClass cls = new MyClass();
		Func funcDell = cls.Reverse;
		funcDell += cls.Space;
		Run run = new Run();
		run.RunFunc(funcDell, s);

	}
}