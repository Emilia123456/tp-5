public static class Escape{
    static string[] incognitasSalas(){
        string[] respuestaC = new string[7];
        return respuestaC;
    }


    private static void InicializarJuego(string[] respuestaC){
        respuestaC[0]="Dolor de panza";
        respuestaC[1]="me duele la panza";
        respuestaC[2]="si";
        respuestaC[3]="si";
        respuestaC[4]="Me duele la panza, tengo el permiso de la coordinadora";
        respuestaC[5]="se me bajó la presión, me mandaron a comprarme un guaymallen";
        respuestaC[6]="430";
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
