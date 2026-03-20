using UnityEngine;

public class MoveLeftExam03 : MonoBehaviour
{
    public float speed = 10f;

    private float leftBound = -15;

    private PlayerControllerExam03 playerController;

    void Start()
    {
        playerController = GameObject.Find("Player").GetComponent<PlayerControllerExam03>();
    }

    void Update()
    {
        if (!playerController.gameOver)
        {
            float currentSpeed = speed;

            if (playerController.isDashing)
            {
                currentSpeed = speed * 2f;
            }

            transform.Translate(Vector3.left * Time.deltaTime * currentSpeed);
        }

        if (transform.position.x < leftBound && gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }
    }
}