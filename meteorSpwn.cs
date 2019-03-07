using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meteorSpwn : MonoBehaviour
{
    [SerializeField]
    GameObject meteoritok;
    [SerializeField]
    int ismSzam = 5; 
    void Start()
    {
        for (int i = 0; i < ismSzam; i++)
        {
            var helyzet = new Vector2(Random.Range(-20, 20), Random.Range(-20, 20));
            Instantiate(meteoritok, helyzet, Quaternion.identity);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
