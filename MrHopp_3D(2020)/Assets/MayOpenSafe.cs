using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MayOpenSafe : MonoBehaviour
{
    float beg_door; 
    public GameObject Hand;
    float End_door;
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

            GameManager gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
            if (beg_door < Player.position.x && Player.position.x < End_door)
            {
                Hand.SetActive(true);
                if (Input.GetKey(KeyCode.E) && gameManager.HaveEndKey)
                {
                    Destroy(GameObject.Find("Canvas(EndKey)(Clone)"));
                }
            }
            else
            {
                Hand.SetActive(false);
            }
        }
    }
}