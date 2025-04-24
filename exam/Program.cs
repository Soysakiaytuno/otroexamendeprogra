    Console.WriteLine("Vehiculos!");
    Console.WriteLine();
    bool inicio = true;
while(inicio){
    Console.WriteLine("Escoja un tipo de vehiculo a usar (Bicicleta, Moto, AutoElectrico)");
    Console.WriteLine("Si no quiere nada escriba salir");
    bool autos = true;
    string auto = Console.ReadLine();
    auto.ToLower();
    auto.Replace(" ", "");
    auto.Trim();
    if(auto == "bicicleta"){
        Bicicleta mibici = new Bicicleta();
        mibici.registrar();
        Console.WriteLine("Auto registrado!");
        while(autos){
            Console.WriteLine("Que quieres hacer con el auto?");
            Console.WriteLine("Si quiere ver detalles escriba Ver");
            Console.WriteLine("Si quiere ir a algun lado escriba moverse");
            Console.WriteLine("Si va a devolver el auto escriba devolver");
            string action = Console.ReadLine();
            action.ToLower();
            if(action == "ver"){
                mibici.mostrardatos();
                Console.WriteLine();
            }
            else if(action == "moverse"){
                mibici.moverse();
                Console.WriteLine();
            }
            else if(action == "devolver"){
                autos = false;
                Console.WriteLine();
            }
            else{
                Console.WriteLine("Ingrese un comando valido");
            }
        }
    }
    else if(auto == "autoelectrico"){
        Autoelectrico miauto = new Autoelectrico();
        miauto.registrar();
        Console.WriteLine("Auto registrado!");
        while(autos){
            Console.WriteLine("Que quieres hacer con el auto?");
            Console.WriteLine("Si quiere ver detalles escriba Ver");
            Console.WriteLine("Si quiere ir a algun lado escriba moverse");
            Console.WriteLine("Si va a devolver el auto escriba devolver");
            string action = Console.ReadLine();
            action.ToLower();
            if(action == "ver"){
                miauto.mostrardatos();
                Console.WriteLine();
            }
            else if(action == "moverse"){
                miauto.moverse();
                Console.WriteLine();
            }
            else if(action == "devolver"){
                autos = false;
                Console.WriteLine();
            }
            else{
                Console.WriteLine("Ingrese un comando valido");
            }
        }
    }
    else if(auto == "moto"){
        Moto mimoto = new Moto();
        mimoto.registrar();
        Console.WriteLine("Auto registrado!");
        Console.WriteLine();
        while(autos){
            Console.WriteLine("Que quieres hacer con el auto?");
            Console.WriteLine("Si quiere ver detalles escriba Ver");
            Console.WriteLine("Si quiere ir a algun lado escriba moverse");
            Console.WriteLine("Si va a devolver el auto escriba devolver");
            string action = Console.ReadLine();
            action.ToLower();
            if(action == "ver"){
                mimoto.mostrardatos();
                Console.WriteLine();
            }
            else if(action == "moverse"){
                mimoto.moverse();
                Console.WriteLine();
            }
            else if(action == "devolver"){
                autos = false;
                Console.WriteLine();
            }
            else{
                Console.WriteLine("Ingrese un comando valido");
                Console.WriteLine();
            }
        }
    }
    else if(auto == "salir"){
        inicio = false;
    }
    else{
        Console.WriteLine("No puedes usar eso, registra un Auto Electrico, Moto o Bicicleta");
    }
}