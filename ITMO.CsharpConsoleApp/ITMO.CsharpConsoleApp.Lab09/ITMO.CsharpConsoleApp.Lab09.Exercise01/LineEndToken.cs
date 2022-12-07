namespace ITMO.CsharpConsoleApp.Lab09.Exercise01
{    
    internal sealed class LineEnd
    {
        internal sealed class Token : ILineEndToken
        {
            internal Token(int number)
            {
                this.number = number;
            }
         
            public static Token operator++(Token t)
            {
                t.number++;
                return t;
            }
            
            int ILineEndToken.Number()
            {
                return number; 
            }
            
            private int number;   
        }
    }
}
