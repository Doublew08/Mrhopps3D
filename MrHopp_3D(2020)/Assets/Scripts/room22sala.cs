﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class room22sala : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadSceneAsync(4);
    }
}
