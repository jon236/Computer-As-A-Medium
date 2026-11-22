using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Coin : MonoBehaviour
{
    private GameManager gm;

    void Start()
    {
        // Find the class GameManager, not the method AddScore
        gm = FindObjectOfType<GameManager>();
       
    }

    void OnTriggerEnter2D(Collider2D other)   
    {
        if (other.CompareTag("Player"))
        {
            gm.AddScore(1);       // call the method on the variable
            Destroy(gameObject);
        }
    }


// Update is called once per frame
void Update()
    {

    }


       
    
}
    
