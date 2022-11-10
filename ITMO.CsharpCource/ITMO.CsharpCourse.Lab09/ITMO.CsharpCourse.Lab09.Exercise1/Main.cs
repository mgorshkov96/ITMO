namespace ITMO.CsharpCourse.Lab09.Exercise1
{
    using System;
    using System.Data;

    public class Application
    {
        public static void Main(string[] args)
        {
            try 
            {
                InnerMain(args);
            }
            catch (Exception caught) //Exception прописал преподователь, что именно он хотел словить не очень понимаю. Надо уточнить.
            {
                Console.WriteLine(caught);
            }
        }
        
        public static void InnerMain(string[] args)
        {
            SourceFile source = new SourceFile(args[0]);
            
            HTMLTokenVisitor visitor = new HTMLTokenVisitor();
            source.Accept(visitor);
        }
    }
}
