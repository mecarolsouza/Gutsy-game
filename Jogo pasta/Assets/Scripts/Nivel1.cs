using UnityEngine;

public class Nivel1 : MonoBehaviour
{
    public GameObject MenuPause;
    private void Start()
    {
       MenuPause.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            MenuPause.SetActive(true);
        }
    }
}

