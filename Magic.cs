String a, b;
Console.WriteLine("Entres un plages Minimal");
a = Console.ReadLine();

Console.WriteLine("Entres un plages Maximal");
b= Console.ReadLine();
int x, y;
try
{
    x= Convert.ToInt32(a);
    y= Convert.ToInt32(b);
    while (y < x)
    {

        try
        {
            Console.WriteLine("Donner un nombre maximal Superieur a "+a);
            b=Console.ReadLine();
            y= Convert.ToInt32(b);
        }
        catch (Exception)
        {
            Console.WriteLine("Veuiller entres une valeur entier!! \n");
        }
    }

    Random rd = new Random();
    int compare = rd.Next(x,y);
    int joueur = compare++;
    int tenter = 10;
    while ( (compare != joueur) && (tenter != 0) )
    {
        try
        {
            Console.WriteLine(" vous avez "+ tenter-- + " fois pour tenter de Gagner ");
            b = Console.ReadLine();
            joueur = Convert.ToInt32(b);
            if ( joueur < compare)
            {
                Console.WriteLine("plus grand !\n");
            }
            else if (joueur > compare)
            {
                Console.WriteLine("plus petit\n");
            } else
            {
                Console.WriteLine("Bien Jouer Vous Avez Ganger !\n\n");
            }
         if (tenter == 0)
            {
                Console.WriteLine("Dommage ! vous avez perdu ! le numero magique est : "+compare+" \n\n");
            }
        }
        catch (Exception)
        {
            Console.WriteLine("Veuiller entres une valeur entier!! \n");
        }
    }

}
catch(Exception)
{
    Console.WriteLine("Veuiller entres des valeurs entiers");
}