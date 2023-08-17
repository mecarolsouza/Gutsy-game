using UnityEngine;
using UnityEngine.UI;

public class resumegame : MonoBehaviour
{
    public GameObject Letter1; // Referência ao GameObject do menu de pausa

    public void start()
    {
        Button resumegame = GetComponent<Button>();
        resumegame.onClick.AddListener(ResumeGame);
      
    }

    public void ResumeGame()
    {
        Time.timeScale = 1f; // Retorna o tempo ao normal para retomar o jogo
       Letter1.SetActive(false); // Esconde o menu de pausa
    }
}
