using UnityEngine;
using System.Collections;

public class bird_move : MonoBehaviour {
    public float birdspeed = 5;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        
       /* if (transform.position.x <-11)
        {
           
            
            if(transform.rotation.y > 100)      //移动位置 旋转速度 update
            {
                print("111");
                transform.Translate(Vector3.right * Time.deltaTime * birdspeed);
                
                
            }
            else
            {
                transform.Rotate(Vector3.up, Time.deltaTime * 50, Space.World);

            }
            

             transform.position = new Vector3(11, 4, 0);
        }*/
       
       
         transform.Translate(Vector3.left * Time.deltaTime * birdspeed);
       
        if(transform.position.x<-7)     //运动方向没有变 只是转变方向
        {
            //transform.Rotate()
            transform.Rotate(Vector3.up, Time.deltaTime * 200);
        }
        if (transform.position.x >= 7.5)
        {
            //transform.Rotate()
            transform.Rotate(Vector3.up, Time.deltaTime * 200);
        }
    }
}
