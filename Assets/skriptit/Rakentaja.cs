using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rakentaja : MonoBehaviour
{
    /* Tämän luokan kirjoitti: "Unknown"
     * Kurssille Ohjelmoinnin perusteet
     * 1. oppimistehtävä 
     */

    // määritellään rakennuspalikat
    // RakennusPalikka on kiinteä, joka ei reagoi osumiin
    public GameObject RakennusPalikka;
    // LiiketuteltavaPalikka reagoi törmäykseen
    public GameObject LiikuteltavaPalikka;

    // aloituskorkeus rakennuspalikoille 1 X 1 palikoille
    private float aloitusKorkeus=0.5f;

    void Start()
    {
        teePelialueenRajat();

        // tekee parametrien määrän torneja satunnaisiin paikkoihin
        teeTornit(10);

        /* tekee seinän jonka parametrit ovat seuraavat:
         * 1. seinän aloitussijainnin X koordinaatti
         * 2. seinän aloitussijainnin Z koordinaatti
         * 3. seinän korkeus
         * 4. seinän pituus
         * 5. seinän suunta (pysty/vaaka)
         * esim: teeSeina(1,2,5,10,pysty)
         * tekee seinän kohtaan 1,2, joka on 5 korkea ja 10 pitkä Z akselin suuntaan)
         */
        teeSeina(-25, -25, 20, 50, "pysty");
        

        /* Tornin parametrit ovat seuraavat:
         * 1. sijainnin X koordinaatti 
         * 2. sijainnin Z koordinaatti
         * 3. esteen korkeus
         */
        teeTorni(1,1,5);

    }

    void teeSeina(int startx, int startz, int korkeus, int pituus, string suunta)
    {
        if (suunta == "pysty")
        {
            for (int k = 0; k < korkeus; k++)
            {
                for (int p = 0; p < pituus; p++)
                {
                    Instantiate(RakennusPalikka, new Vector3(startx, aloitusKorkeus + k, startz + p), Quaternion.identity);
                }
            }
        }
        else if (suunta == "vaaka")
        {
            for (int k = 0; k < korkeus; k++)
            { 
                for (int p = 0; p < pituus; p++)
                {
                    Instantiate(RakennusPalikka, new Vector3(startx + p, aloitusKorkeus + k, startz), Quaternion.identity);
                }
            }
        }
    }

    void teeTorni(int x, int z, int korkeus)
    {
        for(int y = 0; y < korkeus; y++)
        {
            Instantiate(RakennusPalikka, new Vector3(x, aloitusKorkeus+y, z), Quaternion.identity);
        }
        
    }

    void teeTornit(int maara)
    {
        for(int m = 0; m<maara; m++)
        {
            int rand_x = Random.Range(-49, 49);
            int rand_z = Random.Range(-49, 49);
            teeTorni(rand_x, rand_z, 5);
        }
    }


    void teePelialueenRajat()
    {
        teeSeinaPystysuoraan(-49);
        teeSeinaPystysuoraan(49);
        teeSeinaVaakasuoraan(-49);
        teeSeinaVaakasuoraan(49);
    }


    //funktion parametrit on X sijainti, mihin seinä tehdään
    void teeSeinaPystysuoraan(int xSijainti)
    {
        for (int z = -49; z < 50; z++)
        {
            Instantiate(RakennusPalikka, new Vector3(xSijainti, aloitusKorkeus, z), Quaternion.identity);
        }

    }

    // funktion parametrit on Z sijainti, mihin seinä tehdään
    void teeSeinaVaakasuoraan(int zSijainti)
    {
        for (int x = -49; x < 50 ; x++)
        {
            Instantiate(RakennusPalikka, new Vector3(x, aloitusKorkeus, zSijainti), Quaternion.identity);
        }


    }


    /*
    void Update()

    {
        // määritellään satunnaisluku väliltä 4.0 <-> 7.0
        korkeus = Random.Range(4f, 7f);
        // annetaan uusi korkeus
        Instantiate(RakennusPalikka, new Vector3(2.0f,korkeus, 2.0f), Quaternion.identity);
    }
    */


}
