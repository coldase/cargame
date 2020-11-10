using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tarkistaTriggerOsuma : MonoBehaviour
{
    public GameObject tie;
    
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
            var startRoad = 50f + (statistiikka.tieindex - 1f) * 100f;
            Instantiate(tie, new Vector3(0f, -0.5f, startRoad), Quaternion.identity).name = statistiikka.tieindex.ToString();
            statistiikka.tieindex += 1f;
            statistiikka.startRoad = startRoad;
            Debug.Log(startRoad);
            statistiikka.score++;
            
            //Vaikeusasteen säätö
            if (statistiikka.tieindex < 10)
            {
                statistiikka.vaikeusaste = 1;
            }
            if (statistiikka.tieindex > 10)
            {
                statistiikka.vaikeusaste = statistiikka.tieindex / 10;
            }
        }
    }
}
