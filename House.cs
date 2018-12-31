namespace CSharpFun
{
    public class House
    {
        
    string _foundation;
    string _roof;
    string _windows;
    string _doors;
    string _rooms;

    public string Foundation {
        get {
            return _foundation;
        }
        set {
            this._foundation = value;
        }
    }

    public string Roof {
        get {
            return _roof;
        }
        set {
            this._roof = value;
        }
    }

    public string Windows {
        get {
            return _windows;
        }
        set {
            this._windows = value;
        }
    }

    public string Doors {
        get {
            return _doors;
        }
        set {
            this._doors = value;
        }
    }

    public string Rooms {
        get {
            return _rooms;
        }
        set {
            this._rooms = value;
        }
    }
    public void OpenDoor() {

    }
    public void CloseDoor() {

    }

    }
}