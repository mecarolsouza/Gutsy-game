using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Letterhide : MonoBehaviour
{
    public GameObject Letter1; // Referência ao GameObject da carta
    public Button resumegame;

    private void Start()
    {
        Button resumegameButton = resumegame.GetComponent<Button>();
        resumegameButton.onClick.AddListener(ResumeGame);
    }

    public void ResumeGame()
    {
        Time.timeScale = 1f; // Retorna o tempo ao normal para retomar o jogo
        Letter1.SetActive(false); // Esconde a carta
    }
}
