using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BearHit : MonoBehaviour
{

    public Camera playercamera;
    private AudioSource audio2;
    public float RayDistance;
    private void Awake()
    {
        audio2 = GetComponent<AudioSource>();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            pick();
        }
        
    }
    private void pick()
    {
        RaycastHit ray;
        Ray ray1 = playercamera.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray1, out ray, RayDistance))
        {
            if (ray.collider.tag == "Bear")
            {
                audio2.Play();
                Debug.Log("Hit");
            }
            
        }
        
    }

}
