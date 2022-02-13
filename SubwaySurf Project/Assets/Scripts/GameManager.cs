using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameObject obstacleLeftLine;
    public GameObject obstacleMainLine;
    public GameObject obstacleRightLine;
    public Transform player;
    Vector3 LeftLine = new Vector3(-4, -2, -9980);
    Vector3 RightLine = new Vector3(4, -2, -9980);
    Vector3 MainLine = new Vector3(0, -2, -9980);


    // Start is called before the first frame update
    void Start()
    {
        FindObjectOfType<AudioManager>().play("GameMusic");


        for (int i = 0; i<= 400; i++)
        {
            spawn();
        }

    }

    // Update is called once per frame
    void Update()
    {
        
   
    }

    void spawn ()
    {
        Vector3 spawnLocationLeft = new Vector3(0, 0, (Random.Range(5, 250)));
        Vector3 spawnLocationMain = new Vector3(0, 0, (Random.Range(5, 250)));
        Vector3 spawnLocationRight = new Vector3(0, 0, (Random.Range(5, 250)));
        Instantiate(obstacleLeftLine, LeftLine + spawnLocationLeft, transform.rotation);
        Instantiate(obstacleMainLine,MainLine + spawnLocationMain, transform.rotation);
        Instantiate(obstacleRightLine, RightLine + spawnLocationRight, transform.rotation);
        LeftLine += new Vector3(0, 0, 50);
        MainLine += new Vector3(0, 0, 50);
        RightLine += new Vector3(0, 0, 50);

    }
}


//player.transform.position + spawnLocation
// vector 3 (random.range(-4 ,4) 