using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
   //Controle de níveis
    public string proximaCena = "Nivel2";
   
   //Controle da porta
    public GameObject porta;
    public Sprite spritePortaAberta;
    
    
    public static GameController gControl {get; private set;}

    public bool letterOn;
    
    

    
    private void Awake()
    {
        if(gControl == null)
        {
            gControl = this;
        }
        else
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
    }

    
        

    public void LetterOn ()
    {
        letterOn = true;

        if (porta != null && spritePortaAberta != null)
            {
                SpriteRenderer portaRenderer = porta.GetComponent<SpriteRenderer>();
                if (portaRenderer != null)
                {
                    portaRenderer.sprite = spritePortaAberta;
                }
            }
    }
}
