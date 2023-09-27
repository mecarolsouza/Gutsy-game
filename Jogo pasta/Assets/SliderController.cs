using UnityEngine;
using UnityEngine.UI;

public class SliderController : MonoBehaviour
{
    public Slider energySlider;
    public int maxEnergy = 100;
    private int currentEnergy;

    private void Start()
    {
        currentEnergy = maxEnergy;
        UpdateEnergySlider();
    }

    private void Update()
    {
        // Verifique se o jogador está correndo (adicione sua lógica aqui)
        bool correndo = Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift);

        // Se o jogador estiver correndo, diminua a energia
        if (correndo)
        {
            DecreaseEnergy(1); // Você pode ajustar o valor de diminuição conforme necessário
        }

        // Atualize o slider de energia
        UpdateEnergySlider();
    }

    public void CollectBattery(int amount)
    {
        // Aumente a energia quando o jogador coletar uma bateria
        currentEnergy += amount;

        // Certifique-se de que a energia não exceda o máximo
        currentEnergy = Mathf.Clamp(currentEnergy, 0, maxEnergy);

        // Atualize o slider de energia
        UpdateEnergySlider();
    }

    private void DecreaseEnergy(int amount)
    {
        // Diminua a energia com base na quantidade fornecida
        currentEnergy -= amount;

        // Certifique-se de que a energia não seja menor que zero
        currentEnergy = Mathf.Clamp(currentEnergy, 0, maxEnergy);

        // Atualize o slider de energia
        UpdateEnergySlider();
    }

    private void UpdateEnergySlider()
    {
        // Atualize o valor do slider de energia com base na energia atual
        energySlider.value = (float)currentEnergy / maxEnergy;
    }
}


