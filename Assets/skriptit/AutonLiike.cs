using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AutonLiike : MonoBehaviour
{
    public Rigidbody auto;
    public float AutonNopeus = 2f;
    public float SivuttaisLiike = 5f;
    private float xsijainti;
    // Update is called once per frame
    void Start()
    {
        auto = GetComponent<Rigidbody>();
    }

    void Update()
    {
        check_if_ob();
        xsijainti = 0f;
        //Lähdetään muuttamaan kappaleen z sijaintia
        //Translate muuttaa kappaleen sijaintia
        //Forward on z - akselin suunta
        //Time.deltaTime laskee framien välisen ajan
        //transform.Translate(Vector3.forward*Time.deltaTime*AutonNopeus);        
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            xsijainti = -SivuttaisLiike * Time.deltaTime;

        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            xsijainti = SivuttaisLiike * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            auto.AddForce(0,0,-5f);       
        }
        
        auto.AddForce(xsijainti, 0, AutonNopeus * Time.deltaTime, ForceMode.Force);
        
    }

    // Aloittaa scenen alusta ja nollaa pisteet jos auto tippuu tieltä (Out of Bounds)
    // tai jos auton Y sijainti on alle -5
    void check_if_ob()
    {
        if (auto.transform.position.y < -5)
        {
            SceneManager.LoadScene("ajopeli_hiekkalaatikko");
            statistiikka.tieindex = 2f;
            statistiikka.gas = 20;
            statistiikka.vaikeusaste = 1f;
            statistiikka.startRoad = 0f;
        }
    }
}
