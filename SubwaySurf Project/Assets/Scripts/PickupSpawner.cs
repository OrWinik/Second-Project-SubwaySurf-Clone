using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupSpawner : MonoBehaviour
{
    public GameObject pickUpLeft;
    public GameObject pickUpMain;
    public GameObject pickUpRight;
    Vector3 LeftLine = new Vector3(-4, -2, -9980);
    Vector3 RightLine = new Vector3(4, -2, -9980);
    Vector3 MainLine = new Vector3(0, -2, -9980);

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i <= 400; i++)
        {
            spawn();
        }

    }


    public void spawn()
    {
        
        Vector3 spawnLocationLeft = new Vector3(0, 0, (Random.Range(5, 250)));
        Vector3 spawnLocationMain = new Vector3(0, 0, (Random.Range(5, 250)));
        Vector3 spawnLocationRight = new Vector3(0, 0, (Random.Range(5, 250)));
        Instantiate(pickUpLeft, LeftLine + spawnLocationLeft, Quaternion.Euler(-90, 0, 0));
        Instantiate(pickUpRight, MainLine + spawnLocationMain, Quaternion.Euler(-90, 0, 0));
        Instantiate(pickUpMain, RightLine + spawnLocationRight, Quaternion.Euler(-90, 0, 0));
        LeftLine += new Vector3(0, 0, 50);
        MainLine += new Vector3(0, 0, 50);
        RightLine += new Vector3(0, 0, 50);

    }
}

