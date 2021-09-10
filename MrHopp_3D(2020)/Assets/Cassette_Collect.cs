using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cassette_Collect : MonoBehaviour
{
    public float degreesPerSecond = 15.0f;
    public float amplitude = 0.5f;
    public float frequency = 1f;
    Vector3 posOffset = new Vector3();
    Vector3 tempPos = new Vector3();
    float beg_door;
    float End_door;
    public GameObject HandImage;
    public GameObject TapeText;
    public bool SeeingTapeImage;

    public enum Axis
    {
        X,
        Z
    }
    public Axis axis;


    // Start is called before the first frame update
    void Start()
    {
        posOffset = transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        // Float up/down with a Sin()
        tempPos = posOffset;
        tempPos.y += Mathf.Sin(Time.fixedTime * Mathf.PI * frequency) * amplitude;
        // Spin object around Y-Axis
        // transform.Rotate(new Vector3(0f, Time.deltaTime * degreesPerSecond, 0f), Space.World);
        transform.position = tempPos;
        if (GameObject.FindGameObjectWithTag("Player") != null)
        {
            Transform Player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
            switch (axis)
            {
                case Axis.X:
                    beg_door = transform.position.x - (transform.localScale.x / 2);
                    End_door = transform.position.x + (transform.localScale.x / 2);
                    if (beg_door < Player.position.x && Player.position.x < End_door)
                    {
                        HandImage.SetActive(true);
                        if (Input.GetKeyDown(KeyCode.E))
                        {
                            /*Destroy(gameObject);
                            Destroy(Image);*/
                            SeeingTapeImage = true;

                            TapeText.SetActive(true);
                            PlayerMovement playerMovement = Player.GetComponent<PlayerMovement>();

                            playerMovement.canmove = false;

                        }
                        if (SeeingTapeImage && Input.GetKeyDown(KeyCode.Q))
                        {
                            TapeText.SetActive(false);
                            PlayerMovement playerMovement = Player.GetComponent<PlayerMovement>();

                            playerMovement.canmove = true;
                            SeeingTapeImage = false;
                            GameManager gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
                            gameManager.Cassetteint++;
                            CanvasTapes.TapesCollected++;
                            gameManager.destroyCassetteNumber++;
                        }
                    }
                    else
                    {
                        HandImage.SetActive(false);
                    }

                    break;
                case Axis.Z:
                    beg_door = transform.position.z - (transform.localScale.z / 2);
                    End_door = transform.position.z + (transform.localScale.z / 2);
                    if (beg_door < Player.position.z && Player.position.z < End_door)
                    {
                        HandImage.SetActive(true);
                        if (Input.GetKeyDown(KeyCode.E))
                        {
                            /*Destroy(gameObject);
                            Destroy(Image);*/
                            SeeingTapeImage = true;

                            TapeText.SetActive(true);
                            PlayerMovement playerMovement = Player.GetComponent<PlayerMovement>();

                            playerMovement.canmove = false;

                        }
                        if (SeeingTapeImage && Input.GetKeyDown(KeyCode.Q))
                        {
                            TapeText.SetActive(false);
                            PlayerMovement playerMovement = Player.GetComponent<PlayerMovement>();

                            playerMovement.canmove = true;
                            SeeingTapeImage = false;
                            GameManager gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
                            gameManager.Cassetteint++;
                            CanvasTapes.TapesCollected++;
                            gameManager.destroyCassetteNumber++;
                        }
                    }
                    else
                    {
                        HandImage.SetActive(false);
                    }

                    break;
            }
            

        }


    }
}
