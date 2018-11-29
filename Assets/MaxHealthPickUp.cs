//made by Calvin

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Gamekit2D
{
    public class MaxHealthPickUp : MonoBehaviour
    {
        internal void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject == PlayerCharacter.PlayerInstance.gameObject)
            {
                Damageable damageable = PlayerCharacter.PlayerInstance.damageable;
                damageable.SetHealth(damageable.startingHealth + 1);
            }
        }
    }
}