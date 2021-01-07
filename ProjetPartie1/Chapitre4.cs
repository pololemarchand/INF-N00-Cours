using System;

class Chapitre4 {
    //LES MÉTHODES PERSONNALISÉES!

    /*Une méthode est un bloc de code destiné à accomplir une
    tâche en particulier. Le fait que cette tâche soit
    encapsulée à l'intérieur de cette méthode fait en sorte
    que cette dernière peut être appelée de différents endroits,
    et chaque fois, la même tâche sera réexécutée.
    
    Une méthode peut ou peut ne pas retourner quelque chose,
    et elle peut ou peut ne pas avoir de paramètres nécessaires
    à l'exécution de sa tâche.
    
    Premier exemple: une méthode qui n'a aucun paramètre et qui ne
    retourne rien:*/

    static void AfficherMessageToucheEnter() {
        //Ceci est la DÉFINITION de la méthode
        /*C'est tout comme f(x) = 3x... sauf qu'ici il n'y a même pas de "x", puisque ce n'est même pas nécessaire!*/
        Console.WriteLine("Appuyez sur la touche ENTER pour continuer.");
        Console.ReadLine();/*NOTE IMPORTANTE: jusqu'à présent, lorsqu'on utilisait "ReadLine()", il y avait toujours, à GAUCHE de l'appel à la méthode, une déclaration de variable de type string avec le symbole d'affectation (=). Ceci était pour stocker l'information (la chaîne de caractères) qui provenait de la console. Dans ce cas-ci, on se sert du ReadLine() simplement pour "débloquer" la ligne de code. Nous n'avons donc pas besoin de "retenir" quelque chaîne que ce soit venant de la console.*/
    }//Fin de la méthode

    /*Exemple d'une méthode qui retourne un booléenet qui a des paramètres*/
    static bool EstDivisiblePar(int dividende, int diviseur) {
        int reste = dividende % diviseur;
        bool réponse = reste == 0;
        return réponse;
        /*Une version plus rapide aurait été:
        return dividende % diviseur == 0;*/
    }

    static void AfficherParitéVersion1(int unEntier) {
        //Cette méthode ne retourne rien, MAIS elle a un paramètre
        Console.WriteLine("Cet entier est {0}", EstDivisiblePar(unEntier, 2) ? "pair." : "impair.");
        /*Bien que le code de cette méthode soit très court (une ligne), il fait tout de même deux opérations distinctes: un affichage à la console (en raison de WriteLine) et le test de la parité, avec l'appel à "EstDivisiblePar"*/
    }

    static string ChaîneParité(int entierATester) {
        /*Cette méthode prend un entier en paramètre et retourne la chaîne "Ce nombre est pair" (...ou impair...), mais ne fait aucun affichage à la console.*/
        string chaîneRéponse = "Cet entier est " + (EstDivisiblePar(entierATester, 2) ? "pair" : "impair");
        return chaîneRéponse;
        /*VERSION PLUS RAPIDE:
        return "Cet entier est " + (EstDivisiblePar(entierATester, 2) ? "pair" : "impair");
        */
    }

    static void AfficherParitéVersion2(int unEntierATester) {
        /*Cette méthode, contrairement à la "version 1", se charge uniquement de faire l'affichage à la console. Ce n'est pas sa responsabilité de construire la chaîne. Elle remet plutôt cette responsabilité à la méthode "ChaîneParité(...)"*/
        Console.WriteLine(ChaîneParité(unEntierATester));
    }

    static bool EstUneAnnéeDeFinDeSiècle(int uneAnnée) {
        return EstDivisiblePar(uneAnnée, 100);
    }


    static bool EstUneAnnéeBissextile(int année) {
        return EstUneAnnéeDeFinDeSiècle(année) ? EstDivisiblePar(année, 400) : EstDivisiblePar(année, 4);

    }

    static void Main() {
        AfficherMessageToucheEnter();
        /*Ceci est un APPEL SPÉCIFIQUE à la méthode. C'est comme f(2), f(3), f(4)...*/

        int n1 = SaisiesConsoleValides.saisirEntierConsole();
        int n2 = SaisiesConsoleValides.saisirEntierConsole();

        bool n1EDPn2 = EstDivisiblePar(n1, n2);
        Console.WriteLine("{0} est-il un diviseur de {1}? {2}", n2, n1, n1EDPn2 ? "Oui" : "Non");

        Console.WriteLine("Par ailleurs, concernant le premier nombre ({0})...", n1);
        AfficherParitéVersion1(n1);
        Console.WriteLine("D'autre part, concernant le deuxième nombre ({0})...", n2);
        AfficherParitéVersion2(n2);

        Console.WriteLine("Testons si une année est bissextile!");
        int uneAnnéeATester = SaisiesConsoleValides.saisirEntierConsoleDeA(1000, 2000);
        Console.WriteLine("Cette année, {0}, {1} bissextile.", uneAnnéeATester, EstUneAnnéeBissextile(uneAnnéeATester) ? "est" : "n'est pas");
    }//Fin du Main
}//Fin de la classe