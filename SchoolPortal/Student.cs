using System;

namespace SchoolPortal
{
    public class Student
    {
      public string RegNo {get; set;}
      public string StudName {get; set;}
     

      public Student(string regno, string studname)
      {
          RegNo = regno;
          StudName = studname;
          
      }


    public void getDetails(){
        
    }



    //   public int Score
    //   {
    //       get{return score;}
    //       set
    //       {
    //           if(value >= 0 && value <= 100)
    //           {
    //               score = value;
    //           }
    //       }
    //   }

      
    }
}
