namespace AppPoint;
public class Pointt{
      int x;
      int y;
    public Pointt()
    {}
    public Pointt(int x,int y)
    {
        this.x = x;
        this.y = y;
    }
    public int GetX(){
       return x;
    }
    public void SetX(int x){
        this.x=x;
        }
         public int GetY(){
              return y;
    }
    public void SetY(int w){
        y=w;
        }
        public virtual string ToString(){
            return $"{x} : {y}";
        }
        public int[] GetXY(){
            var n=new int[]{x,y};
           return n;
        }
        public void SetXY(int x,int y){
        this.x=x;
        this.y=y;
        }
        public string Distance(int x,int y){
         
          return $"{this.x-x} :{this.y-y} " ;
          
        }
        public string Distancee(Pointt another){
          return $"{this.x-another.x} : {this.y-another.y}";
        }

          
}
