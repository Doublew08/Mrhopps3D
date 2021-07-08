using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppearanceScene : MonoBehaviour
{
    float beg;
    float End;

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

        GameObject Player = GameObject.FindGameObjectWithTag("Player");
        if (beg < Player.transform.position.z && Player.transform.position.z < End && gameManager.canend1)
        {
            gameManager.RabbitExists = true;
            gameManager.AppScene = false;
        }
    }
}
