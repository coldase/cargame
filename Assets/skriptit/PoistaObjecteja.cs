using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoistaObjecteja : MonoBehaviour
{
    /* 1. Tien etäisyys selvittää
     * 2. Koska tien nimet on esim. 2,3,4,5...
     * 3. kauimpana oleva tie, on se jolla on pienin numero nimenä eli täsmällisemmin millaisella kaavalla se löytyy?
     * 4. GameObject.find(statistiikka.tieindex-2)
     * TEHTAVA: Tee vaikeusaste, tee pisteboxit/esteet, poista boksit
     */



    // Update is called once per frame
    void Update()
    {
        if(statistiikka.tieindex > 4)
        {
            GameObject poistettavaTie = GameObject.Find((statistiikka.tieindex - 3).ToString());
            Destroy(poistettavaTie);
        }
    }
}
