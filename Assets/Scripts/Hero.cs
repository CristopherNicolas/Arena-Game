using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour
{ 
    public TYPE tipoActual;
     public int def, atk, hp, vel;
    public enum TYPE
    {
        espada,caster,alchemist,shield
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "enemy")
        {
            collision.gameObject.GetComponent<Enemy>().hp -= atk;
        }
    }
    private void Awake()
    {
      switch (tipoActual)
        {
            case TYPE.espada:
                def = 100; atk = 250; hp = 500; vel = 5;
                break;
            case TYPE.caster:
                def = 50; atk = 300; hp = 500; vel = 4;
                break;
            case TYPE.alchemist:
                def = 100; atk = 300; hp = 600; vel = 6;
                break;
            case TYPE.shield:
                def = 300; atk = 100; hp = 600; vel = 3;
                break;
            default:
                Debug.Log("Error en asignar tipos");
                break;
        }
    }
    private void Update()
    {
      transform.Translate(Vector2.right * vel * Time.deltaTime);
        transform.position= new Vector3(transform.position.x,0);
        if (hp<=0)
        {
            Destroy(gameObject);
        }
    }
}
