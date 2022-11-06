using System;

namespace ExquisiteCorpse
{
  class Program
  {
    static void Main(string[] args)
    {
  
      SwitchCase(2,3,1);
  
    }

    //combine methods 
    static void BuildACreature(string head, string body, string feet)
    {
      //call thress times, head,body and feet
    int headNumber = TranslateToNumber("ghost");
    int bodyNumber = TranslateToNumber("bug");
    int feetNumber =  TranslateToNumber("monster");
    }

    //create automate random creature
    static void RandomMode()
    {
      //create build-in Random class instance
      Random randomNumber = new Random();

      //pick number between 1 and inculsive 3
     int randomHead = randomNumber.Next(1,4);
     int randomBody = randomNumber.Next(1,4);
     int randomFeet = randomNumber.Next(1,4);
 
     //call the method and pass variable arguments
      SwitchCase(randomHead,randomBody,randomFeet);
    }

    static void SwitchCase(int head, int body, int feet)
    {
      switch(head)
      {
        case 1:
         GhostHead();
         break;
         case 2:
         BugHead();
         break;
         case 3:
         MonsterHead();
         break;
      }
      
      switch(body)
      {
        case 1:
         GhostBody();
         break;
         case 2:
         BugBody();
         break;
         case 3:
         MonsterBody();
         break;
      }
      switch(feet)
      {
        case 1:
         GhostFeet();
         break;
         case 2:
         BugFeet();
         break;
         case 3:
         MonsterFeet();
         break;
      }
    }

    //Translate string values to int values method
    static int TranslateToNumber(string creature)
    {
      //can return values in switch statements
      switch (creature)
      {
        case "ghost":
            return 1;        
        case "bug":
            return 2;         
        case "monster":
            return 3;       
         default:
           return 1; 

      }
    }

    static void GhostHead()
    {
      Console.WriteLine("     ..-..");
      Console.WriteLine("    ( o o )");
      Console.WriteLine("    |  O  |");
    }

    static void GhostBody()
    {
      Console.WriteLine("    |     |");
      Console.WriteLine("    |     |");
      Console.WriteLine("    |     |");
    }

    static void GhostFeet()
    {
      Console.WriteLine("    |     |");
      Console.WriteLine("    |     |");
      Console.WriteLine("    '~~~~~'");
    }

    static void BugHead()
    {
      Console.WriteLine("     /   \\");
      Console.WriteLine("     \\. ./");
      Console.WriteLine("    (o + o)");
    }

    static void BugBody()
    {
      Console.WriteLine("  --|  |  |--");
      Console.WriteLine("  --|  |  |--");
      Console.WriteLine("  --|  |  |--");
    }

    static void BugFeet()
    {
      Console.WriteLine("     v   v");
      Console.WriteLine("     *****");
    }

    static void MonsterHead()
    {
      Console.WriteLine("     _____");
      Console.WriteLine(" .-,;='';_),-.");
      Console.WriteLine("  \\_\\(),()/_/");
      Console.WriteLine("　  (,___,)");
    }

    static void MonsterBody()
    {
      Console.WriteLine("   ,-/`~`\\-,___");
      Console.WriteLine("  / /).:.('--._)");
      Console.WriteLine(" {_[ (_,_)");
    }

    static void MonsterFeet()
    {
      Console.WriteLine("    |  Y  |");
      Console.WriteLine("   /   |   \\");
      Console.WriteLine("   \"\"\"\" \"\"\"\"");
    }
  }
}
