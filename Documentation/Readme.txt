# Projet Mairie Gestion

## Description
Ce projet est une application de gestion des actes de naissance, mariage et vente de terrain pour une mairie.

## Structure du Projet
- **CodeSource/** : Contient tous les fichiers source du projet.
- **Exécutable/** : Contient l'exécutable de l'application.
- **BaseDeDonnées/** : Contient le fichier de sauvegarde de la base de données (MAIRIEDB.bak) et les instructions pour la restauration.
- **Documentation/** : Contient le fichier README et le guide utilisateur.

## Outils Utilisés

### Langages et Frameworks
- **Visual Basic .NET** : Utilisé pour le développement de l'application.
- **.NET Framework** : Framework utilisé pour exécuter l'application.

### Environnements de Développement
- **Visual Studio** : Environnement de développement intégré (IDE) utilisé pour coder, tester et déboguer l'application.

### Base de Données
- **SQL Server** : Système de gestion de base de données relationnelle utilisé pour stocker les données de l'application.
- **SQL Server Management Studio (SSMS)** : Outil utilisé pour gérer la base de données.


### Configuration

### 1. Restaurer la Base de Données
1. Ouvrez SQL Server Management Studio (SSMS).
2. Connectez-vous à votre instance SQL Server.
3. Dans l'Explorateur d'objets, cliquez avec le bouton droit sur "Bases de données" et sélectionnez "Restaurer la base de données...".
4. Dans la fenêtre de restauration de la base de données, sélectionnez "Source de la restauration" et choisissez "Dispositif".
5. Cliquez sur "..." pour ouvrir la fenêtre de sélection de fichiers et ajoutez le fichier de sauvegarde (MAIRIEDB.bak) à partir du dossier `BaseDeDonnées/`.
6. Sélectionnez le fichier de sauvegarde ajouté et cliquez sur "OK".
7. Dans la section "Destination", assurez-vous que le nom de la base de données est "MAIRIEDB".
8. Cliquez sur "OK" pour démarrer le processus de restauration.

### 2. Ouvrir le Projet dans Visual Studio
1. Ouvrez Visual Studio.
2. Cliquez sur "Ouvrir un projet ou une solution".
3. Naviguez jusqu'au dossier `CodeSources/` et sélectionnez le fichier de solution `MairieGestionApp.sln`.
4. Visual Studio chargera le projet et vous pourrez le compiler et l'exécuter.

### 3. Exécuter l'Application
1. Dans Visual Studio, compilez et exécutez le projet.
2. Vous pouvez également exécuter l'application en double-cliquant sur l'exécutable dans le dossier `Executable/`.
Chemin de l'exécutable: ProjetMairieGestion\Exécutable\Release\net8.0-windows

## Support
Pour toute question ou assistance, veuillez contacter MERRELOSE Kennedy Denis à kennedymerrelose@gmail.com / +22955809823.
