using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Battery : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Makes the item disappear
    void OnTriggerEnter2D(Collider2D collider){

        if(collider.gameObject.tag == "Player"){
            Destroy(gameObject);
        }
    }
}