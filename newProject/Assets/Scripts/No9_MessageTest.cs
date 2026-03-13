using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//*****************************************
//创建人： Trigger 
//功能说明：消息发送者身上的其他组件
//***************************************** 
public class No9_MessageTest : MonoBehaviour
{
    public void GetMsg()
    {
        print("测试对象身上的其他组件接收到消息了");
    }

    public void GetSrcMsg(string str)
    {
        print("测试对象身上的其他组件接收到的消息为：" + str);
    }
}
