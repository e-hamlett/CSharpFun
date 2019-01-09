using System;

namespace CSharpFun
{
    public class House
    {

        string _foundation;
        // string _roof;
        string _window;
        string _doors;
        string _rooms;
        //string _paintdoor;

        public string Foundation
        {
            get
            {
                return _foundation;
            }
            set
            {
                this._foundation = value;
            }
        }

        public string Roof { get; set; }

        public string Window
        {
            get
            {
                return _window;
            }
            set
            {
                this._window = value;
            }
        }

        public string Doors
        {
            get
            {
                return _doors;
            }
            set
            {
                this._doors = value;
            }
        }

        public string Rooms
        {
            get
            {
                return _rooms;
            }
            set
            {
                this._rooms = value;
            }
        }

        public string PaintDoor { get; set; }

        public House() { }

        public House(string foundation, string window)
        {
            this._foundation = foundation;
            this._window = window;
            Roof = "shingles";
            PaintDoor = "Green";
        }
        public House(string foundation, string window, string roof, string doorPaint)
        {
            this._foundation = foundation;
            this._window = window;
            this.Roof = roof;
            this.PaintDoor = doorPaint;
        }


        public void OpenDoor()
        {
            Console.WriteLine("The door is open");
        }
        public void OpenDoor(bool isExterior)
        {
            if (isExterior)
            {
                Console.WriteLine("Open Front Door.");
            }
            else
            {
                Console.WriteLine("Open Bedroom Door.");
            }
        }

        public void CloseDoor()
        {
            Console.WriteLine("The door is closed");
        }

    }
}