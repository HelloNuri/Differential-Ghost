using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameDirector : MonoBehaviour {
	public Text RTS_equation;
	void Start () {
		RTS_equation = GetComponent<Text>();

	}
	
	void Update () {
		RTS_equation.text = GetComponent<EnemyControl>().str;
	}

	
}
