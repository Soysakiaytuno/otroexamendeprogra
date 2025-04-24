public class Autoelectrico : Vehiculo{
    public Autoelectrico(){
        base.setenergia("Electricidad"); 
    }
    public override void moverse(){
        Console.WriteLine("Escriba cuantos kilometros debe moverse: ");
        string x = Console.ReadLine();
        Console.Write("Te moviste ");
        Console.Write(x);
        Console.WriteLine(" kilometros");
        Console.Write("Se ha gastado ");
        Console.WriteLine(getenergia());
    }
}