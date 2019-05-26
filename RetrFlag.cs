using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class RetrFlag : MonoBehaviour
    
{
    void Start()
    {
        if (Tu_Boss.count1 == 1)
        {
            Attack_B.isClear1 = false;
            Jump_B.isClear2 = false;
            Guard_B.isClear3 = false;
            Move_B.isClear4 = false;
        }
    }
    public void toStringArgFunction(string x)
    {

        if((x.Equals("Attack_Select") && Attack_B.isClear1 == false) || (x.Equals("Jump_Select") && Jump_B.isClear2 == false) || (x.Equals("Guard_Select") && Guard_B.isClear3 == false) || (x.Equals("Move_Select") && Move_B.isClear4 == false))
            SceneManager.LoadScene(x);//Scene移行
    }
}