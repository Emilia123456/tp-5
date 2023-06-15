public static class Escape{
    static string[] incognitasSalas(){
        string[] respuestaC = new string[7];
        return respuestaC;
    }


    private static void InicializarJuego(string[] respuestaC){
        respuestaC[0]="DUELE";
        respuestaC[1]="DUELE";
        respuestaC[2]="SI";
        respuestaC[3]="SI";
        respuestaC[4]="DUELE";
        respuestaC[5]="PRESION";
        respuestaC[6]="430";
        respuestaC[6]="SIN";
    }


    static int estadoJuego=1;


    public static int GetEstadoJuego(int estadoJuego){
        return estadoJuego;
    }


    public static bool ResolverSala(string respuesta, string[]respuestaC, int estadoJuego){
        bool correcto=false;
        if (respuesta==respuestaC[estadoJuego-1]){
            correcto=true;
        }
        return correcto;
    }
   
}
