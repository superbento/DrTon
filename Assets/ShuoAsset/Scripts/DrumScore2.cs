using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrumScore2 : MonoBehaviour
{
    public bool juggScore = false;
    ScoreManager scoreManager;

    void OnCollisionEnter(Collision collision)
    {
       
            if (juggScore)
            {
                GameObject HitAnimation = UnityEngine.Resources.Load("HitAnimations") as GameObject;
                HitAnimation = Instantiate(HitAnimation);//实例化预制体
                HitAnimation.transform.parent = this.gameObject.transform;//指定父物体
                HitAnimation.transform.position = this.gameObject.transform.position - new Vector3(0.397f, -0.449f, 0.406f);
            scoreManager.score += 100;
                scoreManager.combo++;



            }
            else
            {
                scoreManager.score -= 50;
                scoreManager.combo = 0;
            }
            
        
    }

    // 碰撞结束
    void OnCollisionExit(Collision collision)
    {

    }

    // 碰撞持续中
    void OnCollisionStay(Collision collision)
    {

    }


    // Start is called before the first frame update
    void Start()
    {
    
        scoreManager = GameObject.Find("GameManager").GetComponent<ScoreManager>();
 
    }

    // Update is called once per frame
    void Update()
    {

    }
}
