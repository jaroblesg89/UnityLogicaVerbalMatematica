using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimpleInputNamespace;

public class sistemaDisparo : MonoBehaviour
{
    public Transform balaFinal;
    public Rigidbody balaPrefab;
    public float fuerza = 500.0f;
    float tiempoActual;
    public float delay = 0.5f;
    AudioSource audioOrigen;
    // Start is called before the first frame update
    void Start()
    {
        audioOrigen = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if((Mathf.Abs(SimpleInput.GetAxisRaw("MouseX"))>0.75f) ||
        (Mathf.Abs(SimpleInput.GetAxisRaw("MouseY"))>0.75f) &&
        ((Time.time - tiempoActual > delay) || (tiempoActual < 0.01f))){

            tiempoActual = Time.time;
            audioOrigen.Play();

            Rigidbody bulletInstance = Instantiate(balaPrefab, balaFinal.position, balaFinal.rotation) as Rigidbody;
            bulletInstance.AddForce(balaFinal.forward * fuerza);
        } 
    }
}
