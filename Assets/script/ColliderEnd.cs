using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderEnd : MonoBehaviour {

    public GameObject player;

    private Collider playerCollider;
    private DisapearFromTop[] wallScripts;

	// Use this for initialization
	void Start () {
        wallScripts = FindObjectsOfType<DisapearFromTop>();
        playerCollider = player.GetComponent<Collider>();

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider coll)
    {
        if(coll == playerCollider)
        {
            foreach(DisapearFromTop wall in wallScripts)
            {
                wall.dissolutionSpeed= 0.1F;
            }
        }
    }
}
