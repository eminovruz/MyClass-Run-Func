class MyClass
{
	public void Space(string s) => Console.WriteLine($"Space : {string.Join("_", s.ToCharArray())}");
	public void Reverse(string s) => Console.WriteLine($"Reverse : {new string(s.Reverse().ToArray())}");
}
