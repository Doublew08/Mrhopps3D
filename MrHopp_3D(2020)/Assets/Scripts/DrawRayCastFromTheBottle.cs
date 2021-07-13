﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawRayCastFromTheBottle : MonoBehaviour
{
    WayPoints RabbitMove;
    void Start()
    {
        RabbitMove = FindObjectOfType<WayPoints>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.white;
        Gizmos.DrawRay(transform.position, transform.up * 1000f);
    }
    public void hit()
    {
        RaycastHit ray;
        if (Physics.Raycast(transform.position, transform.up, out ray, Mathf.Infinity))
        {
            Debug.Log("PlayerFound");
            RabbitMove.CanMove = true;
        }
    }
}
