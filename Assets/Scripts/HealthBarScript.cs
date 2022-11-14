using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarScript : MonoBehaviour
{

    private Image HealthBar;
    public float CurrentHealth;
    public static float MaxHealth = 100f;
    SheepCollision Player;
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        HealthBar = GetComponent<Image>();

    }

    // Update is called once per frame
    void Update()
    {
        CurrentHealth = SheepCollision.Health;
        HealthBar.fillAmount = CurrentHealth / MaxHealth;
    }
}
