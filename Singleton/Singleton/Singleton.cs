using System;

namespace Singleton
{
   public sealed class Singleton
    {
        private static int instanceCount = 0;

        //private static readonly  Singleton instance = new Singleton (); //Eager Loading
        private static readonly Lazy<Singleton> instance = new Lazy<Singleton>( ()=> new Singleton() );  //Lazy Loading
        private Singleton()
        {
            instanceCount ++; 
            Console.WriteLine("Instance count = " + instanceCount.ToString());
        }

   public static Singleton GetInstance
        {
            get
            {
                //return instance; //Eager Loading
                return instance.Value; //Lazy Loading
            }
        }
        public void printMsg(string msg)
        {

            Console.WriteLine(msg);
        }
    }
}
