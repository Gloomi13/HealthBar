using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heal : MonoBehaviour
{
   [SerializeField] private Player player;

   private void OnButtonClick()
    {
      int heal =10;
      player.HealPlayer(heal);
    }
}
