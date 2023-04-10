using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDamage : MonoBehaviour
{
   public float collisionDamage = 1;
   public string collisionTag;
   private void OnCollisionEnter2D(Collision2D other)
   {
        if (other.gameObject.tag == collisionTag)
        {
            Health hp = other.gameObject.GetComponent<Health>();
            hp.TakeDamage(collisionDamage);
        }
   }
}
