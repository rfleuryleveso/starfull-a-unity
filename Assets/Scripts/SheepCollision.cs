using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.HID;
using UnityEngine.UI;

public class SheepCollision : MonoBehaviour
{
    public static float Health = HealthBarScript.MaxHealth;

    public GameObject Explosion;

    [SerializeField] private GameObject GameOver;
    [SerializeField] private GameObject Dashboard;
    [SerializeField] private Button quitButton;
    
    void Start()
    {
        quitButton.onClick.AddListener(this.HandleQuitButton);
    }

    private void OnCollisionEnter(Collision collision) {
        // detecte quand le vaisseau se fait percuter par un objet qui a pour layer "Cible"
        if (collision.gameObject.layer == LayerMask.NameToLayer("Cible"))
        {
            // Instancie les particules de l'explosion
            GameObject boom = Instantiate(Explosion, collision.transform.position, Quaternion.identity);
            
            // Détruit les cibles
            Destroy(collision.gameObject);
            
            // met a jour le nombre de cibles présentes dans la scène
            GenerationBots.numItemSpawned--;
            
            // ajoute 1 au score
            ScoreScript.score += 1;
            
            //inflige des dégats au vaisseau
            Health -= GenerationBots.DamageTaken;

            //détruit la particule dans la hierarchy
            Destroy(boom, 2f);
        }
    }
    
    void HandleQuitButton()
    {
        Application.Quit();
    }
    
    private void Update() {
        // Détruit le vaisseau dès qu'il n'a plus de vie et affiche le menu game over
        if (Health <= 0)
        {
            Destroy(gameObject);
            Dashboard.SetActive(false);
            GameOver.SetActive(true);
        }
    }
}
