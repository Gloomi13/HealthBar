using System.Collections;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private HealthBar healthBar;
    public float Health { get; private set; }

    public float MaxHealth { get; private set; }

    public void ChangeHealPlayer(float number)
    {
      StartCoroutine(ChangeHealth(number));
    }

    private void Awake()
    {
        Health = 80;
        MaxHealth = 100;
        healthBar.ChangeHealthBar();
    }

    private IEnumerator ChangeHealth(float number)
    {
        var waitForSeconds = new WaitForSeconds(0.05f);
        int speedChange = 10;

        for (int i = 0; i < speedChange; i++)
        {
            Health = Mathf.MoveTowards(Health, MaxHealth, number / speedChange);
            Health = Mathf.Clamp(Health, 0,MaxHealth);
            healthBar.ChangeHealthBar();

            yield return waitForSeconds;
        }
    }
}
