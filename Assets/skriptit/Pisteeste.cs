using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pisteeste : MonoBehaviour
{
    private void OnCollisionEnter(Collision osuma)
    {
        if (osuma.gameObject.CompareTag("autotag"))
        {
            statistiikka.pisteet++;
            Destroy(this.gameObject);
        }
    }
    
}