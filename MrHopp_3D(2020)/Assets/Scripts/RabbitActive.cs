using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RabbitActive : MonoBehaviour
{
     public GameObject Rabbit1;
    public GameObject Rabbit2;
     public int CurrentRabbit;
    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log(Random.Range(0, 2));
        CurrentRabbit = Random.Range(0, 2);
        if (CurrentRabbit == 0)
        {
            Rabbit1.SetActive(true);
            Rabbit2.SetActive(false);
        }
        if (CurrentRabbit == 1)
        {
            Rabbit2.SetActive(true);
            Rabbit1.SetActive(false);
        }
        Debug.Log("Currrent Rabbit is :" + CurrentRabbit);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
