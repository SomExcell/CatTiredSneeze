using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionHeal : MonoBehaviour
{
    public float collisionHeal = 1;
   public string collisionTag;
   private void OnCollisionEnter2D(Collision2D other)
   {
        if (other.gameObject.tag == collisionTag)
        {
            Health hp = other.gameObject.GetComponent<Health>();
            float[] hp_list = hp.CheckHp();
            if (hp_list[0] != hp_list[1])
            {
                hp.HealHp(collisionHeal);
                Destroy(gameObject);
            }
        }
   }
}
