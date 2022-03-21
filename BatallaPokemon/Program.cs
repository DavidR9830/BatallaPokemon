// Programa que realiza una batalla de pokemón y determina cual es el ganador
int vidaPikachu = 100, vidaJiggypuff = 100, pikachuAtaque = 55, jiggypuffAtaque = 45,  turno = 1;
while (vidaPikachu > 0 & vidaJiggypuff > 0)
{
    if (turno == 1)
    {
        vidaJiggypuff = vidaJiggypuff - pikachuAtaque;
        turno = 0;
    }
    else 
    {
        vidaPikachu = vidaPikachu - jiggypuffAtaque;
        turno = 1;
    }
}
if (vidaPikachu <= 0)
{
    Console.WriteLine("jiggypuff es el ganador");
}
else
{
    Console.WriteLine("Pikachu es el ganador");
}