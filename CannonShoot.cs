using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonShoot : MonoBehaviour
{
    public GameObject foxBullet;
    public float speed = 1000f;
    
    // Start is called before the first frame update
    void Start()
    {

    }
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject cloneFox = Instantiate(foxBullet, transform.position, transform.rotation);
            Rigidbody cloneFoxRB = cloneFox.GetComponent<Rigidbody>();
            
            cloneFoxRB.AddForce(Vector3.forward * speed);
            
            Destroy(cloneFox, 2f);
        }

    }
}


