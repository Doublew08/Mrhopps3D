using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WillBeDestroyed : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.instance != null)
        {
            if (GameManager.instance.ToBeDestroyedDrawing)
            {
                Destroy(gameObject);
            }
        }
    }
}
