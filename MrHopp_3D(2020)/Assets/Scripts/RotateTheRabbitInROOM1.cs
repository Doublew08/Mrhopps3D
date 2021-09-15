using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateTheRabbitInROOM1: MonoBehaviour
{
    public GameObject Place1;
    public GameObject Place2;
    public GameObject Head;
    public GameObject Eyes;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Check if Rabbit reach Palce1
        if (Vector3.Distance(transform.position, Place1.transform.position) <= 0)
        {
            Debug.Log("Place1");
            Head.transform.Rotate(0f, 180f, 0f);

        }
        //Check if Rabbit reach place2
        if (Vector3.Distance(transform.position, Place2.transform.position) <= 0)
        {
            Debug.Log("Place2");
            Head.transform.Rotate(0f, -180f, 0f);

        }
    }
}
