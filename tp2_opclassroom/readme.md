# TP 2

Le but de ce TP va être de créer 3 méthodes.

La première va servir à calculer la sommes d'entiers consécutifs. Si par exemple je veux calculer la somme des entiers de 1 à 10, c'est à dire 1 + 2 + 3 + 4 + 5 + 6 + 7 + 8 + 9 + 10, je vais appeler cette méthode en lui passant en paramètres 1 et 10, c'est-à-dire les bornes des entiers dont il faut faire la somme.
Quelque chose du genre :

Console.WriteLine(CalculSommeEntiers(1, 10));

Console.WriteLine(CalculSommeEntiers(1, 100));

Sachant que le premier résultat de cet exemple vaut 55 (1 + 2 + 3 + 4 + 5 + 6 + 7 + 8 + 9 + 10 = 55) et le deuxième 5050.

La deuxième méthode acceptera une liste de double en paramètres et devra renvoyer la moyenne des doubles de la liste. Par exemple :

List<double> liste = new List<double> { 1.0, 5.5, 9.9, 2.8, 9.6};

Console.WriteLine(CalculMoyenne(liste));

Le résultat de cet exemple vaut 5.76.

Enfin, la dernière méthode devra dans un premier temps construire une liste d’entiers de 1 à 100 qui sont des multiples de 3 (3, 6, 9, 12, …). Dans un second temps, construire une autre liste d’entiers de 1 à 100 qui sont des multiples de 5 (5, 10, 15, 20, …). Et dans un dernier temps, il faudra calculer la somme des entiers qui sont communs aux deux listes … vous devez bien sur trouver 630
