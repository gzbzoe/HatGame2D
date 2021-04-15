using UnityEngine;
using System.Collections;

public class game : MonoBehaviour {

	// Use this for initialization
	void Start () {
        InvokeRepeating("Production", 2, 2);
        InvokeRepeating("Production_Red", 5, 10); //反复调用方法的方法  字符串(方法名)  开始时间  间隔时间
        InvokeRepeating("Production_black", 8, 12);
    }
	
	// Update is called once per frame
	void Update () {
	
	}
    public GameObject ball;//球的预设物
    //public int score = 0;
    //生产球的方法
    public GameObject red_ball;
    public GameObject black_ball;
    public void Production()
    {
        //Instantiate()
        //Random.Range() //随机一个数 整数
        GameObject go = Instantiate(ball);
        go.transform.position = new Vector3(Random.Range(-7,7), 7,0); //确定位置
        Destroy(go, 4f);
        /*float hatloc_x = GameObject.Find("HatFrontSprite").GetComponent<Transform>().position.x;
        float hatloc_y = GameObject.Find("HatFrontSprite").GetComponent<Transform>().position.y;
        if (Mathf.Abs(go.transform.position.x-hatloc_x)<0.1&& Mathf.Abs(go.transform.position.y - hatloc_y) < 0.1)
        {
            score++;
            print(score);
        }
        print(score);*/
    }
    public void Production_Red()
    {
        //Instantiate()
        //Random.Range() //随机一个数 整数
        GameObject go = Instantiate(red_ball);
        go.transform.position = new Vector3(Random.Range(-7, 7), 7, 0); //确定位置
        Destroy(go, 4f);
        /*float hatloc_x = GameObject.Find("HatFrontSprite").GetComponent<Transform>().position.x;
        float hatloc_y = GameObject.Find("HatFrontSprite").GetComponent<Transform>().position.y;
        if (Mathf.Abs(go.transform.position.x-hatloc_x)<0.1&& Mathf.Abs(go.transform.position.y - hatloc_y) < 0.1)
        {
            score++;
            print(score);
        }
        print(score);*/
    }
    public void Production_black()
    {
        //Instantiate()
        //Random.Range() //随机一个数 整数
        GameObject go = Instantiate(black_ball);
        go.transform.position = new Vector3(Random.Range(-7, 7), 7, 0); //确定位置
        Destroy(go, 4f);
        /*float hatloc_x = GameObject.Find("HatFrontSprite").GetComponent<Transform>().position.x;
        float hatloc_y = GameObject.Find("HatFrontSprite").GetComponent<Transform>().position.y;
        if (Mathf.Abs(go.transform.position.x-hatloc_x)<0.1&& Mathf.Abs(go.transform.position.y - hatloc_y) < 0.1)
        {
            score++;
            print(score);
        }
        print(score);*/
    }
}
