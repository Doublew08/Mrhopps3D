using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhoneCall : MonoBehaviour
{
    public GameManager gameManager;
    float beg_door;
    float End_door;
    public GameObject Hand;
    public GameObject MarkCALL;
    public enum Call
    {
        NDone,
        Done,
        
    }
    public Call @call;
    // Start is called before the first frame update
    void Start()
    {
        beg_door = transform.position.x - (transform.localScale.x / 2);
        End_door = transform.position.x + (transform.localScale.x / 2);
    }

    // Update is called once per frame
    void Update()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();

        if (GameObject.FindGameObjectWithTag("Player") != null)
        {
            Transform Player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();

            switch (@call)
            {
                case Call.NDone:

                    if (gameManager.destroyCassetteNumber == 4 && Player.position.x < 120)
                    {
                        //run sound
                        if (beg_door < Player.position.x && Player.position.x < End_door)
                        {
                            Hand.SetActive(true);

                            if (Input.GetKey(KeyCode.E) )
                            {
                                // run call
                                StartCoroutine("MarkCallCo");

                            }



                        }

                        else

                        {

                            Hand.SetActive(false);

                        }

                    }
                    break;
                case Call.Done:
                    if (beg_door < Player.position.x && Player.position.x < End_door)
                    {
                        Hand.SetActive(true);

                    }
                    else
                    {
                        Hand.SetActive(false);
                    }
                    break;
                    
            }
        } 
        
    } 

IEnumerator MarkCallCo()
    {
        Debug.Log("Calling");
        GameObject callmark = (GameObject)Instantiate(MarkCALL, GameObject.FindGameObjectWithTag("Canvas").transform);
        yield return new WaitForSeconds(8);
        callmark.SetActive(false);
        Debug.Log("waited");
        gameManager.call_done = true;
        yield break;
    }    
} 

