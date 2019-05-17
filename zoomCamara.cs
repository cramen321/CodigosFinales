using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zoomCamara : MonoBehaviour {

    public float vel;
    public Transform zoom;
    private float distMov;

    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {

        distMov = vel * Time.deltaTime;

        if (Input.GetKey(KeyCode.UpArrow) && zoom.position.z<-2)
        {
            transform.Translate(Vector3.forward * distMov, Space.World);
            Debug.Log(zoom.position.z);
        }
        if (Input.GetKey(KeyCode.DownArrow) && zoom.position.z > -8)
        {
            transform.Translate(Vector3.back * distMov, Space.World);
            Debug.Log(zoom.position.z);
        }
    }
}
