using System;
using System.Collections.Generic;

namespace Building
{
    class Program
    {
        static void Main(string[] args)
        {
            var Lista1 = new List<Room>();
            Room bucatarie = new Kitchen(15, "masa si scanune", 6, 1);
            Room meetingRoom = new MeetingRoom(20, "armchare", 8);
            Room tehnic = new DepositRoom(5, "Materiale", 2);
            Room birou = new WorkingSpace(130, "birouri", 20);
            Room meetingRoom2 = new MeetingRoom(30, "armchare", 10);
            Lista1.Add(bucatarie);
            Lista1.Add(meetingRoom);
            Lista1.Add(tehnic);
            Lista1.Add(birou);
            Lista1.Add(meetingRoom2);
            Floor et1 = new Floor(Lista1);
            
            var Lista2 = new List<Room>();
            Room birou2 = new WorkingSpace(35, "birouri", 4);
            Room meetingRoom3 = new MeetingRoom(15, "armchare", 6);
            Lista2.Add(bucatarie);
            Lista2.Add(birou2);
            Lista2.Add(tehnic);
            Lista2.Add(birou);
            Lista2.Add(meetingRoom3);
            Floor et2 = new Floor(Lista2);

            var Lista3 = new List<Room>();
            Room birou3 = new WorkingSpace(150, "birouri", 30);
            Room bucatarie1 = new Kitchen(50, "masa si scanune", 20, 3);
            Lista3.Add(birou3);
            Lista3.Add(bucatarie1);
            Lista3.Add(tehnic);
            Lista3.Add(meetingRoom3);
            Lista3.Add(meetingRoom);
            Floor et3 = new Floor(Lista3);

            var Lista4 = new List<Room>();
            Room tehnic1 = new DepositRoom(10, "echipamente", 2);
            Room meetingRoom4 = new MeetingRoom(200, "chairs", 100);
            Lista4.Add(tehnic1);
            Lista4.Add(tehnic);
            Lista4.Add(bucatarie1);
            Lista4.Add(meetingRoom4);
            Lista4.Add(birou2);
            Floor et4 = new Floor(Lista4);

            var Lista5 = new List<Room>();
            Lista5.Add(tehnic);
            Lista5.Add(bucatarie);
            Lista5.Add(birou2);
            Lista5.Add(birou);
            Lista5.Add(meetingRoom3);
            Floor et5 = new Floor(Lista5);


            List<Floor> Etaje = new List<Floor>();
            Etaje.Add(et1);
            Etaje.Add(et2);
            Etaje.Add(et3);
            Etaje.Add(et4);
            Etaje.Add(et5);


            Building Office = new Building(Etaje);
            try
            {
                Building.BuildingInfo(Office);
            }
            catch(BuildingException ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }

    
    }
}
