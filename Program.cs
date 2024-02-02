using System;

class OrdemAlfabetica{
    static void Main(){
        Console.WriteLine("DIGITE UMA LISTA DE PALAVRAS QUE VOU ORDERNAR POR ORDEM ALFABÉTICA");

        Console.WriteLine("Quantas palabras deseja salvar?");
        string numPalavras = Console.ReadLine();

        int numPalavrasArray = Convert.ToInt32(numPalavras);


        string[] arrayPalavras;
        arrayPalavras = new string[numPalavrasArray];

        for(int index = 0; index < numPalavrasArray; index++){
            Console.WriteLine($"digite: {index}");

            string palavra = Console.ReadLine();

            arrayPalavras[index] = palavra;
        }

        string[] arrayPalavrasOrdenadas = arrayPalavras.OrderBy(p => p).ToArray();

        foreach(var i in arrayPalavrasOrdenadas){
            Console.WriteLine(i);
        }
    }
}