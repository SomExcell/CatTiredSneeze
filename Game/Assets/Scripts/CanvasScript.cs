using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasScript : MonoBehaviour
{
    public GameObject player;
    public GameObject heart; 
    private float playerHp;
    private float playerMaxHp;
    void Update()
    {
        Health hp = player.GetComponent<Health>();
        float[] hp_list = hp.CheckHp();
        if (playerHp != hp_list[0] || playerMaxHp != hp_list[1])
        {
            playerHp = hp_list[0];
            playerMaxHp = hp_list[1];
        }
    }
}
