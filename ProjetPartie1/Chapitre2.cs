using System;

class Chapitre2 {

    static void Main() {
        //1) Utilisation de variables

        /*Dans le chapitre 1, nous avons utilisé des "littéraux",
        soit des caractères et chaînes de caractères, entiers,
        réels et booléens écrits directement dans le code
        ('a', "abc", 14, 3.14159, true).
         
        Nous pouvons également stocker ce genre de valeur dans
        une VARIABLE. Un premier avantage de cette dernière est
        qu'elle peut... VARIER tout au long du programme. Un
        deuxième avantage est qu'elle nous permet de stocker
        une information fournie par un usager.
         
        Une variable est forcément d'un certain TYPE:
        un entier est généralement stocké dans une variable int
        un réel est généralement stocké dans une variable double
        un caractère est stocké dans une variable char
        une CHAÎNE de caractères est stockée dans une variable string
        un booléen est stocké dans une variable bool.
         
        EXEMPLES:*/
        int monEntier;
        double monRéel;
        char monCharactère;
        string maChaîne;
        bool monBooléen;

        /*Les 5 lignes qui précèdent sont des lignes de DÉCLARATION: elles déclarent dans le code une certaine variable,
        avec sont type.*/

        monEntier = 78;
        monRéel = 2.718281;
        monCharactère = 'b';
        maChaîne = "Pourquoi?";
        monBooléen = true;

        /*Les 5 lignes qui précèdent sont des lignes D'AFFECTATION (ou "d'assignation): on stocke dans
        chaque varaible une valeur correpsondant à son type.*/

        //Affichons les valeurs de ces cinq varaibles:
        Console.WriteLine(monEntier);
        Console.WriteLine(monRéel);
        Console.WriteLine(monCharactère);
        Console.WriteLine(maChaîne);
        Console.WriteLine(monBooléen);

        /*Il est possible de procéder à la déclaration et à l'affectation en même temps:
        on dira alors que les lignes de code qui suivent sont des DÉCLARATIONS AVEC
        INITIALISATION:*/
        int monEntier2 = 2357;
        double monRéel2 = 4.3;
        var monCharactère2 = 'c';
        string maChaîne2 = "...Covid...?";
        bool monBooléen2 = false;

        /*Dans le chapitre 1, nous avons ÉCRIT (donc AFFICHÉ) à la console
        avec les méthodes WriteLine(...) et Write(...). On
        voudra cependant aussi LIRE de la console des valeurs
        inscrites par l'usager. La méthode à privilégier est
        "ReadLine()" (la méthode "Read()" existe, mais n'offre
        pas d'avantage sur ReadLine).
         
        Détail TRÈS important: ce qui est retourné par
        l'exécution de la méthode "ReadLine()" est PAR
        DÉFINITION une chaîne de caractères. On va donc stocker
        cette chaîne dans une variable de type string.*/
        /*Console.WriteLine("Veuillez inscrire une chaîne de caractères s.v.p.:");
        string saisieConsole = Console.ReadLine();
        Console.WriteLine(saisieConsole);*/
        /*Console.WriteLine("Veuillez inscrire une chaîne de caractère s.v.p.:");
        string saisieConsole = Console.ReadLine();
        Console.WriteLine(saisieConsole);*/

        /*EXERCICE À FAIRE: demandez à l'usager
        d'inscrire une chaîne d'une longueur D'AU MOINS 5.
        Stockez cette chaîne dans une variable de type string
        que vous aurez déclarée. Puis, avec ce que nous avons
        vu à la fin du chapitre 1, affichez chacun des 5
        premiers caractères sur une ligne différente.
        
        EXEMPLE: si la chaîne fournie par l'usager est batman, votre code devrait donc
        répondre en affichant:
        b
        a
        t
        m
        a
        
        */
        Console.WriteLine("Veuillez inscrire une chaîne de caractères de longueur d'au moins 5, s.v.p.:");
        string saisieConsole2 = Console.ReadLine();
        Console.WriteLine(saisieConsole2[0]);
        Console.WriteLine(saisieConsole2[1]);
        Console.WriteLine(saisieConsole2[2]);
        Console.WriteLine(saisieConsole2[3]);
        Console.WriteLine(saisieConsole2[4]);


    }//Fin du Main

}//Fin de la classe Chapitre2