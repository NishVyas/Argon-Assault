using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControls : MonoBehaviour
{
    [SerializeField] InputAction movement;

    void OnEnable() {
        movement.Enable();
    }

    void OnDisable() {
        movement.Disable();
    }

    void Update()
    {
        float xThrow = movement.ReadValue<Vector2>().x;
        Debug.Log(xThrow);

        float yThrow = movement.ReadValue<Vector2>().y;
        Debug.Log(yThrow);

        float xOffset = .1f;
        float newXPos = transform.localPosition.x + xOffset;

        transform.localPosition = new Vector3(
            newXPos, 
            transform.localPosition.y,
            transform.localPosition.z);
    }
}
