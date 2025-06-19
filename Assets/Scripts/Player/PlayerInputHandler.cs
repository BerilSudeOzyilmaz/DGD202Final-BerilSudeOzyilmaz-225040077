using UnityEngine;
using UnityEngine.InputSystem;  // Yeni input sistemi için þart

public class PlayerInputHandler : MonoBehaviour
{
    private PlayerInputActions inputActions;
    private PlayerMover mover;

    private void Awake()
    {
        inputActions = new PlayerInputActions(); // Input sistemi dosyandan sýnýf üretildi
        mover = GetComponent<PlayerMover>();     // Ayný GameObject'teki PlayerMover script'ini bul
    }

    private void OnEnable()
    {
        inputActions.Enable();  // Input sistemi açýlýr
    }

    private void OnDisable()
    {
        inputActions.Disable(); // Oyun durursa input kapatýlýr
    }

    void Update()
    {
        Vector2 movement = inputActions.Player.Move.ReadValue<Vector2>(); // Klavye input'u alýnýr
        mover.Move(movement); // PlayerMover script'iyle hareket saðlanýr
    }
}
