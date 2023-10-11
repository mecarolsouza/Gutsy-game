using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetterRaiva : MonoBehaviour
{    
    GameController gControl;

    public GameObject Letter1;
    // Start is called before the first frame update
    void Start()
    {
        gControl = GameController.gControl;        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Makes the item disappear
    void OnTriggerEnter2D(Collider2D collider){

        if(collider.gameObject.tag == "Player")
        {
            GameController.gControl.proximaCena = "GutsyReturn";

            gControl.LetterOn(); //Ativa a carta coletada

           // Letter1.SetActive(true); //Mostra o texto da carta

            Destroy(gameObject);
        }
    }
}