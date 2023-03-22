using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movecubehere : MonoBehaviour
{

   public Rigidbody Rigidbody;


    // Start is called before the first frame update
    void Start()
    {
        Rigidbody = GetComponent<Rigidbody>();
   
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Rigidbody.AddForce(Vector3.up);
            Rigidbody.AddForce(Vector3.up * 20,ForceMode.Impulse);
        }
   
        }
    
}
