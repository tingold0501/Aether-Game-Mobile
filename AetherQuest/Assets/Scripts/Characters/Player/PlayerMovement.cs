using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float walkSpeed = 5f;
    public float runSpeed = 8f;
    public float stamina = 100f;
    public float staminaDecreaseRate = 10f;
    public float staminaRecoveryRate = 5f;

    private CharacterController controller;
    private float currentSpeed;
    private bool isRunning = false;

    void Start()
    {
        controller = GetComponent<CharacterController>();
        currentSpeed = walkSpeed;
    }

    void Update()
    {
        // Xử lý input di chuyển
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;

        // Xử lý chạy nhanh
        if (Input.GetKey(KeyCode.LeftShift) && stamina > 0)
        {
            isRunning = true;
            currentSpeed = runSpeed;
            stamina -= staminaDecreaseRate * Time.deltaTime;
        }
        else
        {
            isRunning = false;
            currentSpeed = walkSpeed;
            stamina = Mathf.Min(stamina + staminaRecoveryRate * Time.deltaTime, 100f);
        }

        // Di chuyển nhân vật
        if (direction.magnitude >= 0.1f)
        {
            controller.Move(direction * currentSpeed * Time.deltaTime);
        }
    }
}
