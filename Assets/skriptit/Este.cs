using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Este : MonoBehaviour
{
    private void OnCollisionEnter(Collision osuma)
    {
        if (osuma.gameObject.CompareTag("autotrigger"))
        {
            Destroy(this.gameObject);
            statistiikka.gas--;
        }
    }
}
