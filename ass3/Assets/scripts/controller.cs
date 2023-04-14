using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class controller : MonoBehaviour
{
    private CharacterController _character;
    private Animator _animator;
    private Vector3 _MoveDirection = Vector3.zero;
    public bool isCaught = false;
    public GameObject gameOverUI;
    public int speed = 2;
    // �Ѿ��Ե��Ľ������
    public int count = 0;
    public string clock;
    

    // ��Ϸʤ����UI����
    public GameObject winUI;
    // Start is called before the first frame update
    void Start()
    {
        _character = GetComponent<CharacterController>();
        _animator = GetComponent<Animator>();
        gameOverUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");

        float vertical = Input.GetAxis("Vertical");

        Vector3 dir = new Vector3(horizontal, 0, vertical);
        
        if (dir != Vector3.zero)
        {
            transform.rotation = Quaternion.LookRotation(dir);

            _animator.SetBool("isRun", true);

            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
        else
        {
            _animator.SetBool("isRun",false);
        }

        if (isCaught)
        {
            Time.timeScale = 0;
            gameOverUI.SetActive(true);

        }

    }

    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag(clock))
        {
            // �Ե�һ����ң����¼����������ؽ��
            other.gameObject.SetActive(false);
            count++;

            // �������10����ң�����ʾ��Ϸʤ��
            if (count >= 2)
            {
                ShowWinUI();
            }
        }
    }

    void ShowWinUI()
    {
        // ������Ϸʤ����UI����
        Time.timeScale = 0;
        winUI.SetActive(true);
    }


}
