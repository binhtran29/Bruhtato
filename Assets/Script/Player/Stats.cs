using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats : MonoBehaviour
{
    public int maxHp, hp, maxMp, mp, atk, luk;
    public float speed, atkSpeed, critRate, critDmg, CD;

    private void Start()
    {
        hp = maxHp;
        mp = maxMp;
    }

    private void Update()
    {
        Death();
    }

    void Death()
    {
        if(hp <= 0)
            Destroy(this.gameObject);
    }
}
