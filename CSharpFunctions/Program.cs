
/*//------- LE MIE FUNZIONI --------------------------------

void StampaMessaggioPerTutti(string nome)
{
    Console.WriteLine("Ciao a tutti! In particolare " + nome);
}

void StampaSoloIlNome(string nome)
{
    Console.WriteLine("Ciao " + nome);
}


// Creiamo una funzione che stampiamo a video un array
void StampaArrayInteri(int[] array)
{
    int ultimoIndiceArray = array.Length - 1;

    Console.Write("[");

    for (int i = 0; i < array.Length; i++)
    {
        if (i == ultimoIndiceArray)
        {
            Console.Write(array[i]);
        }
        else
        {
            Console.Write(array[i] + ", ");
        }
    }

    Console.WriteLine("]");
}


int SommaElementiArray(int[] array)
{
    int somma = 0;
    for (int i = 0; i < array.Length; i++)
    {
        somma = somma + array[i];
    }
    return somma;
}

double CalcolaMediaArray(int[] array)
{
    int sommaArray = SommaElementiArray(array);
    double media = (double)sommaArray / array.Length;
    return media;
}

int sommaNumeriInteri(int addendo1, int addendo2, int addendo3)
{
    int risultato = addendo1 + addendo2 + addendo3;
    if (risultato > 10)
    {
        return risultato;
    }

    return 0;
}



    void CalcoloMatematico(){
    // risultato di 2+(5x5)

    int calcoloParen = calcoloParentesi(5 , 5);//x=25
    int interoproblema = calcoloIntero(calcoloParen, 2);
    Console.WriteLine(interoproblema + "queso è il risultato dell'esercizio base");
}

int calcoloIntero(int calcoloParentesi, int x)
{
    return calcoloParentesi + x;
}

int calcoloParentesi(int x, int y){
    return x * y;
}

int decrementaNumero(int numero)
{
    numero = numero - 1;
    return numero;
}

int[] sommaUnoATuttiGliElementiArray(int[] array)
{
    int[] arrayNuovo = (int[])array.Clone();
    for (int i = 0; i < arrayNuovo.Length; i++)
    {
        arrayNuovo[i] = arrayNuovo[i] + 1;
    }
    return arrayNuovo;
}

string modificaStringa(ref string s)
{
    s = "a tutti";
    return s;
}





// -------------- PROGRAMMA PRINCIPALE ----------------------------------------
int mioNumero = 2;
int numeroModifica = decrementaNumero(mioNumero);
CalcoloMatematico();
int[] arrayDiNumeri = { 1, 6, 9, 10 };
int[] arrayDiNumeriNuovo = sommaUnoATuttiGliElementiArray(arrayDiNumeri);


StampaArrayInteri(arrayDiNumeri);
StampaArrayInteri(arrayDiNumeriNuovo);


string stringa = "ciao";
modificaStringa(ref stringa);
Console.WriteLine(stringa);


Console.WriteLine(mioNumero);


int sommaTreNumeri = sommaNumeriInteri(2, 6, 4);
Console.WriteLine(sommaTreNumeri);


StampaArrayInteri(arrayDiNumeri);

int somma = SommaElementiArray(arrayDiNumeri);
double media = CalcolaMediaArray(arrayDiNumeri);

Console.WriteLine(somma);
Console.WriteLine(media);*/


// INT ARRAY 
void StampaArray(int [] array)
{
    Console.Write("[");
    for(int i=0;i < array.Length; i++)
    {
        if (i == array.Length - 1)
        {
            Console.Write(array[i]);
        }
        else
        {
        Console.Write(array[i]+", ");
        }

    }
    Console.Write("]");
}


//--------- INIZIO ESERCIZIO 



int[] arrayDiNumeri = { 1, 6, 9, 10 };
StampaArray(arrayDiNumeri);









