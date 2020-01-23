using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    // Start is called before the first frame update
    public int score;
    public int combo;
    [SerializeField]
    private Canvas canvas;
    Animator animator;
    public bool isOn=true;
    void Start()
    {
        animator = GameObject.Find("Victory").GetComponent<Animator>();
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        canvas.GetComponent<Text>().text = "Your score is: " + score+"\nCombo: "+combo;
        if (combo == 10|| combo == 20 || combo == 30 )
        {
            animator.SetBool("comboYes", true);
            Invoke("cancelComboBool",0.2f);
            if (isOn)
            {
                if (combo == 10)
                {
                    GameObject scoreAnimation = UnityEngine.Resources.Load("combo10") as GameObject;
                    scoreAnimation = Instantiate(scoreAnimation);//实例化预制体
                    scoreAnimation.transform.parent = this.gameObject.transform;//指定父物体
                }
                if (combo == 20)
                {
                    GameObject scoreAnimation = UnityEngine.Resources.Load("combo10") as GameObject;
                    scoreAnimation = Instantiate(scoreAnimation);//实例化预制体
                    scoreAnimation.transform.parent = this.gameObject.transform;//指定父物体
                }
                if (combo == 30)
                {
                    GameObject scoreAnimation = UnityEngine.Resources.Load("combo10") as GameObject;
                    scoreAnimation = Instantiate(scoreAnimation);//实例化预制体
                    scoreAnimation.transform.parent = this.gameObject.transform;//指定父物体
                }
                isOn = false;
                
            }
        }
        if (combo == 0)
        {
            animator.SetBool("comboYes", false);
            isOn = true;
        }
    }
    void cancelComboBool()
    {
        animator.SetBool("comboYes", false);
    }
}
