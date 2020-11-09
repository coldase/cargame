using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tarkistaTriggerOsuma : MonoBehaviour
{
    public GameObject tie;

    private void OnTriggerEnter(Collider osuma)
    {
        if (osuma.CompareTag("autotag"))
        {
            //z sijainti pitäisi olla 150, 250, 350, jne
            // laita luvun 2 tilalle muuttuja, jonka avulla pystyt rakentamaan
            //tien aina oikeaan kohtaan pelissä
            //vihje "static"
            Debug.Log("TRIGGEREDD!!!!");
            Instantiate(tie, new Vector3(0f, -0.5f, 50f + (2 - 1) * 100f), Quaternion.identity);

        }
    }
}
