using System.Collections;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private HealthBar healthBar;

    public float Health { get; private set; }
    public float MaxHealth { get; private set; }

    public void DoHealPlayer(float Heal)
    {
      Health+=Heal;
      Health = Mathf.Clamp(Health, 0,MaxHealth);
      healthBar.ChangeHealthBar(Heal);
    }

    public void DoDamagePlayer(float Damage)
    {
      Health-=Damage;
      Health = Mathf.Clamp(Health, 0,MaxHealth);
      healthBar.ChangeHealthBar(-Damage);
    }

    private void Awake()
    {
        Health = 80;
        MaxHealth = 100;
    }
}
