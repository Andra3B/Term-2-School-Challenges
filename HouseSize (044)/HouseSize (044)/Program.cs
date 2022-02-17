using System;

class Program
{
    public struct Room
    {
        private double _width;
        private double _height;

        public double Width { get => _width; set => _width = value; }
        public double Height { get => _height; set => _height = value; }
        public double Area { get => _width * _height; }

        public Room(double width, double height) => (_width, _height) = (width, height);

        public override string ToString()
        {
            return $"Width: {Width} | Height: {Height} | Area: {Area}";
        }
    }

    public static Room[] rooms;

    static Program() {
        rooms = new Room[Utilities.GetInputs<uint>("Enter the number of rooms: ", "roomCount")["roomCount"]];
        rooms.Initialize();
    }

    public static void Main()
    {
        for(uint room = 0; room < rooms.Length; room++)
        {
            rooms[room].Width = Utilities.GetInputs<uint>($"Enter the width of room {room}: ", "width")["width"];
            rooms[room].Height = Utilities.GetInputs<uint>($"Enter the width of room {room}: ", "width")["width"];
        }

        for(uint room = 0; room < rooms.Length; room++)
        {

        }
    }
}