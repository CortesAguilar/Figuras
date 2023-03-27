abstract class Figura
{  
  
    public string Color {get; set;}
    public List<Vertice>  vertices = new List<Vertice>();
    public double Area {get; set;}
    public double Perimetro {get; set;}
    public Figura(string color)
    {
        Color = color;
    } 
   
    public abstract void  Dibujar();
    public abstract double  CalcularArea();
    public void DeclararVertices(int numVertices)
    {
        for(int i = 1; i <= numVertices; i++)
        {   
            Console.Write($"Inserte la coordenada cartesiana x del vertice {i}: ");    
            int x = int.Parse(Console.ReadLine());

            Console.Write($"\nInserte la coordenada cartesiana y del vertice {i}: ");    
            int y = int.Parse(Console.ReadLine());
            
            vertices.Add(new Vertice(x,y));
            Console.Clear();
        }
    }
}


class Rectangulo:Figura
{
    public double Base {get; set;}
    public double Altura {get; set;}

    public Rectangulo(string color):base(color)
    {
        DeclararVertices(4);
        
    }   
    public override double CalcularArea() => Base*Altura;
    public override void Dibujar() => Console.WriteLine("Se dibuja un rectangulo");
}

class Vertice
{
    public int X {get; set;}
    public int Y {get; set;}

    public Vertice(int x, int y)
    {
        X = x;
        Y = y;
    }
}
