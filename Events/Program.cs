namespace Events
{
    class Program 
    {
        static void Main(string[] args) {
            Room room = new Room(3);
            room.RoomSoldOutEvent += OnRoomSoldOut;
            room.ReserveSeat();
            room.ReserveSeat();
            room.ReserveSeat();
            room.ReserveSeat();
        }

        static void OnRoomSoldOut (object sender, EventArgs e) {
            Console.WriteLine("Espaço Lotado.");
        }
    }

    public class Room 
    {
        public int Seats { get; set; }
        private int seatsInUse = 0;

        public Room (int seats) 
        {
            Seats = seats;
        }

        public void ReserveSeat() 
        {
            if (seatsInUse >= Seats) 
            {
                OnRoomSoldOut(EventArgs.Empty);
            }
            else 
            {
                Console.WriteLine("Reservado.");
                seatsInUse++;
            }
        } 

        public event EventHandler RoomSoldOutEvent;

        protected virtual void OnRoomSoldOut(EventArgs e) 
        {
            EventHandler handler = RoomSoldOutEvent;
            handler?.Invoke(this, e);
        }
    }
}