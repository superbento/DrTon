using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class opining : MonoBehaviour
{
    public GameObject obj1;
    public GameObject obj2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider collider)
    {
        obj1.SetActive(true);
        obj2.SetActive(false);
        print(collider.name);
    }
}
