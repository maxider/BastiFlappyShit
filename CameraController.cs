using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public Transform Player;
    public float PlayerOffset = 150f;

    // Use this for initialization
    void Start()
    {
        transform.position = new Vector3(Player.transform.position.x + PlayerOffset, 0, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        if (Player) transform.position = new Vector3(Player.transform.position.x + PlayerOffset, 0, transform.position.z);
    }
}
