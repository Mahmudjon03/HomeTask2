using SystemPoint;
namespace Acircle;

class Circle:Point{
     Point _senter;
     double _radius;
    public Circle()
{
    
}
public Circle(int x,int y,double radius):base(x,y)
{
        _radius = radius;
        }

        public double GetRadius(){
            return _radius;
        }
        public void SetRadius(double rad){
            _radius=rad;
      }
      public Point GetSarter(){
        return _senter;
      }
      public void SetSeter(Point sentr){
   _senter=sentr; 
      }

      public int GetSenterX(){
        return GetX();
      }
      public void SetSenterX(int f){
       SetX(f);
      }
      public int[] GeetXY(){
        return GetXY();
      }
      public void SeetXY(int d,int l){
        SetXY(d,l);
      }
    public override string ToString()
    {
        return $" Circle[ center ({base.ToString()}) radius- ({_radius}) ]";
    }
    public double GetArea(){
      return 3.14*_radius*_radius;
    }
    public double GEtCircumferens(){
      return 2*_radius*3.14;
    }
    public string Distansc(Point anod){
       return $"{Distancee(anod)}";
    }

   
}

 