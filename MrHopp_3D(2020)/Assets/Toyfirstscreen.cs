using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toyfirstscreen : MonoBehaviour
{
    public static Toyfirstscreen instance;
    public GameObject screenwarn;
    public int mrnum;


    // Start is called before the first frame update
    public void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.instance.ScreenToBeCleared == 1 && mrnum < 1)
        {
            StartCoroutine(screentoshow());
        }
        else if(mrnum >= 1)
        {
            StopCoroutine(screentoshow());
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Toy")
        {
            Debug.Log("screentobecleared++");
            GameManager.instance.ScreenToBeCleared++;
        }
    }
    IEnumerator screentoshow()
    {
        PlayerMovement player = gameObject.GetComponent<PlayerMovement>();

        if (screenwarn != null)
        {
            mrnum++;
            player.canmove = false;
            screenwarn.SetActive(true);
        }
        yield return new WaitForSeconds(8.5f);
        if (screenwarn != null)
        {
            Destroy(screenwarn);
            player.canmove = true;
        }
    }

}

