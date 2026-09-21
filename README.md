# ConsoleApp1MiniProjetBulletinPaye

> Application console C# qui génère un bulletin de paye : à partir d'un nom,
> d'un mois et d'un taux horaire, elle calcule le salaire brut, les cotisations
> salariales et patronales, le salaire net et le coût total pour l'employeur.

Le projet est une **application console unique** (.NET) qui :

| Étape            | Description                                                              |
| ---------------- | ------------------------------------------------------------------------ |
| Saisie           | Demande le nom/prénom, le mois/année et le nombre d'heures.              |
| Calcul           | Applique les taux de cotisations salariales et patronales au brut.       |
| Affichage        | Efface la console et affiche le bulletin de paye détaillé.               |

---

## Prérequis

- **.NET SDK 6.0 ou supérieur** (le projet utilise les `using` implicites)
- **Visual Studio 2022** (optionnel) ou tout éditeur compatible C# (VS Code, Rider…)
- **Git** pour cloner le dépôt

---

## Compilation

```sh
git clone https://github.com/Loupenoupe/ConsoleApp1MiniProjetBulletinPaye.git
cd ConsoleApp1MiniProjetBulletinPaye
dotnet build
```

Ou, avec **Visual Studio** : ouvrir `ConsoleApp1BulletinPaye.slnx`, puis
`Ctrl+Shift+B`.

---

## Lancement

### Rapide (ligne de commande)

```sh
dotnet run --project ConsoleApp1BulletinPaye
```

### Depuis Visual Studio

Ouvrir la solution `ConsoleApp1BulletinPaye.slnx` puis appuyer sur `F5`
(ou `Ctrl+F5` pour lancer sans débogage).

---

## Utilisation

Le programme pose trois questions à la suite :

| Question                                                   | Format attendu                   |
| ---------------------------------------------------------- | -------------------------------- |
| `Quel est votre Nom et Prénom ?`                           | texte libre                      |
| `De quel mois/année voulez-vous votre bulletin de paye ?`  | `MM/AAAA` (ex. `09/2026`)        |
| `Combien d'heures/semaines avez-vous travaillées ?`        | nombre décimal (ex. `35`)        |

Puis la console est effacée et le bulletin s'affiche.

### Exemple de sortie

```text
**** Fiche de Paye Association ADD ****
Nom et Prénom : Jean Dupont
Mois : 09/2026
Nombre d'heures travaillées : 151.67
Taux horaire : 12.31 EUR

Salaire Brut : 1867.06 EUR

Cotisations salariales :
    Complémentaire Santé : 20.00 EUR
    Vieillesse : 136.30 EUR
    Retraite Complémentaire : 58.81 EUR
    Contribution d'équilibre général : 16.06 EUR
    CSG déductible : 126.96 EUR
    CSG non déductible : 44.81 EUR
    CRDS : 9.34 EUR
Total cotisations salariales : 412.27 EUR

Cotisations patronales :
    Complémentaire Santé : 20.00 EUR
    Maladie : 136.30 EUR
    Accidents du Travail et maladies professionnelles : 41.82 EUR
    Vieillesse : 195.11 EUR
    Retraite Complémentaire : 88.13 EUR
    Contribution d'équilibre général : 24.09 EUR
    Allocations familiales : 64.41 EUR
    Contribution au Fonds National d'Aide au Logement : 1.87 EUR
    Chômage : 75.62 EUR
    Cotisation au Régime de Garantie des Salaires : 2.80 EUR
    Formation professionnelle : 10.27 EUR
    Taxe d'apprentissage : 12.70 EUR
    Contribution au dialogue social : 0.37 EUR
Exonération cotisations patronales : 597.46 EUR
Total cotisations patronales : 76.01 EUR

Salaire Net : 1454.79 EUR
Montant total employeur : 1943.07 EUR
```

---

## Règles de calcul

### Valeurs de base

| Paramètre            | Valeur                                      |
| -------------------- | ------------------------------------------- |
| Entreprise           | Association ADD                             |
| Taux horaire         | 12,31 EUR                                   |
| Heures mensuelles    | 151,67 h                                    |
| Complémentaire santé | 20,00 EUR (part salarié et part employeur)  |

```text
Salaire brut = taux horaire × heures mensuelles
```

### Cotisations salariales

| Cotisation                        | Taux    |
| --------------------------------- | ------- |
| Vieillesse                        | 7,30 %  |
| Retraite complémentaire           | 3,15 %  |
| Contribution d'équilibre général  | 0,86 %  |
| CSG déductible                    | 6,80 %  |
| CSG non déductible                | 2,40 %  |
| CRDS                              | 0,50 %  |

### Cotisations patronales

| Cotisation                                       | Taux    |
| ------------------------------------------------ | ------- |
| Maladie                                          | 7,30 %  |
| Accidents du travail / maladies professionnelles | 2,24 %  |
| Vieillesse                                       | 10,45 % |
| Retraite complémentaire                          | 4,72 %  |
| Contribution d'équilibre général                 | 1,29 %  |
| Allocations familiales                           | 3,45 %  |
| FNAL (aide au logement)                          | 0,10 %  |
| Chômage                                          | 4,05 %  |
| Garantie des salaires                            | 0,15 %  |
| Formation professionnelle                        | 0,55 %  |
| Taxe d'apprentissage                             | 0,68 %  |
| Contribution au dialogue social                  | 0,02 %  |
| **Exonération** (déduite du total patronal)      | 32,00 % |

### Résultats

```text
Salaire net          = salaire brut − total cotisations salariales
Montant employeur    = salaire brut + total cotisations patronales − exonération
```

---

## Structure du dépôt

```
ConsoleApp1BulletinPaye/        # projet C# (Program.cs)
ConsoleApp1BulletinPaye.slnx    # solution Visual Studio
.gitattributes
.gitignore
README.md
```

---

## Pistes d'amélioration

- Utiliser le nombre d'heures saisi par l'utilisateur dans le calcul du brut
  (actuellement, la valeur fixe `151.67` est utilisée).
- Sécuriser les saisies (`decimal.TryParse`, validation du format `MM/AAAA`).
- Permettre de choisir le taux horaire au lieu de le fixer dans le code.
- Exporter le bulletin en fichier (`.txt`, `.pdf`).
- Déplacer les taux dans un fichier de configuration.

---

## Auteur

Projet réalisé par [Loupenoupe](https://github.com/Loupenoupe).
