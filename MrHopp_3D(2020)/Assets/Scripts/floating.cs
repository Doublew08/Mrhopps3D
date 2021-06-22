using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floating : MonoBehaviour
{
    
    public float degreesPerSecond = 15.0f;
    public float amplitude = 0.5f;
    public float frequency = 1f;
    public GameObject Player;
    public GameObject Image;
    public GameObject Drawing;
    //public int Room_num;
    float beg_door;
    float End_door;
    public bool SeeingTheDrawing;


    // Position Storage Variables
    Vector3 posOffset = new Vector3();
    Vector3 tempPos = new Vector3();

    // Use this for initialization
    void Start()
    {
        // Store the starting position & rotation of the object
        posOffset = transform.position;
        beg_door = transform.position.x - (transform.localScale.x / 2);
        End_door = transform.position.x + (transform.localScale.x / 2);
    }

    // Update is called once per frame
    void Update()
    {
        
        // Spin object around Y-Axis
        transform.Rotate(new Vector3(0f, Time.deltaTime * degreesPerSecond, 0f), Space.World);

        // Float up/down with a Sin()
        tempPos = posOffset;
        tempPos.y += Mathf.Sin(Time.fixedTime * Mathf.PI * frequency) * amplitude;

        transform.position = tempPos;
        if (beg_door < Player.transform.position.x && Player.transform.position.x < End_door)
        {
            Image.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E)) 
            {
                /*Destroy(gameObject);
                Destroy(Image);*/
                SeeingTheDrawing = true;

                Drawing.SetActive(true);
                PlayerMovement playerMovement = Player.GetComponent<PlayerMovement>();

                playerMovement.canmove = false;
                
            }
            if(SeeingTheDrawing && Input.GetKeyDown(KeyCode.Q))
            {
                Drawing.SetActive(false);
                PlayerMovement playerMovement = Player.GetComponent<PlayerMovement>();

                playerMovement.canmove = true;
                SeeingTheDrawing = false;
            }
        }
        else
        {
            Image.SetActive(false);
        }

    }
}

