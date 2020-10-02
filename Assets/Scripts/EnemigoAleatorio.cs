using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoAleatorio : MonoBehaviour
{
    public float delay = 4.0f;
    public GameObject enemigo;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("ApareceEnemigo",0.0f,delay);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ApareceEnemigo(){
        int randomPos = (int) Random.Range(0, transform.childCount);
        Instantiate(enemigo, transform.GetChild(randomPos).position, enemigo.transform.rotation);
    }
}
