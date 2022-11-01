using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class MenuInGame : MonoBehaviour
{
    public GameObject MenuPause; //choisit l'objet à faire apparaitre (ici on prend le canvas)
    private bool IsPaused = false;
    
    [SerializeField] private Button BackToGameButton;
    [SerializeField] private Button QuitButton;
    
    
    private void Start()
    {
        BackToGameButton.onClick.AddListener(this.HandleBackButton);
        QuitButton.onClick.AddListener(this.HandleQuitButton);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = 0;
            Debug.Log("Escape key was pressed");
            MenuPause.SetActive(true);
            MonDéplacement.isTalking = true; // bloque le mouvement de camera
            Cursor.lockState = CursorLockMode.None; //permet de pouvoir utiliser sa souris
            Cursor.visible = true; // affiche le curseur de la souris
        }
    }
    private void HandleBackButton()
    {
        Time.timeScale = 1;
        MenuPause.SetActive(false);
        MonDéplacement.isTalking = false; // débloque le mouvement de camera
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = false; // cache le curseur de la souris
    }

    private void HandleQuitButton()
    {
        Application.Quit();
    }
}
