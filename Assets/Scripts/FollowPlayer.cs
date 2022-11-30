using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;   //物体的位置
    public Vector3 offset;   //相机位置偏移量

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + offset;    //更新相机的位置
    }
}
