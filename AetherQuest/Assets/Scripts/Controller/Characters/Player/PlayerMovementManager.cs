using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementManager : MonoBehaviour
{
    [SerializeField] private VariableJoystick variableJoystick;
    private CharacterController characterController;
    private Player player;
    private void Awake() {
        characterController = GetComponent<CharacterController>();
        player = new Player();
    }
    // Start is called before the first frame update
    void Start()
    {
        if(player == null || characterController == null || variableJoystick == null)
        {
            Debug.LogError("Player or CharacterController or VariableJoystick is null");
            return;
        }
        Debug.Log("Player Name: " + player.Name);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate() {
        Vector3 direction = new Vector3(variableJoystick.Horizontal, 0, variableJoystick.Vertical);
        characterController.Move(direction * player.Speed * Time.deltaTime);
        Debug.Log(direction);
        if(direction != Vector3.zero)
        {
            transform.rotation = Quaternion.LookRotation(direction);
        }
    }
}
