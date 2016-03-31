using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {
    public float m_MovementSpeed;


    void Awake()
    {
        m_MovementSpeed = 4f;
    }
	void Update () 
    {
        Movement();
	}
    void Movement()
    {
        if (Input.GetAxis("Horizontal") > 0)
        {
            transform.Translate(Vector2.right * m_MovementSpeed * Time.deltaTime);
            transform.eulerAngles = new Vector2(0, 0);
        }

        if (Input.GetAxis("Horizontal") < 0)
        {
            transform.Translate(Vector2.right * m_MovementSpeed * Time.deltaTime);
            transform.eulerAngles = new Vector2(0, 180);
        }

    }
}
