using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class StaminaScript : MonoBehaviour
{
    public Slider StaminaSlider;
    public const float MaxStamina=100f;
    public float Stamina;
    PlayerMovement Player;
    // Start is called before the first frame update
    void Start()
    {
        
        Stamina = MaxStamina;
        Player = FindObjectOfType<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        //Make sure if Stamina is less than the MaxStamina
       /* if (Stamina < MaxStamina&&Player.IsMoving)
        {
            //then increase the stamina
            IncreaseTheStamina();
        }*/
    }
    //This method to decrease the stamina
    public void DecreaseInStamina(float amount)
    {
        //Decrese the double amount
        Stamina = Stamina - amount*2;
        //and decrease the value of stamina in the inspector
        StaminaSlider.value = Stamina;
        //check if the stamina is less than 0
        if (Stamina < 0)
        {
            //then make it 0 and make the speed of the player 40(make him slow)
            Stamina = 0;
            Debug.Log("You dont have enough stamina");
            Player.speed = 40f;   
        }
    }
    //this method to increase the stamina
   public void IncreaseTheStamina()
    {
        //increse the stamina by time multiplied in 4 
        Stamina = Stamina +Time.deltaTime*4 ;
        StaminaSlider.value = StaminaSlider.value + Time.deltaTime * 4;
    }
}
