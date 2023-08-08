using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attack : MonoBehaviour
{
    public Animator anm;
    public Transform rightHand;
    public Transform sword;
    public Transform hip;
    private bool animates;
    public GameObject attack1;
    private bool magicAttack;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q) && !magicAttack)
        {
            magicAttack = true;
            anm.SetTrigger("using magic");
            StartCoroutine(magicDelay());
           
        }
        if (Input.GetKeyDown(KeyCode.E)){
            sword.SetParent(rightHand);
            sword.localPosition = new Vector3(1.018f, 0.536f, 1.173f);
            sword.localEulerAngles = new Vector3(-238.9f, -125.252f, -138.814f);
            anm.SetTrigger("take out sword");
        }
        if (Input.GetKeyDown(KeyCode.R)&& !animates) {
            StartCoroutine(animationDelay());
        }
    }
    IEnumerator magicDelay()
    {


        yield return new WaitForSeconds(1.2f);
        GameObject clone = Instantiate(attack1, transform.position + transform.TransformDirection(Vector3.forward * 5), Quaternion.identity);
        Destroy(clone, 4);
        yield return new WaitForSeconds(4);
        magicAttack = false;
    }
        IEnumerator animationDelay()
    { 

        anm.SetTrigger("Sheathing Sword");
        animates = true;
        yield return new WaitForSeconds(1.2f);
        animates = false;
        sword.SetParent(hip);
        sword.localPosition = new Vector3(1.062037f, 0.01806676f, 0.8798308f);
        sword.localEulerAngles = new Vector3(-87.639f, 12.443f, -106.581f);
        
    }
}
