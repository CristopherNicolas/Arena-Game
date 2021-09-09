using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruirAlColisionar : MonoBehaviour
{
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag=="enemy"||collision.gameObject.tag=="hero")
        {
           Destroy(collision.gameObject);
        }
    }
}
