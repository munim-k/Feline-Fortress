using UnityEngine;

public class movemouse : MonoBehaviour
{
    public float timeForOneCircle = 4f;
    public float radius = 5f;
    private float angle = 0;
    public float portalAngle = 0;
    public float force;
    private CharacterController controller;
    public Vector3 directionForPortal;
    
    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }
    void Update()
    {
        angle += (2 * Mathf.PI * (1 / timeForOneCircle)) * Time.deltaTime;
        portalAngle = angle;
        Vector3 movement = new Vector3(Mathf.Cos(angle) *
radius, transform.localPosition.y, Mathf.Sin(angle) * radius);
        Vector3 tangent = Vector3.Cross(movement, Vector3.up).normalized;
        transform.forward = tangent;
        transform.right = -transform.forward;
        controller.SimpleMove(tangent * force);
        directionForPortal = tangent;
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Enter"))
        {
            transform.position = new
Vector3(transform.position.x,
other.transform.Find("Exit").transform.position.y,
transform.position.z);
        }
        if(other.CompareTag("cheese"))
        {
            Actions.gamelost();
            Debug.Log("cheese touched");
        }
    }
}
