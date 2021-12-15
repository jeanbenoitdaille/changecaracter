    using System;
     
    namespace Coding.Exercise
    {
        public class Exercise
        {
            public void Main() {
               ComputeAndDisplay(10,2);
               ComputeAndDisplay(21,21);
               ComputeAndDisplay(99,3);
           }
           
           public void ComputeAndDisplay(int a, int b) {
               var res = a % b;
               Console.WriteLine(res);
           }
        }
    }