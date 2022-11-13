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
    
    public GameObject EnableDifficulty; //choisit l'objet à faire apparaitre
    public GameObject DisableDifficulty; //choisit l'objet à faire disparaitre
    

    private void Start()
    {
        playButton.onClick.AddListener(this.HandlePlayButton);
        difficultyButton.onClick.AddListener(this.HandleDifficultyButton);
        quitButton.onClick.AddListener(this.HandleQuitButton);
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
}
