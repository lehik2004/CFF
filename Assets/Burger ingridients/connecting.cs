using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class connecting : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollision()
    {
        if(GameObject.FindGameObjectWithTag("ingridient"))
        {
            //GameObject.GetComponent<FixedJoint>.connectedBody = GameObject.FindGameObjectWithTag("ingridient");
        }
    }
}
