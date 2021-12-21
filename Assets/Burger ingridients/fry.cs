using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fry : MonoBehaviour
{
    public Texture myTexture;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
            {
                Material Fryed = new Material(Shader.Find("Standard"));
                Fryed.SetTexture("_MainTex", myTexture);
                GetComponent<MeshRenderer>().material = Fryed;
            }
    }
}
