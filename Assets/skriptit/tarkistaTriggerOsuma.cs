using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tarkistaTriggerOsuma : MonoBehaviour
{
    public GameObject tie;
    
    public static float testi = 100f;

    private void Update()
    {
        //etsi kameran sijainti
        //jos kameran sijainti on suurempi kuin esim 200f
        //niin Destory(gameObject)
    }

    private void OnTriggerEnter(Collider osuma)
    {
        if (osuma.CompareTag("autotrigger"))
        {
            
            Debug.Log("TRIGGEREDD!!!!");
            var zRoad = 50f + (statistiikka.tieindex - 1f) * 100f;
            Instantiate(tie, new Vector3(0f, -0.5f, zRoad), Quaternion.identity).name = statistiikka.tieindex.ToString();
            statistiikka.tieindex += 1f;
            Debug.Log(zRoad);
            testi = zRoad;
        }
    }
}
