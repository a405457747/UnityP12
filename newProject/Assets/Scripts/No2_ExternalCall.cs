using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//*****************************************
//创建人： Trigger 
//功能说明：用于测试外部调用或者外部复制时的顺序
//***************************************** 
public class No2_ExternalCall : MonoBehaviour
{
    public No2_EventFunction api;

    void Start()
    {
        //通过外部获取组件引用对变量进行赋值
        api.attackValue = -1;
    }

    void Update()
    {

    } 
}
