public class Math {

    public static void difference(Equation equ, int num_diff = 1)
    {
        //coe는 계수, power은 지수, num_diff는 얼마나 미분할 것인지
        //예: x^2+2x+1에서
        //coe = [1,2,1]
        //power = [2,1,0]
        int size = equ.coe.Length;
        for (int j = 1; j <= num_diff;j++ )
        {
            for (int i = 0; i < size; i++)//미분한다.
            {
                equ.coe[i] = equ.coe[i] * equ.power[i];//지수 * 계수
                if (equ.power[i] != 0)
                    equ.power[i]--;//계수-num_diff
            }
        }
    }
}
