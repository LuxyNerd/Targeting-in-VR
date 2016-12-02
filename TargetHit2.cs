using UnityEngine;
using System.Collections;

public class TargetHit2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire1"))
        {
          GetComponent<Renderer>().material.color = Color.green;
            // transform.Rotate(transform.rotation.eulerAngles + new Vector3(0f, 0.1f, 0f));//soll grün werden
        }
    }
}
