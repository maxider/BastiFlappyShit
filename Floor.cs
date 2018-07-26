using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor : MonoBehaviour {

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.name.Equals("Player"))
        {
            Destroy(collision.gameObject);
        }
    }

}
