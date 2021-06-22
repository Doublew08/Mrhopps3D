using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class helpremoved : MonoBehaviour
{
    // Start is called before the first frame update
    public bool startco;
    void Start()
    {
        
    
    }

    void Awake()
    {
        startco = false;
        StartCoroutine(myco());
    }
    // Update is called once per frame
    void Update()
    {
        if (!startco)
        {
            StopCoroutine(myco());
        }   
    }
    IEnumerator myco()
    {
        PlayerMovement player = gameObject.GetComponent<PlayerMovement>();
        player.canmove = false;
        yield return new WaitForSeconds(4);
        gameObject.SetActive(false);
        player.canmove = true;
        startco = true;

    }
}
