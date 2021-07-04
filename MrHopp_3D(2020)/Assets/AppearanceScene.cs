using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppearanceScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameManager gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();

        GameObject Player = GameObject.FindGameObjectWithTag("Player");
        if (gameManager.canend1&&transform.position.x + transform.localScale.x > Player.transform.position.x && Player.transform.position.x < transform.position.x - transform.localScale.x)
        {
            gameManager.RabbitExists = true;
            gameManager.AppScene = true;
        }
    }
}
