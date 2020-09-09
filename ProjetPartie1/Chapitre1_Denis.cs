using System;


namespace ProjetPartie1
{
    class Chapitre1_Denis
    {
        static void Polo()
        {
            Console.WriteLine("Je suis dans la méthode polo");
            /*
            Ceci est un exemple de commentaires multi-lignes.
            Les délimiteurs sont /* et... l'inverse!
            */

            //Ceci est un commentaire sur une seule ligne.
            //Les deux barres obliques font de tout ce qui suit
            //sur a ligne un commentaire.

            /*
            Bonne pratique (obligatoire) d'écriture du code:
            L'INDENTATION. Après chaque début de "bloc de code"
            (donc après une accolade ouvrante), on débute la
            prochaine ligne de code avec l'application d'une touche
            de tabulation (VSC le fait normalement pour vous) pour
            bien montrer que le code qui débute fait partie de ce
            bloc en particulier.
            */

            //1) Premier affichage à la console : la lettre 'a'
            Console.Write('a');
            Console.WriteLine('a');
            //Différence entre les deux: le saut de ligne

            /*
             Les 2 lignes qui précèdent nous montrent le concept
             d'une MÉTHODE, soit une commande qui est envoyée à
             un certain receveur (comme une classe) pour faire
             exécuter une tâche plus ou moins complexe. Ici, le
             receveur est la classe "Console", et les deux méthodes utilisées
             sont "Write" et "WriteLine". Le point (.) sépare le
             receveur de la méthode qui lui est envoyée. TRÈS
             IMPORTANT: le code de "Write" et "WriteLine" doit avoir
             été écrit quelque part dans la classe "Console" pour que
             cette classe puisse comprendre ces méthodes, sinon le
             compilateur signalera une erreur!

             Une méthode a souvent un ARGUMENT, c'est-à-dire un
             élément d'information dont elle a besoin pour faire son
             travail. Ici, il s'agit du caractère 'a'. En effet, si on
             veut faire afficher quelque chose à la console, encore faut-il
             bien spécifier ce que l'on veut afficher!
             */

            //2) Concept de surcharge d'une méthode
            Console.WriteLine();
            Console.WriteLine("a");

            /*Dans les trois lignes de code précédentes - soit
            le premier appel à WriteLine('a') un peu plus haut, et
            les deux lignes directement au-dessus -, nous avons
            TROIS méthodes différentes. Elles ont toutes le même
            nom ("WriteLine"), mais la liste des types d'argument
            est toujours différente:
            cas 1 ==> un caractère ('a')
            cas 2 ==> liste d'arguments vide
            cas 3 ==> une CHAÎNE de caractères (une string)*/

            /*3) Lien entre caractère et CHAÎNE de caractères:
            Chaque élément d'une chaîne de caractères est bien sûr
            un caractère. Pour accéder à un des caractères d'une
            chaîne, on utilise la notation []. IMPORTANT:
            la numérotation des caractères dans une chaîne débute
            à 0, et non à 1, MAIS ÇA COMMENCE À GAUCHE, ET NON À
            DROITE, PUISQU'ON LIT DE GAUCHE À DROITE. Exemples:*/
            Console.WriteLine("abc"[0]);//Affichera a
            Console.WriteLine("abc"[1]);//Affichera b
            Console.WriteLine("abc"[2]);//Affichera c
            /*NOTE IMPORTANTE: les arguments dans les trois
            dernières lignes de code sont toujours des
            CARACTÈRES ('a', 'b' et 'c'), et non la chaîne
            "abc"!*/

            //Mais si on écrit...
            //Console.WriteLine("abc"[3]);
            //Ceci va causer une erreur d'exécution, et non de compilation.

            //4) D'autres exemples de surcharge de la méthode Writeline:
            Console.WriteLine(14);
            //l'argument ici est un nombre entier

            Console.WriteLine(3.14159);
            //L'argument est ici un nombre réel. IMPORTANT: l'écriture des valeurs réelles se fait avec un POINT.

            Console.WriteLine(false);
            /*L'argument est ici une valeur dite booléenne, c'est-
            à-dire pouvant prendre deux valeurs possibles: vrai
            ou faux. true et false sont donc les mots réservés pour
            ces valeurs booléennes.*/

            Console.WriteLine('1');//Argument ==> un caractère, et non un entier
            Console.WriteLine("1");//Argument ==> une chaîne
            Console.WriteLine(1);//Argument ==> un entier
            Console.WriteLine(true);//Argument ==> un boolèen
            Console.WriteLine("True");//Argument ==> une chaîne
        }
        static void Main() // pour tester, mettre Main et changer le main dans la version d'origine
        {
            Console.WriteLine("Calcul matriciel");
            //Chapitre1_Denis.Polo();

            Matrice A = new Matrice(3,5);
            A.Affiche();
            Console.WriteLine("A carre? " + A.TestCarre());

            Matrice B = new MatriceAleatoire(4, 4);
            B.Affiche();
            Console.WriteLine("B carre? " + B.TestCarre());

            Console.WriteLine("B transposee");
            B.Transpose();
            B.Affiche();
            

            Console.WriteLine("Tapez une touche pour terminer");
            Console.ReadKey();

        }//Fin du Main

    }
}
