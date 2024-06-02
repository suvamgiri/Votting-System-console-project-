using System;
using System.Collections.Generic;

public class Canditatess
{
    public string name;
    public Canditatess(string name)
    {
        this.name = name;
    }
}
public class Votinguser
{
    public int voting_number;

    public Votinguser(int voting_number)
    {
        this.voting_number = voting_number;
    }

}
public class Complete
{
    public int number;
    public Complete(int number)
    {
        this.number = number;
    }
}

class Program
{

    public static void Main(string[] args)
    {
    
        List<Canditatess> Canditatesss = new List<Canditatess>();
        List<Votinguser> Votingusers = new List<Votinguser>();

        Votingusers.Add(new Votinguser(334));
        Votingusers.Add(new Votinguser(364));
        Votingusers.Add(new Votinguser(354));
        Votingusers.Add(new Votinguser(324));

        List<Complete> number = new List<Complete>();

        Console.Write("how many canditaes are elected : ");
        int Canditatess_count = Convert.ToInt32(Console.ReadLine());



        int i = 1;
        int count = Canditatess_count;
        while (i < count + 1)
        {
            Console.Write(i+ " ");
            string name = Console.ReadLine();
            Canditatesss.Add(new Canditatess(name));




            i++;
        }
    while(true){


        
        int r = 1;
      


        Console.WriteLine( "\n welcome to  voting system");
        foreach (Canditatess Canditatess in Canditatesss)
        {

            Console.WriteLine(r++ +" "+ Canditatess.name);

        }

        Console.Write("Which Canditatesss you want to vote: ");
        int votingname = Convert.ToInt32(Console.ReadLine());
      
      
        Console.Write("your voting number is: ");
        int votingnumber = Convert.ToInt32(Console.ReadLine());

        number.Add(new Complete(votingnumber));
     
        foreach (Complete Complete in number)
        {
           int num = Complete.number;
        }
      int num12 = 0;
         foreach(Votinguser Votinguser in Votingusers){
            num12 = Votinguser.voting_number;
           
         }   
      int num1 = 0;
      foreach(Complete Complete in number){
        num1 = Complete.number;

      }
      
        // Check if the user has already voted
            bool hasVoted = false;
            foreach (Complete Complete in number)
            {
                if (Complete.number == votingnumber)
                {
                    hasVoted = true;
                    break;
                }
            }

            if (hasVoted)
            {
                Console.WriteLine("You have already voted.");
            }
            else
            {
                bool isValidUser = false;
                foreach (Votinguser Votinguser in Votingusers)
                {
                    if (Votinguser.voting_number == votingnumber)
                    {
                        isValidUser = true;
                        number.Add(new Complete(votingnumber));
                        Console.WriteLine("Thank you for your vote.");
                        break;
                    }
                }

                if (!isValidUser)
                {
                    Console.WriteLine("Sorry, you are not eligible to vote.");
                }
            }
        

        
        }
        
  }
}
