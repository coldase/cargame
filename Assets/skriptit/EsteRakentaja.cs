using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EsteRakentaja : MonoBehaviour
{
    public GameObject Este;
    public GameObject Pisteeste;
    // Start is called before the first frame update
    void Start()
    {
        //RakennaPisteesteita();
        //RakennaEsteita();
    }


    // Update is called once per frame
    void Update()
    {
        
    }
    void RakennaPisteesteita()
    {
        for (int i=10; i < 100; i += 10)
        {
            int random_x = Random.Range(-9, 9);
            Instantiate(Pisteeste, new Vector3(random_x, 1, i), Quaternion.identity);
        }
    }

    void RakennaEsteita()
    {
        for (int i = 20; i < 100; i += 10)
        {
            int random_x = Random.Range(-9, 9);
            Instantiate(Este, new Vector3(random_x, 1, i), Quaternion.identity);
        }
    }
}
