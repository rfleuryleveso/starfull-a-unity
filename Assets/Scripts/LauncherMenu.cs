using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LauncherMenu : MonoBehaviour
{
    [SerializeField] private Button playButton;
    [SerializeField] private Button quitButton;

    private void Start()
    {
        playButton.onClick.AddListener(this.HandlePlayButton);
        quitButton.onClick.AddListener(this.HandleQuitButton);
    }

    private void HandlePlayButton()
    {
        SceneManager.LoadScene(1);
    }

    private void HandleQuitButton()
    {
        Application.Quit();
    }
}
