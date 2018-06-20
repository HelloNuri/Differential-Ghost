using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControl : MonoBehaviour {

    public void makeStr()
    {
        for (int i = 0; i < enemy.coe.Length; i++)
        {
            if (enemy.coe[i] <= 1)
            {
                if (enemy.coe[i] == 0)
                //계수가 0일 때
                {
                    continue;
                }
                else if (enemy.coe[i] == 1)
                //계수가 1일 때
                {
                    if (enemy.power[i] <= 1)
                    {
                        if (enemy.power[i] == 0)
                        //계수가 1이고 지수가 0일 때
                        {
                            str += "+" + 1;
                        }
                        else if (enemy.power[i] == 1)
                        //계수가 1이고 지수가 1일 때
                        {
                            str += "+" + "x";
                        }
                        else
                        //계수가 1이고 지수가 2 이상일 때
                        {
                            str += "+" + "x" + "^" + enemy.power[i];
                        }
                    }
                }
            }
            //위는 계수가 0이거나 1일 때를 상정
            //아래는 계수가 2 이상일 때
            else if (enemy.power[i] <= 1)
            {
                if (enemy.power[i] == 0)
                //계수가 2 이상이고 지수가 0일 때 
                {
                    str += "+" + enemy.coe[i];
                }
                else if (enemy.power[i] == 1)
                //계수가 2 이상이고 지수가 1일 때
                {
                    str += "+" + enemy.coe[i] + "x";
                }
            }
            else
            //계수가 2 이상이고 지수가 2 이상일 때
            {
                str += "+" + enemy.coe[i] + "x" + "^" + enemy.power[i];
            }
        }
        if (str == "")
        {
            str = "0";
            GameDirector.win();
        }
    }
    
    public static string str = "";

	float span = 2.0f; // 2초마다 공격
	float delta = 0f;
	Equation enemy = new Equation();
	GameObject gameDirector;
	// Use this for initialization
	void Start () {
		enemy.init(5);
		enemy.coe[0] = 1;
		enemy.coe[1] = 2;
		enemy.coe[2] = 3;
        enemy.coe[3] = 4;
        enemy.coe[4] = 5;
        makeStr();
	}
	
	// Update is called once per frame
	void Update () {
        //if(delta>span){
        //    gameDirector.damaged();
        //}
        //delta += Time.deltaTime;
	}

	void OnMouseUp(){
        str = "";
		Math.difference(enemy);
        makeStr();
        Debug.Log("1");
	}
}
