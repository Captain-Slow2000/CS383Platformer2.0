using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxOfDoom : MonoBehaviour
{
    public Rigidbody2D hurt;
    // Start is called before the first frame update
    void Start()
    {
        hurt = gameObject.GetComponent<Rigidbody2D>();
    }

    void OnTriggerEnter2D(Collider2D other){
        //Fix this later

        HealthManager.instance.ReduceHealth();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
