namespace CoreLib
{
    public class Class1
    {
        public UtilLib.Class2 C = new UtilLib.Class2();

        public override string ToString() => this.C.ToString();
    }
}
