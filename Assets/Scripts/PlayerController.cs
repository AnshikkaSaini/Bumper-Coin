using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float speed;
    Rigidbody rb;
    float xInput;
    float yInput;
    int score = 0;
    public int winScore;
    public GameObject WinText;
    int coinsCollected;


    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }


    // Update is called once per frame
    void Update()
    {

        if (transform.position.y < -5f)
        {
            SceneManager.LoadScene("Game");

        }
    }

    private void FixedUpdate()
    {
        xInput = Input.GetAxis("Horizontal");
        yInput = Input.GetAxis("Vertical");


        rb.AddForce(xInput * speed, 0, yInput * speed);


    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("coin")) // Better way to check tags
        {
            coinsCollected++;
            Destroy(other.gameObject); // Destroy the coin object

            if (coinsCollected >= winScore && WinText != null)
            {
                WinText.SetActive(true); // Display win message
            }
        }
    }

}
