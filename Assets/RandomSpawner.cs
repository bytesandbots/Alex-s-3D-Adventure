using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    public GameObject Skelly;
    public void RandomSpawn() 
    {
        StartCoroutine(waitspawn());
    }
    Vector3 GetRandomLocation() { 
    int numchild = transform.childCount;
        int rchild  = Random.Range(0, numchild -1);
        return transform.GetChild(rchild).position;

    }

    IEnumerator waitspawn() {
        float rtime = Random.Range(10, 120);
        yield return new WaitForSeconds(rtime);
        Vector3 Rplace = GetRandomLocation();
        Instantiate(Skelly, Rplace, Quaternion.identity);
    }
    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
