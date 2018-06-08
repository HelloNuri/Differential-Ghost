using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Math : MonoBehaviour {

    public void difference(int[] coe,int[] power, int num_diff = 1)
    {
        //coe는 계수, power은 지수, num_diff는 얼마나 미분할 것인지
        //예: x^2+2x+1에서
        //coe = [1,2,1]
        //power = [2,1,0]
        for (int j = 1; j <= num_diff;j++ )
        {
            for (int i = 0; i < power.Length; i++)//미분한다.
            {
                coe[i] = coe[i] * power[i];//지수 * 계수
                if (power[i] != 0)
                    power[i]--;//계수-num_diff
            }
        }
    }
    public void createEquation()
    {

    }
}
