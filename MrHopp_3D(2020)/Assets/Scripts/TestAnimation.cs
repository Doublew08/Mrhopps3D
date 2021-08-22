using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestAnimation : MonoBehaviour
{
    private Animator Rabbit;
    // Start is called before the first frame update
    void Start()
    {
        Rabbit = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Rabbit.SetFloat("Walk", 0.2f);
        Rabbit.SetFloat("Direction", 1f);
    }
}
