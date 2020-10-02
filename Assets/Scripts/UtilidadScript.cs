using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UtilidadScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Pause();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Reinicio(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Salir(){
        Application.Quit();
    }

    public void Pause(){
        Time.timeScale = 0.0f;
    }

    public void NoPause(){
        Time.timeScale = 1.0f;
    }
}
