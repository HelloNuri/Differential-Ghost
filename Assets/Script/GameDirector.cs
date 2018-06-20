using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameDirector : MonoBehaviour {
	public Text RTS_equation; // 적의 체력 상태
    public GameObject textgameobject;
	int HP = 3; // 플레이어 생명력
	void Start () {
		RTS_equation = textgameobject.GetComponent<Text>();
        RTS_equation.text = EnemyControl.str;
	}
	
	void Update () {
        RTS_equation.text = EnemyControl.str;
	}

	public void damaged(){
		HP--;
	}

    public static void win()
    {

    }
	
}
