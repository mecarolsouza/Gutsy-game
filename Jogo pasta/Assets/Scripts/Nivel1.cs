using UnityEngine;

public class Nivel1 : MonoBehaviour
{
    public GameObject MenuPause;
    public GameObject Letter1;
    private void Start()
    {
       MenuPause.SetActive(false);
       Letter1.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            MenuPause.SetActive(true);
        }
    }
}

