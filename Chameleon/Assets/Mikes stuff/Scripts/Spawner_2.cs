using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner_2 : MonoBehaviour
{
    public GameObject Fly;
    float randX;
    Vector2 whereToSpawn;
    public float spawnRate;
    float nextSpawn = 0.0f;
    public float rangeMax;
    public float rangeMin;
    float randY;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextSpawn)
        {
           

            nextSpawn = Time.time + spawnRate;
            randY = Random.Range(rangeMin, rangeMax);
            whereToSpawn = new Vector2(randY, transform.position.x);
            Instantiate(Fly, whereToSpawn, Quaternion.identity);


        }
    }
}
