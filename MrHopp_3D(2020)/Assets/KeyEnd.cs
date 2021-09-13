using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public partial class KeyEnd : MonoBehaviour
{
    public GameObject Image;
    float beg_door;
    float End_door;
    public GameObject Canvas_Endkey;
    public enum Case
    {
        check,
        checkdn
    }
    public Case @case;

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
            switch (@case)
            {
                case Case.check:
                    

                    if (beg_door < Player.position.x && Player.position.x < End_door && gameManager.destroyCassetteNumber == 6)
                    {
                        Image.SetActive(true);
                        if (Input.GetKey(KeyCode.E))
                        {
                            GameObject CanvasEndkey = (GameObject)Instantiate(Canvas_Endkey);

                            //do courtine
                            gameManager.HaveEndKey = true;

                        }
                    }
                    else
                    {
                        Image.SetActive(false);
                    }
                    break;
                case Case.checkdn:
                    Image.SetActive(false);
                    if(gameObject.transform.position != new Vector3(-215 , transform.position.y,transform.position.z))
                    {
                        transform.position = new Vector3(-215, transform.position.y,transform.position.z);
                    }


                    break;
            }
        }
    }
}