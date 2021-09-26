using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpotLightscript : MonoBehaviour
{
    //public GameObject plush;
    public GameObject Rabiit;
    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine("Light");
        StartCoroutine(Rabbit());

    }
    IEnumerator Light()
    {
        gameObject.GetComponent<Light>().enabled = false;
        yield return new WaitForSecondsRealtime(.3f);
        gameObject.GetComponent<Light>().enabled = true;
        yield return new WaitForSecondsRealtime(.3f);
        gameObject.GetComponent<Light>().enabled = false;
        yield return new WaitForSecondsRealtime(.3f);
        gameObject.GetComponent<Light>().enabled = true;
        yield return new WaitForSecondsRealtime(.3f);
        gameObject.GetComponent<Light>().enabled = false;
        yield return new WaitForSecondsRealtime(.3f);
        gameObject.GetComponent<Light>().enabled = true;
        yield return new WaitForSecondsRealtime(.3f);
        gameObject.GetComponent<Light>().enabled = false;
    }


    IEnumerator Rabbit()
    {
        
        Rabiit.SetActive(true);
        yield return new WaitForSecondsRealtime(3f);
        Rabiit.SetActive(false);
        yield return new WaitForSecondsRealtime(3f);
        Rabiit.SetActive(true);
        yield return new WaitForSecondsRealtime(3f);
        Rabiit.SetActive(false);


    }
}
