using UnityEngine;
using UnityEngine.UI;

public class EnergyBar : MonoBehaviour
{
    public Slider energySlider; // Referência ao Slider da barra de energia
    public int maxEnergy = 100; // Energia máxima do jogador
    private int currentEnergy;   // Energia atual do jogador

    private void Start()
    {
        currentEnergy = maxEnergy; // Inicializa a energia atual com o valor máximo
        UpdateEnergyBar();         // Atualiza a visualização da barra de energia
    }

    public void ConsumeEnergy(int amount)
    {
        currentEnergy -= amount; // Diminui a energia atual pelo valor passado
        currentEnergy = Mathf.Clamp(currentEnergy, 0, maxEnergy); // Garante que a energia não seja negativa ou maior que o máximo
        UpdateEnergyBar(); // Atualiza a visualização da barra de energia
    }

    public void RechargeEnergy(int amount)
    {
        currentEnergy += amount; // Aumenta a energia atual pelo valor passado
        currentEnergy = Mathf.Clamp(currentEnergy, 0, maxEnergy); // Garante que a energia não seja maior que o máximo
        UpdateEnergyBar(); // Atualiza a visualização da barra de energia
    }

    private void UpdateEnergyBar()
    {
        // Calcula a porcentagem de energia atual em relação à energia máxima
        float energyPercentage = (float)currentEnergy / maxEnergy;
        
        // Define o valor do Slider para refletir a porcentagem de energia atual
        energySlider.value = energyPercentage;
    }
}