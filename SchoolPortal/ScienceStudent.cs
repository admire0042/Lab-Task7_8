using System;

namespace SchoolPortal
{
    public class ScienceStudent : Student
    {
      public int computerNetworkScore;
      public int dataStructureScore; 
      public int cSharpScore;
      

      public ScienceStudent(string regno, string studname, int computernetwork, int datastructure, int csharp):base(regno, studname)
      {
          ComputerNetworkScore = computernetwork;
          DataStructureScore = datastructure;
          CSharpScore = csharp;
      }


    public int ComputerNetworkScore
    {
        get{return computerNetworkScore; }

        private set
        {
            if(value >= 0 && value <= 100)
            {
                computerNetworkScore = value;
            }
        }
    }

    public int DataStructureScore
    {
        get{return dataStructureScore; }

        private set
        {
            if(value >= 0 && value <= 100)
            {
                dataStructureScore = value;
            }
        }
    }

     public int CSharpScore
    {
        get{return cSharpScore; }

        private set
        {
            if(value >= 0 && value <= 100)
            {
                cSharpScore = value;
            }
        }
    }

    public override string ToString()
    {
        int Average = (ComputerNetworkScore + DataStructureScore + CSharpScore)/3;

        return $"Registration number: {RegNo}\nName: {StudName}\nComputer NeTwork: {ComputerNetworkScore}\nData Structure: {DataStructureScore}\nC-Sharp: {CSharpScore}\nAverage: {Average}";
    }

      
    }
}
