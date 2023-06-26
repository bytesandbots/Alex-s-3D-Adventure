using UnityEngine;

public class wallclimbing : MonoBehaviour
{
    public bool canClimb;
    public Animator anm;
    public LayerMask ignoreLayers;
    public float climbSpeed = 2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position - new Vector3(0,0,-3), transform.forward, 3, ignoreLayers))
        {
            canClimb = true;

        }
        else {
            canClimb = false;
            anm.SetBool("climb", false);
        }
        if (canClimb)
        {
            if (Input.GetKey(KeyCode.W))
            {
                anm.SetBool("climb",true); 
                GetComponentInParent<playerMovement>().moveDirection.y = climbSpeed;
            }
            if (Input.GetKeyUp(KeyCode.W))
            {
                anm.SetBool("climb", false);
            }
        }
    }

}
