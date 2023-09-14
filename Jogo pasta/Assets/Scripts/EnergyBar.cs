using UnityEngine;
using UnityEngine.UI;

public class EnergyBar : MonoBehaviour
{
    public Slider energySlider; // Referência ao componente Slider da barra de energia
    private int currentEnergy = 50;
    private int maxEnergy = 100; // Defina o valor máximo de energia aqui.
    private float energyDecreaseRate = 1.0f;
    private float energyDecreaseTimer = 1.0f;
    // Método para definir a energia na barra de energia
   
   private void Start ()
   {
    energySlider.value = 50f;
   }
   
    public void DefinirEnergia(int energia)
    {
        energySlider.value = energia; // Atualiza o valor do Slider para refletir a energia atual
    }

     private void UpdateEnergy()
    {
        // Diminui a energia com o tempo
        energyDecreaseTimer += Time.deltaTime;
        if (energyDecreaseTimer >= 1.0f) // Diminui a energia a cada segundo
        {
            energyDecreaseTimer = 1.0f;
            DecreaseEnergy(1); // Diminui a energia em 1 unidade a cada segundo
        }
    }
       public void RechargeEnergy(int amount)
    {
        // Recarrega a energia
        currentEnergy += amount;
        // Certifica-se de que a energia não exceda o valor máximo
        currentEnergy = Mathf.Clamp(currentEnergy, 0, maxEnergy);
        // Atualiza o valor do slider de energia
        energySlider.value = (float)currentEnergy / maxEnergy;
    }
       public void DecreaseEnergy(int amount)
    {
        // Diminui a energia
        currentEnergy -= amount;
        // Certifica-se de que a energia não fique abaixo de 0
        currentEnergy = Mathf.Max(currentEnergy, 0);
       // Atualiza o valor do slider de energia
        energySlider.value = (float)currentEnergy / 100f;
    }
}
