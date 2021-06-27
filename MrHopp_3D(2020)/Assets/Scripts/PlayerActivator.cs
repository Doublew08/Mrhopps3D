using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActivator : MonoBehaviour
{
    public bool ActivateP1;
    public GameObject P1;
    public bool ActivateP2;
    public GameObject P2;
    public bool ActivateP3;
    public GameObject P3;
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
        if (ActivateP2)
        {
            P2.SetActive(true);
        }
        else
        {
            P2.SetActive(false);
        }
        if (ActivateP3)
        {
            P3.SetActive(true);
        }
        else
        {
            P3.SetActive(false);
        }
    }
}
