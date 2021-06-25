using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextWillBeCleared : MonoBehaviour
{
    public GameObject text2clear;
    int i;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.instance)
        {
            if (GameManager.instance.TextToBeCleared <= 1)
            {
                StartCoroutine(wait2dest());
            }
        }
    }
    IEnumerator wait2dest()
    {
        if (text2clear != null)
        {
            text2clear.SetActive(true);
        }
        yield return new WaitForSeconds(3);
        if (text2clear != null)
        {
            Destroy(text2clear);
        }
        
    }
}
