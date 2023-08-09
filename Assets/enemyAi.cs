using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class enemyAi : MonoBehaviour
{
    NavMeshAgent Agent;
    Transform Player;
    Animator Anm;                                    
    // Start is called before the first frame update
    void Start()
    {
        Agent = GetComponent<NavMeshAgent>();
        Anm = GetComponent<Animator>();
        Player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        Agent.SetDestination(Player.position);
        Anm.SetFloat("Speed", Agent.velocity.magnitude);
    }
}
