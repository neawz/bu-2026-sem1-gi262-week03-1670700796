using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OOPEnemy : Character
{
    public void Start()
    {
        
    }

    public void Attack(OOPPlayer _player)
    {
        _player.TakeDamage(attackPoint);
    }
}
