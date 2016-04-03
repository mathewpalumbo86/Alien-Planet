using UnityEngine;
using System.Collections;

public class PickupItem : MonoBehaviour {

    public PlayerControl m_PlayerControl;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            
            //test code
            m_PlayerControl.m_MovementSpeed ++;
            Debug.Log(m_PlayerControl.m_MovementSpeed);
            Destroy(gameObject);
        }
        
    }
}
