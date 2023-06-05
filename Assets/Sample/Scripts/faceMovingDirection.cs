using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class faceMovingDirection : MonoBehaviour
{
    public float lerpSpeed = 500.0f;
    public Transform FixedView;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        if (h > 0) {
            Vector3 offset = FixedView.eulerAngles + new Vector3(0, 90, 0);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(offset) , lerpSpeed * Time.deltaTime);
        }
        if (h < 0)
        {
            Vector3 offset = FixedView.eulerAngles + new Vector3(0, -90, 0);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(offset), lerpSpeed * Time.deltaTime);
        }
        if (v > 0)
        {
            Vector3 offset = FixedView.eulerAngles + new Vector3(0, 0, 0);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(offset), lerpSpeed * Time.deltaTime);
        }
        if (v < 0)
        {
            Vector3 offset = FixedView.eulerAngles + new Vector3(0, 180, 0);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(offset), lerpSpeed * Time.deltaTime);
        }
    }
}
