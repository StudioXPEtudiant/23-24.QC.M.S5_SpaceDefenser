using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPub : MonoBehaviour
{
    public GameObject Pub;
    float randomTimer = 1000f;
    [SerializeField]
    private List<GameObject> pub = new List<GameObject>();
    //Random.Range(10000f, 15000f);

    // Start est appelé avant la première mise à jour de frame
    void Start()
    {
       
        
        //https://forum.unity.com/threads/how-to-spawn-at-random-times.1041733/
    }

    // Générer une balle aléatoire à une position x aléatoire en haut de la zone de jeu
    private void FixedUpdate()
    {
     randomTimer = randomTimer - 1f;
        if (randomTimer <= 0)
        {
            Spawn();
            randomTimer = 1000f;
            
        }
    }

    void Spawn()
    {
        Pub.SetActive(true);
    }
}
