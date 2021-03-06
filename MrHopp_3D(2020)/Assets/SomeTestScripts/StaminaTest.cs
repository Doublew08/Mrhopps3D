using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StaminaTest : MonoBehaviour
{
    public Slider StaminaSlider;
    public const float MaxStamina = 100f;
    public float Stamina;
    // Start is called before the first frame update
    void Start()
    {
        Stamina = MaxStamina;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Stamina < MaxStamina)
        {
            IncreaseTheStamina();
        }
    }
    public void DecreaseInStamina(float amount)
    {
        Stamina = Stamina - amount * 2;
        StaminaSlider.value = Stamina;
        if (Stamina < 0)
        {
            Stamina = 0;
            Debug.Log("You dont have enough stamina");
            
        }
    }
    void IncreaseTheStamina()
    {

        Stamina = Stamina + Time.deltaTime * 4;
        StaminaSlider.value = StaminaSlider.value + Time.deltaTime * 4;
    }
}
