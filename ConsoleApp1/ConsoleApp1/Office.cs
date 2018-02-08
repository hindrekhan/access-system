using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Office
    {
        List<Room> AllRooms;
        List<Job> AllJobs;
        User User;

        public Office()
        {
            InitializeAllRooms();
            InitializeAllGroups();
            User = new User();
        }

        void InitializeAllRooms()
        {
            AllRooms = new List<Room>();

            AllRooms.Add(new Rooms.DataProcessors());
            AllRooms.Add(new Rooms.Developers());
            AllRooms.Add(new Rooms.Kitchen());
            AllRooms.Add(new Rooms.Lobby());
            AllRooms.Add(new Rooms.Owners());
        }

        void InitializeAllGroups()
        {
            AllJobs = new List<Job>();

            AllJobs.Add(new Jobs.DataProcessor());
            AllJobs.Add(new Jobs.Janitor());
            AllJobs.Add(new Jobs.JuniorDeveloper());
            AllJobs.Add(new Jobs.Owner());
            AllJobs.Add(new Jobs.SeniorDeveloper());
            AllJobs.Add(new Jobs.SpecialJanitor());
        }

        void AskJob()
        {
            while(true)
            {
                int userInput;

                Console.WriteLine("Mis teie amet on?");
                Console.WriteLine();

                for (int i = 0; i < AllJobs.Count; i++)
                    AllJobs[i].PrintName(i);

                try
                {
                    userInput = Int32.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Peate sisestama numbri");
                    continue;
                }
                
                Console.Clear();

                if (userInput > 0 && userInput <= AllJobs.Count)
                {
                    User.CurrentJob = AllJobs[userInput - 1];
                    return;
                }
                    
                else
                    Console.WriteLine("Peate sisestama numbri õiges vahemikus");
            }
        }

        void AskRoom()
        {
            while(true)
            {
                int userInput;

                Console.WriteLine("Praegune amet: " + User.CurrentJob.Name);
                Console.WriteLine("Praegune asukoht: " + User.CurrentRoom.Name);

                Console.WriteLine();

                Console.WriteLine("Kuhu te soovite minna ?");
                Console.WriteLine();

                for (int i = 0; i < AllRooms.Count; i++)
                    AllRooms[i].PrintName(i);

                Console.WriteLine((AllRooms.Count + 1) + ". Lahkuge");

                try
                {
                    userInput = Int32.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Peate sisestama numbri");
                    continue;
                }

                Console.Clear();

                if (userInput == AllRooms.Count + 1)
                    return;

                if (userInput > 0 && userInput <= AllRooms.Count)
                    User.AccessRoom(AllRooms[userInput - 1]);
            }
        }

        public void Run()
        {
            AskJob();
            AskRoom();
        }
    }
}
