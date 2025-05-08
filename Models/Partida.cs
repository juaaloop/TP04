class Partida
{
    public string palabra { get; private set; }
    public List<char> letrasCorrectas { get; private set; }
    public List<char> letrasFallidas { get; private set; }
    public int cantIntentos { get; private set; }
    public Partida(string Palabra)
    {
        palabra = Palabra.ToUpper();
        foreach (char letra in palabra)
        {
            letrasCorrectas.Add('_');
        }
        cantIntentos = 6;
    }

    public bool siSeUso(char letra)
    {
        bool siSeUso = false;
        siSeUso = buscarLetra(letra, letrasCorrectas);
        if (!siSeUso) { siSeUso = buscarLetra(letra, letrasFallidas); }
        return siSeUso;

    }
    public bool esCorrecta(char letra)
    {
        bool esCorrecta = false;
        for (int i = 0; i < palabra.Length; i++)
        {
            if (palabra[i] == letra)
            {
                letrasCorrectas[i] = letra;
                esCorrecta = true;
            }
        }
        if (!esCorrecta)
        {
            if (!letrasFallidas.Contains(letra))
            {
                letrasFallidas.Add(letra);
                cantIntentos--;
            }
        }
        return esCorrecta;
    }
    public bool encontroLaPalabra(string palabraArriesgada)
    {
        bool encontrada = false;
        if (palabraArriesgada == palabra)
        {
            encontrada = true;
        }
        return encontrada;
    }
    public bool encontroLaPalabra()
    {
        bool encontrada = true;
        foreach (char letra in palabra)
        {
            for (int i = 0; i < palabra.Length; i++)
            {
                if (palabra[i] == letra)
                {
                    letrasCorrectas[i] = letra;
                }
            }
        }
        foreach (char c in letrasCorrectas)
        {
            if (c == '_')
            {
                encontrada = false;
            }

        }
        return encontrada;
    }

    public bool buscarLetra(char letra, List<char> listaABuscar)
    {
        bool seEncontro = false;
        int i = 0;
        while (!seEncontro && i < listaABuscar.Count())
        {
            if (listaABuscar[i] == letra)
            {
                seEncontro = true;
            }
            else { i++; }
        }
        return seEncontro;
    }
    public bool buscarLetra(char letra, string palabra)
    {
        bool seEncontro = false;
        int i = 0;
        while (!seEncontro && i < palabra.Count())
        {
            if (palabra[i] == letra)
            {
                seEncontro = true;
            }
            else { i++; }
        }
        return seEncontro;
    }
}