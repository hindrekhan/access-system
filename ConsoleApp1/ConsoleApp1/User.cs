using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class User
    {
        public Room CurrentRoom;
        public Job CurrentJob;

        public User()
        {
            CurrentRoom = new Rooms.Lobby();
        }

        public void AccessRoom(Room room)
        {
            if (room.IsAccessible(CurrentJob))
                CurrentRoom = room;
            else
                Console.WriteLine("Teil pole privileege, et sinna siseneda\n");
        }
    }
}
