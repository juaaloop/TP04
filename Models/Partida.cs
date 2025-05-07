class Partida
{
    public string palabra { get; private set; }
    public List<char> letrasCorrectas { get; private set; }
    public List<char> letrasFallidas { get; private set; }
    public int cantIntentos { get; private set; }
    public Partida(string Palabra)
    {
        palabra = Palabra;
        foreach(char letra in palabra){
            letrasCorrectas.Add('_');
        }
    }

    public bool siSeUso(char letra){
        bool siSeUso= false;
        siSeUso = buscarLetra(letra,letrasCorrectas);
        if(!siSeUso){siSeUso = buscarLetra(letra,letrasFallidas);}
        return siSeUso;

    }
    public bool esCorrecta (char letra)
    {
        bool esCorrecta = false;
        esCorrecta = buscarLetra(letra, palabra);
        if(esCorrecta){
            foreach(char letr)
        letrasCorrectas[palabra.IndexOf(letra)]=letra;
        }else{
            letrasFallidas.Add(letra);
        }
        cantIntentos++;
        return esCorrecta;
    }
    public bool encontroLaPalabra(string palabraArriesgada){
        bool encontrada = false;
        if(palabraArriesgada == palabra){
            encontrada = true;
        }
        return encontrada;
    }
     public bool encontroLaPalabra(){
         bool encontrada = true;
         bool estaLaLetra = false;
         int i = 0;
         while(encontrada && i<palabra.Count()){
            estaLaLetra = buscarLetra(palabra[i],letrasCorrectas);
            if(!estaLaLetra){
            encontrada= false;
            }else{
                i++;
            }
         }
         return encontrada;
    }

    public bool buscarLetra(char letra, List<char> listaABuscar){
        bool seEncontro= false;
        int i = 0;
        while(!seEncontro && i<listaABuscar.Count()){
           if(listaABuscar[i] == letra){
            seEncontro=true;
           }else{i++;}
        }
        return seEncontro;
    }
      public bool buscarLetra(char letra, string palabra){
        bool seEncontro= false;
        int i = 0;
        while(!seEncontro && i<palabra.Count()){
           if(palabra[i] == letra){
            seEncontro=true;
           }else{i++;}
        }
        return seEncontro;
    }



}