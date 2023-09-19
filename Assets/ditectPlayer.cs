using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ditectPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.tag);
        if (other.tag == "Player")
        {
            GetComponentInParent<enemyAi>().status = alertness.chase; 
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
            GetComponentInParent<enemyAi>().status = alertness.idle;
        }
    }
}
