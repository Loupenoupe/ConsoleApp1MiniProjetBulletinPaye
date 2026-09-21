# ConsoleApp1BulletinPaye

## Description

**ConsoleApp1BulletinPaye** est une application console développée en **C#** avec **.NET**.

L'objectif du projet est de permettre la génération d'un bulletin de paie à partir des informations saisies concernant un salarié.

L'application calcule notamment :

- le salaire brut ;
- les cotisations salariales ;
- les cotisations patronales ;
- les exonérations ;
- le salaire net ;
- le coût total pour l'employeur.

> **Attention :** les taux et calculs présents dans ce projet sont ceux définis dans le code de l'application. Ils constituent un exercice/projet informatique et ne doivent pas être considérés comme un calculateur officiel de paie.

---

## Fonctionnalités

- Saisie du nom et prénom du salarié
- Saisie du mois et de l'année du bulletin
- Saisie du nombre d'heures travaillées par semaine
- Calcul du salaire brut
- Calcul des cotisations salariales
- Calcul des cotisations patronales
- Calcul de l'exonération patronale
- Calcul du salaire net
- Calcul du montant total employeur
- Affichage du bulletin de paie directement dans la console

---

## Technologies utilisées

- **C#**
- **.NET**
- Application console
- `decimal` pour les calculs monétaires

---

# Prérequis

Avant de pouvoir compiler et exécuter le projet, il faut installer le **SDK .NET** sur votre ordinateur.

Le SDK contient notamment :

- le compilateur C# ;
- la commande `dotnet` ;
- les outils nécessaires pour créer, compiler et exécuter une application .NET.

## Vérifier si .NET est déjà installé

Ouvrez un terminal :

### Windows

Ouvrez **PowerShell** ou **Invite de commandes**.

### Linux / macOS

Ouvrez votre terminal.

Puis exécutez :

```bash
dotnet --version
