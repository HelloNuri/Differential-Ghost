using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameDirector : MonoBehaviour {
	public Text RTS_equation; // 적의 체력 상태
	public int HP = 3; // 플레이어 생명력
	void Start () {
		RTS_equation = GetComponent<Text>();

	}
	
	void Update () {
	}

	void RTS_enemy(){
		RTS_equation.text = GetComponent<EnemyControl>().str;

	}

	public void damaged(){
		HP--;
	}
	
}
