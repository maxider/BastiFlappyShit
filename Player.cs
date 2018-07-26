using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {

    public float Gravity = 1f;
    public float jumpForce = 5f;
    public float maxSpeed = 3f;
    public float ScrollSpeed = 5f;
    Vector2 velocity = new Vector2(0,0);

	// Use this for initialization
	void Start () {
        velocity.x = ScrollSpeed * Time.deltaTime;
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (velocity.y < 0) velocity.y = 0;
            velocity.y = jumpForce;
        }


	}

    void FixedUpdate()
    {
        setRotation();

        applyGravity(Time.deltaTime);

        transform.Translate(velocity);
    }

    void applyGravity(float deltaTime)
    {
        velocity.y += -Gravity * deltaTime;
    }

    void setRotation()
    {
        float angle = 0;
        if (velocity.y < 0)
        {
            angle = Mathf.Lerp(0, -90, -velocity.y / maxSpeed);
        }
        transform.GetChild(0).transform.rotation = Quaternion.Euler(0, 0, angle);
    }

    private void OnDestroy()
    {
        SceneManager.LoadScene("MainMenu");
    }
}


