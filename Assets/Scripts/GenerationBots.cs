using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerationBots : MonoBehaviour
{

    public static bool isPaused = false;
    
    public GameObject itemToSpread;
    public GameObject MoveToTarget;
    public int numItemToSpawn; // nombre de cibles que je fais apparaitre
    
    //dimensions de l'aire d'apparition
    private float itemXSpread = 100; 
    private float itemYSpread = 100;
    private float itemZSpread = 100;
    
    public float SheepSpeed;
    
    public static float DamageTaken; // dégats que le joueur prends
    
    public static int numItemSpawned = 0; // nombre de cibles que j'ai déjà fait apparaitre
    
    // on crée un tableau pour y ranger les bots
    public GameObject[] items;
    
    private void Start()
    {
        // gestion des difficultés
        if (LauncherMenu.difficulty == 1)
        {
            numItemToSpawn = 10;
            SheepSpeed = 3f;
            DamageTaken = 5f;
        }
        
        if (LauncherMenu.difficulty == 2)
        {
            numItemToSpawn = 25;
            SheepSpeed = 5f;
            DamageTaken = 10f;
        }
        
        if (LauncherMenu.difficulty == 3)
        {
            numItemToSpawn = 50;
            SheepSpeed = 10f;
            DamageTaken = 25f;
        }
    }

    void BotSpawn()
    {
        // choisit une position aléatoire dans l'aire donnée
            Vector3 randPosition = new Vector3(Random.Range(-itemXSpread, itemXSpread),
                Random.Range(-itemYSpread, itemYSpread), Random.Range(-itemZSpread, itemZSpread)) + transform.position;
            
            //fait apparaitre une cible
            Instantiate(itemToSpread, randPosition, Quaternion.identity);
    }
    void Update()
    {
        if (isPaused == false)
        {
            items = GameObject.FindGameObjectsWithTag("Sheep");
            // on fait bouger les objets
            foreach (GameObject item in items)
            {
                if (item != null)
                {
                    item.transform.Translate(Vector3.Normalize(MoveToTarget.transform.position - item.transform.position)*SheepSpeed*0.01f);
                    //les objets regardent dans la direction de la target
                    item.transform.LookAt(MoveToTarget.transform.position);
                }
            }
            if (numItemToSpawn > numItemSpawned)
            {
                // dès qu'il y a une cible en moins, en fait apparaitre une nouvelle
                BotSpawn();
                numItemSpawned++;
            }
        }
    }
}

