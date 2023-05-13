using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NavMeshPatrol : MonoBehaviour
{
    private UnityEngine.AI.NavMeshAgent agent;
    public Transform[] goal;
    public GameObject player;
    public float detectRadius;
    public bool playerDetected;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        agent.destination = goal[0].position;
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(player.transform.position, gameObject.transform.position) <= detectRadius)
        {
            playerDetected = true;
        } else
        {
            playerDetected = false;
        }


        if (agent.remainingDistance < 0.5f && playerDetected == false)
        {
            agent.destination = goal[Random.Range(0, goal.Length)].position;
        }
        else if (playerDetected == true)
        {
            agent.destination = player.transform.position;
        }
    }
}
