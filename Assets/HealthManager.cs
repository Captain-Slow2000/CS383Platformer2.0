using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HealthManager : MonoBehaviour
{
    // Start is called before the first frame update
    public TMP_Text HealthDisplay;
    int health = 5;

    private void Awake(){
        instance = this;    
    }

    public static HealthManager instance;

    void Start()
    {
        HealthDisplay.text = "HEALTH: " + health.ToString();
    }

    // Update is called once per frame
    public void ReduceHealth()
    {
        health -= 1;
        if(health >=0){
            HealthDisplay.text = "Health: " + health.ToString();
        }else{
            HealthDisplay.text = "DEAD";
        }
        Debug.Log("Ouch!");

    }

    public void Update(){
        //change transform position
        //getPlayerposition
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        this.transform.position = new Vector2(player.transform.position.x, player.transform.position.y+45);
        //<transform.getPlayerposition>();
    }
}
