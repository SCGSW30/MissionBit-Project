//made by Calvin but irrelevant
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Gamekit2D
{
    public class WeaponPickUp : MonoBehaviour
    {
        internal void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject == PlayerCharacter.PlayerInstance.gameObject)
            {
                Damageable damageable = PlayerCharacter.PlayerInstance.damageable;
                damageable.SetHealth(damageable.CurrentHealth-1);
                PlayerInput.Instance.EnableRangedAttacking();
            }
        }
    }
}