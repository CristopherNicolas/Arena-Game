using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseComponent : MonoBehaviour
{
    public bool isPlayerBase;
    public float hp;

    private void Update()
    {
        if(isPlayerBase)
        {
            hp = GameManager.inst.hp;
        }
        else
        {
            hp = GameManager.inst.hpE;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag=="enemy")
        {
            GameManager.inst.hp -= 100;
            Destroy(collision.gameObject);
            
        }
        else if (collision.gameObject.tag=="hero")
        {
            GameManager.inst.hpE -= 100;
            Destroy(collision.gameObject);
        }
    }

}
