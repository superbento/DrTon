using SonicBloom.Koreo;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventSubscriber : MonoBehaviour
{
    public delegate void KoreographyEventCallback(KoreographyEvent koreoEvent);
    public delegate void KoreographyEventCallbackWithTime(KoreographyEvent koreoEvent, int
    sampleTime, int sampleDelta, DeltaSlice deltaSlice);
    public GameObject cubeObject;
    private bool test=false;
    // Start is called before the first frame update
    void Start()
    {
        Koreographer.Instance.RegisterForEvents("NewKoreographyTrack", FireEventDebugLog);

    }

    // Update is called once per frame
    void Update()
    {
       
    }
    private void white()
    {
        cubeObject.GetComponent<Renderer>().material.color = Color.white;
    }
    void FireEventDebugLog(KoreographyEvent koreoEvent)
    {
        Debug.Log("KoreographyEventFired.");
        cubeObject.GetComponent<Renderer>().material.color = Color.black;
        Invoke("white", 0.2f);


    }

}
