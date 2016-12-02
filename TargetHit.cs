using UnityEngine;
using System.Collections;

public class TargetHit : MonoBehaviour {

	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire1"))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit = new RaycastHit();
            if (Physics.Raycast(ray, out hit))
            {

               // hit.collider.gameObject.name;
                Debug.Log(hit.collider.gameObject.name);
                Debug.DrawLine(ray.origin, hit.point, Color.red);

               
                //GetComponent<Renderer>().material.color = Color.green;
            }
           // transform.Rotate(transform.rotation.eulerAngles + new Vector3(0f, 0.1f, 0f));//soll grün werden
           
        }
	}
}
