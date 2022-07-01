using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour 
{
  [SerializeField] private Player player;

   private void OnButtonClick()
    {
      int damage =-10;
      player.DamagePlayer(damage);
    }
}
