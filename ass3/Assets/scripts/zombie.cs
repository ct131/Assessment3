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
        // ���㷽������
        Vector3 direction = target.transform.position - transform.position;

        // �õ�������Ŀ�����
        transform.LookAt(target.transform);

        // �ƶ�������Ŀ�������
        transform.Translate(direction.normalized * Time.deltaTime * speed);

        if (direction.magnitude <= 1)
        {
            // ��������ĺ�ɫ����
           
            // ��������Ϊ�Ѿ���׽ס
            target.GetComponent<controller>().isCaught = true;
            
        }
    }
}
