# 🚗 TP Web – Séance 2 : Application Web Dynamique avec ASP.NET Core MVC

## 📌 Présentation du projet

Ce TP consiste à faire évoluer le site vitrine statique d'une agence de location de voitures, réalisé lors du TP Séance 1, vers une application web dynamique en utilisant **ASP.NET Core 10 MVC**.

L'objectif est de mettre en place une architecture MVC complète permettant de gérer les catégories de véhicules, les voitures et leurs informations à travers une base de données SQL Server LocalDB.

Le projet utilise également Entity Framework Core pour la persistance des données et le Repository Pattern pour organiser l'accès aux données.

## 🎯 Objectifs du TP

- Créer une application web avec ASP.NET Core 10 MVC.
- Configurer Entity Framework Core et SQL Server LocalDB.
- Comprendre et appliquer l'architecture MVC.
- Implémenter le Repository Pattern.
- Réaliser les opérations CRUD (Create, Read, Update, Delete).
- Gérer le téléchargement et le stockage des images.
- Établir une relation One-to-Many entre les catégories et les voitures.
- Utiliser les migrations Code First.
- Transformer la page d'accueil en une vitrine dynamique.

## 🛠️ Technologies utilisées

- 💻 **ASP.NET Core 10 MVC** : développement de l'application web.
- ⚙️ **C#** : langage de programmation côté serveur.
- 🗄️ **Entity Framework Core 10** : gestion et persistance des données.
- 🔌 **SQL Server LocalDB** : système de gestion de base de données.
- 🌐 **Razor Views** : génération dynamique des pages HTML.
- 🎨 **Bootstrap 5** : conception d'une interface responsive.
- 🧰 **Visual Studio 2022** : environnement de développement.

## 🚀 Fonctionnalités principales

### 1️⃣ Configuration du projet

- Création du projet ASP.NET Core MVC.
- Installation des packages NuGet nécessaires.
- Configuration de la chaîne de connexion.
- Création et configuration de `ApplicationDbContext`.

### 2️⃣ Gestion des catégories de véhicules

Mise en place d'un module CRUD permettant :

- ➕ Ajouter une catégorie.
- 📋 Afficher la liste des catégories.
- 🔍 Consulter les détails d'une catégorie.
- ✏️ Modifier une catégorie.
- 🗑️ Supprimer une catégorie.
- 🖼️ Télécharger et stocker les images sur le serveur.

### 3️⃣ Gestion de la flotte automobile

Développement d'un module de gestion des voitures permettant :

- ➕ Ajouter de nouveaux véhicules.
- 📋 Afficher la liste des véhicules.
- 🔍 Consulter les détails d'un véhicule.
- ✏️ Modifier les informations d'un véhicule.
- 🗑️ Supprimer un véhicule.
- 🚘 Gérer la disponibilité des véhicules.

### 4️⃣ Relation entre les catégories et les voitures

Mise en place d'une relation One-to-Many (1-N) :

- Une catégorie peut contenir plusieurs voitures.
- Chaque voiture appartient à une seule catégorie.
- Utilisation des clés étrangères pour assurer la relation.
- Utilisation de `Include()` pour récupérer les catégories associées.

### 5️⃣ Vitrine client dynamique

Transformation de la page d'accueil pour afficher automatiquement les véhicules enregistrés dans la base de données.

- Réutilisation du design du TP Séance 1.
- Affichage dynamique des voitures avec Razor.
- Présentation des caractéristiques et des tarifs.
- Affichage du statut de disponibilité.
- Adaptation responsive avec Bootstrap 5.

## 🏗️ Architecture du projet

Le projet suit le modèle MVC (Model – View – Controller), avec une séparation des responsabilités :

- 📦 **Models** : définition des entités et des données.
- 🖥️ **Views** : affichage des interfaces utilisateur avec Razor.
- 🎮 **Controllers** : gestion des requêtes et des interactions.
- 🗄️ **Data** : configuration du contexte de base de données.
- 🔄 **Repositories** : gestion des opérations d'accès aux données.
- 📁 **wwwroot** : stockage des fichiers statiques et des images.

## 🗃️ Base de données

La base de données est gérée avec SQL Server LocalDB et Entity Framework Core.

Elle contient principalement deux entités :

- `CategoryVoiture` : informations sur les catégories de véhicules.
- `Voiture` : informations sur les véhicules.

Les migrations Code First permettent de créer et de mettre à jour automatiquement la structure de la base de données.

## 📸 Captures d'écran

Cette section est réservée aux captures d'écran illustrant les différentes fonctionnalités de l'application :

- 🏠 Page d'accueil.
- 📋 Liste des catégories.
- ➕ Formulaire d'ajout d'une catégorie.
- 🚗 Liste des véhicules.
- 📝 Formulaire d'ajout d'un véhicule.
- 🔍 Détails d'un véhicule.
- ✏️ Interface de modification et de suppression.

## 🎓 Conclusion

Ce TP permet de mettre en pratique les concepts fondamentaux du développement web dynamique avec ASP.NET Core MVC.

Il représente une continuité du TP Séance 1 et permet de passer d'un site statique à une application web connectée à une base de données, avec une gestion complète des catégories et des véhicules.

Ce travail contribue à renforcer les compétences en C#, ASP.NET Core MVC, Entity Framework Core, SQL Server et architecture logicielle.

---

📚 **Module :** Programmation Web  
📝 **TP :** Séance 2 – ASP.NET Core MVC  
💻 **Environnement :** Visual Studio 2022  
⚙️ **Framework :** .NET 10