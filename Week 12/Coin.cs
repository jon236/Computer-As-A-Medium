using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Coin : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
        public int scoreValue = 5;
        void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("PlayerController"))
            {
                ScoreManager sm = FindObjectOfType<ScoreManager>();
                sm.AddScore(scoreValue);
                Destroy(gameObject);
            }
        }
    }
}
}
