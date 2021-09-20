using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MayOpenSafe : MonoBehaviour
{
    public float beg_door; 
    public GameObject Hand;
    public float End_door;
    public GameObject SafePuzzle;
    public bool seeingPuzzle;
    public GameObject door;
    // Start is called before the first frame update
    void Start()
    {
        beg_door = transform.position.z - (transform.localScale.z / 2);
        End_door = transform.position.z + (transform.localScale.z / 2);
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindGameObjectWithTag("Player") != null)
        {
            GameObject Player = GameObject.FindGameObjectWithTag("Player");

            GameManager gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
            if (beg_door < Player.transform.position.z && Player.transform.position.z < End_door)
            {
                Hand.SetActive(true);
                if (Input.GetKey(KeyCode.E) && gameManager.HaveEndKey)
                {
                    Player.GetComponent<PlayerMovement>().canmove = false;
                    SafePuzzle.SetActive(true);
                    print("destroyed");
                    Destroy(GameObject.Find("Canvas(EndKey)(Clone)"));
                    seeingPuzzle = true;
                    door.SetActive(false);
                }
                if(seeingPuzzle && Input.GetKey(KeyCode.Q))
                {
                    door.SetActive(true);
                    Player.GetComponent<PlayerMovement>().canmove = true;

                    seeingPuzzle = false;
                    SafePuzzle.SetActive(false);
                }
                
            }
            else
            {
                Hand.SetActive(false);
            }
        }
    }
}