using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public float hp;
    public float maxhp;
    public void TakeDamage(float damage)
    {
        hp -= damage;
        if (hp <= 0)
        {
            Destroy(gameObject);
        }
    }
    public void HealHp(float heal)
    {
        hp += heal;
        if (hp > maxhp)
        {
            hp = maxhp;
        }
    }
    public float[] CheckHp()
    {
        float[] hps = {hp, maxhp};
        return hps;
    }
}
