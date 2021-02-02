using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    public Portal destinationPortal;
    public Transform transform;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        //if (other.gameObject.tag == "Player")
        {
            Debug.Log("Entered");
            other.gameObject.transform.position = destinationPortal.transform.position + new Vector3(0, 0, 0);
            Vector3 direction = destinationPortal.transform.forward;
            direction = Quaternion.Euler(0, 90, 0) * direction;
            other.gameObject.GetComponent<Rigidbody>().velocity = direction * other.gameObject.GetComponent<Rigidbody>().velocity.magnitude;
            //other.gameObject.GetComponent<Player>().PortalJump(destinationPortal);,
        }
    }
}
