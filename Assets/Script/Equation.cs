using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Equation : MonoBehaviour {
    public int[] coe;
    public int[] power;

    public void makePower(int[] power){
        // 지수가 2,1,0과 같은 형식일 때 자동으로 초기화한다.
        for(int i=0;i<power.Length;i++){
            power[i] = power.Length - 1 - i;
        }
    }

    public void init(int size){
        coe = new int[size];
        power = new int[size];
        makePower(power);
    }
}
