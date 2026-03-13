using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//*****************************************
//创建人： Trigger 
//功能说明：事件函数（生命周期函数）
//***************************************** 
public class No2_EventFunction : MonoBehaviour
{
    public float attackValue=10000;
    public float currentHP;

    //对变量赋值的顺序（左边最先赋值，右边最后赋值，以此类推）：
    //变量声明并直接赋值>检视面板赋值>Awake>OnEnable>Start>外部赋值
    //我们一般对一个对象赋值，或者说想要从外部对一个对象的属性或者成员变量的值
    //进行更改的前提是，这个对象已经有了（意味着start方法已经调用），所以外部赋值
    //会后于Start方法进行调用

    private void Reset()
    {
        //1.调用情况
        //此函数只能在编辑器模式下（不运行）调用。
        //2.调用时间,次数与作用
        //当脚本第一次挂载到对象或者使用了Reset命令之后调用，
        //来初始化脚本的各个属性，Reset最常用于在检视面板中提供良好的默认值。
        //Debug.Log("调用了Reset方法");
        //Debug.Log("攻击值重置为默认值");
    }

    private void Awake()
    {
        //1.调用情况
        //a.在加载场景时初始化包含脚本的激活状态的GameObject时
        //b.GameObject从非激活转变为激活状态
        //c.在初始化使用Instantiate创建的GameObject之后
        //2.调用时间,次数与作用
        //在脚本实例的生存期内，Unity 仅调用 Awake 一次。脚本的生存期持续到包含它的场景被卸载为止。
        //Unity 调用每个GameObject的Awake的顺序是不确定的,人为干涉（即设计）来保证程序的正确性和稳定性
        // Awake 来代替构造函数进行初始化，在Unity这里，组件的初始化不使用构造函数 
        //Debug.Log("调用了Awake方法"); 
        //attackValue = 1;
    }

    private void OnEnable()
    {
        //1.调用情况
        //a.游戏物体被激活
        //b.脚本组件被激活
        //2.调用时间,次数与作用
        //每次游戏物体或者脚本被激活都会调用一次
        //重复赋值 变为初始状态
        //Debug.Log("调用了OnEnable方法");
        //currentHP = 100;
        //Debug.Log("当前血量为："+currentHP);
        //attackValue = 2;
    }

    void Start()
    {
        //1.调用情况
        //a.游戏物体被激活
        //b.脚本组件被激活
        //2.调用时间,次数与作用
        //在脚本实例激活时在第一帧的Update之前被调用
        //后于Awake执行,方便控制逻辑的前后调用顺序
        //Debug.Log("调用了Start方法");
        attackValue = 3;
    }

    void Update()
    {
        //1.调用情况
        //a.游戏物体被激活
        //b.脚本组件被激活
        //2.调用时间,次数与作用
        //每帧调用，是最常用函数,每秒调用60次左右(根据当前电脑的的性能和状态)
        //实时更新数据，接受输入数据
        //Debug.Log("调用了Update方法");
    }

    private void LateUpdate()
    {
        //1.调用情况
        //a.游戏物体被激活
        //b.脚本组件被激活
        //2.调用时间,次数与作用
        //LateUpdate在调用所有Update函数后调用,每秒调用60次左右,安排脚本的执行顺序
        //比如摄像机跟随，一定是人物先移动了，摄像机才会跟随
        //Debug.Log("调用了LateUpdate方法");
    }

    private void OnDisable()
    {
        //1.调用情况
        //a.游戏物体被禁用
        //b.脚本组件被禁用
        //c.游戏物体被销毁
        //2.调用时间,次数与作用
        //满足调用情况时即时调用一次，用于一些对象的状态重置，资源回收与清理
        Debug.Log("调用了OnDisable方法");
    }

    void OnApplicatoinQuit()
    {
        //1.调用情况
        //a.在程序退出之前所有的游戏对象都会调用这个函数
        //b.在编辑器中会在用户终止播放模式时调用
        //c.在网页视图关闭时调用
        //2.调用时间,次数与作用
        //满足调用情况时即时调用一次，用于处理一些游戏退出后的逻辑
        Debug.Log("OnApplicationQuit");
    }


    void OnDestroy()
    {
        //1.调用情况
        //a.场景或游戏结束
        //b.停止播放模式将终止应用程序
        //c.在网页视图关闭时调用
        //d.当前脚本被移除
        //e.当前脚本挂载到的游戏物体被删除
        //2.调用时间,次数与作用
        //满足调用情况时即时调用一次，用于一些游戏物体的销毁
        Debug.Log("OnDestroy");
    }
}
