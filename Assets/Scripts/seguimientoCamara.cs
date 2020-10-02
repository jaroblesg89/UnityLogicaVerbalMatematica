using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class seguimientoCamara : MonoBehaviour
{
    public Transform jugador;
    public float height = 12.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void LateUpdate(){
        this.transform.position = new Vector3(jugador.position.x, height, jugador.position.z);
    }
}
