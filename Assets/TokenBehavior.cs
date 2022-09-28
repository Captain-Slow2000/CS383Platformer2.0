using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TokenBehavior : MonoBehaviour
{
    public Rigidbody2D token;

    // Start is called before the first frame update
    void Start()
    {
        token = gameObject.GetComponent<Rigidbody2D>();
    }

    void OnTriggerEnter2D(Collider2D other){
        //Fix this later

        ScoreManager.instance.AddScore();
        //Play Audio Clip
        Destroy(gameObject);
        Debug.Log("Touched a token!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
