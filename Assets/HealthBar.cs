using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Player player;

    [SerializeField] private Slider slider;

    private void Start()
    {
        slider.maxValue=player._maxHealth;
    }
    
    private void Update()
    {
        slider.value=player._health;
    }
}
