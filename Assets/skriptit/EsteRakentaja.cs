﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EsteRakentaja : MonoBehaviour
{
    public GameObject Este;
    public GameObject Pisteeste;

    // Start is called before the first frame update
    void Start()
    {   
        RakennaEsteita(statistiikka.startRoad, statistiikka.startRoad + 100f, statistiikka.vaikeusaste);
        RakennaPisteesteita(statistiikka.startRoad, statistiikka.startRoad + 100f);
    }

       
    // Update is called once per frame
    void Update()
    {
        
    }
    void RakennaPisteesteita(float start, float end)
    {
        for (float i=start; i < end; i += 20)
        {
            float random_x = Random.Range(-9, 9);
            Instantiate(Pisteeste, new Vector3(random_x, 1, i), Quaternion.identity);
        }
    }

    void RakennaEsteita(float start, float end, float taso)
    {

        for (float i =start; i < end; i += 50 / taso)
        {
            int random_x = Random.Range(-9, 9);
            Instantiate(Este, new Vector3(random_x, 1, i), Quaternion.identity);
        }
    }
}
