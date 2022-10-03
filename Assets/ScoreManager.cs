using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    // Start is called before the first frame update
    public TMP_Text ScoreDisplay;
    int score = 0;

    private void Awake(){
        instance = this;    
    }

    public static ScoreManager instance;

    void Start()
    {
        ScoreDisplay.text = "SCORE: " + score.ToString();
    }

    // Update is called once per frame
    public void AddScore()
    {
        score += 10;
        ScoreDisplay.text = "SCORE: " + score.ToString();

    }

    public void Update(){
        //change transform position
        //getPlayerposition
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        this.transform.position = new Vector2(player.transform.position.x, player.transform.position.y+75);
        //<transform.getPlayerposition>();
    }
}
