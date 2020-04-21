using System;

namespace SchoolPortal
{
    public class CommerceStudent : Student
    {
      private int electronicCircuitsScore; 
      private int circuitAnalysisScore;
      private int communicationAndAnalogScore;
      
      

      public CommerceStudent(string regno, string studname, int electronicCircuits, int circuitanalysis, int communicationandanalog):base(regno, studname)
      {
          ElectronicCircuitsScore = electronicCircuits;
          CircuitAnalysisScore = circuitanalysis;
          CommunicationAndAnalogScore = communicationandanalog;
      }


    public int ElectronicCircuitsScore
    {
        get{return electronicCircuitsScore; }

        private set
        {
            if(value >= 0 && value <= 100)
            {
                electronicCircuitsScore = value;
            }
        }
    }

    public int CircuitAnalysisScore
    {
        get{return circuitAnalysisScore; }

        private set
        {
            if(value >= 0 && value <= 100)
            {
                circuitAnalysisScore = value;
            }
        }
    }

     public int CommunicationAndAnalogScore
    {
        get{return communicationAndAnalogScore; }

        private set
        {
            if(value >= 0 && value <= 100)
            {
                communicationAndAnalogScore = value;
            }
        }
    }

    public override string ToString()
    {
        int Average = (ElectronicCircuitsScore + CircuitAnalysisScore + CommunicationAndAnalogScore)/3;

        return $"Registration number: {RegNo}\nName: {StudName}\nElectronic Circuits: {ElectronicCircuitsScore}\nData Structure: {CircuitAnalysisScore}\nCommunication And Analog: {CommunicationAndAnalogScore}\nAverage: {Average}";
    }

      
    }
}
