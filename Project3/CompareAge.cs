
using System.Collections.Generic;  namespace Project3 {     internal class CompareAge : IComparer<student>     {         List<student> students = new List<student>();          public int Compare(student x, student y)         {             if (x.Age == 0 && y.Age == 0) return 0;             else if (x.Age == 0) return -1;             else if (y.Age == 0) return 1;             else return x.Age.CompareTo(y.Age);         }
     } }  
