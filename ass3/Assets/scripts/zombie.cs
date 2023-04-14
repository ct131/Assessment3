using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombie : MonoBehaviour
{
    public GameObject target;
    public int speed = 1;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 计算方向向量
        Vector3 direction = target.transform.position - transform.position;

        // 让敌人面向目标对象
        transform.LookAt(target.transform);

        // 移动敌人向目标对象方向
        transform.Translate(direction.normalized * Time.deltaTime * speed);

        if (direction.magnitude <= 1)
        {
            // 设置人物的红色材质
           
            // 将人物标记为已经被捉住
            target.GetComponent<controller>().isCaught = true;
            
        }
    }
}
