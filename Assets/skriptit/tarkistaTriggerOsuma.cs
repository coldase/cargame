using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tarkistaTriggerOsuma : MonoBehaviour
{
    public GameObject tie;
    private bool triggered = false;
    static float tieindex = 2f;
    static int tienumero = 2;
    public static float testi = 100f;

    private void OnTriggerEnter(Collider osuma)
    {
        if (osuma.CompareTag("autotag") && !triggered)
        {
            //z sijainti pitäisi olla 150, 250, 350, jne
            //laita luvun 2 tilalle muuttuja, jonka avulla pystyt rakentamaan
            //tien aina oikeaan kohtaan pelissä
            //vihje "static"
            Debug.Log("TRIGGEREDD!!!!");
            var zRoad = 50f + (tieindex - 1f) * 100f;
            Instantiate(tie, new Vector3(0f, -0.5f, zRoad), Quaternion.identity).name = tienumero.ToString();
            triggered = true;
            tieindex += 1f;
            tienumero++;
            Debug.Log(zRoad);
            testi = zRoad;
        }
        if (tienumero > 5)
        {
            Destroy(GameObject.Find((tienumero-4).ToString()));
        }
    }
}
