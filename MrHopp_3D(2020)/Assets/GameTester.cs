using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameTester : MonoBehaviour

{
    public GameObject Manager;
    // Start is called before the first frame update
    void Start()
    {
        if (!GameObject.FindGameObjectWithTag("GameManager"))
        {
            Debug.Log("Testing");
            Instantiate(Manager);
        }
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
