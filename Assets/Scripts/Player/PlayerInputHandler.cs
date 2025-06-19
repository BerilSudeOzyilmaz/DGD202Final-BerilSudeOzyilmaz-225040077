using UnityEngine;
using UnityEngine.InputSystem;  // Yeni input sistemi i�in �art

public class PlayerInputHandler : MonoBehaviour
{
    private PlayerInputActions inputActions;
    private PlayerMover mover;

    private void Awake()
    {
        inputActions = new PlayerInputActions(); // Input sistemi dosyandan s�n�f �retildi
        mover = GetComponent<PlayerMover>();     // Ayn� GameObject'teki PlayerMover script'ini bul
    }

    private void OnEnable()
    {
        inputActions.Enable();  // Input sistemi a��l�r
    }

    private void OnDisable()
    {
        inputActions.Disable(); // Oyun durursa input kapat�l�r
    }

    void Update()
    {
        Vector2 movement = inputActions.Player.Move.ReadValue<Vector2>(); // Klavye input'u al�n�r
        mover.Move(movement); // PlayerMover script'iyle hareket sa�lan�r
    }
}
