using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lettermedo : MonoBehaviour
{    
    GameController gControl;
    public GameObject RecadoPorta;
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

    private void OnDestroy()
    {
        // Verifique se o objeto RecadoPorta não é nulo e ative-o.
        if (RecadoPorta != null)
        {
            RecadoPorta.SetActive(true);
        }
    }

    //Makes the item disappear
    void OnTriggerEnter2D(Collider2D collider){

        if(collider.gameObject.tag == "Player")
        {
            gControl.LetterOn(); //Ativa a carta coletada

            Letter1.SetActive(true); //Mostra o texto da carta

            Destroy(gameObject);
        }
    }
}
