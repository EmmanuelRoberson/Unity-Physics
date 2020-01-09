using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonBall : MonoBehaviour
{
    //custom
   public GameObject target;
    
    public float forceOnFire = 300;

    private bool fire = false;
    private bool canFire = true;

    private Rigidbody rigidbody = null;
    
    // Start is called before the first frame update
    void Start()
    {
        //custom
        transform.LookAt(target.transform);
    }

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
        rigidbody.isKinematic = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown && canFire)
        {
            rigidbody.isKinematic = false;
            rigidbody.AddForce(transform.forward * forceOnFire);
            canFire = false;
        }
    }
}
