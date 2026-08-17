using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float timeToWait = 2f;

    MeshRenderer myMeshRenderer;
    Rigidbody myRigiBody;
    void Start()
    {
        myMeshRenderer = GetComponent<MeshRenderer>();
        myRigiBody = GetComponent<Rigidbody>();

        myMeshRenderer.enabled = false;
        myRigiBody.useGravity = false;
    }

    void Update()
    {
        if(Time.time > timeToWait)
        {
            myMeshRenderer.enabled = true;
            myRigiBody.useGravity = true;
        }
    }
}
