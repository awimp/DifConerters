namespace DZ2


{
    public abstract class Student
    {
       
        
        public Student(string name)
        {
            this.name = name;
            this.state = "";
        }

        public void State() { }


        public string getName()
        {
            return name;
        }

        public string getState()
        {
            return state;
        }


        public void Relax()
        {
            state += " Relax";
        }

        public void Write()
        {
            state += " Write";
        }

        public void Read()
        {
            state += " Read";
        }
                

        protected string name;

        protected string state;

        public abstract void Study();

    }


    public class GoodStudent : Student
    {
        public GoodStudent(string name) : base(name)

        {
            state += " good";
        }

        public override void Study()

        {
            Read();
            Write();
            Read();
            Write();
            Relax();

        }
    }


    public class BadStudent : Student
    {
        public BadStudent(string name) : base(name)

        {
            state += " bad";
        }

        public override void Study()

        {

            Relax();
            Relax();
            Relax();
            Relax();
            Read();

        }
    }

    
}