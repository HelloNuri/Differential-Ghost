using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControl : MonoBehaviour {

	public string str = "";

	float span = 2.0f; // 2초마다 공격
	float delta = 0f;
		Equation enemy = new Equation();
		GameObject gameDirector;
	// Use this for initialization
	void Start () {
		gameDirector = GetComponent<GameDirector>();
		enemy.init(3);
		enemy.coe[0] = 1;
		enemy.coe[1] = 2;
		enemy.coe[2] = 3;
	}
	
	// Update is called once per frame
	void Update () {
		if(delta>span){
			damaged();
		}
		delta += Time.deltaTime;
	}

	void Onclick(){
		Math.difference(enemy);
		for(int i = 0;i<enemy.coe.Length;i++){
			str+= enemy.coe[i] + "x" + "^" + enemy.power[i];
		}
	}
}
