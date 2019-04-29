using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ManageBehaviorAI : MonoBehaviour
{
    public enum States
    {
        Patrol,
        Chase,
        Sound
    }

    public States state;
    public NavMeshAgent agent;
    public GameObject player;

    //Chase variables
    public float chaseSpeed;

    private void Awake()
    {
        if(agent == null)
        {
            GetComponent<NavMeshAgent>();
        }

    }

    void Start()
    {
        Patrolling();
    }

    // Update is called once per frame
    void Update()
    {

        if(!agent.pathPending && agent.remainingDistance < 5.0f)
        {
            switchState(States.Patrol);
        }

        if((player.transform.position - agent.transform.position).magnitude < 15.0f)
        {
            Debug.Log("Chase");
            switchState(States.Chase);
        }
    }


    void switchState(States state)
    {
        switch (state)
        {
            case States.Patrol:
                Debug.Log("Patrol");
                Patrolling();
                break;
            case States.Chase:
                Debug.Log("Chase");
                Chasing();
                break;
            case States.Sound:
                Debug.Log("Sound");
                break;
        }
    }

    //Patrol State Workflow
    public void Patrolling()
    {
        this.agent.GetComponent<Renderer>().material.color = new Color(0, 0, 0, 255);
        agent.destination = generateRandomPosition();

        if(Mathf.Approximately( this.gameObject.transform.position.x, agent.destination.x) && Mathf.Approximately(this.gameObject.transform.position.z, agent.destination.z))
        {
            Debug.Log("Arrived");
            return;
        }
    }
    public Vector3 generateRandomPosition()
    {
        Vector3 position = new Vector3(Random.Range(-24.0f, 24.0f), 0, Random.Range(-24.0f, 24.0f));
        return position;
        }

    //Chase State Workflow
    public void Chasing()
    {
        this.agent.destination = this.player.transform.position;
        this.agent.GetComponent<Renderer>().material.color= new Color(255, 0, 0, 255);

        if((player.transform.position - agent.transform.position).magnitude > 15.0f)
        {
            switchState(States.Patrol);
        }
    }

}
