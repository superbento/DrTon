﻿using SonicBloom.Koreo;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using static UnityEngine.UI.DefaultControls;

public class EventSubscriber : MonoBehaviour
{
    public delegate void KoreographyEventCallback(KoreographyEvent koreoEvent);
    public delegate void KoreographyEventCallbackWithTime(KoreographyEvent koreoEvent, int
    sampleTime, int sampleDelta, DeltaSlice deltaSlice);
    public GameObject cubeObject;
    [SerializeField]
    private DrumScore drumScore;
    public bool test=false;

    // Start is called before the first frame update
    void Start()
    {
        drumScore = GameObject.Find("drum1").GetComponent<DrumScore>();
        
        Koreographer.Instance.RegisterForEvents("longzhuTrack11", AnimationStart);
        Koreographer.Instance.RegisterForEvents("longzhuTrack12", scoreJugg);
    }

    // Update is called once per frame
    void Update()
    {
      
    }
    private void juggChange()
    {
        cubeObject.GetComponent<Renderer>().material.color = Color.black;
        Invoke("white", 0.4f);
        drumScore.juggScore = true;
    }

    private void white()
    {
        cubeObject.GetComponent<Renderer>().material.color = Color.white;
        drumScore.juggScore = false;
    }
    void scoreJugg(KoreographyEvent koreoEvent)
    {

        Invoke("juggChange",0.65f);

    }
    void AnimationStart(KoreographyEvent koreoEvent)
    {
        GameObject scoreAnimation = UnityEngine.Resources.Load("scoreAnimation") as GameObject;
        scoreAnimation = Instantiate(scoreAnimation);//实例化预制体
        scoreAnimation.transform.parent = this.gameObject.transform;//指定父物体
        scoreAnimation.transform.position = this.gameObject.transform.position;
    }

  
}
