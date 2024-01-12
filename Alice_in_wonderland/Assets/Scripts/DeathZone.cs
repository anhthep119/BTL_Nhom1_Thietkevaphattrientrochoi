using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZone : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Damageable damage = collision.GetComponent<Damageable>();

        if(damage)
        {
            damage.IsAlive = false;
        }
    }
}
