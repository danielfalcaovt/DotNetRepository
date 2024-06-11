namespace EventosPratica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            var room = new Room(3);
            room.RoomSoldOutEvent += OnRoomSoldOut;
            room.ReserveSeat();
            room.ReserveSeat();
            room.ReserveSeat();
            room.ReserveSeat();
        }

        static void OnRoomSoldOut (object sender, EventArgs e)
        {
            Console.WriteLine("Esgotado.");
        }
    }

    public class Room
    {
        public int Seats { get; set; }
        private int freeSeats { get; set; }

        public Room (int seats)
        {
            Seats = seats;
        }

        public void ReserveSeat ()
        {
            if (freeSeats >= Seats)
            {
                OnRoomSoldOut(EventArgs.Empty);
            }
            else
            {
                Console.WriteLine("Reserved");
                freeSeats++;
            }
        }

        public event EventHandler RoomSoldOutEvent;

        protected virtual void OnRoomSoldOut (EventArgs e) 
        {
            EventHandler handler = RoomSoldOutEvent;
            handler.Invoke(this, e);
        }
    }
}