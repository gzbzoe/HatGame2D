using UnityEngine;
using System.Collections;//引用

public class hat_move : MonoBehaviour {          //不继承MonoBehaviour 无法连入unity

    //修饰符 + 类型 +名字；
    public float speed = 10;
	// Use this for initialization
                                                    //最开始执行 只能执行一次  变量赋值可放入其中
	void Start () {
        print("Hello World !");
	}
	
	// Update is called once per frame
                                                        // 反复执行 每一帧 unity自带 跟电脑性能有关
	void Update () {

        
        //Input.GetKey() 获取键盘的方法
        if (Input.GetKey(KeyCode.A))
        {

            //帽子向左移动 -x
            //this.GetComponent<Transform>().position  访问组件
            /*transform.position+= new Vector3(-1, 0, 0)*Time.deltaTime*speed;
            transform.position += Vector3.left * Time.deltaTime * speed;  节省性能*/
            transform.Translate(Vector3.left * Time.deltaTime * speed); //平移方法 参数为方向
            if(transform.position.x<-7.5)
            {
                transform.position = new Vector3(-7.5f, -2.46f, 0);
            }
        }
        if (Input.GetKey(KeyCode.D))
        {
            //帽子向左移动 x
            //this.GetComponent<Transform>().position
           /* transform.position += new Vector3(1, 0, 0) * Time.deltaTime * speed;
            transform.position += Vector3.right * Time.deltaTime * speed;*/
            transform.Translate(Vector3.right * Time.deltaTime * speed); //平移方法 参数为方向
            if (transform.position.x > 7.5)
            {
                transform.position = new Vector3(7.5f, -2.46f, 0);
            }
        }
        /*if (Input.GetKey(KeyCode.W))
         {
             //帽子向左移动 x
             //this.GetComponent<Transform>().position
             transform.position += new Vector3(0, 1, 0) * Time.deltaTime * speed;


         }*/
        /* if (Input.GetKey(KeyCode.S))
        {
            //帽子向上移动 x
            //this.GetComponent<Transform>().position
            transform.position += new Vector3(0, -1, 0) * Time.deltaTime * speed;
        }*/
        if (Input.GetKey(KeyCode.Z))
        {
            //帽子向下移动 x
            //this.GetComponent<Transform>().position
            transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
            
        }
        if (Input.GetKey(KeyCode.C))
        {
            //帽子向下移动 x
            //this.GetComponent<Transform>().position
            transform.localScale -= new Vector3(0.1f, 0.1f, 0.1f);

        }
        //Camera.main.ScreenToWorldPoint 屏幕坐标转世界坐标
        //Input.mousePosition 获取鼠标坐标
        //Input.GetMouseButton(0) 按下鼠标左键 1鼠标右键  2鼠标中键
        // Input.GetButtonDown()按下 Input.GetButtonUp() 抬起  执行一次
        if (Camera.main.ScreenToWorldPoint(Input.mousePosition).x < 0 && Input.GetMouseButton(0))
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
            if (transform.position.x < -7.5)
            {
                transform.position = new Vector3(-7.5f, -2.46f, 0);
            }
        }
        if (Camera.main.ScreenToWorldPoint(Input.mousePosition).x >= 0 && Input.GetMouseButton(0))
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed);
            if (transform.position.x > 7.5)
            {
                transform.position = new Vector3(7.5f, -2.46f, 0);
            }
        }

    }

}
