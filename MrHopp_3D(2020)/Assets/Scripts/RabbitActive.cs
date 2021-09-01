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
        //Make a Random Number from 0 to 2
        CurrentRabbit = Random.Range(0, 2);
        //Check if the number is 0
        if (CurrentRabbit == 0)
        {
            //Rabbit 1 will be activated and Rabbit 2 will be disabled
            Rabbit1.SetActive(true);
            Rabbit2.SetActive(false);
        }
        //check if the number is 1
        if (CurrentRabbit == 1)
        {
            //The Rabbit 1 will be Disabled and Rabbit 2 will be activated
            Rabbit2.SetActive(true);
            Rabbit1.SetActive(false);
        }
        //Show in the Console The Rabbit who is Activated (Number)
        Debug.Log("Currrent Rabbit is :" + CurrentRabbit);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
