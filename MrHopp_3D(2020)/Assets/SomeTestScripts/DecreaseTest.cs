using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecreaseTest : MonoBehaviour
{
    StaminaTest Stamina;
    // Start is called before the first frame update
    void Start()
    {
        Stamina = FindObjectOfType<StaminaTest>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log(2F);
            Stamina.DecreaseInStamina(10);
        }
    }
}
