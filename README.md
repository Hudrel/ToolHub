# ToolHub

**ToolHub** est une application multitool développée en C# qui intègre divers outils dans une interface compacte et facile d'utilisation. Actuellement, ToolHub permet l’intégration de services comme **ChatGPT** et **Spotify**, avec des fonctionnalités et outils additionnels prévus pour les futures versions.

## Fonctionnalités

- **Interface Utilisateur Personnalisable** : Interface élégante en WPF avec un menu latéral permettant de sélectionner les outils.
- **Intégration de ChatGPT** : Envoie et reçoit des réponses à partir de l'API OpenAI, permettant une utilisation directe de ChatGPT dans ToolHub.
- **Intégration de Spotify** : Contrôle la lecture de musique, affiche les informations de pistes, et plus encore grâce à l'API Spotify.
- **Future Extensibilité** : Conçu pour être un hub polyvalent où de nouveaux outils peuvent être ajoutés facilement.

## Technologies Utilisées

- **Langage** : C#
- **Framework** : WPF pour une interface utilisateur moderne et réactive
- **APIs** :
  - [OpenAI API](https://platform.openai.com/signup) pour l'intégration de ChatGPT
  - [Spotify API](https://developer.spotify.com/dashboard/) pour l'intégration musicale

## Installation

1. **Clonez le dépôt :**
    ```bash
    git clone https://github.com/username/ToolHub.git
    cd ToolHub
    ```
2. **Ouvrez le projet dans Visual Studio.**
3. **Restaurez les packages NuGet** pour s’assurer que toutes les dépendances sont installées.
4. **Ajoutez vos clés API :**
   - Dans le fichier `App.config` (ou `appsettings.json`), renseignez votre clé OpenAI et les informations d'authentification pour Spotify.
5. **Compilez et lancez l'application.**

## Utilisation

1. **Démarrer ToolHub** : Lancez l'application et choisissez l'outil que vous souhaitez utiliser à partir du menu de droite.
2. **Utiliser ChatGPT** : Sélectionnez "ChatGPT" dans le menu pour accéder au chat et envoyer des requêtes.
3. **Utiliser Spotify** : Sélectionnez "Spotify" pour contrôler la musique et afficher les informations de lecture.

## Roadmap

- Ajouter des intégrations supplémentaires pour de nouveaux outils.
- Implémenter un système de préférences utilisateur.
- Améliorer l’interface utilisateur avec des options de personnalisation.

## Contribution

Les contributions sont les bienvenues ! N’hésitez pas à ouvrir une **issue** pour rapporter des bugs ou proposer des améliorations.

1. **Fork** le dépôt
2. Créez une branche pour votre fonctionnalité :
    ```bash
    git checkout -b feature/AmazingFeature
    ```
3. **Commit** vos modifications :
    ```bash
    git commit -m 'Add some AmazingFeature'
    ```
4. **Push** sur la branche :
    ```bash
    git push origin feature/AmazingFeature
    ```
5. **Ouvrez une Pull Request**

## Licence

Ce projet est sous licence [GNU General Public License v3.0](https://www.gnu.org/licenses/gpl-3.0.fr.html). En utilisant ce projet, vous acceptez de respecter les termes de cette licence.
