using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppearanceScene : MonoBehaviour
{
    float beg;
    float End;
    public int shown1stapp;
    public static int firstapp;

    // Start is called before the first frame update
    void Start()
    {
        beg = transform.position.z - (transform.localScale.z / 2);
        End = transform.position.z + (transform.localScale.z / 2);
    }

    // Update is called once per frame
    void Update()
    {
        shown1stapp = firstapp;
        GameManager gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();

        Transform Player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        if (beg < Player.position.z && Player.position.z < End && gameManager.canend1)
        {
            firstapp++;
        }
    }
}
