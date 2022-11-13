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
    
    public static int difficulty = 0;
    
    private void Start()
    {
        playButton.onClick.AddListener(this.HandlePlayButton);
        difficultyButton.onClick.AddListener(this.HandleDifficultyButton);
        quitButton.onClick.AddListener(this.HandleQuitButton);
        easyButton.onClick.AddListener(this.HandleEasyButton);
        normalButton.onClick.AddListener(this.HandleNormalButton);
        hardButton.onClick.AddListener(this.HandleHardButton);
        backButton.onClick.AddListener(this.HandleBackButton);
    }

    private void HandlePlayButton()
    {
        SceneManager.LoadScene(1);
    }
    
    private void HandleDifficultyButton()
    {
        EnableDifficulty.SetActive(true);
        DisableDifficulty.SetActive(false);
    }

    private void HandleQuitButton()
    {
        Application.Quit();
    }
    
    private void HandleEasyButton()
    {
        difficulty = 1;
    }
    
    private void HandleNormalButton()
    {
        difficulty = 2;
    }
    
    private void HandleHardButton()
    {
        difficulty = 3;
    }
    
    private void HandleBackButton()
    {
        EnableDifficulty.SetActive(false);
        DisableDifficulty.SetActive(true);
    }
}
