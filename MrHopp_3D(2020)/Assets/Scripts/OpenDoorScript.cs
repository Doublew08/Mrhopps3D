using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoorScript : MonoBehaviour
{
    public  bool OpenWay;
    [SerializeField] private float OpenSpeed;

    private bool IsOpen;
    private float AngleSpeedTarget;
    // Start is called before the first frame update

    void Start()
    {
        OpenDoor();
    }

    // Update is called once per frame
    void Update()
    {
        Quaternion smoothRotate = Quaternion.Lerp(transform.localRotation, Quaternion.Euler(0, AngleSpeedTarget, 0)
            , OpenSpeed * Time.deltaTime);
        transform.localRotation = smoothRotate;
    }
    public void OpenDoor()
    {
        IsOpen = !IsOpen;
        if (IsOpen)
        {
            if (OpenWay)
            {
                AngleSpeedTarget = 90f;
            }
            else
            {
                AngleSpeedTarget = -90f;
            }
        }
        else
        {
            AngleSpeedTarget = 0f;
        }
    }
}
