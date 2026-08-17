 using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;


    void Start()
    {
        callDebug();
    }

    void Update()
    {
        movePlayer();
    }

    void callDebug()
    {
        Debug.Log("Welcome to the game !");
    }

    void movePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float yValue = 0f;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;

        transform.Translate(xValue, yValue, zValue);
    }
}
