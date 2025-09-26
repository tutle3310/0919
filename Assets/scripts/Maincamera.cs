using UnityEngine;

public class Maincamera : MonoBehaviour
{
    [SerializeField] private float �t�� = 3.5f;
    public float rotationSpeed = 5f; // ����t�׭��v
    public bool lockY = true;        // �O�_��w Y �b


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        //�ƹ����ʨ���
        float mouseX = Input.GetAxis("Mouse X"); // �ƹ����k����
        float mouseY = Input.GetAxis("Mouse Y"); // �ƹ��W�U����

        if (lockY)
        {
            // �u�� X �b�ӱ��� Y �b��V�]���k��ʡ^
            transform.Rotate(Vector3.up, mouseX * rotationSpeed, Space.World);
        }





        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)) //���e forward z
        {
            transform.Translate(Vector3.forward * �t�� * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)) //����
        {
            transform.Translate(Vector3.back * �t�� * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) //����
        {
            transform.Translate(Vector3.left * �t�� * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) //���k
        {
            transform.Translate(Vector3.right * �t�� * Time.deltaTime);
        }

    }
}

