namespace Util.Utils
{
    public class SelectTestFunc
    {
        public string Desc { get; set; }
        public Util.Func Func { get; set; }

        public SelectTestFunc(string desc, Util.Func func)
        {
            this.Desc = desc;
            this.Func = func;
        }
    }
}