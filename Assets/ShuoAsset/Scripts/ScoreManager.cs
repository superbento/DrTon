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
    public bool isTenOn=false;
    public bool isTwentyOn = false;
    public bool isThirtyOn = false;
    void Start()
    {
        animator = GameObject.Find("Victory").GetComponent<Animator>();
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        canvas.GetComponent<Text>().text = "Your score is: " + score+"\nCombo: "+combo;
        if (combo == 10)
        {
            if (!isTenOn)
            {
                animator.SetBool("comboYes", true);
                Invoke("cancelComboBool", 2f);

                GameObject scoreAnimation = UnityEngine.Resources.Load("combo10") as GameObject;
                scoreAnimation = Instantiate(scoreAnimation);//实例化预制体
                scoreAnimation.transform.parent = this.gameObject.transform;//指定父物体
                isTenOn = true;

            }
            
        }
        if (combo == 20)
        {
            if (!isTwentyOn)
            {
                animator.SetBool("comboYes", true);
                Invoke("cancelComboBool", 2f);

                GameObject scoreAnimation = UnityEngine.Resources.Load("combo20") as GameObject;
                scoreAnimation = Instantiate(scoreAnimation);//实例化预制体
                scoreAnimation.transform.parent = this.gameObject.transform;//指定父物体
                isTwentyOn = true;

            }

        }
        if (combo == 30)
        {
            if (!isThirtyOn)
            {
                animator.SetBool("comboYes", true);
                Invoke("cancelComboBool", 2f);

                GameObject scoreAnimation = UnityEngine.Resources.Load("combo30") as GameObject;
                scoreAnimation = Instantiate(scoreAnimation);//实例化预制体
                scoreAnimation.transform.parent = this.gameObject.transform;//指定父物体
                isThirtyOn = true;

            }

        }
        if (combo == 0)
        {
            isTenOn = false;
            isTwentyOn = false;
            isThirtyOn = false;
        }


    }
    void cancelComboBool()
    {
        animator.SetBool("comboYes", false);
    }
}
