// See https://aka.ms/new-console-template for more information

System.Console.WriteLine("Comienzo de la simulacion de tareas");
Random tareas=new Random();
int numeroAleatorio=tareas.Next(1,5);
System.Console.WriteLine("Las tareas a realizar son: "+numeroAleatorio);
//creo las listas
List<Tarea> listaPendientes= new List<Tarea>(); // creacion de listas
string aux;
int duracion;
for (int i = 0; i < numeroAleatorio; i++) //comienzo con el bucle de crear x cantidad de tareas
{
    System.Console.WriteLine("Descripcion de la tarea");    
    aux=Console.ReadLine();
    System.Console.WriteLine(("Dame la duracion de la tarea"));
    duracion=Int32.Parse(Console.ReadLine());
    listaPendientes.Add(new Tarea{TareaId=i+1,Descripcion=aux,Duracion=duracion});    

}
int verdad;
List<Tarea> listaRealizadas= new List<Tarea>();
for (int i = 0; i < numeroAleatorio; i++)
{
    System.Console.WriteLine("Hiciste la tarea con id: "+i+1+" 1-si,2-no");
    verdad=Int32.Parse(Console.ReadLine());
    if (verdad==1)
    {
        //añado a la listaRealizada la tarea
        listaRealizadas.Add(new Tarea{TareaId=i+1,Descripcion=listaPendientes[i].Descripcion,Duracion=listaPendientes[i].Duracion});
        //elimino de la lista de pendientes el id
        listaPendientes.RemoveAt(i); // elimina el elemento de la lista basado en el indice
    }
}
if (listaPendientes.Count>0)
{
    System.Console.WriteLine("Las tareas pendientes a realizar son las siguientes");
    foreach (var item in listaPendientes)
    {
        System.Console.WriteLine("Id de la tarea: "+ item.TareaId);
        System.Console.WriteLine("Descripcion de la tarea"+ item.Descripcion);
        System.Console.WriteLine("Duracion de la tarea: ", item.Duracion);
    }
        
}else{
    System.Console.WriteLine("No hay tareas pendientes");
}

if(listaRealizadas.Count>0){
    System.Console.WriteLine("Las tareas realizadas son: ");
    foreach (var jose in listaRealizadas)
    {
        System.Console.WriteLine("Id de la tarea: "+ jose.TareaId);
        System.Console.WriteLine("Descripcion de la tarea"+ jose.Descripcion);
        System.Console.WriteLine("Duracion de la tarea: ", jose.Duracion);
    }
}else{
    System.Console.WriteLine("No hay tareas realizadas");
}
//inicio de la creacion de la clase
class Tarea
{
    private int pTareaId;
    public int TareaId{
        get{
            return pTareaId;
        }
        set{
            pTareaId=value;
        }
    }
    private string pDescripcion;
    public string Descripcion{
        get{
            return pDescripcion;
        }
        set{
            pDescripcion=value;
        }
    }
    private int pDuracion;
    public int Duracion{
        get{
            return pDuracion;
        }
        set{
            pDuracion=value;
        }
    }
}
