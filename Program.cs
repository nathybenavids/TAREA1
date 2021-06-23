using System;

namespace Tarea1
{
    class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("HOLA, BIENVENID@");
        }
            class MarioBros
    {
            static void Main(string[]args)
    {

                Console.WriteLine("BIENVENID@ al mundo de Mario Bros :)");

                Console.Write("Escriba su nombre: ");
                string nombre = Console.ReadLine();

                Console.Write("Escriba su edad: ");
                string edad = Console.ReadLine();
                int edad1 = int.Parse(edad);

                Console.Write("¿Desde que edad jugo Mario Bros?: ");
                string edadJugando = Console.ReadLine();
                int edadJugando1 = int.Parse(edadJugando);

                Console.Write("Escriba el nombre de un personaje de Mario Bros: ");
                string personaje = Console.ReadLine();

                Console.Write("Escriba el nombre del Hermano de Mario Bros: ");
                string hermano = Console.ReadLine();

                Console.Write("Juego que mas le guste de Mario Bros: ");
                string juego = Console.ReadLine();

                Console.Write("¿Que es lo que mas le gusta de los video juegos? ");
                string cosaFavJuego = Console.ReadLine();

                Console.Write("¿Cuantas horas seguidas juega Mario Bros? ");
                string horasJugando = Console.ReadLine();
                int horasJugando1 = int.Parse(horasJugando);

                Console.Write("¿Le gustaria recibir informacion por correo sobre las novedades de Mario Bros? Responda si/no: ");
                string info = Console.ReadLine().ToUpper();
                bool info1 = info == "si";

                Console.Write("Escriba su correo electronico: ");
                string correo = Console.ReadLine();
                bool correo1 = correo == "@";

            }
        }
    }
}
class Marvel
{
    static void Main(string[] args)
    {

        Console.WriteLine("BIENVENID@ al Universo de Marvel :)");

        Console.Write("Escriba su nombre: ");
        string nombre = Console.ReadLine();

        Console.Write("Escriba su edad: ");
        string edad = Console.ReadLine();
        int edad1 = int.Parse(edad);

        Console.Write("Ingrese su comic de marvel favorito: ");
        string comicFav = Console.ReadLine();      

        Console.Write("Escriba el superheroe que mas le guste : ");
        string heroeFav = Console.ReadLine();

        Console.Write("Ingrese su personaje favorito de Los Vengadores: ");
        string  personajeFav = Console.ReadLine();

        Console.Write("¿Quien es el creador del universo de Marvel? : ");
        string creadorMarvel = Console.ReadLine();

        Console.Write("¿Cuantas peliculas de Marvel cree que existan?: ");
        string pelis = Console.ReadLine();
        int pelis1 = int.Parse(pelis);

        Console.Write("¿Cual es su pelicula favorita de Marvel?: ");
        string peliFav = Console.ReadLine();      

        Console.Write("¿Le gustaria recibir informacion por correo sobre las novedades deL Universo de Marvel? Responda si/no: ");
        string info = Console.ReadLine().ToUpper();
        bool info1 = info == "si";

        Console.Write("Escriba su correo electronico");
        string correo = Console.ReadLine();
        bool correo1 = correo == "@";

    }
}
  
      class Comics
{
    static void Main(string[] args)
    {

        Console.WriteLine("BIENVENID@ a la seccion de Comics :)");

        Console.Write("Escriba su nombre: ");
        string nombre = Console.ReadLine();

        Console.Write("Escriba su edad: ");
        string edad = Console.ReadLine();
        int edad1 = int.Parse(edad);

        Console.Write("¿Cual fue su primer comic?: ");
        string primerComic = Console.ReadLine();       

        Console.Write("¿Cual es su comic favorito?: ");
        string comicFav = Console.ReadLine();

        Console.Write("Escriba el personaje malvado de su comic favorito: ");
        string pesonajeMalvado = Console.ReadLine();

        Console.Write("Escriba el comic con el que mas se relacione con usted: ");
        string comicRelacion = Console.ReadLine();

        Console.Write("¿Cuantos comics ah leido? ");
        string comicsLeidos = Console.ReadLine();
        int comicsLeidos1 = int.Parse(comicsLeidos);

        Console.Write("¿Cuantas horas dedica al dia para leer un comic?: ");
        string horasLeerComic = Console.ReadLine();
        int horasLeerComic1 = int.Parse(horasLeerComic);

        Console.Write("¿Le gustaria recibir informacion por correo sobre las novedades de Mario Bros? Responda si/no: ");
        string info = Console.ReadLine().ToUpper();
        bool info1 = info == "si";

        Console.Write("Escriba su correo electronico");
        string correo = Console.ReadLine();
        bool correo1 = correo == "@";

    }
}
 
      class Batman
{
    static void Main(string[] args)
    {

        Console.WriteLine("BIENVENID@ al juego de Batman:)");

        Console.Write("Escriba un nombre para su personaje: ");
        string nombrePesonaje = Console.ReadLine();

        Console.Write("Escriba la mejor destreza de su personaje: ");
        string destrezaPersonaje = Console.ReadLine();
        
        Console.Write("Escriba el villano contra el que quiera pelear: ");
        string villano = Console.ReadLine();

        Console.Write("Escriba cuantos rounds quiere jugar: ");
        string rounds = Console.ReadLine();
        int round1 = int.Parse(rounds);

        Console.Write("Escriba la debilidad de su personaje: ");
        string debilidadPersonaje = Console.ReadLine();

        Console.Write("Escriba la duracion de su partida: ");
        string duracionPartida = Console.ReadLine();
        int duracionPartida1 = int.Parse(duracionPartida);

        Console.Write("Escriba cuantas veces a ganado su personaje: ");
        string partidasGanadas = Console.ReadLine();
        int paridasGanadas1 = int.Parse(partidasGanadas);

        Console.Write("Escriba cuantas veces a perdido su personaje: ");
        string partidasPerdidas = Console.ReadLine();
        int partidasPerdidas1 = int.Parse(partidasPerdidas);

        Console.Write("¿Le gusto el juego? Responda si/no: ");
        string siGusto = Console.ReadLine().ToUpper();
        bool siGuso1 = siGusto == "si";

        Console.Write("¿Volveria a jugar? Responda si/no: ");
        string siVuelve = Console.ReadLine().ToUpper();
        bool siVuelve1 = siVuelve == "si";


    }
}
class Superman
{
    static void Main(string[] args)
    {

        Console.WriteLine("BIENVENID@ al juego de Superman:)");

        Console.Write("Escriba un nombre para su personaje: ");
        string nombrePesonaje = Console.ReadLine();

        Console.Write("Escriba la destreza para su personaje: ");
        string destrezaPersonaje = Console.ReadLine();

        Console.Write("Escriba el villano contra el que quiera pelear: ");
        string villano = Console.ReadLine();

        Console.Write("Escriba cuantos rounds quiere jugar: ");
        string rounds = Console.ReadLine();
        int round1 = int.Parse(rounds);

        Console.Write("Escriba la debilidad para su personaje: ");
        string debilidadPersonaje = Console.ReadLine();

        Console.Write("Escriba la duracion de su partida: ");
        string duracionPartida = Console.ReadLine();
        int duracionPartida1 = int.Parse(duracionPartida);

        Console.Write("Escriba cuantas veces a ganado su personaje: ");
        string partidasGanadas = Console.ReadLine();
        int paridasGanadas1 = int.Parse(partidasGanadas);

        Console.Write("Escriba cuantas veces a perdido su personaje: ");
        string partidasPerdidas = Console.ReadLine();
        int partidasPerdidas1 = int.Parse(partidasPerdidas);

        Console.Write("¿Le gustaria recibir informacion por correo sobre las novedades de Sobre el juego de Superman? Responda si/no: ");
        string info = Console.ReadLine().ToUpper();
        bool info1 = info == "si";

        Console.Write("Escriba su correo electronico");
        string correo = Console.ReadLine();
        bool correo1 = correo == "@";

    }
}
