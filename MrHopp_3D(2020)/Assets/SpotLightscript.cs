using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpotLightscript : MonoBehaviour
{
    public GameObject plush;
    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine("Light");

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
}
