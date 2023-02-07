using LESON1;
using System.Xml;
using System.Xml.Linq;

internal class Program
{
    private static void Main(string[] args)
    {
        ApplicationContext ef = new ApplicationContext();

        Ticket tick = new Ticket()
        {
            Passanger = ef.Passangers.FirstOrDefault(x => x.IdPassanger == 2),
            PointArrival = ef.Points.FirstOrDefault(x => x.IdPoint == 3),
            PointDeparture = new Point() { Value = "Казань" };
            DateArriva = new DateTime (2023,02,07,11,31,10)

        };

        ef.Add(tick);
        ef.SaveChanges();

//        Passanger p = new Passanger()
//        {
//            Name = "Положай Настя",
//            Phone = "89374368954"
//        };

//        Passanger p2 = new Passanger()
//        {
//            Name = "Николаева Алина",
//            Phone = "89178626487"
//        };

//        Passanger p3 = new Passanger()
//        {
//            Name = "Тимакова Лиза",
//            Phone = "89379993476"
//        };

//        if (!ef.Passangers.Any(x=> x.Name == p.Name)) 
//        {
//            ef.Add(p);
//        }

        
//        ef.Add(p2);
//        ef.Add(p3);
   }
}

