using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : MonoBehaviour
{
    Animator anim;
    public GameObject player;

    public GameObject GetPlayer()
    {
        return player;
    }

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>(); 
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetFloat("Distance", Vector3.Distance(transform.position, player.transform.position));
    }
}
