using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Maaliviiva : MonoBehaviour
{
    private void OnCollisionEnter(Collision osuma)
    {
        if (osuma.gameObject.CompareTag("autotag"))
        {
            SceneManager.LoadScene("ajopeli_hiekkalaatikko");
        }
    }
}
