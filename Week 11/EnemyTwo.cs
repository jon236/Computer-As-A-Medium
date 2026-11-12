using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTwo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0, -3, 0) * Time.deltaTime * 5f);
        if (transform.position.y < -4.5f)
        {
            Destroy(this.gameObject);
        }
    }
    public class GameOject { }    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CreateEnemyTwo", 2, 0.8f);
        }

    // Update is called once per frame
    void Update()
        {

        }

        void CreateEnemyTwo()
        {
            Instantiate(EnemyTwo, new Vector3(Random.Range(-7f, 8f), 5.5f, 0), Quaternion.identity);
        }
    }




