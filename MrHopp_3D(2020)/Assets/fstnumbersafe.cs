using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fstnumbersafe : MonoBehaviour
{
    public Text[] SafeNums;
    //public GameObject[] Buttons;
    public Button[] buttons;
    [Range(0,9)]
    public int[] nums;
    
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
                if (nums[0] < 9)
                {
                    Debug.Log("Increase 1st 1 ");
                    nums[0] = int.Parse(SafeNums[N].text) + 1;
                    SafeNums[N].text = nums[0].ToString();
                }
            }
            if (N == 2)
            {
                if (nums[1] < 9)
                {
                    nums[1] = int.Parse(SafeNums[1].text) + 1;
                    SafeNums[1].text = nums[1].ToString();
                }
            }
            if (N == 4)
            {
                if (nums[2] < 9)
                {
                    nums[2] = int.Parse(SafeNums[2].text) + 1;
                    SafeNums[2].text = nums[2].ToString();
                }
            }
            if (N == 6)
            {
                if ( nums[3] < 9)
                {
                    nums[3] = int.Parse(SafeNums[3].text) + 1;
                    SafeNums[3].text = nums[3].ToString();
                }
            }
        }
        else
        {
            if (N == 1)
            {
                if (nums[0] > 0)
                {
                    nums[0] = int.Parse(SafeNums[0].text) - 1;
                    SafeNums[0].text = nums[0].ToString();
                }
            }
            if (N == 3)
            {
                if (nums[1] > 0)
                {
                    nums[1] = int.Parse(SafeNums[1].text) - 1;
                    SafeNums[1].text = nums[1].ToString();
                }
            }
            if (N == 5)
            {
                if (nums[2] > 0)
                {
                    nums[2] = int.Parse(SafeNums[2].text) - 1;
                    SafeNums[2].text = nums[2].ToString();
                }
            }
            if (N == 7)
            {
                if (nums[3] > 0)
                {
                    nums[3] = int.Parse(SafeNums[3].text) - 1;
                    SafeNums[3].text = nums[3].ToString();
                }
            }
        }
        // Debug.Log("You have clicked the button #" + buttonIndex, buttons[buttonIndex]);
    }
}
