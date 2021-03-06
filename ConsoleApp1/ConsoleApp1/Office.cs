﻿using System;
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
            AllRooms = new List<Room>
            {
                new Rooms.DataProcessors(),
                new Rooms.Developers(),
                new Rooms.Kitchen(),
                new Rooms.Lobby(),
                new Rooms.Owners()
            };
        }

        void InitializeAllGroups()
        {
            AllJobs = new List<Job>
            {
                new Jobs.DataProcessor(),
                new Jobs.Janitor(),
                new Jobs.JuniorDeveloper(),
                new Jobs.Owner(),
                new Jobs.SeniorDeveloper(),
                new Jobs.SpecialJanitor()
            };
        }

        void AskJob()
        {
            while(true)
            {
                int userInput;

                Console.WriteLine("Mis teie amet on?");
                Console.WriteLine();

                //Prints every job
                for (int i = 0; i < AllJobs.Count; i++)
                    AllJobs[i].PrintName(i);

                //Asks for user input
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

                //Assigns CurrentJob if input is correct
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

                //Prints every room
                for (int i = 0; i < AllRooms.Count; i++)
                    AllRooms[i].PrintName(i);

                Console.WriteLine((AllRooms.Count + 1) + ". Lahkuge");

                //Asks for user input
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

                //Check whether user input is equal to leave
                if (userInput == AllRooms.Count + 1)
                    return;

                //Check whether user input is in range
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
