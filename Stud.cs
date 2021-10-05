using System;

namespace ConsoleApp2
{
	public abstract class Student
	{
		public string name;
		public string state;
		public void Name(string name_)
		{
			name = name_;
		}
		public string State() { }
		public void Relax()
		{
			state += "Relax";
		}
		public void Read()
		{
			state += "Read";
		}
		public void Write()
		{
			state += "Write";
		}
		public abstract void Study();
	}



	class GoodStudent : Student
	{
		public string State()
        {
			state+="good":
        }
		public abstract void Study()
        {
			Read();
			Write();
			Read();
			Write();
			Relax();
		}

	}

	class BadStudent : Student
	{
		public string State()
		{
			state += "bad":
        }
		public abstract void Study()
		{
			Relax();
			Relax();
			Relax();
			Relax();
			Read();
		}
	}

	class Program
	{
		static void Main(string[] args)
		{

		}
	}


}
