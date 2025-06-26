using Unity.VisualScripting;
using UnityEngine;

public class Les3 : MonoBehaviour
{
    private int score = 0;
    [SerializeField] private float timeLeft = 5f;

    [SerializeField] private float speed = 0.5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;
        transform.position += new Vector3 (Input.GetAxis("Horizontal")*speed, 0f, 0f);
        //transform.rotation = transform.position + new Vector3(3f, 3f, 3f);
        if (timeLeft <= 0 && score < 30) 
        {
            Debug.Log("game over :(");
        }
        else if (timeLeft <= 0)
        {
            Debug.Log("omg");
        }
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("teehee");
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("yay");
        if (other.CompareTag("PickUp"))
        {
            Destroy(other.gameObject);
            Debug.Log("Pickupbam");
            score += 10;
            Debug.Log("yippeescore");
        }
    }
}
