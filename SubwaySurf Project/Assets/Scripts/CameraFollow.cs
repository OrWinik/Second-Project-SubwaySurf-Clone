using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform traget;
    Vector3 distance;

    // Start is called before the first frame update
    void Start()
    {
        distance = transform.position - traget.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = traget.position + distance;
    }
}
