using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionManagerScr : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void HandleCollision(GameObject collidingObject, Collision col)
    {
        Debug.Log("I've managed this collision with " + collidingObject.name);
        Debug.Log(col); // Some info about the Collision2D object
    }
}
