using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalBehavior : MonoBehaviour
{
    public Rigidbody2D goal;
    public AudioSource audioPlayer;

    // Start is called before the first frame update
    void Start()
    {
        goal = gameObject.GetComponent<Rigidbody2D>();
    }

   void OnTriggerEnter2D(Collider2D other){
        //Fix this later

        //ScoreManager.instance.AddScore();
        //Play Audio Clip
        audioPlayer.Play();
        Destroy(gameObject);
        Debug.Log("You Win!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
