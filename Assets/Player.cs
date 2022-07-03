using System.Collections;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float Health { get; private set; }
    public float MaxHealth { get; private set; }

    public void HealPlayer(float heal)
    {
      Health+=heal;
      Health = Mathf.Clamp(Health, 0,MaxHealth);
    }

    public void DamagePlayer(float damage)
    {
      Health-=damage;
      Health = Mathf.Clamp(Health, 0,MaxHealth);
    }

    private void Awake()
    {
        Health = 80;
        MaxHealth = 100;
    }
}
