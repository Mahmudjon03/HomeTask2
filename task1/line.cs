namespace  ALine;

using AppPoint;

public class Line:Point{
    Point Begin;
    Point End;
   public Line(int x1,int x2,int y1, int y2)
   {
    Begin.SetXY(x1,x2);
    End.SetXY(y1,y2);
}
  public Line(Point begin,Point end)
  {
    Begin=begin;
    End=end;
  }
  public Point GetBegin(){
    return Begin;
  }
  public void SetBegin(Point begin){
    Begin=begin;
    }
    public Point GetEnd(){
        return End;
  }
  public void SetEnd(Point end){
    End=end;
    }
    public int GetBeginX(){
        return Begin.GetX();
    }
    public void SetBeginX(int a){
         Begin.SetX(a);
    }
    public int GetEndY(int y){
        return End.GetY();
    }
      public void SetBeginY(int f){
         End.SetY(f);
    }
    public int[] GetBeginXY(){
        return Begin.GetXY();
    }
    public void SetBeginXY(int a,int b){
        Begin.SetXY(a,b);
    }
    //-------------------------------------------------
public int GetEndX(){
    return End.GetX();
}
public   void  SetEndX(int a){
    End.SetX(a);
}
public int GetEndY(){
    return End.GetY();
}
public   void  SetEndY(int a){
    Begin.SetY(a);
}
public int[] GetEndXY(){
    return End.GetXY();
}
public void SetEndXY( int a,int b){
End.SetXY(a,b);
}

    public override string ToString()
    {
        return $"begin = ([{Begin.GetXY}),end=({End.GetXY()})]";
    }
   }










    


