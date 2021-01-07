using System;

class Chapitre3 {
    static void Main() {
        /*Commençons à effectuer certaines opérations avec des
        littéraux et des variables, et en particulier ENTRE
        des littéraux et des variables.*/

        /*1) Les opérateurs les plus fréquemment utilisés:
        les opérateurs BINAIRES, soit ceux s'appliquant à
        DEUX opérandes, situés de chaque côté de l'opérateur.
         
         1A) Les opérateurs binaires ARITHMÉTIQUES
            les deux opérateurs additifs:
            + pour l'addition
            - pour la soustraction
         
            les trois opérateurs multiplicatifs:
            * pour la multiplication
            / pour la division
            % pour le modulo (reste)
         
         EXEMPLES:*/
        Console.WriteLine("LES OPÉRATEURS BINAIRES!");
        Console.WriteLine();
        Console.Write("Exemple d'addition entre deux littéraux ENTIERS: 2 + 3 = ");
        Console.WriteLine(2 + 3);
        Console.WriteLine();

        int unNombre1 = 4;
        Console.WriteLine("Exemple de soustraction entre une variable et un littéral entier: 4 - 5 = {0}", unNombre1 - 5);
        /*Dans ce qui précède, nous avons un exemple de chaîne
        FORMATTÉE: elle contient au moins un marqueur ({}),
        dont la valeur sera remplacée par un argument subséquent,
        dans l'appel de la méthode. Il peut y avoir PLUSIEURS
        marqueurs, et ils commencent à 0! Ici, il n'y a qu'un seul
        marqueur, et c'est donc {0}. Sa valeur est remplacée dans
        l'affichage par le résultat de unNombre1 - 5. Il doit
        toujours y avoir suffisamment d'arguments APRÈS la chaîne
        d'affichage que ce que les marqueurs requièrent. Ex.:
        s'il y a un marqueur {2}, ça prend au moins trois arguments
        après la chaîne pour tenir compte de {0}{1}{2}. S'il y a
        un marqueur {4}, ça prend au moins 5 arguments après la
        chaîne pour tenir compte de {0}{1}{2}{3}{4}. Si ceci n'est
        pas respecté, il y aura une erreur D'EXÉCUTION.*/

        int unNombre2 = 6;
        int unNombre3 = 7;
        Console.WriteLine("Exemple de {3} entre {2} {0} {6}: 6 X 7 = {5}", "variables", 22, "deux", "multiplication", "toto", unNombre2 * unNombre3, "entières");
        Console.WriteLine();
        /*À bien noter la bonne position et la bonne valeur de
        chaque marqueur dans la chaîne formattée qui précède.*/

        Console.WriteLine("Exemple d'addition entre deux littéraux RÉELS: 2,1 + 3,4 = {0}", 2.1 + 3.4);
        Console.WriteLine();
        /*NOTE TRÈS IMPORTANTE: tout comme le principe de surcharge
        existe pour DES MÉTHODES comme Write et WriteLine (ex.:
        soit avec des caractères, chaînes, entiers, réels ou
        booléens comme arguments), ce principe existe également
        pour des OPÉRATEURS: l'addition entre des entiers
        N'EST PAS LA MÊME que celle entre des réels. Même si dans
        les deux cas, le résultat est une addition "classique",
        informatiquement, les micro-instructions qui manipulent
        les bits et les octets ne sont pas les mêmes dans les
        deux contextes. Le même principe s'applique pour les autres
        opérateurs arithmétiques.*/

        //Pour la division, les choses se corsent un peu...
        Console.WriteLine("Exemple d'une division ENTIÈRE: 6 / 4 = {0}", unNombre2 / unNombre1);
        Console.WriteLine();
        /*La division entre des entiers donne forcément une réponse
        ENTIÈRE. Ici, 6/4 donnerait normalement 1,5, mais ce n'est
        que la partie entière qui est retenue, soit 1. NOTE IMPORTANTE:
        il s'agit bien de la partie ENTIÈRE, et non L'ARRONDI!
        Nous verrons plus loin comment régler ceci.*/

        //Le modulo
        Console.WriteLine("Opération de reste: 7 % 4 = {0}", unNombre3 % unNombre1);
        Console.WriteLine();
        /*À NOTER QUE LE MODULO EXISTE AUSSI POUR LES RÉELS: le principe est exactement le même que pour les entiers, car on regarde "combien de fois" (un nombre ENTIER) l'opérande de droite est inclus dans celui de droite (sans le dépasser), et "ce qui reste" sera le modulo. Exemple: 6,8 % 2,1. 2,1 "rentre" 3 	fois dans 6,8 car 3 X 2,1 = 6,3. Il reste 0,5 (la différence entre 6,8 et 6,3), et 6,8 % 2,1 = 0,5.*/

        /*CONCEPT DE CONVERSION IMPLICITE ENTRE TYPES: si les deux
        opérandes ne sont pas de même type, C# commence par
        convertir un des deux types en l'autre type de façon à
        ce que l'opérateur binaire arithmétique s'applique entre
        deux expressions DU MÊME TYPE. Le critère de C# est la
        précision: il convertit toujours du type le moins précis
        VERS le type le plus précis, de façon à ne pas perdre de
        précision. EXEMPLE:*/

        Console.WriteLine("Conversion implicite d'un entier à un réel: 2 + 3,4 = {0}", 2 + 3.4);
        Console.WriteLine();
        /*Dans la ligne de code ci-haut, le littéral 2 a été IMPLICITEMENT (i.e. automatiquement) converti en un réel de
        valeur 2.0. Puis, c'est l'opérateur d'addition DES RÉELS qui a été exécuté: 2.0 + 3,4 = 5,4. Si c'était le réel
        qui avait été implicitement converti en valeur entière, il y aurait eu perte de précision: 2 + 3,4 ==> 2 + 3 = 5
        (et non 5,4).*/
        Console.WriteLine();

        /*Si, pour quelque raison que ce soit, nous voulons effectuer la conversion CONTRAIRE à ce que fait C# automatiquement,
        il faut nous-mêmes forcer une conversion EXPLICITE, comme ceci:*/
        Console.WriteLine("Conversion EXPLICITE d'un réel (3,6) à un entier (3): 2 + 3,6 = {0}", 2 + (int)3.6);
        Console.WriteLine();

        /*NOTE IMPORTANTE: si une conversion - implicite ou explicite - est nécessaire dans l'évaluation d'une expression, et
        que cette conversion s'applique sur la valeur d'une variable, la "durée de vie" de cette conversion n'est que pour
        l'évaluation de cette expression, et ne modifie pas de façon permanente la valeur de la variable. Exemple:*/
        double unRéel1 = 3.7;
        Console.WriteLine("Autre conversion EXPLICITE d'un réel (3,7) à un entier (3): 3 + 3,7 = {0}", 3 + (int)unRéel1);
        Console.WriteLine("Mais la valeur de la variable unRéel1 est toujours à {0}", unRéel1);


        /*LA CLASSE MATH. Pour d'autres calculs mathématiques habituels, utilisez la classe Math. Exemples:*/
        Console.Write("3 à la puissance 4 est égal à: ");
        Console.WriteLine(Math.Pow(3, unNombre1)); //À NOTER: Deux méthodes imbriquées!
        Console.WriteLine();

        Console.Write("La racine carrée de 625 est:");
        Console.WriteLine(Math.Sqrt(625)); //À NOTER: Deux méthodes imbriquées!
        Console.WriteLine();
        //Il y a aussi les fonctions trigonométriques dans cette classe... et aussi Pi et e...
        Console.WriteLine("2 belles constantes: {0} et {1}", Math.PI, Math.E);
        Console.WriteLine();


        //Que se passe-t-il dans le cas d'une conversion impliquant un CARACTÈRE avec soit un entier ou un réel?
        Console.WriteLine("Conversion implicite avec un caractère: voyons voir ce que donne, par exemple, 'a' + 20: {0}", 'a' + 20);
        Console.WriteLine();
        /*Dans ce cas, C# convertit implicitement 'a' dans sa VALEUR NUMÉRIQUE, soit son code ASCII (et non 1!). Le code
        ASCII de la lettre 'a' (MINUSCULE!) est 97. Les codes ASCII des 26 lettres minuscules vont de 97 à 122.
        Les codes ASCII des 26 lettres majuscules vont de 65 à 90.
        Les codes ASCII des CARACTÈRES de 0 à 9 vont de 48 à 57.
        (note: le même principe s'appliquerait si nous avions additionné 20.45 plutôt que 20 à la valeur numérique de 'a'
        (97): il y aurait alors eu une DOUBLE conversion implicite: 'a' aurait été converti en 97, puis ce 97 aurait été
        converti en 97.0 pour que l'opérateur d'addition puisse s'effectuer entre deux doubles)*/

        //Et si nous avions deux caractères?
        Console.WriteLine("Faisons la \"somme\" de 'A' et '1': {0}", 'A' + '1');
        /*à remarquer: si on veut faire apparaître les guillemets doubles dans une chaîne, on les fait précéder de la barre oblique inversée (appelée le caractère 'escape' dans le jargon informatique...)*/
        Console.WriteLine();
        Console.WriteLine();
        //La somme est faite avec les deux codes ACII: 65 + 49 = 114

        /*Il est facile de tomber dans le piège de croire que la
        "somme" de deux caractères ne fera que les écrire l'un à
        la suite de l'autre. Dans l'exemple qui précède, nous
        aurions eu A1. Ceci s'appelle une CONCATÉNATION et existe
        entre des CHAÎNES de caractères. Exemple:*/
        Console.WriteLine("Exemple de concaténation: {0}", "abc" + "def");
        Console.WriteLine();

        /*Combinaison d'une concaténation avec une conversion
        implicite: l'opérateur + utilisé entre une chaîne et
        n'importe quoi d'autre convertit ce 'n'importe quoi' en
        une chaîne:*/
        Console.WriteLine("Concaténations avec conversions implicites:");
        Console.WriteLine("abc" + 1);//avec un entier
        Console.WriteLine("abc" + 2.3);//avec un réel
        Console.WriteLine("abc" + 'd');//avec un caractère
        Console.WriteLine("abc" + true);//avec un booléen
        Console.WriteLine();

        /*À NOTER QUE LES AUTRES OPÉRATEURS BINAIRES ARITHMÉTIQUES NE SONT PAS DÉFINIS POUR DES CHAÎNES: il n'y aurait pas vraiment de sens à conceptualiser une soustraction, une multiplication, une division ou un modulo entre deux chaînes.*/

        /*1B) Les opérateurs binaires RELATIONNELS. Leur réponse
        est un booléen (vrai ou faux)
        
        == est un test d'égalité. TRÈS IMPORTANT!!! À bien noter
        les DEUX signes d'égalité, puisque le signe d'égalité
        utilisé seul est une opération D'AFFECTATION.

        != est un test d'inégalité
        
        >= est le "plus grand ou égal à"
        <= est le "plus petit ou égal à"
        > est le "strictement plus grand que"
        < est le "strictement plus petit que".
        
        Ce que nous avons vu pour les conversions implicites et
        explicites tient toujours.
        
        QUELQUES EXEMPLES:*/
        Console.WriteLine("8 est-il égal à 8 ? {0}", 8 == 8);
        Console.WriteLine("9 est-il différent de 9 ? {0}", 9 != 9.0);//CONVERSION IMPLICITE!
        int unNombre4 = 10;
        Console.WriteLine("10 est-il plus grand ou égal à 11? {0}", unNombre4 >= 11);

        /*1C) Les opérateurs binaires BOOLÉENS. Sont utilisés
        ENTRE des valeurs booléennes.
        
        & est le "et". unBool1 ET unBool2 sera vrai si unBool1 ET
        unBool2 SONT TOUS LES DEUX VRAIS. Faux sinon.

        | est le "ou inclusif". unBool1 OU unBool2 sera vrai si
        AU MOINS UN DES OPÉRANDES EST VRAI. Faux sinon.

        ^ est le "ou exclusif" ("ou alors"). unBool1 OU ALORS
        unBool2 sera vrai si UN DES DEUX OPÉRANDES est vrai. Faux sinon.

        && est le "et conditionnel" ==> c'est comme un "et", mais si
        le premier opérande est faux, le deuxième opérande n'est même
        pas évalué.

        || est le "ou conditionnel" ==> c'est comme un "ou INCLUSIF", mais si
        le premier opérande est vrai, le deuxième opérande n'est même
        pas évalué.
        
        EXEMPLES:*/
        Console.Write("13 >= (int)13.9 et 14 < 14. Ceci est: ");
        Console.WriteLine(13 >= (int)13.9 & 14 < 14);//FAUX, car nous avons "vrai et faux"

        Console.Write("13 >= 13.9 ou 14 <= 14. Ceci est: ");
        Console.WriteLine(13 >= 13.9 | 14 <= 14);//VRAI, car nous avons "faux ou vrai"

        /*Jusqu'à présent, nous avons vu différents types
        d'opérateurs binaires. Voici la SÉQUENCE DE PRIORITÉ
        dans laquelle ils s'effectuent, dans une seule ligne de
        code:
        EN PREMIER LIEU, les arithmétiques multiplicatifs
        ENSUITE, les arithmétiques additifs
        ENSUITE, les relationnels
        ENSUITE, les booléens "et"
        ENSUITE, les booléens "ou"
        
        S'il y a plusieurs opérateurs de "même niveau" de priorité
        dans la même ligne, ils sont évalués de gauche à droite.
        
        SI ON VEUT MODIFIER L'ORDRE D'EXÉCUTION, il faut utiliser
        des parenthèses.*/

        Console.Write("15 != 16 ou alors 32 + 2 / 2 == 17. Ceci est: ");
        Console.WriteLine(15 != 16 ^ 32 + 2 / 2 == 17);//VRAI, car nous avons "vrai ou alors faux"

        Console.Write("15 != 16 ou alors (32 + 2) / 2 == 17. Ceci est: ");
        Console.WriteLine(15 != 16 ^ (32 + 2) / 2 == 17);//FAUX, car nous avons "vrai ou alors vrai"

        int unNombre5 = 0;
        Console.Write("18 > 19 \"et-conditionnel\" 5 / unNombre5 == 10. Ceci est: ");
        Console.WriteLine(18 > 19 && 5 / unNombre5 == 10);
        /*FAUX, et la deuxième condition N'EST MÊME PAS ÉVALUÉE.*/

        //MAIS...
        Console.Write("19 > 18 \"et-conditionnel\" 5 / unNombre5 == 10. Ceci est: ");
        //Console.WriteLine(19 > 18 && 5 / unNombre5 == 10);
        /*La 2ième condition est évaluée, ET ÇA PLANTE!*/

        //Le même principe s'appliquerait pour le "ou-conditionnel"
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();

        //2.-) LES OPÉRATEURS UNAIRES: s'appliquent à UN SEUL opérande
        Console.WriteLine("LES OPÉRATEURS UNAIRES!!!");
        Console.WriteLine();

        /*Premièrement, l'opérateur booléen de négation: !
        Il inverse tout simplement la valeur booléenne
        (un vrai devient faux, et vice-versa)*/
        Console.Write("La négation de vrai est: ");
        bool unBooléen = true;
        Console.WriteLine(!unBooléen);
        //NOTE: le ! ne change pas la valeur de la VARIABLE

        /*Maintenant, les opérateurs D'INCRÉMENTATION (+1) et
        de DÉCRÉMENTATION, utilisés de façon PRÉFIXE ou POSTFIXE.*/
        int unNombre6 = 0;
        Console.WriteLine("Incrémentation PRÉFIXE:");
        Console.WriteLine("En maths, le \"symbole\" dénotant L'ABSENCE de quantité est: {0}", unNombre6);
        Console.WriteLine("Si on veut afficher les trois premiers entiers naturels SANS INCLURE LE ZÉRO:");
        Console.WriteLine(++unNombre6);
        Console.WriteLine(++unNombre6);
        Console.WriteLine(++unNombre6);
        /*L'incrémentation se fait ALORS QUE LE CODE VA CHERCHER
        LA VALEUR DE LA VARIABLE (ELLE EST DONC INCRÉMENTÉE
        IMMÉDIATEMENT!)*/
        /*À noter qu'après ces trois lignes de code, unNombre6 vaut 3.*/

        /*Reprenons le même programme, mais avec une incrémentation
        POSTFIXE*/
        unNombre6 = 0;
        Console.WriteLine("Incrémentation POSTFIXE:");
        Console.WriteLine("En maths, le \"symbole\" dénotant L'ABSENCE de quantité est: {0}", unNombre6);
        Console.WriteLine("Si on veut afficher les trois premiers entiers naturels EN INCLUANT LE ZÉRO:");
        Console.WriteLine(unNombre6++);
        Console.WriteLine(unNombre6++);
        Console.WriteLine(unNombre6++);
        /*L'incrémentation se fait APRÈS QUE LA VALEUR DE CETTE
        VARIABLE AIT ÉTÉ LUE, ET NE SERA EFFECTIVE QU'À LA
        PROCHAINE LECTURE DE CETTE VARIABLE!*/
        /*À noter qu'après ces trois lignes de code, unNombre6 vaut encore une fois 3, MAIS la différence, c'est que ce 3 n'a pas été affiché.*/

        /*Le même principe s'applique pour la décrémentation:
        elle peut être préfixe ou postfixe.*/

        /*Les incrémentations fonctionnent aussi pour des
        caractères: incrémenter 'a' donne 'b', décrémenter
        'd' donne 'c', etc.*/

        /*3) L'opérateur TERNAIRE de condition booléenne:
        s'applique à TROIS opérandes.
        
        Cet opérateur contient deux symboles: ? :
        
        À LA GAUCHE DU ? se trouvera un booléen (donc, forcément
        soit vrai ou faux)

        ENTRE ? et : se trouve le résultat de l'exécution de
        l'opération SI LA CONDITION CI-HAUT EST VRAIE.
        
        À LA DROITE DU : se trouve le résultat de l'exécution de
        l'opération SI LA CONDITION CI-HAUT EST FAUSSE.
        
        EXEMPLE: on demande à l'usager d'inscrire UN SEUL caractère. Allez chercher la valeur de ce caractère avec le []
        appropié. Puis, on spécifie deux phrases à la console: si oui ou non le caractère est une lettre minuscule, et ensuite, sur la ligne suivante, si le caractère est une lettre majuscule.*/
        Console.Write("Inscrivez un caractère, svp: ");
        string saisieConsole = Console.ReadLine();
        char caractere = saisieConsole[0];
        Console.WriteLine("Ce caractère {0} une lettre minuscule", caractere > 96 && caractere < 123 ? "est" : "n'est pas");
        Console.WriteLine("Ce caractère {0} une lettre majuscule", caractere > 64 && caractere < 91 ? "est" : "n'est pas");
    }//Fin de la méthode Main
}//Fin de la classe Chapitre3