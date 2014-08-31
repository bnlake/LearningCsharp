using System;

// Shows an example of each kind of type declaration. Later sections describe type declarations in detail

public enum Color
{
	Red,Blue,Green
}
public struct Point
{
	public int x, y;
}
public interface IBase
{
	void f();
}
public interface IDerived : IBase
{
	void G();
}
public class A
{
	protected virtual void H()
	{
		Console.WriteLine("A.H");
	}
}
public class B : A, IDerived
{
	public void F()
	{
		Console.WriteLine("B.F, implementation of IDerived.F");
	}
	public void G()
	{
		Console.WriteLine("B.G, implementation of IDerived.G");
	}
	protected override void H()
	{
		Console.WriteLine("B.H, override of A.H");
	}
}
public delegate void EmptyDelegate();