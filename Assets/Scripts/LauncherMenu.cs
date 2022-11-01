using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LauncherMenu : MonoBehaviour
{
    [SerializeField] private Button playButton;

    private void Start()
    {
        playButton.onClick.AddListener(this.HandlePlayButton);
    }

    private void HandlePlayButton()
    {
        SceneManager.LoadScene(1);
    }
}
