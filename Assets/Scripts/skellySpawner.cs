using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class skellySpawner : MonoBehaviour
{
    //Randomize spawn, n amount
    //Spawn grounded position
    // Go To Player
    // Add timer after a minute make spawn

    public float spawnTimer = 0f;
    public GameObject skeletons;

    public Transform[] spawns;

    public float timer;
    public Transform player;

    //NavMeshAgent agent;

    void Start()
    {
       

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer > spawnTimer) 
        {
            timer = 0f;
            GameObject skellySpawned = Instantiate(skeletons,spawns[Random.Range(0,spawns.Length)].position,Quaternion.identity);
          
           // timer= 0f;
        }   
    }
}
