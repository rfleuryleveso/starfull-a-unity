using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Cache = UnityEngine.Cache;

public class MenuInGame : MonoBehaviour
{
    [SerializeField] private GameObject HealthBarHidden;
    
    [SerializeField] private GameObject MenuPause;

    [SerializeField] private Button ResumeButton;
    [SerializeField] private Button QuitButton;
    
    
    private void Start()
    {
        // événements des boutons
        ResumeButton.onClick.AddListener(this.HandleResumeButton);
        QuitButton.onClick.AddListener(this.HandleQuitButton);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // Cache le dashboard
            HealthBarHidden.SetActive(false);
            // arrète le temps
            Time.timeScale = 0;
            // stop la génération des ennemis
            GenerationBots.isPaused = true;
            // active l'UI du menu
            MenuPause.SetActive(true);
            Cursor.lockState = CursorLockMode.None; //permet de pouvoir utiliser sa souris
            Cursor.visible = true; // affiche le curseur de la souris
        }
    }
    private void HandleResumeButton()
    {
        // viens rétablir tous les paramètres précédemment changés, pour pouvoir reprendre la partie
        HealthBarHidden.SetActive(true);
        Time.timeScale = 1;
        GenerationBots.isPaused = false;
        MenuPause.SetActive(false);
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = false; // cache le curseur de la souris
    }

    private void HandleQuitButton()
    {
        // ferme le jeu
        Application.Quit();
    }
}
