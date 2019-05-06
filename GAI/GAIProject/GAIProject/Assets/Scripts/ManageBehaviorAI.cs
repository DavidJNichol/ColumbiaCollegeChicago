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
        Sound,
        Touch
    }

    public States state;
    public NavMeshAgent agent;
    public GameObject player;
    public GameObject soundCube;
    public AudioSource ad;

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
        this.soundCube.transform.position = generateRandomPosition();
    }

    // Update is called once per frame
    void Update()
    {

        if(!agent.pathPending && agent.remainingDistance < 5.0f)
        {
            switchState(States.Patrol);
        }

        if((player.transform.position - agent.transform.position).magnitude < 10.0f)
        {
            switchState(States.Chase);
        }

        if ((player.transform.position - soundCube.transform.position).magnitude < 2.0f)
        {
            switchState(States.Sound);
        }

        if((player.transform.position - agent.transform.position).magnitude < 1.0f)
        {
            switchState(States.Touch);
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
                Sounding();
                break;
            case States.Touch:
                Debug.Log("Touch");
                Touching();
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
        Vector3 position = new Vector3(Random.Range(-24.0f, 24.0f), 3, Random.Range(-24.0f, 24.0f));
        return position;
    }

    //Chase State Workflow
    public void Chasing()
    {
        this.agent.destination = this.player.transform.position;
        this.agent.GetComponent<Renderer>().material.color= new Color(255, 0, 0, 255);
    }

    public void Sounding()
    {
        this.soundCube.transform.position = generateRandomPosition();
        ad.Play();
        switchState(States.Chase);        
    }

    public void Touching()
    {
        Destroy(player);
    }
}
