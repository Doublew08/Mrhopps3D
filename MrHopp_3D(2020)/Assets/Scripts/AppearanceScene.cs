using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  class AppearanceScene : MonoBehaviour
{
    float beg;
    float End;
    public int firstapp = 0;
    public GameObject Babbit;
    // Start is called before the first frame update
    void Start()
    {
        beg = transform.position.z - (transform.localScale.z / 2);
        End = transform.position.z + (transform.localScale.z / 2);
    }

    // Update is called once per frame
    void Update()
    {
        GameManager gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();

        gameManager.shown1stapp1 = firstapp;
        
        if (gameManager.RabbitExists)
        {
            Babbit.SetActive(true);
        }
        else
        {
            Babbit.SetActive(false);
        }

        GameObject Player = GameObject.FindGameObjectWithTag("Player");
        if (GameObject.FindGameObjectWithTag("Player")){
            if (beg < Player.transform.position.z)
            {
                if (Player.transform.position.z < End)
                {
                    if (gameManager.canend1)
                    {
                        {
                            firstapp++;
                        }
                    }
                }
            }
        }
    } }