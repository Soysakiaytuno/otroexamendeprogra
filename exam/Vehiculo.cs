public class Vehiculo{
    private string energia = "";
    private string marca = "";
    private string modelo = "";
    private string dueño = "";
    public string getenergia(){
        return energia;
    }
    public void setenergia(string e){
        energia = e;
    }
    public void registrar(){
        Console.Write("Ingrese la marca: ");
        marca = Console.ReadLine();
        Console.Write("Ingrese el modelo: ");
        modelo = Console.ReadLine();
        Console.Write("Ingrese su nombre: ");
        dueño = Console.ReadLine();
    }
    public void mostrardatos(){
        Console.Write("El modelo: ");
        Console.WriteLine(modelo);
        Console.Write("La marca: ");
        Console.WriteLine(marca);
        Console.Write("Esta a nombre de: ");
        Console.WriteLine(dueño);
    }
    public virtual void moverse(){
        Console.WriteLine("Escriba cuantos kilometros debe moverse: ");
        string x = Console.ReadLine();
        Console.Write("Te moviste ");
        Console.Write(x);
        Console.Write(" kilometros");
    }
}