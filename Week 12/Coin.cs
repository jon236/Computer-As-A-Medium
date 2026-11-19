using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Coin : MonoBehaviour
{
    public int scoreValue = 5;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("PlayerController"))
        {
            AddScore sm = FindObjectOfType<AddScore>();
            sm.AddScore(scoreValue);
            Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


       
    
}
    
