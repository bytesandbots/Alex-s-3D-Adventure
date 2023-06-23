using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallclimbing : MonoBehaviour
{
    public bool canClimb;
    public Animator anm;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (canClimb)
        {
            if (Input.GetKey(KeyCode.F))
            {
                anm.SetBool("climb",true); 
            }
            if (Input.GetKeyUp(KeyCode.F))
            {
                anm.SetBool("climb", false);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        canClimb = true;
    }
    private void OnTriggerExit(Collider other)
    {
        canClimb  = false;
    }
}
