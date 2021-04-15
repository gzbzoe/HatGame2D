using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class button : MonoBehaviour {

	// Use this for initialization
    void Awake()   //程序最先执行的方法 且执行一次
    {
        Time.timeScale = 0;
    }
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public GameObject startButton;
    public GameObject stopButton;
    public void OnClickStart()   //开始
    {
        //Time.timeScale = 0;  游戏静止
        //开始游戏
        //开始按钮隐藏 停止按钮显示

        Time.timeScale = 1;
        startButton.SetActive(false); //一个物体隐藏
        stopButton.SetActive(true);  //一个物体显示

    }
    public void OnClickStop()   //暂停
    {
        //暂停游戏
        //暂停按钮隐藏 开始按钮显示
        Time.timeScale = 0;
        stopButton.SetActive(false);  
        startButton.SetActive(true); 
    }
}
