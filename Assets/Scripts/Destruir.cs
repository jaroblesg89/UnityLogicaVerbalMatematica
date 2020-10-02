using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruir : MonoBehaviour
{
    public float delay = 3.0f;
    // Start is called before the first frame update
    void Start()
    {
        if(gameObject != null){
Destroy(this.gameObject, delay);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
