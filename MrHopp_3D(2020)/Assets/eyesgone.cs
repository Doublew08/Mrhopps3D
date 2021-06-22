using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eyesgone : MonoBehaviour
{
    public GameObject Eyez;
    public GameObject Player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameManager gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
        
        if (Player.transform.position.x < -188.5)
        {
            gameManager.destroy_eyes = true;

        }
        if (gameManager.destroy_eyes)
        {
            Destroy(Eyez);
        }
    }
}
