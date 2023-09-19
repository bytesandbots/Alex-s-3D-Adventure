using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public enum alertness { idle,chase}
public class enemyAi : MonoBehaviour
{
    NavMeshAgent Agent;
    Transform Player;
    Animator Anm; 
    public alertness status = alertness.idle;
    // Start is called before the first frame update
    void Start()
    {
        Agent = GetComponent<NavMeshAgent>();
        Anm = GetComponent<Animator>();
        Player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {if(status == alertness.chase)
        {
            Agent.isStopped = false;
            Agent.SetDestination(Player.position);
            Anm.SetFloat("Speed", Agent.velocity.magnitude);
        }
    if(status == alertness.idle)
        {
            Agent.isStopped = true;
            Anm.SetFloat("Speed",0);
        }
        
    }
}
