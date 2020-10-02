using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimpleInputNamespace;

public class movimientoJugador : MonoBehaviour
{
    public Transform rotacion;
    private Rigidbody Cuborb;
    public float velocidad = 5.0f;

    private Vector2 input;
    // Start is called before the first frame update
    void Start()
    {
        Cuborb = GetComponent<Rigidbody>();
    }

    bool ObtenerInput(string horizontal, string vertical){
        input.x = SimpleInput.GetAxisRaw(horizontal) * velocidad;
        input.y = SimpleInput.GetAxisRaw(vertical) * velocidad;

        return (Mathf.Abs(input.x)>0.01f) || (Mathf.Abs(input.y)>0.01f);
    }

    void MueveJugador(){
        Cuborb.velocity = Vector3.Normalize(new Vector3(input.x, 0, input.y)) * velocidad;
    }

    void RotarTorreta(){
        rotacion.eulerAngles = new Vector3(0, Mathf.Atan2(input.x, input.y) * 180 / Mathf.PI ,0);
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        if(ObtenerInput("Horizontal","Vertical")){
            MueveJugador();
        }

        if(ObtenerInput("MouseX","MouseY")){
            RotarTorreta();
        }
    }
}
