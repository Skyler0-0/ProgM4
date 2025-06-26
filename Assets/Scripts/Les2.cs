using UnityEngine;
using UnityEngine.InputSystem.Controls;

public class Les2 : MonoBehaviour
{
    [SerializeField] private float speed = 50f;
    private Rigidbody rb;
    private bool isOnFloor = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        transform.position = new Vector3(0f, 1.3f, 0f);
        transform.rotation =  Quaternion.Euler(0f, 45f, 0f);
        transform.localScale = Vector3.one * 1.5f;
    }
    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + transform.forward * speed * Time.deltaTime * Input.GetAxis("Vertical");
        transform.Rotate(Vector3.up, 0.5f * Input.GetAxis("Horizontal"));
        if (Input.GetKeyDown(KeyCode.Space) && isOnFloor)
        {
            rb.AddForce(Vector3.up * 300f, ForceMode.Force);
            isOnFloor = false;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Floor"))
        {
            isOnFloor = true;
        }
    }
}
