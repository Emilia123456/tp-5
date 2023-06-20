public static class Escape{
   static string[] incognitasSalas = new string[8];
    static int estadoJuego=1;
    public static int sancion=0;
    public static void InicializarJuego(){
        incognitasSalas[0]="DUELE";
        incognitasSalas[1]="DUELE";
        incognitasSalas[2]="SI";
        incognitasSalas[3]="SI";
        incognitasSalas[4]="PERMISO";
        incognitasSalas[5]="PRESION";
        incognitasSalas[6]="430";
        incognitasSalas[7]="SIN";
    }
    public static int sumarSancion(){
        sancion++;
        return sancion;
    }
   public static int GetEstadoJuego(){
        if (estadoJuego == 1){
            InicializarJuego();
        }
        return estadoJuego;
    }
    public static bool ResolverSala(string respuesta, int sala){
        
        if (incognitasSalas[sala-1]!=respuesta) 
        {
            sancion++;
            return false;
        }
        else
        {
            
            estadoJuego=estadoJuego+1;
            return true;
        }

    }
   
}