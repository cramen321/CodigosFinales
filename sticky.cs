using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sticky : MonoBehaviour
{
    GameObject cerca;
    public admin gm; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnTriggerEnter(Collider hit)
    {
        Rigidbody rig = hit.attachedRigidbody;
        gm.posX1.Add((int)rig.transform.position.x);
        gm.posY1.Add((int)rig.transform.position.y);
        gm.posZ1.Add((int)rig.transform.position.z);

        if (hit.gameObject.tag == "Cerca")
        {
            rig.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ | RigidbodyConstraints.FreezeRotationY;
        }

        for(int i =0; i < gm.posX1.Count; i++) {
            Debug.Log(gm.posX1[i] + ", " + gm.posY1[i] + ", " + gm.posZ1[i]);
        }
    }

}
