using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LauncherMenu : MonoBehaviour
{
    [SerializeField] private Button playButton;
    [SerializeField] private Button difficultyButton;
    [SerializeField] private Button quitButton;
    
    [SerializeField] private GameObject EnableDifficulty; //choisit l'objet à faire apparaitre
    [SerializeField] private GameObject DisableDifficulty; //choisit l'objet à faire disparaitre
    
    [SerializeField] private Button easyButton;
    [SerializeField] private Button normalButton;
    [SerializeField] private Button hardButton;
    [SerializeField] private Button backButton;
    
    public static int difficulty = 2;
    
    private void Start()
    {
        // événement de l'appui des boutons
        playButton.onClick.AddListener(this.HandlePlayButton);
        difficultyButton.onClick.AddListener(this.HandleDifficultyButton);
        quitButton.onClick.AddListener(this.HandleQuitButton);
        easyButton.onClick.AddListener(this.HandleEasyButton);
        normalButton.onClick.AddListener(this.HandleNormalButton);
        hardButton.onClick.AddListener(this.HandleHardButton);
        backButton.onClick.AddListener(this.HandleBackButton);
    }

    // change de scène pour lancer la partie
    private void HandlePlayButton()
    {
        SceneManager.LoadScene(1);
    }
    
    // cache le menu principal pour afficher le menu de difficulté
    private void HandleDifficultyButton()
    {
        EnableDifficulty.SetActive(true);
        DisableDifficulty.SetActive(false);
    }

    
    // quitte le jeu
    private void HandleQuitButton()
    {
        Application.Quit();
    }
    
    // change la difficulté en facile et lance le jeu
    private void HandleEasyButton()
    {
        difficulty = 1;
        SceneManager.LoadScene(1);
    }
    
    // change la difficulté en normale et lance le jeu
    private void HandleNormalButton()
    {
        difficulty = 2;
        SceneManager.LoadScene(1);
    }
    
    // change la difficulté en difficile et lance le jeu
    private void HandleHardButton()
    {
        difficulty = 3;
        SceneManager.LoadScene(1);
    }
    
    // cache le menu de difficulté pour afficher le menu principal
    private void HandleBackButton()
    {
        EnableDifficulty.SetActive(false);
        DisableDifficulty.SetActive(true);
    }
}