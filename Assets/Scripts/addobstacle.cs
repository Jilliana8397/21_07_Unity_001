using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addobstacle : MonoBehaviour
{
    public GameObject obstacle;
    Vector3 pos = new Vector3(0, 1, 15);  //障碍初始位置
    Quaternion qua = new Quaternion(0, 0, 0, 0);  //roataion

    public float obDistance = 20f;   //障碍物间隔
    public int obNum = 1;    //每一行中障碍物的数量

    //在指定位置创建新物体
    void Start()
    {
        int seed = (int)System.DateTime.Now.Ticks;
        Random.InitState(seed);
        for (int i = 1; i < 18; i++)
        {
            switch (obNum)
            {
                case 1:
                    {
                        float x = Random.Range(-6.5f, 6.5f);
                        pos.Set(x, 1, i * obDistance);
                        GameObject obs = GameObject.Instantiate(obstacle, pos, qua) as GameObject;
                        break;
                    }
                case 2:
                    {
                        int num = Random.Range(0, 2);
                        float x0 = Random.Range(-6.5f, 6.5f);
                        float x1 = Random.Range(-6.5f, -1f);
                        float x2 = Random.Range(1f, 6.5f);
                        if (num == 1)
                        {
                            pos.Set(x1, 1, i * obDistance);
                            GameObject obs1 = GameObject.Instantiate(obstacle, pos, qua) as GameObject;
                            pos.Set(x2, 1, i * obDistance);
                            GameObject obs2 = GameObject.Instantiate(obstacle, pos, qua) as GameObject;
                        }
                        else
                        {
                            pos.Set(x0, 1, i * obDistance);
                            GameObject obs3 = GameObject.Instantiate(obstacle, pos, qua) as GameObject;
                        }
                        break;
                    }
                case 3:
                    {
                        float x1 = Random.Range(-6.5f, -1f);
                        float x2 = Random.Range(1f, 6.5f);
                        pos.Set(x1, 1, i * obDistance);
                        GameObject obs1 = GameObject.Instantiate(obstacle, pos, qua) as GameObject;
                        pos.Set(x2, 1, i * obDistance);
                        GameObject obs2 = GameObject.Instantiate(obstacle, pos, qua) as GameObject;
                        break;
                    }
            }
            
        }
        //GameObject obs = GameObject.Instantiate(obstacle, pos, qua) as GameObject;
    }
}
