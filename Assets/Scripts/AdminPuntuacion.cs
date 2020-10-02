using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdminPuntuacion : MonoBehaviour
{
    public static AdminPuntuacion instancia;
    public Text scoreText;
    int score;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

  

    void Awake(){
        if(instancia){
            Destroy(this.gameObject);
        }else{
            instancia = this;
        }
        UpdateScore();
    }

    public void IncrementaScore(int cantidad){
        score += cantidad;
        UpdateScore();
    }

      void UpdateScore(){
        scoreText.text = "Score: "+ score.ToString();
    }   
}
