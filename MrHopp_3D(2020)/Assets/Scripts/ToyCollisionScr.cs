using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToyCollisionScr : MonoBehaviour
{
    private CollisionManagerScr colManager;

    void Start()
    {
        colManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<CollisionManagerScr>();

    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Toy")
        {
            if (colManager != null)
            {
                colManager.HandleCollision(this.gameObject, col); // Passes in the object that detected the collision
                colManager.HandleCollision(col.gameObject, col); // Passes in the Ballone object
             }
        }
    }

}
