using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class EndMenu : MonoBehaviour
{
    public void TryAgain()
    {
        Debug.Log("Trying again!");
        SceneManager.LoadScene("ajopeli_hiekkalaatikko");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Menu");
        Debug.Log("QUITTING!!");
    
    }
}
