using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneAgainInRoof : MonoBehaviour
{
    PlayerMovement2 Player2;

    public GameObject Panel;
    private int Cs;

    // Start is called before the first frame update
    void Start()
    {
        Player2 = FindObjectOfType<PlayerMovement2>();


    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit Ray;
        if (Physics.Raycast(transform.position, -transform.up, out Ray, Mathf.Infinity))
        {
            if (Ray.collider.tag == "Player")
            {
                Debug.Log("I catch you");
                Panel.SetActive(true);
                StartCoroutine(RabbitCatchThePlayer());

            }

        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawRay(transform.position, -transform.up * 1000);
    }
    IEnumerator RabbitCatchThePlayer()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(8);


    }

}
