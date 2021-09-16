using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MayOpenSafe : MonoBehaviour
{
    public float beg_door; 
    public GameObject Hand;
    public float End_door;
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
            Transform Player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();

            GameManager gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
            if (beg_door < Player.position.z && Player.position.z < End_door)
            {
                Hand.SetActive(true);
                if (Input.GetKey(KeyCode.E) && gameManager.HaveEndKey)
                {
                    print("destroyed");
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