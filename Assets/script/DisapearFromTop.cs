using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DisapearFromTop : MonoBehaviour {
	
	public float dissolutionSpeed;
    public bool isDissolutionStart;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (isDissolutionStart)
        {
            float curr = GetComponent<Renderer>().material.GetFloat("_Cutoff");
            if(curr < 1)
            {
                GetComponent<Renderer>().material.SetFloat("_Cutoff", curr + dissolutionSpeed);
            }
        }

    }
}
