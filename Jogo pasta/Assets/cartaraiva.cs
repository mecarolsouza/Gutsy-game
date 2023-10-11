using UnityEngine;
using UnityEngine.UI;

public class CloseObjectWithButton : MonoBehaviour
{
    public GameObject carta;
    public Button ButtonQ;

    private void Start()
    {
        // Add an onClick listener to the button
       ButtonQ.onClick.AddListener(CloseObject);
    }

    // Method to close the GameObject
    private void CloseObject()
    {
        carta.SetActive(false);
    }
}

