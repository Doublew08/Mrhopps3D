using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActivator : MonoBehaviour
{
    public bool ActivateP1;
    public GameObject P1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ActivateP1)
        {
            P1.SetActive(true);
        }
        else
        {
            P1.SetActive(false);
        }
    }
}
