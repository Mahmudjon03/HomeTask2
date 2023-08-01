namespace SystemPoint;

public class Point{

    int _x;
    int _y;
    public Point()
     {
     }
     public Point(int x,int y)
     {
        _x = x;
        _y = y;
    }
    public int GetX(){
        return _x;
    }
     public void SetX( int a){
    _x=a;
     }
     public int GetY(){
        return _y;
     }
     public void SetY(int b){
        _y=b;

     }

     public virtual string ToString(){
            return $" x->{_x} : y->{_y}";
        }

    public int[] GetXY(){
        var n=new int[]{_x,_y};
        return n;
    }
    public void SetXY(int s,int c){
        _x=s;
        _y=c;
    }

    public string  Distance(int r,int m){
       return $"{_x-r}:{_y-m}";
        }
        public string Distancee(Point anoser){
            return $"{_x-anoser._x};{_y-anoser._y}";
        }

}
   