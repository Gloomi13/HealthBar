using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Player player;
    [SerializeField] private Slider slider;
    
    public void ChangeHealthBar()
    {
        slider.value=player.Health;
    }

    private void Start()
    {
        slider.maxValue=player.MaxHealth;
    }
}
