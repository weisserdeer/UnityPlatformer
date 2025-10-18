using UnityEngine;
using UnityEngine.InputSystem;

public class HeroInputReader : MonoBehaviour
{
    [SerializeField] private Hero _hero;

    public void OnHorizontalMovement(InputAction.CallbackContext context)
    {
        var xdirection = context.ReadValue<float>();
        _hero.SetXDirection(xdirection);
    }
    public void OnVerticalMovement(InputAction.CallbackContext context)
    {        
        var ydirection = context.ReadValue<float>();
        _hero.SetYDirection(ydirection);
    }

    public void OnSaySomething(InputAction.CallbackContext context)
    {
        if (context.canceled)
        {
            _hero.SaySomething();
        }
    }
}
