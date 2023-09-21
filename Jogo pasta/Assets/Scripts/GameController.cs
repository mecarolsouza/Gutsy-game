using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
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
    }
}
