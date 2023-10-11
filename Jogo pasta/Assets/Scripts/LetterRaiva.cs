using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LetterRaiva : MonoBehaviour
{
    GameController gControl;

    public GameObject carta;
    public GameObject raiva;

    // Start is called before the first frame update
    void Start()
    {
        gControl = GameController.gControl;
        carta.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (!raiva.activeSelf)
        {
            carta.SetActive(true);
        }
    }

    // Makes the item disappear
    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.tag == "Player")
        {
            GameController.gControl.proximaCena = "GustyReturn";

            gControl.LetterOn(); //Ativa a carta coletada

           carta.SetActive(true); //Mostra o texto da carta

            Destroy(gameObject);

            SceneManagement.LoadScene(GameController.gControl.proximaCena);
        }
    }
}
