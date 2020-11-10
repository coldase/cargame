using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class statistiikka : MonoBehaviour
{
    public Text PisteetTeksti;
    public static int pisteet = 0;
    public static float tieindex = 2f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        PisteetTeksti.text = "SCORE: "+pisteet.ToString();
    }
}
