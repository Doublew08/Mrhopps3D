using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fstnumbersafe : MonoBehaviour
{
    public Text[] SafeNums;
    //public GameObject[] Buttons;
    public Button[] buttons;
    
    // Start is called before the first frame update
    void Start()
    {
        foreach(Text i in SafeNums)
        {
            i.text = "0";
        }
        /* foreach(Button j in btns)
          {
              j.onClick.AddListener(IncreaseButton);
          }*/
        for (int i = 0; i < buttons.Length; i++)
        {
            int closureIndex = i; // Prevents the closure problem
            buttons[closureIndex].onClick.AddListener(() => TaskOnClick(closureIndex));
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void TaskOnClick(int buttonIndex)
    {
        int N = buttonIndex;
       // int M = 
        print(N);

        if(N%2 == 0)
        {
            if (N == 0)
            {
                Debug.Log("Increase 1st 1 ");
                int number = int.Parse(SafeNums[N].text) + 1;
                SafeNums[N].text = number.ToString();
            }
            if (N == 2)
            {
                int number = int.Parse(SafeNums[1].text) + 1;
                SafeNums[1].text = number.ToString();
            }
            if (N == 4)
            {
                int number = int.Parse(SafeNums[2].text) + 1;
                SafeNums[2].text = number.ToString();
            }
            if (N == 6)
            {
                
                int number = int.Parse(SafeNums[3].text) + 1;
                SafeNums[3].text = number.ToString();
            }

        }
        else
        {
            if (N == 1)
            {
                int number = int.Parse(SafeNums[0].text) - 1;
                SafeNums[0].text = number.ToString();
            }
            if (N == 3)
            {
                int number = int.Parse(SafeNums[1].text) - 1;
                SafeNums[1].text = number.ToString();
            }
            if (N == 5)
            {
                int number = int.Parse(SafeNums[2].text) - 1;
                SafeNums[2].text = number.ToString();
            }
            if (N == 7)
            {
                int number = int.Parse(SafeNums[3].text) - 1;
                SafeNums[3].text = number.ToString();
            }

        }
        // Debug.Log("You have clicked the button #" + buttonIndex, buttons[buttonIndex]);
    }
}
