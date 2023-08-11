using UnityEngine;

public class circularMovement : MonoBehaviour
{
    public float timeForOneCircle = 4f;
    public float radius = 5f;
    private float angle = 0;
    public float force;
    public CharacterController controller;
    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }
    void Update()
    {
        angle += (2 * Mathf.PI * (1 / timeForOneCircle)) * Time.deltaTime;
        Vector3 movement = new Vector3(Mathf.Cos(angle) * radius,transform.localPosition.y, Mathf.Sin(angle) * radius);
        Vector3 tangent = Vector3.Cross(movement,Vector3.up).normalized;
        transform.forward=tangent;
        transform.right=-transform.forward;
        controller.SimpleMove(tangent*force);
    }
}
