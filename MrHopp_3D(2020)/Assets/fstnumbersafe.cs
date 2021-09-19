using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fstnumbersafe : MonoBehaviour
{
    public Text[] SafeNums;
    public GameObject[] Buttons;
    // Start is called before the first frame update
    void Start()
    {
        foreach (Text text in SafeNums)
        {
            text.text = "0";
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
   public void ChangeValButton()
    {
        int N = int.Parse(gameObject.name);
        //for (int i = 0; i < 8; i++)
        
            if (N % 2 == 0)
            {
                if (N == 0)
                {
                Debug.Log("Increase 1st 1 ");
                    int number = int.Parse(SafeNums[N].text) + 1;
                    SafeNums[N].text = number.ToString();
                }
            if (N == 2)
            {
                int number = int.Parse(SafeNums[N].text) + 1;
                SafeNums[N].text = number.ToString();
            }
            if (N == 4)
            {
                int number = int.Parse(SafeNums[N].text) + 1;
                SafeNums[N].text = number.ToString();
            }
            if (N == 6)
            {
                int number = int.Parse(SafeNums[N].text) + 1;
                SafeNums[N].text = number.ToString();
            }

        }
            else
            {
            if (N == 1)
            {
                int number = int.Parse(SafeNums[N].text) - 1;
                SafeNums[N].text = number.ToString();
            }
            if (N == 3)
            {
                int number = int.Parse(SafeNums[N].text) - 1;
                SafeNums[N].text = number.ToString();
            }
            if (N == 5)
            {
                int number = int.Parse(SafeNums[N].text) - 1;
                SafeNums[N].text = number.ToString();
            }
            if (N == 7)
            {
                int number = int.Parse(SafeNums[N].text) - 1;
                SafeNums[N].text = number.ToString();
            }

        }
        }
    }

