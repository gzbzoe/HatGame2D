using UnityEngine;
using System.Collections;
using UnityEngine.UI;    //使用UI时必须先引用UI命名空间
public class ball : MonoBehaviour {

    //得分
    public int score = 0;
    public Text scoreText;
    public Text braveText;
    
    /*
     * 球消失：
     * 1.落到地上4秒后消失
     * 2.落入帽中立马消失
     * 
     */
    // Use this for initialization
   
	void Start () {
        // Destroy(this.gameObject,3f);
        /*scoreText = GameObject.Find("Canvas/score").GetComponent<Text>();*/ //变量赋值
        scoreText.text = "分数:" + score.ToString(); //赋初值 
	}
	
	// Update is called once per frame
	void Update () {
        scoreText.text = "分数:" + score.ToString();
    }

    //碰撞器：开始 停留 离开     方法里不能写方法
    /*private void OnCollisionEnter(Collision col)       //3D
    {

    }
    private void OnCollisionStay(Collision col)
    {

    }
    private void OnCollisionExit(Collision col)
    {

    }*/

    
   /* private void OnCollisionEnter2D(Collision2D col)
    {
        print(col.gameObject.name);  //打印碰撞物体名字
        print("Enter");
        if(col.gameObject.tag=="hat")
        {
            Destroy(this.gameObject);
           
        }
        
       
    }*/
    /*private void OnCollisionStay2D(Collision2D col)
    {
        print("Stay");
    }
    private void OnCollisionExit2D(Collision2D col)
    {
        print("Exit");
    }*/

    //触发器：开始 停留 离开  参数为球
    //条件：碰撞的物体都有碰撞盒，运动物体要有刚体  至少一个碰撞盒要勾选is trigger 属性
    private void OnTriggerEnter2D(Collider2D col)
    {
        
        print(col.gameObject.name);  //打印碰撞物体名字
        print("Enter");
        if (col.gameObject.tag == "Ball")
        {
            Destroy(col.gameObject);
            CreateEffect(col.transform.position);
            //加分
            score+=10;
            Debug.Log(score);
            if(score>50)
            {
                
            }
        }
        if (col.gameObject.tag == "Red_Ball")
        {
            Destroy(col.gameObject);
            CreateEffect(col.transform.position);
            
            score += 20;
            Debug.Log(score);
        }
        if (col.gameObject.tag == "Black_Ball")
        {
            Destroy(col.gameObject);
            CreateEffect(col.transform.position);
            transform.parent.localScale = new Vector3(2.0f, 2.0f, 2.0f);
            //开启协程
            StartCoroutine(back());
           // StopCoroutine("")  //关闭协程 参数只能用字符串
            score -= 15;
            Debug.Log(score);
        }
    }
 //协程
 IEnumerator back()
    {
       
        yield return new WaitForSeconds(2f);
        transform.parent.localScale = new Vector3(1.0f, 1.0f, 1.0f);
    }
    //特效预设物
    public GameObject effect;
    //生成特效的方法
    void CreateEffect(Vector3 pos)
    {
        //克隆方法 （物体 赋值坐标 旋转）
        GameObject go = Instantiate(effect, pos + new Vector3(0, 2, 0), Quaternion.identity) as GameObject;  // 默认不旋转
        Destroy(go, 0.5f);
    }
    /*private void OnTriggerStay2D(Collider2D col)
    {
        Debug.Log("Stay");
    }

    private void OnTriggerExit2D(Collider2D col)
    {
        Debug.Log("Exit");
    }*/
   
}
