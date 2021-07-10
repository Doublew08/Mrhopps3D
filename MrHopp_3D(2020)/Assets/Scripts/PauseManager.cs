using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseManager : MonoBehaviour
{
    public GameObject PauseMenu_BackGround;

    public void Yes()
    {
        SceneManager.LoadScene(0);
    }

    public void No()
    {
        PauseMenu_BackGround.SetActive(false);
    }
}
