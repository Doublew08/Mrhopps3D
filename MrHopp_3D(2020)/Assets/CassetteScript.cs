using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CassetteScript : MonoBehaviour
{
    public static CassetteScript instance;
    public float degreesPerSecond = 15.0f;
    public float amplitude = 0.5f;
    public float frequency = 1f;
    public GameObject Image;
    public GameObject TapeImage;
    //public int Room_num;
    float beg_door;
    float End_door;
    public bool SeeingTapeImage;
    //public bool CanvasActive;
    
    


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
        if (GameObject.FindGameObjectWithTag("Player") != null)
        {
            Transform Player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();


            // Spin object around Y-Axis
            transform.Rotate(new Vector3(0f, Time.deltaTime * degreesPerSecond, 0f), Space.World);

            // Float up/down with a Sin()
            tempPos = posOffset;
            tempPos.y += Mathf.Sin(Time.fixedTime * Mathf.PI * frequency) * amplitude;

            transform.position = tempPos;
            if (beg_door < Player.position.x && Player.position.x < End_door)
            {
                Image.SetActive(true);
                if (Input.GetKeyDown(KeyCode.E))
                {
                    /*Destroy(gameObject);
                    Destroy(Image);*/
                   SeeingTapeImage = true;

                    TapeImage.SetActive(true);
                    PlayerMovement playerMovement = Player.GetComponent<PlayerMovement>();

                    playerMovement.canmove = false;

                }
                if (SeeingTapeImage && Input.GetKeyDown(KeyCode.Q))
                {
                    TapeImage.SetActive(false);
                    PlayerMovement playerMovement = Player.GetComponent<PlayerMovement>();

                    playerMovement.canmove = true;
                    SeeingTapeImage = false;
                   // CanvasActive = true;

                    GameManager.instance.DestroyCassette = true;
                    
                }
            }
            else
            {
                Image.SetActive(false);
            }

        }
    }
}

