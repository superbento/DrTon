using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMove : MonoBehaviour
{
    Vector3 init;
    // Start is called before the first frame update
    void Start()
    {
        init = this.gameObject.transform.position;
        this.gameObject.GetComponent<Renderer>().material.color = Color.red;
    }

    // Update is called once per frame
    public void UpCube()
    {
        this.gameObject.transform.position = init;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
           
                this.gameObject.transform.Translate(Vector3.down * Time.deltaTime*3, Space.Self);
               
           
        }
       
    }
}
