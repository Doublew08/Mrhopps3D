using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalendarScript : MonoBehaviour
{
    float beg_door;
    float End_door;
    public GameObject Date;
    // Start is called before the first frame update
    void Start()
    {
        beg_door = transform.position.x - (transform.localScale.x / 2);
        End_door = transform.position.x + (transform.localScale.x / 2);
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindGameObjectWithTag("Player") != null)
        {
            Transform Player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
            if (beg_door < Player.position.x && Player.position.x < End_door)
            {
                Date.SetActive(true);
            }
            else
            {
                Date.SetActive(false);
            }

        }
    }
}