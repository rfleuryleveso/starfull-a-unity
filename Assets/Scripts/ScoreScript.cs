using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreScript : MonoBehaviour
{
    
    public TextMeshProUGUI scoreText;
    
    public static int score = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        scoreText = GetComponent<TextMeshProUGUI>();
    }

    // affiche le score en direct, à partir du TextMeshPro
    void Update()
    {
        scoreText.text = "Score : " + score;
    }
}
