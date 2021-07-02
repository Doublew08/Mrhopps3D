using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bedending : MonoBehaviour
    
{
    public GameObject end1;
    public bool bedendcan = false;
    public GameObject endingscreen1;
    bool canend1bed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement playerMovement = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>();
        if(GameObject.FindGameObjectWithTag("GameManager"))
        {
            GameManager gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
            gameManager.canend1 = canend1bed;
        }
        if (bedendcan&&canend1bed)
        {
            end1.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
            {
                playerMovement.canmove = false;
                endingscreen1.SetActive(true);
                if (Input.GetKeyDown(KeyCode.Escape))
                {
                    Application.Quit();
                }
            }
        }
        else
        {
            end1.SetActive(false);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        bedendcan = true;
    }
    private void OnTriggerExit(Collider other)
    {
        bedendcan = false;
    }
}
