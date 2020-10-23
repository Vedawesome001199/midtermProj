using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DIst : MonoBehaviour
{
	public Transform displacement;
	    // Update is called once per frame
    void Update()
    {
    	    float dist = Vector3.Distance(displacement.position, transform.position);
            Debug.Log(dist);

    }
}
